Public Class Form1


    Private Sub PicCenterBtn_Click(sender As Object, e As EventArgs) Handles PicCenterBtn.Click

        'set picture center of space
        'We reduce the size of the shape and panel from the form and then divide by 2
        PicAirplane.Top = (Me.Height - PicAirplane.Height) / 2
        PicAirplane.Left = (Me.Width - PicAirplane.Width - PanelOrder.Width) / 2 + PanelOrder.Width

    End Sub

    Private Sub PicUpBtn_Click(sender As Object, e As EventArgs) Handles PicUpBtn.Click
        PicAirplane.Top = PicAirplane.Top - 10
    End Sub

    Private Sub PicDownBtn_Click(sender As Object, e As EventArgs) Handles PicDownBtn.Click
        PicAirplane.Top = PicAirplane.Top + 10
        'If you want the shape Not To go out Of space, use under code.
        'PicAirplane.Top = (PicAirplane.Top + 30) Mod Me.Height
    End Sub

    Private Sub PicLeftBtn_Click(sender As Object, e As EventArgs) Handles PicLeftBtn.Click
        PicAirplane.Left = PicAirplane.Left - 10
    End Sub

    Private Sub PicRightBtn_Click(sender As Object, e As EventArgs) Handles PicRightBtn.Click
        PicAirplane.Left = PicAirplane.Left + 10
        'If you want the shape Not To go out Of space, use under code.
        'PicAirplane.Left = (PicAirplane.Left + 30) Mod Me.Width
    End Sub

    Private Sub BtnZoomIn_Click(sender As Object, e As EventArgs) Handles BtnZoomIn.Click
        'zoom in
        PicAirplane.Width = PicAirplane.Width * 1.1
        PicAirplane.Height = PicAirplane.Height * 1.1
        'stay shape in centerof space
        PicAirplane.Top = (Me.Height - PicAirplane.Height) / 2
        PicAirplane.Left = (Me.Width - PicAirplane.Width - PanelOrder.Width) / 2 + PanelOrder.Width

    End Sub

    Private Sub BtnZoomOut_Click(sender As Object, e As EventArgs) Handles BtnZoomOut.Click
        'zoom out
        PicAirplane.Width = PicAirplane.Width * 0.9
        PicAirplane.Height = PicAirplane.Height * 0.9
        'stay shape in centerof space
        PicAirplane.Top = (Me.Height - PicAirplane.Height) / 2
        PicAirplane.Left = (Me.Width - PicAirplane.Width - PanelOrder.Width) / 2 + PanelOrder.Width
    End Sub
End Class
