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
        TxtNumber = New TextBox()
        lblResult = New Label()
        BtnCal = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lblEntered = New Label()
        BtnReset = New Button()
        SuspendLayout()
        ' 
        ' TxtNumber
        ' 
        TxtNumber.Font = New Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point)
        TxtNumber.Location = New Point(262, 47)
        TxtNumber.Name = "TxtNumber"
        TxtNumber.Size = New Size(354, 61)
        TxtNumber.TabIndex = 0
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Font = New Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point)
        lblResult.Location = New Point(542, 158)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(0, 54)
        lblResult.TabIndex = 1
        ' 
        ' BtnCal
        ' 
        BtnCal.Location = New Point(278, 383)
        BtnCal.Name = "BtnCal"
        BtnCal.Size = New Size(115, 40)
        BtnCal.TabIndex = 2
        BtnCal.Text = "Calculate"
        BtnCal.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(85, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(171, 54)
        Label1.TabIndex = 1
        Label1.Text = "number:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(250, 148)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 54)
        Label2.TabIndex = 3
        Label2.Text = "average:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 241)
        Label3.Name = "Label3"
        Label3.Size = New Size(319, 54)
        Label3.TabIndex = 3
        Label3.Text = "Entered number:"
        ' 
        ' lblEntered
        ' 
        lblEntered.AutoSize = True
        lblEntered.Font = New Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point)
        lblEntered.Location = New Point(357, 241)
        lblEntered.Name = "lblEntered"
        lblEntered.Size = New Size(0, 54)
        lblEntered.TabIndex = 1
        ' 
        ' BtnReset
        ' 
        BtnReset.Location = New Point(426, 383)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(115, 40)
        BtnReset.TabIndex = 2
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(BtnReset)
        Controls.Add(BtnCal)
        Controls.Add(Label1)
        Controls.Add(lblEntered)
        Controls.Add(lblResult)
        Controls.Add(TxtNumber)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtNumber As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents BtnCal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblEntered As Label
    Friend WithEvents BtnReset As Button
End Class
