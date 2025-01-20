<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.User1DataSet = New _7._1_1.user1DataSet()
        Me.WorkersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorkersTableAdapter = New _7._1_1.user1DataSetTableAdapters.WorkersTableAdapter()
        Me.TableAdapterManager = New _7._1_1.user1DataSetTableAdapters.TableAdapterManager()
        Me.WorkersDataGridView = New System.Windows.Forms.DataGridView()
        Me.User1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorkersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentsTableAdapter = New _7._1_1.user1DataSetTableAdapters.DepartamentsTableAdapter()
        Me.PostsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PostsTableAdapter = New _7._1_1.user1DataSetTableAdapters.PostsTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ButtonSave = New System.Windows.Forms.Button()
        CType(Me.User1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PostsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'User1DataSet
        '
        Me.User1DataSet.DataSetName = "user1DataSet"
        Me.User1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WorkersBindingSource
        '
        Me.WorkersBindingSource.DataMember = "Workers"
        Me.WorkersBindingSource.DataSource = Me.User1DataSet
        '
        'WorkersTableAdapter
        '
        Me.WorkersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DepartamentsTableAdapter = Me.DepartamentsTableAdapter
        Me.TableAdapterManager.PostsTableAdapter = Me.PostsTableAdapter
        Me.TableAdapterManager.UpdateOrder = _7._1_1.user1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WorkersTableAdapter = Me.WorkersTableAdapter
        '
        'WorkersDataGridView
        '
        Me.WorkersDataGridView.AutoGenerateColumns = False
        Me.WorkersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WorkersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.WorkersDataGridView.DataSource = Me.WorkersBindingSource
        Me.WorkersDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.WorkersDataGridView.Name = "WorkersDataGridView"
        Me.WorkersDataGridView.Size = New System.Drawing.Size(548, 220)
        Me.WorkersDataGridView.TabIndex = 1
        '
        'User1DataSetBindingSource
        '
        Me.User1DataSetBindingSource.DataSource = Me.User1DataSet
        Me.User1DataSetBindingSource.Position = 0
        '
        'WorkersBindingSource1
        '
        Me.WorkersBindingSource1.DataMember = "Workers"
        Me.WorkersBindingSource1.DataSource = Me.User1DataSetBindingSource
        '
        'DepartamentsBindingSource
        '
        Me.DepartamentsBindingSource.DataMember = "Departaments"
        Me.DepartamentsBindingSource.DataSource = Me.User1DataSetBindingSource
        '
        'DepartamentsTableAdapter
        '
        Me.DepartamentsTableAdapter.ClearBeforeFill = True
        '
        'PostsBindingSource
        '
        Me.PostsBindingSource.DataMember = "Posts"
        Me.PostsBindingSource.DataSource = Me.User1DataSetBindingSource
        '
        'PostsTableAdapter
        '
        Me.PostsTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FIO"
        Me.DataGridViewTextBoxColumn2.FillWeight = 175.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "ФИО"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Birthday"
        Me.DataGridViewTextBoxColumn3.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Дата рождения"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DepartamentID"
        Me.DataGridViewTextBoxColumn4.DataSource = Me.DepartamentsBindingSource
        Me.DataGridViewTextBoxColumn4.DisplayMember = "Title"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Отдел"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.ValueMember = "ID"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PostID"
        Me.DataGridViewTextBoxColumn5.DataSource = Me.PostsBindingSource
        Me.DataGridViewTextBoxColumn5.DisplayMember = "Title"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Должность"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.ValueMember = "ID"
        '
        'ButtonSave
        '
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Location = New System.Drawing.Point(444, 238)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(119, 24)
        Me.ButtonSave.TabIndex = 2
        Me.ButtonSave.Text = "Сохранить"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 267)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.WorkersDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form5"
        Me.ShowIcon = False
        Me.Text = "Изменение сотрудников"
        CType(Me.User1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PostsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents User1DataSet As user1DataSet
    Friend WithEvents WorkersBindingSource As BindingSource
    Friend WithEvents WorkersTableAdapter As user1DataSetTableAdapters.WorkersTableAdapter
    Friend WithEvents TableAdapterManager As user1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents DepartamentsTableAdapter As user1DataSetTableAdapters.DepartamentsTableAdapter
    Friend WithEvents WorkersDataGridView As DataGridView
    Friend WithEvents User1DataSetBindingSource As BindingSource
    Friend WithEvents WorkersBindingSource1 As BindingSource
    Friend WithEvents DepartamentsBindingSource As BindingSource
    Friend WithEvents PostsTableAdapter As user1DataSetTableAdapters.PostsTableAdapter
    Friend WithEvents PostsBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewComboBoxColumn
    Friend WithEvents ButtonSave As Button
End Class
