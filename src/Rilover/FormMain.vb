Public Class FormMain
    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Application.Exit()
    End Sub

    Private Sub FormWelcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim quote As String = "خداوند از زیبایی ریاضیات برای خلق جهان استفاده کرد."
        Dim author As String = "پل دیراک"

        LabelQuote.Text = """" & quote & """"
        LabelAuthor.Text = "-" & author

        ButtonMusicOn_Click(sender, e)
    End Sub

    Private Sub ButtonMusicOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMusicOff.Click
        ButtonMusicOff.Visible = False
        ButtonMusicOn.Visible = True

        My.Computer.Audio.Stop()
    End Sub

    Private Sub ButtonMusicOn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMusicOn.Click
        ButtonMusicOff.Visible = True
        ButtonMusicOn.Visible = False

        My.Computer.Audio.Play(My.Resources.Notebook, AudioPlayMode.Background)
    End Sub

    Private Sub ToolStripMenuItemLesson1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemLesson1.Click
        FormQuestion.Show()
        Me.Close()
    End Sub
End Class
