Public Class MainScreen
    Public VideoTrackType As String
    Private Sub LeftVideoSelect_CheckedChanged(sender As Object, e As EventArgs) Handles LeftVideoSelect.CheckedChanged
        VideoTrackType = "Left"
    End Sub

    Private Sub RightVideoSelect_CheckedChanged(sender As Object, e As EventArgs) Handles RightVideoSelect.CheckedChanged
        VideoTrackType = "Right"
    End Sub

    Private Sub BothVideoSelect_CheckedChanged(sender As Object, e As EventArgs) Handles BothVideoSelect.CheckedChanged
        VideoTrackType = "Both"
    End Sub

    Private Sub FileSearchButton_Click(sender As Object, e As EventArgs) Handles FileSearchButton.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            SourceTextBox.Text = OpenFileDialog1.FileName
        Else
            MsgBox("Beim Auswählen der Datei ist etwas schiefgelaufen. Versuch es erneut oder suche an einem anderen Speicherort.")
        End If
    End Sub

    Private Sub ResultSearchButton_Click(sender As Object, e As EventArgs) Handles ResultSearchButton.Click
        Dim result As DialogResult = SaveFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            ResultTextBox.Text = SaveFileDialog1.FileName
        Else
            MsgBox("Beim Auswählen der Datei ist etwas schiefgelaufen. Versuch es erneut oder wähle einen anderen Speicherort.")
        End If
    End Sub

    Private Sub GithubLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GithubLink.LinkClicked
        Process.Start("CMD", "/C start https://github.com/unterflieger")
    End Sub

    Private Sub ConvertButton_Click(sender As Object, e As EventArgs) Handles ConvertButton.Click
        Dim command As String

        If VideoTrackType Is "Left" Then
            command = "/K ""%cd%""\ffmpeg-master-latest-win64-gpl\bin\ffmpeg.exe -i """ & SourceTextBox.Text & """ -map 0:0 -map 0:1 -vcodec copy -acodec copy ""left" & ResultTextBox.Text & """"
        End If
        If VideoTrackType Is "Right" Then
            command = "/K ""%cd%""\ffmpeg-master-latest-win64-gpl\bin\ffmpeg.exe -i """ & SourceTextBox.Text & """ -map 0:2 -vcodec copy -acodec copy -an ""right" & SourceTextBox.Text & """"
        End If
        Process.Start("CMD", command)
    End Sub
End Class
