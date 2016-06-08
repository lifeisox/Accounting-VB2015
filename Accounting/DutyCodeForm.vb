Imports System.ComponentModel

Public Class DutyCodeForm

    Private MaxQueryCount As Integer = 5
    Private Enum queryENUM
        READ_ALL
        READ
        INSERT
        UPDATE
        DELETE
    End Enum
    Private _SQL(MaxQueryCount) As String

    Private _FirstSW As Boolean = True
    Private _AddSW As Boolean = False
    Private _UpdateSW As Boolean = False
    Private _ChangedSW As Boolean = False

    Private _Conn As SqlConnection = Nothing

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Assign queries to use in this class
        _SQL(queryENUM.READ_ALL) = "SELECT DutyCode, DutyName FROM Tbl_Duty"
        _SQL(queryENUM.READ) = "SELECT DutyCode, DutyName FROM Tbl_Duty WHERE DutyCode = @Code"
        _SQL(queryENUM.INSERT) = "INSERT INTO Tbl_Duty ( DutyCode, DutyName ) VALUES ( @Code, @Name )"
        _SQL(queryENUM.UPDATE) = "UPDATE Tbl_Duty SET DutyName = @Name WHERE DutyCode = @Code"
        _SQL(queryENUM.DELETE) = "DELETE FROM Tbl_Duty WHERE DutyCode = @Code"

        ' Add any initialization after the InitializeComponent() call.
        _Conn = New SqlConnection(My.Settings.DbConn)
        _Conn.Open()

    End Sub

    Protected Overrides Sub Finalize()
        _Conn.Close()
        MyBase.Finalize()
    End Sub

    Private Sub DutyCodeForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        checkChangedField()
    End Sub

    Private Sub DutyCodeForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If _FirstSW = True Then
            fillGrid()
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
            Case "deleteTSB"
                deleteCurrentRecord()
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
            Case "lastTSB"
                grdNavi.CurrentCell = grdNavi(0, grdNavi.RowCount - 1)
            Case "refreshTSB"
                fillGrid()
            Case "saveTSB"
                saveCurrentRecord()
            Case "closeTSB"
                Close()
        End Select
    End Sub

    Private Sub grdNavi_CurrentCellChanged(sender As Object, e As EventArgs) Handles grdNavi.CurrentCellChanged, grdNavi.CurrentCellChanged
        checkChangedField()
        If grdNavi.SelectedRows.Count <> 1 Then Return

        Dim index As Integer = grdNavi.SelectedRows(0).Index
        If grdNavi.SelectedRows.Count = 1 And index <= grdNavi.Rows.Count - 1 And _FirstSW = False Then
            fillData(grdNavi.Rows(index).Cells("CodeCol").Value)
        End If
    End Sub

    Private Sub txtCode_GotFocus(sender As Object, e As EventArgs) Handles txtCode.GotFocus
        txtCode.Select(0, 0)
    End Sub

    Private Sub txtName_GotFocus(sender As Object, e As EventArgs) Handles txtName.GotFocus
        txtName.SelectAll()
    End Sub

    Private Sub control_Changed(sender As Object, e As EventArgs) Handles txtCode.TextChanged, txtName.TextChanged
        If _AddSW = True Or _UpdateSW = True Then
            _ChangedSW = True
            saveTSB.Enabled = True
        End If
    End Sub

    Private Sub control_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCode.KeyDown, txtName.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True   'This will prevent ding sound.
            If sender.Name = "codeTB" Then
                txtName.Focus()
            ElseIf sender.Name = "nameTB" Then
                menuTS.Focus()
            End If
        End If
    End Sub

    Private Sub txtCode_Validating(sender As Object, e As CancelEventArgs) Handles txtCode.Validating
        If _AddSW = False Then Exit Sub

        If txtCode.Text.Length = 2 Then
            Dim command As New SqlCommand(_SQL(queryENUM.READ), _Conn)
            command.Parameters.Add("@Code", SqlDbType.Char)
            command.Parameters("@Code").Value = txtCode.Text
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                MessageBox.Show("The code has already used. Use an another code!",
                "Duplicated code", MessageBoxButtons.OK)
                txtCode.Focus()
                e.Cancel = True
            End If
            reader.Close()
        Else
            MessageBox.Show("The length of the code should be 2. Re-enter!",
                "Wrong code", MessageBoxButtons.OK)
            txtCode.Focus()
            e.Cancel = True
        End If
    End Sub

    Private Sub checkChangedField()
        If (_AddSW = True Or _UpdateSW = True) And _ChangedSW = True Then
            Dim result As DialogResult = MessageBox.Show("There are some changed data. Save it?",
                "Confirmation to save", MessageBoxButtons.YesNo)
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

    Private Sub fillGrid()
        Dim command As New SqlCommand(_SQL(queryENUM.READ_ALL), _Conn)

        Me.Cursor = Cursors.WaitCursor

        grdNavi.RowCount = 0

        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                grdNavi.Rows.Add(reader("DutyCode"), reader("DutyName"))
            End While
            reader.Close()
            grdNavi.CurrentCell = grdNavi(0, grdNavi.Rows.Count - 1)
            fillData(grdNavi.CurrentCell.Value)
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
        Dim command As New SqlCommand(_SQL(queryENUM.READ), _Conn)
        command.Parameters.Add("@Code", SqlDbType.Char)
        command.Parameters("@Code").Value = code
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            With reader
                txtCode.Text = .Item("DutyCode")
                txtCode.ReadOnly = True
                txtName.Text = .Item("DutyName")
            End With
        End If

        reader.Close()

        _UpdateSW = True
        _ChangedSW = False
        _AddSW = False

        newTSB.Enabled = True
        saveTSB.Enabled = False
        deleteTSB.Enabled = True

        txtName.Focus()

    End Sub

    Private Sub clearAllFields()
        txtCode.Text = ""                                    'Code
        txtCode.ReadOnly = False

        txtName.Text = ""                                    'Name

        _AddSW = True
        _ChangedSW = False

        newTSB.Enabled = False
        saveTSB.Enabled = False
        deleteTSB.Enabled = False

        txtCode.Focus()
    End Sub

    Private Sub saveCurrentRecord()
        If _AddSW = True Then
            Dim command As New SqlCommand(_SQL(queryENUM.INSERT), _Conn)
            parameterMove(command)
            _AddSW = False
            _ChangedSW = False

            newTSB.Enabled = True
            deleteTSB.Enabled = True
            saveTSB.Enabled = False

            grdNavi.Rows.Add(txtCode.Text, txtName.Text)
            grdNavi.CurrentCell = grdNavi(0, grdNavi.Rows.Count - 1)
        Else
            Dim command As New SqlCommand(_SQL(queryENUM.UPDATE), _Conn)
            parameterMove(command)
            _UpdateSW = True
            _ChangedSW = False

            newTSB.Enabled = True
            deleteTSB.Enabled = True
            saveTSB.Enabled = False

            grdNavi(1, grdNavi.CurrentRow.Index).Value = txtName.Text
        End If
    End Sub

    Private Sub parameterMove(ByVal command As SqlCommand)
        command.Parameters.Add("@Code", SqlDbType.Char)
        command.Parameters.Add("@Name", SqlDbType.VarChar)

        command.Parameters("@Code").Value = txtCode.Text
        command.Parameters("@Name").Value = txtName.Text

        command.ExecuteNonQuery()
    End Sub

    Private Sub deleteCurrentRecord()
        Dim result As DialogResult = MessageBox.Show("Deleted data can't be recovered. Delete it?",
                "Confirmation to delete", MessageBoxButtons.YesNo)
        If result = vbNo Then Exit Sub

        Dim command As New SqlCommand(_SQL(queryENUM.DELETE), _Conn)

        command.Parameters.Add("@Code", SqlDbType.Char)

        command.Parameters("@Code").Value = txtCode.Text

        command.ExecuteNonQuery()

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
            fillData(grdNavi.CurrentCell.Value)
        Else
            grdNavi.CurrentCell = grdNavi(0, saveCurrentRow)
            fillData(grdNavi.CurrentCell.Value)
        End If

    End Sub
End Class