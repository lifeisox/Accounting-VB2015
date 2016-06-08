Imports System.ComponentModel

Public Class BookCodeForm

    Private _MaxQueryCount As Integer = 6
    Private Enum queryENUM
        READ_ALL
        READ
        INSERT
        UPDATE
        DELETE
        READ_AVAILABLE_CODE 'Find the available minimum Code in the Table
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
            SELECT BookCode, BookName
                FROM Tbl_Book 
                WHERE BookYear = @BookYear ORDER BY BookCode
            "
        _SQL(queryENUM.READ) = "
            Select * FROM Tbl_Book 
                WHERE BookYear = @BookYear AND BookCode = @BookCode
            "
        _SQL(queryENUM.INSERT) = "
            INSERT INTO Tbl_Book ( [BookYear],[BookCode],[BookName],[BookNameKr],[ForwardAmount] ) 
            VALUES ( @BookYear, @BookCode, @BookName, @BookNameKr, @ForwardAmount )
            "
        _SQL(queryENUM.UPDATE) = "
            UPDATE Tbl_Book Set [BookName] = @BookName, [BookNameKr] = @BookNameKr, 
                [ForwardAmount] = @ForwardAmount
            WHERE BookYear = @BookYear AND BookCode = @BookCode
            "
        _SQL(queryENUM.DELETE) = "
            DELETE FROM Tbl_Book 
            WHERE BookYear = @BookYear AND BookCode = @BookCode
            "
        _SQL(queryENUM.READ_AVAILABLE_CODE) = "
            SELECT MIN(BookCode + 1) FROM Tbl_Book 
            WHERE BookYear = @BookYear AND (BookCode + 1) 
                NOT IN (SELECT BookCode FROM Tbl_Book WHERE BookYear = @BookYear)
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

    Private Sub BookCodeForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        checkChangedField()
    End Sub

    Private Sub BookCodeForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
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
            fillData(grdNavi("BookCode", index).Value)
        End If
    End Sub

    Private Sub control_GotFocus(sender As Object, e As EventArgs) Handles txtBookCode.GotFocus,
        txtBookNameKr.GotFocus, txtBookName.GotFocus, txtForwardAmount.GotFocus
        sender.Select(0, sender.Text.Length)
    End Sub

    Private Sub control_Changed(sender As Object, e As EventArgs) Handles txtBookName.TextChanged,
        txtBookNameKr.TextChanged, txtForwardAmount.TextChanged

        If _AddSW = True Or _UpdateSW = True Then
            _ChangedSW = True
            saveTSB.Enabled = True
        End If
    End Sub

    Private Sub control_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBookNameKr.KeyDown,
        txtBookName.KeyDown, txtBookCode.KeyDown, txtForwardAmount.KeyDown
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

    Private Sub txtBookCode_Validating(sender As Object, e As CancelEventArgs) Handles txtBookCode.Validating
        If _AddSW = False Then Exit Sub

        If txtBookCode.Text.Length = 4 Then
            Dim cmd As New SqlCommand(_SQL(queryENUM.READ), _Conn1)
            cmd.Parameters.Add("@BookYear", SqlDbType.Char)
            cmd.Parameters.Add("@BookCode", SqlDbType.Char)
            cmd.Parameters("@BookYear").Value = txtBookYear.Text
            cmd.Parameters("@BookCode").Value = txtBookCode.Text
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                MessageBox.Show("The code has already used. Use an another code!",
                "Duplicated code", MessageBoxButtons.OK)
                txtBookCode.Focus()
                e.Cancel = True
            End If
            reader.Close()
        Else
            MessageBox.Show("The length Of the code should be 4. Re-enter!",
                "Wrong code", MessageBoxButtons.OK)
            txtBookCode.Focus()
            e.Cancel = True
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
        cmd.Parameters.Add("@BookYear", SqlDbType.Char)
        cmd.Parameters("@BookYear").Value = cboYear.SelectedItem

        Me.Cursor = Cursors.WaitCursor
        grdNavi.RowCount = 0

        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                grdNavi.Rows.Add(reader("BookCode"), reader("BookName"))
            End While
            reader.Close()
            grdNavi.CurrentCell = grdNavi(0, grdNavi.RowCount - 1)
            fillData(grdNavi("BookCode", grdNavi.CurrentRow.Index).Value)
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
        cmd.Parameters.Add("@BookYear", SqlDbType.Char)
        cmd.Parameters.Add("@BookCode", SqlDbType.Char)
        cmd.Parameters("@BookYear").Value = cboYear.SelectedItem
        cmd.Parameters("@BookCode").Value = code
        Dim rdr As SqlDataReader = cmd.ExecuteReader()

        If rdr.HasRows Then
            rdr.Read()
            txtBookYear.Text = rdr("BookYear")
            txtBookYear.BackColor = SystemColors.InactiveCaption
            txtBookYear.ReadOnly = True
            txtBookCode.Text = rdr("BookCode")
            txtBookCode.BackColor = SystemColors.InactiveCaption
            txtBookCode.ReadOnly = True
            txtBookName.Text = IIf(IsDBNull(rdr("BookName")), "", rdr("BookName"))
            txtBookNameKr.Text = IIf(IsDBNull(rdr("BookNameKr")), "", rdr("BookNameKr"))
            txtForwardAmount.Text = rdr("ForwardAmount")

            rdr.Close()
        Else
            rdr.Close()
        End If

        _UpdateSW = True
        _ChangedSW = False
        _AddSW = False

        newTSB.Enabled = True
        saveTSB.Enabled = False
        deleteTSB.Enabled = True

        txtBookName.Focus()
    End Sub

    Private Sub clearAllFields()
        txtBookYear.Text = cboYear.SelectedItem
        txtBookCode.Text = ""
        txtBookName.Text = ""
        txtBookNameKr.Text = ""
        txtForwardAmount.Text = "0"

        _AddSW = True
        _ChangedSW = False

        newTSB.Enabled = False
        saveTSB.Enabled = False
        deleteTSB.Enabled = False
    End Sub

    Private Sub createKeyField()
        Dim tmpCode As Int32 = 0

        Dim cmd As New SqlCommand(_SQL(queryENUM.READ_AVAILABLE_CODE), _Conn1)
        cmd.Parameters.Add("@BookYear", SqlDbType.Char)
        cmd.Parameters("@BookYear").Value = cboYear.SelectedItem
        Try
            tmpCode = Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            tmpCode = 1
        Finally
            If tmpCode > 9999 Then
                MessageBox.Show("A member can't be inserted anymore!", "Full data", MessageBoxButtons.OK)
                Close()
            Else
                txtBookCode.Text = tmpCode.ToString("0000")
                txtBookCode.ReadOnly = False
                txtBookCode.BackColor = SystemColors.Window
                txtBookCode.Focus()
            End If
        End Try
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

            grdNavi.Rows.Add(txtBookCode.Text, txtBookName.Text)
            grdNavi.CurrentCell = grdNavi(0, grdNavi.RowCount - 1)
        Else
            Dim cmd As New SqlCommand(_SQL(queryENUM.UPDATE), _Conn1)
            parameterMove(cmd)
            _UpdateSW = True
            _ChangedSW = False

            newTSB.Enabled = True
            deleteTSB.Enabled = True
            saveTSB.Enabled = False

            grdNavi(1, grdNavi.CurrentRow.Index).Value = txtBookName.Text
        End If
    End Sub

    Private Sub parameterMove(ByVal cmd As SqlCommand)
        cmd.Parameters.Add("@BookYear", SqlDbType.Char)
        cmd.Parameters.Add("@BookCode", SqlDbType.Char)
        cmd.Parameters.Add("@BookName", SqlDbType.VarChar)
        cmd.Parameters.Add("@BookNameKr", SqlDbType.VarChar)
        cmd.Parameters.Add("@ForwardAmount", SqlDbType.Decimal)

        cmd.Parameters("@BookYear").Value = txtBookYear.Text
        cmd.Parameters("@BookCode").Value = txtBookCode.Text
        cmd.Parameters("@BookName").Value = txtBookName.Text
        cmd.Parameters("@BookNameKr").Value = txtBookNameKr.Text
        cmd.Parameters("@ForwardAmount").Value = txtForwardAmount.Text

        cmd.ExecuteNonQuery()
    End Sub

    Private Sub deleteCurrentRecord()
        Dim result As DialogResult = MessageBox.Show("Deleted data can't be recovered. Delete it?",
                "Confirmation to delete", MessageBoxButtons.YesNo)
        If result = vbNo Then Exit Sub

        Dim cmd As New SqlCommand(_SQL(queryENUM.DELETE), _Conn1)
        cmd.Parameters.Add("@BookYear", SqlDbType.Char)
        cmd.Parameters.Add("@BookCode", SqlDbType.Char)
        cmd.Parameters("@BookYear").Value = txtBookYear.Text
        cmd.Parameters("@BookCode").Value = txtBookCode.Text

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
            fillData(grdNavi("BookCode", grdNavi.CurrentRow.Index).Value)
        Else
            grdNavi.CurrentCell = grdNavi(0, saveCurrentRow)
            fillData(grdNavi("BookCode", grdNavi.CurrentRow.Index).Value)
        End If

    End Sub

End Class