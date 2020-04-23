Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            MsgBox("Bem Vindo!")
        Else
            MsgBox("Tente Outra Vez!")
        End If
    End Sub
End Class