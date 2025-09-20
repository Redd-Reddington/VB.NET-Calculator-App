Public Class Form1


    Dim FirstNumber As Integer
    Dim SecondNumber As Integer
    Dim Result As Integer


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FirstNumber = Integer.Parse(txtNum1.Text)
        SecondNumber = Integer.Parse(txtNum2.Text)

        Result = FirstNumber + SecondNumber

        lblResults.Text = Result.ToString()

    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        FirstNumber = Integer.Parse(txtNum1.Text)
        SecondNumber = Integer.Parse(txtNum2.Text)

        Result = FirstNumber - SecondNumber

        lblResults.Text = Result.ToString()

    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        FirstNumber = Integer.Parse(txtNum1.Text)
        SecondNumber = Integer.Parse(txtNum2.Text)

        Result = FirstNumber * SecondNumber

        lblResults.Text = Result.ToString()

    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        FirstNumber = Integer.Parse(txtNum1.Text)
        SecondNumber = Integer.Parse(txtNum2.Text)
        Dim Result As Decimal

        Result = FirstNumber / SecondNumber

        lblResults.Text = Result.ToString()

    End Sub


End Class
