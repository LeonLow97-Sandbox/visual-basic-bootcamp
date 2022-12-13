Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MessageBox.Show("Message Box from Form1")

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll

        'Dim value As Integer = TrackBar1.Value
        Label1.Text = $"Value: {TrackBar1.Value}"

    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        'Function Chaining
        lblMessage.Text = txtInput.Text.Trim().ToUpper()
    End Sub
End Class
