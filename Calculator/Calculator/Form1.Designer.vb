<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtFirstValue = New System.Windows.Forms.TextBox()
        Me.btnSummarize = New System.Windows.Forms.Button()
        Me.txtSecondValue = New System.Windows.Forms.TextBox()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtFirstValue
        '
        Me.txtFirstValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtFirstValue.Location = New System.Drawing.Point(129, 69)
        Me.txtFirstValue.Name = "txtFirstValue"
        Me.txtFirstValue.Size = New System.Drawing.Size(166, 30)
        Me.txtFirstValue.TabIndex = 0
        '
        'btnSummarize
        '
        Me.btnSummarize.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnSummarize.Location = New System.Drawing.Point(337, 147)
        Me.btnSummarize.Name = "btnSummarize"
        Me.btnSummarize.Size = New System.Drawing.Size(129, 34)
        Me.btnSummarize.TabIndex = 1
        Me.btnSummarize.Text = "Summarize"
        Me.btnSummarize.UseVisualStyleBackColor = True
        '
        'txtSecondValue
        '
        Me.txtSecondValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtSecondValue.Location = New System.Drawing.Point(470, 69)
        Me.txtSecondValue.Name = "txtSecondValue"
        Me.txtSecondValue.Size = New System.Drawing.Size(166, 30)
        Me.txtSecondValue.TabIndex = 2
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblSummary.Location = New System.Drawing.Point(332, 225)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(0, 38)
        Me.lblSummary.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.txtSecondValue)
        Me.Controls.Add(Me.btnSummarize)
        Me.Controls.Add(Me.txtFirstValue)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstValue As TextBox
    Friend WithEvents btnSummarize As Button
    Friend WithEvents txtSecondValue As TextBox
    Friend WithEvents lblSummary As Label
End Class
