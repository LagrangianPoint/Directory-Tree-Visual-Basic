
Imports System.IO

''' <summary>
''' This class contains directory helper functions
''' 
''' Based from: http://www.dotnetperls.com/recursive-file-directory-vbnet
''' </summary>
''' <remarks></remarks>
Public Class FileHelper

    ''' <summary>
    ''' Returns a list of all the files found in a directory recursively.
    ''' </summary>
    ''' <param name="strInitialDir">Initial directory to start the scan</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetFilesRecursive(ByVal strInitialDir As String) As List(Of String)
        ' This list stores the files found
        Dim lstFiles As New List(Of String)

        ' This stack stores the directories to be inspected
        Dim stack As New Stack(Of String)

        ' Add the initial directory
        stack.Push(strInitialDir)

        ' Continue processing each stacked directory
        Do While (stack.Count > 0)
            ' Get the top directory
            Dim dir As String = stack.Pop()
            Try
                ' Add all immediate file paths
                lstFiles.AddRange(Directory.GetFiles(dir, "*.*"))

                ' Extracting all the directories from the current directory
                Dim directoryName As String
                For Each directoryName In Directory.GetDirectories(dir)
                    stack.Push(directoryName)
                Next

            Catch ex As Exception
            End Try
        Loop

        Return lstFiles
    End Function

    Public Shared Function RemoveBasePath(strFile, strPath) As String
        Return Replace(strFile, strPath & "\", "")
    End Function

End Class
