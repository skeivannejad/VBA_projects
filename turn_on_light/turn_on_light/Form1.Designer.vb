<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PicLightOff = New PictureBox()
        PicLightOn = New PictureBox()
        PicOff = New PictureBox()
        PicOn = New PictureBox()
        Panel1 = New Panel()
        CType(PicLightOff, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicLightOn, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicOff, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicOn, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PicLightOff
        ' 
        PicLightOff.Image = My.Resources.Resources.Off
        PicLightOff.Location = New Point(28, 20)
        PicLightOff.Name = "PicLightOff"
        PicLightOff.Size = New Size(141, 237)
        PicLightOff.TabIndex = 0
        PicLightOff.TabStop = False
        ' 
        ' PicLightOn
        ' 
        PicLightOn.Image = My.Resources.Resources._On
        PicLightOn.Location = New Point(28, 20)
        PicLightOn.Name = "PicLightOn"
        PicLightOn.Size = New Size(141, 237)
        PicLightOn.TabIndex = 0
        PicLightOn.TabStop = False
        PicLightOn.Visible = False
        ' 
        ' PicOff
        ' 
        PicOff.Cursor = Cursors.Hand
        PicOff.Image = My.Resources.Resources.turn_off_button
        PicOff.Location = New Point(297, 302)
        PicOff.Name = "PicOff"
        PicOff.Size = New Size(80, 82)
        PicOff.SizeMode = PictureBoxSizeMode.Zoom
        PicOff.TabIndex = 1
        PicOff.TabStop = False
        ' 
        ' PicOn
        ' 
        PicOn.Cursor = Cursors.Hand
        PicOn.Image = My.Resources.Resources.turn_on_button
        PicOn.Location = New Point(297, 302)
        PicOn.Name = "PicOn"
        PicOn.Size = New Size(80, 82)
        PicOn.SizeMode = PictureBoxSizeMode.Zoom
        PicOn.TabIndex = 1
        PicOn.TabStop = False
        PicOn.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PicLightOn)
        Panel1.Controls.Add(PicLightOff)
        Panel1.Location = New Point(230, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 284)
        Panel1.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(684, 450)
        Controls.Add(Panel1)
        Controls.Add(PicOn)
        Controls.Add(PicOff)
        DoubleBuffered = True
        Name = "Form1"
        RightToLeft = RightToLeft.Yes
        Text = "Form1"
        CType(PicLightOff, ComponentModel.ISupportInitialize).EndInit()
        CType(PicLightOn, ComponentModel.ISupportInitialize).EndInit()
        CType(PicOff, ComponentModel.ISupportInitialize).EndInit()
        CType(PicOn, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PicLightOff As PictureBox
    Friend WithEvents PicLightOn As PictureBox
    Friend WithEvents PicOff As PictureBox
    Friend WithEvents PicOn As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
