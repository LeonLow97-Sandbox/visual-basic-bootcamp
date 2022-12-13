Imports System.IO

Public Class Form1
    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Clear out the label text between button clicks
        Label1.Text = ""
        For Each item In CheckedListBox1.CheckedItems
            Label1.Text += item + vbCr
        Next
    End Sub

    Private Sub btnWriteToFile_Click(sender As Object, e As EventArgs) Handles btnWriteToFile.Click
        Dim s As StreamWriter = New StreamWriter("C:\Users\User\delete.txt")
        For index = 0 To CheckedListBox1.CheckedIndices.Count - 1
            s.WriteLine(CheckedListBox1.CheckedItems(index))
        Next
        s.Close()
        'opens this delete.txt file right away
        Process.Start("notepad.exe", "C:\Users\User\delete.txt")
    End Sub
End Class
