Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intSpeed As Integer
        Dim intTime As Integer
        Dim intCount As Integer = 0
        Dim intDistance As Integer
        Dim strSpeed As Integer
        Dim strTime As Integer
        Dim strSpeedInfo As String = ("Vehicle Speed: " & intSpeed & " MPH")
        Dim strTimeInfo As String = ("Time Traveled: " & intTime & " hours")

        strSpeed = InputBox("Please input the Miles Per Hour speed of your vehicle.", "Input Needed", "60")
        strTime = InputBox("Please input the amount of time (in hours) that the vehicle was in motion.", "Input Needed", "6")

        
        If Integer.TryParse(strSpeed, intSpeed) Then
            If Integer.TryParse(strTime, intTime) Then
                lstOutput.Items.Add(strSpeedInfo)
                lstOutput.Items.Add(strTimeInfo)
                lstOutput.Items.Add("Hours         Distance Traveled")
                lstOutput.Items.Add("-------------------------------")
                Do Until intCount = intTime
                    intCount += 1
                    intDistance += intSpeed
                    lstOutput.Items.Add(intCount & "              " & intDistance)
                Loop
                lstOutput.Items.Add("Total Distance: " & intDistance)
            Else
                MessageBox.Show("Please input a numeral hour.")
            End If
        Else
            MessageBox.Show("Please input a numeral MPH.")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstOutput.Items.Clear()
    End Sub
End Class
