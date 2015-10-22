Public Class FormQuestion
    Dim answer As String
    Dim choise As String

    Private Sub SelectOption(ByVal sender As System.Object)
        For Each ctrl As Object In Me.Controls
            If TypeOf ctrl Is Label And ctrl.BackColor = Color.LightGray Then
                ctrl.BackColor = Color.White
                ctrl.Enabled = Enabled
            End If
        Next

        choise = sender.Text

        sender.Enabled = False
        sender.BackColor = Color.LightGray

        'My.Computer.Audio.Play(My.Resources.Ding, AudioPlayMode.Background)
    End Sub

    Private Sub Swap(ByRef a As String, ByRef b As String)
        Dim tmp As String = a
        a = b
        b = tmp
    End Sub

    Private Sub GenerateQuestion()
        Dim questionFrame As String = "نمایش توصیفی مجموعه ی {0} کدام گزینه است؟"
        Dim questionVar As String = "A = {{ {0}, {1}, {2}, {3}, ... }} x"
        Dim answerFrame As String = " A = {{ {0} X  | X ∈ {1} }} x"
        Dim options(4) As String
        Dim x As Integer = 0
        Dim r As New Random

        While Math.Abs(x) < 2
            x = r.Next(-10, 10)
        End While

        questionVar = String.Format(questionVar, x, x * 2, x * 3, x * 4)
        answer = String.Format(answerFrame, x, "N")

        options(0) = String.Format(answerFrame, x & " +", "N")
        options(1) = String.Format(answerFrame, -1 * x, "N")
        options(2) = String.Format(answerFrame, x, "Z")
        options(3) = answer

        For i As Integer = 1 To 10
            Swap(options(0), options(r.Next(1, 4)))
        Next

        LabelQuestion.Text = String.Format(questionFrame, questionVar)
        LabelOption1.Text += options(0)
        LabelOption2.Text += options(1)
        LabelOption3.Text += options(2)
        LabelOption4.Text += options(3)
    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Application.Exit()
    End Sub

    Private Sub FormWelcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        GenerateQuestion()
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
        Me.Close()
    End Sub

    Private Sub LabelOption1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelOption1.Click
        SelectOption(sender)
    End Sub

    Private Sub LabelOption2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelOption2.Click
        SelectOption(sender)
    End Sub

    Private Sub LabelOption3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelOption3.Click
        SelectOption(sender)
    End Sub

    Private Sub LabelOption4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelOption4.Click
        SelectOption(sender)
    End Sub

    Private Sub ButtonCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCheck.Click
        For Each ctrl As Object In Me.Controls
            If TypeOf ctrl Is Label And ctrl.Text.length > 3 Then
                If ctrl.Text.Substring(2) = answer Then
                    ctrl.BackColor = Color.Green
                End If
            End If
            If answer <> choise And ctrl.Text = choise And choise <> "" Then
                ctrl.BackColor = Color.Red
            End If
        Next
    End Sub

    Private Sub ButtonNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNext.Click
        Dim form As New FormQuestion
        form.Show()
        Me.Close()
    End Sub
End Class
