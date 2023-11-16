Imports System.Formats

Public Class FFmpegdownload
    Private Sub FFmpegmanualdownload_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ffmpegmanualdownload.LinkClicked
        'Dim webAddress As String = "https://www.ffmpeg.org/"
        Process.Start("CMD", "/C start https://www.ffmpeg.org/")
        Me.Hide()
    End Sub

    Private Sub DownloadYesButton_Click(sender As Object, e As EventArgs) Handles DownloadYesButton.Click
        Process.Start("CMD", "/C start downloadunpack.bat")
        'Dim cmddownload As Process = Process.Start("CMD", "/C start curl -L --remote-name --url https://github.com/BtbN/FFmpeg-Builds/releases/download/latest/ffmpeg-master-latest-win64-gpl.zip")
        'cmddownload.WaitForExit()
        'Dim cmdunpack As Process = Process.Start("CMD", "/C start tar -x -f ffmpeg-master-latest-win64-gpl.zip")
        'cmdunpack.WaitForExit()
        Me.Hide()
    End Sub

    Private Sub DownloadNoButton_Click(sender As Object, e As EventArgs) Handles DownloadNoButton.Click
        MainScreen.Show()
        Me.Hide()

    End Sub
End Class