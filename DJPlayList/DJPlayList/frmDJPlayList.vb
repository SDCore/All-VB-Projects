' Michael Voell
' DJ Playlist
' 2/11/2016
' Purpose: To display songs in a playlist based on what genre is chosen.

' --TODO--
' On open, the app reads the values from the song list names songs.txt
'  songs.txt includes song titles, genre, and length of each song
' A drop down list of the genres is available to select a music genre and dispaly songs of that type
' The user can select the Display Song List menu item to open a second form
'  The second form displays the choice of displaying the playlist in the present play order or a sorted song order
' Clear Button
' Exit Button

Option Strict On

Public Class frmDJPlayList

    Private Sub frmDJPlayList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Variables
        Dim strFilePath As String = "E:\Advanced VB\DJPlayList\DJPlayList\songs.txt"
        Dim strFileError As String = "File not found. Please try again."
        Dim strFileErrorTitle As String = "File Error"
        Dim objReader As IO.StreamReader
        Dim intCount As Integer
        Dim intFill As Integer
        Dim strSongGenre(intCount) As String
        Dim i As Integer = 0

        ' Finding the file
        If IO.File.Exists(strFilePath) Then
            ' Opening the text file
            objReader = IO.File.OpenText(strFilePath)
            Do Until objReader.Peek = -1
                ReDim Preserve strSongGenre(i)
                strSongGenre(i) = objReader.ReadLine
                cboMusicGenre.Items.Add(strSongGenre(i))
                i += 1
            Loop
        Else
            MsgBox(strFileError, , strFileErrorTitle)
            Close()
        End If
    End Sub

    Private Sub btnShowList_Click(sender As System.Object, e As System.EventArgs) Handles btnShowList.Click

    End Sub

    Private Sub DisplaySongListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DisplaySongListToolStripMenuItem.Click

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        lstSelectedSongs.Items.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

End Class
