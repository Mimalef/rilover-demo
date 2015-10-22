<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQuote
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormQuote))
        Me.TimerNextForm = New System.Windows.Forms.Timer(Me.components)
        Me.LabelQuote = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'TimerNextForm
        '
        Me.TimerNextForm.Enabled = True
        Me.TimerNextForm.Interval = 8000
        '
        'LabelQuote
        '
        Me.LabelQuote.BackColor = System.Drawing.Color.White
        Me.LabelQuote.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQuote.Location = New System.Drawing.Point(166, 97)
        Me.LabelQuote.Name = "LabelQuote"
        Me.LabelQuote.Padding = New System.Windows.Forms.Padding(40)
        Me.LabelQuote.Size = New System.Drawing.Size(469, 307)
        Me.LabelQuote.TabIndex = 0
        '
        'FormQuote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelQuote)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormQuote"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rilover"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TimerNextForm As System.Windows.Forms.Timer
    Friend WithEvents LabelQuote As System.Windows.Forms.Label

End Class
