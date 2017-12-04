Public Class CoinFlip
    Dim intHeadScore As Integer
    Dim intTailsScore As Integer
    Private Sub btnFlip_Click(sender As Object, e As EventArgs) Handles btnFlip.Click
        Dim rand As New Random

        If rand.Next(2) = 0 Then
            picHeads.Visible = True
            picTails.Visible = False
            intHeadScore += 1
        Else
            picHeads.Visible = False
            picTails.Visible = True
            intTailsScore += 1
        End If
        lblHeads.Text = intHeadScore
        lblTails.Text = intTailsScore
    End Sub
End Class
