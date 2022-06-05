Public Class contactTracingForm
    Private Sub currentTimeTimer_Tick(sender As Object, e As EventArgs) Handles currentTimeTimer.Tick
        timerLabel.Text = DateTime.Now.ToLongTimeString()
    End Sub
End Class
