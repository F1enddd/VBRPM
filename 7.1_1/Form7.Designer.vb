<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.DepartamentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentsTableAdapter = New _7._1_1.user1DataSetTableAdapters.DepartamentsTableAdapter()
        Me.TableAdapterManager = New _7._1_1.user1DataSetTableAdapters.TableAdapterManager()
        Me.DepartamentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.User1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.PostsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = _7._1_1.user1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WorkersTableAdapter = Nothing
        '
        'DepartamentsDataGridView
        '
        Me.DepartamentsDataGridView.AutoGenerateColumns = False
        Me.DepartamentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DepartamentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DepartamentsDataGridView.DataSource = Me.DepartamentsBindingSource
        Me.DepartamentsDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.DepartamentsDataGridView.Name = "DepartamentsDataGridView"
        Me.DepartamentsDataGridView.Size = New System.Drawing.Size(261, 220)
        Me.DepartamentsDataGridView.TabIndex = 1
        '
        'ButtonSave
        '
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Location = New System.Drawing.Point(154, 238)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(119, 24)
        Me.ButtonSave.TabIndex = 4
        Me.ButtonSave.Text = "Сохранить"
        Me.ButtonSave.UseVisualStyleBackColor = True
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
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 273)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.DepartamentsDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form7"
        Me.ShowIcon = False
        Me.Text = "Изменение отделов"
        CType(Me.User1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents User1DataSet As user1DataSet
    Friend WithEvents DepartamentsBindingSource As BindingSource
    Friend WithEvents DepartamentsTableAdapter As user1DataSetTableAdapters.DepartamentsTableAdapter
    Friend WithEvents TableAdapterManager As user1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents DepartamentsDataGridView As DataGridView
    Friend WithEvents ButtonSave As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
