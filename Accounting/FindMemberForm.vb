Imports System.ComponentModel

Public Class FindMemberForm
    ' Define a local variable to store the property value.
    Private _memberCode As String
    Private _connection As SqlConnection = Nothing
    Private _command As SqlCommand
    Private _set As Boolean
    Private _isOkButton As Boolean

    ' Define the property.
    Public Property memberCode() As String
        Get
            Return _memberCode
        End Get
        Set(ByVal value As String)
            _memberCode = value
        End Set
    End Property

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim query = "SELECT MemberCode, IIF(KoreanName IS NULL OR KoreanName = '', EnglishName, " +
                "IIF(EngLishName Is NULL Or EnglishName = '', KoreanName, CONCAT(KoreanName, '(', " +
                "EnglishName, ')'))) AS ViewName, DutyName, Email " +
                "FROM Tbl_Member, Tbl_Duty " +
                "WHERE Tbl_Duty.DutyCode = Tbl_Member.DutyCode AND (KoreanName LIKE @Name OR " +
                    "EnglishName LIKE @Name)"

        _connection = New SqlConnection(My.Settings.DbConn)
        _connection.Open()
        _command = New SqlCommand(query, _connection)
        _command.Parameters.Add("@Name", SqlDbType.VarChar)
        _set = False
        _isOkButton = False

    End Sub

    Private Sub nameTB_TextChanged(sender As Object, e As EventArgs) Handles nameTB.TextChanged
        If nameTB.TextLength = 0 Then Return

        naviDGV.RowCount = 0

        _command.Parameters("@Name").Value = "%" + nameTB.Text + "%"
        Dim reader As SqlDataReader = _command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                naviDGV.Rows.Add(reader("MemberCode"), reader("ViewName"), reader("DutyName"), reader("Email"))
            End While
            naviDGV.CurrentCell = naviDGV(0, 0)
        End If
        reader.Close()
    End Sub

    Private Sub naviDGV_CurrentCellChanged(sender As Object, e As EventArgs) Handles naviDGV.CurrentCellChanged
        If naviDGV.RowCount < 1 Then Return

        'Dim index As Integer = naviDGV.SelectedRows(0).Index
        'If naviDGV.SelectedRows.Count = 1 And index < naviDGV.RowCount Then
        '    memberCode = naviDGV.Rows(index).Cells("CodeCol").Value
        'End If
        Try
            memberCode = naviDGV.Rows(naviDGV.CurrentRow.Index).Cells("CodeCol").Value
            _set = True
        Catch ex As Exception
            _set = False
        End Try
    End Sub

    Private Sub FindMemberForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If _isOkButton = True And _set = False Then
            MessageBox.Show("Member Code is not selected.", "Warning!", MessageBoxButtons.OK)
            _isOkButton = False
            e.Cancel = True
        Else
            _connection.Close()
        End If
    End Sub

    Private Sub okBtn_Click(sender As Object, e As EventArgs) Handles okBtn.Click
        _isOkButton = True
    End Sub

    Private Sub naviDGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles naviDGV.CellMouseDoubleClick
        okBtn.PerformClick()
    End Sub
End Class