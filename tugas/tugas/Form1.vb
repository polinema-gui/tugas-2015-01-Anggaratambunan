﻿Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.BackColor = Color.CadetBlue Then
            Me.BackColor = Color.DarkMagenta
        Else
            Me.BackColor = Color.CadetBlue

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.CadetBlue

    End Sub

End Class
