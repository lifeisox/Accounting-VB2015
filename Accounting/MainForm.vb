Public Class MainForm

    Private Sub exitTSMI_Click(sender As Object, e As EventArgs) Handles exitTSMI.Click
        ' Close all Forms
        Try
            For Each frmClose As Form In My.Application.OpenForms
                frmClose.Close()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dutyCodeTSMI_Click(sender As Object, e As EventArgs) Handles dutyCodeTSMI.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms

        If frmCollection.OfType(Of DutyCodeForm).Any Then
            frmCollection.Item("DutyCodeForm").Activate()
        Else
            Dim dutyCodeForm = New DutyCodeForm()
            dutyCodeForm.MdiParent = Me
            dutyCodeForm.Show()
        End If
    End Sub

    Private Sub educationCodeTSMI_Click(sender As Object, e As EventArgs) Handles educationCodeTSMI.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms

        If frmCollection.OfType(Of EducationCodeForm).Any Then
            frmCollection.Item("EducationCodeForm").Activate()
        Else
            Dim educationCodeForm = New EducationCodeForm()
            educationCodeForm.MdiParent = Me
            educationCodeForm.Show()
        End If
    End Sub

    Private Sub memberTSMI_Click(sender As Object, e As EventArgs) Handles memberTSMI.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms

        If frmCollection.OfType(Of MemberForm).Any Then
            frmCollection.Item("MemberForm").Activate()
        Else
            Dim memberForm = New MemberForm()
            memberForm.MdiParent = Me
            memberForm.Show()
        End If
    End Sub

    Private Sub assignDedicatorCodeTSMI_Click(sender As Object, e As EventArgs) Handles assignDedicatorCodeTSMI.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms

        If frmCollection.OfType(Of DedicatorForm).Any Then
            frmCollection.Item("DedicatorForm").Activate()
        Else
            Dim dedicatorForm = New DedicatorForm()
            dedicatorForm.MdiParent = Me
            dedicatorForm.Show()
        End If
    End Sub

    Private Sub duplicateDedicatorCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles duplicateDedicatorCodeToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms

        If frmCollection.OfType(Of CopyDedicatorForm).Any Then
            frmCollection.Item("CopyDedicatorForm").Activate()
        Else
            Dim dedicatorForm = New CopyDedicatorForm()
            dedicatorForm.MdiParent = Me
            dedicatorForm.Show()
        End If
    End Sub
End Class
