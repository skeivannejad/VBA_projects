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
        TextBox1 = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        LblResult = New Label()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(120, 79)
        TextBox1.Name = "TextBox1"
        TextBox1.RightToLeft = RightToLeft.No
        TextBox1.Size = New Size(265, 61)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(391, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 54)
        Label1.TabIndex = 1
        Label1.Text = "نمره:"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(241, 332)
        Button1.Name = "Button1"
        Button1.Size = New Size(109, 52)
        Button1.TabIndex = 2
        Button1.Text = "محاسبه1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' LblResult
        ' 
        LblResult.AutoSize = True
        LblResult.Font = New Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point)
        LblResult.Location = New Point(241, 184)
        LblResult.Name = "LblResult"
        LblResult.Size = New Size(0, 54)
        LblResult.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(391, 332)
        Button2.Name = "Button2"
        Button2.Size = New Size(102, 52)
        Button2.TabIndex = 3
        Button2.Text = "محاسبه2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(LblResult)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Name = "Form1"
        RightToLeft = RightToLeft.Yes
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LblResult As Label
    Friend WithEvents Button2 As Button
End Class
