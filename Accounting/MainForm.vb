Public Class MainForm

    Private Sub mnuDutyCode_Click(sender As Object, e As EventArgs) Handles mnuDutyCode.Click
        Dim frmCollection As FormCollection = System.Windows.Forms.Application.OpenForms

        If frmCollection.OfType(Of DutyCodeForm).Any Then
            frmCollection.Item("DutyCodeForm").Activate()
        Else
            Dim iForm = New DutyCodeForm()
            iForm.MdiParent = Me
            iForm.Show()
        End If
    End Sub

    Private Sub mnuEducationCode_Click(sender As Object, e As EventArgs) Handles mnuEducationCode.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms

        If frmCollection.OfType(Of EducationCodeForm).Any Then
            frmCollection.Item("EducationCodeForm").Activate()
        Else
            Dim iForm = New EducationCodeForm()
            iForm.MdiParent = Me
            iForm.Show()
        End If
    End Sub

    Private Sub mnuMember_Click(sender As Object, e As EventArgs) Handles mnuMember.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms

        If frmCollection.OfType(Of MemberForm).Any Then
            frmCollection.Item("MemberForm").Activate()
        Else
            Dim iForm = New MemberForm()
            iForm.MdiParent = Me
            iForm.Show()
        End If
    End Sub

    Private Sub mnuAssignDedicatorCode_Click(sender As Object, e As EventArgs) Handles mnuAssignDedicatorCode.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms

        If frmCollection.OfType(Of DedicatorForm).Any Then
            frmCollection.Item("DedicatorForm").Activate()
        Else
            Dim iForm = New DedicatorForm()
            iForm.MdiParent = Me
            iForm.Show()
        End If
    End Sub

    Private Sub mnuDuplicateDedicatorCode_Click(sender As Object, e As EventArgs) Handles mnuDuplicateDedicatorCode.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms

        If frmCollection.OfType(Of CopyDedicatorForm).Any Then
            frmCollection.Item("CopyDedicatorForm").Activate()
        Else
            Dim iForm = New CopyDedicatorForm()
            iForm.MdiParent = Me
            iForm.Show()
        End If
    End Sub

    Private Sub mnuAccountCode_Click(sender As Object, e As EventArgs) Handles mnuAccountCode.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms

        If frmCollection.OfType(Of AccountForm).Any Then
            frmCollection.Item("AccountForm").Activate()
        Else
            Dim iForm = New AccountForm()
            iForm.MdiParent = Me
            iForm.Show()
        End If
    End Sub

    Private Sub mnuDuplicateAccountCode_Click(sender As Object, e As EventArgs) Handles mnuDuplicateAccountCode.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms

        If frmCollection.OfType(Of CopyAccountCodeForm).Any Then
            frmCollection.Item("CopyAccountCodeForm").Activate()
        Else
            Dim iForm = New CopyAccountCodeForm()
            iForm.MdiParent = Me
            iForm.Show()
        End If
    End Sub

    Private Sub mnuBookCode_Click(sender As Object, e As EventArgs) Handles mnuBookCode.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms

        If frmCollection.OfType(Of BookCodeForm).Any Then
            frmCollection.Item("BookCodeForm").Activate()
        Else
            Dim iForm = New BookCodeForm()
            iForm.MdiParent = Me
            iForm.Show()
        End If
    End Sub

    Private Sub mnuAssignAccountCodeToABook_Click(sender As Object, e As EventArgs) Handles mnuAssignAccountCodeToABook.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms

        If frmCollection.OfType(Of ComposeBookForm).Any Then
            frmCollection.Item("ComposeBookForm").Activate()
        Else
            Dim iForm = New ComposeBookForm()
            iForm.MdiParent = Me
            iForm.Show()
        End If
    End Sub

    Private Sub mnuBudgetEntry_Click(sender As Object, e As EventArgs) Handles mnuBudgetEntry.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms

        If frmCollection.OfType(Of BudgetEntryForm).Any Then
            frmCollection.Item("BudgetEntryForm").Activate()
        Else
            Dim iForm = New BudgetEntryForm()
            iForm.MdiParent = Me
            iForm.Show()
        End If
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' Close all Forms
        Try
            For Each frmClose As Form In My.Application.OpenForms
                frmClose.Close()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub mnuOfferings_Click(sender As Object, e As EventArgs) Handles mnuOfferings.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms

        If frmCollection.OfType(Of IncomeForm).Any Then
            frmCollection.Item("IncomeForm").Activate()
        Else
            Dim iForm = New IncomeForm()
            iForm.MdiParent = Me
            iForm.Show()
        End If
    End Sub

    Private Sub mnuExpenses_Click(sender As Object, e As EventArgs) Handles mnuExpenses.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms

        If frmCollection.OfType(Of ExpenseForm).Any Then
            frmCollection.Item("ExpenseForm").Activate()
        Else
            Dim iForm = New ExpenseForm()
            iForm.MdiParent = Me
            iForm.Show()
        End If
    End Sub
End Class
