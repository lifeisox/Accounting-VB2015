<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DedicatorForm
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DedicatorForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.entryPnl = New System.Windows.Forms.Panel()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDedicator = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grdDedicator = New System.Windows.Forms.DataGridView()
        Me.DedicatorCodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DedicatorNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grdMember = New System.Windows.Forms.DataGridView()
        Me.MemberCodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.entryPnl.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grdDedicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.grdMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.entryPnl)
        Me.Panel1.Controls.Add(Me.btnRemove)
        Me.Panel1.Controls.Add(Me.btnInsert)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cboYear)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(240, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 20)
        Me.Panel1.Size = New System.Drawing.Size(239, 399)
        Me.Panel1.TabIndex = 6
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Image = Global.Accounting.My.Resources.Resources.closeImg
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.Location = New System.Drawing.Point(49, 357)
        Me.btnClose.MinimumSize = New System.Drawing.Size(150, 30)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 30)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'entryPnl
        '
        Me.entryPnl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.entryPnl.BackColor = System.Drawing.SystemColors.GrayText
        Me.entryPnl.Controls.Add(Me.btnConfirm)
        Me.entryPnl.Controls.Add(Me.lblName)
        Me.entryPnl.Controls.Add(Me.lblCode)
        Me.entryPnl.Controls.Add(Me.Label4)
        Me.entryPnl.Controls.Add(Me.Label3)
        Me.entryPnl.Controls.Add(Me.txtDedicator)
        Me.entryPnl.Controls.Add(Me.Label2)
        Me.entryPnl.Location = New System.Drawing.Point(15, 92)
        Me.entryPnl.Margin = New System.Windows.Forms.Padding(10, 10, 10, 3)
        Me.entryPnl.MinimumSize = New System.Drawing.Size(210, 0)
        Me.entryPnl.Name = "entryPnl"
        Me.entryPnl.Size = New System.Drawing.Size(210, 161)
        Me.entryPnl.TabIndex = 8
        Me.entryPnl.Visible = False
        '
        'btnConfirm
        '
        Me.btnConfirm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirm.Location = New System.Drawing.Point(64, 120)
        Me.btnConfirm.MinimumSize = New System.Drawing.Size(80, 25)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(80, 25)
        Me.btnConfirm.TabIndex = 9
        Me.btnConfirm.Text = "OK"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblName.Location = New System.Drawing.Point(57, 62)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(136, 38)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Name Label"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblCode.Location = New System.Drawing.Point(57, 45)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(77, 15)
        Me.lblCode.TabIndex = 7
        Me.lblCode.Text = "Code Label"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Location = New System.Drawing.Point(14, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Location = New System.Drawing.Point(14, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Code:"
        '
        'txtDedicator
        '
        Me.txtDedicator.Location = New System.Drawing.Point(128, 12)
        Me.txtDedicator.Mask = "000"
        Me.txtDedicator.Name = "txtDedicator"
        Me.txtDedicator.ResetOnSpace = False
        Me.txtDedicator.Size = New System.Drawing.Size(39, 23)
        Me.txtDedicator.TabIndex = 1
        Me.txtDedicator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(17, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Dedicator Code"
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.Image = Global.Accounting.My.Resources.Resources.removeImg
        Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemove.Location = New System.Drawing.Point(49, 310)
        Me.btnRemove.MinimumSize = New System.Drawing.Size(150, 30)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(150, 30)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove Dedicator"
        Me.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInsert.Image = Global.Accounting.My.Resources.Resources.moveLeftImg
        Me.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInsert.Location = New System.Drawing.Point(49, 274)
        Me.btnInsert.MinimumSize = New System.Drawing.Size(150, 30)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(150, 30)
        Me.btnInsert.TabIndex = 2
        Me.btnInsert.Text = "To Dedicator"
        Me.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(49, 28)
        Me.Label1.MinimumSize = New System.Drawing.Size(150, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Offering Year"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboYear
        '
        Me.cboYear.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboYear.DropDownHeight = 100
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.IntegralHeight = False
        Me.cboYear.ItemHeight = 15
        Me.cboYear.Location = New System.Drawing.Point(49, 51)
        Me.cboYear.MaxDropDownItems = 10
        Me.cboYear.MinimumSize = New System.Drawing.Size(150, 0)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(150, 23)
        Me.cboYear.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Left
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdDedicator)
        Me.SplitContainer1.Size = New System.Drawing.Size(240, 399)
        Me.SplitContainer1.SplitterDistance = 28
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(240, 28)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Dedicator"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grdDedicator
        '
        Me.grdDedicator.AllowUserToAddRows = False
        Me.grdDedicator.AllowUserToDeleteRows = False
        Me.grdDedicator.AllowUserToResizeColumns = False
        Me.grdDedicator.AllowUserToResizeRows = False
        Me.grdDedicator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDedicator.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DedicatorCodeCol, Me.DedicatorNameCol, Me.MemberCode})
        Me.grdDedicator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDedicator.Location = New System.Drawing.Point(0, 0)
        Me.grdDedicator.Margin = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.grdDedicator.MultiSelect = False
        Me.grdDedicator.Name = "grdDedicator"
        Me.grdDedicator.ReadOnly = True
        Me.grdDedicator.RowHeadersVisible = False
        Me.grdDedicator.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdDedicator.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDedicator.ShowEditingIcon = False
        Me.grdDedicator.Size = New System.Drawing.Size(240, 370)
        Me.grdDedicator.TabIndex = 90
        Me.grdDedicator.TabStop = False
        '
        'DedicatorCodeCol
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DedicatorCodeCol.DefaultCellStyle = DataGridViewCellStyle1
        Me.DedicatorCodeCol.HeaderText = "Code"
        Me.DedicatorCodeCol.MaxInputLength = 3
        Me.DedicatorCodeCol.Name = "DedicatorCodeCol"
        Me.DedicatorCodeCol.ReadOnly = True
        Me.DedicatorCodeCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DedicatorCodeCol.Width = 50
        '
        'DedicatorNameCol
        '
        Me.DedicatorNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.DedicatorNameCol.DefaultCellStyle = DataGridViewCellStyle2
        Me.DedicatorNameCol.HeaderText = "Name"
        Me.DedicatorNameCol.MaxInputLength = 30
        Me.DedicatorNameCol.Name = "DedicatorNameCol"
        Me.DedicatorNameCol.ReadOnly = True
        Me.DedicatorNameCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'MemberCode
        '
        Me.MemberCode.HeaderText = "MemberCode"
        Me.MemberCode.MaxInputLength = 5
        Me.MemberCode.Name = "MemberCode"
        Me.MemberCode.ReadOnly = True
        Me.MemberCode.Visible = False
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Right
        Me.SplitContainer2.Location = New System.Drawing.Point(479, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label6)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.grdMember)
        Me.SplitContainer2.Size = New System.Drawing.Size(240, 399)
        Me.SplitContainer2.SplitterDistance = 28
        Me.SplitContainer2.SplitterWidth = 1
        Me.SplitContainer2.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(240, 28)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Member"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grdMember
        '
        Me.grdMember.AllowUserToAddRows = False
        Me.grdMember.AllowUserToDeleteRows = False
        Me.grdMember.AllowUserToResizeColumns = False
        Me.grdMember.AllowUserToResizeRows = False
        Me.grdMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMember.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MemberCodeCol, Me.MemberNameCol})
        Me.grdMember.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdMember.Location = New System.Drawing.Point(0, 0)
        Me.grdMember.Margin = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.grdMember.MultiSelect = False
        Me.grdMember.Name = "grdMember"
        Me.grdMember.ReadOnly = True
        Me.grdMember.RowHeadersVisible = False
        Me.grdMember.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdMember.ShowEditingIcon = False
        Me.grdMember.Size = New System.Drawing.Size(240, 370)
        Me.grdMember.TabIndex = 90
        Me.grdMember.TabStop = False
        '
        'MemberCodeCol
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberCodeCol.DefaultCellStyle = DataGridViewCellStyle3
        Me.MemberCodeCol.HeaderText = "Code"
        Me.MemberCodeCol.MaxInputLength = 5
        Me.MemberCodeCol.Name = "MemberCodeCol"
        Me.MemberCodeCol.ReadOnly = True
        Me.MemberCodeCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MemberCodeCol.Width = 50
        '
        'MemberNameCol
        '
        Me.MemberNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.MemberNameCol.DefaultCellStyle = DataGridViewCellStyle4
        Me.MemberNameCol.HeaderText = "Name"
        Me.MemberNameCol.MaxInputLength = 30
        Me.MemberNameCol.Name = "MemberNameCol"
        Me.MemberNameCol.ReadOnly = True
        Me.MemberNameCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DedicatorForm
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 399)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DedicatorForm"
        Me.Text = "Managing Dedicator Code"
        Me.Panel1.ResumeLayout(False)
        Me.entryPnl.ResumeLayout(False)
        Me.entryPnl.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grdDedicator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.grdMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents entryPnl As Panel
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnInsert As Button
    Private WithEvents Label1 As Label
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents grdDedicator As DataGridView
    Private WithEvents Label5 As Label
    Friend WithEvents SplitContainer2 As SplitContainer
    Private WithEvents Label6 As Label
    Friend WithEvents grdMember As DataGridView
    Private WithEvents lblName As Label
    Private WithEvents lblCode As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label3 As Label
    Friend WithEvents txtDedicator As MaskedTextBox
    Private WithEvents Label2 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents DedicatorCodeCol As DataGridViewTextBoxColumn
    Friend WithEvents DedicatorNameCol As DataGridViewTextBoxColumn
    Friend WithEvents MemberCode As DataGridViewTextBoxColumn
    Friend WithEvents MemberCodeCol As DataGridViewTextBoxColumn
    Friend WithEvents MemberNameCol As DataGridViewTextBoxColumn
    Friend WithEvents btnClose As Button
End Class
