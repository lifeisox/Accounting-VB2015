Imports System.ComponentModel

Public Class DedicatorForm
    Private Const MaxQueryCount As Integer = 6
    Private Enum queryENUM
        READ_ALL_DEDICATOR
        READ_ALL_MEMBER
        READ_AVAILABLE_CODE 'Find the available minimum Code in the Table
        READ_DEDICATOR
        INSERT
        DELETE
    End Enum

    Private _sql(MaxQueryCount) As String
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
            cboYear.SelectedItem = Year(Now()).ToString
            _FirstSW = False
        End If
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
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
            txtDedicator.Text = tmpCode.ToString("000")
            txtDedicator.Focus()
        End If

        lblCode.Text = grdMember("MemberCodeCol", grdMember.CurrentRow.Index).Value
        lblName.Text = grdMember("MemberNameCol", grdMember.CurrentRow.Index).Value
        btnInsert.Enabled = False
        btnRemove.Enabled = False
    End Sub

    Private Sub txtDedicator_Validating(sender As Object, e As CancelEventArgs) Handles txtDedicator.Validating
        If txtDedicator.Text.Length = 0 Then Exit Sub

        Dim cmd As New SqlCommand(_sql(queryENUM.READ_DEDICATOR), _connection)
        cmd.Parameters.Add("@Year", SqlDbType.Char)
        cmd.Parameters.Add("@Code", SqlDbType.Char)
        cmd.Parameters("@Year").Value = cboYear.Text
        cmd.Parameters("@Code").Value = txtDedicator.Text
        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        If rdr.HasRows Then
            MessageBox.Show("The code has already used. Use an another code!",
                "Duplicated code", MessageBoxButtons.OK)
            txtDedicator.Focus()
            e.Cancel = True
        End If
        rdr.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim cmd As New SqlCommand(_sql(queryENUM.INSERT), _connection)
        cmd.Parameters.Add("@DedicatorYear", SqlDbType.Char)
        cmd.Parameters.Add("@DedicatorCode", SqlDbType.Char)
        cmd.Parameters.Add("@MemberCode", SqlDbType.Char)
        cmd.Parameters("@DedicatorYear").Value = cboYear.Text
        cmd.Parameters("@DedicatorCode").Value = txtDedicator.Text
        cmd.Parameters("@MemberCode").Value = lblCode.Text
        cmd.ExecuteNonQuery()

        grdDedicator.Rows.Add(txtDedicator.Text, lblName.Text, lblCode.Text)
        grdDedicator.CurrentCell = grdDedicator("DedicatorCodeCol", grdDedicator.RowCount - 1)
        grdMember.Rows.RemoveAt(grdMember.CurrentRow.Index)

        txtDedicator.Text = ""
        lblCode.Text = ""
        lblName.Text = ""
        entryPnl.Visible = False

        If grdMember.RowCount < 1 Then
            btnInsert.Enabled = False
            btnRemove.Enabled = True
        Else
            btnInsert.Enabled = True
            btnRemove.Enabled = True
        End If
    End Sub

    Private Sub fillComboData()
        For index As Integer = 2016 To 2100 Step 1
            cboYear.Items.Add(index.ToString)
        Next

    End Sub

    Private Sub cboYear_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboYear.SelectedValueChanged
        entryPnl.Visible = False
        'Fill Dedicator Grid
        grdDedicator.RowCount = 0
        Dim cmd As New SqlCommand(_sql(queryENUM.READ_ALL_DEDICATOR), _connection)
        cmd.Parameters.Add("@Year", SqlDbType.Char)
        cmd.Parameters("@Year").Value = cboYear.SelectedItem
        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        If rdr.HasRows Then
            While rdr.Read()
                grdDedicator.Rows.Add(rdr("DedicatorCode"), rdr("ViewName"), rdr("MemberCode"))
            End While
            rdr.Close()
            grdDedicator.CurrentCell = grdDedicator(0, grdDedicator.RowCount - 1)
            btnRemove.Enabled = True
        Else
            rdr.Close()
            btnRemove.Enabled = False
        End If
        'Fill Member Grid
        grdMember.RowCount = 0
        cmd.CommandText = _sql(queryENUM.READ_ALL_MEMBER)
        cmd.Parameters("@Year").Value = cboYear.SelectedItem
        rdr = cmd.ExecuteReader()
        If rdr.HasRows Then
            While rdr.Read()
                grdMember.Rows.Add(rdr("MemberCode"), rdr("ViewName"))
            End While
            rdr.Close()
            grdMember.CurrentCell = grdMember(0, grdMember.RowCount - 1)
            btnInsert.Enabled = True
        Else
            rdr.Close()
            btnInsert.Enabled = False
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim cmd As New SqlCommand(_sql(queryENUM.DELETE), _connection)
        cmd.Parameters.Add("@Year", SqlDbType.Char)
        cmd.Parameters.Add("@Code", SqlDbType.Char)
        cmd.Parameters("@Year").Value = cboYear.SelectedItem
        cmd.Parameters("@Code").Value = grdDedicator("DedicatorCodeCol", grdDedicator.CurrentRow.Index).Value
        cmd.ExecuteNonQuery()

        grdMember.Rows.Add(grdDedicator("MemberCode", grdDedicator.CurrentRow.Index).Value,
            grdDedicator("DedicatorNameCol", grdDedicator.CurrentRow.Index).Value)
        grdMember.CurrentCell = grdMember("MemberCodeCol", grdMember.RowCount - 1)
        grdDedicator.Rows.RemoveAt(grdDedicator.CurrentRow.Index)

        txtDedicator.Text = ""
        lblCode.Text = ""
        lblName.Text = ""
        entryPnl.Visible = False

        If grdDedicator.RowCount < 1 Then
            btnRemove.Enabled = False
        End If
        btnInsert.Enabled = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class