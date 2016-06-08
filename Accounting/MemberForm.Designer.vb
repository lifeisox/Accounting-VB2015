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
        Me.grdNavi = New System.Windows.Forms.DataGridView()
        Me.CodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.postalAreaLL = New System.Windows.Forms.Label()
        Me.txtPostalCode = New System.Windows.Forms.MaskedTextBox()
        Me.txtMemberCode = New System.Windows.Forms.MaskedTextBox()
        Me.chkIsDeleted = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboDuty = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboProvince = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPhone3No = New System.Windows.Forms.TextBox()
        Me.cboPhone3Kind = New System.Windows.Forms.ComboBox()
        Me.txtPhone2No = New System.Windows.Forms.TextBox()
        Me.cboPhone2Kind = New System.Windows.Forms.ComboBox()
        Me.txtPhone1No = New System.Windows.Forms.TextBox()
        Me.cboPhone1Kind = New System.Windows.Forms.ComboBox()
        Me.btnFindHouseHolder = New System.Windows.Forms.Button()
        Me.lblHouseHolderName = New System.Windows.Forms.Label()
        Me.txtHouseHolderCode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboEducation = New System.Windows.Forms.ComboBox()
        Me.sexGB = New System.Windows.Forms.GroupBox()
        Me.rdoFemale = New System.Windows.Forms.RadioButton()
        Me.rdoMale = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEnglishName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKoreanName = New System.Windows.Forms.TextBox()
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
        CType(Me.grdNavi, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer.Panel1.Controls.Add(Me.grdNavi)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.SplitContainer.Panel2.Controls.Add(Me.postalAreaLL)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtPostalCode)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtMemberCode)
        Me.SplitContainer.Panel2.Controls.Add(Me.chkIsDeleted)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label13)
        Me.SplitContainer.Panel2.Controls.Add(Me.cboDuty)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label12)
        Me.SplitContainer.Panel2.Controls.Add(Me.cboProvince)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label11)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtCity)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label10)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtAddress)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtRemark)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtEmail)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtPhone3No)
        Me.SplitContainer.Panel2.Controls.Add(Me.cboPhone3Kind)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtPhone2No)
        Me.SplitContainer.Panel2.Controls.Add(Me.cboPhone2Kind)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtPhone1No)
        Me.SplitContainer.Panel2.Controls.Add(Me.cboPhone1Kind)
        Me.SplitContainer.Panel2.Controls.Add(Me.btnFindHouseHolder)
        Me.SplitContainer.Panel2.Controls.Add(Me.lblHouseHolderName)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtHouseHolderCode)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer.Panel2.Controls.Add(Me.cboEducation)
        Me.SplitContainer.Panel2.Controls.Add(Me.sexGB)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtEnglishName)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtKoreanName)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer.Panel2.Controls.Add(Me.menuTS)
        Me.SplitContainer.Size = New System.Drawing.Size(882, 404)
        Me.SplitContainer.SplitterDistance = 236
        Me.SplitContainer.TabIndex = 0
        '
        'grdNavi
        '
        Me.grdNavi.AllowUserToAddRows = False
        Me.grdNavi.AllowUserToDeleteRows = False
        Me.grdNavi.AllowUserToResizeColumns = False
        Me.grdNavi.AllowUserToResizeRows = False
        Me.grdNavi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdNavi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeCol, Me.NameCol})
        Me.grdNavi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdNavi.Location = New System.Drawing.Point(0, 0)
        Me.grdNavi.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.grdNavi.MultiSelect = False
        Me.grdNavi.Name = "grdNavi"
        Me.grdNavi.ReadOnly = True
        Me.grdNavi.RowHeadersVisible = False
        Me.grdNavi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdNavi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdNavi.ShowEditingIcon = False
        Me.grdNavi.Size = New System.Drawing.Size(236, 404)
        Me.grdNavi.TabIndex = 3
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
        'txtPostalCode
        '
        Me.txtPostalCode.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.txtPostalCode.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtPostalCode.Location = New System.Drawing.Point(392, 62)
        Me.txtPostalCode.Mask = ">A0A0A0"
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.ResetOnSpace = False
        Me.txtPostalCode.Size = New System.Drawing.Size(59, 23)
        Me.txtPostalCode.TabIndex = 14
        Me.txtPostalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMemberCode
        '
        Me.txtMemberCode.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtMemberCode.Location = New System.Drawing.Point(111, 45)
        Me.txtMemberCode.Mask = "00000"
        Me.txtMemberCode.Name = "txtMemberCode"
        Me.txtMemberCode.ResetOnSpace = False
        Me.txtMemberCode.Size = New System.Drawing.Size(54, 23)
        Me.txtMemberCode.TabIndex = 0
        Me.txtMemberCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkIsDeleted
        '
        Me.chkIsDeleted.AutoSize = True
        Me.chkIsDeleted.Location = New System.Drawing.Point(392, 332)
        Me.chkIsDeleted.Name = "chkIsDeleted"
        Me.chkIsDeleted.Size = New System.Drawing.Size(124, 19)
        Me.chkIsDeleted.TabIndex = 20
        Me.chkIsDeleted.Text = "Deleted Member"
        Me.chkIsDeleted.UseVisualStyleBackColor = True
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
        'cboDuty
        '
        Me.cboDuty.FormattingEnabled = True
        Me.cboDuty.Location = New System.Drawing.Point(392, 210)
        Me.cboDuty.Name = "cboDuty"
        Me.cboDuty.Size = New System.Drawing.Size(181, 23)
        Me.cboDuty.TabIndex = 18
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
        'cboProvince
        '
        Me.cboProvince.FormattingEnabled = True
        Me.cboProvince.Location = New System.Drawing.Point(392, 174)
        Me.cboProvince.Name = "cboProvince"
        Me.cboProvince.Size = New System.Drawing.Size(181, 23)
        Me.cboProvince.TabIndex = 17
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
        'txtCity
        '
        Me.txtCity.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.txtCity.Location = New System.Drawing.Point(392, 145)
        Me.txtCity.MaxLength = 30
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(237, 23)
        Me.txtCity.TabIndex = 16
        Me.txtCity.WordWrap = False
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
        'txtAddress
        '
        Me.txtAddress.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.txtAddress.Location = New System.Drawing.Point(392, 94)
        Me.txtAddress.MaxLength = 70
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(237, 45)
        Me.txtAddress.TabIndex = 15
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
        'txtRemark
        '
        Me.txtRemark.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.txtRemark.Location = New System.Drawing.Point(392, 245)
        Me.txtRemark.MaxLength = 70
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(237, 76)
        Me.txtRemark.TabIndex = 19
        '
        'txtEmail
        '
        Me.txtEmail.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.txtEmail.Location = New System.Drawing.Point(111, 362)
        Me.txtEmail.MaxLength = 70
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(518, 23)
        Me.txtEmail.TabIndex = 13
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
        'txtPhone3No
        '
        Me.txtPhone3No.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.txtPhone3No.Location = New System.Drawing.Point(111, 327)
        Me.txtPhone3No.MaxLength = 20
        Me.txtPhone3No.Name = "txtPhone3No"
        Me.txtPhone3No.Size = New System.Drawing.Size(181, 23)
        Me.txtPhone3No.TabIndex = 12
        Me.txtPhone3No.WordWrap = False
        '
        'cboPhone3Kind
        '
        Me.cboPhone3Kind.FormattingEnabled = True
        Me.cboPhone3Kind.Location = New System.Drawing.Point(16, 327)
        Me.cboPhone3Kind.Name = "cboPhone3Kind"
        Me.cboPhone3Kind.Size = New System.Drawing.Size(89, 23)
        Me.cboPhone3Kind.TabIndex = 11
        '
        'txtPhone2No
        '
        Me.txtPhone2No.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.txtPhone2No.Location = New System.Drawing.Point(111, 298)
        Me.txtPhone2No.MaxLength = 20
        Me.txtPhone2No.Name = "txtPhone2No"
        Me.txtPhone2No.Size = New System.Drawing.Size(181, 23)
        Me.txtPhone2No.TabIndex = 10
        Me.txtPhone2No.WordWrap = False
        '
        'cboPhone2Kind
        '
        Me.cboPhone2Kind.FormattingEnabled = True
        Me.cboPhone2Kind.Location = New System.Drawing.Point(16, 298)
        Me.cboPhone2Kind.Name = "cboPhone2Kind"
        Me.cboPhone2Kind.Size = New System.Drawing.Size(89, 23)
        Me.cboPhone2Kind.TabIndex = 9
        '
        'txtPhone1No
        '
        Me.txtPhone1No.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.txtPhone1No.Location = New System.Drawing.Point(111, 269)
        Me.txtPhone1No.MaxLength = 20
        Me.txtPhone1No.Name = "txtPhone1No"
        Me.txtPhone1No.Size = New System.Drawing.Size(181, 23)
        Me.txtPhone1No.TabIndex = 8
        Me.txtPhone1No.WordWrap = False
        '
        'cboPhone1Kind
        '
        Me.cboPhone1Kind.FormattingEnabled = True
        Me.cboPhone1Kind.Location = New System.Drawing.Point(16, 269)
        Me.cboPhone1Kind.Name = "cboPhone1Kind"
        Me.cboPhone1Kind.Size = New System.Drawing.Size(89, 23)
        Me.cboPhone1Kind.TabIndex = 7
        '
        'btnFindHouseHolder
        '
        Me.btnFindHouseHolder.Location = New System.Drawing.Point(176, 219)
        Me.btnFindHouseHolder.Name = "btnFindHouseHolder"
        Me.btnFindHouseHolder.Size = New System.Drawing.Size(64, 23)
        Me.btnFindHouseHolder.TabIndex = 6
        Me.btnFindHouseHolder.Text = "Find"
        Me.btnFindHouseHolder.UseVisualStyleBackColor = True
        '
        'lblHouseHolderName
        '
        Me.lblHouseHolderName.AutoSize = True
        Me.lblHouseHolderName.Location = New System.Drawing.Point(114, 245)
        Me.lblHouseHolderName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHouseHolderName.Name = "lblHouseHolderName"
        Me.lblHouseHolderName.Size = New System.Drawing.Size(126, 15)
        Me.lblHouseHolderName.TabIndex = 57
        Me.lblHouseHolderName.Text = "House Holder Name"
        Me.lblHouseHolderName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtHouseHolderCode
        '
        Me.txtHouseHolderCode.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtHouseHolderCode.Location = New System.Drawing.Point(111, 219)
        Me.txtHouseHolderCode.MaxLength = 5
        Me.txtHouseHolderCode.Name = "txtHouseHolderCode"
        Me.txtHouseHolderCode.ReadOnly = True
        Me.txtHouseHolderCode.Size = New System.Drawing.Size(54, 23)
        Me.txtHouseHolderCode.TabIndex = 98
        Me.txtHouseHolderCode.TabStop = False
        Me.txtHouseHolderCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.formTT.SetToolTip(Me.txtHouseHolderCode, "Member ID will automatically be created. ")
        Me.txtHouseHolderCode.WordWrap = False
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
        'cboEducation
        '
        Me.cboEducation.Location = New System.Drawing.Point(111, 183)
        Me.cboEducation.Name = "cboEducation"
        Me.cboEducation.Size = New System.Drawing.Size(181, 23)
        Me.cboEducation.TabIndex = 5
        '
        'sexGB
        '
        Me.sexGB.Controls.Add(Me.rdoFemale)
        Me.sexGB.Controls.Add(Me.rdoMale)
        Me.sexGB.Location = New System.Drawing.Point(111, 136)
        Me.sexGB.Name = "sexGB"
        Me.sexGB.Size = New System.Drawing.Size(134, 40)
        Me.sexGB.TabIndex = 98
        Me.sexGB.TabStop = False
        '
        'rdoFemale
        '
        Me.rdoFemale.AutoSize = True
        Me.rdoFemale.Location = New System.Drawing.Point(65, 15)
        Me.rdoFemale.Name = "rdoFemale"
        Me.rdoFemale.Size = New System.Drawing.Size(67, 19)
        Me.rdoFemale.TabIndex = 4
        Me.rdoFemale.TabStop = True
        Me.rdoFemale.Text = "Female"
        Me.rdoFemale.UseVisualStyleBackColor = True
        '
        'rdoMale
        '
        Me.rdoMale.AutoSize = True
        Me.rdoMale.Location = New System.Drawing.Point(6, 15)
        Me.rdoMale.Name = "rdoMale"
        Me.rdoMale.Size = New System.Drawing.Size(53, 19)
        Me.rdoMale.TabIndex = 3
        Me.rdoMale.TabStop = True
        Me.rdoMale.Text = "Male"
        Me.rdoMale.UseVisualStyleBackColor = True
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
        'txtEnglishName
        '
        Me.txtEnglishName.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.txtEnglishName.Location = New System.Drawing.Point(111, 110)
        Me.txtEnglishName.MaxLength = 40
        Me.txtEnglishName.Name = "txtEnglishName"
        Me.txtEnglishName.Size = New System.Drawing.Size(181, 23)
        Me.txtEnglishName.TabIndex = 2
        Me.txtEnglishName.WordWrap = False
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
        'txtKoreanName
        '
        Me.txtKoreanName.ImeMode = System.Windows.Forms.ImeMode.Hangul
        Me.txtKoreanName.Location = New System.Drawing.Point(111, 80)
        Me.txtKoreanName.MaxLength = 20
        Me.txtKoreanName.Name = "txtKoreanName"
        Me.txtKoreanName.Size = New System.Drawing.Size(92, 23)
        Me.txtKoreanName.TabIndex = 1
        Me.txtKoreanName.WordWrap = False
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
        CType(Me.grdNavi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sexGB.ResumeLayout(False)
        Me.sexGB.PerformLayout()
        Me.menuTS.ResumeLayout(False)
        Me.menuTS.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer As SplitContainer
    Friend WithEvents grdNavi As DataGridView
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
    Friend WithEvents txtKoreanName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents formTT As ToolTip
    Friend WithEvents searchTSB As ToolStripButton
    Friend WithEvents cboEducation As ComboBox
    Friend WithEvents sexGB As GroupBox
    Friend WithEvents rdoFemale As RadioButton
    Friend WithEvents rdoMale As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEnglishName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPhone1No As TextBox
    Friend WithEvents cboPhone1Kind As ComboBox
    Friend WithEvents btnFindHouseHolder As Button
    Friend WithEvents lblHouseHolderName As Label
    Friend WithEvents txtHouseHolderCode As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPhone3No As TextBox
    Friend WithEvents cboPhone3Kind As ComboBox
    Friend WithEvents txtPhone2No As TextBox
    Friend WithEvents cboPhone2Kind As ComboBox
    Friend WithEvents chkIsDeleted As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cboDuty As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cboProvince As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtMemberCode As MaskedTextBox
    Friend WithEvents CodeCol As DataGridViewTextBoxColumn
    Friend WithEvents NameCol As DataGridViewTextBoxColumn
    Friend WithEvents txtPostalCode As MaskedTextBox
    Friend WithEvents postalAreaLL As Label
End Class
