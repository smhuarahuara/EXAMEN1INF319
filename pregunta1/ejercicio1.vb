Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, i, j As Integer
        Dim b, c, d As Integer
        TextBox2.Text = ""
        i = 0
        n = Convert.ToInt32(TextBox1.Text)
        b = 0
        c = 1
        d = 0
        j = 0
bucle:
        If i <= n Then GoTo ejecutar Else GoTo salir
ejecutar:
        j = 0
        d = d + 1
        TextBox2.Text = TextBox2.Text + b.ToString() + ","
        i = i + 1
        If i <= n Then GoTo bucle1 Else GoTo salir
bucle1:
        j = j + 1
        i = i + 1
        TextBox2.Text = TextBox2.Text + c.ToString() + ","
        If i > n Then GoTo salir
        If j < d Then GoTo bucle1 Else GoTo bucle
salir:
    End Sub
End Class
