Public Class contactTracingForm
    Private Sub currentTimeTimer_Tick(sender As Object, e As EventArgs) Handles currentTimeTimer.Tick
        timerLabel.Text = DateTime.Now.ToLongTimeString()
    End Sub
    Private Sub submitFormButton_Click(sender As Object, e As EventArgs) Handles submitFormButton.Click
        Dim writefile As System.IO.StreamWriter
        writefile = My.Computer.FileSystem.OpenTextFileWriter(txtbxFname.Text & " " & txtbxLastName.Text & " " & "Contact Tracing Form.txt", False)
        writefile.WriteLine("CONTACT TRACING FORM")
        writefile.WriteLine(" ")
        writefile.WriteLine(firstNameLabel.Text & " " & txtbxFname.Text)
        writefile.WriteLine(midNameLabel.Text & " " & txtbxMidName.Text)
        writefile.WriteLine(lastNameLabel.Text & " " & txtbxLastName.Text)
        writefile.WriteLine(ageLabel.Text & " " & txtboxAge.Text)
        If radioMale.Checked Then
            writefile.WriteLine(genderLabel.Text & " " & "Male")
        ElseIf radioFemale.Checked Then
            writefile.WriteLine(genderLabel.Text & " " & "Female")
        Else
            writefile.WriteLine(genderLabel.Text & " " & "Not Specified")
        End If
        writefile.WriteLine(contactLabel.Text & " " & txtbxContact.Text)
        writefile.WriteLine(addressLabel.Text & " " & txtbxAddress.Text)
        writefile.WriteLine(emailLabel.Text & " " & txtbxEmail.Text)
        writefile.WriteLine(dateLabel.Text & " " & currentDate.Text)
        writefile.WriteLine(currentTime.Text & " " & timerLabel.Text)
        writefile.WriteLine(locationLabel.Text & " " & txtbxLocation.Text)
        writefile.WriteLine(" ")

        writefile.Close()
    End Sub
End Class
