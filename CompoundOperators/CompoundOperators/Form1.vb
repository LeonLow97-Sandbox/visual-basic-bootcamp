﻿Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "Results: "

        Dim x As Double = 1
        Label1.Text += vbCr + $"x={x}"
        x = x + 1
        Label1.Text += vbCr + $"x+1={x}"

        x *= 2
        Label1.Text += vbCr + $"x*2={x}"

        x -= 1
        Label1.Text += vbCr + $"x-1={x}"
    End Sub
End Class
