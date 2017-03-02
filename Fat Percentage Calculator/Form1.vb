Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare constants
        Dim intCALORIES_PER_FAT_GRAM As Integer = 9

        'declare variables
        Dim dblPercentFat As Double
        Dim dblCalories As Double
        Dim dblFatGrams As Double

        If Double.TryParse(txtCalories.Text, dblCalories) Then
            If Double.TryParse(txtFatGrams.Text, dblFatGrams) Then
                dblPercentFat = (dblFatGrams * intCALORIES_PER_FAT_GRAM) / dblCalories
                lblPercentFat.Text = dblPercentFat.ToString("p")
            Else
                MessageBox.Show("You must enter a number for fat grams")
            End If
        Else
            MessageBox.Show("you must enter a number for calories.")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear the form for another calculation
        txtCalories.Clear()
        txtFatGrams.Clear()
        lblPercentFat.Text = String.Empty

        txtCalories.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' leave the program
        Me.Close()
    End Sub
End Class
