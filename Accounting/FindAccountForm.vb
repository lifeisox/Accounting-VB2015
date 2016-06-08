Imports System.ComponentModel

Public Class FindAccountForm
    ' Define a local variable to store the property value.
    Private _accountCode As String
    Private _connection As SqlConnection = Nothing
    Private _command As SqlCommand
    Private _set As Boolean
    Private _isOkButton As Boolean

    ' Define the property.
    Public Property accountCode() As String
        Get
            Return _accountCode
        End Get
        Set(ByVal value As String)
            _accountCode = value
        End Set
    End Property

    Public Sub New(ByVal accountYear As String, ByVal withComputedField As Boolean)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim query = "
            SELECT AccountCode, IIF(Division = 'E', 'Expense', 'Income') AS ViewDivision, 
                IIF(AccountNameKr IS NULL OR AccountNameKr = '', AccountName, 
                IIF(AccountName Is NULL Or AccountName = '', AccountNameKr, CONCAT(AccountNameKr, '(', 
                AccountName, ')'))) AS ViewName 
            FROM Tbl_Account 
            WHERE AccountYear = @AccountYear AND (AccountNameKr LIKE @AccountName OR 
                AccountName LIKE @AccountName)
        " + IIf(withComputedField = False, " AND IsComputed = 'N'", "")

        chkWithComputedField.Checked = withComputedField
        chkWithComputedField.Enabled = False
        _connection = New SqlConnection(My.Settings.DbConn)
        _connection.Open()
        _command = New SqlCommand(query, _connection)
        _command.Parameters.Add("@AccountYear", SqlDbType.VarChar)
        _command.Parameters.Add("@AccountName", SqlDbType.VarChar)
        _command.Parameters("@AccountYear").Value = accountYear
        _set = False
        _isOkButton = False

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        If txtName.TextLength = 0 Then Return

        grdNavi.RowCount = 0

        _command.Parameters("@AccountName").Value = "%" + txtName.Text + "%"
        Dim reader As SqlDataReader = _command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                grdNavi.Rows.Add(reader("AccountCode"), reader("ViewDivision"), reader("ViewName"))
            End While
            grdNavi.CurrentCell = grdNavi(0, 0)
        End If
        reader.Close()
    End Sub

    Private Sub grdNavi_CurrentCellChanged(sender As Object, e As EventArgs) Handles grdNavi.CurrentCellChanged
        If grdNavi.RowCount < 1 Then Return

        Try
            accountCode = grdNavi.Rows(grdNavi.CurrentRow.Index).Cells("colAccountCode").Value
            _set = True
        Catch ex As Exception
            _set = False
        End Try
    End Sub

    Private Sub FindAccountForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If _isOkButton = True And _set = False Then
            MessageBox.Show("Account Code is not selected.", "Warning!", MessageBoxButtons.OK)
            _isOkButton = False
            e.Cancel = True
        Else
            _connection.Close()
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        _isOkButton = True
    End Sub

    Private Sub grdNavi_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grdNavi.CellMouseDoubleClick
        btnOk.PerformClick()
    End Sub
End Class