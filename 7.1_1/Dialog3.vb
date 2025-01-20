Imports System.Windows.Forms

Public Class Dialog3

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddPostsButton.Click
        Dim Rows() As DataRow
        Dim PostID As ULong
        Rows = Form1.User1DataSet.Posts.Select("Title = '" & AddPosts.Text & "'")

        If Rows.Length = 0 Then
            Form1.PostsTableAdapter.Insert(AddPosts.Text)
            Form1.PostsTableAdapter.Fill(Form1.User1DataSet.Posts)

            Rows = Form1.User1DataSet.Posts.Select("Title = '" & AddPosts.Text & "'")
            PostID = Rows(0)("ID")
        Else
            PostID = Rows(0)("ID")
        End If

        Form1.PostsTableAdapter.Fill(Form1.User1DataSet.Posts)
        Dialog2.FillPostsList()
        Dialog2.PostSelect.Text = " "
        Dialog2.PostSelect.Items.Clear()
        For Each Row As DataRow In
                Form1.User1DataSet.Posts.Rows
            Dialog2.PostSelect.Items.Add(Row("Title"))
        Next Row
    End Sub
End Class
