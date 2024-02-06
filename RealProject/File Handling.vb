'add nameSpaces

Imports System
Imports System.IO
Imports System.Collections

Module File_Handling

    Public Sub ReadFromDatabase(ofFile As OpenFileDialog, ByRef Data() As String, ByVal filename As String)

        Dim delimiters As Char() = {",", ";", vbCrLf}
        Dim file As New StreamReader(filename)


        Data = file.ReadToEnd.Split(delimiters)
        Data = Data.Select(Function(s) s.Trim()).Where(Function(s) Not String.IsNullOrEmpty(s)).ToArray()

        file.Close()

    End Sub

    Public Sub writeToFile(sfDeezNutz As SaveFileDialog, ByVal ID As Integer, ByVal username As String, ByVal password As String, ByVal filename As String)

        '1. open the file for writing
        'the FALSE means that we overwrite any existing file 
        'TRUE would mean we append on the end of an existing file 
        Dim file As StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(filename, True)

        '2. write to the file 
        file.WriteLine(ID & "," & username & "," & password)

        '3. close the file
        file.Close()

    End Sub
End Module
