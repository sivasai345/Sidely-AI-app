<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewSubmissionsForm
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
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
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
        Me.GroupBox1.Controls.Add(Me.btnNext)
        Me.GroupBox1.Controls.Add(Me.btnPrevious)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTime)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPhoneNum)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtGithubLink)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(103, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 357)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "View"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(290, 286)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 13
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(70, 286)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 12
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "StopWatch"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(173, 239)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(234, 22)
        Me.txtTime.TabIndex = 10
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(173, 95)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
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
        Me.txtPhoneNum.ReadOnly = True
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
        Me.txtGithubLink.ReadOnly = True
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
        Me.txtName.ReadOnly = True
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
        'viewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "viewSubmissionsForm"
        Me.Text = "ViewSubmissionsForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTime As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
End Class
