<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.menuMS = New System.Windows.Forms.MenuStrip()
        Me.basicTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.dutyCodeTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.educationCodeTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.memberTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.assignDedicatorCodeTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.accountCodeTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.booksTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.budgetEntryTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.exitTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.dailyWorksTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.offeringsTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.expensesTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.bankDepositReportTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.reportsTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.memberListTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.duplicateDedicatorCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.duplicateAccountCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuMS.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuMS
        '
        Me.menuMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.basicTSMI, Me.dailyWorksTSMI, Me.reportsTSMI})
        Me.menuMS.Location = New System.Drawing.Point(0, 0)
        Me.menuMS.Name = "menuMS"
        Me.menuMS.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.menuMS.Size = New System.Drawing.Size(915, 25)
        Me.menuMS.TabIndex = 1
        Me.menuMS.Text = "MenuStrip1"
        '
        'basicTSMI
        '
        Me.basicTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dutyCodeTSMI, Me.educationCodeTSMI, Me.ToolStripMenuItem1, Me.memberTSMI, Me.assignDedicatorCodeTSMI, Me.duplicateDedicatorCodeToolStripMenuItem, Me.ToolStripMenuItem2, Me.accountCodeTSMI, Me.duplicateAccountCodeToolStripMenuItem, Me.ToolStripMenuItem3, Me.booksTSMI, Me.budgetEntryTSMI, Me.ToolStripMenuItem5, Me.exitTSMI})
        Me.basicTSMI.Name = "basicTSMI"
        Me.basicTSMI.Size = New System.Drawing.Size(46, 19)
        Me.basicTSMI.Text = "Basic"
        '
        'dutyCodeTSMI
        '
        Me.dutyCodeTSMI.Name = "dutyCodeTSMI"
        Me.dutyCodeTSMI.Size = New System.Drawing.Size(209, 22)
        Me.dutyCodeTSMI.Text = "Duty Code"
        '
        'educationCodeTSMI
        '
        Me.educationCodeTSMI.Name = "educationCodeTSMI"
        Me.educationCodeTSMI.Size = New System.Drawing.Size(209, 22)
        Me.educationCodeTSMI.Text = "Education Code"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(206, 6)
        '
        'memberTSMI
        '
        Me.memberTSMI.Name = "memberTSMI"
        Me.memberTSMI.Size = New System.Drawing.Size(209, 22)
        Me.memberTSMI.Text = "Member Code"
        '
        'assignDedicatorCodeTSMI
        '
        Me.assignDedicatorCodeTSMI.Name = "assignDedicatorCodeTSMI"
        Me.assignDedicatorCodeTSMI.Size = New System.Drawing.Size(209, 22)
        Me.assignDedicatorCodeTSMI.Text = "Assign Dedicator Code"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(206, 6)
        '
        'accountCodeTSMI
        '
        Me.accountCodeTSMI.Name = "accountCodeTSMI"
        Me.accountCodeTSMI.Size = New System.Drawing.Size(209, 22)
        Me.accountCodeTSMI.Text = "Account Code"
        '
        'booksTSMI
        '
        Me.booksTSMI.Name = "booksTSMI"
        Me.booksTSMI.Size = New System.Drawing.Size(209, 22)
        Me.booksTSMI.Text = "Books"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(206, 6)
        '
        'budgetEntryTSMI
        '
        Me.budgetEntryTSMI.Name = "budgetEntryTSMI"
        Me.budgetEntryTSMI.Size = New System.Drawing.Size(209, 22)
        Me.budgetEntryTSMI.Text = "Budget Entry"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(206, 6)
        '
        'exitTSMI
        '
        Me.exitTSMI.Image = CType(resources.GetObject("exitTSMI.Image"), System.Drawing.Image)
        Me.exitTSMI.Name = "exitTSMI"
        Me.exitTSMI.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.exitTSMI.Size = New System.Drawing.Size(209, 22)
        Me.exitTSMI.Text = "Exit"
        '
        'dailyWorksTSMI
        '
        Me.dailyWorksTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.offeringsTSMI, Me.expensesTSMI, Me.ToolStripMenuItem4, Me.bankDepositReportTSMI})
        Me.dailyWorksTSMI.Name = "dailyWorksTSMI"
        Me.dailyWorksTSMI.Size = New System.Drawing.Size(81, 19)
        Me.dailyWorksTSMI.Text = "Daily Works"
        '
        'offeringsTSMI
        '
        Me.offeringsTSMI.Name = "offeringsTSMI"
        Me.offeringsTSMI.Size = New System.Drawing.Size(181, 22)
        Me.offeringsTSMI.Text = "Offerings"
        '
        'expensesTSMI
        '
        Me.expensesTSMI.Name = "expensesTSMI"
        Me.expensesTSMI.Size = New System.Drawing.Size(181, 22)
        Me.expensesTSMI.Text = "Expenses"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(178, 6)
        '
        'bankDepositReportTSMI
        '
        Me.bankDepositReportTSMI.Name = "bankDepositReportTSMI"
        Me.bankDepositReportTSMI.Size = New System.Drawing.Size(181, 22)
        Me.bankDepositReportTSMI.Text = "Bank Deposit Report"
        '
        'reportsTSMI
        '
        Me.reportsTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.memberListTSMI})
        Me.reportsTSMI.Name = "reportsTSMI"
        Me.reportsTSMI.Size = New System.Drawing.Size(59, 19)
        Me.reportsTSMI.Text = "Reports"
        '
        'memberListTSMI
        '
        Me.memberListTSMI.Name = "memberListTSMI"
        Me.memberListTSMI.Size = New System.Drawing.Size(140, 22)
        Me.memberListTSMI.Text = "Member List"
        '
        'duplicateDedicatorCodeToolStripMenuItem
        '
        Me.duplicateDedicatorCodeToolStripMenuItem.Name = "duplicateDedicatorCodeToolStripMenuItem"
        Me.duplicateDedicatorCodeToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.duplicateDedicatorCodeToolStripMenuItem.Text = "Duplicate Dedicator Code"
        '
        'duplicateAccountCodeToolStripMenuItem
        '
        Me.duplicateAccountCodeToolStripMenuItem.Name = "duplicateAccountCodeToolStripMenuItem"
        Me.duplicateAccountCodeToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.duplicateAccountCodeToolStripMenuItem.Text = "Duplicate Account Code"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 648)
        Me.Controls.Add(Me.menuMS)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuMS
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.Text = "Ottawa Korean Community Church"
        Me.menuMS.ResumeLayout(False)
        Me.menuMS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuMS As MenuStrip
    Friend WithEvents basicTSMI As ToolStripMenuItem
    Friend WithEvents dutyCodeTSMI As ToolStripMenuItem
    Friend WithEvents educationCodeTSMI As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents memberTSMI As ToolStripMenuItem
    Friend WithEvents assignDedicatorCodeTSMI As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents accountCodeTSMI As ToolStripMenuItem
    Friend WithEvents booksTSMI As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents budgetEntryTSMI As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripSeparator
    Friend WithEvents exitTSMI As ToolStripMenuItem
    Friend WithEvents dailyWorksTSMI As ToolStripMenuItem
    Friend WithEvents offeringsTSMI As ToolStripMenuItem
    Friend WithEvents expensesTSMI As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents bankDepositReportTSMI As ToolStripMenuItem
    Friend WithEvents reportsTSMI As ToolStripMenuItem
    Friend WithEvents memberListTSMI As ToolStripMenuItem
    Friend WithEvents duplicateDedicatorCodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents duplicateAccountCodeToolStripMenuItem As ToolStripMenuItem
End Class
