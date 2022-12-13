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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Panel1.Visible = True Then
            mnuShowHidePanel.Text = "Hide Panel"
        Else
            mnuShowHidePanel.Text = "Show Panel"
        End If
    End Sub

    Private Sub mnuShowHidePanel_Click(sender As Object, e As EventArgs) Handles mnuShowHidePanel.Click
        If mnuShowHidePanel.Text = "Hide Panel" Then
            Panel1.Visible = False
            mnuShowHidePanel.Text = "Show Panel"
        Else
            Panel1.Visible = True
            mnuShowHidePanel.Text = "Hide Panel"
        End If
    End Sub
End Class
