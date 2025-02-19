Public Class Form1

    Dim isFirst As Boolean
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Static max, min As Integer
        Dim inputNum As Integer = TextBox1.Text

        If isFirst = False Then 'عددی وارد نشده
            max = inputNum
            min = inputNum
            lblMax.Text = max
            lblMin.Text = min
            isFirst = True
        End If
        If max < inputNum Then
            max = inputNum
            lblMax.Text = max
        ElseIf min > inputNum Then
            min = inputNum
            lblMin.Text = min
        End If

        LblAddedNum.Text = LblAddedNum.Text + Str(inputNum) + ", "
        TextBox1.Text = ""

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        lblMax.Text = ""
        lblMin.Text = ""
        LblAddedNum.Text = ""
        isFirst = False 'هنوز عددی وارد نشده

    End Sub
End Class
