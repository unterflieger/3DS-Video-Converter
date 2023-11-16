Public Class MainScreen
    Private Sub LeftVideoSelect_CheckedChanged(sender As Object, e As EventArgs) Handles LeftVideoSelect.CheckedChanged
        RightVideoSelect.Checked = False
        BothVideoSelect.Checked = False
    End Sub
End Class
