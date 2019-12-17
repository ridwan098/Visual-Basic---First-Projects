Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, num3, total As Integer
        Dim average As Single

        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        num3 = Val(TextBox4.Text)

        total = num1 + num2
        average = total / 3

        TextBox3.Text = "The average is: " & average

        'to show the average in a label, use the code below'
        'Label5.Text = "The average is: " & average'

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = WindowState.Maximized
    End Sub
End Class
