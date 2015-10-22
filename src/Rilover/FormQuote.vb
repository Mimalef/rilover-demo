Public Class FormQuote
    Private Sub NextForm()
        FormMain.Show()
        TimerNextForm.Stop()
        Me.Hide()
    End Sub

    Private Sub FormQuotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim quote As String = "خداوند از زیبایی ریاضیات برای خلق جهان استفاده کرد."
        Dim author As String = "پل دیراک"

        LabelQuote.Text = """" & quote & """" & vbNewLine & vbNewLine
        LabelQuote.Text += "-" & author
    End Sub

    Private Sub TimerNextForm_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerNextForm.Tick
        NextForm()
    End Sub

    Private Sub LabelQuote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelQuote.Click
        NextForm()
    End Sub

    Private Sub FormQuotes_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseClick
        NextForm()
    End Sub

    Private Sub FormQuotes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        NextForm()
    End Sub
End Class
