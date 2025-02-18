Public Class Form1
    'سراسری
    Dim count As Integer 'تعداد اعداد
    Dim sum As Double 'مجموع اعداد

    Private Sub BtnCal_Click(sender As Object, e As EventArgs) Handles BtnCal.Click
        'محلی
        Dim Num As Double = Val(TxtNumber.Text)
        Dim average As Double

        count = count + 1
        sum = sum + Num
        average = sum / count
        lblResult.Text = average

        lblEntered.Text = lblEntered.Text + Str(Num) + ","

    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click

        lblResult.Text = ""
        lblEntered.Text = ""
        TxtNumber.Text = ""
        count = 0
        sum = 0

    End Sub

End Class
