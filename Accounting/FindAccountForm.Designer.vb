<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindAccountForm
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdNavi = New System.Windows.Forms.DataGridView()
        Me.colAccountCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDivision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccountName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkWithComputedField = New System.Windows.Forms.CheckBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grdNavi, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkWithComputedField)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnCancel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnOk)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdNavi)
        Me.SplitContainer1.Size = New System.Drawing.Size(480, 333)
        Me.SplitContainer1.SplitterDistance = 46
        Me.SplitContainer1.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(409, 9)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(59, 31)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(352, 9)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(51, 31)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "&OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtName.ImeMode = System.Windows.Forms.ImeMode.Hangul
        Me.txtName.Location = New System.Drawing.Point(117, 12)
        Me.txtName.MaxLength = 20
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(89, 23)
        Me.txtName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account Name:"
        '
        'grdNavi
        '
        Me.grdNavi.AllowUserToAddRows = False
        Me.grdNavi.AllowUserToDeleteRows = False
        Me.grdNavi.AllowUserToResizeColumns = False
        Me.grdNavi.AllowUserToResizeRows = False
        Me.grdNavi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdNavi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colAccountCode, Me.colDivision, Me.colAccountName})
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
        Me.grdNavi.Size = New System.Drawing.Size(480, 283)
        Me.grdNavi.TabIndex = 4
        '
        'colAccountCode
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAccountCode.DefaultCellStyle = DataGridViewCellStyle4
        Me.colAccountCode.HeaderText = "Code"
        Me.colAccountCode.MaxInputLength = 4
        Me.colAccountCode.Name = "colAccountCode"
        Me.colAccountCode.ReadOnly = True
        Me.colAccountCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colAccountCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colAccountCode.Width = 45
        '
        'colDivision
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDivision.DefaultCellStyle = DataGridViewCellStyle5
        Me.colDivision.HeaderText = "Division"
        Me.colDivision.MaxInputLength = 7
        Me.colDivision.Name = "colDivision"
        Me.colDivision.ReadOnly = True
        Me.colDivision.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDivision.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDivision.Width = 70
        '
        'colAccountName
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colAccountName.DefaultCellStyle = DataGridViewCellStyle6
        Me.colAccountName.HeaderText = "Account Name"
        Me.colAccountName.Name = "colAccountName"
        Me.colAccountName.ReadOnly = True
        Me.colAccountName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colAccountName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colAccountName.Width = 1000
        '
        'chkWithComputedField
        '
        Me.chkWithComputedField.AutoSize = True
        Me.chkWithComputedField.Checked = True
        Me.chkWithComputedField.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWithComputedField.Location = New System.Drawing.Point(226, 16)
        Me.chkWithComputedField.Name = "chkWithComputedField"
        Me.chkWithComputedField.Size = New System.Drawing.Size(117, 19)
        Me.chkWithComputedField.TabIndex = 1
        Me.chkWithComputedField.Text = "Computed Fld."
        Me.chkWithComputedField.UseVisualStyleBackColor = True
        '
        'FindAccountForm
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(480, 333)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FindAccountForm"
        Me.Text = "Find Account Code"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grdNavi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents grdNavi As DataGridView
    Friend WithEvents colAccountCode As DataGridViewTextBoxColumn
    Friend WithEvents colDivision As DataGridViewTextBoxColumn
    Friend WithEvents colAccountName As DataGridViewTextBoxColumn
    Private WithEvents chkWithComputedField As CheckBox
End Class
