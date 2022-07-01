<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class contacttraceqr
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.scanQRBtn = New System.Windows.Forms.Button()
        Me.cameraPicBox = New System.Windows.Forms.PictureBox()
        Me.timerqr = New System.Windows.Forms.Timer(Me.components)
        CType(Me.cameraPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'scanQRBtn
        '
        Me.scanQRBtn.Location = New System.Drawing.Point(167, 386)
        Me.scanQRBtn.Name = "scanQRBtn"
        Me.scanQRBtn.Size = New System.Drawing.Size(139, 61)
        Me.scanQRBtn.TabIndex = 0
        Me.scanQRBtn.Text = "Scan QR"
        Me.scanQRBtn.UseVisualStyleBackColor = True
        '
        'cameraPicBox
        '
        Me.cameraPicBox.Location = New System.Drawing.Point(12, 12)
        Me.cameraPicBox.Name = "cameraPicBox"
        Me.cameraPicBox.Size = New System.Drawing.Size(460, 368)
        Me.cameraPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.cameraPicBox.TabIndex = 1
        Me.cameraPicBox.TabStop = False
        '
        'timerqr
        '
        Me.timerqr.Interval = 1000
        '
        'contacttraceqr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(488, 457)
        Me.Controls.Add(Me.cameraPicBox)
        Me.Controls.Add(Me.scanQRBtn)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "contacttraceqr"
        Me.Text = "Contact Tracing QR"
        CType(Me.cameraPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents scanQRBtn As Button
    Friend WithEvents cameraPicBox As PictureBox
    Friend WithEvents timerqr As Timer
End Class
