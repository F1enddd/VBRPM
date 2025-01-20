<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ButtonSqlOut = New System.Windows.Forms.Button()
        Me.ButtonGridView = New System.Windows.Forms.Button()
        Me.MainMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗавершениеРаботыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОбщаяСтруктураToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПросмотрИИзменениеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправочникиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СотрудникиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИзменениеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОтделыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИзменениеToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДолжностиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИзменениеToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОтчётыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПоискПоСложнымЗапросамToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.БухглатерыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОКToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИванToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonFiltersClear = New System.Windows.Forms.Button()
        Me.TextBoxFIOFilter = New System.Windows.Forms.TextBox()
        Me.ComboBoxFilterPosts = New System.Windows.Forms.ComboBox()
        Me.ComboBoxFilterDepartaments = New System.Windows.Forms.ComboBox()
        Me.ButtonDialog2 = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.WorkersListView = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FIO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Bitrthday = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DepartamentsWorkers = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PostsWorkers = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.User1DataSet = New _7._1_1.user1DataSet()
        Me.DepartamentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentsTableAdapter = New _7._1_1.user1DataSetTableAdapters.DepartamentsTableAdapter()
        Me.TableAdapterManager = New _7._1_1.user1DataSetTableAdapters.TableAdapterManager()
        Me.PostsTableAdapter = New _7._1_1.user1DataSetTableAdapters.PostsTableAdapter()
        Me.WorkersTableAdapter = New _7._1_1.user1DataSetTableAdapters.WorkersTableAdapter()
        Me.PostsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorkersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChangetoolStripMenuItem = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItemEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBoxDepartamentsSearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MainMenuStrip.SuspendLayout()
        CType(Me.User1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PostsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ChangetoolStripMenuItem.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonSqlOut
        '
        Me.ButtonSqlOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSqlOut.Location = New System.Drawing.Point(395, 60)
        Me.ButtonSqlOut.Name = "ButtonSqlOut"
        Me.ButtonSqlOut.Size = New System.Drawing.Size(136, 23)
        Me.ButtonSqlOut.TabIndex = 0
        Me.ButtonSqlOut.Text = "Вывод в MsgBox"
        Me.ButtonSqlOut.UseVisualStyleBackColor = True
        '
        'ButtonGridView
        '
        Me.ButtonGridView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGridView.Location = New System.Drawing.Point(226, 60)
        Me.ButtonGridView.Name = "ButtonGridView"
        Me.ButtonGridView.Size = New System.Drawing.Size(163, 23)
        Me.ButtonGridView.TabIndex = 0
        Me.ButtonGridView.Text = "Вывод в DataGrid"
        Me.ButtonGridView.UseVisualStyleBackColor = True
        '
        'MainMenuStrip
        '
        Me.MainMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.ОбщаяСтруктураToolStripMenuItem, Me.СправочникиToolStripMenuItem, Me.ОтчётыToolStripMenuItem, Me.СправкаToolStripMenuItem})
        Me.MainMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainMenuStrip.Name = "MainMenuStrip"
        Me.MainMenuStrip.Size = New System.Drawing.Size(715, 24)
        Me.MainMenuStrip.TabIndex = 1
        Me.MainMenuStrip.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЗавершениеРаботыToolStripMenuItem})
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'ЗавершениеРаботыToolStripMenuItem
        '
        Me.ЗавершениеРаботыToolStripMenuItem.Name = "ЗавершениеРаботыToolStripMenuItem"
        Me.ЗавершениеРаботыToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ЗавершениеРаботыToolStripMenuItem.Text = "Завершение работы"
        '
        'ОбщаяСтруктураToolStripMenuItem
        '
        Me.ОбщаяСтруктураToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПросмотрИИзменениеToolStripMenuItem})
        Me.ОбщаяСтруктураToolStripMenuItem.Name = "ОбщаяСтруктураToolStripMenuItem"
        Me.ОбщаяСтруктураToolStripMenuItem.Size = New System.Drawing.Size(115, 20)
        Me.ОбщаяСтруктураToolStripMenuItem.Text = "Общая структура"
        '
        'ПросмотрИИзменениеToolStripMenuItem
        '
        Me.ПросмотрИИзменениеToolStripMenuItem.Name = "ПросмотрИИзменениеToolStripMenuItem"
        Me.ПросмотрИИзменениеToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ПросмотрИИзменениеToolStripMenuItem.Text = "Просмотр и изменение"
        '
        'СправочникиToolStripMenuItem
        '
        Me.СправочникиToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СотрудникиToolStripMenuItem, Me.ОтделыToolStripMenuItem, Me.ДолжностиToolStripMenuItem})
        Me.СправочникиToolStripMenuItem.Name = "СправочникиToolStripMenuItem"
        Me.СправочникиToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.СправочникиToolStripMenuItem.Text = "Справочники"
        '
        'СотрудникиToolStripMenuItem
        '
        Me.СотрудникиToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ИзменениеToolStripMenuItem})
        Me.СотрудникиToolStripMenuItem.Name = "СотрудникиToolStripMenuItem"
        Me.СотрудникиToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.СотрудникиToolStripMenuItem.Text = "Сотрудники"
        '
        'ИзменениеToolStripMenuItem
        '
        Me.ИзменениеToolStripMenuItem.Name = "ИзменениеToolStripMenuItem"
        Me.ИзменениеToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ИзменениеToolStripMenuItem.Text = "Изменение..."
        '
        'ОтделыToolStripMenuItem
        '
        Me.ОтделыToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ИзменениеToolStripMenuItem1})
        Me.ОтделыToolStripMenuItem.Name = "ОтделыToolStripMenuItem"
        Me.ОтделыToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ОтделыToolStripMenuItem.Text = "Отделы"
        '
        'ИзменениеToolStripMenuItem1
        '
        Me.ИзменениеToolStripMenuItem1.Name = "ИзменениеToolStripMenuItem1"
        Me.ИзменениеToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.ИзменениеToolStripMenuItem1.Text = "Изменение..."
        '
        'ДолжностиToolStripMenuItem
        '
        Me.ДолжностиToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ИзменениеToolStripMenuItem2})
        Me.ДолжностиToolStripMenuItem.Name = "ДолжностиToolStripMenuItem"
        Me.ДолжностиToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ДолжностиToolStripMenuItem.Text = "Должности"
        '
        'ИзменениеToolStripMenuItem2
        '
        Me.ИзменениеToolStripMenuItem2.Name = "ИзменениеToolStripMenuItem2"
        Me.ИзменениеToolStripMenuItem2.Size = New System.Drawing.Size(145, 22)
        Me.ИзменениеToolStripMenuItem2.Text = "Изменение..."
        '
        'ОтчётыToolStripMenuItem
        '
        Me.ОтчётыToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПоискПоСложнымЗапросамToolStripMenuItem})
        Me.ОтчётыToolStripMenuItem.Name = "ОтчётыToolStripMenuItem"
        Me.ОтчётыToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ОтчётыToolStripMenuItem.Text = "Отчёты"
        '
        'ПоискПоСложнымЗапросамToolStripMenuItem
        '
        Me.ПоискПоСложнымЗапросамToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.БухглатерыToolStripMenuItem, Me.ОКToolStripMenuItem1, Me.ИванToolStripMenuItem1})
        Me.ПоискПоСложнымЗапросамToolStripMenuItem.Name = "ПоискПоСложнымЗапросамToolStripMenuItem"
        Me.ПоискПоСложнымЗапросамToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.ПоискПоСложнымЗапросамToolStripMenuItem.Text = "Поиск по сложным запросам"
        '
        'БухглатерыToolStripMenuItem
        '
        Me.БухглатерыToolStripMenuItem.Name = "БухглатерыToolStripMenuItem"
        Me.БухглатерыToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.БухглатерыToolStripMenuItem.Text = "Бухглатеры"
        '
        'ОКToolStripMenuItem1
        '
        Me.ОКToolStripMenuItem1.Name = "ОКToolStripMenuItem1"
        Me.ОКToolStripMenuItem1.Size = New System.Drawing.Size(138, 22)
        Me.ОКToolStripMenuItem1.Text = "ОК"
        '
        'ИванToolStripMenuItem1
        '
        Me.ИванToolStripMenuItem1.Name = "ИванToolStripMenuItem1"
        Me.ИванToolStripMenuItem1.Size = New System.Drawing.Size(138, 22)
        Me.ИванToolStripMenuItem1.Text = "Иван"
        '
        'СправкаToolStripMenuItem
        '
        Me.СправкаToolStripMenuItem.Name = "СправкаToolStripMenuItem"
        Me.СправкаToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.СправкаToolStripMenuItem.Text = "Справка"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(510, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Должность"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(291, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Отдел"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ФИО"
        '
        'ButtonFiltersClear
        '
        Me.ButtonFiltersClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFiltersClear.Location = New System.Drawing.Point(537, 60)
        Me.ButtonFiltersClear.Name = "ButtonFiltersClear"
        Me.ButtonFiltersClear.Size = New System.Drawing.Size(165, 23)
        Me.ButtonFiltersClear.TabIndex = 12
        Me.ButtonFiltersClear.Text = "Отчистить фильтры"
        Me.ButtonFiltersClear.UseVisualStyleBackColor = True
        '
        'TextBoxFIOFilter
        '
        Me.TextBoxFIOFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxFIOFilter.Location = New System.Drawing.Point(61, 27)
        Me.TextBoxFIOFilter.Name = "TextBoxFIOFilter"
        Me.TextBoxFIOFilter.Size = New System.Drawing.Size(191, 20)
        Me.TextBoxFIOFilter.TabIndex = 11
        '
        'ComboBoxFilterPosts
        '
        Me.ComboBoxFilterPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxFilterPosts.FormattingEnabled = True
        Me.ComboBoxFilterPosts.Location = New System.Drawing.Point(581, 26)
        Me.ComboBoxFilterPosts.Name = "ComboBoxFilterPosts"
        Me.ComboBoxFilterPosts.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxFilterPosts.TabIndex = 9
        '
        'ComboBoxFilterDepartaments
        '
        Me.ComboBoxFilterDepartaments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxFilterDepartaments.FormattingEnabled = True
        Me.ComboBoxFilterDepartaments.Location = New System.Drawing.Point(335, 26)
        Me.ComboBoxFilterDepartaments.Name = "ComboBoxFilterDepartaments"
        Me.ComboBoxFilterDepartaments.Size = New System.Drawing.Size(127, 21)
        Me.ComboBoxFilterDepartaments.TabIndex = 10
        '
        'ButtonDialog2
        '
        Me.ButtonDialog2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDialog2.Location = New System.Drawing.Point(24, 404)
        Me.ButtonDialog2.Name = "ButtonDialog2"
        Me.ButtonDialog2.Size = New System.Drawing.Size(201, 23)
        Me.ButtonDialog2.TabIndex = 20
        Me.ButtonDialog2.Text = "Добавление сотрудника б/в"
        Me.ButtonDialog2.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Location = New System.Drawing.Point(537, 378)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(165, 23)
        Me.ButtonDelete.TabIndex = 19
        Me.ButtonDelete.Text = "Удаление сотрудника"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddButton.Location = New System.Drawing.Point(24, 378)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(165, 23)
        Me.AddButton.TabIndex = 18
        Me.AddButton.Text = "Добавление сотрудника расш."
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'WorkersListView
        '
        Me.WorkersListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WorkersListView.CheckBoxes = True
        Me.WorkersListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.FIO, Me.Bitrthday, Me.DepartamentsWorkers, Me.PostsWorkers})
        Me.WorkersListView.FullRowSelect = True
        Me.WorkersListView.GridLines = True
        Me.WorkersListView.HideSelection = False
        Me.WorkersListView.Location = New System.Drawing.Point(24, 89)
        Me.WorkersListView.MultiSelect = False
        Me.WorkersListView.Name = "WorkersListView"
        Me.WorkersListView.Size = New System.Drawing.Size(678, 283)
        Me.WorkersListView.TabIndex = 17
        Me.WorkersListView.UseCompatibleStateImageBehavior = False
        Me.WorkersListView.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 62
        '
        'FIO
        '
        Me.FIO.Text = "ФИО"
        Me.FIO.Width = 214
        '
        'Bitrthday
        '
        Me.Bitrthday.Text = "Дата рождения"
        Me.Bitrthday.Width = 103
        '
        'DepartamentsWorkers
        '
        Me.DepartamentsWorkers.Text = "Отдел"
        Me.DepartamentsWorkers.Width = 127
        '
        'PostsWorkers
        '
        Me.PostsWorkers.Text = "Должность"
        Me.PostsWorkers.Width = 167
        '
        'User1DataSet
        '
        Me.User1DataSet.DataSetName = "user1DataSet"
        Me.User1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DepartamentsBindingSource
        '
        Me.DepartamentsBindingSource.DataMember = "Departaments"
        Me.DepartamentsBindingSource.DataSource = Me.User1DataSet
        '
        'DepartamentsTableAdapter
        '
        Me.DepartamentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DepartamentsTableAdapter = Me.DepartamentsTableAdapter
        Me.TableAdapterManager.PostsTableAdapter = Me.PostsTableAdapter
        Me.TableAdapterManager.UpdateOrder = _7._1_1.user1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WorkersTableAdapter = Me.WorkersTableAdapter
        '
        'PostsTableAdapter
        '
        Me.PostsTableAdapter.ClearBeforeFill = True
        '
        'WorkersTableAdapter
        '
        Me.WorkersTableAdapter.ClearBeforeFill = True
        '
        'PostsBindingSource
        '
        Me.PostsBindingSource.DataMember = "Posts"
        Me.PostsBindingSource.DataSource = Me.User1DataSet
        '
        'WorkersBindingSource
        '
        Me.WorkersBindingSource.DataMember = "Workers"
        Me.WorkersBindingSource.DataSource = Me.User1DataSet
        '
        'ChangetoolStripMenuItem
        '
        Me.ChangetoolStripMenuItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemEdit})
        Me.ChangetoolStripMenuItem.Name = "ChangetoolStripMenuItem"
        Me.ChangetoolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        '
        'ToolStripMenuItemEdit
        '
        Me.ToolStripMenuItemEdit.Name = "ToolStripMenuItemEdit"
        Me.ToolStripMenuItemEdit.Size = New System.Drawing.Size(128, 22)
        Me.ToolStripMenuItemEdit.Text = "Изменить"
        '
        'TextBoxDepartamentsSearch
        '
        Me.TextBoxDepartamentsSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxDepartamentsSearch.Location = New System.Drawing.Point(90, 63)
        Me.TextBoxDepartamentsSearch.Name = "TextBoxDepartamentsSearch"
        Me.TextBoxDepartamentsSearch.Size = New System.Drawing.Size(130, 20)
        Me.TextBoxDepartamentsSearch.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Отдел"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 440)
        Me.Controls.Add(Me.ButtonDialog2)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.WorkersListView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonFiltersClear)
        Me.Controls.Add(Me.TextBoxDepartamentsSearch)
        Me.Controls.Add(Me.TextBoxFIOFilter)
        Me.Controls.Add(Me.ComboBoxFilterPosts)
        Me.Controls.Add(Me.ComboBoxFilterDepartaments)
        Me.Controls.Add(Me.ButtonGridView)
        Me.Controls.Add(Me.ButtonSqlOut)
        Me.Controls.Add(Me.MainMenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Главная страница"
        Me.MainMenuStrip.ResumeLayout(False)
        Me.MainMenuStrip.PerformLayout()
        CType(Me.User1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PostsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ChangetoolStripMenuItem.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonSqlOut As Button
    Friend WithEvents ButtonGridView As Button
    Friend WithEvents MainMenuStrip As MenuStrip
    Friend WithEvents ФайлToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ЗавершениеРаботыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОбщаяСтруктураToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СправочникиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОтчётыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СправкаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПросмотрИИзменениеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПоискПоСложнымЗапросамToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents БухглатерыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОКToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ИванToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents СотрудникиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ИзменениеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОтделыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ИзменениеToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ДолжностиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ИзменениеToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonFiltersClear As Button
    Friend WithEvents TextBoxFIOFilter As TextBox
    Friend WithEvents ComboBoxFilterPosts As ComboBox
    Friend WithEvents ComboBoxFilterDepartaments As ComboBox
    Friend WithEvents ButtonDialog2 As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents WorkersListView As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents FIO As ColumnHeader
    Friend WithEvents Bitrthday As ColumnHeader
    Friend WithEvents DepartamentsWorkers As ColumnHeader
    Friend WithEvents PostsWorkers As ColumnHeader
    Friend WithEvents User1DataSet As user1DataSet
    Friend WithEvents DepartamentsBindingSource As BindingSource
    Friend WithEvents DepartamentsTableAdapter As user1DataSetTableAdapters.DepartamentsTableAdapter
    Friend WithEvents TableAdapterManager As user1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PostsTableAdapter As user1DataSetTableAdapters.PostsTableAdapter
    Friend WithEvents PostsBindingSource As BindingSource
    Friend WithEvents WorkersTableAdapter As user1DataSetTableAdapters.WorkersTableAdapter
    Friend WithEvents WorkersBindingSource As BindingSource
    Friend WithEvents ChangetoolStripMenuItem As ContextMenuStrip
    Friend WithEvents ToolStripMenuItemEdit As ToolStripMenuItem
    Friend WithEvents TextBoxDepartamentsSearch As TextBox
    Friend WithEvents Label4 As Label
End Class
