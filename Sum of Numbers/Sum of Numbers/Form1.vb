Public Class SumOfNumbers
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim intCount As Integer = 0
        Dim intInput As Integer
        Dim strInput As String
        Dim intFinalNumber As Integer

        strInput = InputBox("Enter a positive integer value.", "Input Needed", "10")

        If Integer.TryParse(strInput, intInput) Then
            If intInput < 0 Then
                MessageBox.Show("Please input positive number.")
            Else
                Do Until intCount = intInput
                    intCount += 1
                    intFinalNumber += intCount
                Loop
                MessageBox.Show("The sum of numbers 1 through " & intInput & " is " & intFinalNumber)
            End If
        Else
            MessageBox.Show("Please input a valid number.")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
