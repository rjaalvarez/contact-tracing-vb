﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactTracingFormQR
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
        Me.scanQRBtn = New System.Windows.Forms.Button()
        Me.cameraPicBox = New System.Windows.Forms.PictureBox()
        CType(Me.cameraPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'scanQRBtn
        '
        Me.scanQRBtn.Location = New System.Drawing.Point(151, 374)
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
        Me.cameraPicBox.Size = New System.Drawing.Size(426, 356)
        Me.cameraPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.cameraPicBox.TabIndex = 1
        Me.cameraPicBox.TabStop = False
        '
        'ContactTracingFormQR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 447)
        Me.Controls.Add(Me.cameraPicBox)
        Me.Controls.Add(Me.scanQRBtn)
        Me.Name = "ContactTracingFormQR"
        Me.Text = "Contact Tracing QR"
        CType(Me.cameraPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents scanQRBtn As Button
    Friend WithEvents cameraPicBox As PictureBox
End Class