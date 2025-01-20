Public Class Form1
    Dim DataSelectTable As New DataTable

    Dim LastSelectedItem As ListViewItem

    Public Sub FillWorkersList()
        Me.WorkersTableAdapter.Fill(Me.User1DataSet.Workers)
        Me.PostsTableAdapter.Fill(Me.User1DataSet.Posts)
        Me.DepartamentsTableAdapter.Fill(Me.User1DataSet.Departaments)
        For Each RowCB As DataRow In Me.User1DataSet.Departaments.Rows
            ComboBoxFilterDepartaments.Items.Add(RowCB("Title"))
        Next RowCB
        For Each RowCB As DataRow In Me.User1DataSet.Posts.Rows
            ComboBoxFilterPosts.Items.Add(RowCB("Title"))
        Next RowCB
        WorkersListView.Items.Clear()
        Dim items(4) As String
        Dim TempRow As DataRow
        For Each Row As DataRow In
            Me.User1DataSet.Workers.Rows
            items(1) = Row(1)
            items(2) = Row(2)
            TempRow = Row.GetParentRow("FK_Workers_Departaments")
            items(3) = TempRow(1)
            TempRow = Row.GetParentRow("FK_Workers_Posts")
            items(4) = TempRow(1)
            Dim it As New ListViewItem()
            it.Text = Row(0)
            it.SubItems.AddRange(items)
            WorkersListView.Items.Add(it)

        Next Row



    End Sub
    Public Sub Selection(SQLCommandSTR As String)
        Dim cn As New SqlClient.SqlConnection
        cn.ConnectionString = My.Settings.WorkersConnectionString
        cn.Open()
        Dim SQLCommand As New SqlClient.SqlCommand(SQLCommandSTR, cn)
        Dim da As New SqlClient.SqlDataAdapter

        Dim DataSQLTable As New DataTable
        da.SelectCommand = SQLCommand
        da.Fill(DataSQLTable)

        cn.Close()

        Form4.SelectionDataGridView.DataSource = DataSQLTable
        Form4.ShowDialog()
    End Sub
    Private Sub OutSQL()
        Dim cn As New SqlClient.SqlConnection
        cn.ConnectionString = My.Settings.WorkersConnectionString
        cn.Open()
        Dim SQL As New SqlClient.SqlCommand("SELECT " & "Workers.FIO, Departaments.Title As DTitle, " & "Posts.Title As PTitle FROM Posts INNER JOIN " & "(Departaments INNER JOIN Workers ON " & "Departaments.ID = Workers.DepartamentID) ON " & "Posts.ID = Workers.PostID", cn)
        Dim da As New SqlClient.SqlDataAdapter

        Dim DataSQLTable As New DataTable
        da.SelectCommand = SQL
        da.Fill(DataSQLTable)

        cn.Close()

        Dim RowCB As DataRow

        For Each RowCB In DataSQLTable.Rows
            MsgBox(RowCB("FIO") & " " & RowCB("DTitle") & " " & RowCB("PTitle"))
        Next RowCB
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "User1DataSet.Workers". При необходимости она может быть перемещена или удалена.
        Me.WorkersTableAdapter.Fill(Me.User1DataSet.Workers)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "User1DataSet.Posts". При необходимости она может быть перемещена или удалена.
        Me.PostsTableAdapter.Fill(Me.User1DataSet.Posts)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "User1DataSet.Departaments". При необходимости она может быть перемещена или удалена.
        Me.DepartamentsTableAdapter.Fill(Me.User1DataSet.Departaments)
        FillWorkersList()
    End Sub

    Private Sub ButtonGridView_Click(sender As Object, e As EventArgs) Handles ButtonGridView.Click
        Dim cn As New SqlClient.SqlConnection
        cn.ConnectionString = My.Settings.WorkersConnectionString
        cn.Open()
        Dim SQL As New SqlClient.SqlCommand("SELECT " & "Workers.FIO As ФИО, Departaments.Title As Название_Отдела, " & "Posts.Title As Название_Должности FROM Posts INNER JOIN " & "(Departaments INNER JOIN Workers ON " & "Departaments.ID = Workers.DepartamentID) ON " & "Posts.ID = Workers.PostID", cn)
        Dim da As New SqlClient.SqlDataAdapter

        Dim DataSQLTable As New DataTable
        da.SelectCommand = SQL
        da.Fill(DataSQLTable)

        cn.Close()

        Form2.OutDataGridView.DataSource = DataSQLTable
        Form2.ShowDialog()
    End Sub

    Private Sub ButtonSqlOut_Click(sender As Object, e As EventArgs) Handles ButtonSqlOut.Click
        OutSQL()
    End Sub

    Private Sub ЗавершениеРаботыToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗавершениеРаботыToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ПросмотрИИзменениеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПросмотрИИзменениеToolStripMenuItem.Click
        Form3.ShowDialog()
    End Sub

    Private Sub БухглатерыToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles БухглатерыToolStripMenuItem.Click
        Dim SqlCommand As String = "SELECT 
    Workers.ID, 
    Workers.FIO AS [ФИО], 
    Workers.Birthday AS [Дата рождения], 
    Departaments.Title AS [Отдел], 
    Posts.Title AS [Должность]
FROM 
    Workers 
JOIN 
    Posts  ON Workers.PostID = Posts.ID
JOIN 
    Departaments  ON Workers.DepartamentID = Departaments.ID
WHERE 
    Posts.Title = 'Бухгалтер'"
        Selection(SqlCommand)
    End Sub

    Private Sub ОКToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ОКToolStripMenuItem1.Click
        Dim SqlCommand As String = "SELECT 
    Workers.ID, 
    Workers.FIO AS [ФИО], 
    Workers.Birthday AS [Дата рождения], 
    Departaments.Title AS [Отдел], 
    Posts.Title AS [Должность]
FROM 
    Workers 
JOIN 
    Posts  ON Workers.PostID = Posts.ID
JOIN 
    Departaments  ON Workers.DepartamentID = Departaments.ID
WHERE 
    Posts.Title = 'Бухгалтер' AND 
    Departaments.Title = 'ОК';
"
        Selection(SqlCommand)
    End Sub

    Private Sub ИванToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ИванToolStripMenuItem1.Click
        Dim SqlCommand As String = "SELECT 
    Workers.ID, 
    Workers.FIO AS [ФИО], 
    Workers.Birthday AS [Дата рождения], 
    Departaments.Title AS [Отдел], 
    Posts.Title AS [Должность]
FROM 
    Workers 
JOIN 
    Posts ON Workers.PostID = Posts.ID
JOIN 
    Departaments  ON Workers.DepartamentID = Departaments.ID
WHERE 
    Posts.Title = 'Бухгалтер' AND 
    Workers.FIO LIKE '% Иван %'
"
        Selection(SqlCommand)
    End Sub

    Private Sub ИзменениеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ИзменениеToolStripMenuItem.Click
        Form5.ShowDialog()
    End Sub

    Private Sub ИзменениеToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ИзменениеToolStripMenuItem1.Click
        Form6.ShowDialog()
    End Sub

    Private Sub ИзменениеToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ИзменениеToolStripMenuItem2.Click
        Form7.ShowDialog()
    End Sub

    Private Sub ОтчётыToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОтчётыToolStripMenuItem.Click

    End Sub

    Private Sub DepartamentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DepartamentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.User1DataSet)

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        With Dialog1
            .AddOrChange = False
            .Text = "Добавление сотрудника"
            .FIOText.Text = " "
            .BirthdayDate.Value = DateTime.Now
            .PostSelect.Text = " "
            .PostSelect.Items.Clear()
            For Each Row As DataRow In
                    Me.User1DataSet.Posts.Rows
                .PostSelect.Items.Add(Row("Title"))
            Next Row

            .DepartamentsSelect.Text = " "
            .DepartamentsSelect.Items.Clear()

            For Each Row As DataRow In
                    Me.User1DataSet.Departaments.Rows
                .DepartamentsSelect.Items.Add(Row("Title"))
            Next Row
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                FillWorkersList()
            End If
        End With
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim Rows() As DataRow
        For Each item As ListViewItem In WorkersListView.CheckedItems
            Rows = User1DataSet.Workers.Select("ID ='" & item.Text & "'")
            WorkersTableAdapter.Delete(Rows(0)(0), Rows(0)(1), Rows(0)(2), Rows(0)(3), Rows(0)(4))
            item.Remove()

        Next item
        Me.WorkersTableAdapter.Fill(User1DataSet.Workers)
    End Sub

    Private Sub ButtonDialog2_Click(sender As Object, e As EventArgs) Handles ButtonDialog2.Click
        With Dialog2
            .Text = "Добавление сотрудника"
            .FIOText.Text = " "
            .BirthdayDate.Value = DateTime.Now
            .PostSelect.Text = " "
            .PostSelect.Items.Clear()
            For Each Row As DataRow In
                    Me.User1DataSet.Posts.Rows
                .PostSelect.Items.Add(Row("Title"))
            Next Row

            .DepartamentsSelect.Text = " "
            .DepartamentsSelect.Items.Clear()

            For Each Row As DataRow In
                    Me.User1DataSet.Departaments.Rows
                .DepartamentsSelect.Items.Add(Row("Title"))
            Next Row
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                FillWorkersList()
            End If
        End With
    End Sub

    Private Sub WorkersListView_MouseClick(sender As Object, e As MouseEventArgs) Handles WorkersListView.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ChangetoolStripMenuItem.Show(sender, e.X, e.Y)
        End If
    End Sub

    Private Sub WorkersListView_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles WorkersListView.ItemSelectionChanged
        LastSelectedItem = e.Item
    End Sub

    Private Sub ToolStripMenuItemEdit_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEdit.Click
        With Dialog1
            .Text = "Редактирование сотрудника"
            Dim CurrentWorkersRow As DataRow = User1DataSet.Workers.Select("ID = '" & LastSelectedItem.Text & "'")(0)
            .OldRowID = CurrentWorkersRow("ID")
            .AddOrChange = True
            .FIOText.Text = CurrentWorkersRow("FIO")
            .BirthdayDate.Value = CurrentWorkersRow("Birthday")
            .DepartamentsSelect.Text = CurrentWorkersRow.GetParentRow("FK_Workers_Departaments")("Title")
            .DepartamentsSelect.Items.Clear()
            For Each Row As DataRow In User1DataSet.Departaments.Rows
                .DepartamentsSelect.Items.Add(Row("Title"))
            Next Row
            .PostSelect.Text = CurrentWorkersRow.GetParentRow("FK_Workers_Posts")("Title")
            .PostSelect.Items.Clear()
            For Each Row As DataRow In User1DataSet.Posts.Rows
                .PostSelect.Items.Add(Row("Title"))
            Next Row
            .ShowDialog()
            If .DialogResult = Dialog1.DialogResult.OK Then
                FillWorkersList()
            End If

        End With
    End Sub

    Private Sub ComboBoxFilterDepartaments_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoxFilterDepartaments.SelectionChangeCommitted
        WorkersListView.Items.Clear()
        Dim Items(4) As String
        Dim TempRow As DataRow
        For Each Row As DataRow In Me.User1DataSet.Workers.Rows
            Dim RowFilterDepart As DataRow = User1DataSet.Departaments.Select("Title = '" & ComboBoxFilterDepartaments.SelectedItem & "'")(0)
            If Row("DepartamentID") = RowFilterDepart("ID") Then
                MsgBox(RowFilterDepart("ID"))
                Items(1) = Row(1)
                Items(2) = Row(2)
                TempRow = Row.GetParentRow("FK_Workers_Departaments")
                Items(3) = TempRow(1)
                TempRow = Row.GetParentRow("FK_Workers_Posts")
                Items(4) = TempRow(1)
                Dim it As New ListViewItem()
                it.Text = Row(0)
                it.SubItems.AddRange(Items)
                WorkersListView.Items.Add(it)
            End If
        Next Row
    End Sub

    Private Sub ButtonFiltersClear_Click(sender As Object, e As EventArgs) Handles ButtonFiltersClear.Click
        ComboBoxFilterDepartaments.Text = ""
        FillWorkersList()
    End Sub

    Private Sub ComboBoxFilterPosts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFilterPosts.SelectedIndexChanged
        WorkersListView.Items.Clear()
        Dim Items(4) As String
        Dim TempRow As DataRow
        Dim RowFilterPosts As DataRow = User1DataSet.Posts.Select("Title = '" & ComboBoxFilterPosts.SelectedItem & "'")(0)
        Dim RowID_Post As ULong = RowFilterPosts("ID")
        RowID_Post = RowFilterPosts("ID")
        For Each Row As DataRow In Me.User1DataSet.Workers.Rows
            Dim RowFilterPost As DataRow = User1DataSet.Posts.Select("Title = '" & ComboBoxFilterPosts.SelectedItem & "'")(0)
            If Row("PostID") = RowFilterPost("ID") Then
                Items(1) = Row(1)
                Items(2) = Row(2)
                TempRow = Row.GetParentRow("FK_Workers_Departaments")
                Items(3) = TempRow(1)
                TempRow = Row.GetParentRow("FK_Workers_Posts")
                Items(4) = TempRow(1)
                Dim it As New ListViewItem()
                it.Text = Row(0)
                it.SubItems.AddRange(Items)
                WorkersListView.Items.Add(it)
            End If
        Next Row
    End Sub

    Private Sub TextBoxFIOFilter_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFIOFilter.TextChanged
        WorkersListView.Items.Clear()
        Dim Items(4) As String
        Dim TempRow As DataRow
        Dim StrFindFIO As String

        If TextBoxFIOFilter.Text = vbNullChar Then
            TextBoxFIOFilter.Text = " "
        End If

        StrFindFIO = TextBoxFIOFilter.Text

        For Each Row As DataRow In Me.User1DataSet.Workers.Select("FIO LIKE '*" & StrFindFIO & "*'")
            Items(1) = Row(1)
            Items(2) = Row(2)
            TempRow = Row.GetParentRow("FK_Workers_Departaments")
            Items(3) = TempRow(1)
            TempRow = Row.GetParentRow("FK_Workers_Posts")
            Items(4) = TempRow(1)
            Dim it As New ListViewItem()
            it.Text = Row(0)
            it.SubItems.AddRange(Items)
            WorkersListView.Items.Add(it)
        Next Row
    End Sub

    Private Sub ComboBoxFilterDepartaments_TextUpdate(sender As Object, e As EventArgs) Handles ComboBoxFilterDepartaments.TextUpdate
        WorkersListView.Items.Clear()
        Dim Items(4) As String
        Dim TempRow As DataRow
        Dim StrFindDep As String


        If ComboBoxFilterDepartaments.Text = vbNullChar Then
            ComboBoxFilterDepartaments.Text = ""
        End If

        StrFindDep = ComboBoxFilterDepartaments.Text
        For Each Row As DataRow In Me.User1DataSet.Departaments.Select("Title LIKE '*" & StrFindDep & "*'")
            Dim SrchRow As ULong = Row("ID")
            For Each Row1 As DataRow In Me.User1DataSet.Workers.Select("DepartamentID = '" & SrchRow & "'")
                Items(1) = Row(1)
                Items(2) = Row(2)
                TempRow = Row.GetParentRow("FK_Workers_Departaments")
                Items(3) = TempRow(1)
                TempRow = Row.GetParentRow("FK_Workers_Posts")
                Items(4) = TempRow(1)
                Dim it As New ListViewItem()
                it.Text = Row(0)
                it.SubItems.AddRange(Items)
                WorkersListView.Items.Add(it)
            Next Row1
        Next Row
    End Sub

    Private Sub СправкаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СправкаToolStripMenuItem.Click

    End Sub

    Private Sub TextBoxDepartamentsSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDepartamentsSearch.TextChanged

        WorkersListView.Items.Clear()
        Dim Items(4) As String
        Dim TempRow As DataRow
        Dim StrFindDep As String


        If TextBoxDepartamentsSearch.Text = vbNullChar Then
            TextBoxDepartamentsSearch.Text = " "
        End If

        StrFindDep = TextBoxDepartamentsSearch.Text


        For Each Row As DataRow In Me.User1DataSet.Departaments.Select("Title LIKE '%" & StrFindDep & "%'")
            Dim SrchRow As ULong = Row("ID")
            Dim DepartmentTitle As String = Row("Title")
            For Each Row1 As DataRow In Me.User1DataSet.Workers.Select("DepartamentID = " & SrchRow)
                Items(1) = Row1("FIO")
                Items(2) = Row1("Birthday")
                Items(3) = DepartmentTitle
                TempRow = Row1.GetParentRow("FK_Workers_Posts")
                Items(4) = TempRow("Title")
                Dim it As New ListViewItem()
                it.Text = Row1("ID")
                it.SubItems.AddRange(Items)
                WorkersListView.Items.Add(it)
            Next Row1
        Next Row
    End Sub




End Class
