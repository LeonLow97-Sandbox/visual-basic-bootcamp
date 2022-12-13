## Adding Tools using ToolBox

- View --> Toolbox
- Button | Label | TrackBar | TextBox | PictureBox | DataGridView 

## TrackBar, Button, TextBox

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

## Going to the next line 

- Use `vbcr` to go to the next line
```vb
Dim message = $"Column Index: {e.ColumnIndex}" + vbcr + $"Row Index: {e.RowIndex}"
```

## PictureBox

```vb
Public Class Form1
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim path = IO.Path.GetFileName(PictureBox2.ImageLocation)
        MessageBox.Show(path, "Picture", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

## MonthCalendar

- Hide and Unhide calendar with checkbox

```vb
    Private Sub chkCalendar_CheckedChanged(sender As Object, e As EventArgs) Handles chkCalendar.CheckedChanged
        If chkCalendar.Checked Then
            MonthCalendar1.Visible = True
        Else
            MonthCalendar1.Visible = False
        End If
    End Sub
```

## Using `IF` with `SaveFileDialog`

- Use `MenuStrip` and `SaveFileDialog`

```vb
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'Opens up the save file dialog
        'Saved as a Rich text format file and then in plan text format
        'DiaglogResult.OK in case if user cancels.
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub
```

## Using Compound Operators

```vb
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
```

## Looping: Making a program that reads a file

- Use `OpenFileDialog`
- Reading a stream of message for a `.txt` file.

```vb
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
            'Improves the overall performance and efficiency of the program
            stream.Close()
        End If
    End Sub
End Class
```

## Looping with **Do Until / Loop**

```vb
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
```

## For Each Loops

- Example includes a checklist of 3 items. (Collection of items)

```vb
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
End Class
```

## Write Selected Choices (from check list) to a file

```vb
    Private Sub btnWriteToFile_Click(sender As Object, e As EventArgs) Handles btnWriteToFile.Click
        Dim s As StreamWriter = New StreamWriter("C:\Users\User\delete.txt")
        For index = 0 To CheckedListBox1.CheckedIndices.Count - 1
            s.WriteLine(CheckedListBox1.CheckedItems(index))
        Next
        s.Close()
        'opens this delete.txt file right away
        Process.Start("notepad.exe", "C:\Users\User\delete.txt")
    End Sub
```

## If Else - Menus and Form Load

```vb
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
```

## IF with Image Lists

- Changes an images on button click through an `ImageList`
```vb
Public Class Form1
    'Set as global variable
    Dim pos = 0
    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        Dim g = Graphics.FromHwnd(Me.Handle)

        If pos < ImageList1.Images.Count Then
            ImageList1.Draw(g, New Point(10, 10), pos)
            pos += 1
        End If
        g.Dispose()
    End Sub
End Class

```








































