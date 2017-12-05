Public Class Form1
    Sub calcSideC(ByVal ASide As Double, ByVal Bside As Double)
        Dim Cside As Double
        Cside = Math.Sqrt(ASide * ASide + Bside * Bside)
        txtC.Text = Cside.ToString
    End Sub
    Sub calcSideB(ByVal ASide As Double, ByVal Cside As Double)
        Dim BSide As Double
        BSide = Math.Sqrt(Cside * Cside - ASide * ASide)
        txtB.Text = BSide.ToString
    End Sub
    Sub calcSideA(ByVal bSide As Double, ByVal Cside As Double)
        Dim ASide As Double
        ASide = Math.Sqrt(Cside * Cside - bSide * bSide)
        txtA.Text = ASide.ToString
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Dim result As Double
        If radC.Checked = True Then
            calcSideC(CDbl(txtA.Text), CDbl(txtB.Text))
        ElseIf radA.Checked = True Then
            calcSideA(CDbl(txtB.Text), CDbl(txtC.Text))
        ElseIf radB.Checked = True Then
            calcSideB(CDbl(txtA.Text), CDbl(txtC.Text))
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtA.Clear()
        txtB.Clear()
        txtC.Clear()
    End Sub
End Class
