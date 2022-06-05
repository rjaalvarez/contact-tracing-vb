Public Class contactTracingForm
    Private Sub currentTimeTimer_Tick(sender As Object, e As EventArgs) Handles currentTimeTimer.Tick
        timerLabel.Text = DateTime.Now.ToLongTimeString()
    End Sub
    Private Sub submitFormButton_Click(sender As Object, e As EventArgs) Handles submitFormButton.Click
        Dim writefile As System.IO.StreamWriter
        writefile = My.Computer.FileSystem.OpenTextFileWriter(txtbxFname.Text & " " & txtbxLastName.Text & " " & "Contact Tracing Form.txt", False)
        writefile.WriteLine("CONTACT TRACING FORM")

        writefile.Close()
    End Sub
End Class
