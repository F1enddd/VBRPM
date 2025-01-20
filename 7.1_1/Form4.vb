Public Class Form4


    Private Sub DepartamentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DepartamentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.User1DataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WorkersTableAdapter.Fill(Me.User1DataSet.Workers)
        Me.PostsTableAdapter.Fill(Me.User1DataSet.Posts)
        Me.DepartamentsTableAdapter.Fill(Me.User1DataSet.Departaments)

    End Sub

    Private Sub SelectionDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SelectionDataGridView.CellContentClick

    End Sub
End Class