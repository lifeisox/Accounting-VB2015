Imports System.ComponentModel

Public Class CopyDedicatorForm
    Private Const MAX_QUERY_COUNT As Integer = 3
    Private Enum queryENUM
        READ_ALL_DEDICATOR
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

        _sql(queryENUM.INSERT) =
            "INSERT INTO Tbl_Dedicator ( DedicatorYear, DedicatorCode, MemberCode ) 
	            SELECT @To, DedicatorCode, MemberCode 
	            FROM Tbl_Dedicator WHERE DedicatorYear = @From"
        _sql(queryENUM.DELETE) =
            "DELETE FROM Tbl_Dedicator WHERE DedicatorYear = @Year"

        ' Add any initialization after the InitializeComponent() call.
        _connection = New SqlConnection(My.Settings.DbConn)
        _connection.Open()

    End Sub

    Private Sub CopyDedicatorForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        _connection.Close()
    End Sub

    Private Sub CopyDedicatorForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If _FirstSW = True Then
            fillComboData()
            fromCbo.SelectedItem = Year(Now()).ToString
            toCbo.SelectedItem = (Year(Now()) + 1).ToString
            _FirstSW = False
        End If
    End Sub

    Private Sub fillComboData()
        For index As Integer = 2016 To 2100 Step 1
            fromCbo.Items.Add(index.ToString)
            toCbo.Items.Add(index.ToString)
        Next

    End Sub

    Private Sub fromCbo_SelectedValueChanged(sender As Object, e As EventArgs) Handles fromCbo.SelectedValueChanged, fromCbo.SelectedValueChanged
        Dim fromYear As String = fromCbo.SelectedItem

        fromLbl.Text = fromYear

        fromGrd.RowCount = 0
        Dim cmd As New SqlCommand(_sql(queryENUM.READ_ALL_DEDICATOR), _connection)
        cmd.Parameters.Add("@Year", SqlDbType.Char)
        cmd.Parameters("@Year").Value = fromCbo.SelectedItem
        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        If rdr.HasRows Then
            While rdr.Read()
                fromGrd.Rows.Add(rdr("DedicatorCode"), rdr("ViewName"))
            End While
            rdr.Close()
            executeBtn.Enabled = True
        Else
            rdr.Close()
            executeBtn.Enabled = False
        End If
    End Sub

    Private Sub toCbo_SelectedValueChanged(sender As Object, e As EventArgs) Handles toCbo.SelectedValueChanged
        fillToGrid()
    End Sub

    Private Sub executeBtn_Click(sender As Object, e As EventArgs) Handles executeBtn.Click
        If fromCbo.SelectedItem = toCbo.SelectedItem Then
            Dim result As DialogResult = MessageBox.Show("It shoudn't be same YEAR",
                "Duplicate Error!", MessageBoxButtons.OK)
            Exit Sub
        End If

        If toGrd.RowCount > 0 Then
            Dim result As DialogResult = MessageBox.Show("All " + toCbo.SelectedItem +
            " data will be deleted. Is it Okay?", "Confirmation to delete", MessageBoxButtons.YesNo)
            If result = vbNo Then Exit Sub
        End If

        Dim cmd As New SqlCommand(_sql(queryENUM.DELETE), _connection)
        cmd.Parameters.Add("@Year", SqlDbType.Char)
        cmd.Parameters("@Year").Value = toCbo.SelectedItem
        cmd.ExecuteNonQuery()

        cmd.CommandText = _sql(queryENUM.INSERT)
        cmd.Parameters.Add("@From", SqlDbType.Char)
        cmd.Parameters.Add("@To", SqlDbType.Char)
        cmd.Parameters("@From").Value = fromCbo.SelectedItem
        cmd.Parameters("@To").Value = toCbo.SelectedItem
        cmd.ExecuteNonQuery()

        fillToGrid()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Close()
    End Sub

    Private Sub fillToGrid()
        Dim toYear As String = toCbo.SelectedItem

        toLbl.Text = toYear

        toGrd.RowCount = 0
        Dim cmd As New SqlCommand(_sql(queryENUM.READ_ALL_DEDICATOR), _connection)
        cmd.Parameters.Add("@Year", SqlDbType.Char)
        cmd.Parameters("@Year").Value = toYear
        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        If rdr.HasRows Then
            While rdr.Read()
                toGrd.Rows.Add(rdr("DedicatorCode"), rdr("ViewName"))
            End While
            rdr.Close()
        Else
            rdr.Close()
        End If
    End Sub
End Class