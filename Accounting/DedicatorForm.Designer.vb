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
        Me.entryPnl = New System.Windows.Forms.Panel()
        Me.confirmBtn = New System.Windows.Forms.Button()
        Me.nameLbl = New System.Windows.Forms.Label()
        Me.codeLbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dedicatorTxt = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.removeBtn = New System.Windows.Forms.Button()
        Me.insertBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.yearCbo = New System.Windows.Forms.ComboBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dedicatorGrd = New System.Windows.Forms.DataGridView()
        Me.DedicatorCodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DedicatorNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.memberGrd = New System.Windows.Forms.DataGridView()
        Me.MemberCodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.entryPnl.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dedicatorGrd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.memberGrd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.closeBtn)
        Me.Panel1.Controls.Add(Me.entryPnl)
        Me.Panel1.Controls.Add(Me.removeBtn)
        Me.Panel1.Controls.Add(Me.insertBtn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.yearCbo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(240, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 20)
        Me.Panel1.Size = New System.Drawing.Size(239, 399)
        Me.Panel1.TabIndex = 6
        '
        'entryPnl
        '
        Me.entryPnl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.entryPnl.BackColor = System.Drawing.SystemColors.GrayText
        Me.entryPnl.Controls.Add(Me.confirmBtn)
        Me.entryPnl.Controls.Add(Me.nameLbl)
        Me.entryPnl.Controls.Add(Me.codeLbl)
        Me.entryPnl.Controls.Add(Me.Label4)
        Me.entryPnl.Controls.Add(Me.Label3)
        Me.entryPnl.Controls.Add(Me.dedicatorTxt)
        Me.entryPnl.Controls.Add(Me.Label2)
        Me.entryPnl.Location = New System.Drawing.Point(15, 92)
        Me.entryPnl.Margin = New System.Windows.Forms.Padding(10, 10, 10, 3)
        Me.entryPnl.MinimumSize = New System.Drawing.Size(210, 0)
        Me.entryPnl.Name = "entryPnl"
        Me.entryPnl.Size = New System.Drawing.Size(210, 161)
        Me.entryPnl.TabIndex = 8
        Me.entryPnl.Visible = False
        '
        'confirmBtn
        '
        Me.confirmBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.confirmBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.confirmBtn.Location = New System.Drawing.Point(64, 120)
        Me.confirmBtn.MinimumSize = New System.Drawing.Size(80, 25)
        Me.confirmBtn.Name = "confirmBtn"
        Me.confirmBtn.Size = New System.Drawing.Size(80, 25)
        Me.confirmBtn.TabIndex = 9
        Me.confirmBtn.Text = "OK"
        Me.confirmBtn.UseVisualStyleBackColor = True
        '
        'nameLbl
        '
        Me.nameLbl.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLbl.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.nameLbl.Location = New System.Drawing.Point(57, 62)
        Me.nameLbl.Name = "nameLbl"
        Me.nameLbl.Size = New System.Drawing.Size(136, 38)
        Me.nameLbl.TabIndex = 8
        Me.nameLbl.Text = "Name Label"
        '
        'codeLbl
        '
        Me.codeLbl.AutoSize = True
        Me.codeLbl.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codeLbl.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.codeLbl.Location = New System.Drawing.Point(57, 45)
        Me.codeLbl.Name = "codeLbl"
        Me.codeLbl.Size = New System.Drawing.Size(77, 15)
        Me.codeLbl.TabIndex = 7
        Me.codeLbl.Text = "Code Label"
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
        'dedicatorTxt
        '
        Me.dedicatorTxt.Location = New System.Drawing.Point(128, 12)
        Me.dedicatorTxt.Mask = "000"
        Me.dedicatorTxt.Name = "dedicatorTxt"
        Me.dedicatorTxt.ResetOnSpace = False
        Me.dedicatorTxt.Size = New System.Drawing.Size(39, 23)
        Me.dedicatorTxt.TabIndex = 1
        Me.dedicatorTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'removeBtn
        '
        Me.removeBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.removeBtn.Image = Global.Accounting.My.Resources.Resources.removeImg
        Me.removeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.removeBtn.Location = New System.Drawing.Point(49, 310)
        Me.removeBtn.MinimumSize = New System.Drawing.Size(150, 30)
        Me.removeBtn.Name = "removeBtn"
        Me.removeBtn.Size = New System.Drawing.Size(150, 30)
        Me.removeBtn.TabIndex = 3
        Me.removeBtn.Text = "Remove Dedicator"
        Me.removeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.removeBtn.UseVisualStyleBackColor = True
        '
        'insertBtn
        '
        Me.insertBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.insertBtn.Image = Global.Accounting.My.Resources.Resources.moveLeftImg
        Me.insertBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.insertBtn.Location = New System.Drawing.Point(49, 274)
        Me.insertBtn.MinimumSize = New System.Drawing.Size(150, 30)
        Me.insertBtn.Name = "insertBtn"
        Me.insertBtn.Size = New System.Drawing.Size(150, 30)
        Me.insertBtn.TabIndex = 2
        Me.insertBtn.Text = "To Dedicator"
        Me.insertBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.insertBtn.UseVisualStyleBackColor = True
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
        'yearCbo
        '
        Me.yearCbo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.yearCbo.DropDownHeight = 100
        Me.yearCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.yearCbo.FormattingEnabled = True
        Me.yearCbo.IntegralHeight = False
        Me.yearCbo.ItemHeight = 15
        Me.yearCbo.Location = New System.Drawing.Point(49, 51)
        Me.yearCbo.MaxDropDownItems = 10
        Me.yearCbo.MinimumSize = New System.Drawing.Size(150, 0)
        Me.yearCbo.Name = "yearCbo"
        Me.yearCbo.Size = New System.Drawing.Size(150, 23)
        Me.yearCbo.TabIndex = 0
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.dedicatorGrd)
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
        'dedicatorGrd
        '
        Me.dedicatorGrd.AllowUserToAddRows = False
        Me.dedicatorGrd.AllowUserToDeleteRows = False
        Me.dedicatorGrd.AllowUserToResizeColumns = False
        Me.dedicatorGrd.AllowUserToResizeRows = False
        Me.dedicatorGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dedicatorGrd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DedicatorCodeCol, Me.DedicatorNameCol, Me.MemberCode})
        Me.dedicatorGrd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dedicatorGrd.Location = New System.Drawing.Point(0, 0)
        Me.dedicatorGrd.Margin = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.dedicatorGrd.MultiSelect = False
        Me.dedicatorGrd.Name = "dedicatorGrd"
        Me.dedicatorGrd.ReadOnly = True
        Me.dedicatorGrd.RowHeadersVisible = False
        Me.dedicatorGrd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dedicatorGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dedicatorGrd.ShowEditingIcon = False
        Me.dedicatorGrd.Size = New System.Drawing.Size(240, 370)
        Me.dedicatorGrd.TabIndex = 90
        Me.dedicatorGrd.TabStop = False
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
        Me.SplitContainer2.Panel2.Controls.Add(Me.memberGrd)
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
        'memberGrd
        '
        Me.memberGrd.AllowUserToAddRows = False
        Me.memberGrd.AllowUserToDeleteRows = False
        Me.memberGrd.AllowUserToResizeColumns = False
        Me.memberGrd.AllowUserToResizeRows = False
        Me.memberGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.memberGrd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MemberCodeCol, Me.MemberNameCol})
        Me.memberGrd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.memberGrd.Location = New System.Drawing.Point(0, 0)
        Me.memberGrd.Margin = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.memberGrd.MultiSelect = False
        Me.memberGrd.Name = "memberGrd"
        Me.memberGrd.ReadOnly = True
        Me.memberGrd.RowHeadersVisible = False
        Me.memberGrd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.memberGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.memberGrd.ShowEditingIcon = False
        Me.memberGrd.Size = New System.Drawing.Size(240, 370)
        Me.memberGrd.TabIndex = 90
        Me.memberGrd.TabStop = False
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
        'closeBtn
        '
        Me.closeBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeBtn.Image = Global.Accounting.My.Resources.Resources.closeImg
        Me.closeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.closeBtn.Location = New System.Drawing.Point(49, 357)
        Me.closeBtn.MinimumSize = New System.Drawing.Size(150, 30)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(150, 30)
        Me.closeBtn.TabIndex = 4
        Me.closeBtn.Text = "Close"
        Me.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'DedicatorForm
        '
        Me.AcceptButton = Me.confirmBtn
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
        CType(Me.dedicatorGrd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.memberGrd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents entryPnl As Panel
    Friend WithEvents removeBtn As Button
    Friend WithEvents insertBtn As Button
    Private WithEvents Label1 As Label
    Friend WithEvents yearCbo As ComboBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dedicatorGrd As DataGridView
    Private WithEvents Label5 As Label
    Friend WithEvents SplitContainer2 As SplitContainer
    Private WithEvents Label6 As Label
    Friend WithEvents memberGrd As DataGridView
    Private WithEvents nameLbl As Label
    Private WithEvents codeLbl As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label3 As Label
    Friend WithEvents dedicatorTxt As MaskedTextBox
    Private WithEvents Label2 As Label
    Friend WithEvents confirmBtn As Button
    Friend WithEvents DedicatorCodeCol As DataGridViewTextBoxColumn
    Friend WithEvents DedicatorNameCol As DataGridViewTextBoxColumn
    Friend WithEvents MemberCode As DataGridViewTextBoxColumn
    Friend WithEvents MemberCodeCol As DataGridViewTextBoxColumn
    Friend WithEvents MemberNameCol As DataGridViewTextBoxColumn
    Friend WithEvents closeBtn As Button
End Class
