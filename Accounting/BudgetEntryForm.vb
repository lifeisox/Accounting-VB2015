Imports System.ComponentModel

Public Class BudgetEntryForm
    Private _MaxQueryCount As Integer = 2
    Private Enum queryENUM
        READ_ALL_BOOK
        UPDATE
    End Enum
    Private _SQL(_MaxQueryCount) As String

    Private _FirstSW As Boolean = True
    Private _ChangedSW As Boolean = False
    Private _UpdateSW As Boolean = False

    Private _Conn1 As SqlConnection = Nothing
    Private _Conn2 As SqlConnection = Nothing

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        _SQL(queryENUM.READ_ALL_BOOK) = "
            SELECT AccountCode, IIF(AccountNameKr IS NULL OR AccountNameKr = '', AccountName, 
                IIF(AccountName Is NULL Or AccountName = '', AccountNameKr, CONCAT(AccountNameKr, '(', 
                AccountName, ')'))) AS ViewName, Budget
            FROM Tbl_Account 
            WHERE AccountYear = @AccountYear AND IsComputed = 'N' ORDER BY AccountCode
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
    End Sub

    Protected Overrides Sub Finalize()
        _Conn1.Close()
        _Conn2.Close()
        MyBase.Finalize()
    End Sub

    Private Sub BudgetEntryForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        checkChangedField()
    End Sub

    Private Sub BudgetEntryForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If _FirstSW = True Then
            fillComboData()
            cboYear.SelectedItem = Year(Now()).ToString
            fillGrid()
            _FirstSW = False
        End If
    End Sub

    Private Sub menuButtons_Click(sender As Object, e As EventArgs) Handles saveTSB.Click, closeTSB.Click

        If sender.Name <> "saveTSB" Then
            checkChangedField()
        End If

        Select Case sender.Name
            Case "saveTSB" : saveCurrentRecord()
            Case "closeTSB" : Close()
        End Select
    End Sub

    Private Sub cboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYear.SelectedIndexChanged
        checkChangedField()
        fillGrid()
    End Sub

    Private Sub grdNavi_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles grdNavi.CellValueChanged
        If _UpdateSW = True And _ChangedSW = False Then
            _ChangedSW = True
            saveTSB.Enabled = True
        End If
    End Sub

    Private Sub checkChangedField()
        If _UpdateSW = True And _ChangedSW = True Then
            Dim result As DialogResult = MessageBox.Show("There are some changed data. Save it?",
                "Confirmation To save", MessageBoxButtons.YesNo)
            If result = vbYes Then
                saveCurrentRecord()
            Else
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
        cmd.Parameters.Add("@AccountYear", SqlDbType.Char)
        cmd.Parameters("@AccountYear").Value = cboYear.SelectedItem

        grdNavi.RowCount = 0
        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        If rdr.HasRows Then
            While rdr.Read()
                grdNavi.Rows.Add(rdr("AccountCode"), rdr("ViewName"), rdr("Budget"))
            End While
            rdr.Close()
            grdNavi.CurrentCell = grdNavi("Budget", grdNavi.RowCount - 1)
            enableAllToolStripButton(True)
            _UpdateSW = True
            saveTSB.Enabled = False
        Else
            rdr.Close()
            MessageBox.Show("There is no Account data to compose.", "Not Existed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Close()
        End If
    End Sub

    Private Sub saveCurrentRecord()

    End Sub

    Private Sub grdNavi_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles grdNavi.CellValidating
        If e.ColumnIndex <> 2 Or _FirstSW = True Then Exit Sub
        If IsNumeric(e.FormattedValue.ToString) = False Then
            MessageBox.Show("It shouldn't be a numeric value.", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        End If
    End Sub
End Class