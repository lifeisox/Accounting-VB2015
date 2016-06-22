<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BudgetEntryForm
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BudgetEntryForm))
        Me.menuTS = New System.Windows.Forms.ToolStrip()
        Me.closeTSB = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.saveTSB = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboYear = New System.Windows.Forms.ToolStripComboBox()
        Me.grdNavi = New System.Windows.Forms.DataGridView()
        Me.AccountCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Budget = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.menuTS.SuspendLayout()
        CType(Me.grdNavi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuTS
        '
        Me.menuTS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.closeTSB, Me.ToolStripSeparator4, Me.saveTSB, Me.ToolStripLabel1, Me.cboYear})
        Me.menuTS.Location = New System.Drawing.Point(0, 0)
        Me.menuTS.Name = "menuTS"
        Me.menuTS.Padding = New System.Windows.Forms.Padding(0, 2, 1, 2)
        Me.menuTS.Size = New System.Drawing.Size(347, 27)
        Me.menuTS.TabIndex = 31
        Me.menuTS.Text = "ToolStrip"
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
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 20)
        Me.ToolStripLabel1.Text = "Year: "
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.DropDownWidth = 75
        Me.cboYear.MaxDropDownItems = 10
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(75, 23)
        '
        'grdNavi
        '
        Me.grdNavi.AllowUserToAddRows = False
        Me.grdNavi.AllowUserToDeleteRows = False
        Me.grdNavi.AllowUserToResizeColumns = False
        Me.grdNavi.AllowUserToResizeRows = False
        Me.grdNavi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdNavi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccountCode, Me.AccountName, Me.Budget})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdNavi.DefaultCellStyle = DataGridViewCellStyle4
        Me.grdNavi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdNavi.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.grdNavi.Location = New System.Drawing.Point(0, 27)
        Me.grdNavi.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.grdNavi.MultiSelect = False
        Me.grdNavi.Name = "grdNavi"
        Me.grdNavi.RowHeadersVisible = False
        Me.grdNavi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdNavi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.grdNavi.ShowEditingIcon = False
        Me.grdNavi.Size = New System.Drawing.Size(347, 421)
        Me.grdNavi.TabIndex = 0
        '
        'AccountCode
        '
        Me.AccountCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountCode.DefaultCellStyle = DataGridViewCellStyle1
        Me.AccountCode.HeaderText = "Code"
        Me.AccountCode.MaxInputLength = 4
        Me.AccountCode.Name = "AccountCode"
        Me.AccountCode.ReadOnly = True
        Me.AccountCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AccountCode.Width = 45
        '
        'AccountName
        '
        Me.AccountName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.AccountName.DefaultCellStyle = DataGridViewCellStyle2
        Me.AccountName.HeaderText = "Name"
        Me.AccountName.MaxInputLength = 50
        Me.AccountName.Name = "AccountName"
        Me.AccountName.ReadOnly = True
        Me.AccountName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Budget
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.Budget.DefaultCellStyle = DataGridViewCellStyle3
        Me.Budget.HeaderText = "Budget"
        Me.Budget.MaxInputLength = 15
        Me.Budget.Name = "Budget"
        Me.Budget.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'BudgetEntryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 448)
        Me.Controls.Add(Me.grdNavi)
        Me.Controls.Add(Me.menuTS)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BudgetEntryForm"
        Me.Text = "Budget Entry"
        Me.menuTS.ResumeLayout(False)
        Me.menuTS.PerformLayout()
        CType(Me.grdNavi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuTS As ToolStrip
    Private WithEvents closeTSB As ToolStripButton
    Private WithEvents ToolStripSeparator4 As ToolStripSeparator
    Private WithEvents saveTSB As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Private WithEvents cboYear As ToolStripComboBox
    Friend WithEvents grdNavi As DataGridView
    Friend WithEvents AccountCode As DataGridViewTextBoxColumn
    Friend WithEvents AccountName As DataGridViewTextBoxColumn
    Friend WithEvents Budget As DataGridViewTextBoxColumn
End Class
