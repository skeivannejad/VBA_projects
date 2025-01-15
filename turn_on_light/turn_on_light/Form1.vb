Public Class Form1

    Private Sub PicOff_Click(sender As Object, e As EventArgs) Handles PicOff.Click

        PicLightOn.Visible = True
        PicOn.Visible = True
        PicOff.Visible = False
        PicLightOff.Visible = False



    End Sub

    Private Sub PicOn_Click(sender As Object, e As EventArgs) Handles PicOn.Click

        PicLightOn.Visible = False
        PicOn.Visible = False
        PicOff.Visible = True
        PicLightOff.Visible = True


    End Sub
End Class
