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
        writefile.WriteLine(checkListLabel.Text)
        writefile.WriteLine(" ")

        'First Checklist
        If firstYesRadio.Checked Then
            writefile.WriteLine(firstSymptomLabel.Text & " " & firstYesRadio.Text)
        ElseIf firstNoRadio.Checked Then
            writefile.WriteLine(firstSymptomLabel.Text & " " & firstNoRadio.Text)
        Else
            writefile.WriteLine(firstSymptomLabel.Text & " " & "Kindly answer the checklist completely.")
        End If

        If secondYesRadio.Checked Then
            writefile.WriteLine(secondSymptomLabel.Text & " " & secondYesRadio.Text)
        ElseIf secondNoRadio.Checked Then
            writefile.WriteLine(secondSymptomLabel.Text & " " & secondNoRadio.Text)
        Else
            writefile.WriteLine(secondSymptomLabel.Text & " " & "Kindly answer the checklist completely.")
        End If

        If thirdYesRadio.Checked Then
            writefile.WriteLine(thirdSymptomLabel.Text & " " & thirdYesRadio.Text)
        ElseIf thirdNoRadio.Checked Then
            writefile.WriteLine(thirdSymptomLabel.Text & " " & thirdNoRadio.Text)
        Else
            writefile.WriteLine(thirdSymptomLabel.Text & " " & "Kindly answer the checklist completely.")
        End If

        If fourthYesRadio.Checked Then
            writefile.WriteLine(fourthSymptomLabel.Text & " " & fourthYesRadio.Text)
        ElseIf fourthNoRadio.Checked Then
            writefile.WriteLine(fourthSymptomLabel.Text & " " & fourthNoRadio.Text)
        Else
            writefile.WriteLine(fourthSymptomLabel.Text & " " & "Kindly answer the checklist completely.")
        End If

        If fifthYesRadio.Checked Then
            writefile.WriteLine(fifthSymptomLabel.Text & " " & fifthYesRadio.Text)
        ElseIf fifthNoRadio.Checked Then
            writefile.WriteLine(fifthSymptomLabel.Text & " " & fifthNoRadio.Text)
        Else
            writefile.WriteLine(fifthSymptomLabel.Text & " " & "Kindly answer the checklist completely.")
        End If

        'Second Checklist
        If travelYesRadio.Checked Then
            writefile.WriteLine(secondQuestionLabel.Text & " " & travelYesRadio.Text)
        ElseIf travelNoRadio.Checked Then
            writefile.WriteLine(secondQuestionLabel.Text & " " & travelNoRadio.Text)
        Else
            writefile.WriteLine(secondQuestionLabel.Text & " " & "Kindly answer the checklist completely.")
        End If

        If inContactYesRadio.Checked Then
            writefile.WriteLine(thirdQuestionLabel1.Text & vbNewLine & thirdQuestionLabel2.Text & " " & inContactYesRadio.Text)
        ElseIf inContactNoRadio.Checked Then
            writefile.WriteLine(thirdQuestionLabel1.Text & vbNewLine & thirdQuestionLabel2.Text & " " & inContactNoRadio.Text)
        Else
            writefile.WriteLine(thirdQuestionLabel1.Text & vbNewLine & thirdQuestionLabel2.Text & " " & "Kindly answer the checklist completely.")
        End If

        writefile.WriteLine(" ")
        writefile.WriteLine(footerLabel.Text)
        MessageBox.Show("Submitted a form.")

        writefile.Close()

    End Sub
End Class
