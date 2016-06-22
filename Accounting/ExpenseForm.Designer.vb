<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpenseForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IncomeForm))
        Me.sltPane = New System.Windows.Forms.SplitContainer()
        Me.grdSlip = New System.Windows.Forms.DataGridView()
        Me.calSlipDate = New System.Windows.Forms.MonthCalendar()
        Me.lblSlipDate = New System.Windows.Forms.Label()
        Me.grdSlipItem = New System.Windows.Forms.DataGridView()
        Me.SlipSeq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountCodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboMemberName = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMemberCode = New System.Windows.Forms.Label()
        Me.txtDedicatorCode = New System.Windows.Forms.MaskedTextBox()
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
        Me.SlipNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.sltPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sltPane.Panel1.SuspendLayout()
        Me.sltPane.Panel2.SuspendLayout()
        Me.sltPane.SuspendLayout()
        CType(Me.grdSlip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSlipItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.menuTS.SuspendLayout()
        Me.SuspendLayout()
        '
        'sltPane
        '
        Me.sltPane.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sltPane.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.sltPane.IsSplitterFixed = True
        Me.sltPane.Location = New System.Drawing.Point(0, 0)
        Me.sltPane.Name = "sltPane"
        '
        'sltPane.Panel1
        '
        Me.sltPane.Panel1.Controls.Add(Me.grdSlip)
        Me.sltPane.Panel1.Controls.Add(Me.calSlipDate)
        Me.sltPane.Panel1.Controls.Add(Me.lblSlipDate)
        '
        'sltPane.Panel2
        '
        Me.sltPane.Panel2.Controls.Add(Me.grdSlipItem)
        Me.sltPane.Panel2.Controls.Add(Me.pnlMain)
        Me.sltPane.Panel2.Controls.Add(Me.menuTS)
        Me.sltPane.Size = New System.Drawing.Size(736, 451)
        Me.sltPane.SplitterDistance = 227
        Me.sltPane.SplitterWidth = 2
        Me.sltPane.TabIndex = 0
        '
        'grdSlip
        '
        Me.grdSlip.AllowUserToAddRows = False
        Me.grdSlip.AllowUserToDeleteRows = False
        Me.grdSlip.AllowUserToResizeColumns = False
        Me.grdSlip.AllowUserToResizeRows = False
        Me.grdSlip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdSlip.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdSlip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdSlip.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SlipNo, Me.MemberCode, Me.MemberName, Me.Amount})
        Me.grdSlip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdSlip.Location = New System.Drawing.Point(0, 187)
        Me.grdSlip.MultiSelect = False
        Me.grdSlip.Name = "grdSlip"
        Me.grdSlip.ReadOnly = True
        Me.grdSlip.RowHeadersVisible = False
        Me.grdSlip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdSlip.Size = New System.Drawing.Size(227, 264)
        Me.grdSlip.TabIndex = 100
        Me.grdSlip.TabStop = False
        '
        'calSlipDate
        '
        Me.calSlipDate.AnnuallyBoldedDates = New Date() {New Date(1962, 8, 11, 0, 0, 0, 0), New Date(2016, 12, 25, 0, 0, 0, 0)}
        Me.calSlipDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.calSlipDate.Location = New System.Drawing.Point(0, 25)
        Me.calSlipDate.MaxDate = New Date(2062, 12, 31, 0, 0, 0, 0)
        Me.calSlipDate.MaxSelectionCount = 1
        Me.calSlipDate.MinDate = New Date(1962, 1, 1, 0, 0, 0, 0)
        Me.calSlipDate.Name = "calSlipDate"
        Me.calSlipDate.TabIndex = 100
        Me.calSlipDate.TabStop = False
        '
        'lblSlipDate
        '
        Me.lblSlipDate.BackColor = System.Drawing.Color.SteelBlue
        Me.lblSlipDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSlipDate.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlipDate.ForeColor = System.Drawing.Color.White
        Me.lblSlipDate.Location = New System.Drawing.Point(0, 0)
        Me.lblSlipDate.Name = "lblSlipDate"
        Me.lblSlipDate.Size = New System.Drawing.Size(227, 25)
        Me.lblSlipDate.TabIndex = 0
        Me.lblSlipDate.Text = "20 June 2016"
        Me.lblSlipDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grdSlipItem
        '
        Me.grdSlipItem.AllowUserToAddRows = False
        Me.grdSlipItem.AllowUserToDeleteRows = False
        Me.grdSlipItem.AllowUserToResizeColumns = False
        Me.grdSlipItem.AllowUserToResizeRows = False
        Me.grdSlipItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdSlipItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grdSlipItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdSlipItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SlipSeq, Me.AccountCodeCol, Me.AccountNameCol, Me.ItemAmount})
        Me.grdSlipItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdSlipItem.Location = New System.Drawing.Point(0, 300)
        Me.grdSlipItem.MultiSelect = False
        Me.grdSlipItem.Name = "grdSlipItem"
        Me.grdSlipItem.ReadOnly = True
        Me.grdSlipItem.RowHeadersVisible = False
        Me.grdSlipItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.grdSlipItem.Size = New System.Drawing.Size(507, 151)
        Me.grdSlipItem.TabIndex = 101
        Me.grdSlipItem.TabStop = False
        '
        'SlipSeq
        '
        Me.SlipSeq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SlipSeq.DefaultCellStyle = DataGridViewCellStyle7
        Me.SlipSeq.HeaderText = "Seq"
        Me.SlipSeq.Name = "SlipSeq"
        Me.SlipSeq.ReadOnly = True
        Me.SlipSeq.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SlipSeq.Width = 40
        '
        'AccountCodeCol
        '
        Me.AccountCodeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.AccountCodeCol.DefaultCellStyle = DataGridViewCellStyle8
        Me.AccountCodeCol.HeaderText = "Code"
        Me.AccountCodeCol.MaxInputLength = 4
        Me.AccountCodeCol.Name = "AccountCodeCol"
        Me.AccountCodeCol.ReadOnly = True
        Me.AccountCodeCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AccountCodeCol.Width = 60
        '
        'AccountNameCol
        '
        Me.AccountNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.AccountNameCol.DefaultCellStyle = DataGridViewCellStyle9
        Me.AccountNameCol.HeaderText = "Account Name"
        Me.AccountNameCol.Name = "AccountNameCol"
        Me.AccountNameCol.ReadOnly = True
        Me.AccountNameCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AccountNameCol.Width = 270
        '
        'ItemAmount
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.ItemAmount.DefaultCellStyle = DataGridViewCellStyle10
        Me.ItemAmount.HeaderText = "Amount"
        Me.ItemAmount.Name = "ItemAmount"
        Me.ItemAmount.ReadOnly = True
        Me.ItemAmount.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ItemAmount.Width = 130
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.txtRemark)
        Me.pnlMain.Controls.Add(Me.Label2)
        Me.pnlMain.Controls.Add(Me.cboMemberName)
        Me.pnlMain.Controls.Add(Me.Label3)
        Me.pnlMain.Controls.Add(Me.lblMemberCode)
        Me.pnlMain.Controls.Add(Me.txtDedicatorCode)
        Me.pnlMain.Controls.Add(Me.Label1)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMain.Location = New System.Drawing.Point(0, 27)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(507, 273)
        Me.pnlMain.TabIndex = 1
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(137, 46)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(352, 23)
        Me.txtRemark.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Remark:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboMemberName
        '
        Me.cboMemberName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboMemberName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMemberName.DropDownHeight = 200
        Me.cboMemberName.DropDownWidth = 200
        Me.cboMemberName.ImeMode = System.Windows.Forms.ImeMode.Hangul
        Me.cboMemberName.IntegralHeight = False
        Me.cboMemberName.Location = New System.Drawing.Point(366, 16)
        Me.cboMemberName.MaxDropDownItems = 15
        Me.cboMemberName.Name = "cboMemberName"
        Me.cboMemberName.Size = New System.Drawing.Size(123, 23)
        Me.cboMemberName.Sorted = True
        Me.cboMemberName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(240, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Member Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMemberCode
        '
        Me.lblMemberCode.Location = New System.Drawing.Point(369, 16)
        Me.lblMemberCode.Name = "lblMemberCode"
        Me.lblMemberCode.Size = New System.Drawing.Size(120, 23)
        Me.lblMemberCode.TabIndex = 2
        Me.lblMemberCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDedicatorCode
        '
        Me.txtDedicatorCode.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtDedicatorCode.Location = New System.Drawing.Point(136, 16)
        Me.txtDedicatorCode.Mask = "000"
        Me.txtDedicatorCode.Name = "txtDedicatorCode"
        Me.txtDedicatorCode.RejectInputOnFirstFailure = True
        Me.txtDedicatorCode.ResetOnSpace = False
        Me.txtDedicatorCode.Size = New System.Drawing.Size(45, 23)
        Me.txtDedicatorCode.TabIndex = 0
        Me.txtDedicatorCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dedicator Code:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'menuTS
        '
        Me.menuTS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newTSB, Me.deleteTSB, Me.ToolStripSeparator1, Me.firstTSB, Me.previousTSB, Me.nextTSB, Me.lastTSB, Me.ToolStripSeparator2, Me.refreshTSB, Me.ToolStripSeparator3, Me.closeTSB, Me.ToolStripSeparator4, Me.saveTSB})
        Me.menuTS.Location = New System.Drawing.Point(0, 0)
        Me.menuTS.Name = "menuTS"
        Me.menuTS.Padding = New System.Windows.Forms.Padding(0, 2, 1, 2)
        Me.menuTS.Size = New System.Drawing.Size(507, 27)
        Me.menuTS.TabIndex = 31
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
        'SlipNo
        '
        Me.SlipNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SlipNo.DefaultCellStyle = DataGridViewCellStyle2
        Me.SlipNo.HeaderText = "No"
        Me.SlipNo.Name = "SlipNo"
        Me.SlipNo.ReadOnly = True
        Me.SlipNo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SlipNo.Width = 30
        '
        'MemberCode
        '
        Me.MemberCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.MemberCode.DefaultCellStyle = DataGridViewCellStyle3
        Me.MemberCode.HeaderText = "Code"
        Me.MemberCode.MaxInputLength = 5
        Me.MemberCode.Name = "MemberCode"
        Me.MemberCode.ReadOnly = True
        Me.MemberCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MemberCode.Width = 45
        '
        'MemberName
        '
        Me.MemberName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.MemberName.DefaultCellStyle = DataGridViewCellStyle4
        Me.MemberName.HeaderText = "Name"
        Me.MemberName.Name = "MemberName"
        Me.MemberName.ReadOnly = True
        Me.MemberName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MemberName.Width = 85
        '
        'Amount
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle5
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Amount.Width = 65
        '
        'IncomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 451)
        Me.Controls.Add(Me.sltPane)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ExpenseForm"
        Me.Text = "Expenses"
        Me.sltPane.Panel1.ResumeLayout(False)
        Me.sltPane.Panel2.ResumeLayout(False)
        Me.sltPane.Panel2.PerformLayout()
        CType(Me.sltPane, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sltPane.ResumeLayout(False)
        CType(Me.grdSlip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSlipItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.menuTS.ResumeLayout(False)
        Me.menuTS.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sltPane As SplitContainer
    Private WithEvents grdSlip As DataGridView
    Private WithEvents calSlipDate As MonthCalendar
    Private WithEvents lblSlipDate As Label
    Friend WithEvents pnlMain As Panel
    Private WithEvents grdSlipItem As DataGridView
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
    Private WithEvents cboMemberName As ComboBox
    Private WithEvents Label3 As Label
    Private WithEvents lblMemberCode As Label
    Private WithEvents txtDedicatorCode As MaskedTextBox
    Private WithEvents Label1 As Label
    Friend WithEvents txtRemark As TextBox
    Private WithEvents Label2 As Label
    Friend WithEvents SlipSeq As DataGridViewTextBoxColumn
    Friend WithEvents AccountCodeCol As DataGridViewTextBoxColumn
    Friend WithEvents AccountNameCol As DataGridViewTextBoxColumn
    Friend WithEvents ItemAmount As DataGridViewTextBoxColumn
    Friend WithEvents SlipNo As DataGridViewTextBoxColumn
    Friend WithEvents MemberCode As DataGridViewTextBoxColumn
    Friend WithEvents MemberName As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
End Class
