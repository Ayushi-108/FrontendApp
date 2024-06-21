<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        LblName = New Label()
        LblEmail = New Label()
        LblPhone = New Label()
        LblGithubLink = New Label()
        TxtName = New TextBox()
        TxtEmail = New TextBox()
        TxtPhone = New TextBox()
        TxtGithubLink = New TextBox()
        BtnToggleStopwatch = New Button()
        LblStopwatch = New Label()
        BtnSubmit = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' LblName
        ' 
        LblName.AutoSize = True
        LblName.BackColor = Color.LightYellow
        LblName.BorderStyle = BorderStyle.FixedSingle
        LblName.Font = New Font("Times New Roman", 14.0F)
        LblName.Location = New Point(202, 88)
        LblName.Name = "LblName"
        LblName.Size = New Size(71, 29)
        LblName.TabIndex = 0
        LblName.Text = "Name"
        ' 
        ' LblEmail
        ' 
        LblEmail.AutoSize = True
        LblEmail.BackColor = Color.LightYellow
        LblEmail.BorderStyle = BorderStyle.FixedSingle
        LblEmail.Font = New Font("Times New Roman", 14.0F)
        LblEmail.Location = New Point(195, 135)
        LblEmail.Name = "LblEmail"
        LblEmail.Size = New Size(78, 29)
        LblEmail.TabIndex = 1
        LblEmail.Text = "E-mail"
        ' 
        ' LblPhone
        ' 
        LblPhone.AutoSize = True
        LblPhone.BackColor = Color.LightYellow
        LblPhone.BorderStyle = BorderStyle.FixedSingle
        LblPhone.Font = New Font("Times New Roman", 14.0F)
        LblPhone.Location = New Point(114, 185)
        LblPhone.Name = "LblPhone"
        LblPhone.Size = New Size(159, 29)
        LblPhone.TabIndex = 2
        LblPhone.Text = "Phone Number"
        ' 
        ' LblGithubLink
        ' 
        LblGithubLink.AutoSize = True
        LblGithubLink.BackColor = Color.LightYellow
        LblGithubLink.BorderStyle = BorderStyle.FixedSingle
        LblGithubLink.Font = New Font("Times New Roman", 14.0F)
        LblGithubLink.Location = New Point(35, 234)
        LblGithubLink.Name = "LblGithubLink"
        LblGithubLink.Size = New Size(238, 29)
        LblGithubLink.TabIndex = 3
        LblGithubLink.Text = "GitHub Link for Task 2"
        ' 
        ' TxtName
        ' 
        TxtName.Location = New Point(334, 88)
        TxtName.Multiline = True
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(389, 29)
        TxtName.TabIndex = 4
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(334, 135)
        TxtEmail.Multiline = True
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(389, 29)
        TxtEmail.TabIndex = 5
        ' 
        ' TxtPhone
        ' 
        TxtPhone.Location = New Point(334, 185)
        TxtPhone.Multiline = True
        TxtPhone.Name = "TxtPhone"
        TxtPhone.Size = New Size(389, 29)
        TxtPhone.TabIndex = 6
        ' 
        ' TxtGithubLink
        ' 
        TxtGithubLink.Location = New Point(334, 234)
        TxtGithubLink.Multiline = True
        TxtGithubLink.Name = "TxtGithubLink"
        TxtGithubLink.Size = New Size(389, 29)
        TxtGithubLink.TabIndex = 7
        ' 
        ' BtnToggleStopwatch
        ' 
        BtnToggleStopwatch.BackColor = Color.LightYellow
        BtnToggleStopwatch.Font = New Font("Times New Roman", 11.0F)
        BtnToggleStopwatch.Location = New Point(26, 309)
        BtnToggleStopwatch.Name = "BtnToggleStopwatch"
        BtnToggleStopwatch.Size = New Size(293, 39)
        BtnToggleStopwatch.TabIndex = 8
        BtnToggleStopwatch.Text = "&Toggle Stopwatch"
        BtnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' LblStopwatch
        ' 
        LblStopwatch.AutoSize = True
        LblStopwatch.Font = New Font("Times New Roman", 20.0F)
        LblStopwatch.Location = New Point(472, 305)
        LblStopwatch.Name = "LblStopwatch"
        LblStopwatch.Size = New Size(137, 39)
        LblStopwatch.TabIndex = 9
        LblStopwatch.Text = "00:00:00"
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.BackColor = Color.LightYellow
        BtnSubmit.Font = New Font("Times New Roman", 11.0F)
        BtnSubmit.Location = New Point(275, 382)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(223, 39)
        BtnSubmit.TabIndex = 11
        BtnSubmit.Text = "&Submit"
        BtnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 18.0F)
        Label1.Location = New Point(135, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(588, 34)
        Label1.TabIndex = 12
        Label1.Text = "Ayushi Singh, Slidely Task 2 - Slidely Form App"
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightPink
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(BtnSubmit)
        Controls.Add(LblStopwatch)
        Controls.Add(BtnToggleStopwatch)
        Controls.Add(TxtGithubLink)
        Controls.Add(TxtPhone)
        Controls.Add(TxtEmail)
        Controls.Add(TxtName)
        Controls.Add(LblGithubLink)
        Controls.Add(LblPhone)
        Controls.Add(LblEmail)
        Controls.Add(LblName)
        Name = "CreateSubmissionForm"
        Text = "Slidely_AI_Task"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblName As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblPhone As Label
    Friend WithEvents LblGithubLink As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents TxtGithubLink As TextBox
    Friend WithEvents BtnToggleStopwatch As Button
    Friend WithEvents LblStopwatch As Label
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents Label1 As Label
End Class
