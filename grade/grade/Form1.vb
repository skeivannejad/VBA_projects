Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim score As Double = TextBox1.Text

        If score >= 10 Then
            LblResult.Text = "قبول"
        Else
            LblResult.Text = "مردود"
        End If

        If score < 0 Then
            LblResult.Text = "Error"
        End If

        If score > 20 Then
            LblResult.Text = "Error"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim score As Double = TextBox1.Text
        If score >= 0 And score <= 20 Then
            'نمره مجاز
            If score >= 10 Then
                LblResult.Text = "Pass"
            Else
                LblResult.Text = "Refuse"
            End If
        Else
            'نمره غیر مجاز
            LblResult.Text = "Error"
        End If


    End Sub
End Class
