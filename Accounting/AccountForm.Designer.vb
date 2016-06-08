<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountForm))
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.grdNavi = New System.Windows.Forms.DataGridView()
        Me.AccountCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblParentName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFindParent = New System.Windows.Forms.Button()
        Me.txtParentCode = New System.Windows.Forms.MaskedTextBox()
        Me.txtAccountNameKr = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtLastYearCode = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtAccountYear = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.postalAreaLL = New System.Windows.Forms.Label()
        Me.txtAccountCode = New System.Windows.Forms.MaskedTextBox()
        Me.chkIsComputed = New System.Windows.Forms.CheckBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.btnFindYear = New System.Windows.Forms.Button()
        Me.lblLastYearName = New System.Windows.Forms.Label()
        Me.sexGB = New System.Windows.Forms.GroupBox()
        Me.rdoIncome = New System.Windows.Forms.RadioButton()
        Me.rdoExpense = New System.Windows.Forms.RadioButton()
        Me.txtAccountName = New System.Windows.Forms.TextBox()
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
        Me.cboYear = New System.Windows.Forms.ToolStripComboBox()
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
        Me.SplitContainer.Panel2.Controls.Add(Me.lblParentName)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer.Panel2.Controls.Add(Me.btnFindParent)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtParentCode)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtAccountNameKr)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label10)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label16)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtLastYearCode)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label15)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtAccountYear)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label14)
        Me.SplitContainer.Panel2.Controls.Add(Me.postalAreaLL)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtAccountCode)
        Me.SplitContainer.Panel2.Controls.Add(Me.chkIsComputed)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtRemark)
        Me.SplitContainer.Panel2.Controls.Add(Me.btnFindYear)
        Me.SplitContainer.Panel2.Controls.Add(Me.lblLastYearName)
        Me.SplitContainer.Panel2.Controls.Add(Me.sexGB)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtAccountName)
        Me.SplitContainer.Panel2.Controls.Add(Me.menuTS)
        Me.SplitContainer.Size = New System.Drawing.Size(781, 379)
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
        Me.grdNavi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccountCode, Me.AccountName})
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
        Me.grdNavi.Size = New System.Drawing.Size(236, 379)
        Me.grdNavi.TabIndex = 3
        '
        'AccountCode
        '
        Me.AccountCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountCode.DefaultCellStyle = DataGridViewCellStyle1
        Me.AccountCode.HeaderText = "Code"
        Me.AccountCode.MaxInputLength = 5
        Me.AccountCode.Name = "AccountCode"
        Me.AccountCode.ReadOnly = True
        Me.AccountCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AccountCode.Width = 50
        '
        'AccountName
        '
        Me.AccountName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.AccountName.DefaultCellStyle = DataGridViewCellStyle2
        Me.AccountName.HeaderText = "Name"
        Me.AccountName.MaxInputLength = 30
        Me.AccountName.Name = "AccountName"
        Me.AccountName.ReadOnly = True
        Me.AccountName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'lblParentName
        '
        Me.lblParentName.AutoSize = True
        Me.lblParentName.Location = New System.Drawing.Point(325, 288)
        Me.lblParentName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblParentName.Name = "lblParentName"
        Me.lblParentName.Size = New System.Drawing.Size(119, 15)
        Me.lblParentName.TabIndex = 114
        Me.lblParentName.Text = "Parent Code Name"
        Me.lblParentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 316)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(185, 23)
        Me.Label5.TabIndex = 113
        Me.Label5.Text = "Remark:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 284)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 23)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Parent Code:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnFindParent
        '
        Me.btnFindParent.Image = Global.Accounting.My.Resources.Resources.searchImg
        Me.btnFindParent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFindParent.Location = New System.Drawing.Point(247, 284)
        Me.btnFindParent.Name = "btnFindParent"
        Me.btnFindParent.Size = New System.Drawing.Size(64, 23)
        Me.btnFindParent.TabIndex = 8
        Me.btnFindParent.Text = "Find"
        Me.btnFindParent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFindParent.UseVisualStyleBackColor = True
        '
        'txtParentCode
        '
        Me.txtParentCode.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtParentCode.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtParentCode.Location = New System.Drawing.Point(200, 284)
        Me.txtParentCode.Mask = "0000"
        Me.txtParentCode.Name = "txtParentCode"
        Me.txtParentCode.ReadOnly = True
        Me.txtParentCode.ResetOnSpace = False
        Me.txtParentCode.Size = New System.Drawing.Size(41, 23)
        Me.txtParentCode.TabIndex = 107
        Me.txtParentCode.TabStop = False
        Me.txtParentCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAccountNameKr
        '
        Me.txtAccountNameKr.ImeMode = System.Windows.Forms.ImeMode.Hangul
        Me.txtAccountNameKr.Location = New System.Drawing.Point(200, 214)
        Me.txtAccountNameKr.MaxLength = 50
        Me.txtAccountNameKr.Name = "txtAccountNameKr"
        Me.txtAccountNameKr.Size = New System.Drawing.Size(317, 23)
        Me.txtAccountNameKr.TabIndex = 6
        Me.txtAccountNameKr.WordWrap = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 214)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(185, 23)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Account Name (Korean):"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 183)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 23)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Account Name (English):"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 148)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(185, 23)
        Me.Label16.TabIndex = 104
        Me.Label16.Text = "Division:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLastYearCode
        '
        Me.txtLastYearCode.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtLastYearCode.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtLastYearCode.Location = New System.Drawing.Point(200, 111)
        Me.txtLastYearCode.Mask = "0000"
        Me.txtLastYearCode.Name = "txtLastYearCode"
        Me.txtLastYearCode.ReadOnly = True
        Me.txtLastYearCode.ResetOnSpace = False
        Me.txtLastYearCode.Size = New System.Drawing.Size(41, 23)
        Me.txtLastYearCode.TabIndex = 2
        Me.txtLastYearCode.TabStop = False
        Me.txtLastYearCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 111)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 23)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Last Year Account Code:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 75)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(185, 23)
        Me.Label15.TabIndex = 102
        Me.Label15.Text = "Account Code:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAccountYear
        '
        Me.txtAccountYear.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtAccountYear.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtAccountYear.Location = New System.Drawing.Point(200, 44)
        Me.txtAccountYear.Mask = "0000"
        Me.txtAccountYear.Name = "txtAccountYear"
        Me.txtAccountYear.ReadOnly = True
        Me.txtAccountYear.ResetOnSpace = False
        Me.txtAccountYear.Size = New System.Drawing.Size(41, 23)
        Me.txtAccountYear.TabIndex = 99
        Me.txtAccountYear.TabStop = False
        Me.txtAccountYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 44)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(185, 23)
        Me.Label14.TabIndex = 101
        Me.Label14.Text = "Year:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'postalAreaLL
        '
        Me.postalAreaLL.AutoSize = True
        Me.postalAreaLL.Location = New System.Drawing.Point(459, 122)
        Me.postalAreaLL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.postalAreaLL.Name = "postalAreaLL"
        Me.postalAreaLL.Size = New System.Drawing.Size(0, 15)
        Me.postalAreaLL.TabIndex = 99
        Me.postalAreaLL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAccountCode
        '
        Me.txtAccountCode.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtAccountCode.Location = New System.Drawing.Point(200, 75)
        Me.txtAccountCode.Mask = "0000"
        Me.txtAccountCode.Name = "txtAccountCode"
        Me.txtAccountCode.ResetOnSpace = False
        Me.txtAccountCode.Size = New System.Drawing.Size(41, 23)
        Me.txtAccountCode.TabIndex = 1
        Me.txtAccountCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkIsComputed
        '
        Me.chkIsComputed.AutoSize = True
        Me.chkIsComputed.Location = New System.Drawing.Point(200, 249)
        Me.chkIsComputed.Name = "chkIsComputed"
        Me.chkIsComputed.Size = New System.Drawing.Size(236, 19)
        Me.chkIsComputed.TabIndex = 7
        Me.chkIsComputed.Text = "Will this account be computed?"
        Me.chkIsComputed.UseVisualStyleBackColor = True
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(200, 316)
        Me.txtRemark.MaxLength = 80
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(317, 42)
        Me.txtRemark.TabIndex = 10
        '
        'btnFindYear
        '
        Me.btnFindYear.Image = Global.Accounting.My.Resources.Resources.searchImg
        Me.btnFindYear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFindYear.Location = New System.Drawing.Point(247, 111)
        Me.btnFindYear.Name = "btnFindYear"
        Me.btnFindYear.Size = New System.Drawing.Size(64, 23)
        Me.btnFindYear.TabIndex = 2
        Me.btnFindYear.Text = "Find"
        Me.btnFindYear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFindYear.UseVisualStyleBackColor = True
        '
        'lblLastYearName
        '
        Me.lblLastYearName.AutoSize = True
        Me.lblLastYearName.Location = New System.Drawing.Point(325, 114)
        Me.lblLastYearName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLastYearName.Name = "lblLastYearName"
        Me.lblLastYearName.Size = New System.Drawing.Size(161, 15)
        Me.lblLastYearName.TabIndex = 57
        Me.lblLastYearName.Text = "Last Year Account Name"
        Me.lblLastYearName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sexGB
        '
        Me.sexGB.Controls.Add(Me.rdoIncome)
        Me.sexGB.Controls.Add(Me.rdoExpense)
        Me.sexGB.Location = New System.Drawing.Point(200, 135)
        Me.sexGB.Name = "sexGB"
        Me.sexGB.Size = New System.Drawing.Size(179, 40)
        Me.sexGB.TabIndex = 98
        Me.sexGB.TabStop = False
        '
        'rdoIncome
        '
        Me.rdoIncome.AutoSize = True
        Me.rdoIncome.Location = New System.Drawing.Point(102, 13)
        Me.rdoIncome.Name = "rdoIncome"
        Me.rdoIncome.Size = New System.Drawing.Size(67, 19)
        Me.rdoIncome.TabIndex = 4
        Me.rdoIncome.TabStop = True
        Me.rdoIncome.Text = "Income"
        Me.rdoIncome.UseVisualStyleBackColor = True
        '
        'rdoExpense
        '
        Me.rdoExpense.AutoSize = True
        Me.rdoExpense.Location = New System.Drawing.Point(11, 13)
        Me.rdoExpense.Name = "rdoExpense"
        Me.rdoExpense.Size = New System.Drawing.Size(74, 19)
        Me.rdoExpense.TabIndex = 3
        Me.rdoExpense.TabStop = True
        Me.rdoExpense.Text = "Expense"
        Me.rdoExpense.UseVisualStyleBackColor = True
        '
        'txtAccountName
        '
        Me.txtAccountName.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.txtAccountName.Location = New System.Drawing.Point(200, 183)
        Me.txtAccountName.MaxLength = 50
        Me.txtAccountName.Name = "txtAccountName"
        Me.txtAccountName.Size = New System.Drawing.Size(317, 23)
        Me.txtAccountName.TabIndex = 5
        Me.txtAccountName.WordWrap = False
        '
        'menuTS
        '
        Me.menuTS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newTSB, Me.deleteTSB, Me.ToolStripSeparator1, Me.firstTSB, Me.previousTSB, Me.nextTSB, Me.lastTSB, Me.ToolStripSeparator2, Me.refreshTSB, Me.ToolStripSeparator3, Me.closeTSB, Me.ToolStripSeparator4, Me.saveTSB, Me.cboYear})
        Me.menuTS.Location = New System.Drawing.Point(0, 0)
        Me.menuTS.Name = "menuTS"
        Me.menuTS.Padding = New System.Windows.Forms.Padding(0, 2, 1, 2)
        Me.menuTS.Size = New System.Drawing.Size(541, 27)
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
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.DropDownWidth = 75
        Me.cboYear.MaxDropDownItems = 10
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(75, 23)
        '
        'AccountForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 379)
        Me.Controls.Add(Me.SplitContainer)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "AccountForm"
        Me.Text = "Managing Account Code"
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
    Friend WithEvents deleteTSB As ToolStripButton
    Friend WithEvents formTT As ToolTip
    Friend WithEvents sexGB As GroupBox
    Friend WithEvents rdoIncome As RadioButton
    Friend WithEvents rdoExpense As RadioButton
    Friend WithEvents lblLastYearName As Label
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents chkIsComputed As CheckBox
    Friend WithEvents postalAreaLL As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Private WithEvents txtAccountNameKr As TextBox
    Private WithEvents txtAccountName As TextBox
    Private WithEvents txtLastYearCode As MaskedTextBox
    Private WithEvents btnFindYear As Button
    Private WithEvents txtAccountCode As MaskedTextBox
    Private WithEvents txtAccountYear As MaskedTextBox
    Friend WithEvents lblParentName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Private WithEvents btnFindParent As Button
    Private WithEvents txtParentCode As MaskedTextBox
    Private WithEvents cboYear As ToolStripComboBox
    Private WithEvents newTSB As ToolStripButton
    Private WithEvents ToolStripSeparator1 As ToolStripSeparator
    Private WithEvents firstTSB As ToolStripButton
    Private WithEvents previousTSB As ToolStripButton
    Private WithEvents nextTSB As ToolStripButton
    Private WithEvents lastTSB As ToolStripButton
    Private WithEvents ToolStripSeparator2 As ToolStripSeparator
    Private WithEvents refreshTSB As ToolStripButton
    Private WithEvents ToolStripSeparator3 As ToolStripSeparator
    Private WithEvents closeTSB As ToolStripButton
    Private WithEvents ToolStripSeparator4 As ToolStripSeparator
    Private WithEvents saveTSB As ToolStripButton
    Friend WithEvents AccountCode As DataGridViewTextBoxColumn
    Friend WithEvents AccountName As DataGridViewTextBoxColumn
End Class
