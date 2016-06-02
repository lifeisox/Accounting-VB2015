<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CopyDedicatorForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CopyDedicatorForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.toCbo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.executeBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fromCbo = New System.Windows.Forms.ComboBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.fromLbl = New System.Windows.Forms.Label()
        Me.fromGrd = New System.Windows.Forms.DataGridView()
        Me.FromCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FromName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.toLbl = New System.Windows.Forms.Label()
        Me.toGrd = New System.Windows.Forms.DataGridView()
        Me.ToCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.fromGrd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.toGrd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.closeBtn)
        Me.Panel1.Controls.Add(Me.toCbo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.executeBtn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.fromCbo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(200, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 20)
        Me.Panel1.Size = New System.Drawing.Size(205, 356)
        Me.Panel1.TabIndex = 6
        '
        'toCbo
        '
        Me.toCbo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toCbo.DropDownHeight = 100
        Me.toCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.toCbo.FormattingEnabled = True
        Me.toCbo.IntegralHeight = False
        Me.toCbo.ItemHeight = 15
        Me.toCbo.Location = New System.Drawing.Point(28, 110)
        Me.toCbo.MaxDropDownItems = 10
        Me.toCbo.MinimumSize = New System.Drawing.Size(150, 0)
        Me.toCbo.Name = "toCbo"
        Me.toCbo.Size = New System.Drawing.Size(150, 23)
        Me.toCbo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(28, 87)
        Me.Label2.MinimumSize = New System.Drawing.Size(150, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "To"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'executeBtn
        '
        Me.executeBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.executeBtn.Image = Global.Accounting.My.Resources.Resources.runImg
        Me.executeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.executeBtn.Location = New System.Drawing.Point(28, 267)
        Me.executeBtn.MinimumSize = New System.Drawing.Size(150, 30)
        Me.executeBtn.Name = "executeBtn"
        Me.executeBtn.Size = New System.Drawing.Size(150, 30)
        Me.executeBtn.TabIndex = 2
        Me.executeBtn.Text = "Execute"
        Me.executeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.executeBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(28, 28)
        Me.Label1.MinimumSize = New System.Drawing.Size(150, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "From"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'fromCbo
        '
        Me.fromCbo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fromCbo.DropDownHeight = 100
        Me.fromCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.fromCbo.FormattingEnabled = True
        Me.fromCbo.IntegralHeight = False
        Me.fromCbo.ItemHeight = 15
        Me.fromCbo.Location = New System.Drawing.Point(28, 51)
        Me.fromCbo.MaxDropDownItems = 10
        Me.fromCbo.MinimumSize = New System.Drawing.Size(150, 0)
        Me.fromCbo.Name = "fromCbo"
        Me.fromCbo.Size = New System.Drawing.Size(150, 23)
        Me.fromCbo.TabIndex = 0
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.fromLbl)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.fromGrd)
        Me.SplitContainer1.Size = New System.Drawing.Size(200, 356)
        Me.SplitContainer1.SplitterDistance = 25
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 7
        '
        'fromLbl
        '
        Me.fromLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fromLbl.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fromLbl.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.fromLbl.Location = New System.Drawing.Point(0, 0)
        Me.fromLbl.Name = "fromLbl"
        Me.fromLbl.Size = New System.Drawing.Size(200, 25)
        Me.fromLbl.TabIndex = 1
        Me.fromLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fromGrd
        '
        Me.fromGrd.AllowUserToAddRows = False
        Me.fromGrd.AllowUserToDeleteRows = False
        Me.fromGrd.AllowUserToResizeColumns = False
        Me.fromGrd.AllowUserToResizeRows = False
        Me.fromGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.fromGrd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FromCode, Me.FromName})
        Me.fromGrd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fromGrd.Location = New System.Drawing.Point(0, 0)
        Me.fromGrd.Margin = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.fromGrd.MultiSelect = False
        Me.fromGrd.Name = "fromGrd"
        Me.fromGrd.ReadOnly = True
        Me.fromGrd.RowHeadersVisible = False
        Me.fromGrd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fromGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.fromGrd.ShowEditingIcon = False
        Me.fromGrd.Size = New System.Drawing.Size(200, 330)
        Me.fromGrd.TabIndex = 90
        Me.fromGrd.TabStop = False
        '
        'FromCode
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromCode.DefaultCellStyle = DataGridViewCellStyle1
        Me.FromCode.HeaderText = "Code"
        Me.FromCode.MaxInputLength = 3
        Me.FromCode.Name = "FromCode"
        Me.FromCode.ReadOnly = True
        Me.FromCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FromCode.Width = 50
        '
        'FromName
        '
        Me.FromName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.FromName.DefaultCellStyle = DataGridViewCellStyle2
        Me.FromName.HeaderText = "Name"
        Me.FromName.MaxInputLength = 30
        Me.FromName.Name = "FromName"
        Me.FromName.ReadOnly = True
        Me.FromName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Right
        Me.SplitContainer2.Location = New System.Drawing.Point(405, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.SplitContainer2.Panel1.Controls.Add(Me.toLbl)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.toGrd)
        Me.SplitContainer2.Size = New System.Drawing.Size(200, 356)
        Me.SplitContainer2.SplitterDistance = 25
        Me.SplitContainer2.SplitterWidth = 1
        Me.SplitContainer2.TabIndex = 8
        '
        'toLbl
        '
        Me.toLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toLbl.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toLbl.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.toLbl.Location = New System.Drawing.Point(0, 0)
        Me.toLbl.Name = "toLbl"
        Me.toLbl.Size = New System.Drawing.Size(200, 25)
        Me.toLbl.TabIndex = 1
        Me.toLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'toGrd
        '
        Me.toGrd.AllowUserToAddRows = False
        Me.toGrd.AllowUserToDeleteRows = False
        Me.toGrd.AllowUserToResizeColumns = False
        Me.toGrd.AllowUserToResizeRows = False
        Me.toGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.toGrd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ToCode, Me.ToName})
        Me.toGrd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toGrd.Location = New System.Drawing.Point(0, 0)
        Me.toGrd.Margin = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.toGrd.MultiSelect = False
        Me.toGrd.Name = "toGrd"
        Me.toGrd.ReadOnly = True
        Me.toGrd.RowHeadersVisible = False
        Me.toGrd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.toGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.toGrd.ShowEditingIcon = False
        Me.toGrd.Size = New System.Drawing.Size(200, 330)
        Me.toGrd.TabIndex = 90
        Me.toGrd.TabStop = False
        '
        'ToCode
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToCode.DefaultCellStyle = DataGridViewCellStyle3
        Me.ToCode.HeaderText = "Code"
        Me.ToCode.MaxInputLength = 5
        Me.ToCode.Name = "ToCode"
        Me.ToCode.ReadOnly = True
        Me.ToCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ToCode.Width = 50
        '
        'ToName
        '
        Me.ToName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.ToName.DefaultCellStyle = DataGridViewCellStyle4
        Me.ToName.HeaderText = "Name"
        Me.ToName.MaxInputLength = 30
        Me.ToName.Name = "ToName"
        Me.ToName.ReadOnly = True
        Me.ToName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'closeBtn
        '
        Me.closeBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.closeBtn.Image = Global.Accounting.My.Resources.Resources.closeImg
        Me.closeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.closeBtn.Location = New System.Drawing.Point(28, 303)
        Me.closeBtn.MinimumSize = New System.Drawing.Size(150, 30)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(150, 30)
        Me.closeBtn.TabIndex = 3
        Me.closeBtn.Text = "Close"
        Me.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'CopyDedicatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.closeBtn
        Me.ClientSize = New System.Drawing.Size(605, 356)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CopyDedicatorForm"
        Me.Text = "Duplicate Dedicator Code"
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.fromGrd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.toGrd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents executeBtn As Button
    Private WithEvents Label1 As Label
    Friend WithEvents fromCbo As ComboBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents fromGrd As DataGridView
    Private WithEvents fromLbl As Label
    Friend WithEvents SplitContainer2 As SplitContainer
    Private WithEvents toLbl As Label
    Friend WithEvents toGrd As DataGridView
    Friend WithEvents toCbo As ComboBox
    Private WithEvents Label2 As Label
    Friend WithEvents FromCode As DataGridViewTextBoxColumn
    Friend WithEvents FromName As DataGridViewTextBoxColumn
    Friend WithEvents ToCode As DataGridViewTextBoxColumn
    Friend WithEvents ToName As DataGridViewTextBoxColumn
    Friend WithEvents closeBtn As Button
End Class
