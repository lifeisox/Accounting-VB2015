Imports System.ComponentModel

Public Class DedicatorForm
    Private Const MAX_QUERY_COUNT As Integer = 6
    Private Enum queryENUM
        READ_ALL_DEDICATOR
        READ_ALL_MEMBER
        READ_AVAILABLE_CODE 'Find the available minimum Code in the Table
        READ_DEDICATOR
        INSERT
        DELETE
    End Enum

    Private _sql(MAX_QUERY_COUNT) As String
    Private _FirstSW As Boolean = True
    Private _connection As SqlConnection = Nothing

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Assign queries to use in this class
        _sql(queryENUM.READ_ALL_DEDICATOR) =
            "SELECT DedicatorCode, IIF(KoreanName IS NULL OR KoreanName = '', EnglishName, 
                IIf(EngLishName Is NULL Or EnglishName = '', KoreanName, CONCAT(KoreanName, '(', 
                EnglishName, ')'))) AS ViewName, Tbl_Dedicator.MemberCode 
            FROM Tbl_Dedicator, Tbl_Member 
            WHERE Tbl_Member.MemberCode = Tbl_Dedicator.MemberCode AND DedicatorYear = @Year 
            Order By DedicatorCode"
        _sql(queryENUM.READ_ALL_MEMBER) =
            "SELECT MemberCode, IIF(KoreanName IS NULL OR KoreanName = '', EnglishName, 
                IIF(EngLishName Is NULL Or EnglishName = '', KoreanName, CONCAT(KoreanName, '(', 
                EnglishName, ')'))) AS ViewName 
            FROM Tbl_Member 
            WHERE Tbl_Member.MemberCode NOT IN 
				( SELECT MemberCode FROM Tbl_Dedicator WHERE DedicatorYear = @Year )
            ORDER BY MemberCode"
        _sql(queryENUM.READ_AVAILABLE_CODE) =
            "SELECT MIN(DedicatorCode + 1) FROM Tbl_Dedicator 
                WHERE (DedicatorCode + 1) NOT IN ( SELECT DedicatorCode FROM Tbl_Dedicator )"
        _sql(queryENUM.READ_DEDICATOR) =
            "SELECT MemberCode FROM Tbl_Dedicator 
            WHERE DedicatorYear = @Year AND DedicatorCode = @Code"
        _sql(queryENUM.INSERT) =
            "INSERT INTO Tbl_Dedicator ( [DedicatorYear], [DedicatorCode], [MemberCode] ) 
                VALUES ( @DedicatorYear, @DedicatorCode, @MemberCode )"
        _sql(queryENUM.DELETE) =
            "DELETE FROM Tbl_Dedicator WHERE DedicatorYear = @Year AND DedicatorCode = @Code"

        ' Add any initialization after the InitializeComponent() call.
        _connection = New SqlConnection(My.Settings.DbConn)
        _connection.Open()

    End Sub

    Private Sub DedicatorForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        _connection.Close()
    End Sub

    Private Sub DedicatorForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If _FirstSW = True Then
            fillComboData()
            yearCbo.SelectedItem = Year(Now()).ToString
            _FirstSW = False
        End If
    End Sub

    Private Sub insertBtn_Click(sender As Object, e As EventArgs) Handles insertBtn.Click
        Dim tmpCode As Int32 = 0
        Dim tmpStr As Object

        entryPnl.Visible = True
        Dim command As New SqlCommand(_sql(queryENUM.READ_AVAILABLE_CODE), _connection)
        tmpStr = command.ExecuteScalar()
        If tmpStr Is DBNull.Value Then
            tmpCode = 1
        Else
            tmpCode = Convert.ToInt32(tmpStr)
        End If
        If tmpCode > 999 Then
            MessageBox.Show("A dedicator can't be inserted anymore!", "Full data", MessageBoxButtons.OK)
            Close()
        Else
            dedicatorTxt.Text = tmpCode.ToString("000")
            dedicatorTxt.Focus()
        End If

        codeLbl.Text = memberGrd("MemberCodeCol", memberGrd.CurrentRow.Index).Value
        nameLbl.Text = memberGrd("MemberNameCol", memberGrd.CurrentRow.Index).Value
        insertBtn.Enabled = False
        removeBtn.Enabled = False
    End Sub

    Private Sub dedicatorTxt_Validating(sender As Object, e As CancelEventArgs) Handles dedicatorTxt.Validating
        If dedicatorTxt.Text.Length = 0 Then Exit Sub

        Dim cmd As New SqlCommand(_sql(queryENUM.READ_DEDICATOR), _connection)
        cmd.Parameters.Add("@Year", SqlDbType.Char)
        cmd.Parameters.Add("@Code", SqlDbType.Char)
        cmd.Parameters("@Year").Value = yearCbo.Text
        cmd.Parameters("@Code").Value = dedicatorTxt.Text
        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        If rdr.HasRows Then
            MessageBox.Show("The code has already used. Use an another code!",
                "Duplicated code", MessageBoxButtons.OK)
            dedicatorTxt.Focus()
            e.Cancel = True
        End If
        rdr.Close()
    End Sub

    Private Sub confirmBtn_Click(sender As Object, e As EventArgs) Handles confirmBtn.Click
        Dim cmd As New SqlCommand(_sql(queryENUM.INSERT), _connection)
        cmd.Parameters.Add("@DedicatorYear", SqlDbType.Char)
        cmd.Parameters.Add("@DedicatorCode", SqlDbType.Char)
        cmd.Parameters.Add("@MemberCode", SqlDbType.Char)
        cmd.Parameters("@DedicatorYear").Value = yearCbo.Text
        cmd.Parameters("@DedicatorCode").Value = dedicatorTxt.Text
        cmd.Parameters("@MemberCode").Value = codeLbl.Text
        cmd.ExecuteNonQuery()

        dedicatorGrd.Rows.Add(dedicatorTxt.Text, nameLbl.Text, codeLbl.Text)
        dedicatorGrd.CurrentCell = dedicatorGrd("DedicatorCodeCol", dedicatorGrd.RowCount - 1)
        memberGrd.Rows.RemoveAt(memberGrd.CurrentRow.Index)

        dedicatorTxt.Text = ""
        codeLbl.Text = ""
        nameLbl.Text = ""
        entryPnl.Visible = False

        If memberGrd.RowCount < 1 Then
            insertBtn.Enabled = False
            removeBtn.Enabled = True
        Else
            insertBtn.Enabled = True
            removeBtn.Enabled = True
        End If
    End Sub

    Private Sub fillComboData()
        For index As Integer = 2016 To 2100 Step 1
            yearCbo.Items.Add(index.ToString)
        Next

    End Sub

    Private Sub yearCbo_SelectedValueChanged(sender As Object, e As EventArgs) Handles yearCbo.SelectedValueChanged
        entryPnl.Visible = False
        'Fill Dedicator Grid
        dedicatorGrd.RowCount = 0
        Dim cmd As New SqlCommand(_sql(queryENUM.READ_ALL_DEDICATOR), _connection)
        cmd.Parameters.Add("@Year", SqlDbType.Char)
        cmd.Parameters("@Year").Value = yearCbo.SelectedItem
        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        If rdr.HasRows Then
            While rdr.Read()
                dedicatorGrd.Rows.Add(rdr("DedicatorCode"), rdr("ViewName"), rdr("MemberCode"))
            End While
            rdr.Close()
            dedicatorGrd.CurrentCell = dedicatorGrd(0, dedicatorGrd.RowCount - 1)
            removeBtn.Enabled = True
        Else
            rdr.Close()
            removeBtn.Enabled = False
        End If
        'Fill Member Grid
        memberGrd.RowCount = 0
        cmd.CommandText = _sql(queryENUM.READ_ALL_MEMBER)
        cmd.Parameters("@Year").Value = yearCbo.SelectedItem
        rdr = cmd.ExecuteReader()
        If rdr.HasRows Then
            While rdr.Read()
                memberGrd.Rows.Add(rdr("MemberCode"), rdr("ViewName"))
            End While
            rdr.Close()
            memberGrd.CurrentCell = memberGrd(0, memberGrd.RowCount - 1)
            insertBtn.Enabled = True
        Else
            rdr.Close()
            insertBtn.Enabled = False
        End If
    End Sub

    Private Sub removeBtn_Click(sender As Object, e As EventArgs) Handles removeBtn.Click
        Dim cmd As New SqlCommand(_sql(queryENUM.DELETE), _connection)
        cmd.Parameters.Add("@Year", SqlDbType.Char)
        cmd.Parameters.Add("@Code", SqlDbType.Char)
        cmd.Parameters("@Year").Value = yearCbo.SelectedItem
        cmd.Parameters("@Code").Value = dedicatorGrd("DedicatorCodeCol", dedicatorGrd.CurrentRow.Index).Value
        cmd.ExecuteNonQuery()

        memberGrd.Rows.Add(dedicatorGrd("MemberCode", dedicatorGrd.CurrentRow.Index).Value,
            dedicatorGrd("DedicatorNameCol", dedicatorGrd.CurrentRow.Index).Value)
        memberGrd.CurrentCell = memberGrd("MemberCodeCol", memberGrd.RowCount - 1)
        dedicatorGrd.Rows.RemoveAt(dedicatorGrd.CurrentRow.Index)

        dedicatorTxt.Text = ""
        codeLbl.Text = ""
        nameLbl.Text = ""
        entryPnl.Visible = False

        If dedicatorGrd.RowCount < 1 Then
            removeBtn.Enabled = False
        End If
        insertBtn.Enabled = True
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Close()
    End Sub
End Class