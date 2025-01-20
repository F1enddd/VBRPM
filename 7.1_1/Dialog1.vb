Imports System.Windows.Forms

Public Class Dialog1
    Public AddOrChange As Boolean
    Public OldRowID As ULong
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click, OK_Button.Click
        Dim Rows() As DataRow
        Dim DepartamentID, PostID As ULong
        Rows = Form1.User1DataSet.Posts.Select("Title = '" & PostSelect.Text & "'")

        If Rows.Length = 0 Then
            Form1.PostsTableAdapter.Insert(PostSelect.Text)
            Form1.PostsTableAdapter.Fill(Form1.User1DataSet.Posts)

            Rows = Form1.User1DataSet.Posts.Select("Title = '" & PostSelect.Text & "'")
            PostID = Rows(0)("ID")
        Else
            PostID = Rows(0)("ID")
        End If

        Rows = Form1.User1DataSet.Departaments.Select("Title = '" & DepartamentsSelect.Text & "'")

        If Rows.Length = 0 Then
            Form1.DepartamentsTableAdapter.Insert(DepartamentsSelect.Text)
            Form1.DepartamentsTableAdapter.Fill(Form1.User1DataSet.Departaments)

            Rows = Form1.User1DataSet.Departaments.Select("Title = '" & DepartamentsSelect.Text & "'")
            DepartamentID = Rows(0)("ID")
        Else
            DepartamentID = Rows(0)("ID")
        End If

        If AddOrChange = False Then
            Form1.WorkersTableAdapter.Insert(FIOText.Text, BirthdayDate.Value.Date, DepartamentID, PostID)
        Else
            Dim OldWorkersRow As DataRow = Form1.User1DataSet.Workers.Select("ID = '" & OldRowID.ToString & "'")(0)
            Form1.WorkersTableAdapter.Update(FIOText.Text, BirthdayDate.Value.Date, DepartamentID, PostID, OldWorkersRow(0), OldWorkersRow(1), OldWorkersRow(2), OldWorkersRow(3), OldWorkersRow(4))
        End If
        Form1.WorkersTableAdapter.Fill(Form1.User1DataSet.Workers)

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonAddDepartaments.Click
        'Dialog2.FillDepartamentsList()
        'Dialog4.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonAddPosts.Click
        'Dialog2.FillPostsList()
        'Dialog3.ShowDialog()
    End Sub

End Class