<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindMemberForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FindMemberForm))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.okBtn = New System.Windows.Forms.Button()
        Me.nameTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.naviDGV = New System.Windows.Forms.DataGridView()
        Me.CodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DutyCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.naviDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.cancelBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.okBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.nameTB)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.naviDGV)
        Me.SplitContainer1.Size = New System.Drawing.Size(480, 333)
        Me.SplitContainer1.SplitterDistance = 46
        Me.SplitContainer1.TabIndex = 0
        '
        'cancelBtn
        '
        Me.cancelBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelBtn.Location = New System.Drawing.Point(409, 9)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(59, 31)
        Me.cancelBtn.TabIndex = 3
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'okBtn
        '
        Me.okBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.okBtn.Location = New System.Drawing.Point(352, 9)
        Me.okBtn.Name = "okBtn"
        Me.okBtn.Size = New System.Drawing.Size(51, 31)
        Me.okBtn.TabIndex = 2
        Me.okBtn.Text = "&OK"
        Me.okBtn.UseVisualStyleBackColor = True
        '
        'nameTB
        '
        Me.nameTB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.nameTB.ImeMode = System.Windows.Forms.ImeMode.Hangul
        Me.nameTB.Location = New System.Drawing.Point(61, 14)
        Me.nameTB.MaxLength = 20
        Me.nameTB.Name = "nameTB"
        Me.nameTB.Size = New System.Drawing.Size(138, 23)
        Me.nameTB.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'naviDGV
        '
        Me.naviDGV.AllowUserToAddRows = False
        Me.naviDGV.AllowUserToDeleteRows = False
        Me.naviDGV.AllowUserToResizeColumns = False
        Me.naviDGV.AllowUserToResizeRows = False
        Me.naviDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.naviDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeCol, Me.NameCol, Me.DutyCol, Me.EmailCol})
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
        Me.naviDGV.Size = New System.Drawing.Size(480, 283)
        Me.naviDGV.TabIndex = 4
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.NameCol.DefaultCellStyle = DataGridViewCellStyle2
        Me.NameCol.HeaderText = "Name"
        Me.NameCol.MaxInputLength = 30
        Me.NameCol.Name = "NameCol"
        Me.NameCol.ReadOnly = True
        Me.NameCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NameCol.Width = 150
        '
        'DutyCol
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.DutyCol.DefaultCellStyle = DataGridViewCellStyle3
        Me.DutyCol.HeaderText = "Duty"
        Me.DutyCol.Name = "DutyCol"
        Me.DutyCol.ReadOnly = True
        Me.DutyCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'EmailCol
        '
        Me.EmailCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.EmailCol.DefaultCellStyle = DataGridViewCellStyle4
        Me.EmailCol.HeaderText = "Email"
        Me.EmailCol.Name = "EmailCol"
        Me.EmailCol.ReadOnly = True
        Me.EmailCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'FindMemberForm
        '
        Me.AcceptButton = Me.okBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cancelBtn
        Me.ClientSize = New System.Drawing.Size(480, 333)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FindMemberForm"
        Me.Text = "Find Member"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.naviDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents nameTB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cancelBtn As Button
    Friend WithEvents okBtn As Button
    Friend WithEvents naviDGV As DataGridView
    Friend WithEvents CodeCol As DataGridViewTextBoxColumn
    Friend WithEvents NameCol As DataGridViewTextBoxColumn
    Friend WithEvents DutyCol As DataGridViewTextBoxColumn
    Friend WithEvents EmailCol As DataGridViewTextBoxColumn
End Class
