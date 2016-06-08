Imports System.ComponentModel

Public Class AccountForm

    Private _MaxQueryCount As Integer = 5
    Private Enum queryENUM
        READ_ALL
        READ
        INSERT
        UPDATE
        DELETE
    End Enum
    Private _SQL(_MaxQueryCount) As String

    Private _FirstSW As Boolean = True
    Private _AddSW As Boolean = False
    Private _UpdateSW As Boolean = False
    Private _ChangedSW As Boolean = False

    Private _Conn1 As SqlConnection = Nothing
    Private _Conn2 As SqlConnection = Nothing

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Assign queries to use in this class
        _SQL(queryENUM.READ_ALL) = "
            SELECT AccountCode, AccountName
                FROM Tbl_Account 
                WHERE AccountYear = @AccountYear ORDER BY AccountCode
            "
        _SQL(queryENUM.READ) = "
            Select * FROM Tbl_Account 
                WHERE AccountYear = @AccountYear AND AccountCode = @AccountCode
            "
        _SQL(queryENUM.INSERT) = "
            INSERT INTO Tbl_Account ( [AccountYear],[AccountCode],[LastYearCode],[Division],
                [AccountName],[AccountNameKr],[IsComputed],[ParentCode],[Remark] ) 
            VALUES ( @AccountYear, @AccountCode, @LastYearCode, @Division, @AccountName, 
                @AccountNameKr, @IsComputed, @ParentCode, @Remark )
            "
        _SQL(queryENUM.UPDATE) = "
            UPDATE Tbl_Account Set [LastYearCode] = @LastYearCode, [Division] = @Division, 
                [AccountName] = @AccountName, [AccountNameKr] = @AccountNameKr, 
                [IsComputed] = @IsComputed, [ParentCode] = @ParentCode,  
                [Remark] = @Remark
            WHERE AccountYear = @AccountYear AND AccountCode = @AccountCode
            "
        _SQL(queryENUM.DELETE) = "
            DELETE FROM Tbl_Account 
            WHERE AccountYear = @AccountYear AND AccountCode = @AccountCode
            "
        ' Add any initialization after the InitializeComponent() call.
        _Conn1 = New SqlConnection(My.Settings.DbConn)
        _Conn1.Open()
        _Conn2 = New SqlConnection(My.Settings.DbConn)
        _Conn2.Open()

    End Sub

    Protected Overrides Sub Finalize()
        _Conn1.Close()
        _Conn2.Close()
        MyBase.Finalize()
    End Sub

    Private Sub AccountForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        checkChangedField()
    End Sub

    Private Sub AccountForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If _FirstSW = True Then
            fillComboData()
            cboYear.SelectedItem = Year(Now()).ToString
            'fillGrid()
            _FirstSW = False
        End If
    End Sub

    Private Sub menuButtons_Click(sender As Object, e As EventArgs) Handles newTSB.Click, deleteTSB.Click,
        firstTSB.Click, previousTSB.Click, nextTSB.Click, lastTSB.Click, refreshTSB.Click, saveTSB.Click,
        closeTSB.Click

        If sender.Name <> "saveTSB" Then
            checkChangedField()
        End If

        Select Case sender.Name
            Case "newTSB"
                clearAllFields()
                createKeyField()
            Case "deleteTSB" : deleteCurrentRecord()
            Case "firstTSB"
                grdNavi.CurrentCell = grdNavi(0, 0)
            Case "previousTSB"
                If grdNavi.CurrentRow.Index > 0 Then
                    grdNavi.CurrentCell = grdNavi(0, grdNavi.CurrentRow.Index - 1)
                End If
            Case "nextTSB"
                If grdNavi.CurrentRow.Index < grdNavi.RowCount - 1 Then
                    grdNavi.CurrentCell = grdNavi(0, grdNavi.CurrentRow.Index + 1)
                End If
            Case "lastTSB" : grdNavi.CurrentCell = grdNavi(0, grdNavi.RowCount - 1)
            Case "refreshTSB" : fillGrid()
            Case "saveTSB" : saveCurrentRecord()
            Case "closeTSB" : Close()
        End Select
    End Sub

    Private Sub cboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYear.SelectedIndexChanged
        checkChangedField()
        fillGrid()
    End Sub

    Private Sub grdNavi_CurrentCellChanged(sender As Object, e As EventArgs) Handles grdNavi.CurrentCellChanged
        checkChangedField()
        If grdNavi.SelectedRows.Count <> 1 Then Return

        Dim index As Integer = grdNavi.SelectedRows(0).Index
        If grdNavi.SelectedRows.Count = 1 And index <= grdNavi.Rows.Count - 1 And _FirstSW = False Then
            fillData(grdNavi("AccountCode", index).Value)
        End If
    End Sub

    Private Sub control_GotFocus(sender As Object, e As EventArgs) Handles txtAccountCode.GotFocus,
        txtAccountName.GotFocus, txtAccountNameKr.GotFocus, txtRemark.GotFocus
        sender.SelectAll()
    End Sub

    Private Sub control_Changed(sender As Object, e As EventArgs) Handles txtLastYearCode.TextChanged,
        rdoExpense.CheckedChanged, rdoIncome.CheckedChanged, txtAccountName.TextChanged,
        txtAccountNameKr.TextChanged, chkIsComputed.CheckedChanged, txtParentCode.TextChanged, txtRemark.TextChanged

        If _AddSW = True Or _UpdateSW = True Then
            _ChangedSW = True
            saveTSB.Enabled = True
        End If
        If TypeOf sender Is TextBox Or TypeOf sender Is MaskedTextBox Then
            If String.IsNullOrWhiteSpace(sender.Text) Then Exit Sub
            If sender.Name = "txtLastYearCode" Then
                getLastYearName(sender.Text)
            ElseIf sender.Name = "txtParentCode" Then
                getParentName(sender.Text)
            End If
        End If
    End Sub

    Private Sub control_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAccountCode.KeyDown,
        txtAccountName.KeyDown, txtAccountNameKr.KeyDown, chkIsComputed.KeyDown
        ' maleRB.KeyDown, femaleRB.KeyDown, findBN.KeyDown, addressTB.KeyDown, remarkTB.KeyDown 
        Dim nextControl As Control
        If e.KeyCode = Keys.Enter Then
            nextControl = GetNextControl(sender, True)
            If nextControl Is Nothing Then
                nextControl = GetNextControl(Nothing, True)
            End If
            nextControl.Focus()
            e.SuppressKeyPress = True   'This will prevent ding sound.
        End If
    End Sub

    Private Sub txtAccountCode_Validating(sender As Object, e As CancelEventArgs) Handles txtAccountCode.Validating
        If _AddSW = False Then Exit Sub

        If txtAccountCode.Text.Length = 4 Then
            Dim cmd As New SqlCommand(_SQL(queryENUM.READ), _Conn1)
            cmd.Parameters.Add("@AccountYear", SqlDbType.Char)
            cmd.Parameters.Add("@AccountCode", SqlDbType.Char)
            cmd.Parameters("@AccountYear").Value = txtAccountYear.Text
            cmd.Parameters("@AccountCode").Value = txtAccountCode.Text
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                MessageBox.Show("The code has already used. Use an another code!",
                "Duplicated code", MessageBoxButtons.OK)
                txtAccountCode.Focus()
                e.Cancel = True
            End If
            reader.Close()
        Else
            MessageBox.Show("The length Of the code should be 4. Re-enter!",
                "Wrong code", MessageBoxButtons.OK)
            txtAccountCode.Focus()
            e.Cancel = True
        End If
    End Sub

    Private Sub btnFindYear_Click(sender As Object, e As EventArgs) Handles btnFindYear.Click
        Dim findAccountForm As FindAccountForm = New FindAccountForm((Convert.ToInt32(txtAccountYear.Text) - 1).ToString("0000"), True)
        Dim result As DialogResult = findAccountForm.ShowDialog()
        If result = vbOK Then
            _ChangedSW = True
            txtLastYearCode.Text = findAccountForm.accountCode
            lblLastYearName.Text = getLastYearName(txtLastYearCode.Text)
            rdoExpense.Focus()
        End If
    End Sub

    Private Sub btnFindParent_Click(sender As Object, e As EventArgs) Handles btnFindParent.Click
        Dim findAccountForm As FindAccountForm = New FindAccountForm(txtAccountYear.Text, True)
        Dim result As DialogResult = findAccountForm.ShowDialog()
        If result = vbOK Then
            _ChangedSW = True
            txtParentCode.Text = findAccountForm.accountCode
            lblParentName.Text = getParentName(txtParentCode.Text)
            rdoExpense.Focus()
        End If
    End Sub

    Private Sub checkChangedField()
        If (_AddSW = True Or _UpdateSW = True) And _ChangedSW = True Then
            Dim result As DialogResult = MessageBox.Show("There are some changed data. Save it?",
                "Confirmation To save", MessageBoxButtons.YesNo)
            If result = vbYes Then
                saveCurrentRecord()
            Else
                _AddSW = False
                _UpdateSW = False
                _ChangedSW = False
            End If
        End If
    End Sub

    Private Sub enableAllToolStripButton(ByVal status As Boolean)
        For Each menu As ToolStripItem In menuTS.Items
            If TypeOf menu Is ToolStripButton And menu.Name <> "closeTSB" Then
                menu.Enabled = status
            End If
        Next
    End Sub

    Private Sub fillComboData()
        For index As Integer = 2016 To 2100 Step 1
            cboYear.Items.Add(index.ToString)
        Next
    End Sub

    Private Sub fillGrid()
        Dim cmd As New SqlCommand(_SQL(queryENUM.READ_ALL), _Conn1)
        cmd.Parameters.Add("@AccountYear", SqlDbType.Char)
        cmd.Parameters("@AccountYear").Value = cboYear.SelectedItem

        Me.Cursor = Cursors.WaitCursor
        grdNavi.RowCount = 0

        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                grdNavi.Rows.Add(reader("AccountCode"), reader("AccountName"))
            End While
            reader.Close()
            grdNavi.CurrentCell = grdNavi(0, grdNavi.RowCount - 1)
            fillData(grdNavi("AccountCode", grdNavi.CurrentRow.Index).Value)
            enableAllToolStripButton(True)
            saveTSB.Enabled = False
        Else
            reader.Close()
            clearAllFields()
            enableAllToolStripButton(False)
            newTSB.Enabled = True
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub fillData(ByVal code As String)
        Dim cmd As New SqlCommand(_SQL(queryENUM.READ), _Conn1)
        cmd.Parameters.Add("@AccountYear", SqlDbType.Char)
        cmd.Parameters.Add("@AccountCode", SqlDbType.Char)
        cmd.Parameters("@AccountYear").Value = cboYear.SelectedItem
        cmd.Parameters("@AccountCode").Value = code
        Dim rdr As SqlDataReader = cmd.ExecuteReader()

        If rdr.HasRows Then
            rdr.Read()
            txtAccountYear.Text = rdr("AccountYear")
            txtAccountYear.BackColor = SystemColors.InactiveCaption
            txtAccountYear.ReadOnly = True
            txtAccountCode.Text = rdr("AccountCode")
            txtAccountCode.BackColor = SystemColors.InactiveCaption
            txtAccountCode.ReadOnly = True
            txtLastYearCode.Text = rdr("LastYearCode")
            If rdr("Division") = "E" Then rdoExpense.Checked = True Else rdoIncome.Checked = True
            txtAccountName.Text = IIf(IsDBNull(rdr("AccountName")), "", rdr("AccountName"))
            txtAccountNameKr.Text = IIf(IsDBNull(rdr("AccountNameKr")), "", rdr("AccountNameKr"))
            chkIsComputed.Checked = IIf(rdr("IsComputed") = "Y", True, False)
            txtParentCode.Text = IIf(IsDBNull(rdr("ParentCode")), "", rdr("ParentCode"))
            txtRemark.Text = IIf(IsDBNull(rdr("Remark")), "", rdr("Remark"))

            rdr.Close()

            lblLastYearName.Text = getLastYearName(txtLastYearCode.Text)
            lblParentName.Text = getParentName(txtParentCode.Text)
        Else
            rdr.Close()
        End If

        _UpdateSW = True
        _ChangedSW = False
        _AddSW = False

        newTSB.Enabled = True
        saveTSB.Enabled = False
        deleteTSB.Enabled = True

        btnFindYear.Focus()

    End Sub

    Private Sub clearAllFields()
        txtAccountYear.Text = cboYear.SelectedItem
        txtAccountCode.Text = ""
        txtLastYearCode.Text = ""
        rdoExpense.Checked = True
        txtAccountName.Text = ""
        txtAccountNameKr.Text = ""
        chkIsComputed.Checked = False
        txtParentCode.Text = ""
        txtRemark.Text = ""

        lblLastYearName.Text = ""
        lblParentName.Text = ""

        _AddSW = True
        _ChangedSW = False

        newTSB.Enabled = False
        saveTSB.Enabled = False
        deleteTSB.Enabled = False
    End Sub

    Private Sub createKeyField()
        txtAccountCode.Text = ""
        txtAccountCode.ReadOnly = False
        txtAccountCode.BackColor = SystemColors.Window
        txtAccountCode.Focus()
    End Sub

    Private Sub saveCurrentRecord()
        If _AddSW = True Then
            Dim cmd As New SqlCommand(_SQL(queryENUM.INSERT), _Conn1)
            parameterMove(cmd)
            _AddSW = False
            _ChangedSW = False

            newTSB.Enabled = True
            deleteTSB.Enabled = True
            saveTSB.Enabled = False

            grdNavi.Rows.Add(txtAccountCode.Text, txtAccountName.Text)
            grdNavi.CurrentCell = grdNavi(0, grdNavi.RowCount - 1)
        Else
            Dim cmd As New SqlCommand(_SQL(queryENUM.UPDATE), _Conn1)
            parameterMove(cmd)
            _UpdateSW = True
            _ChangedSW = False

            newTSB.Enabled = True
            deleteTSB.Enabled = True
            saveTSB.Enabled = False

            grdNavi(1, grdNavi.CurrentRow.Index).Value = txtAccountName.Text
        End If
    End Sub

    Private Sub parameterMove(ByVal cmd As SqlCommand)
        cmd.Parameters.Add("@AccountYear", SqlDbType.Char)
        cmd.Parameters.Add("@AccountCode", SqlDbType.Char)
        cmd.Parameters.Add("@LastYearCode", SqlDbType.Char)
        cmd.Parameters.Add("@Division", SqlDbType.Char)
        cmd.Parameters.Add("@AccountName", SqlDbType.VarChar)
        cmd.Parameters.Add("@AccountNameKr", SqlDbType.VarChar)
        cmd.Parameters.Add("@IsComputed", SqlDbType.Char)
        cmd.Parameters.Add("@ParentCode", SqlDbType.Char)
        cmd.Parameters.Add("@Remark", SqlDbType.VarChar)

        cmd.Parameters("@AccountYear").Value = txtAccountYear.Text
        cmd.Parameters("@AccountCode").Value = txtAccountCode.Text
        cmd.Parameters("@LastYearCode").Value = txtLastYearCode.Text
        cmd.Parameters("@Division").Value = IIf(rdoIncome.Checked = True, "I", "E")
        cmd.Parameters("@AccountName").Value = txtAccountName.Text
        cmd.Parameters("@AccountNameKr").Value = txtAccountNameKr.Text
        cmd.Parameters("@IsComputed").Value = IIf(chkIsComputed.Checked = True, "Y", "N")
        cmd.Parameters("@ParentCode").Value = IIf(String.IsNullOrWhiteSpace(txtParentCode.Text), DBNull.Value, txtParentCode.Text)
        cmd.Parameters("@Remark").Value = IIf(String.IsNullOrWhiteSpace(txtRemark.Text), DBNull.Value, txtRemark.Text)

        cmd.ExecuteNonQuery()
    End Sub

    Private Sub deleteCurrentRecord()
        Dim result As DialogResult = MessageBox.Show("Deleted data can't be recovered. Delete it?",
                "Confirmation to delete", MessageBoxButtons.YesNo)
        If result = vbNo Then Exit Sub

        Dim cmd As New SqlCommand(_SQL(queryENUM.DELETE), _Conn1)
        cmd.Parameters.Add("@AccountYear", SqlDbType.Char)
        cmd.Parameters.Add("@AccountCode", SqlDbType.Char)
        cmd.Parameters("@AccountYear").Value = txtAccountYear.Text
        cmd.Parameters("@AccountCode").Value = txtAccountCode.Text

        cmd.ExecuteNonQuery()

        Dim saveCurrentRow = grdNavi.CurrentRow.Index
        grdNavi.Rows.RemoveAt(saveCurrentRow)
        If grdNavi.RowCount < 1 Then
            clearAllFields()
            _AddSW = False
            _UpdateSW = False
            enableAllToolStripButton(False)
            newTSB.Enabled = True
        ElseIf saveCurrentRow > grdNavi.RowCount - 1 Then
            grdNavi.CurrentCell = grdNavi(0, grdNavi.RowCount - 1)
            fillData(grdNavi("AccountCode", grdNavi.CurrentRow.Index).Value)
        Else
            grdNavi.CurrentCell = grdNavi(0, saveCurrentRow)
            fillData(grdNavi("AccountCode", grdNavi.CurrentRow.Index).Value)
        End If

    End Sub

    Private Function getLastYearName(ByVal code As String) As String
        Dim cmd As New SqlCommand(_SQL(queryENUM.READ), _Conn2)
        cmd.Parameters.Add("@AccountYear", SqlDbType.Char)
        cmd.Parameters.Add("@AccountCode", SqlDbType.Char)
        cmd.Parameters("@AccountYear").Value = (Convert.ToInt32(txtAccountYear.Text) - 1).ToString("0000")
        cmd.Parameters("@AccountCode").Value = code
        Dim rdr As SqlDataReader = cmd.ExecuteReader()

        If rdr.HasRows Then
            rdr.Read()
            Dim kn = rdr("AccountName")
            rdr.Close()
            Return kn
        Else
            rdr.Close()
            Return ""
        End If
    End Function

    Private Function getParentName(ByVal code As String) As String
        Dim cmd As New SqlCommand(_SQL(queryENUM.READ), _Conn2)
        cmd.Parameters.Add("@AccountYear", SqlDbType.Char)
        cmd.Parameters.Add("@AccountCode", SqlDbType.Char)
        cmd.Parameters("@AccountYear").Value = txtAccountYear.Text
        cmd.Parameters("@AccountCode").Value = code
        Dim rdr As SqlDataReader = cmd.ExecuteReader()

        If rdr.HasRows Then
            rdr.Read()
            Dim kn = rdr("AccountName")
            rdr.Close()
            Return kn
        Else
            rdr.Close()
            Return ""
        End If
    End Function

End Class
