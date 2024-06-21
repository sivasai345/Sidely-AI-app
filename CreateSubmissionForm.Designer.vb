<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.btnStopWatch = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPhoneNum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGithubLink = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTime)
        Me.GroupBox1.Controls.Add(Me.btnStopWatch)
        Me.GroupBox1.Controls.Add(Me.btnSubmit)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPhoneNum)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtGithubLink)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(74, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 357)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Create"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(295, 239)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(112, 22)
        Me.txtTime.TabIndex = 10
        '
        'btnStopWatch
        '
        Me.btnStopWatch.Location = New System.Drawing.Point(65, 238)
        Me.btnStopWatch.Name = "btnStopWatch"
        Me.btnStopWatch.Size = New System.Drawing.Size(185, 38)
        Me.btnStopWatch.TabIndex = 9
        Me.btnStopWatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Me.btnStopWatch.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(173, 307)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(178, 31)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(173, 95)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(234, 22)
        Me.txtEmail.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Github Link"
        '
        'txtPhoneNum
        '
        Me.txtPhoneNum.Location = New System.Drawing.Point(173, 134)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.Size = New System.Drawing.Size(234, 22)
        Me.txtPhoneNum.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Phone Num"
        '
        'txtGithubLink
        '
        Me.txtGithubLink.Location = New System.Drawing.Point(173, 180)
        Me.txtGithubLink.Name = "txtGithubLink"
        Me.txtGithubLink.Size = New System.Drawing.Size(234, 22)
        Me.txtGithubLink.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Email"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(173, 53)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(234, 22)
        Me.txtName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Timer1
        '
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 490)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "CreateSubmissionForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnStopWatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtTime As TextBox
    Friend WithEvents Timer1 As Timer
End Class
