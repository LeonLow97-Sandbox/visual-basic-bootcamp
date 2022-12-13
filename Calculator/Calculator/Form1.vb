Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtFirstValue.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtSecondValue.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSummarize.Click
        Dim leftValue = Double.Parse(txtFirstValue.Text)
        Dim rightValue = Double.Parse(txtSecondValue.Text)
        Dim sum = leftValue + rightValue
        Dim average = sum / 2
        lblSummary.Text = $"Sum: {sum}" + vbCr + $"Average: {average}"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblSummary.Click

    End Sub
End Class
