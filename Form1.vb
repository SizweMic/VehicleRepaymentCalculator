Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmdMonths.Items.Add(36)
        cmdMonths.Items.Add(54)
        cmdMonths.Items.Add(72)


    End Sub

    Public Function calcInstall(ByVal decVehiclePrice As Decimal, ByVal decDeposit As Decimal,
                                ByVal Months As Integer, ByVal Interest As Decimal)

        Dim MonthlyRepayment As Decimal
        MonthlyRepayment = ((((decVehiclePrice - decDeposit) / Months) * Interest) _
            + (decVehiclePrice - decDeposit) / Months)
        Return "The monthly payment amount is: " & MonthlyRepayment.ToString("R###,###,###,##")

    End Function


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim decVehiclePrice As Decimal = CDec(txtVehiclePrice.Text)
        Dim decDeposit As Decimal = CDec(txtDeposit.Text)
        Dim Months = cmdMonths.SelectedItem()
        Dim interest = lblInterest.Text / 100

        lblDisplay.Text = calcInstall(decVehiclePrice, decDeposit, Months, interest)


    End Sub

    Private Sub cmdMonths_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmdMonths.SelectedIndexChanged

        If cmdMonths.SelectedIndex = 0 Then
            lblInterest.Text = 10
        ElseIf cmdMonths.SelectedIndex = 1 Then
            lblInterest.Text = 13
        ElseIf cmdMonths.SelectedIndex = 2 Then
            lblInterest.Text = 15
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtDeposit.Clear()
        txtVehiclePrice.Clear()
        lblDisplay.Text = ""
        lblInterest.Text = ""
        cmdMonths.Text = "Select months"


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub
End Class
