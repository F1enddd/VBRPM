Imports System.Windows.Forms

Public Class Dialog8

    Public Sub FillWorkersList()
        Me.DataTable1TableAdapter.Fill(Me.DataSet2.DataTable1)

        SelectListView.Items.Clear()
        Dim items(4) As String
        For Each Row As DataRow In
            Me.DataSet2.DataTable1.Rows
            items(1) = Row(1)
            items(2) = Row(2)
            items(3) = Row(3)
            items(4) = Row(4)
            Dim it As New ListViewItem()
            it.Text = Row(0)
            it.SubItems.AddRange(items)
            SelectListView.Items.Add(it)

        Next Row



    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillWorkersList()
    End Sub
End Class
