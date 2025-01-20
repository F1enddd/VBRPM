Public Class Form5

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "User1DataSet.Posts". При необходимости она может быть перемещена или удалена.
        Me.PostsTableAdapter.Fill(Me.User1DataSet.Posts)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "User1DataSet.Departaments". При необходимости она может быть перемещена или удалена.
        Me.DepartamentsTableAdapter.Fill(Me.User1DataSet.Departaments)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "User1DataSet.Workers". При необходимости она может быть перемещена или удалена.
        Me.WorkersTableAdapter.Fill(Me.User1DataSet.Workers)

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Me.Validate()
        Me.WorkersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.User1DataSet)
    End Sub
End Class