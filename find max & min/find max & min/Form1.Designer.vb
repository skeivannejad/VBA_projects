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
        btnAdd = New Button()
        Label1 = New Label()
        lblMax = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lblMin = New Label()
        btnReset = New Button()
        Label4 = New Label()
        LblAddedNum = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(149, 44)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(181, 34)
        TextBox1.TabIndex = 0
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(121, 110)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 1
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(26, 329)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 28)
        Label1.TabIndex = 2
        Label1.Text = "Maximum:"
        ' 
        ' lblMax
        ' 
        lblMax.AutoSize = True
        lblMax.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        lblMax.Location = New Point(135, 329)
        lblMax.Name = "lblMax"
        lblMax.Size = New Size(0, 28)
        lblMax.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 28)
        Label2.TabIndex = 2
        Label2.Text = "Enter number:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(26, 378)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 28)
        Label3.TabIndex = 2
        Label3.Text = "Minimum:"
        ' 
        ' lblMin
        ' 
        lblMin.AutoSize = True
        lblMin.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        lblMin.Location = New Point(135, 378)
        lblMin.Name = "lblMin"
        lblMin.Size = New Size(0, 28)
        lblMin.TabIndex = 3
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(121, 460)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(75, 23)
        btnReset.TabIndex = 4
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(12, 155)
        Label4.Name = "Label4"
        Label4.Size = New Size(148, 28)
        Label4.TabIndex = 2
        Label4.Text = "Added number:"
        ' 
        ' LblAddedNum
        ' 
        LblAddedNum.AutoSize = True
        LblAddedNum.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        LblAddedNum.Location = New Point(175, 155)
        LblAddedNum.Name = "LblAddedNum"
        LblAddedNum.Size = New Size(0, 28)
        LblAddedNum.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(364, 579)
        Controls.Add(btnReset)
        Controls.Add(lblMin)
        Controls.Add(LblAddedNum)
        Controls.Add(lblMax)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(btnAdd)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMax As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMin As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents LblAddedNum As Label
End Class
