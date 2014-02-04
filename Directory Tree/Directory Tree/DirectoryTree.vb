Imports System.IO
Imports System.Text

Public Class btnScan

    Private strSelectedDirectory As String

    Public Property SelectedDirectory() As String
        Get
            Return strSelectedDirectory
        End Get
        Set(value As String)
            strSelectedDirectory = value
            lblSelectedDir.Text = value
            lblSelectedDir.Refresh()
        End Set
    End Property

    Public ReadOnly Property OutputFile() As String
        Get
            Return txtFileName.Text & "." & cbxOutputFormat.SelectedItem.ToString.ToLower
        End Get
    End Property

    Private objFileBrowser As FolderBrowserDialog

    Private Sub DirectoryTree_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbxOutputFormat.SelectedIndex = 0
        SelectedDirectory = Directory.GetCurrentDirectory()
    End Sub

    Private Sub btnSelectDir_Click(sender As Object, e As EventArgs) Handles btnSelectDir.Click
        objFileBrowser = New FolderBrowserDialog()
        objFileBrowser.SelectedPath = Directory.GetCurrentDirectory()
        If objFileBrowser.ShowDialog() = DialogResult.OK Then
            SelectedDirectory = objFileBrowser.SelectedPath
        End If
    End Sub

    Public Sub ScanDirectory()
        Dim lstFiles As List(Of String)
        Dim stbFound As New StringBuilder

        lstFiles = FileHelper.GetFilesRecursive(SelectedDirectory)
        For Each strFile As String In lstFiles
            Dim strCleanFile As String
            strCleanFile = FileHelper.RemoveBasePath(strFile, SelectedDirectory)
            stbFound.Append(strCleanFile)
            stbFound.AppendLine()
        Next

        My.Computer.FileSystem.WriteAllText(OutputFile, stbFound.ToString, False)
        'MessageBox.Show("Data was saved in: " & OutputFile, "Directory Tree", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Process.Start(OutputFile)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ScanDirectory()
    End Sub
End Class
