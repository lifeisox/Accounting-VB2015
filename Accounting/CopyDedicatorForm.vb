﻿Imports System.ComponentModel

Public Class CopyDedicatorForm
    Private Const MaxQueryCount As Integer = 3
    Private Enum queryENUM
        READ_ALL_DEDICATOR
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
            cboFrom.SelectedItem = Year(Now()).ToString
            cboTo.SelectedItem = (Year(Now()) + 1).ToString
            _FirstSW = False
        End If
    End Sub

    Private Sub fillComboData()
        For index As Integer = 2016 To 2100 Step 1
            cboFrom.Items.Add(index.ToString)
            cboTo.Items.Add(index.ToString)
        Next

    End Sub

    Private Sub cboFrom_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboFrom.SelectedValueChanged
        Dim fromYear As String = cboFrom.SelectedItem

        lblFrom.Text = fromYear

        grdFrom.RowCount = 0
        Dim cmd As New SqlCommand(_sql(queryENUM.READ_ALL_DEDICATOR), _connection)
        cmd.Parameters.Add("@Year", SqlDbType.Char)
        cmd.Parameters("@Year").Value = cboFrom.SelectedItem
        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        If rdr.HasRows Then
            While rdr.Read()
                grdFrom.Rows.Add(rdr("DedicatorCode"), rdr("ViewName"))
            End While
            rdr.Close()
            btnExecute.Enabled = True
        Else
            rdr.Close()
            btnExecute.Enabled = False
        End If
    End Sub

    Private Sub cboTo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboTo.SelectedValueChanged
        fillToGrid()
    End Sub

    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        If cboFrom.SelectedItem = cboTo.SelectedItem Then
            Dim result As DialogResult = MessageBox.Show("It shoudn't be same YEAR",
                "Duplicate Error!", MessageBoxButtons.OK)
            Exit Sub
        End If

        If grdTo.RowCount > 0 Then
            Dim result As DialogResult = MessageBox.Show("All " + cboTo.SelectedItem +
            " data will be deleted. Is it Okay?", "Confirmation to delete", MessageBoxButtons.YesNo)
            If result = vbNo Then Exit Sub
        End If

        Dim cmd As New SqlCommand(_sql(queryENUM.DELETE), _connection)
        cmd.Parameters.Add("@Year", SqlDbType.Char)
        cmd.Parameters("@Year").Value = cboTo.SelectedItem
        cmd.ExecuteNonQuery()

        cmd.CommandText = _sql(queryENUM.INSERT)
        cmd.Parameters.Add("@From", SqlDbType.Char)
        cmd.Parameters.Add("@To", SqlDbType.Char)
        cmd.Parameters("@From").Value = cboFrom.SelectedItem
        cmd.Parameters("@To").Value = cboTo.SelectedItem
        cmd.ExecuteNonQuery()

        fillToGrid()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub fillToGrid()
        Dim toYear As String = cboTo.SelectedItem

        lblTo.Text = toYear

        grdTo.RowCount = 0
        Dim cmd As New SqlCommand(_sql(queryENUM.READ_ALL_DEDICATOR), _connection)
        cmd.Parameters.Add("@Year", SqlDbType.Char)
        cmd.Parameters("@Year").Value = toYear
        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        If rdr.HasRows Then
            While rdr.Read()
                grdTo.Rows.Add(rdr("DedicatorCode"), rdr("ViewName"))
            End While
            rdr.Close()
        Else
            rdr.Close()
        End If
    End Sub
End Class