Public Class Form1
    'Defining a global variable
    Dim g As Graphics
    Dim p As Pen
    Dim v As Integer
    Dim c As Color = Color.Red
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        'Setting a tooltip that displays value as you move the trackbar
        ToolTip1.SetToolTip(TrackBar1, TrackBar1.Value)
        g = Graphics.FromHwnd(Handle)
        'Creating a pen with red color and size 5
        p = New Pen(c, 5)
        v = TrackBar1.Value
        'Allows you to address the selected option in the ComboBox
        Select Case ComboBox1.SelectedItem
            Case "Circle"
                'Clearing the previous ellipse so the previou version does not accumulate
                g.Clear(Me.BackColor)
                g.DrawEllipse(p, 100, 100, v, v)
            Case "Square"
                g.Clear(Me.BackColor)
                g.DrawRectangle(p, 100, 100, v, v)
        End Select
        g.Dispose()
        g = Nothing
        p.Dispose()
        p = Nothing
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        g = Graphics.FromHwnd(Handle)
        p = New Pen(c, 5)
        Select Case ComboBox1.SelectedItem
            Case "Circle"
                g.Clear(Me.BackColor)
                g.DrawEllipse(p, 100, 100, v, v)
            Case "Square"
                g.Clear(Me.BackColor)
                g.DrawRectangle(p, 100, 100, v, v)
        End Select
        g.Dispose()
        g = Nothing
        p.Dispose()
        p = Nothing
    End Sub
End Class
