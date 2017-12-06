Public Class frmRockPaperScissors
    Dim intRock As Integer
    Dim intPaper As Integer
    Dim intScissors As Integer
    Sub showRock()
        picRock.Visible = True
        picPaper.Visible = False
        picScissors.Visible = False
        picAll.Visible = False
    End Sub
    Sub showPaper()
        picRock.Visible = False
        picPaper.Visible = True
        picScissors.Visible = False
        picAll.Visible = False
    End Sub
    Sub showScissors()
        picRock.Visible = False
        picPaper.Visible = False
        picScissors.Visible = True
        picAll.Visible = False
    End Sub
    Sub showScores()
        lblPaper.Text = intPaper
        lblRock.Text = intRock
        lblScissors.Text = intScissors
    End Sub
    Sub reset()
        If intPaper + intScissors + intRock = 25 Then
            MessageBox.Show("New Round!")
            picAll.Visible = True
            picPaper.Visible = False
            picRock.Visible = False
            picScissors.Visible = False
            intRock = 0
            intPaper = 0
            intScissors = 0
            lblWinning.Text = String.Empty
            lblPaper.Text = String.Empty
            lblRock.Text = String.Empty
            lblScissors.Text = String.Empty
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRock.Click
        Dim rand As New Random

        If rand.Next(3) = 0 Then
            showRock()
            intRock += 1
            lblWinning.Text = "The computer played rock! You tied!"
        ElseIf rand.Next(3) = 1 Then
            showPaper()
            intPaper += 1
            lblWinning.Text = "The computer played paper! You lost!"
        ElseIf rand.Next(3) = 2 Then
            showScissors()
            intScissors += 1
            lblWinning.Text = "The computer played scissors! You won!"
        End If

        showScores()
        reset()

    End Sub

    Private Sub btnPaper_Click(sender As Object, e As EventArgs) Handles btnPaper.Click
        Dim rand As New Random

        If rand.Next(3) = 0 Then
            showRock()
            intRock += 1
            lblWinning.Text = "The computer played rock! You won!"
        ElseIf rand.Next(3) = 1 Then
            showPaper()
            intPaper += 1
            lblWinning.Text = "The computer played paper! You tied!"
        ElseIf rand.Next(3) = 2 Then
            showScissors()
            intScissors += 1
            lblWinning.Text = "The computer played scissors! You lost!"
        End If

        showScores()
        reset()

    End Sub

    Private Sub btnScissors_Click(sender As Object, e As EventArgs) Handles btnScissors.Click
        Dim rand As New Random

        If rand.Next(3) = 0 Then
            showRock()
            intRock += 1
            lblWinning.Text = "The computer played rock! You lost!"
        ElseIf rand.Next(3) = 1 Then
            showPaper()
            intPaper += 1
            lblWinning.Text = "The computer played paper! You won!"
        ElseIf rand.Next(3) = 2 Then
            showScissors()
            intScissors += 1
            lblWinning.Text = "The computer played scissors! You tied!"
        End If

        showScores()
        reset()

    End Sub
End Class
