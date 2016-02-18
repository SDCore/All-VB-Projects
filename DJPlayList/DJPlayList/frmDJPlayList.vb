﻿' Michael Voell
' DJ Playlist
' 2/11/2016
' Purpose: To display songs in a playlist based on what genre is chosen.

' --TODO--
' On open, the app reads the values from the song list names songs.txt
'  songs.txt includes song titles, genre, and length of each song
' A drop down list of the genres is available to select a music genre and display songs of that type
' The user can select the Display Song List menu item to open a second form
'  The second form displays the choice of displaying the playlist in the present play order or a sorted song order

Option Strict On

Public Class frmDJPlayList

    Private _intSizeOfArray As Integer = 52
    Private _strSongNames(_intSizeOfArray) As String

    Private Sub frmDJPlayList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Variables
        Dim objReader As IO.StreamReader
        Dim strFile As String = "E:\Advanced VB\DJPlayList\DJPlayList\songs.txt"
        Dim strFileError As String = "File not found. Please try again."
        Dim strFileErrorTitle As String = "File Error"
        Dim intCount As Integer = 0
        Dim strSongGenre(51) As String

        If IO.File.Exists(strFile) Then
            objReader = IO.File.OpenText(strFile)
            Do Until objReader.Peek = -1
                Dim tempName, tempDuration As String
                ReDim Preserve strSongGenre(intCount)
                tempName = objReader.ReadLine
                strSongGenre(intCount) = objReader.ReadLine
                tempDuration = objReader.ReadLine
                cboMusicGenre.Items.Add(strSongGenre(intCount))
                intCount += 1
            Loop
        Else
            MsgBox(strFileError, , strFileErrorTitle)
        End If
    End Sub

    Private Sub btnShowList_Click(sender As System.Object, e As System.EventArgs) Handles btnShowList.Click

    End Sub

    Private Sub DisplaySongListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DisplaySongListToolStripMenuItem.Click

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        lstSelectedSongs.Items.Clear()
        cboMusicGenre.Text = "Select a Genre"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

End Class
