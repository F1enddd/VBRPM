<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DepartamentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.PostsDataGridView = New System.Windows.Forms.DataGridView()
        Me.WorkersDataGridView = New System.Windows.Forms.DataGridView()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.DepartamentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.User1DataSet = New _7._1_1.user1DataSet()
        Me.PostsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorkersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentsTableAdapter = New _7._1_1.user1DataSetTableAdapters.DepartamentsTableAdapter()
        Me.PostsTableAdapter = New _7._1_1.user1DataSetTableAdapters.PostsTableAdapter()
        Me.WorkersTableAdapter = New _7._1_1.user1DataSetTableAdapters.WorkersTableAdapter()
        Me.TableAdapterManager = New _7._1_1.user1DataSetTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBoxWorkers = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.DepartamentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PostsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PostsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxWorkers.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DepartamentsDataGridView
        '
        Me.DepartamentsDataGridView.AutoGenerateColumns = False
        Me.DepartamentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DepartamentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DepartamentsDataGridView.DataSource = Me.DepartamentsBindingSource
        Me.DepartamentsDataGridView.Location = New System.Drawing.Point(6, 14)
        Me.DepartamentsDataGridView.Name = "DepartamentsDataGridView"
        Me.DepartamentsDataGridView.Size = New System.Drawing.Size(261, 220)
        Me.DepartamentsDataGridView.TabIndex = 1
        '
        'PostsDataGridView
        '
        Me.PostsDataGridView.AutoGenerateColumns = False
        Me.PostsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PostsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.PostsDataGridView.DataSource = Me.PostsBindingSource
        Me.PostsDataGridView.Location = New System.Drawing.Point(6, 14)
        Me.PostsDataGridView.Name = "PostsDataGridView"
        Me.PostsDataGridView.Size = New System.Drawing.Size(256, 220)
        Me.PostsDataGridView.TabIndex = 2
        '
        'WorkersDataGridView
        '
        Me.WorkersDataGridView.AutoGenerateColumns = False
        Me.WorkersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WorkersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.WorkersDataGridView.DataSource = Me.WorkersBindingSource
        Me.WorkersDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.WorkersDataGridView.Name = "WorkersDataGridView"
        Me.WorkersDataGridView.Size = New System.Drawing.Size(597, 220)
        Me.WorkersDataGridView.TabIndex = 3
        '
        'ButtonSave
        '
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.ForeColor = System.Drawing.Color.ForestGreen
        Me.ButtonSave.Location = New System.Drawing.Point(490, 282)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(218, 68)
        Me.ButtonSave.TabIndex = 4
        Me.ButtonSave.Text = "Сохранить и обновить"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'DepartamentsBindingSource
        '
        Me.DepartamentsBindingSource.DataMember = "Departaments"
        Me.DepartamentsBindingSource.DataSource = Me.User1DataSet
        '
        'User1DataSet
        '
        Me.User1DataSet.DataSetName = "user1DataSet"
        Me.User1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'DepartamentsTableAdapter
        '
        Me.DepartamentsTableAdapter.ClearBeforeFill = True
        '
        'PostsTableAdapter
        '
        Me.PostsTableAdapter.ClearBeforeFill = True
        '
        'WorkersTableAdapter
        '
        Me.WorkersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DepartamentsTableAdapter = Nothing
        Me.TableAdapterManager.PostsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = _7._1_1.user1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WorkersTableAdapter = Nothing
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "FIO"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ФИО"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ToolTipText = "Фамилия, Имя и Отчество сотрудника"
        Me.DataGridViewTextBoxColumn6.Width = 170
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Birthday"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Дата рождения"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ToolTipText = "Дата рождения сотрудника"
        Me.DataGridViewTextBoxColumn7.Width = 80
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DepartamentID"
        Me.DataGridViewTextBoxColumn8.DataSource = Me.DepartamentsBindingSource
        Me.DataGridViewTextBoxColumn8.DisplayMember = "Title"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Отдел"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn8.ToolTipText = "Отдел в котором работает сотрудник"
        Me.DataGridViewTextBoxColumn8.ValueMember = "ID"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PostID"
        Me.DataGridViewTextBoxColumn9.DataSource = Me.PostsBindingSource
        Me.DataGridViewTextBoxColumn9.DisplayMember = "Title"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Должность"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn9.ToolTipText = "Должность сотрудника"
        Me.DataGridViewTextBoxColumn9.ValueMember = "ID"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ToolTipText = "Н"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Название"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ToolTipText = "Название должности"
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Название"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ToolTipText = "Название отдела"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'GroupBoxWorkers
        '
        Me.GroupBoxWorkers.Controls.Add(Me.WorkersDataGridView)
        Me.GroupBoxWorkers.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxWorkers.Name = "GroupBoxWorkers"
        Me.GroupBoxWorkers.Size = New System.Drawing.Size(614, 245)
        Me.GroupBoxWorkers.TabIndex = 5
        Me.GroupBoxWorkers.TabStop = False
        Me.GroupBoxWorkers.Text = "Редактирование сотрудников"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DepartamentsDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(906, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 245)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Редактирование отделов"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PostsDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(632, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(268, 245)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Редактирование должностей"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1187, 362)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxWorkers)
        Me.Controls.Add(Me.ButtonSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.ShowIcon = False
        Me.Text = "Просмотр и изменение"
        CType(Me.DepartamentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PostsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PostsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxWorkers.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents User1DataSet As user1DataSet
    Friend WithEvents DepartamentsBindingSource As BindingSource
    Friend WithEvents DepartamentsTableAdapter As user1DataSetTableAdapters.DepartamentsTableAdapter
    Friend WithEvents TableAdapterManager As user1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PostsTableAdapter As user1DataSetTableAdapters.PostsTableAdapter
    Friend WithEvents DepartamentsDataGridView As DataGridView
    Friend WithEvents PostsBindingSource As BindingSource
    Friend WithEvents WorkersTableAdapter As user1DataSetTableAdapters.WorkersTableAdapter
    Friend WithEvents PostsDataGridView As DataGridView
    Friend WithEvents WorkersBindingSource As BindingSource
    Friend WithEvents WorkersDataGridView As DataGridView
    Friend WithEvents ButtonSave As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewComboBoxColumn
    Friend WithEvents GroupBoxWorkers As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
