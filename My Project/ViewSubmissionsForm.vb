Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json.Linq

Public Class ViewSubmissionsForm
    Private index As Integer = 0

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.KeyPreview = True ' Enable key preview to capture key events at the form level
    End Sub

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmission()
    End Sub

    Private Async Function LoadSubmission() As Task
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={index}")
            If response.IsSuccessStatusCode Then
                Dim submission As String = Await response.Content.ReadAsStringAsync()
                Dim json = JObject.Parse(submission)
                PopulateFields(json)
            Else
                MessageBox.Show("End of forms.")
            End If
        End Using
    End Function

    Private Sub PopulateFields(json As JObject)
        txtName.Text = json("name").ToString()
        txtEmail.Text = json("email").ToString()
        txtPhone.Text = json("phone").ToString()
        txtGithub.Text = json("github_link").ToString()
        txtStopwatch.Text = json("stopwatch_time").ToString()

        txtName.ReadOnly = True
        txtEmail.ReadOnly = True
        txtPhone.ReadOnly = True
        txtGithub.ReadOnly = True
        txtStopwatch.ReadOnly = True
        btnSave.Visible = False
        btnEdit.Visible = True
    End Sub

    Private Async Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If index > 0 Then
            index -= 1
            Await LoadSubmission()
        End If
    End Sub

    Private Async Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        index += 1
        Await LoadSubmission()
    End Sub

    Private Async Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this submission?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.DeleteAsync($"http://localhost:3000/delete/{index}")
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If index > 0 Then
                        index -= 1
                    End If
                    Await LoadSubmission()
                Else
                    Dim errorMsg As String = Await response.Content.ReadAsStringAsync()
                    MessageBox.Show($"Failed to delete submission: {errorMsg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ToggleEditMode(True)
    End Sub

    Private Async Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Await SaveSubmission()
    End Sub

    Private Sub ToggleEditMode(enable As Boolean)
        txtName.ReadOnly = Not enable
        txtEmail.ReadOnly = Not enable
        txtPhone.ReadOnly = Not enable
        txtGithub.ReadOnly = Not enable
        txtStopwatch.ReadOnly = Not enable
        btnSave.Visible = enable
        btnEdit.Visible = Not enable
    End Sub

    Private Async Function SaveSubmission() As Task
        Using client As New HttpClient()
            Dim name As String = txtName.Text
            Dim email As String = txtEmail.Text
            Dim phone As String = txtPhone.Text
            Dim githubLink As String = txtGithub.Text
            Dim stopwatchTime As String = txtStopwatch.Text

            If String.IsNullOrEmpty(name) OrElse String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(phone) OrElse String.IsNullOrEmpty(githubLink) Then
                MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim content As New StringContent($"{{""name"":""{name}"",""email"":""{email}"",""phone"":""{phone}"",""github_link"":""{githubLink}"",""stopwatch_time"":""{stopwatchTime}""}}", Encoding.UTF8, "application/json")
            Dim response = Await client.PutAsync($"http://localhost:3000/update/{index}", content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ToggleEditMode(False)
            Else
                Dim errorMsg As String = Await response.Content.ReadAsStringAsync()
                MessageBox.Show($"Failed to update submission: {errorMsg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
    End Function

    Private Async Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Await SearchByEmail()
    End Sub

    Private Async Function SearchByEmail() As Task
        Dim email As String = txtSearchEmail.Text.Trim()
        If String.IsNullOrEmpty(email) Then
            MessageBox.Show("Please enter an email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/search?email={email}")
            If response.IsSuccessStatusCode Then
                Dim submission As String = Await response.Content.ReadAsStringAsync()
                Dim json = JObject.Parse(submission)
                PopulateFields(json)
            Else
                Dim errorMsg As String = Await response.Content.ReadAsStringAsync()
                MessageBox.Show($"Failed to find submission: {errorMsg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
    End Function

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.P
                    BtnPrevious_Click(sender, e)
                Case Keys.N
                    BtnNext_Click(sender, e)
                Case Keys.D
                    BtnDelete_Click(sender, e)
                Case Keys.E
                    BtnEdit_Click(sender, e)
                Case Keys.S
                    BtnSave_Click(sender, e)
                Case Keys.F
                    BtnSearch_Click(sender, e)
            End Select
        End If
    End Sub
End Class
