Public Class Form3
    ' Form to get the answer for each question from the user
    Dim userGuess As String = ""

    'When each button is clicked it 
    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        userGuess = "A"
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        userGuess = "B"
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        userGuess = "C"
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        userGuess = "D"
    End Sub

    Public Function practise() As String
        Return
    End Function
End Class