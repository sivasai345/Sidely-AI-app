Imports Newtonsoft.Json
Imports System.IO
Public Class viewSubmissionsForm


    Dim currentIndex As Integer
    Dim lstRecords As New List(Of Registration)
    Dim records As New List(Of Registration)
    Private Sub viewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filePath As String = "E:\OutputFile\db.Json"
        Dim jsonData As String = File.ReadAllText(filePath)

        records = JsonConvert.DeserializeObject(Of List(Of Registration))(jsonData)
        currentIndex = 0
        DisplayRecord(currentIndex)
    End Sub

    Private Sub DisplayRecord(index As Integer)
        ' Display the record at the given index in the ListBox
        If index >= 0 AndAlso index < records.Count Then

            Dim record As Registration = records(index)
            txtName.Text = record.Name
            txtEmail.Text = record.Email

            txtPhoneNum.Text = record.PhoneNum
            txtGithubLink.Text = record.GitHub
            txtTime.Text = record.Timer

        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplayRecord(currentIndex)
        Else
            MessageBox.Show("This is the first record.")
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < records.Count - 1 Then
            currentIndex += 1
            DisplayRecord(currentIndex)
        Else
            MessageBox.Show("No more records to display.")
        End If
    End Sub
End Class