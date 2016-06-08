Imports System.ComponentModel

Public Class MemberForm

    Private MaxQueryCount As Integer = 11
    Private Enum queryENUM
        READ_ALL
        READ
        INSERT
        UPDATE
        DELETE
        READ_DUTY
        READ_EDUCATION
        READ_PROVINCE
        READ_AVAILABLE_CODE 'Find the available minimum Code in the Table
        READ_POSTAL_CODE
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
        _SQL(queryENUM.READ_ALL) =
            "SELECT MemberCode, IIF(KoreanName IS NULL OR KoreanName = '', EnglishName, " +
                "IIF(EngLishName Is NULL Or EnglishName = '', KoreanName, CONCAT(KoreanName, '(', " +
                "EnglishName, ')'))) AS ViewName " +
            "FROM Tbl_Member ORDER BY MemberCode"
        _SQL(queryENUM.READ) = "SELECT * FROM Tbl_Member WHERE MemberCode = @MemberCode"
        _SQL(queryENUM.INSERT) =
            "INSERT INTO Tbl_Member ( [MemberCode], [KoreanName], [EnglishName], [Sex], [EducationCode], [HouseHolderCode], " +
                "[Phone1Kind], [Phone1No], [Phone2Kind], [Phone2No], [Phone3Kind], [Phone3No], [Email], [PostalCode], [Address], " +
                "[City], [ProvinceCode], [DutyCode], [Remark], [IsDeleted] ) " +
                "VALUES ( @MemberCode, @KoreanName, @EnglishName, @Sex, @EducationCode, @HouseHolderCode, @Phone1Kind, @Phone1No, " +
                "@Phone2Kind, @Phone2No, @Phone3Kind, @Phone3No, @Email, @PostalCode, @Address, @City, @ProvinceCode, " +
                "@DutyCode, @Remark, @IsDeleted)"
        _SQL(queryENUM.UPDATE) =
            "UPDATE Tbl_Member SET [KoreanName] = @KoreanName, [EnglishName] = @EnglishName, [Sex] = @Sex, " +
                "[EducationCode] = @EducationCode, [HouseHolderCode] = @HouseHolderCode, [Phone1Kind] = @Phone1Kind, " +
                "[Phone1No] = @Phone1No, [Phone2Kind] = @Phone2Kind, [Phone2No] = @Phone2No, [Phone3Kind] = @Phone3Kind, " +
                "[Phone3No] = @Phone3No, [Email] = @Email, [PostalCode] = @PostalCode, [Address] = @Address, [City] = @City, " +
                "[ProvinceCode] = @ProvinceCode, [DutyCode] = @DutyCode, [Remark] = @Remark, [IsDeleted] = @IsDeleted " +
                "WHERE MemberCode = @MemberCode"
        _SQL(queryENUM.DELETE) = "DELETE FROM Tbl_Member WHERE MemberCode = @MemberCode"
        _SQL(queryENUM.READ_DUTY) = "SELECT DutyCode, DutyName FROM Tbl_Duty"
        _SQL(queryENUM.READ_EDUCATION) = "SELECT EducationCode, EducationName FROM Tbl_Education"
        _SQL(queryENUM.READ_PROVINCE) = "SELECT ProvinceCode, ProvinceName FROM Tbl_Province"
        _SQL(queryENUM.READ_AVAILABLE_CODE) =
            "SELECT MIN(MemberCode + 1) FROM Tbl_Member " +
                "WHERE (MemberCode + 1) Not In (SELECT MemberCode FROM Tbl_Member)"
        _SQL(queryENUM.READ_POSTAL_CODE) = "SELECT * FROM Tbl_PostalArea WHERE PostalAreaCode = @PostalAreaCode"

        ' Add any initialization after the InitializeComponent() call.
        _Conn = New SqlConnection(My.Settings.DbConn)
        _Conn.Open()

    End Sub

    Protected Overrides Sub Finalize()
        _Conn.Close()
        MyBase.Finalize()
    End Sub

    Private Sub MemberForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        checkChangedField()
    End Sub

    Private Sub MemberForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If _FirstSW = True Then
            fillComboData()
            fillGrid()
            _FirstSW = False
        End If
    End Sub

    Private Sub menuButtons_Click(sender As Object, e As EventArgs) Handles newTSB.Click, deleteTSB.Click,
        firstTSB.Click, previousTSB.Click, nextTSB.Click, lastTSB.Click, refreshTSB.Click, saveTSB.Click,
        closeTSB.Click, searchTSB.Click

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
            Case "searchTSB" : searchName()
            Case "saveTSB" : saveCurrentRecord()
            Case "closeTSB" : Close()
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

    Private Sub control_GotFocus(sender As Object, e As EventArgs) Handles txtKoreanName.GotFocus,
        txtEnglishName.GotFocus, txtPhone1No.GotFocus, txtPhone2No.GotFocus, txtPhone3No.GotFocus,
        txtEmail.GotFocus, txtPostalCode.GotFocus, txtAddress.GotFocus, txtCity.GotFocus,
        txtRemark.GotFocus
        sender.SelectAll()
    End Sub

    Private Sub control_Changed(sender As Object, e As EventArgs) Handles txtKoreanName.TextChanged,
        txtEnglishName.TextChanged, rdoMale.CheckedChanged, rdoFemale.CheckedChanged,
        cboEducation.SelectedIndexChanged, txtHouseHolderCode.TextChanged, cboPhone1Kind.SelectedIndexChanged,
        txtPhone1No.TextChanged, cboPhone2Kind.SelectedIndexChanged, txtPhone2No.TextChanged,
        cboPhone3Kind.SelectedIndexChanged, txtPhone3No.TextChanged, txtEmail.TextChanged,
        txtPostalCode.TextChanged, txtAddress.TextChanged, txtCity.TextChanged, cboProvince.SelectedIndexChanged,
        cboDuty.SelectedIndexChanged, txtRemark.TextChanged, chkIsDeleted.CheckedChanged

        If _AddSW = True Or _UpdateSW = True Then
            _ChangedSW = True
            saveTSB.Enabled = True
        End If
    End Sub

    Private Sub control_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMemberCode.KeyDown,
        txtKoreanName.KeyDown, txtEnglishName.KeyDown, cboEducation.KeyDown, cboPhone1Kind.KeyDown,
        txtPhone1No.KeyDown, cboPhone2Kind.KeyDown, txtPhone2No.KeyDown, cboPhone3Kind.KeyDown,
        txtPhone3No.KeyDown, txtPostalCode.KeyDown, txtAddress.KeyDown, txtCity.KeyDown,
        cboProvince.KeyDown, cboDuty.KeyDown, txtRemark.KeyDown

        Dim nextControl As Control
        If e.KeyCode = Keys.Enter Then
            nextControl = GetNextControl(sender, True)
            If nextControl Is Nothing Then
                nextControl = GetNextControl(Nothing, True)
            End If
            nextControl.Focus()
            e.SuppressKeyPress = True   'This will prevent ding sound.
        End If
    End Sub

    Private Sub txtMemberCode_Validating(sender As Object, e As CancelEventArgs) Handles txtMemberCode.Validating
        If _AddSW = False Then Exit Sub

        If txtMemberCode.Text.Length = 5 Then
            Dim command As New SqlCommand(_SQL(queryENUM.READ), _Conn)
            command.Parameters.Add("@MemberCode", SqlDbType.Char)
            command.Parameters("@MemberCode").Value = txtMemberCode.Text
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                MessageBox.Show("The code has already used. Use an another code!",
                "Duplicated code", MessageBoxButtons.OK)
                txtMemberCode.Focus()
                e.Cancel = True
            Else
                txtHouseHolderCode.Text = txtMemberCode.Text
                lblHouseHolderName.Text = "Principal"
            End If
            reader.Close()
        Else
            MessageBox.Show("The length Of the code should be 5. Re-enter!",
                "Wrong code", MessageBoxButtons.OK)
            txtMemberCode.Focus()
            e.Cancel = True
        End If
    End Sub

    Private Sub postalCodeTB_Validating(sender As Object, e As CancelEventArgs) Handles txtPostalCode.Validating
        postalAreaLL.Text = ""
        If txtPostalCode.Text.Length = 6 Then
            Dim areaCode As String = txtPostalCode.Text.Substring(0, 3)
            Dim command As New SqlCommand(_SQL(queryENUM.READ_POSTAL_CODE), _Conn)
            command.Parameters.Add("@PostalAreaCode", SqlDbType.Char)
            command.Parameters("@PostalAreaCode").Value = areaCode
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows And reader.Read() = True Then
                postalAreaLL.Text = reader("PlaceName")
                cboProvince.SelectedValue = reader("ProvinceCode")
            End If
            reader.Close()
        ElseIf txtPostalCode.Text.Length <> 0 Then
            MessageBox.Show("The wrong postal code has been used. Use an another code!",
                "Wrong postal code", MessageBoxButtons.OK)
            txtPostalCode.Focus()
            e.Cancel = True
        End If
    End Sub

    Private Sub btnFindHouseHolder_Click(sender As Object, e As EventArgs) Handles btnFindHouseHolder.Click
        Dim findMemberForm As FindMemberForm = New FindMemberForm()
        Dim result As DialogResult = findMemberForm.ShowDialog()
        If result = vbOK Then
            _ChangedSW = True
            txtHouseHolderCode.Text = findMemberForm.memberCode
            lblHouseHolderName.Text = readHouseHolder(txtHouseHolderCode.Text)
            cboPhone1Kind.Focus()
        End If
    End Sub

    Private Sub searchName()
        Dim findMemberForm As FindMemberForm = New FindMemberForm()
        Dim result As DialogResult = findMemberForm.ShowDialog()
        If result = vbOK Then
            For i As Integer = 0 To grdNavi.RowCount - 1
                If findMemberForm.memberCode = grdNavi(0, i).Value Then
                    grdNavi.CurrentCell = grdNavi(0, i)
                End If
            Next
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
        Dim phoneKind() = {"Mobile", "Home", "Work", "Main", "Home Fax", "Work Fax", "Other"}

        Me.Cursor = Cursors.WaitCursor

        cboEducation.DataSource = GetEducationItems()
        cboEducation.DisplayMember = "Name"
        cboEducation.ValueMember = "Code"

        cboDuty.DataSource = GetDutyItems()
        cboDuty.DisplayMember = "Name"
        cboDuty.ValueMember = "Code"

        cboProvince.DataSource = GetProvinceItems()
        cboProvince.DisplayMember = "Name"
        cboProvince.ValueMember = "Code"

        For index As Integer = 0 To phoneKind.Length - 1 Step 1
            cboPhone1Kind.Items.Add(phoneKind(index))
            cboPhone2Kind.Items.Add(phoneKind(index))
            cboPhone3Kind.Items.Add(phoneKind(index))
        Next
        cboPhone1Kind.SelectedIndex = 0
        cboPhone2Kind.SelectedIndex = 0
        cboPhone3Kind.SelectedIndex = 0

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub fillGrid()
        Dim command As New SqlCommand(_SQL(queryENUM.READ_ALL), _Conn)

        Me.Cursor = Cursors.WaitCursor

        grdNavi.RowCount = 0

        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                grdNavi.Rows.Add(reader.Item("MemberCode"), reader.Item("ViewName"))
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
        command.Parameters.Add("@MemberCode", SqlDbType.Char)
        command.Parameters("@MemberCode").Value = code
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            txtMemberCode.Text = reader("MemberCode")
            txtMemberCode.BackColor = SystemColors.InactiveCaption
            txtMemberCode.ReadOnly = True
            txtKoreanName.Text = IIf(IsDBNull(reader("KoreanName")), "", reader("KoreanName"))
            txtEnglishName.Text = IIf(IsDBNull(reader("EnglishName")), "", reader("EnglishName"))
            If reader("Sex") = "M" Then rdoMale.Checked = True Else rdoFemale.Checked = True
            cboEducation.SelectedValue = reader("EducationCode")
            txtHouseHolderCode.Text = IIf(IsDBNull(reader("HouseHolderCode")), "", reader("HouseHolderCode"))
            cboPhone1Kind.SelectedItem = reader("Phone1Kind")
            txtPhone1No.Text = IIf(IsDBNull(reader("Phone1No")), "", reader("Phone1No"))
            cboPhone2Kind.SelectedItem = reader("Phone2Kind")
            txtPhone2No.Text = IIf(IsDBNull(reader("Phone2No")), "", reader("Phone2No"))
            cboPhone3Kind.SelectedItem = reader("Phone3Kind")
            txtPhone3No.Text = IIf(IsDBNull(reader("Phone3No")), "", reader("Phone3No"))
            txtEmail.Text = IIf(IsDBNull(reader("Email")), "", reader("Email"))
            txtPostalCode.Text = IIf(IsDBNull(reader("PostalCode")), "", reader("PostalCode"))
            txtAddress.Text = IIf(IsDBNull(reader("Address")), "", reader("Address"))
            txtCity.Text = IIf(IsDBNull(reader("City")), "", reader("City"))
            cboProvince.SelectedValue = reader("ProvinceCode")
            cboDuty.SelectedValue = reader("DutyCode")
            txtRemark.Text = IIf(IsDBNull(reader("Remark")), "", reader("Remark"))
            chkIsDeleted.Checked = IIf(reader("isDeleted") = "Y", True, False)
            reader.Close()
            lblHouseHolderName.Text = readHouseHolder(txtHouseHolderCode.Text)
            postalAreaLL.Text = readPostalArea(txtPostalCode.Text)
        Else
            reader.Close()
        End If

        _UpdateSW = True
        _ChangedSW = False
        _AddSW = False

        newTSB.Enabled = True
        saveTSB.Enabled = False
        deleteTSB.Enabled = True

        txtKoreanName.Focus()

    End Sub

    Private Sub clearAllFields()
        txtMemberCode.Text = ""
        txtKoreanName.Text = ""
        txtEnglishName.Text = ""
        rdoMale.Checked = True
        cboEducation.SelectedIndex = 0
        txtHouseHolderCode.Text = ""
        lblHouseHolderName.Text = ""
        cboPhone1Kind.SelectedItem = "Mobile"
        txtPhone1No.Text = ""
        cboPhone2Kind.SelectedItem = "Home"
        txtPhone2No.Text = ""
        cboPhone3Kind.SelectedItem = "Work"
        txtPhone3No.Text = ""
        txtEmail.Text = ""
        txtPostalCode.Text = ""
        postalAreaLL.Text = ""
        txtAddress.Text = ""
        txtCity.Text = "Ottawa"
        cboProvince.SelectedValue = "ON"
        cboDuty.SelectedValue = "99"
        txtRemark.Text = ""
        chkIsDeleted.Checked = False

        _AddSW = True
        _ChangedSW = False

        newTSB.Enabled = False
        saveTSB.Enabled = False
        deleteTSB.Enabled = False
    End Sub

    Private Sub createKeyField()
        Dim tmpCode As Int32 = 0

        Dim command As New SqlCommand(_SQL(queryENUM.READ_AVAILABLE_CODE), _Conn)
        Try
            tmpCode = Convert.ToInt32(command.ExecuteScalar())
        Catch ex As Exception
            tmpCode = 1
        Finally
            If tmpCode > 99999 Then
                MessageBox.Show("A member can't be inserted anymore!", "Full data", MessageBoxButtons.OK)
                Close()
            Else
                txtMemberCode.Text = tmpCode.ToString("00000")
                txtMemberCode.ReadOnly = False
                txtMemberCode.BackColor = SystemColors.Window
                txtMemberCode.Focus()
            End If
        End Try
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

            grdNavi.Rows.Add(txtMemberCode.Text, txtKoreanName.Text)
            grdNavi.CurrentCell = grdNavi(0, grdNavi.Rows.Count - 1)
        Else
            Dim command As New SqlCommand(_SQL(queryENUM.UPDATE), _Conn)
            parameterMove(command)
            _UpdateSW = True
            _ChangedSW = False

            newTSB.Enabled = True
            deleteTSB.Enabled = True
            saveTSB.Enabled = False

            grdNavi(1, grdNavi.CurrentRow.Index).Value = txtKoreanName.Text
        End If
    End Sub

    Private Sub parameterMove(ByVal command As SqlCommand)
        command.Parameters.Add("@MemberCode", SqlDbType.Char)
        command.Parameters.Add("@KoreanName", SqlDbType.VarChar)
        command.Parameters.Add("@EnglishName", SqlDbType.VarChar)
        command.Parameters.Add("@Sex", SqlDbType.Char)
        command.Parameters.Add("@EducationCode", SqlDbType.Char)
        command.Parameters.Add("@HouseHolderCode", SqlDbType.Char)
        command.Parameters.Add("@Phone1Kind", SqlDbType.VarChar)
        command.Parameters.Add("@Phone1No", SqlDbType.VarChar)
        command.Parameters.Add("@Phone2Kind", SqlDbType.VarChar)
        command.Parameters.Add("@Phone2No", SqlDbType.VarChar)
        command.Parameters.Add("@Phone3Kind", SqlDbType.VarChar)
        command.Parameters.Add("@Phone3No", SqlDbType.VarChar)
        command.Parameters.Add("@Email", SqlDbType.VarChar)
        command.Parameters.Add("@PostalCode", SqlDbType.Char)
        command.Parameters.Add("@Address", SqlDbType.VarChar)
        command.Parameters.Add("@City", SqlDbType.VarChar)
        command.Parameters.Add("@ProvinceCode", SqlDbType.Char)
        command.Parameters.Add("@DutyCode", SqlDbType.Char)
        command.Parameters.Add("@Remark", SqlDbType.VarChar)
        command.Parameters.Add("@IsDeleted", SqlDbType.Char)

        command.Parameters("@MemberCode").Value = txtMemberCode.Text
        command.Parameters("@KoreanName").Value = txtKoreanName.Text
        command.Parameters("@EnglishName").Value = txtEnglishName.Text
        command.Parameters("@Sex").Value = IIf(rdoFemale.Checked = True, "F", "M")
        command.Parameters("@EducationCode").Value = cboEducation.SelectedValue
        command.Parameters("@HouseHolderCode").Value = txtHouseHolderCode.Text
        command.Parameters("@Phone1Kind").Value = cboPhone1Kind.Text
        command.Parameters("@Phone1No").Value = txtPhone1No.Text
        command.Parameters("@Phone2Kind").Value = cboPhone2Kind.Text
        command.Parameters("@Phone2No").Value = txtPhone2No.Text
        command.Parameters("@Phone3Kind").Value = cboPhone3Kind.Text
        command.Parameters("@Phone3No").Value = txtPhone3No.Text
        command.Parameters("@Email").Value = txtEmail.Text
        command.Parameters("@PostalCode").Value = txtPostalCode.Text
        command.Parameters("@Address").Value = txtAddress.Text
        command.Parameters("@City").Value = txtCity.Text
        command.Parameters("@ProvinceCode").Value = cboProvince.SelectedValue
        command.Parameters("@DutyCode").Value = cboDuty.SelectedValue
        command.Parameters("@Remark").Value = txtRemark.Text
        command.Parameters("@IsDeleted").Value = IIf(chkIsDeleted.Checked = True, "Y", "N")

        command.ExecuteNonQuery()
    End Sub

    Private Sub deleteCurrentRecord()
        Dim result As DialogResult = MessageBox.Show("Deleted data can't be recovered. Delete it?",
                "Confirmation to delete", MessageBoxButtons.YesNo)
        If result = vbNo Then Exit Sub

        Dim command As New SqlCommand(_SQL(queryENUM.DELETE), _Conn)
        command.Parameters.Add("@MemberCode", SqlDbType.Char)
        command.Parameters("@MemberCode").Value = txtMemberCode.Text

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

    Private Function readHouseHolder(ByVal memberCode As String) As String
        If memberCode = txtMemberCode.Text Then Return "Principal"

        Dim command As New SqlCommand(_SQL(queryENUM.READ), _Conn)
        command.Parameters.Add("@MemberCode", SqlDbType.Char)
        command.Parameters("@MemberCode").Value = memberCode
        Dim rd As SqlDataReader = command.ExecuteReader()

        If rd.HasRows Then
            rd.Read()
            Dim kn = IIf(String.IsNullOrEmpty(rd("KoreanName")), "",
                IIf(String.IsNullOrEmpty(rd("EnglishName")), rd("KoreanName"),
                rd("KoreanName") + "(" + rd("EnglishName") + ")"))
            rd.Close()
            Return kn
        Else
            rd.Close()
            Return "Error Householder code"
        End If
    End Function

    Private Function readPostalArea(ByVal postalCode As String) As String
        Dim areaName As String = ""

        If postalCode.Length = 6 Then
            Dim areaCode As String = postalCode.Substring(0, 3)
            Dim command As New SqlCommand(_SQL(queryENUM.READ_POSTAL_CODE), _Conn)
            command.Parameters.Add("@PostalAreaCode", SqlDbType.Char)
            command.Parameters("@PostalAreaCode").Value = areaCode
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows And reader.Read() = True Then
                areaName = reader("PlaceName")
            End If
            reader.Close()
        End If
        Return areaName
    End Function

    Function GetEducationItems() As List(Of ItemStructure)
        Dim items = New List(Of ItemStructure)
        Dim command As New SqlCommand(_SQL(queryENUM.READ_EDUCATION), _Conn)

        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                items.Add(New ItemStructure(reader("EducationCode"), reader("EducationName")))
            End While
            reader.Close()
            Return items
        Else
            reader.Close()
            MessageBox.Show("There should be more than one data for education code!", "Empty data", MessageBoxButtons.OK)
            Close()
            Return Nothing
        End If
    End Function

    Function GetDutyItems() As List(Of ItemStructure)
        Dim items = New List(Of ItemStructure)
        Dim command As New SqlCommand(_SQL(queryENUM.READ_DUTY), _Conn)

        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                items.Add(New ItemStructure(reader("DutyCode"), reader("DutyName")))
            End While
            reader.Close()
            Return items
        Else
            reader.Close()
            MessageBox.Show("There should be more than one data for duty code!", "Empty data", MessageBoxButtons.OK)
            Close()
            Return Nothing
        End If
    End Function

    Function GetProvinceItems() As List(Of ItemStructure)
        Dim items = New List(Of ItemStructure)
        Dim command As New SqlCommand(_SQL(queryENUM.READ_PROVINCE), _Conn)

        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                items.Add(New ItemStructure(reader("ProvinceCode"), reader("ProvinceName")))
            End While
            reader.Close()
            Return items
        Else
            reader.Close()
            MessageBox.Show("There should be more than one data for province code!", "Empty data", MessageBoxButtons.OK)
            Close()
            Return Nothing
        End If
    End Function

End Class

Public Class ItemStructure
    Private mCode As String
    Private mName As String

    Public Sub New(ByVal code As String, ByVal name As String)
        mCode = code
        mName = name
    End Sub

    Public ReadOnly Property Code() As String
        Get
            Return mCode
        End Get
    End Property

    Public ReadOnly Property Name() As String
        Get
            Return mName
        End Get
    End Property
End Class
