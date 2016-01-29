﻿Public Class frmWriteToTextFile

    Private Sub btnShowOutput_Click(sender As System.Object, e As System.EventArgs) Handles btnShowOutput.Click
        ' Parallel arrays
        Dim strNames(5) As String
        Dim intID(5) As Integer

        ' Creates a reference variable called objWriter, instantiates a StreamWriter object
        ' by passing the location of the file, then assigns the object to the objWriter variable
        Dim objWriter As New IO.StreamWriter("E:\Advanced VB\WritingToTextFileDemo\WritingToTextFileDemo\roster.txt")

        For intCount = 0 To strNames.Length - 1
            strNames(intCount) = InputBox("Enter Name " & (intCount + 1), "Enter Information", "")
            intID(intCount) = InputBox("Enter ID # for Student " & (intCount + 1), "Enter Information", "")

            If IO.File.Exists("E:\Advanced VB\WritingToTextFileDemo\WritingToTextFileDemo\roster.txt") Then
                objWriter.WriteLine(strNames(intCount)) ' Writes the array element of the Name to the text file
                objWriter.WriteLine(intID(intCount)) ' Writes the array element of the ID to the text file
            Else
                MsgBox("File not available. Please re-run program when it is available.")
                Close()
            End If

        Next

        objWriter.Close()

        ' Read from array
        Dim objReader As IO.StreamReader

        If IO.File.Exists("E:\Advanced VB\WritingToTextFileDemo\WritingToTextFileDemo\roster.txt") Then
            objReader = IO.File.OpenText("E:\Advanced VB\WritingToTextFileDemo\WritingToTextFileDemo\roster.txt")
            Do While objReader.Peek <> -1
                lstOutput.Items.Add(objReader.ReadLine())
            Loop

        Else
            MsgBox("File is not available. Please re-run program when it is available.")
            Close()
        End If

        objReader.Close()

    End Sub
End Class
