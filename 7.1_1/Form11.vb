Public Class Form11
    Public DialogResOk As Boolean
    Private Sub SelectImageButton_Click(sender As Object, e As EventArgs) Handles SelectImageButton.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            DialogResOk = True
            AddListFiles(FolderBrowserDialog1.SelectedPath)
        End If
    End Sub

    Private Sub AddListFiles(ByVal FolderPath As String)
        FilesListBox.Items.Clear()
        Dim FileNames = My.Computer.FileSystem.GetFiles(IO.Directory.GetCurrentDirectory() & "\Picture\", FileIO.SearchOption.SearchTopLevelOnly, "*.*")
        For Each fileName As String In FileNames
            FilesListBox.Items.Add(fileName)
        Next


        If DialogResOk = True Then
            FileNames = My.Computer.FileSystem.GetFiles(FolderPath, FileIO.SearchOption.SearchTopLevelOnly, "*.jp*g")
            For Each fileName As String In FileNames
                FilesListBox.Items.Add(fileName)
            Next

            FileNames = My.Computer.FileSystem.GetFiles(FolderPath, FileIO.SearchOption.SearchTopLevelOnly, "*.png")
            For Each fileName As String In FileNames
                FilesListBox.Items.Add(fileName)
            Next

            FileNames = My.Computer.FileSystem.GetFiles(FolderPath, FileIO.SearchOption.SearchTopLevelOnly, "*.bmp")
            For Each fileName As String In FileNames
                FilesListBox.Items.Add(fileName)
            Next

            FileNames = My.Computer.FileSystem.GetFiles(FolderPath, FileIO.SearchOption.SearchTopLevelOnly, "*.gif")
            For Each fileName As String In FileNames
                FilesListBox.Items.Add(fileName)
            Next
            DialogResOk = False
        End If
    End Sub

    Private Sub FilesListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FilesListBox.SelectedIndexChanged
        If Not FilesListBox.SelectedItem = Nothing Then

            Dim FilePath = FilesListBox.SelectedItem.ToString()
            Try
                FileNameTB.Text = My.Computer.FileSystem.GetFileInfo(FilePath).Name
                PicBoxAOC.Image = Image.FromFile(FilesListBox.SelectedItem.ToString())
            Catch
                FileNameTB.Text = "Файл не найден"
                PicBoxAOC.Image = Image.FromFile(IO.Directory.GetCurrentDirectory & "\Picture\notexist.png")
            End Try
        End If
    End Sub

    Private Sub SetImageButton_Click(sender As Object, e As EventArgs) Handles SetImageButton.Click
        If FilesListBox.SelectedItem Is Nothing Then
            MessageBox.Show("Изображение не выбрано!")
            Exit Sub
        End If

        Dim FilePath = FilesListBox.SelectedItem.ToString()

        If My.Computer.FileSystem.FileExists(FilePath) = False Then
            MessageBox.Show("Файл не найден: " + FilePath)
            Exit Sub
        End If

        Dim sNameFile As String = My.Computer.FileSystem.GetFileInfo(FilePath).Name

        Dim SaveFolderPic As String = (IO.Directory.GetCurrentDirectory() & "\Picture\")

        Dim SNewFilePath As String = SaveFolderPic & Format(DateTime.Now, "dd.MM.yyyy_HH.mm.ss") & sNameFile

        Dim DS As String = IO.Directory.GetCurrentDirectory() & "\Picture\" & sNameFile

        Try
            If Not FilePath = (DS) Then
                My.Computer.FileSystem.CopyFile(FilePath, SNewFilePath)
                Dialog1.PicBoxAOC.Image = Image.FromFile(SNewFilePath)
                Dialog1.FileNameTB.Text = My.Computer.FileSystem.GetFileInfo(SNewFilePath).Name
            Else
                Dialog1.PicBoxAOC.Image = Image.FromFile(FilePath)
                Dialog1.FileNameTB.Text = My.Computer.FileSystem.GetFileInfo(FilePath).Name
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



        Me.Close()
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class