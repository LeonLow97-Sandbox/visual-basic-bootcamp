Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'In case cancel, code won't crash
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            'Reads the entire stream in the file
            Dim stream As StreamReader = File.OpenText(OpenFileDialog1.FileName)
            Dim c As Integer = stream.Peek()

            'File has multiple lines
            'Can also do stream.Peek() <> -1 OR stream.Peek() >= 0
            While c > -1
                Label1.Text += vbCr + stream.ReadLine()
                c = stream.Peek()
            End While

            'Ensures that any memory or resources used by the stream are released
            'Improves the overall performance and effiency of the program
            stream.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim stream As StreamReader = File.OpenText(OpenFileDialog1.FileName)
            Dim c As Integer = stream.Peek()
            Do Until c = -1
                Label1.Text += vbCr + stream.ReadLine()
                c = stream.Peek()
            Loop
            stream.Close()
        End If
    End Sub
End Class
