<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.ButtonMusicOff = New System.Windows.Forms.Button
        Me.ButtonMusicOn = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.MenuStripMain = New System.Windows.Forms.MenuStrip
        Me.ToolStripMenuItemLesson1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemLesson2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemLesson3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemLesson4 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemLesson5 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemLesson6 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemLesson7 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemLesson8 = New System.Windows.Forms.ToolStripMenuItem
        Me.LabelQuote = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LabelAuthor = New System.Windows.Forms.Label
        Me.ToolStripMenuItemAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemGames = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStripMain.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonMusicOff
        '
        Me.ButtonMusicOff.BackgroundImage = CType(resources.GetObject("ButtonMusicOff.BackgroundImage"), System.Drawing.Image)
        Me.ButtonMusicOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonMusicOff.FlatAppearance.BorderSize = 0
        Me.ButtonMusicOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMusicOff.Location = New System.Drawing.Point(102, 15)
        Me.ButtonMusicOff.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonMusicOff.Name = "ButtonMusicOff"
        Me.ButtonMusicOff.Size = New System.Drawing.Size(75, 74)
        Me.ButtonMusicOff.TabIndex = 2
        Me.ButtonMusicOff.TabStop = False
        Me.ButtonMusicOff.UseVisualStyleBackColor = True
        '
        'ButtonMusicOn
        '
        Me.ButtonMusicOn.BackgroundImage = CType(resources.GetObject("ButtonMusicOn.BackgroundImage"), System.Drawing.Image)
        Me.ButtonMusicOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonMusicOn.FlatAppearance.BorderSize = 0
        Me.ButtonMusicOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMusicOn.Location = New System.Drawing.Point(102, 15)
        Me.ButtonMusicOn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonMusicOn.Name = "ButtonMusicOn"
        Me.ButtonMusicOn.Size = New System.Drawing.Size(75, 74)
        Me.ButtonMusicOn.TabIndex = 1
        Me.ButtonMusicOn.TabStop = False
        Me.ButtonMusicOn.UseVisualStyleBackColor = True
        Me.ButtonMusicOn.Visible = False
        '
        'ButtonClose
        '
        Me.ButtonClose.BackgroundImage = CType(resources.GetObject("ButtonClose.BackgroundImage"), System.Drawing.Image)
        Me.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Location = New System.Drawing.Point(19, 15)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 74)
        Me.ButtonClose.TabIndex = 0
        Me.ButtonClose.TabStop = False
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'MenuStripMain
        '
        Me.MenuStripMain.AutoSize = False
        Me.MenuStripMain.BackColor = System.Drawing.Color.Gainsboro
        Me.MenuStripMain.Dock = System.Windows.Forms.DockStyle.Right
        Me.MenuStripMain.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemLesson1, Me.ToolStripMenuItemLesson2, Me.ToolStripMenuItemLesson3, Me.ToolStripMenuItemLesson4, Me.ToolStripMenuItemLesson5, Me.ToolStripMenuItemLesson6, Me.ToolStripMenuItemLesson7, Me.ToolStripMenuItemLesson8, Me.ToolStripMenuItemGames, Me.ToolStripMenuItemAbout})
        Me.MenuStripMain.Location = New System.Drawing.Point(654, 0)
        Me.MenuStripMain.Name = "MenuStripMain"
        Me.MenuStripMain.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.MenuStripMain.Size = New System.Drawing.Size(146, 500)
        Me.MenuStripMain.TabIndex = 5
        Me.MenuStripMain.Text = "Main"
        '
        'ToolStripMenuItemLesson1
        '
        Me.ToolStripMenuItemLesson1.Image = CType(resources.GetObject("ToolStripMenuItemLesson1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItemLesson1.Name = "ToolStripMenuItemLesson1"
        Me.ToolStripMenuItemLesson1.Padding = New System.Windows.Forms.Padding(10)
        Me.ToolStripMenuItemLesson1.Size = New System.Drawing.Size(119, 43)
        Me.ToolStripMenuItemLesson1.Text = "درس اول"
        '
        'ToolStripMenuItemLesson2
        '
        Me.ToolStripMenuItemLesson2.Image = CType(resources.GetObject("ToolStripMenuItemLesson2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItemLesson2.Name = "ToolStripMenuItemLesson2"
        Me.ToolStripMenuItemLesson2.Padding = New System.Windows.Forms.Padding(10)
        Me.ToolStripMenuItemLesson2.Size = New System.Drawing.Size(119, 43)
        Me.ToolStripMenuItemLesson2.Text = "درس دوم"
        '
        'ToolStripMenuItemLesson3
        '
        Me.ToolStripMenuItemLesson3.Image = CType(resources.GetObject("ToolStripMenuItemLesson3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItemLesson3.Name = "ToolStripMenuItemLesson3"
        Me.ToolStripMenuItemLesson3.Padding = New System.Windows.Forms.Padding(10)
        Me.ToolStripMenuItemLesson3.Size = New System.Drawing.Size(119, 43)
        Me.ToolStripMenuItemLesson3.Text = "درس سوم"
        '
        'ToolStripMenuItemLesson4
        '
        Me.ToolStripMenuItemLesson4.Image = CType(resources.GetObject("ToolStripMenuItemLesson4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItemLesson4.Name = "ToolStripMenuItemLesson4"
        Me.ToolStripMenuItemLesson4.Padding = New System.Windows.Forms.Padding(10)
        Me.ToolStripMenuItemLesson4.Size = New System.Drawing.Size(119, 43)
        Me.ToolStripMenuItemLesson4.Text = "درس چهارم"
        '
        'ToolStripMenuItemLesson5
        '
        Me.ToolStripMenuItemLesson5.Image = CType(resources.GetObject("ToolStripMenuItemLesson5.Image"), System.Drawing.Image)
        Me.ToolStripMenuItemLesson5.Name = "ToolStripMenuItemLesson5"
        Me.ToolStripMenuItemLesson5.Padding = New System.Windows.Forms.Padding(10)
        Me.ToolStripMenuItemLesson5.Size = New System.Drawing.Size(119, 43)
        Me.ToolStripMenuItemLesson5.Text = "درس پنجم"
        '
        'ToolStripMenuItemLesson6
        '
        Me.ToolStripMenuItemLesson6.Image = CType(resources.GetObject("ToolStripMenuItemLesson6.Image"), System.Drawing.Image)
        Me.ToolStripMenuItemLesson6.Name = "ToolStripMenuItemLesson6"
        Me.ToolStripMenuItemLesson6.Padding = New System.Windows.Forms.Padding(10)
        Me.ToolStripMenuItemLesson6.Size = New System.Drawing.Size(119, 43)
        Me.ToolStripMenuItemLesson6.Text = "درس ششم"
        '
        'ToolStripMenuItemLesson7
        '
        Me.ToolStripMenuItemLesson7.Image = CType(resources.GetObject("ToolStripMenuItemLesson7.Image"), System.Drawing.Image)
        Me.ToolStripMenuItemLesson7.Name = "ToolStripMenuItemLesson7"
        Me.ToolStripMenuItemLesson7.Padding = New System.Windows.Forms.Padding(10)
        Me.ToolStripMenuItemLesson7.Size = New System.Drawing.Size(119, 43)
        Me.ToolStripMenuItemLesson7.Text = "درس هفتم"
        '
        'ToolStripMenuItemLesson8
        '
        Me.ToolStripMenuItemLesson8.Image = CType(resources.GetObject("ToolStripMenuItemLesson8.Image"), System.Drawing.Image)
        Me.ToolStripMenuItemLesson8.Name = "ToolStripMenuItemLesson8"
        Me.ToolStripMenuItemLesson8.Padding = New System.Windows.Forms.Padding(10)
        Me.ToolStripMenuItemLesson8.Size = New System.Drawing.Size(119, 43)
        Me.ToolStripMenuItemLesson8.Text = "درس هشتم"
        '
        'LabelQuote
        '
        Me.LabelQuote.BackColor = System.Drawing.Color.Transparent
        Me.LabelQuote.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQuote.ForeColor = System.Drawing.Color.Black
        Me.LabelQuote.Location = New System.Drawing.Point(176, 161)
        Me.LabelQuote.Name = "LabelQuote"
        Me.LabelQuote.Size = New System.Drawing.Size(279, 160)
        Me.LabelQuote.TabIndex = 6
        Me.LabelQuote.Text = """یک سخن زیبا از بزرگان علم در وصف عظمت و شکوه ریاضیات"""
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(61, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(532, 430)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'LabelAuthor
        '
        Me.LabelAuthor.Location = New System.Drawing.Point(169, 321)
        Me.LabelAuthor.Name = "LabelAuthor"
        Me.LabelAuthor.Size = New System.Drawing.Size(89, 23)
        Me.LabelAuthor.TabIndex = 8
        Me.LabelAuthor.Text = "-نویسنده"
        '
        'ToolStripMenuItemAbout
        '
        Me.ToolStripMenuItemAbout.Image = CType(resources.GetObject("ToolStripMenuItemAbout.Image"), System.Drawing.Image)
        Me.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout"
        Me.ToolStripMenuItemAbout.Padding = New System.Windows.Forms.Padding(10)
        Me.ToolStripMenuItemAbout.Size = New System.Drawing.Size(119, 43)
        Me.ToolStripMenuItemAbout.Text = "درباره ما"
        '
        'ToolStripMenuItemGames
        '
        Me.ToolStripMenuItemGames.Image = CType(resources.GetObject("ToolStripMenuItemGames.Image"), System.Drawing.Image)
        Me.ToolStripMenuItemGames.Name = "ToolStripMenuItemGames"
        Me.ToolStripMenuItemGames.Padding = New System.Windows.Forms.Padding(10)
        Me.ToolStripMenuItemGames.Size = New System.Drawing.Size(119, 43)
        Me.ToolStripMenuItemGames.Text = "زنگ تفریح"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelAuthor)
        Me.Controls.Add(Me.LabelQuote)
        Me.Controls.Add(Me.ButtonMusicOff)
        Me.Controls.Add(Me.ButtonMusicOn)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.MenuStripMain)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStripMain
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rilover"
        Me.MenuStripMain.ResumeLayout(False)
        Me.MenuStripMain.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ButtonMusicOn As System.Windows.Forms.Button
    Friend WithEvents ButtonMusicOff As System.Windows.Forms.Button
    Friend WithEvents MenuStripMain As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItemLesson1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemLesson2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemLesson3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemLesson4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemLesson5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemLesson6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemLesson7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemLesson8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelQuote As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelAuthor As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItemGames As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemAbout As System.Windows.Forms.ToolStripMenuItem

End Class
