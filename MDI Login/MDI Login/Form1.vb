﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As New Login
        f.MdiParent = Me
        f.Show()


    End Sub
End Class
