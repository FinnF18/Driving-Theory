Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form1

    Dim currentUser As String = ""
    Dim loggedIn As Boolean = False

    Public Structure usersRecord
        Dim userID As String
        Dim username As String
        Dim password As String
    End Structure

    Public Structure questionsRecord
        Dim quesion As String
        Dim answer1 As String
        Dim answer2 As String
        Dim answer3 As String
        Dim answer4 As String
        Dim correctAnswer As String
    End Structure

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        Call createAccount()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Call login()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click

        If loggedIn = False Then
            MsgBox("You are not logged-in")
        Else
            'Clear textbox
            txtOutput.Clear()

            'remove any user that is logged-in
            currentUser = ""
            loggedIn = False
            lblUsername.Text = ""
            txtOutput.Text = ("Logged-Out")
        End If

    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If loggedIn = False Then
            Form2.Show()
        Else
            Call practice()
        End If

    End Sub

    Public Sub createAccount()
        '2. Sub to create annacount for a new user with a name and password

        Dim users() As usersRecord = {}
        Dim newUsername As String = ""
        Dim newPassword As String = ""
        Dim confirmPassword As String = ""
        Dim usernameValid As Boolean = False
        Dim passwordValid As Boolean = False
        Dim allData() As String = {}
        Dim file As String = "C:\Users\finla\OneDrive\Documents\Project\rTest.csv"

        'Get data from database and sort into array of records
        Call ReadFromDatabase(OpenFileDialog1, allData, file)
        Call sortIntoUserRecord(allData, users)


        'Clear textbox
        txtOutput.Clear()

        'Create and validate new username
        newUsername = InputBox("Please create a username within 6-20 characters.")
        Do
            If Len(newUsername) < 6 Or Len(newUsername) > 20 Then
                MsgBox("Username must be within 6 to 20 characters")
                newUsername = InputBox("Please create a username within 6-20 characters.")
            Else
                usernameValid = True
                For i = 0 To UBound(users)
                    If newUsername = users(i).username Then
                        MsgBox("Username already in use.")
                        usernameValid = False

                        Exit For 'Exits fixed loop if userrname is found to be invalid
                    End If
                Next
            End If
        Loop Until usernameValid = True

        'Create and validate new password
        Do
            newPassword = InputBox("Please create a password.")
            confirmPassword = InputBox("Please confirm password.")
            If Len(newPassword) < 8 Or Len(newPassword) > 12 Then
                MsgBox("Password must be within 8 to 12 characters")
            ElseIf newPassword <> confirmPassword Then
                MsgBox("Passwords do not match")
            Else
                passwordValid = True
            End If
        Loop Until passwordValid = True

        'Send new account to database
        Dim newID As Integer = UBound(allData) / 3 + 1

        Call writeToFile(SaveFileDialog1, newID, newUsername, newPassword, file)

        currentUser = UBound(allData) / 3
        txtOutput.Text = ("Account sucessfully created." & vbCrLf & "Logged-In")
        lblUsername.Text = newUsername
        loggedIn = True
    End Sub
    Public Sub login()
        'Sub program for logging in existing users
        Dim allData() As String = {}
        Dim users() As usersRecord = {}
        Dim userPosition As Integer = -1
        Dim username As String = ""
        Dim password As String = ""
        Dim file As String = "C:\Users\finla\OneDrive\Documents\Project\rTest.csv"

        'Clear textbox
        txtOutput.Clear()

        If loggedIn = True Then
            MsgBox("You are already logged In. If you wish To change account, first sign out.")
        Else
            Call ReadFromDatabase(OpenFileDialog1, allData, file)
            Call sortIntoUserRecord(allData, users)
            Do
                username = InputBox("Please enter your username.")
                password = InputBox("Please enter your password.")
                For i = 0 To UBound(users)
                    If username = users(i).username Then
                        userPosition = i
                        Exit For ' Exits fixed loop when position of username is found
                    End If
                Next
                If userPosition < 0 Then
                    MsgBox("Username not recognised.")
                ElseIf users(userPosition).password <> password Then
                    MsgBox("Incorrect Password.")
                Else
                    currentUser = userPosition
                    txtOutput.Text = ("Successfully logged-In")
                    lblUsername.Text = users(currentUser).username
                    loggedIn = True
                End If
            Loop Until loggedIn = True
        End If
    End Sub

    Public Sub practice()
        'Sub program that dictates the driving theory test practice
        Dim allData() As String = {}
        Dim questions() As questionsRecord = {}
        Dim questionNumbers(19) As Integer
        Dim temp As Integer = 0
        Dim valid As Boolean = True

        'Reads the questions from the csv file and sorts it into the questions record structure
        Call ReadFromDatabase(OpenFileDialog1, allData, "C:\Users\finla\OneDrive\Documents\Project\rQuestions")
        Call sortIntoQuestionRecord(allData, questions)

        'Generate 20 different random numbers to find random questions

        Randomize()

        For i = 0 To 19
            Do
                temp = CInt(100 * Rnd())
                valid = True
                'check if number is already in the array
                For j = 0 To UBound(questionNumbers)
                    If temp = questionNumbers(j) Then
                        valid = False
                        Exit For
                    End If
                Next
            Loop While valid = False
            questionNumbers(i) = temp
        Next


    End Sub

    Public Sub sortIntoUserRecord(ByRef allData() As String, ByRef users() As usersRecord)
        'Sub program to sort the data from the database into the record structure

        Dim recordCounter As Integer = 0
        ReDim users(allData.Length \ 3 - 1)

        For i = 0 To UBound(allData) Step 3
            users(recordCounter).username = allData(i)
            users(recordCounter).username = allData(i + 1)
            users(recordCounter).password = allData(i + 2)
            recordCounter = recordCounter + 1
        Next

    End Sub

    Public Sub sortIntoQuestionRecord(ByRef allData() As String, ByRef questions() As questionsRecord)
        'sub to sort the    questions from the csv file into a record structure
        Dim recordCounter As Integer = 0
        ReDim questions(allData.Length \ 6 - 1)

        For i = 0 To UBound(allData) Step 6
            questions(recordCounter).quesion = allData(i)
            questions(recordCounter).answer1 = allData(i + 1)
            questions(recordCounter).answer2 = allData(i + 2)
            questions(recordCounter).answer3 = allData(i + 3)
            questions(recordCounter).answer4 = allData(i + 4)
            questions(recordCounter).correctAnswer = allData(i + 5)
            recordCounter = recordCounter + 1
        Next

    End Sub

End Class
