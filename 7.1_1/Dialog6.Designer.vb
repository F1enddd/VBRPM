<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dialog6))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.WorkersDataGridView = New System.Windows.Forms.DataGridView()
        Me.WorkersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartamentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DepartamentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.User1DataSet = New _7._1_1.user1DataSet()
        Me.PostIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartamentsTableAdapter = New _7._1_1.user1DataSetTableAdapters.DepartamentsTableAdapter()
        Me.TableAdapterManager = New _7._1_1.user1DataSetTableAdapters.TableAdapterManager()
        Me.WorkersTableAdapter = New _7._1_1.user1DataSetTableAdapters.WorkersTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.WorkersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.WorkersDataGridView)
        Me.GroupBox1.Controls.Add(Me.DepartamentsDataGridView)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 347)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Просмотр информации о сотрдниках по выбранному отделу"
        '
        'WorkersDataGridView
        '
        Me.WorkersDataGridView.AllowUserToAddRows = False
        Me.WorkersDataGridView.AllowUserToDeleteRows = False
        Me.WorkersDataGridView.AutoGenerateColumns = False
        Me.WorkersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WorkersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FIODataGridViewTextBoxColumn, Me.BirthdayDataGridViewTextBoxColumn, Me.DepartamentIDDataGridViewTextBoxColumn, Me.PostIDDataGridViewTextBoxColumn})
        Me.WorkersDataGridView.DataSource = Me.WorkersBindingSource
        Me.WorkersDataGridView.Location = New System.Drawing.Point(172, 19)
        Me.WorkersDataGridView.MultiSelect = False
        Me.WorkersDataGridView.Name = "WorkersDataGridView"
        Me.WorkersDataGridView.ReadOnly = True
        Me.WorkersDataGridView.RowHeadersVisible = False
        Me.WorkersDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.WorkersDataGridView.Size = New System.Drawing.Size(443, 298)
        Me.WorkersDataGridView.TabIndex = 1
        '
        'WorkersBindingSource
        '
        Me.WorkersBindingSource.DataMember = "FK_Workers_Departaments"
        Me.WorkersBindingSource.DataSource = Me.DepartamentsBindingSource
        '
        'DepartamentsDataGridView
        '
        Me.DepartamentsDataGridView.AllowUserToAddRows = False
        Me.DepartamentsDataGridView.AllowUserToDeleteRows = False
        Me.DepartamentsDataGridView.AutoGenerateColumns = False
        Me.DepartamentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DepartamentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DepartamentsDataGridView.DataSource = Me.DepartamentsBindingSource
        Me.DepartamentsDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.DepartamentsDataGridView.MultiSelect = False
        Me.DepartamentsDataGridView.Name = "DepartamentsDataGridView"
        Me.DepartamentsDataGridView.ReadOnly = True
        Me.DepartamentsDataGridView.RowHeadersVisible = False
        Me.DepartamentsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DepartamentsDataGridView.Size = New System.Drawing.Size(160, 179)
        Me.DepartamentsDataGridView.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'FIODataGridViewTextBoxColumn
        '
        Me.FIODataGridViewTextBoxColumn.DataPropertyName = "FIO"
        Me.FIODataGridViewTextBoxColumn.HeaderText = "ФИО"
        Me.FIODataGridViewTextBoxColumn.Name = "FIODataGridViewTextBoxColumn"
        Me.FIODataGridViewTextBoxColumn.ReadOnly = True
        Me.FIODataGridViewTextBoxColumn.Width = 250
        '
        'BirthdayDataGridViewTextBoxColumn
        '
        Me.BirthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday"
        Me.BirthdayDataGridViewTextBoxColumn.HeaderText = "Дата рождения"
        Me.BirthdayDataGridViewTextBoxColumn.Name = "BirthdayDataGridViewTextBoxColumn"
        Me.BirthdayDataGridViewTextBoxColumn.ReadOnly = True
        Me.BirthdayDataGridViewTextBoxColumn.Width = 80
        '
        'DepartamentIDDataGridViewTextBoxColumn
        '
        Me.DepartamentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartamentID"
        Me.DepartamentIDDataGridViewTextBoxColumn.DataSource = Me.DepartamentsBindingSource
        Me.DepartamentIDDataGridViewTextBoxColumn.DisplayMember = "Title"
        Me.DepartamentIDDataGridViewTextBoxColumn.HeaderText = "Отдел"
        Me.DepartamentIDDataGridViewTextBoxColumn.Name = "DepartamentIDDataGridViewTextBoxColumn"
        Me.DepartamentIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DepartamentIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DepartamentIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DepartamentIDDataGridViewTextBoxColumn.ValueMember = "ID"
        Me.DepartamentIDDataGridViewTextBoxColumn.Width = 110
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
        'PostIDDataGridViewTextBoxColumn
        '
        Me.PostIDDataGridViewTextBoxColumn.DataPropertyName = "PostID"
        Me.PostIDDataGridViewTextBoxColumn.HeaderText = "PostID"
        Me.PostIDDataGridViewTextBoxColumn.Name = "PostIDDataGridViewTextBoxColumn"
        Me.PostIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PostIDDataGridViewTextBoxColumn.Visible = False
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Отдел"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 160
        '
        'DepartamentsTableAdapter
        '
        Me.DepartamentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DepartamentsTableAdapter = Me.DepartamentsTableAdapter
        Me.TableAdapterManager.PostsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = _7._1_1.user1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WorkersTableAdapter = Me.WorkersTableAdapter
        '
        'WorkersTableAdapter
        '
        Me.WorkersTableAdapter.ClearBeforeFill = True
        '
        'Dialog6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 371)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog6"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Просмотр связанных таблиц"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.WorkersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents User1DataSet As user1DataSet
    Friend WithEvents DepartamentsBindingSource As BindingSource
    Friend WithEvents DepartamentsTableAdapter As user1DataSetTableAdapters.DepartamentsTableAdapter
    Friend WithEvents TableAdapterManager As user1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents DepartamentsDataGridView As DataGridView
    Friend WithEvents WorkersTableAdapter As user1DataSetTableAdapters.WorkersTableAdapter
    Friend WithEvents WorkersBindingSource As BindingSource
    Friend WithEvents WorkersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FIODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BirthdayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartamentIDDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents PostIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
