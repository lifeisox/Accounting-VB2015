Imports System.ComponentModel

Public Class ComposeBookForm

    Private _MaxQueryCount As Integer = 3
    Private Enum queryENUM
        READ_ALL_BOOK
        READ_ALL_ACCOUNT
        READ
        UPDATE
    End Enum
    Private _SQL(_MaxQueryCount) As String

    Private _FirstSW As Boolean = True
    Private _AddSW As Boolean = False
    Private _UpdateSW As Boolean = False
    Private _ChangedSW As Boolean = False
    Private _saveCode As String

    Private _Conn1 As SqlConnection = Nothing
    Private _Conn2 As SqlConnection = Nothing

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Assign queries to use in this class
        _SQL(queryENUM.READ_ALL_BOOK) = "
            SELECT BookCode, IIF(BookNameKr IS NULL OR BookNameKr = '', BookName, 
                IIF(BookName Is NULL Or BookName = '', BookNameKr, CONCAT(BookNameKr, '(', 
                BookName, ')'))) AS ViewName
            FROM Tbl_Book 
            WHERE BookYear = @BookYear ORDER BY BookCode
            "
        _SQL(queryENUM.READ_ALL_ACCOUNT) = "
            SELECT AccountCode, Division, IIF(AccountNameKr IS NULL OR AccountNameKr = '', AccountName, 
                IIF(AccountName Is NULL Or AccountName = '', AccountNameKr, CONCAT(AccountNameKr, '(', 
                AccountName, ')'))) AS ViewName, Remark
            FROM Tbl_Account 
            WHERE AccountYear = @AccountYear AND BookCode = @BookCode
            ORDER BY AccountCode
            "
        _SQL(queryENUM.READ) = "
            SELECT AccountCode, Division, IIF(AccountNameKr IS NULL OR AccountNameKr = '', AccountName, 
                IIF(AccountName Is NULL Or AccountName = '', AccountNameKr, CONCAT(AccountNameKr, '(', 
                AccountName, ')'))) AS ViewName, Remark
            FROM Tbl_Account 
            WHERE AccountYear = @AccountYear AND AccountCode = @AccountCode
            "
        _SQL(queryENUM.UPDATE) = "
            UPDATE Tbl_Account Set [BookCode] = @BookCode
            WHERE AccountYear = @AccountYear AND AccountCode = @AccountCode
            "
        ' Add any initialization after the InitializeComponent() call.
        _Conn1 = New SqlConnection(My.Settings.DbConn)
        _Conn1.Open()
        _Conn2 = New SqlConnection(My.Settings.DbConn)
        _Conn2.Open()
        _saveCode = ""
    End Sub

    Protected Overrides Sub Finalize()
        _Conn1.Close()
        _Conn2.Close()
        MyBase.Finalize()
    End Sub

    Private Sub ComposeBookForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        checkChangedField()
    End Sub

    Private Sub ComposeBookForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
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
        If grdNavi.SelectedRows.Count <> 1 Then Exit Sub
        checkChangedField()
        Dim index As Integer = grdNavi.SelectedRows(0).Index
        If grdNavi.SelectedRows.Count = 1 And index <= grdNavi.Rows.Count - 1 And _FirstSW = False Then
            lblBookName.Text = grdNavi("BookName", index).Value
            fillGridSub(grdNavi("BookCode", index).Value)
        End If
    End Sub

    Private Sub grdSub_CurrentCellChanged(sender As Object, e As EventArgs) Handles grdSub.CurrentCellChanged
        If grdSub.SelectedRows.Count <> 1 Then Exit Sub
        checkChangedField()
        Dim index As Integer = grdSub.SelectedRows(0).Index
        If grdSub.SelectedRows.Count = 1 And index <= grdSub.Rows.Count - 1 Then
            fillData(grdSub("AccountCode", index).Value, grdSub("AccountName", index).Value)
        End If
    End Sub

    Private Sub control_Changed(sender As Object, e As EventArgs) Handles txtAccountCode.TextChanged
        If _AddSW = True Or _UpdateSW = True Then
            _ChangedSW = True
            saveTSB.Enabled = True
        End If
        If TypeOf sender Is TextBox Or TypeOf sender Is MaskedTextBox Then
            If String.IsNullOrWhiteSpace(sender.Text) Then Exit Sub
            If sender.Name = "txtAccountCode" Then
                lblAccountName.Text = getAccountName(sender.Text)
            End If
        End If
    End Sub

    Private Sub btnFindCode_Click(sender As Object, e As EventArgs) Handles btnFindCode.Click
        Dim findAccountForm As FindAccountForm = New FindAccountForm(txtBookYear.Text, False)
        Dim result As DialogResult = findAccountForm.ShowDialog()
        If result = vbOK Then
            _ChangedSW = True
            txtAccountCode.Text = findAccountForm.accountCode
            lblAccountName.Text = getAccountName(txtAccountCode.Text)
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
        Dim cmd As New SqlCommand(_SQL(queryENUM.READ_ALL_BOOK), _Conn1)
        cmd.Parameters.Add("@BookYear", SqlDbType.Char)
        cmd.Parameters("@BookYear").Value = cboYear.SelectedItem

        grdNavi.RowCount = 0
        txtBookYear.Text = cboYear.SelectedItem
        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        If rdr.HasRows Then
            While rdr.Read()
                grdNavi.Rows.Add(rdr("BookCode"), rdr("ViewName"))
            End While
            rdr.Close()
            lblBookName.Text = grdNavi("BookName", grdNavi.RowCount - 1).Value
            grdNavi.CurrentCell = grdNavi(0, grdNavi.RowCount - 1)
            fillGridSub(grdNavi("BookCode", grdNavi.CurrentRow.Index).Value)
        Else
            rdr.Close()
            MessageBox.Show("There is no Book data to compose.", "Not Existed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Close()
        End If
    End Sub

    Private Sub fillGridSub(ByVal bookCode As String)
        Dim cmd As New SqlCommand(_SQL(queryENUM.READ_ALL_ACCOUNT), _Conn1)
        cmd.Parameters.Add("@AccountYear", SqlDbType.Char)
        cmd.Parameters.Add("@BookCode", SqlDbType.Char)
        cmd.Parameters("@AccountYear").Value = cboYear.SelectedItem
        cmd.Parameters("@BookCode").Value = bookCode

        grdSub.RowCount = 0
        txtBookCode.Text = bookCode
        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        If rdr.HasRows Then
            While rdr.Read()
                grdSub.Rows.Add(rdr("AccountCode"), rdr("Division"), rdr("ViewName"), rdr("Remark"))
            End While
            rdr.Close()
            grdSub.CurrentCell = grdSub(0, grdSub.RowCount - 1)
            fillData(grdSub("AccountCode", grdSub.CurrentRow.Index).Value, grdSub("AccountName", grdSub.CurrentRow.Index).Value)
            enableAllToolStripButton(True)
            saveTSB.Enabled = False
        Else
            rdr.Close()
            clearAllFields()
            enableAllToolStripButton(False)
            newTSB.Enabled = True
            btnFindCode.Enabled = False
        End If

    End Sub

    Private Sub fillData(ByVal code As String, ByVal name As String)
        txtAccountCode.Text = code
        _saveCode = code
        lblAccountName.Text = name

        _UpdateSW = True
        _ChangedSW = False
        _AddSW = False

        newTSB.Enabled = True
        saveTSB.Enabled = False
        deleteTSB.Enabled = True
        btnFindCode.Enabled = True
    End Sub

    Private Sub clearAllFields()
        txtAccountCode.Text = ""
        _saveCode = ""
        lblAccountName.Text = ""

        _AddSW = True
        _ChangedSW = False

        newTSB.Enabled = False
        saveTSB.Enabled = False
        deleteTSB.Enabled = False
        btnFindCode.Enabled = True
    End Sub

    Private Sub createKeyField()
        btnFindCode.Focus()
    End Sub

    Private Sub saveCurrentRecord()
        Dim division As String = Nothing, name As String = Nothing, remark As String = Nothing

        If _AddSW = True Then
            insertRecord()
            _AddSW = False
            _ChangedSW = False

            newTSB.Enabled = True
            deleteTSB.Enabled = True
            saveTSB.Enabled = False

            getAccountFields(txtAccountCode.Text, division, name, remark)
            grdSub.Rows.Add(txtAccountCode.Text, division, name, remark)
            grdSub.CurrentCell = grdSub(0, grdSub.RowCount - 1)
        Else
            updateRecord()
            _UpdateSW = True
            _ChangedSW = False

            newTSB.Enabled = True
            deleteTSB.Enabled = True
            saveTSB.Enabled = False

            getAccountFields(txtAccountCode.Text, division, name, remark)
            grdSub("AccountCode", grdSub.CurrentRow.Index).Value = txtAccountCode.Text
            grdSub("Division", grdSub.CurrentRow.Index).Value = division
            grdSub("AccountName", grdSub.CurrentRow.Index).Value = name
            grdSub("Remark", grdSub.CurrentRow.Index).Value = remark
        End If
    End Sub

    Private Sub insertRecord()
        Dim cmd As New SqlCommand(_SQL(queryENUM.UPDATE), _Conn1)
        cmd.Parameters.Add("@AccountYear", SqlDbType.Char)
        cmd.Parameters.Add("@AccountCode", SqlDbType.Char)
        cmd.Parameters.Add("@BookCode", SqlDbType.Char)

        cmd.Parameters("@AccountYear").Value = txtBookYear.Text
        cmd.Parameters("@AccountCode").Value = txtAccountCode.Text
        cmd.Parameters("@BookCode").Value = txtBookCode.Text

        cmd.ExecuteNonQuery()
    End Sub

    Private Sub updateRecord()
        Dim cmd As New SqlCommand(_SQL(queryENUM.UPDATE), _Conn1)
        cmd.Parameters.Add("@AccountYear", SqlDbType.Char)
        cmd.Parameters.Add("@AccountCode", SqlDbType.Char)
        cmd.Parameters.Add("@BookCode", SqlDbType.Char)

        cmd.Parameters("@AccountYear").Value = txtBookYear.Text
        cmd.Parameters("@AccountCode").Value = _saveCode
        cmd.Parameters("@BookCode").Value = DBNull.Value

        cmd.ExecuteNonQuery()

        cmd.Parameters("@AccountYear").Value = txtBookYear.Text
        cmd.Parameters("@AccountCode").Value = txtAccountCode.Text
        cmd.Parameters("@BookCode").Value = txtBookCode.Text

        cmd.ExecuteNonQuery()
    End Sub

    Private Sub deleteCurrentRecord()
        Dim cmd As New SqlCommand(_SQL(queryENUM.UPDATE), _Conn1)
        cmd.Parameters.Add("@AccountYear", SqlDbType.Char)
        cmd.Parameters.Add("@AccountCode", SqlDbType.Char)
        cmd.Parameters.Add("@BookCode", SqlDbType.Char)
        cmd.Parameters("@AccountYear").Value = txtBookYear.Text
        cmd.Parameters("@AccountCode").Value = txtAccountCode.Text
        cmd.Parameters("@BookCode").Value = DBNull.Value

        cmd.ExecuteNonQuery()

        Dim saveCurrentRow = grdSub.CurrentRow.Index
        grdSub.Rows.RemoveAt(saveCurrentRow)
        If grdSub.RowCount < 1 Then
            clearAllFields()
            _AddSW = False
            _UpdateSW = False
            enableAllToolStripButton(False)
            newTSB.Enabled = True
            btnFindCode.Enabled = False
        ElseIf saveCurrentRow > grdSub.RowCount - 1 Then
            grdSub.CurrentCell = grdSub(0, grdSub.RowCount - 1)
            fillData(grdSub("AccountCode", grdSub.CurrentRow.Index).Value,
                     grdSub("AccountName", grdSub.CurrentRow.Index).Value)
        Else
            grdSub.CurrentCell = grdSub(0, saveCurrentRow)
            fillData(grdSub("AccountCode", grdSub.CurrentRow.Index).Value,
                     grdSub("AccountName", grdSub.CurrentRow.Index).Value)
        End If

    End Sub

    Private Function getAccountName(ByVal code As String) As String
        Dim cmd As New SqlCommand(_SQL(queryENUM.READ), _Conn2)
        cmd.Parameters.Add("@AccountYear", SqlDbType.Char)
        cmd.Parameters.Add("@AccountCode", SqlDbType.Char)
        cmd.Parameters("@AccountYear").Value = txtBookYear.Text
        cmd.Parameters("@AccountCode").Value = code
        Dim rdr As SqlDataReader = cmd.ExecuteReader()

        If rdr.HasRows Then
            rdr.Read()
            Dim kn = rdr("ViewName")
            rdr.Close()
            Return kn
        Else
            rdr.Close()
            Return ""
        End If
    End Function

    Private Sub getAccountFields(ByVal code As String, ByRef division As String, ByRef name As String,
                                 ByRef remark As String)
        Dim cmd As New SqlCommand(_SQL(queryENUM.READ), _Conn2)
        cmd.Parameters.Add("@AccountYear", SqlDbType.Char)
        cmd.Parameters.Add("@AccountCode", SqlDbType.Char)
        cmd.Parameters("@AccountYear").Value = txtBookYear.Text
        cmd.Parameters("@AccountCode").Value = code
        Dim rdr As SqlDataReader = cmd.ExecuteReader()

        If rdr.HasRows Then
            rdr.Read()
            division = rdr("Division")
            name = rdr("ViewName")
            remark = IIf(IsDBNull(rdr("Remark")), "", rdr("Remark"))
            rdr.Close()
        Else
            rdr.Close()
            division = ""
            name = ""
            remark = ""
        End If
    End Sub
End Class