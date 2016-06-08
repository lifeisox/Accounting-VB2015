<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CopyAccountCodeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CopyAccountCodeForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cboTo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboFrom = New System.Windows.Forms.ComboBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.grdFrom = New System.Windows.Forms.DataGridView()
        Me.FromCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FromName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.grdTo = New System.Windows.Forms.DataGridView()
        Me.ToCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grdFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.grdTo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.cboTo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnExecute)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cboFrom)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(200, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 20)
        Me.Panel1.Size = New System.Drawing.Size(205, 356)
        Me.Panel1.TabIndex = 6
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Image = Global.Accounting.My.Resources.Resources.closeImg
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.Location = New System.Drawing.Point(28, 303)
        Me.btnClose.MinimumSize = New System.Drawing.Size(150, 30)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 30)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cboTo
        '
        Me.cboTo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTo.DropDownHeight = 1
        Me.cboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTo.FormattingEnabled = True
        Me.cboTo.IntegralHeight = False
        Me.cboTo.ItemHeight = 15
        Me.cboTo.Location = New System.Drawing.Point(28, 110)
        Me.cboTo.MaxDropDownItems = 1
        Me.cboTo.MinimumSize = New System.Drawing.Size(150, 0)
        Me.cboTo.Name = "cboTo"
        Me.cboTo.Size = New System.Drawing.Size(150, 23)
        Me.cboTo.TabIndex = 1
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
        'btnExecute
        '
        Me.btnExecute.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExecute.Image = Global.Accounting.My.Resources.Resources.runImg
        Me.btnExecute.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExecute.Location = New System.Drawing.Point(28, 267)
        Me.btnExecute.MinimumSize = New System.Drawing.Size(150, 30)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(150, 30)
        Me.btnExecute.TabIndex = 2
        Me.btnExecute.Text = "Execute"
        Me.btnExecute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExecute.UseVisualStyleBackColor = True
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
        'cboFrom
        '
        Me.cboFrom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFrom.DropDownHeight = 100
        Me.cboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFrom.FormattingEnabled = True
        Me.cboFrom.IntegralHeight = False
        Me.cboFrom.ItemHeight = 15
        Me.cboFrom.Location = New System.Drawing.Point(28, 51)
        Me.cboFrom.MaxDropDownItems = 10
        Me.cboFrom.MinimumSize = New System.Drawing.Size(150, 0)
        Me.cboFrom.Name = "cboFrom"
        Me.cboFrom.Size = New System.Drawing.Size(150, 23)
        Me.cboFrom.TabIndex = 0
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFrom)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdFrom)
        Me.SplitContainer1.Size = New System.Drawing.Size(200, 356)
        Me.SplitContainer1.SplitterDistance = 25
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 7
        '
        'lblFrom
        '
        Me.lblFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFrom.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblFrom.Location = New System.Drawing.Point(0, 0)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(200, 25)
        Me.lblFrom.TabIndex = 1
        Me.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grdFrom
        '
        Me.grdFrom.AllowUserToAddRows = False
        Me.grdFrom.AllowUserToDeleteRows = False
        Me.grdFrom.AllowUserToResizeColumns = False
        Me.grdFrom.AllowUserToResizeRows = False
        Me.grdFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdFrom.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FromCode, Me.FromName})
        Me.grdFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdFrom.Location = New System.Drawing.Point(0, 0)
        Me.grdFrom.Margin = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.grdFrom.MultiSelect = False
        Me.grdFrom.Name = "grdFrom"
        Me.grdFrom.ReadOnly = True
        Me.grdFrom.RowHeadersVisible = False
        Me.grdFrom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdFrom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdFrom.ShowEditingIcon = False
        Me.grdFrom.Size = New System.Drawing.Size(200, 330)
        Me.grdFrom.TabIndex = 90
        Me.grdFrom.TabStop = False
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblTo)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.grdTo)
        Me.SplitContainer2.Size = New System.Drawing.Size(200, 356)
        Me.SplitContainer2.SplitterDistance = 25
        Me.SplitContainer2.SplitterWidth = 1
        Me.SplitContainer2.TabIndex = 8
        '
        'lblTo
        '
        Me.lblTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTo.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblTo.Location = New System.Drawing.Point(0, 0)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(200, 25)
        Me.lblTo.TabIndex = 1
        Me.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grdTo
        '
        Me.grdTo.AllowUserToAddRows = False
        Me.grdTo.AllowUserToDeleteRows = False
        Me.grdTo.AllowUserToResizeColumns = False
        Me.grdTo.AllowUserToResizeRows = False
        Me.grdTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ToCode, Me.ToName})
        Me.grdTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTo.Location = New System.Drawing.Point(0, 0)
        Me.grdTo.Margin = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.grdTo.MultiSelect = False
        Me.grdTo.Name = "grdTo"
        Me.grdTo.ReadOnly = True
        Me.grdTo.RowHeadersVisible = False
        Me.grdTo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdTo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdTo.ShowEditingIcon = False
        Me.grdTo.Size = New System.Drawing.Size(200, 330)
        Me.grdTo.TabIndex = 90
        Me.grdTo.TabStop = False
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
        'CopyAccountCodeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(605, 356)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CopyAccountCodeForm"
        Me.Text = "Duplicate Dedicator Code"
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grdFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.grdTo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExecute As Button
    Private WithEvents Label1 As Label
    Friend WithEvents cboFrom As ComboBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents grdFrom As DataGridView
    Private WithEvents lblFrom As Label
    Friend WithEvents SplitContainer2 As SplitContainer
    Private WithEvents lblTo As Label
    Friend WithEvents grdTo As DataGridView
    Friend WithEvents cboTo As ComboBox
    Private WithEvents Label2 As Label
    Friend WithEvents FromCode As DataGridViewTextBoxColumn
    Friend WithEvents FromName As DataGridViewTextBoxColumn
    Friend WithEvents ToCode As DataGridViewTextBoxColumn
    Friend WithEvents ToName As DataGridViewTextBoxColumn
    Friend WithEvents btnClose As Button
End Class
