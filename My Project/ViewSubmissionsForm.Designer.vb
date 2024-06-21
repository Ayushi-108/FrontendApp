<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        LblName = New Label()
        LblEmail = New Label()
        LblPhone = New Label()
        LblGithub = New Label()
        LablStopwatch = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithub = New TextBox()
        txtStopwatch = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        btnDelete = New Button()
        btnEdit = New Button()
        btnSave = New Button()
        Label1 = New Label()
        btnSearch = New Button()
        txtSearchEmail = New TextBox()
        SuspendLayout()
        ' 
        ' LblName
        ' 
        LblName.AutoSize = True
        LblName.BackColor = Color.LightYellow
        LblName.BorderStyle = BorderStyle.FixedSingle
        LblName.Font = New Font("Times New Roman", 15F)
        LblName.Location = New Point(197, 131)
        LblName.Name = "LblName"
        LblName.Size = New Size(75, 31)
        LblName.TabIndex = 0
        LblName.Text = "Name"
        ' 
        ' LblEmail
        ' 
        LblEmail.AutoSize = True
        LblEmail.BackColor = Color.LightYellow
        LblEmail.BorderStyle = BorderStyle.FixedSingle
        LblEmail.Font = New Font("Times New Roman", 15F)
        LblEmail.Location = New Point(191, 181)
        LblEmail.Name = "LblEmail"
        LblEmail.Size = New Size(81, 31)
        LblEmail.TabIndex = 1
        LblEmail.Text = "E-mail"
        ' 
        ' LblPhone
        ' 
        LblPhone.AutoSize = True
        LblPhone.BackColor = Color.LightYellow
        LblPhone.BorderStyle = BorderStyle.FixedSingle
        LblPhone.Font = New Font("Times New Roman", 15F)
        LblPhone.Location = New Point(104, 238)
        LblPhone.Name = "LblPhone"
        LblPhone.Size = New Size(168, 31)
        LblPhone.TabIndex = 2
        LblPhone.Text = "Phone Number"
        ' 
        ' LblGithub
        ' 
        LblGithub.AutoSize = True
        LblGithub.BackColor = Color.LightYellow
        LblGithub.BorderStyle = BorderStyle.FixedSingle
        LblGithub.Font = New Font("Times New Roman", 15F)
        LblGithub.Location = New Point(26, 289)
        LblGithub.Name = "LblGithub"
        LblGithub.Size = New Size(246, 31)
        LblGithub.TabIndex = 3
        LblGithub.Text = "GitHub Link for Task 2"
        ' 
        ' LablStopwatch
        ' 
        LablStopwatch.AutoSize = True
        LablStopwatch.BackColor = Color.LightYellow
        LablStopwatch.BorderStyle = BorderStyle.FixedSingle
        LablStopwatch.Font = New Font("Times New Roman", 15F)
        LablStopwatch.Location = New Point(94, 340)
        LablStopwatch.Name = "LablStopwatch"
        LablStopwatch.Size = New Size(178, 31)
        LablStopwatch.TabIndex = 4
        LablStopwatch.Text = "Stopwatch Time"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(306, 131)
        txtName.Multiline = True
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(398, 31)
        txtName.TabIndex = 5
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(306, 181)
        txtEmail.Multiline = True
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(398, 31)
        txtEmail.TabIndex = 6
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(306, 238)
        txtPhone.Multiline = True
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(398, 31)
        txtPhone.TabIndex = 7
        ' 
        ' txtGithub
        ' 
        txtGithub.Location = New Point(306, 289)
        txtGithub.Multiline = True
        txtGithub.Name = "txtGithub"
        txtGithub.ReadOnly = True
        txtGithub.Size = New Size(398, 31)
        txtGithub.TabIndex = 8
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.Location = New Point(306, 340)
        txtStopwatch.Multiline = True
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.ReadOnly = True
        txtStopwatch.Size = New Size(398, 31)
        txtStopwatch.TabIndex = 9
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.LightYellow
        btnPrevious.BackgroundImageLayout = ImageLayout.None
        btnPrevious.CausesValidation = False
        btnPrevious.Font = New Font("Times New Roman", 11F)
        btnPrevious.Location = New Point(22, 393)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(125, 45)
        btnPrevious.TabIndex = 10
        btnPrevious.Text = "&Previous"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.LightYellow
        btnNext.Font = New Font("Times New Roman", 11F)
        btnNext.Location = New Point(184, 393)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(112, 45)
        btnNext.TabIndex = 11
        btnNext.Text = "&Next"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.LightYellow
        btnDelete.Font = New Font("Times New Roman", 11F)
        btnDelete.Location = New Point(328, 393)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(127, 45)
        btnDelete.TabIndex = 12
        btnDelete.Text = "&Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.LightYellow
        btnEdit.Font = New Font("Times New Roman", 11F)
        btnEdit.Location = New Point(491, 393)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(124, 45)
        btnEdit.TabIndex = 13
        btnEdit.Text = "&Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.LightYellow
        btnSave.Font = New Font("Times New Roman", 11F)
        btnSave.Location = New Point(645, 393)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(124, 45)
        btnSave.TabIndex = 14
        btnSave.Text = "&Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 18F)
        Label1.Location = New Point(104, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(588, 34)
        Label1.TabIndex = 15
        Label1.Text = "Ayushi Singh, Slidely Task 2 - Slidely Form App"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.LightYellow
        btnSearch.Font = New Font("Times New Roman", 11F)
        btnSearch.Location = New Point(621, 65)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(148, 34)
        btnSearch.TabIndex = 16
        btnSearch.Text = "&Find By Email"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtSearchEmail
        ' 
        txtSearchEmail.Location = New Point(329, 65)
        txtSearchEmail.Multiline = True
        txtSearchEmail.Name = "txtSearchEmail"
        txtSearchEmail.Size = New Size(286, 34)
        txtSearchEmail.TabIndex = 17
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightPink
        ClientSize = New Size(800, 450)
        Controls.Add(txtSearchEmail)
        Controls.Add(btnSearch)
        Controls.Add(Label1)
        Controls.Add(btnSave)
        Controls.Add(btnEdit)
        Controls.Add(btnDelete)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtStopwatch)
        Controls.Add(txtGithub)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(LablStopwatch)
        Controls.Add(LblGithub)
        Controls.Add(LblPhone)
        Controls.Add(LblEmail)
        Controls.Add(LblName)
        Name = "ViewSubmissionsForm"
        Text = "Slidely_AI_Task"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblName As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblPhone As Label
    Friend WithEvents LblGithub As Label
    Friend WithEvents LablStopwatch As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearchEmail As TextBox
End Class
