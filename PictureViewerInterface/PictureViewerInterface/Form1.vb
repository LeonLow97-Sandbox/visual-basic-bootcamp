Public Class Form1
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim path = IO.Path.GetFileName(PictureBox2.ImageLocation)
        MessageBox.Show(path, "Picture", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
