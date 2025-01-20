Public Class Form2
    Private Sub DepartamentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DepartamentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.User1DataSet1)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "User1DataSet1.Workers". При необходимости она может быть перемещена или удалена.
        Me.WorkersTableAdapter.Fill(Me.User1DataSet1.Workers)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "User1DataSet1.Posts". При необходимости она может быть перемещена или удалена.
        Me.PostsTableAdapter.Fill(Me.User1DataSet1.Posts)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "User1DataSet1.Departaments". При необходимости она может быть перемещена или удалена.
        Me.DepartamentsTableAdapter.Fill(Me.User1DataSet1.Departaments)

    End Sub
End Class