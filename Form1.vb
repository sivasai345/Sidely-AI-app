Public Class Form1
    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        Dim createSubmissionForm As New CreateSubmissionForm()
        createSubmissionForm.Show()
    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewSubmissionsForm As New viewSubmissionsForm()
        viewSubmissionsForm.Show()
    End Sub
End Class
