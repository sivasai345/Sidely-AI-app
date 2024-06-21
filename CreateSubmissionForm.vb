Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class CreateSubmissionForm

    Private timeelapsed As Integer
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim filePath As String = "E:\OutputFile\db.Json"
        Dim userList As New List(Of Registration)

        If File.Exists(filePath) Then
            Dim existingJson As String = File.ReadAllText(filePath)
            userList = JsonConvert.DeserializeObject(Of List(Of Registration))(existingJson)
        End If

        Dim Registration As New Registration()
        Registration.Name = txtName.Text
        Registration.Email = txtEmail.Text
        Registration.PhoneNum = txtPhoneNum.Text
        Registration.GitHub = txtGithubLink.Text
        Registration.Timer = txtTime.Text



        userList.Add(Registration)

        ' Read existing JSON data from the file


        Dim updatedJson As String = JsonConvert.SerializeObject(userList)

        File.WriteAllText(filePath, updatedJson)
        MessageBox.Show("Registration Data Saved Successfully!")


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeElapsed += 1
        txtTime.Text = timeElapsed
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnStopWatch_Click(sender As Object, e As EventArgs) Handles btnStopWatch.Click
        If String.IsNullOrEmpty(txtTime.Text) Then
            Timer1.Enabled = True
            Timer1.Start()
            btnStopWatch.Text = "Timer Stop"
        Else
            Timer1.Stop()
            btnStopWatch.Text = "Timer start"
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Enabled = False

    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()

            e.Handled = True ' Prevent system beep on Ctrl+S
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            btnStopWatch.PerformClick()

        End If
    End Sub

    Private Sub txtPhoneNum_ReadOnlyChanged(sender As Object, e As EventArgs) Handles txtPhoneNum.ReadOnlyChanged

    End Sub
End Class