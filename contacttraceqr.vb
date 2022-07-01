Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow

Public Class contacttraceqr
    Dim camera_qr As VideoCaptureDevice
    Dim bitdisplay As Bitmap

    Private Sub scanQRBtn_Click(sender As Object, e As EventArgs) Handles scanQRBtn.Click
        Dim cameraqr As VideoCaptureDeviceForm = New VideoCaptureDeviceForm

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
End Class