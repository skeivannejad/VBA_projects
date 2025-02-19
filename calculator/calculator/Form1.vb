Public Class Form1

    Dim num1 As Double
    Dim opr As String = "+"


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
        TextBox1.Text = TextBox1.Text + "7"


    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
        TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
        TextBox1.Text = TextBox1.Text + "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub ButtonSum_Click(sender As Object, e As EventArgs) Handles ButtonSum.Click
        '+
        num1 = TextBox1.Text
        TextBox1.Text = "0"
        opr = "+"
    End Sub
    Private Sub ButtonSub_Click(sender As Object, e As EventArgs) Handles ButtonSub.Click
        '-
        num1 = TextBox1.Text
        TextBox1.Text = "0"
        opr = "-"
    End Sub

    Private Sub ButtonMul_Click(sender As Object, e As EventArgs) Handles ButtonMul.Click
        '*
        num1 = TextBox1.Text
        TextBox1.Text = "0"
        opr = "*"
    End Sub

    Private Sub ButtonDiv_Click(sender As Object, e As EventArgs) Handles ButtonDiv.Click
        '/
        num1 = TextBox1.Text
        TextBox1.Text = "0"
        opr = "/"
    End Sub
    Private Sub ButtonResult_Click(sender As Object, e As EventArgs) Handles ButtonResult.Click
        '=
        Dim num2 As Double = TextBox1.Text
        If opr = "+" Then
            TextBox1.Text = num1 + num2
        ElseIf opr = "-" Then
            TextBox1.Text = num1 - num2
        ElseIf opr = "*" Then
            TextBox1.Text = num1 * num2
        ElseIf opr = "/" Then
            TextBox1.Text = num1 / num2
        End If

    End Sub


End Class
