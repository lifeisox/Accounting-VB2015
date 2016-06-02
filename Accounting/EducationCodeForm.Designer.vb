<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EducationCodeForm
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EducationCodeForm))
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.naviDGV = New System.Windows.Forms.DataGridView()
        Me.CodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nameTB = New System.Windows.Forms.TextBox()
        Me.codeTB = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.menuTS = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.formTT = New System.Windows.Forms.ToolTip(Me.components)
        Me.newTSB = New System.Windows.Forms.ToolStripButton()
        Me.deleteTSB = New System.Windows.Forms.ToolStripButton()
        Me.firstTSB = New System.Windows.Forms.ToolStripButton()
        Me.previousTSB = New System.Windows.Forms.ToolStripButton()
        Me.nextTSB = New System.Windows.Forms.ToolStripButton()
        Me.lastTSB = New System.Windows.Forms.ToolStripButton()
        Me.refreshTSB = New System.Windows.Forms.ToolStripButton()
        Me.closeTSB = New System.Windows.Forms.ToolStripButton()
        Me.saveTSB = New System.Windows.Forms.ToolStripButton()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        CType(Me.naviDGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer.Panel1.Controls.Add(Me.naviDGV)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.SplitContainer.Panel2.Controls.Add(Me.nameTB)
        Me.SplitContainer.Panel2.Controls.Add(Me.codeTB)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer.Panel2.Controls.Add(Me.menuTS)
        Me.SplitContainer.Size = New System.Drawing.Size(732, 404)
        Me.SplitContainer.SplitterDistance = 236
        Me.SplitContainer.TabIndex = 0
        '
        'naviDGV
        '
        Me.naviDGV.AllowUserToAddRows = False
        Me.naviDGV.AllowUserToDeleteRows = False
        Me.naviDGV.AllowUserToResizeColumns = False
        Me.naviDGV.AllowUserToResizeRows = False
        Me.naviDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.naviDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeCol, Me.NameCol})
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
        Me.naviDGV.Size = New System.Drawing.Size(236, 404)
        Me.naviDGV.TabIndex = 3
        '
        'CodeCol
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CodeCol.DefaultCellStyle = DataGridViewCellStyle1
        Me.CodeCol.HeaderText = "Code"
        Me.CodeCol.MaxInputLength = 2
        Me.CodeCol.Name = "CodeCol"
        Me.CodeCol.ReadOnly = True
        Me.CodeCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CodeCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CodeCol.Width = 50
        '
        'NameCol
        '
        Me.NameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.NameCol.DefaultCellStyle = DataGridViewCellStyle2
        Me.NameCol.HeaderText = "Education"
        Me.NameCol.MaxInputLength = 30
        Me.NameCol.Name = "NameCol"
        Me.NameCol.ReadOnly = True
        Me.NameCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'nameTB
        '
        Me.nameTB.Location = New System.Drawing.Point(87, 100)
        Me.nameTB.MaxLength = 30
        Me.nameTB.Name = "nameTB"
        Me.nameTB.Size = New System.Drawing.Size(259, 23)
        Me.nameTB.TabIndex = 1
        Me.nameTB.WordWrap = False
        '
        'codeTB
        '
        Me.codeTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.codeTB.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.codeTB.Location = New System.Drawing.Point(87, 59)
        Me.codeTB.Mask = "00"
        Me.codeTB.Name = "codeTB"
        Me.codeTB.ResetOnSpace = False
        Me.codeTB.Size = New System.Drawing.Size(31, 23)
        Me.codeTB.TabIndex = 0
        Me.codeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.formTT.SetToolTip(Me.codeTB, "Only can use numeric two digits")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 103)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Code:"
        '
        'menuTS
        '
        Me.menuTS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newTSB, Me.deleteTSB, Me.ToolStripSeparator1, Me.firstTSB, Me.previousTSB, Me.nextTSB, Me.lastTSB, Me.ToolStripSeparator2, Me.refreshTSB, Me.ToolStripSeparator3, Me.closeTSB, Me.ToolStripSeparator4, Me.saveTSB})
        Me.menuTS.Location = New System.Drawing.Point(0, 0)
        Me.menuTS.Name = "menuTS"
        Me.menuTS.Padding = New System.Windows.Forms.Padding(0, 2, 1, 2)
        Me.menuTS.Size = New System.Drawing.Size(492, 27)
        Me.menuTS.TabIndex = 0
        Me.menuTS.Text = "ToolStrip"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 23)
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
        'closeTSB
        '
        Me.closeTSB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.closeTSB.Image = Global.Accounting.My.Resources.Resources.closeImg
        Me.closeTSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.closeTSB.Name = "closeTSB"
        Me.closeTSB.Size = New System.Drawing.Size(56, 20)
        Me.closeTSB.Text = "Close"
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
        'educationCodeFM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 404)
        Me.Controls.Add(Me.SplitContainer)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "educationCodeFM"
        Me.Text = "Managing Education Code"
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel2.ResumeLayout(False)
        Me.SplitContainer.Panel2.PerformLayout()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        CType(Me.naviDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuTS.ResumeLayout(False)
        Me.menuTS.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer As SplitContainer
    Friend WithEvents naviDGV As DataGridView
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
    Friend WithEvents nameTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents codeTB As MaskedTextBox
    Friend WithEvents formTT As ToolTip
    Friend WithEvents CodeCol As DataGridViewTextBoxColumn
    Friend WithEvents NameCol As DataGridViewTextBoxColumn
End Class
