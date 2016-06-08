<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComposeBookForm
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComposeBookForm))
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.grdNavi = New System.Windows.Forms.DataGridView()
        Me.BookCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAccountName = New System.Windows.Forms.Label()
        Me.lblBookName = New System.Windows.Forms.Label()
        Me.grdSub = New System.Windows.Forms.DataGridView()
        Me.AccountCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Division = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtAccountCode = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtBookYear = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.postalAreaLL = New System.Windows.Forms.Label()
        Me.txtBookCode = New System.Windows.Forms.MaskedTextBox()
        Me.btnFindCode = New System.Windows.Forms.Button()
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
        CType(Me.grdSub, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer.Panel1.Controls.Add(Me.Label4)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.SplitContainer.Panel2.Controls.Add(Me.lblAccountName)
        Me.SplitContainer.Panel2.Controls.Add(Me.lblBookName)
        Me.SplitContainer.Panel2.Controls.Add(Me.grdSub)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtAccountCode)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label15)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtBookYear)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label14)
        Me.SplitContainer.Panel2.Controls.Add(Me.postalAreaLL)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtBookCode)
        Me.SplitContainer.Panel2.Controls.Add(Me.btnFindCode)
        Me.SplitContainer.Panel2.Controls.Add(Me.menuTS)
        Me.SplitContainer.Size = New System.Drawing.Size(698, 379)
        Me.SplitContainer.SplitterDistance = 200
        Me.SplitContainer.TabIndex = 0
        '
        'grdNavi
        '
        Me.grdNavi.AllowUserToAddRows = False
        Me.grdNavi.AllowUserToDeleteRows = False
        Me.grdNavi.AllowUserToResizeColumns = False
        Me.grdNavi.AllowUserToResizeRows = False
        Me.grdNavi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdNavi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookCode, Me.BookName})
        Me.grdNavi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdNavi.Location = New System.Drawing.Point(0, 23)
        Me.grdNavi.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.grdNavi.MultiSelect = False
        Me.grdNavi.Name = "grdNavi"
        Me.grdNavi.ReadOnly = True
        Me.grdNavi.RowHeadersVisible = False
        Me.grdNavi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdNavi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdNavi.ShowEditingIcon = False
        Me.grdNavi.Size = New System.Drawing.Size(200, 356)
        Me.grdNavi.TabIndex = 3
        '
        'BookCode
        '
        Me.BookCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookCode.DefaultCellStyle = DataGridViewCellStyle1
        Me.BookCode.HeaderText = "Code"
        Me.BookCode.MaxInputLength = 4
        Me.BookCode.Name = "BookCode"
        Me.BookCode.ReadOnly = True
        Me.BookCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BookCode.Width = 45
        '
        'BookName
        '
        Me.BookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.BookName.DefaultCellStyle = DataGridViewCellStyle2
        Me.BookName.HeaderText = "Name"
        Me.BookName.MaxInputLength = 50
        Me.BookName.Name = "BookName"
        Me.BookName.ReadOnly = True
        Me.BookName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 23)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Book Data"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAccountName
        '
        Me.lblAccountName.Location = New System.Drawing.Point(162, 147)
        Me.lblAccountName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAccountName.Name = "lblAccountName"
        Me.lblAccountName.Size = New System.Drawing.Size(200, 23)
        Me.lblAccountName.TabIndex = 106
        Me.lblAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBookName
        '
        Me.lblBookName.Location = New System.Drawing.Point(214, 75)
        Me.lblBookName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBookName.Name = "lblBookName"
        Me.lblBookName.Size = New System.Drawing.Size(200, 23)
        Me.lblBookName.TabIndex = 105
        Me.lblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grdSub
        '
        Me.grdSub.AllowUserToAddRows = False
        Me.grdSub.AllowUserToDeleteRows = False
        Me.grdSub.AllowUserToResizeColumns = False
        Me.grdSub.AllowUserToResizeRows = False
        Me.grdSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSub.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccountCode, Me.Division, Me.AccountName, Me.Remark})
        Me.grdSub.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grdSub.Location = New System.Drawing.Point(0, 184)
        Me.grdSub.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.grdSub.MultiSelect = False
        Me.grdSub.Name = "grdSub"
        Me.grdSub.ReadOnly = True
        Me.grdSub.RowHeadersVisible = False
        Me.grdSub.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdSub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdSub.ShowEditingIcon = False
        Me.grdSub.Size = New System.Drawing.Size(494, 195)
        Me.grdSub.TabIndex = 104
        '
        'AccountCode
        '
        Me.AccountCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountCode.DefaultCellStyle = DataGridViewCellStyle3
        Me.AccountCode.HeaderText = "Code"
        Me.AccountCode.MaxInputLength = 4
        Me.AccountCode.Name = "AccountCode"
        Me.AccountCode.ReadOnly = True
        Me.AccountCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AccountCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AccountCode.Width = 45
        '
        'Division
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Division.DefaultCellStyle = DataGridViewCellStyle4
        Me.Division.HeaderText = "Division"
        Me.Division.Name = "Division"
        Me.Division.ReadOnly = True
        Me.Division.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Division.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Division.Width = 70
        '
        'AccountName
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.AccountName.DefaultCellStyle = DataGridViewCellStyle5
        Me.AccountName.HeaderText = "Name"
        Me.AccountName.MaxInputLength = 30
        Me.AccountName.Name = "AccountName"
        Me.AccountName.ReadOnly = True
        Me.AccountName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AccountName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AccountName.Width = 200
        '
        'Remark
        '
        Me.Remark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Remark.DefaultCellStyle = DataGridViewCellStyle6
        Me.Remark.HeaderText = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.ReadOnly = True
        Me.Remark.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Remark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'txtAccountCode
        '
        Me.txtAccountCode.BackColor = System.Drawing.SystemColors.Control
        Me.txtAccountCode.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtAccountCode.Location = New System.Drawing.Point(165, 118)
        Me.txtAccountCode.Mask = "0000"
        Me.txtAccountCode.Name = "txtAccountCode"
        Me.txtAccountCode.ReadOnly = True
        Me.txtAccountCode.ResetOnSpace = False
        Me.txtAccountCode.Size = New System.Drawing.Size(41, 23)
        Me.txtAccountCode.TabIndex = 2
        Me.txtAccountCode.TabStop = False
        Me.txtAccountCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 118)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 23)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Account Code:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 76)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(150, 23)
        Me.Label15.TabIndex = 102
        Me.Label15.Text = "Book Code:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBookYear
        '
        Me.txtBookYear.BackColor = System.Drawing.SystemColors.Control
        Me.txtBookYear.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtBookYear.Location = New System.Drawing.Point(165, 44)
        Me.txtBookYear.Mask = "0000"
        Me.txtBookYear.Name = "txtBookYear"
        Me.txtBookYear.ReadOnly = True
        Me.txtBookYear.ResetOnSpace = False
        Me.txtBookYear.Size = New System.Drawing.Size(41, 23)
        Me.txtBookYear.TabIndex = 99
        Me.txtBookYear.TabStop = False
        Me.txtBookYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 44)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(150, 23)
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
        'txtBookCode
        '
        Me.txtBookCode.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtBookCode.Location = New System.Drawing.Point(165, 76)
        Me.txtBookCode.Mask = "0000"
        Me.txtBookCode.Name = "txtBookCode"
        Me.txtBookCode.ReadOnly = True
        Me.txtBookCode.ResetOnSpace = False
        Me.txtBookCode.Size = New System.Drawing.Size(41, 23)
        Me.txtBookCode.TabIndex = 1
        Me.txtBookCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnFindCode
        '
        Me.btnFindCode.Image = Global.Accounting.My.Resources.Resources.searchImg
        Me.btnFindCode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFindCode.Location = New System.Drawing.Point(217, 118)
        Me.btnFindCode.Name = "btnFindCode"
        Me.btnFindCode.Size = New System.Drawing.Size(64, 23)
        Me.btnFindCode.TabIndex = 2
        Me.btnFindCode.Text = "Find"
        Me.btnFindCode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFindCode.UseVisualStyleBackColor = True
        '
        'menuTS
        '
        Me.menuTS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newTSB, Me.deleteTSB, Me.ToolStripSeparator1, Me.firstTSB, Me.previousTSB, Me.nextTSB, Me.lastTSB, Me.ToolStripSeparator2, Me.refreshTSB, Me.ToolStripSeparator3, Me.closeTSB, Me.ToolStripSeparator4, Me.saveTSB, Me.cboYear})
        Me.menuTS.Location = New System.Drawing.Point(0, 0)
        Me.menuTS.Name = "menuTS"
        Me.menuTS.Padding = New System.Windows.Forms.Padding(0, 2, 1, 2)
        Me.menuTS.Size = New System.Drawing.Size(494, 27)
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
        'ComposeBookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 379)
        Me.Controls.Add(Me.SplitContainer)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ComposeBookForm"
        Me.Text = "Compose Book Code"
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel2.ResumeLayout(False)
        Me.SplitContainer.Panel2.PerformLayout()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        CType(Me.grdNavi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSub, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuTS.ResumeLayout(False)
        Me.menuTS.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer As SplitContainer
    Friend WithEvents grdNavi As DataGridView
    Friend WithEvents menuTS As ToolStrip
    Friend WithEvents deleteTSB As ToolStripButton
    Friend WithEvents formTT As ToolTip
    Friend WithEvents postalAreaLL As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Private WithEvents txtAccountCode As MaskedTextBox
    Private WithEvents btnFindCode As Button
    Private WithEvents txtBookCode As MaskedTextBox
    Private WithEvents txtBookYear As MaskedTextBox
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
    Friend WithEvents lblAccountName As Label
    Friend WithEvents lblBookName As Label
    Friend WithEvents grdSub As DataGridView
    Friend WithEvents BookCode As DataGridViewTextBoxColumn
    Friend WithEvents BookName As DataGridViewTextBoxColumn
    Friend WithEvents AccountCode As DataGridViewTextBoxColumn
    Friend WithEvents Division As DataGridViewTextBoxColumn
    Friend WithEvents AccountName As DataGridViewTextBoxColumn
    Friend WithEvents Remark As DataGridViewTextBoxColumn
End Class
