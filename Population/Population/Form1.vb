Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblOrgansims As Double
        Dim dblIncrease As Double
        Dim intDays As Integer
        Dim dblResult As Double
        Dim strOrganisms As String
        Dim strIncrease As String
        Dim strDays As String
        Dim intCount As Integer = 0

        strOrganisms = cboOrganisms.Text
        strIncrease = txtIncrease.Text
        strDays = cboDays.Text

        If Double.TryParse(strOrganisms, dblOrgansims) Then
            If Double.TryParse(strIncrease, dblIncrease) Then
                If Integer.TryParse(strDays, intDays) Then
                    lstOutput.Items.Add("Day           Approximate Population")
                    lstOutput.Items.Add("---------------------------------------------")
                    dblIncrease = (dblIncrease / 100) + 1
                    Do Until intCount = intDays
                        intCount += 1
                        If intCount = 1 Then
                            lstOutput.Items.Add(intCount & "              " & dblOrgansims)
                        ElseIf intCount < 10 And intCount > 1 Then
                            dblOrgansims *= dblIncrease
                            lstOutput.Items.Add(intCount & "              " & dblOrgansims)
                        ElseIf intCount >= 10 Then
                            dblOrgansims *= dblIncrease
                            lstOutput.Items.Add(intCount & "            " & dblOrgansims)
                        End If
                    Loop
                End If
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cboDays.SelectedIndex = -1
        cboOrganisms.SelectedIndex = -1
        txtIncrease.Clear()
        lstOutput.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
