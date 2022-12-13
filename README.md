## TrackBar, Button, TextInput

```vb
Public Class Form1
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
```

## Button

```vb
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSummarize.Click
        Dim leftValue = Double.Parse(txtFirstValue.Text)
        Dim rightValue = Double.Parse(txtSecondValue.Text)
        Dim sum = leftValue + rightValue
        Dim average = sum / 2
        lblSummary.Text = $"Sum: {sum}" + vbCr + $"Average: {average}"
    End Sub
End Class
```

## DataGridView (Delegates)

```vb
Public Class Form1
    Private Sub CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim message = $"Column Index: {e.ColumnIndex}" + vbCr + $"Row Index: {e.RowIndex}"
        MessageBox.Show(message)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler DataGridView1.CellContentClick, AddressOf CellClick
    End Sub
End Class
```

## Going to the next line 

- Use `vbcr` to go to the next line
```vb
Dim message = $"Column Index: {e.ColumnIndex}" + vbcr + $"Row Index: {e.RowIndex}"
```