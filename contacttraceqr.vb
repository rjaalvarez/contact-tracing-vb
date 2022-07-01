Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing.Aztec
Imports ZXing


Public Class contacttraceqr
    Dim camera_qr As VideoCaptureDevice
    Dim bitdisplay As Bitmap

    Private Sub scanQRBtn_Click(sender As Object, e As EventArgs) Handles scanQRBtn.Click
        Dim cameraqr As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        timerqr.Start()

        If cameraqr.ShowDialog() = DialogResult.OK Then
            camera_qr = cameraqr.VideoDevice
            AddHandler camera_qr.NewFrame, New NewFrameEventHandler(AddressOf picboxqr)
            camera_qr.Start()
        End If

    End Sub

    Private Sub picboxqr(sender As Object, eventArgs As NewFrameEventArgs)
        bitdisplay = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        cameraPicBox.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)

    End Sub

    Private Sub timerqr_Tick(sender As Object, e As EventArgs) Handles timerqr.Tick
        If cameraPicBox.Image IsNot Nothing Then
            Dim scanqr As BarcodeReader = New BarcodeReader
            Dim qrdecode As Result = scanqr.Decode(DirectCast(cameraPicBox.Image, Bitmap))

            If qrdecode IsNot Nothing Then
                Dim contactform As New contactTracingForm
                contactform.contents = qrdecode.ToString()


                contactform.Show()
                Me.Hide()

            End If

        End If
    End Sub
End Class