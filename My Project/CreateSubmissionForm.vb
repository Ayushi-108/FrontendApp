Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports System.Diagnostics

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Private WithEvents timer As New Timer()

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.KeyPreview = True ' Enable key preview to capture key events at the form level

        ' Initialize the timer
        timer.Interval = 1000 ' 1 second interval
    End Sub

    Private Sub BtnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles BtnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            timer.Stop()
        Else
            stopwatch.Start()
            timer.Start()
        End If
        UpdateStopwatchLabel()
    End Sub

    Private Sub UpdateStopwatchLabel()
        LblStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        UpdateStopwatchLabel()
    End Sub

    Private Async Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Await SubmitForm()
    End Sub

    Private Async Function SubmitForm() As Task
        Dim name As String = TxtName.Text
        Dim email As String = TxtEmail.Text
        Dim phone As String = TxtPhone.Text
        Dim githubLink As String = TxtGithubLink.Text
        Dim stopwatchTime As String = stopwatch.Elapsed.ToString("hh\:mm\:ss")

        If String.IsNullOrEmpty(name) OrElse String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(phone) OrElse String.IsNullOrEmpty(githubLink) Then
            MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using client As New HttpClient()
            Dim content As New StringContent($"{{""name"":""{name}"",""email"":""{email}"",""phone"":""{phone}"",""github_link"":""{githubLink}"",""stopwatch_time"":""{stopwatchTime}""}}", Encoding.UTF8, "application/json")
            Dim response = Await client.PostAsync("http://localhost:3000/submit", content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                Dim errorMsg As String = Await response.Content.ReadAsStringAsync()
                MessageBox.Show($"Failed to save submission: {errorMsg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
    End Function

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.T
                    BtnToggleStopwatch_Click(sender, e)
                Case Keys.S
                    BtnSubmit_Click(sender, e)
            End Select
        End If
    End Sub
End Class
