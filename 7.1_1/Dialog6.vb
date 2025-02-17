Imports System.Windows.Forms

Public Class Dialog6

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DepartamentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DepartamentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.User1DataSet)

    End Sub

    Private Sub Dialog6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "User1DataSet.Workers". При необходимости она может быть перемещена или удалена.
        Me.WorkersTableAdapter.Fill(Me.User1DataSet.Workers)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "User1DataSet.Departaments". При необходимости она может быть перемещена или удалена.
        Me.DepartamentsTableAdapter.Fill(Me.User1DataSet.Departaments)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
