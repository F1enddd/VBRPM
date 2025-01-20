Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "User1DataSet.Workers". При необходимости она может быть перемещена или удалена.
        Me.WorkersTableAdapter.Fill(Me.User1DataSet.Workers)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "User1DataSet.Posts". При необходимости она может быть перемещена или удалена.
        Me.PostsTableAdapter.Fill(Me.User1DataSet.Posts)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "User1DataSet.Departaments". При необходимости она может быть перемещена или удалена.
        Me.DepartamentsTableAdapter.Fill(Me.User1DataSet.Departaments)

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Me.Validate()
        Me.WorkersBindingSource.EndEdit()
        Me.DepartamentsBindingSource.EndEdit()
        Me.PostsBindingSource.EndEdit()
        Me.WorkersTableAdapter.Update(Me.User1DataSet.Workers)
        Me.DepartamentsTableAdapter.Update(Me.User1DataSet.Departaments)
        Me.PostsTableAdapter.Update(Me.User1DataSet.Posts)
        Form1.FillWorkersList()

    End Sub

    Private Sub GroupBoxWorkers_Enter(sender As Object, e As EventArgs) Handles GroupBoxWorkers.Enter

    End Sub
End Class