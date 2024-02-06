Public Class Form2
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        'Continues to the practice test without logging in
        Me.Hide()
        Dim form1Instance As Form1 = DirectCast(Application.OpenForms("Form1"), Form1) 'finds form 1
        form1Instance.practice()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'send the user to log in before continuing to do the practice quiz
        Me.Hide()
        Dim form1Instance As Form1 = DirectCast(Application.OpenForms("Form1"), Form1) 'finds form 1
        form1Instance.login() 'calls the login sub from form1
        form1Instance.practice() 'call the practtice sub from form1
    End Sub
    Private Sub btnNewAcc_Click(sender As Object, e As EventArgs) Handles btnNewAcc.Click
        'sends the user to create a new account
        Me.Hide()
        Dim form1Instance As Form1 = DirectCast(Application.OpenForms("Form1"), Form1) 'finds form 1
        form1Instance.createAccount() 'calls the create account sub in form1
    End Sub
End Class