Imports System.Windows.Forms

Public Class Dialog2
    Private AddOrChange As Boolean = False
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim Rows() As DataRow
        Dim DepartmentID, PostID As ULong
        Rows = Form1.User1DataSet.Posts.Select("Title = '" & PostSelect.Text & "'")
        PostID = Rows(0)("ID")

        Rows = Form1.User1DataSet.Departaments.Select("Title = '" & DepartamentsSelect.Text & "'")
        DepartmentID = Rows(0)("ID")

        If AddOrChange = False Then
            Form1.WorkersTableAdapter.Insert(FIOText.Text, BirthdayDate.Value.Date, DepartmentID, PostID, "")
        End If

        Form1.WorkersTableAdapter.Fill(Form1.User1DataSet.Workers)

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FillDepartamentsList()
        Dialog4.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FillPostsList()
        Dialog3.ShowDialog()
    End Sub
    Public Sub FillDepartamentsList()
        With Dialog4
            Form1.DepartamentsTableAdapter.Fill(Form1.User1DataSet.Departaments)
            .DepartamentsListView.Items.Clear()
            For Each Row As DataRow In Form1.User1DataSet.Departaments.Rows
                Dim it As New ListViewItem()
                it.Text = Row(1)
                .DepartamentsListView.Items.Add(it)
            Next Row
        End With
    End Sub
    Public Sub FillPostsList()
        With Dialog3
            Form1.PostsTableAdapter.Fill(Form1.User1DataSet.Posts)
            .PostsListView.Items.Clear()
            For Each Row As DataRow In Form1.User1DataSet.Posts.Rows
                Dim it As New ListViewItem()
                it.Text = Row(1)
                .PostsListView.Items.Add(it)
            Next Row
        End With
    End Sub

    Private Sub Dialog2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class