Imports System.ComponentModel

Public Class EducationCodeForm

    Private ivMaxQueryCount As Integer = 5
    Private Enum queryENUM
        READ_ALL
        READ
        INSERT
        UPDATE
        DELETE
    End Enum
    Private ivSQL(ivMaxQueryCount) As String

    Private ivFirstSW As Boolean = True
    Private ivAddSW As Boolean = False
    Private ivUpdateSW As Boolean = False
    Private ivChangedSW As Boolean = False

    Private ivConnection As SqlConnection = Nothing

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Assign queries to use in this class
        ivSQL(queryENUM.READ_ALL) = "SELECT EducationCode, EducationName FROM Tbl_Education"
        ivSQL(queryENUM.READ) = "SELECT EducationCode, EducationName FROM Tbl_Education WHERE EducationCode = @Code"
        ivSQL(queryENUM.INSERT) = "INSERT INTO Tbl_Education ( EducationCode, EducationName ) VALUES ( @Code, @Name )"
        ivSQL(queryENUM.UPDATE) = "UPDATE Tbl_Education SET EducationName = @Name WHERE EducationCode = @Code"
        ivSQL(queryENUM.DELETE) = "DELETE FROM Tbl_Education WHERE EducationCode = @Code"

        ' Add any initialization after the InitializeComponent() call.
        ivConnection = New SqlConnection(My.Settings.DbConn)
        ivConnection.Open()

    End Sub

    Protected Overrides Sub Finalize()
        ivConnection.Close()
        MyBase.Finalize()
    End Sub

    Private Sub educationCodeFM_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        checkChangedField()
    End Sub

    Private Sub educationCodeFM_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If ivFirstSW = True Then
            fillGrid()
            ivFirstSW = False
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
            Case "deleteTSB"
                deleteCurrentRecord()
            Case "firstTSB"
                naviDGV.CurrentCell = naviDGV(0, 0)
            Case "previousTSB"
                If naviDGV.CurrentRow.Index > 0 Then
                    naviDGV.CurrentCell = naviDGV(0, naviDGV.CurrentRow.Index - 1)
                End If
            Case "nextTSB"
                If naviDGV.CurrentRow.Index < naviDGV.RowCount - 1 Then
                    naviDGV.CurrentCell = naviDGV(0, naviDGV.CurrentRow.Index + 1)
                End If
            Case "lastTSB"
                naviDGV.CurrentCell = naviDGV(0, naviDGV.RowCount - 1)
            Case "refreshTSB"
                fillGrid()
            Case "saveTSB"
                saveCurrentRecord()
            Case "closeTSB"
                Close()
        End Select
    End Sub

    Private Sub naviDGV_CurrentCellChanged(sender As Object, e As EventArgs) Handles naviDGV.CurrentCellChanged
        checkChangedField()
        If naviDGV.SelectedRows.Count <> 1 Then Return

        Dim index As Integer = naviDGV.SelectedRows(0).Index
        If naviDGV.SelectedRows.Count = 1 And index <= naviDGV.Rows.Count - 1 And ivFirstSW = False Then
            fillData(naviDGV.Rows(index).Cells("CodeCol").Value)
        End If
    End Sub

    Private Sub codeTB_GotFocus(sender As Object, e As EventArgs) Handles codeTB.GotFocus
        codeTB.Select(0, 0)
    End Sub

    Private Sub nameTB_GotFocus(sender As Object, e As EventArgs) Handles nameTB.GotFocus
        nameTB.SelectAll()
    End Sub

    Private Sub control_Changed(sender As Object, e As EventArgs) Handles codeTB.TextChanged, nameTB.TextChanged
        If ivAddSW = True Or ivUpdateSW = True Then
            ivChangedSW = True
            saveTSB.Enabled = True
        End If
    End Sub

    Private Sub control_KeyDown(sender As Object, e As KeyEventArgs) Handles codeTB.KeyDown, nameTB.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True   'This will prevent ding sound.
            If sender.Name = "codeTB" Then
                nameTB.Focus()
            ElseIf sender.Name = "nameTB" Then
                menuTS.Focus()
            End If
        End If
    End Sub

    Private Sub codeTB_Validating(sender As Object, e As CancelEventArgs) Handles codeTB.Validating
        If ivAddSW = False Then Exit Sub

        If codeTB.Text.Length = 2 Then
            Dim command As New SqlCommand(ivSQL(queryENUM.READ), ivConnection)
            command.Parameters.Add("@Code", SqlDbType.Char)
            command.Parameters("@Code").Value = codeTB.Text
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                MessageBox.Show("The code has already used. Use an another code!",
                "Duplicated code", MessageBoxButtons.OK)
                codeTB.Focus()
                e.Cancel = True
            End If
            reader.Close()
        Else
            MessageBox.Show("The length of the code should be 2. Re-enter!",
                "Wrong code", MessageBoxButtons.OK)
            codeTB.Focus()
            e.Cancel = True
        End If
    End Sub

    Private Sub checkChangedField()
        If (ivAddSW = True Or ivUpdateSW = True) And ivChangedSW = True Then
            Dim result As DialogResult = MessageBox.Show("There are some changed data. Save it?",
                "Confirmation to save", MessageBoxButtons.YesNo)
            If result = vbYes Then
                saveCurrentRecord()
            Else
                ivAddSW = False
                ivUpdateSW = False
                ivChangedSW = False
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

    Private Sub fillGrid()
        Dim command As New SqlCommand(ivSQL(queryENUM.READ_ALL), ivConnection)

        Me.Cursor = Cursors.WaitCursor

        naviDGV.RowCount = 0

        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                naviDGV.Rows.Add(reader("EducationCode"), reader("EducationName"))
            End While
            reader.Close()
            naviDGV.CurrentCell = naviDGV(0, naviDGV.Rows.Count - 1)
            fillData(naviDGV.CurrentCell.Value)
            enableAllToolStripButton(True)
            saveTSB.Enabled = False
        Else
            reader.Close()
            enableAllToolStripButton(False)
            newTSB.Enabled = True
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub fillData(ByVal code As String)
        Dim command As New SqlCommand(ivSQL(queryENUM.READ), ivConnection)
        command.Parameters.Add("@Code", SqlDbType.Char)
        command.Parameters("@Code").Value = code
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            With reader
                codeTB.Text = .Item("EducationCode")
                codeTB.ReadOnly = True
                nameTB.Text = .Item("EducationName")
            End With
        End If

        reader.Close()

        ivUpdateSW = True
        ivChangedSW = False
        ivAddSW = False

        newTSB.Enabled = True
        saveTSB.Enabled = False
        deleteTSB.Enabled = True

        nameTB.Focus()

    End Sub

    Private Sub clearAllFields()
        codeTB.Text = ""                                    'Code
        codeTB.ReadOnly = False

        nameTB.Text = ""                                    'Name

        ivAddSW = True
        ivChangedSW = False

        newTSB.Enabled = False
        saveTSB.Enabled = False
        deleteTSB.Enabled = False

        codeTB.Focus()
    End Sub

    Private Sub saveCurrentRecord()
        If ivAddSW = True Then
            Dim command As New SqlCommand(ivSQL(queryENUM.INSERT), ivConnection)
            parameterMove(command)
            ivAddSW = False
            ivChangedSW = False

            newTSB.Enabled = True
            deleteTSB.Enabled = True
            saveTSB.Enabled = False

            naviDGV.Rows.Add(codeTB.Text, nameTB.Text)
            naviDGV.CurrentCell = naviDGV(0, naviDGV.Rows.Count - 1)
        Else
            Dim command As New SqlCommand(ivSQL(queryENUM.UPDATE), ivConnection)
            parameterMove(command)
            ivUpdateSW = True
            ivChangedSW = False

            newTSB.Enabled = True
            deleteTSB.Enabled = True
            saveTSB.Enabled = False

            naviDGV(1, naviDGV.CurrentRow.Index).Value = nameTB.Text
        End If
    End Sub

    Private Sub parameterMove(ByVal command As SqlCommand)
        command.Parameters.Add("@Code", SqlDbType.Char)
        command.Parameters.Add("@Name", SqlDbType.VarChar)

        command.Parameters("@Code").Value = codeTB.Text
        command.Parameters("@Name").Value = nameTB.Text

        command.ExecuteNonQuery()
    End Sub

    Private Sub deleteCurrentRecord()
        Dim result As DialogResult = MessageBox.Show("Deleted data can't be recovered. Delete it?",
                "Confirmation to delete", MessageBoxButtons.YesNo)
        If result = vbNo Then Exit Sub

        Dim command As New SqlCommand(ivSQL(queryENUM.DELETE), ivConnection)

        command.Parameters.Add("@Code", SqlDbType.Char)

        command.Parameters("@Code").Value = codeTB.Text

        command.ExecuteNonQuery()

        Dim saveCurrentRow = naviDGV.CurrentRow.Index
        naviDGV.Rows.RemoveAt(saveCurrentRow)
        If naviDGV.RowCount < 1 Then
            clearAllFields()
            ivAddSW = False
            ivUpdateSW = False
            enableAllToolStripButton(False)
            newTSB.Enabled = True
        ElseIf saveCurrentRow > naviDGV.RowCount - 1 Then
            naviDGV.CurrentCell = naviDGV(0, naviDGV.RowCount - 1)
            fillData(naviDGV.CurrentCell.Value)
        Else
            naviDGV.CurrentCell = naviDGV(0, saveCurrentRow)
            fillData(naviDGV.CurrentCell.Value)
        End If

    End Sub
End Class