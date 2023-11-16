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
End Class
