<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MemberForm))
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.naviDGV = New System.Windows.Forms.DataGridView()
        Me.CodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.postalAreaLL = New System.Windows.Forms.Label()
        Me.postalCodeTB = New System.Windows.Forms.MaskedTextBox()
        Me.memberCodeTB = New System.Windows.Forms.MaskedTextBox()
        Me.isDeletedCB = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dutyCB = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.provinceCB = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cityTB = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.addressTB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.remarkTB = New System.Windows.Forms.TextBox()
        Me.emailTB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.phone3NoTB = New System.Windows.Forms.TextBox()
        Me.phone3KindCB = New System.Windows.Forms.ComboBox()
        Me.phone2NoTB = New System.Windows.Forms.TextBox()
        Me.phone2KindCB = New System.Windows.Forms.ComboBox()
        Me.phone1NoTB = New System.Windows.Forms.TextBox()
        Me.phone1KindCB = New System.Windows.Forms.ComboBox()
        Me.findBN = New System.Windows.Forms.Button()
        Me.houseHolderNameLL = New System.Windows.Forms.Label()
        Me.houseHolderCodeTB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.educationCB = New System.Windows.Forms.ComboBox()
        Me.sexGB = New System.Windows.Forms.GroupBox()
        Me.femaleRB = New System.Windows.Forms.RadioButton()
        Me.maleRB = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.englishNameTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.koreanNameTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.menuTS = New System.Windows.Forms.ToolStrip()
        Me.newTSB = New System.Windows.Forms.ToolStripButton()
        Me.deleteTSB = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.firstTSB = New System.Windows.Forms.ToolStripButton()
        Me.previousTSB = New System.Windows.Forms.ToolStripButton()
        Me.nextTSB = New System.Windows.Forms.ToolStripButton()
        Me.lastTSB = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.refreshTSB = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.closeTSB = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.saveTSB = New System.Windows.Forms.ToolStripButton()
        Me.searchTSB = New System.Windows.Forms.ToolStripButton()
        Me.formTT = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        CType(Me.naviDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sexGB.SuspendLayout()
        Me.menuTS.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer
        '
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer.IsSplitterFixed = True
        Me.SplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.SplitContainer.Name = "SplitContainer"
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.naviDGV)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.SplitContainer.Panel2.Controls.Add(Me.postalAreaLL)
        Me.SplitContainer.Panel2.Controls.Add(Me.postalCodeTB)
        Me.SplitContainer.Panel2.Controls.Add(Me.memberCodeTB)
        Me.SplitContainer.Panel2.Controls.Add(Me.isDeletedCB)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label13)
        Me.SplitContainer.Panel2.Controls.Add(Me.dutyCB)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label12)
        Me.SplitContainer.Panel2.Controls.Add(Me.provinceCB)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label11)
        Me.SplitContainer.Panel2.Controls.Add(Me.cityTB)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label10)
        Me.SplitContainer.Panel2.Controls.Add(Me.addressTB)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer.Panel2.Controls.Add(Me.remarkTB)
        Me.SplitContainer.Panel2.Controls.Add(Me.emailTB)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer.Panel2.Controls.Add(Me.phone3NoTB)
        Me.SplitContainer.Panel2.Controls.Add(Me.phone3KindCB)
        Me.SplitContainer.Panel2.Controls.Add(Me.phone2NoTB)
        Me.SplitContainer.Panel2.Controls.Add(Me.phone2KindCB)
        Me.SplitContainer.Panel2.Controls.Add(Me.phone1NoTB)
        Me.SplitContainer.Panel2.Controls.Add(Me.phone1KindCB)
        Me.SplitContainer.Panel2.Controls.Add(Me.findBN)
        Me.SplitContainer.Panel2.Controls.Add(Me.houseHolderNameLL)
        Me.SplitContainer.Panel2.Controls.Add(Me.houseHolderCodeTB)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer.Panel2.Controls.Add(Me.educationCB)
        Me.SplitContainer.Panel2.Controls.Add(Me.sexGB)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer.Panel2.Controls.Add(Me.englishNameTB)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer.Panel2.Controls.Add(Me.koreanNameTB)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer.Panel2.Controls.Add(Me.menuTS)
        Me.SplitContainer.Size = New System.Drawing.Size(882, 404)
        Me.SplitContainer.SplitterDistance = 236
        Me.SplitContainer.TabIndex = 0
        '
        'naviDGV
        '
        Me.naviDGV.AllowUserToAddRows = False
        Me.naviDGV.AllowUserToDeleteRows = False
        Me.naviDGV.AllowUserToResizeColumns = False
        Me.naviDGV.AllowUserToResizeRows = False
        Me.naviDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.naviDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeCol, Me.NameCol})
        Me.naviDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.naviDGV.Location = New System.Drawing.Point(0, 0)
        Me.naviDGV.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.naviDGV.MultiSelect = False
        Me.naviDGV.Name = "naviDGV"
        Me.naviDGV.ReadOnly = True
        Me.naviDGV.RowHeadersVisible = False
        Me.naviDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.naviDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.naviDGV.ShowEditingIcon = False
        Me.naviDGV.Size = New System.Drawing.Size(236, 404)
        Me.naviDGV.TabIndex = 3
        '
        'CodeCol
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodeCol.DefaultCellStyle = DataGridViewCellStyle1
        Me.CodeCol.HeaderText = "Code"
        Me.CodeCol.MaxInputLength = 2
        Me.CodeCol.Name = "CodeCol"
        Me.CodeCol.ReadOnly = True
        Me.CodeCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CodeCol.Width = 50
        '
        'NameCol
        '
        Me.NameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.NameCol.DefaultCellStyle = DataGridViewCellStyle2
        Me.NameCol.HeaderText = "Name"
        Me.NameCol.MaxInputLength = 30
        Me.NameCol.Name = "NameCol"
        Me.NameCol.ReadOnly = True
        Me.NameCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'postalAreaLL
        '
        Me.postalAreaLL.AutoSize = True
        Me.postalAreaLL.Location = New System.Drawing.Point(458, 65)
        Me.postalAreaLL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.postalAreaLL.Name = "postalAreaLL"
        Me.postalAreaLL.Size = New System.Drawing.Size(0, 15)
        Me.postalAreaLL.TabIndex = 99
        Me.postalAreaLL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'postalCodeTB
        '
        Me.postalCodeTB.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.postalCodeTB.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.postalCodeTB.Location = New System.Drawing.Point(392, 62)
        Me.postalCodeTB.Mask = ">A0A0A0"
        Me.postalCodeTB.Name = "postalCodeTB"
        Me.postalCodeTB.ResetOnSpace = False
        Me.postalCodeTB.Size = New System.Drawing.Size(59, 23)
        Me.postalCodeTB.TabIndex = 14
        Me.postalCodeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'memberCodeTB
        '
        Me.memberCodeTB.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.memberCodeTB.Location = New System.Drawing.Point(111, 45)
        Me.memberCodeTB.Mask = "00000"
        Me.memberCodeTB.Name = "memberCodeTB"
        Me.memberCodeTB.ResetOnSpace = False
        Me.memberCodeTB.Size = New System.Drawing.Size(54, 23)
        Me.memberCodeTB.TabIndex = 0
        Me.memberCodeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'isDeletedCB
        '
        Me.isDeletedCB.AutoSize = True
        Me.isDeletedCB.Location = New System.Drawing.Point(392, 332)
        Me.isDeletedCB.Name = "isDeletedCB"
        Me.isDeletedCB.Size = New System.Drawing.Size(124, 19)
        Me.isDeletedCB.TabIndex = 20
        Me.isDeletedCB.Text = "Deleted Member"
        Me.isDeletedCB.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(349, 213)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 15)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "Duty:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dutyCB
        '
        Me.dutyCB.FormattingEnabled = True
        Me.dutyCB.Location = New System.Drawing.Point(392, 210)
        Me.dutyCB.Name = "dutyCB"
        Me.dutyCB.Size = New System.Drawing.Size(181, 23)
        Me.dutyCB.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(321, 177)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 15)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "Province:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'provinceCB
        '
        Me.provinceCB.FormattingEnabled = True
        Me.provinceCB.Location = New System.Drawing.Point(392, 174)
        Me.provinceCB.Name = "provinceCB"
        Me.provinceCB.Size = New System.Drawing.Size(181, 23)
        Me.provinceCB.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(349, 148)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 15)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "City:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cityTB
        '
        Me.cityTB.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.cityTB.Location = New System.Drawing.Point(392, 145)
        Me.cityTB.MaxLength = 30
        Me.cityTB.Name = "cityTB"
        Me.cityTB.Size = New System.Drawing.Size(237, 23)
        Me.cityTB.TabIndex = 16
        Me.cityTB.WordWrap = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(328, 97)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 15)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Address:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'addressTB
        '
        Me.addressTB.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.addressTB.Location = New System.Drawing.Point(392, 94)
        Me.addressTB.MaxLength = 70
        Me.addressTB.Multiline = True
        Me.addressTB.Name = "addressTB"
        Me.addressTB.Size = New System.Drawing.Size(237, 45)
        Me.addressTB.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(314, 65)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 15)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Post Code:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(335, 248)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 15)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Remark:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'remarkTB
        '
        Me.remarkTB.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.remarkTB.Location = New System.Drawing.Point(392, 245)
        Me.remarkTB.MaxLength = 70
        Me.remarkTB.Multiline = True
        Me.remarkTB.Name = "remarkTB"
        Me.remarkTB.Size = New System.Drawing.Size(237, 76)
        Me.remarkTB.TabIndex = 19
        '
        'emailTB
        '
        Me.emailTB.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.emailTB.Location = New System.Drawing.Point(111, 362)
        Me.emailTB.MaxLength = 70
        Me.emailTB.Multiline = True
        Me.emailTB.Name = "emailTB"
        Me.emailTB.Size = New System.Drawing.Size(518, 23)
        Me.emailTB.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(62, 365)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 15)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Email:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'phone3NoTB
        '
        Me.phone3NoTB.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.phone3NoTB.Location = New System.Drawing.Point(111, 327)
        Me.phone3NoTB.MaxLength = 20
        Me.phone3NoTB.Name = "phone3NoTB"
        Me.phone3NoTB.Size = New System.Drawing.Size(181, 23)
        Me.phone3NoTB.TabIndex = 12
        Me.phone3NoTB.WordWrap = False
        '
        'phone3KindCB
        '
        Me.phone3KindCB.FormattingEnabled = True
        Me.phone3KindCB.Location = New System.Drawing.Point(16, 327)
        Me.phone3KindCB.Name = "phone3KindCB"
        Me.phone3KindCB.Size = New System.Drawing.Size(89, 23)
        Me.phone3KindCB.TabIndex = 11
        '
        'phone2NoTB
        '
        Me.phone2NoTB.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.phone2NoTB.Location = New System.Drawing.Point(111, 298)
        Me.phone2NoTB.MaxLength = 20
        Me.phone2NoTB.Name = "phone2NoTB"
        Me.phone2NoTB.Size = New System.Drawing.Size(181, 23)
        Me.phone2NoTB.TabIndex = 10
        Me.phone2NoTB.WordWrap = False
        '
        'phone2KindCB
        '
        Me.phone2KindCB.FormattingEnabled = True
        Me.phone2KindCB.Location = New System.Drawing.Point(16, 298)
        Me.phone2KindCB.Name = "phone2KindCB"
        Me.phone2KindCB.Size = New System.Drawing.Size(89, 23)
        Me.phone2KindCB.TabIndex = 9
        '
        'phone1NoTB
        '
        Me.phone1NoTB.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.phone1NoTB.Location = New System.Drawing.Point(111, 269)
        Me.phone1NoTB.MaxLength = 20
        Me.phone1NoTB.Name = "phone1NoTB"
        Me.phone1NoTB.Size = New System.Drawing.Size(181, 23)
        Me.phone1NoTB.TabIndex = 8
        Me.phone1NoTB.WordWrap = False
        '
        'phone1KindCB
        '
        Me.phone1KindCB.FormattingEnabled = True
        Me.phone1KindCB.Location = New System.Drawing.Point(16, 269)
        Me.phone1KindCB.Name = "phone1KindCB"
        Me.phone1KindCB.Size = New System.Drawing.Size(89, 23)
        Me.phone1KindCB.TabIndex = 7
        '
        'findBN
        '
        Me.findBN.Location = New System.Drawing.Point(176, 219)
        Me.findBN.Name = "findBN"
        Me.findBN.Size = New System.Drawing.Size(64, 23)
        Me.findBN.TabIndex = 6
        Me.findBN.Text = "Find"
        Me.findBN.UseVisualStyleBackColor = True
        '
        'houseHolderNameLL
        '
        Me.houseHolderNameLL.AutoSize = True
        Me.houseHolderNameLL.Location = New System.Drawing.Point(114, 245)
        Me.houseHolderNameLL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.houseHolderNameLL.Name = "houseHolderNameLL"
        Me.houseHolderNameLL.Size = New System.Drawing.Size(126, 15)
        Me.houseHolderNameLL.TabIndex = 57
        Me.houseHolderNameLL.Text = "House Holder Name"
        Me.houseHolderNameLL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'houseHolderCodeTB
        '
        Me.houseHolderCodeTB.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.houseHolderCodeTB.Location = New System.Drawing.Point(111, 219)
        Me.houseHolderCodeTB.MaxLength = 5
        Me.houseHolderCodeTB.Name = "houseHolderCodeTB"
        Me.houseHolderCodeTB.ReadOnly = True
        Me.houseHolderCodeTB.Size = New System.Drawing.Size(54, 23)
        Me.houseHolderCodeTB.TabIndex = 98
        Me.houseHolderCodeTB.TabStop = False
        Me.houseHolderCodeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.formTT.SetToolTip(Me.houseHolderCodeTB, "Member ID will automatically be created. ")
        Me.houseHolderCodeTB.WordWrap = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 222)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 15)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "House Holder:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 186)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Education:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'educationCB
        '
        Me.educationCB.Location = New System.Drawing.Point(111, 183)
        Me.educationCB.Name = "educationCB"
        Me.educationCB.Size = New System.Drawing.Size(181, 23)
        Me.educationCB.TabIndex = 5
        '
        'sexGB
        '
        Me.sexGB.Controls.Add(Me.femaleRB)
        Me.sexGB.Controls.Add(Me.maleRB)
        Me.sexGB.Location = New System.Drawing.Point(111, 136)
        Me.sexGB.Name = "sexGB"
        Me.sexGB.Size = New System.Drawing.Size(134, 40)
        Me.sexGB.TabIndex = 98
        Me.sexGB.TabStop = False
        '
        'femaleRB
        '
        Me.femaleRB.AutoSize = True
        Me.femaleRB.Location = New System.Drawing.Point(65, 15)
        Me.femaleRB.Name = "femaleRB"
        Me.femaleRB.Size = New System.Drawing.Size(67, 19)
        Me.femaleRB.TabIndex = 4
        Me.femaleRB.TabStop = True
        Me.femaleRB.Text = "Female"
        Me.femaleRB.UseVisualStyleBackColor = True
        '
        'maleRB
        '
        Me.maleRB.AutoSize = True
        Me.maleRB.Location = New System.Drawing.Point(6, 15)
        Me.maleRB.Name = "maleRB"
        Me.maleRB.Size = New System.Drawing.Size(53, 19)
        Me.maleRB.TabIndex = 3
        Me.maleRB.TabStop = True
        Me.maleRB.Text = "Male"
        Me.maleRB.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 153)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 15)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Sex:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'englishNameTB
        '
        Me.englishNameTB.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.englishNameTB.Location = New System.Drawing.Point(111, 110)
        Me.englishNameTB.MaxLength = 40
        Me.englishNameTB.Name = "englishNameTB"
        Me.englishNameTB.Size = New System.Drawing.Size(181, 23)
        Me.englishNameTB.TabIndex = 2
        Me.englishNameTB.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 113)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 15)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "English Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'koreanNameTB
        '
        Me.koreanNameTB.ImeMode = System.Windows.Forms.ImeMode.Hangul
        Me.koreanNameTB.Location = New System.Drawing.Point(111, 80)
        Me.koreanNameTB.MaxLength = 20
        Me.koreanNameTB.Name = "koreanNameTB"
        Me.koreanNameTB.Size = New System.Drawing.Size(92, 23)
        Me.koreanNameTB.TabIndex = 1
        Me.koreanNameTB.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 15)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Korean Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Member Code:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'menuTS
        '
        Me.menuTS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newTSB, Me.deleteTSB, Me.ToolStripSeparator1, Me.firstTSB, Me.previousTSB, Me.nextTSB, Me.lastTSB, Me.ToolStripSeparator2, Me.refreshTSB, Me.ToolStripSeparator3, Me.closeTSB, Me.ToolStripSeparator4, Me.saveTSB, Me.searchTSB})
        Me.menuTS.Location = New System.Drawing.Point(0, 0)
        Me.menuTS.Name = "menuTS"
        Me.menuTS.Padding = New System.Windows.Forms.Padding(0, 2, 1, 2)
        Me.menuTS.Size = New System.Drawing.Size(642, 27)
        Me.menuTS.TabIndex = 30
        Me.menuTS.Text = "ToolStrip"
        '
        'newTSB
        '
        Me.newTSB.Image = Global.Accounting.My.Resources.Resources.newImg
        Me.newTSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newTSB.Name = "newTSB"
        Me.newTSB.Size = New System.Drawing.Size(51, 20)
        Me.newTSB.Text = "New"
        Me.newTSB.ToolTipText = "New Record"
        '
        'deleteTSB
        '
        Me.deleteTSB.Image = Global.Accounting.My.Resources.Resources.deleteImg
        Me.deleteTSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.deleteTSB.Name = "deleteTSB"
        Me.deleteTSB.Size = New System.Drawing.Size(60, 20)
        Me.deleteTSB.Text = "Delete"
        Me.deleteTSB.ToolTipText = "Delete Current Record"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'firstTSB
        '
        Me.firstTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.firstTSB.Image = Global.Accounting.My.Resources.Resources.gotoFirstImg
        Me.firstTSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.firstTSB.Name = "firstTSB"
        Me.firstTSB.Size = New System.Drawing.Size(23, 20)
        Me.firstTSB.Text = "First"
        Me.firstTSB.ToolTipText = "First Record"
        '
        'previousTSB
        '
        Me.previousTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.previousTSB.Image = Global.Accounting.My.Resources.Resources.gotoPrevImg
        Me.previousTSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.previousTSB.Name = "previousTSB"
        Me.previousTSB.Size = New System.Drawing.Size(23, 20)
        Me.previousTSB.Text = "Previous"
        Me.previousTSB.ToolTipText = "Previous Record"
        '
        'nextTSB
        '
        Me.nextTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.nextTSB.Image = Global.Accounting.My.Resources.Resources.gotoNextImg
        Me.nextTSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.nextTSB.Name = "nextTSB"
        Me.nextTSB.Size = New System.Drawing.Size(23, 20)
        Me.nextTSB.Text = "Next"
        Me.nextTSB.ToolTipText = "Next Record"
        '
        'lastTSB
        '
        Me.lastTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.lastTSB.Image = Global.Accounting.My.Resources.Resources.gotoLastImg
        Me.lastTSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.lastTSB.Name = "lastTSB"
        Me.lastTSB.Size = New System.Drawing.Size(23, 20)
        Me.lastTSB.Text = "Last"
        Me.lastTSB.ToolTipText = "Last Record"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'refreshTSB
        '
        Me.refreshTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.refreshTSB.Image = Global.Accounting.My.Resources.Resources.refreshImg
        Me.refreshTSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.refreshTSB.Name = "refreshTSB"
        Me.refreshTSB.Size = New System.Drawing.Size(23, 20)
        Me.refreshTSB.Text = "Refresh"
        Me.refreshTSB.ToolTipText = "Refresh Table"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 23)
        '
        'closeTSB
        '
        Me.closeTSB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.closeTSB.Image = Global.Accounting.My.Resources.Resources.closeImg
        Me.closeTSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.closeTSB.Name = "closeTSB"
        Me.closeTSB.Size = New System.Drawing.Size(56, 20)
        Me.closeTSB.Text = "Close"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 23)
        '
        'saveTSB
        '
        Me.saveTSB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.saveTSB.Image = Global.Accounting.My.Resources.Resources.saveImg
        Me.saveTSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.saveTSB.Name = "saveTSB"
        Me.saveTSB.Size = New System.Drawing.Size(51, 20)
        Me.saveTSB.Text = "Save"
        Me.saveTSB.ToolTipText = "Save Current Record"
        '
        'searchTSB
        '
        Me.searchTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.searchTSB.Image = Global.Accounting.My.Resources.Resources.searchImg
        Me.searchTSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.searchTSB.Name = "searchTSB"
        Me.searchTSB.Size = New System.Drawing.Size(23, 20)
        Me.searchTSB.Text = "ToolStripButton1"
        '
        'MemberForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 404)
        Me.Controls.Add(Me.SplitContainer)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "MemberForm"
        Me.Text = "Managing Member Code"
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel2.ResumeLayout(False)
        Me.SplitContainer.Panel2.PerformLayout()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        CType(Me.naviDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sexGB.ResumeLayout(False)
        Me.sexGB.PerformLayout()
        Me.menuTS.ResumeLayout(False)
        Me.menuTS.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer As SplitContainer
    Friend WithEvents naviDGV As DataGridView
    Friend WithEvents menuTS As ToolStrip
    Friend WithEvents newTSB As ToolStripButton
    Friend WithEvents deleteTSB As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents firstTSB As ToolStripButton
    Friend WithEvents previousTSB As ToolStripButton
    Friend WithEvents nextTSB As ToolStripButton
    Friend WithEvents lastTSB As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents refreshTSB As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents closeTSB As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents saveTSB As ToolStripButton
    Friend WithEvents koreanNameTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents formTT As ToolTip
    Friend WithEvents searchTSB As ToolStripButton
    Friend WithEvents educationCB As ComboBox
    Friend WithEvents sexGB As GroupBox
    Friend WithEvents femaleRB As RadioButton
    Friend WithEvents maleRB As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents englishNameTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents phone1NoTB As TextBox
    Friend WithEvents phone1KindCB As ComboBox
    Friend WithEvents findBN As Button
    Friend WithEvents houseHolderNameLL As Label
    Friend WithEvents houseHolderCodeTB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents remarkTB As TextBox
    Friend WithEvents emailTB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents phone3NoTB As TextBox
    Friend WithEvents phone3KindCB As ComboBox
    Friend WithEvents phone2NoTB As TextBox
    Friend WithEvents phone2KindCB As ComboBox
    Friend WithEvents isDeletedCB As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents dutyCB As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents provinceCB As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cityTB As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents addressTB As TextBox
    Friend WithEvents memberCodeTB As MaskedTextBox
    Friend WithEvents CodeCol As DataGridViewTextBoxColumn
    Friend WithEvents NameCol As DataGridViewTextBoxColumn
    Friend WithEvents postalCodeTB As MaskedTextBox
    Friend WithEvents postalAreaLL As Label
End Class
