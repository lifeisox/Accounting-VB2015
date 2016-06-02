Imports System.ComponentModel

Public Class MemberForm

    Private ivMaxQueryCount As Integer = 11
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
        ivSQL(queryENUM.READ_ALL) =
            "SELECT MemberCode, IIF(KoreanName IS NULL OR KoreanName = '', EnglishName, " +
                "IIF(EngLishName Is NULL Or EnglishName = '', KoreanName, CONCAT(KoreanName, '(', " +
                "EnglishName, ')'))) AS ViewName " +
            "FROM Tbl_Member ORDER BY MemberCode"
        ivSQL(queryENUM.READ) = "SELECT * FROM Tbl_Member WHERE MemberCode = @MemberCode"
        ivSQL(queryENUM.INSERT) =
            "INSERT INTO Tbl_Member ( [MemberCode], [KoreanName], [EnglishName], [Sex], [EducationCode], [HouseHolderCode], " +
                "[Phone1Kind], [Phone1No], [Phone2Kind], [Phone2No], [Phone3Kind], [Phone3No], [Email], [PostalCode], [Address], " +
                "[City], [ProvinceCode], [DutyCode], [Remark], [IsDeleted] ) " +
                "VALUES ( @MemberCode, @KoreanName, @EnglishName, @Sex, @EducationCode, @HouseHolderCode, @Phone1Kind, @Phone1No, " +
                "@Phone2Kind, @Phone2No, @Phone3Kind, @Phone3No, @Email, @PostalCode, @Address, @City, @ProvinceCode, " +
                "@DutyCode, @Remark, @IsDeleted)"
        ivSQL(queryENUM.UPDATE) =
            "UPDATE Tbl_Member SET [KoreanName] = @KoreanName, [EnglishName] = @EnglishName, [Sex] = @Sex, " +
                "[EducationCode] = @EducationCode, [HouseHolderCode] = @HouseHolderCode, [Phone1Kind] = @Phone1Kind, " +
                "[Phone1No] = @Phone1No, [Phone2Kind] = @Phone2Kind, [Phone2No] = @Phone2No, [Phone3Kind] = @Phone3Kind, " +
                "[Phone3No] = @Phone3No, [Email] = @Email, [PostalCode] = @PostalCode, [Address] = @Address, [City] = @City, " +
                "[ProvinceCode] = @ProvinceCode, [DutyCode] = @DutyCode, [Remark] = @Remark, [IsDeleted] = @IsDeleted " +
                "WHERE MemberCode = @MemberCode"
        ivSQL(queryENUM.DELETE) = "DELETE FROM Tbl_Member WHERE MemberCode = @MemberCode"
        ivSQL(queryENUM.READ_DUTY) = "SELECT DutyCode, DutyName FROM Tbl_Duty"
        ivSQL(queryENUM.READ_EDUCATION) = "SELECT EducationCode, EducationName FROM Tbl_Education"
        ivSQL(queryENUM.READ_PROVINCE) = "SELECT ProvinceCode, ProvinceName FROM Tbl_Province"
        ivSQL(queryENUM.READ_AVAILABLE_CODE) =
            "SELECT MIN(MemberCode + 1) FROM Tbl_Member " +
                "WHERE (MemberCode + 1) Not In (SELECT MemberCode FROM Tbl_Member)"
        ivSQL(queryENUM.READ_POSTAL_CODE) = "SELECT * FROM Tbl_PostalArea WHERE PostalAreaCode = @PostalAreaCode"

        ' Add any initialization after the InitializeComponent() call.
        ivConnection = New SqlConnection(My.Settings.DbConn)
        ivConnection.Open()

    End Sub

    Protected Overrides Sub Finalize()
        ivConnection.Close()
        MyBase.Finalize()
    End Sub

    Private Sub memberFM_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        checkChangedField()
    End Sub

    Private Sub memberFM_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If ivFirstSW = True Then
            fillComboData()
            fillGrid()
            ivFirstSW = False
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
                naviDGV.CurrentCell = naviDGV(0, 0)
            Case "previousTSB"
                If naviDGV.CurrentRow.Index > 0 Then
                    naviDGV.CurrentCell = naviDGV(0, naviDGV.CurrentRow.Index - 1)
                End If
            Case "nextTSB"
                If naviDGV.CurrentRow.Index < naviDGV.RowCount - 1 Then
                    naviDGV.CurrentCell = naviDGV(0, naviDGV.CurrentRow.Index + 1)
                End If
            Case "lastTSB" : naviDGV.CurrentCell = naviDGV(0, naviDGV.RowCount - 1)
            Case "refreshTSB" : fillGrid()
            Case "searchTSB" : searchName()
            Case "saveTSB" : saveCurrentRecord()
            Case "closeTSB" : Close()
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

    Private Sub control_GotFocus(sender As Object, e As EventArgs) Handles koreanNameTB.GotFocus,
        englishNameTB.GotFocus, phone1NoTB.GotFocus, phone2NoTB.GotFocus, phone3NoTB.GotFocus,
        emailTB.GotFocus, cityTB.GotFocus, postalCodeTB.GotFocus
        sender.SelectAll()
    End Sub

    Private Sub control_Changed(sender As Object, e As EventArgs) Handles koreanNameTB.TextChanged,
        englishNameTB.TextChanged, educationCB.SelectedIndexChanged, maleRB.CheckedChanged, femaleRB.CheckedChanged,
        phone1KindCB.SelectedIndexChanged, phone1NoTB.TextChanged, phone2KindCB.SelectedIndexChanged, phone2NoTB.TextChanged,
        phone3KindCB.SelectedIndexChanged, phone3NoTB.TextChanged, emailTB.TextChanged, postalCodeTB.TextAlignChanged,
        cityTB.TextChanged, provinceCB.SelectedIndexChanged, dutyCB.SelectedIndexChanged, isDeletedCB.CheckedChanged,
        addressTB.TextChanged, remarkTB.TextChanged

        If ivAddSW = True Or ivUpdateSW = True Then
            ivChangedSW = True
            saveTSB.Enabled = True
        End If
    End Sub

    Private Sub control_KeyDown(sender As Object, e As KeyEventArgs) Handles memberCodeTB.KeyDown,
        koreanNameTB.KeyDown, englishNameTB.KeyDown, educationCB.KeyDown, postalCodeTB.KeyDown,
        phone1KindCB.KeyDown, phone1NoTB.KeyDown, phone2KindCB.KeyDown, phone2NoTB.KeyDown,
        phone3KindCB.KeyDown, phone3NoTB.KeyDown, emailTB.KeyDown,
        cityTB.KeyDown, provinceCB.KeyDown, dutyCB.KeyDown, isDeletedCB.KeyDown
        ' maleRB.KeyDown, femaleRB.KeyDown, findBN.KeyDown, addressTB.KeyDown, remarkTB.KeyDown 
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

    Private Sub memberCodeTB_Validating(sender As Object, e As CancelEventArgs) Handles memberCodeTB.Validating
        If ivAddSW = False Then Exit Sub

        If memberCodeTB.Text.Length = 5 Then
            Dim command As New SqlCommand(ivSQL(queryENUM.READ), ivConnection)
            command.Parameters.Add("@MemberCode", SqlDbType.Char)
            command.Parameters("@MemberCode").Value = memberCodeTB.Text
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                MessageBox.Show("The code has already used. Use an another code!",
                "Duplicated code", MessageBoxButtons.OK)
                memberCodeTB.Focus()
                e.Cancel = True
            Else
                houseHolderCodeTB.Text = memberCodeTB.Text
                houseHolderNameLL.Text = "Principal"
            End If
            reader.Close()
        Else
            MessageBox.Show("The length Of the code should be 5. Re-enter!",
                "Wrong code", MessageBoxButtons.OK)
            memberCodeTB.Focus()
            e.Cancel = True
        End If
    End Sub

    Private Sub postalCodeTB_Validating(sender As Object, e As CancelEventArgs) Handles postalCodeTB.Validating
        postalAreaLL.Text = ""
        If postalCodeTB.Text.Length = 6 Then
            Dim areaCode As String = postalCodeTB.Text.Substring(0, 3)
            Dim command As New SqlCommand(ivSQL(queryENUM.READ_POSTAL_CODE), ivConnection)
            command.Parameters.Add("@PostalAreaCode", SqlDbType.Char)
            command.Parameters("@PostalAreaCode").Value = areaCode
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows And reader.Read() = True Then
                postalAreaLL.Text = reader("PlaceName")
                provinceCB.SelectedValue = reader("ProvinceCode")
            End If
            reader.Close()
        ElseIf postalCodeTB.Text.Length <> 0 Then

            MessageBox.Show("The wrong postal code has been used. Use an another code!",
                "Wrong postal code", MessageBoxButtons.OK)
            postalCodeTB.Focus()
            e.Cancel = True
        End If
    End Sub

    Private Sub findBN_Click(sender As Object, e As EventArgs) Handles findBN.Click
        Dim findMemberForm As FindMemberForm = New FindMemberForm()
        Dim result As DialogResult = findMemberForm.ShowDialog()
        If result = vbOK Then
            ivChangedSW = True
            houseHolderCodeTB.Text = findMemberForm.memberCode
            houseHolderNameLL.Text = readHouseHolder(houseHolderCodeTB.Text)
            phone1KindCB.Focus()
        End If
    End Sub

    Private Sub searchName()
        Dim findMemberForm As FindMemberForm = New FindMemberForm()
        Dim result As DialogResult = findMemberForm.ShowDialog()
        If result = vbOK Then
            For i As Integer = 0 To naviDGV.RowCount - 1
                If findMemberForm.memberCode = naviDGV(0, i).Value Then
                    naviDGV.CurrentCell = naviDGV(0, i)
                End If
            Next
            ivChangedSW = True
            houseHolderCodeTB.Text = findMemberForm.memberCode
            phone1KindCB.Focus()
        End If
    End Sub

    Private Sub checkChangedField()
        If (ivAddSW = True Or ivUpdateSW = True) And ivChangedSW = True Then
            Dim result As DialogResult = MessageBox.Show("There are some changed data. Save it?",
                "Confirmation To save", MessageBoxButtons.YesNo)
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

    Private Sub fillComboData()
        Dim phoneKind() = {"Mobile", "Home", "Work", "Main", "Home Fax", "Work Fax", "Other"}

        Me.Cursor = Cursors.WaitCursor

        educationCB.DataSource = GetEducationItems()
        educationCB.DisplayMember = "Name"
        educationCB.ValueMember = "Code"

        dutyCB.DataSource = GetDutyItems()
        dutyCB.DisplayMember = "Name"
        dutyCB.ValueMember = "Code"

        provinceCB.DataSource = GetProvinceItems()
        provinceCB.DisplayMember = "Name"
        provinceCB.ValueMember = "Code"

        For index As Integer = 0 To phoneKind.Length - 1 Step 1
            phone1KindCB.Items.Add(phoneKind(index))
            phone2KindCB.Items.Add(phoneKind(index))
            phone3KindCB.Items.Add(phoneKind(index))
        Next
        phone1KindCB.SelectedIndex = 0
        phone2KindCB.SelectedIndex = 0
        phone3KindCB.SelectedIndex = 0

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub fillGrid()
        Dim command As New SqlCommand(ivSQL(queryENUM.READ_ALL), ivConnection)

        Me.Cursor = Cursors.WaitCursor

        naviDGV.RowCount = 0

        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                naviDGV.Rows.Add(reader.Item("MemberCode"), reader.Item("ViewName"))
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
        command.Parameters.Add("@MemberCode", SqlDbType.Char)
        command.Parameters("@MemberCode").Value = code
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            memberCodeTB.Text = reader("MemberCode")
            memberCodeTB.BackColor = SystemColors.InactiveCaption
            memberCodeTB.ReadOnly = True
            koreanNameTB.Text = IIf(String.IsNullOrEmpty(reader("KoreanName")), "", reader("KoreanName"))
            englishNameTB.Text = IIf(String.IsNullOrEmpty(reader("EnglishName")), "", reader("EnglishName"))
            If reader("Sex") = "M" Then maleRB.Checked = True Else femaleRB.Checked = True
            educationCB.SelectedValue = reader("EducationCode")
            houseHolderCodeTB.Text = IIf(String.IsNullOrEmpty(reader("HouseHolderCode")), "", reader("HouseHolderCode"))
            phone1KindCB.SelectedItem = reader("Phone1Kind")
            phone1NoTB.Text = IIf(String.IsNullOrEmpty(reader("Phone1No")), "", reader("Phone1No"))
            phone2KindCB.SelectedItem = reader("Phone2Kind")
            phone2NoTB.Text = IIf(String.IsNullOrEmpty(reader("Phone2No")), "", reader("Phone2No"))
            phone3KindCB.SelectedItem = reader("Phone3Kind")
            phone3NoTB.Text = IIf(String.IsNullOrEmpty(reader("Phone3No")), "", reader("Phone3No"))
            emailTB.Text = IIf(String.IsNullOrEmpty(reader("Email")), "", reader("Email"))
            postalCodeTB.Text = IIf(String.IsNullOrEmpty(reader("PostalCode")), "", reader("PostalCode"))
            addressTB.Text = IIf(String.IsNullOrEmpty(reader("Address")), "", reader("Address"))
            cityTB.Text = IIf(String.IsNullOrEmpty(reader("City")), "", reader("City"))
            provinceCB.SelectedValue = reader("ProvinceCode")
            dutyCB.SelectedValue = reader("DutyCode")
            remarkTB.Text = IIf(String.IsNullOrEmpty(reader("Remark")), "", reader("Remark"))
            isDeletedCB.Checked = IIf(reader("isDeleted") = "Y", True, False)
            reader.Close()
            houseHolderNameLL.Text = readHouseHolder(houseHolderCodeTB.Text)
            postalAreaLL.Text = readPostalArea(postalCodeTB.Text)
        Else
            reader.Close()
        End If

        ivUpdateSW = True
        ivChangedSW = False
        ivAddSW = False

        newTSB.Enabled = True
        saveTSB.Enabled = False
        deleteTSB.Enabled = True

        koreanNameTB.Focus()

    End Sub

    Private Sub clearAllFields()
        memberCodeTB.Text = ""
        koreanNameTB.Text = ""
        englishNameTB.Text = ""
        maleRB.Checked = True
        educationCB.SelectedIndex = 0
        houseHolderCodeTB.Text = ""
        houseHolderNameLL.Text = ""
        phone1KindCB.SelectedItem = "Mobile"
        phone1NoTB.Text = ""
        phone2KindCB.SelectedItem = "Home"
        phone2NoTB.Text = ""
        phone3KindCB.SelectedItem = "Work"
        phone3NoTB.Text = ""
        emailTB.Text = ""
        postalCodeTB.Text = ""
        postalAreaLL.Text = ""
        addressTB.Text = ""
        cityTB.Text = "Ottawa"
        provinceCB.SelectedValue = "ON"
        dutyCB.SelectedValue = "99"
        remarkTB.Text = ""
        isDeletedCB.Checked = False

        ivAddSW = True
        ivChangedSW = False

        newTSB.Enabled = False
        saveTSB.Enabled = False
        deleteTSB.Enabled = False
    End Sub

    Private Sub createKeyField()
        Dim tmpCode As Int32 = 0

        Dim command As New SqlCommand(ivSQL(queryENUM.READ_AVAILABLE_CODE), ivConnection)
        Try
            tmpCode = Convert.ToInt32(command.ExecuteScalar())
        Catch ex As Exception
            tmpCode = 1
        Finally
            If tmpCode > 99999 Then
                MessageBox.Show("A member can't be inserted anymore!", "Full data", MessageBoxButtons.OK)
                Close()
            Else
                memberCodeTB.Text = tmpCode.ToString("00000")
                memberCodeTB.ReadOnly = False
                memberCodeTB.BackColor = SystemColors.Window
                memberCodeTB.Focus()
            End If
        End Try
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

            naviDGV.Rows.Add(memberCodeTB.Text, koreanNameTB.Text)
            naviDGV.CurrentCell = naviDGV(0, naviDGV.Rows.Count - 1)
        Else
            Dim command As New SqlCommand(ivSQL(queryENUM.UPDATE), ivConnection)
            parameterMove(command)
            ivUpdateSW = True
            ivChangedSW = False

            newTSB.Enabled = True
            deleteTSB.Enabled = True
            saveTSB.Enabled = False

            naviDGV(1, naviDGV.CurrentRow.Index).Value = koreanNameTB.Text
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

        command.Parameters("@MemberCode").Value = memberCodeTB.Text
        command.Parameters("@KoreanName").Value = koreanNameTB.Text
        command.Parameters("@EnglishName").Value = englishNameTB.Text
        command.Parameters("@Sex").Value = IIf(femaleRB.Checked = True, "F", "M")
        command.Parameters("@EducationCode").Value = educationCB.SelectedValue
        command.Parameters("@HouseHolderCode").Value = houseHolderCodeTB.Text
        command.Parameters("@Phone1Kind").Value = phone1KindCB.Text
        command.Parameters("@Phone1No").Value = phone1NoTB.Text
        command.Parameters("@Phone2Kind").Value = phone2KindCB.Text
        command.Parameters("@Phone2No").Value = phone2NoTB.Text
        command.Parameters("@Phone3Kind").Value = phone3KindCB.Text
        command.Parameters("@Phone3No").Value = phone3NoTB.Text
        command.Parameters("@Email").Value = emailTB.Text
        command.Parameters("@PostalCode").Value = postalCodeTB.Text
        command.Parameters("@Address").Value = addressTB.Text
        command.Parameters("@City").Value = cityTB.Text
        command.Parameters("@ProvinceCode").Value = provinceCB.SelectedValue
        command.Parameters("@DutyCode").Value = dutyCB.SelectedValue
        command.Parameters("@Remark").Value = remarkTB.Text
        command.Parameters("@IsDeleted").Value = IIf(isDeletedCB.Checked = True, "Y", "N")

        command.ExecuteNonQuery()
    End Sub

    Private Sub deleteCurrentRecord()
        Dim result As DialogResult = MessageBox.Show("Deleted data can't be recovered. Delete it?",
                "Confirmation to delete", MessageBoxButtons.YesNo)
        If result = vbNo Then Exit Sub

        Dim command As New SqlCommand(ivSQL(queryENUM.DELETE), ivConnection)
        command.Parameters.Add("@MemberCode", SqlDbType.Char)
        command.Parameters("@MemberCode").Value = memberCodeTB.Text

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

    Private Function readHouseHolder(ByVal memberCode As String) As String
        If memberCode = memberCodeTB.Text Then Return "Principal"

        Dim command As New SqlCommand(ivSQL(queryENUM.READ), ivConnection)
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
            Dim command As New SqlCommand(ivSQL(queryENUM.READ_POSTAL_CODE), ivConnection)
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
        Dim command As New SqlCommand(ivSQL(queryENUM.READ_EDUCATION), ivConnection)

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
        Dim command As New SqlCommand(ivSQL(queryENUM.READ_DUTY), ivConnection)

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
        Dim command As New SqlCommand(ivSQL(queryENUM.READ_PROVINCE), ivConnection)

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
