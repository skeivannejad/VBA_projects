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
        lblResult = New Label()
        BtnTap = New Button()
        BtnReset = New Button()
        SuspendLayout()
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Font = New Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point)
        lblResult.Location = New Point(99, 40)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(74, 89)
        lblResult.TabIndex = 0
        lblResult.Text = "0"
        ' 
        ' BtnTap
        ' 
        BtnTap.Location = New Point(35, 14)
        BtnTap.Name = "BtnTap"
        BtnTap.Size = New Size(75, 23)
        BtnTap.TabIndex = 1
        BtnTap.Text = "Tap"
        BtnTap.UseVisualStyleBackColor = True
        ' 
        ' BtnReset
        ' 
        BtnReset.Location = New Point(184, 12)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(75, 23)
        BtnReset.TabIndex = 1
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(271, 243)
        Controls.Add(BtnReset)
        Controls.Add(BtnTap)
        Controls.Add(lblResult)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblResult As Label
    Friend WithEvents BtnTap As Button
    Friend WithEvents BtnReset As Button
End Class
