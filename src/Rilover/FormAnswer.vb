Public Class FormAnswer
    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Application.Exit()
    End Sub

    Private Sub FormWelcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ButtonMusicOn_Click(sender, e)
    End Sub

    Private Sub ButtonMusicOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMusicOff.Click
        ButtonMusicOff.Visible = False
        ButtonMusicOn.Visible = True
    End Sub

    Private Sub ButtonMusicOn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMusicOn.Click
        ButtonMusicOff.Visible = True
        ButtonMusicOn.Visible = False
    End Sub

    Private Sub ButtonHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHome.Click
        FormMain.Show()
        Me.Hide()
    End Sub
End Class
