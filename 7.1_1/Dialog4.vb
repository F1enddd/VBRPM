Imports System.Windows.Forms

Public Class Dialog4

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Rows() As DataRow
            Dim DepartamentID As ULong
            Rows = Form1.User1DataSet.Departaments.Select("Title = '" & AddDepartaments.Text & "'")
            If Rows.Length = 0 Then
                Form1.DepartamentsTableAdapter.Insert(AddDepartaments.Text)
                Form1.DepartamentsTableAdapter.Fill(Form1.User1DataSet.Departaments)

                Rows = Form1.User1DataSet.Departaments.Select("Title = '" & AddDepartaments.Text & "'")
                DepartamentID = Rows(0)("ID")
            Else
                DepartamentID = Rows(0)("ID")
            End If

            Form1.DepartamentsTableAdapter.Fill(Form1.User1DataSet.Departaments)
            Dialog2.FillDepartamentsList()
            Dialog2.DepartamentsSelect.Text = " "
            Dialog2.DepartamentsSelect.Items.Clear()
            For Each Row As DataRow In
            Form1.User1DataSet.Departaments.Rows
                Dialog2.DepartamentsSelect.Items.Add(Row("Title"))
            Next Row
        Catch Ex As Exception
            MessageBox.Show("Ошибка: " & Ex.Message)
        End Try
    End Sub

    Private Sub Dialog4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
