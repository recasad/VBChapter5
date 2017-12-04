Public Class Form1
    Dim intBeccaCount As Integer
    Dim intJamesCount As Integer
    Dim intReneeCount As Integer
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picBecca.Click
        picBecca.Left = 25
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnRace.Click
        Dim intCount1, intCount2, intCount3 As Integer
        Dim rand As New Random
        Dim intScore As Integer = 1
        Dim intYouWin As Integer = 9

        For intCount1 = 25 To rand.Next(250) + 50
            picBecca.Left = intCount1
        Next
        For intCount2 = 25 To rand.Next(250) + 50
            picJames.Left = intCount2
        Next
        For intCount3 = 25 To rand.Next(250) + 50
            picRenee.Left = intCount3
        Next

        If intCount1 > intCount2 And intCount3 Then
            intBeccaCount = intBeccaCount + 1
        ElseIf intCount2 > intCount3 And intCount1 Then
            intJamesCount = intJamesCount + 1
        ElseIf intCount3 > intCount2 And intCount1 Then
            intReneeCount = intReneeCount + 1
        End If

        lblBecca.Text = intBeccaCount
        lblJames.Text = intJamesCount
        lblRenee.Text = intReneeCount

        If intReneeCount = intYouWin Then
            lblRenee.Text = "You Win!!"
            If radRenee.Checked = True Then
                picHappy.Visible = True
                picSad.Visible = False
                picAward.Visible = False
                MessageBox.Show("You've Won!")
            Else
                picHappy.Visible = False
                picSad.Visible = True
                picAward.Visible = False
                MessageBox.Show("What A Loser")
            End If
            intJamesCount = 0
            intReneeCount = 0
            intBeccaCount = 0
        ElseIf intJamesCount = intYouWin Then
            lblJames.Text = "You Win!!"
            If radJames.Checked = True Then
                picHappy.Visible = True
                picSad.Visible = False
                picAward.Visible = False
                MessageBox.Show("You've Won!")
            Else
                picHappy.Visible = False
                picSad.Visible = True
                picAward.Visible = False
                MessageBox.Show("What A Loser")
            End If
            intJamesCount = 0
            intReneeCount = 0
            intBeccaCount = 0
        ElseIf intBeccaCount = intYouWin Then
            lblBecca.Text = "You Win!!"
            If radBecca.Checked = True Then
                picHappy.Visible = True
                picSad.Visible = False
                picAward.Visible = False
                MessageBox.Show("You've Won!")
            Else
                picHappy.Visible = False
                picSad.Visible = True
                picAward.Visible = False
                MessageBox.Show("What A Loser")
            End If
            intJamesCount = 0
            intReneeCount = 0
            intBeccaCount = 0
        End If
    End Sub

    Private Sub picJames_Click(sender As Object, e As EventArgs) Handles picJames.Click
        picJames.Left = 25
    End Sub

    Private Sub picRenee_Click(sender As Object, e As EventArgs) Handles picRenee.Click
        picRenee.Left = 25
    End Sub

End Class
