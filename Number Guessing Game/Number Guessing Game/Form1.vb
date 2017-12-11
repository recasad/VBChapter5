Public Class Form1
    Dim intCount As Integer
    Dim rand As New Random
    Dim intNumber As Integer = rand.Next(101)
    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        intCount += 1
        Dim intGuess As Integer
        If Integer.TryParse(txtGuess.Text, intGuess) Then
            If intGuess = intNumber Then
                If intCount < 5 Then
                    MessageBox.Show("Okay God, it's all fun and games but shouldn't you be running the world?? It took you " & intCount & " tries.")
                ElseIf intCount < 20 Then
                    MessageBox.Show("You didn't fail! I'm suprised! Don't worry, it still took you " & intCount & " tries!")
                Else
                    MessageBox.Show("It took you " & intCount & " tries to get this?? You might as well have failed.")
                End If
                lblResult.Text = String.Empty

            ElseIf intGuess > intNumber Then
                lblResult.Text = ("Try a bit smaller.")
            ElseIf intGuess < intNumber Then
                lblResult.Text = ("Try a bit bigger.")
            End If
        Else
            MessageBox.Show("Please pick an integer numeric number dummy.")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs)
        lblResult.Text = String.Empty
        txtGuess.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
