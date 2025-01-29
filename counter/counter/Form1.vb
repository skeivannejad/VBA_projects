Public Class Form1
    Private Sub BtnTap_Click(sender As Object, e As EventArgs) Handles BtnTap.Click

        lblResult.Text = lblResult.Text + 1

    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        lblResult.Text = "0"
    End Sub
End Class
