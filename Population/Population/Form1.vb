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
                    lstOutput.Items.Add("------------------------------------")
                    Do Until intCount = intDays
                        dblOrgansims *= (dblIncrease / 100)
                        lstOutput.Items.Add(intCount & "              " & dblOrgansims)
                        dblResult = dblOrgansims
                    Loop
                End If
            End If
        End If
    End Sub
End Class
