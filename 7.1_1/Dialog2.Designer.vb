<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog2
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PostSelect = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DepartamentsSelect = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BirthdayDate = New System.Windows.Forms.DateTimePicker()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelFIO = New System.Windows.Forms.Label()
        Me.FIOText = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 274)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "ОК"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Отмена"
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(218, 232)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 21)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Добавить"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(218, 167)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 21)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Добавить"
        '
        'PostSelect
        '
        Me.PostSelect.DisplayMember = "Title"
        Me.PostSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PostSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PostSelect.FormattingEnabled = True
        Me.PostSelect.Location = New System.Drawing.Point(16, 232)
        Me.PostSelect.Name = "PostSelect"
        Me.PostSelect.Size = New System.Drawing.Size(196, 21)
        Me.PostSelect.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Должность"
        '
        'DepartamentsSelect
        '
        Me.DepartamentsSelect.DisplayMember = "Title"
        Me.DepartamentsSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartamentsSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DepartamentsSelect.FormattingEnabled = True
        Me.DepartamentsSelect.Location = New System.Drawing.Point(16, 167)
        Me.DepartamentsSelect.Name = "DepartamentsSelect"
        Me.DepartamentsSelect.Size = New System.Drawing.Size(196, 21)
        Me.DepartamentsSelect.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Отдел"
        '
        'BirthdayDate
        '
        Me.BirthdayDate.Location = New System.Drawing.Point(12, 95)
        Me.BirthdayDate.Name = "BirthdayDate"
        Me.BirthdayDate.Size = New System.Drawing.Size(200, 20)
        Me.BirthdayDate.TabIndex = 33
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Location = New System.Drawing.Point(13, 75)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(86, 13)
        Me.LabelDate.TabIndex = 32
        Me.LabelDate.Text = "Дата рождения"
        '
        'LabelFIO
        '
        Me.LabelFIO.AutoSize = True
        Me.LabelFIO.Location = New System.Drawing.Point(13, 12)
        Me.LabelFIO.Name = "LabelFIO"
        Me.LabelFIO.Size = New System.Drawing.Size(34, 13)
        Me.LabelFIO.TabIndex = 31
        Me.LabelFIO.Text = "ФИО"
        '
        'FIOText
        '
        Me.FIOText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FIOText.Location = New System.Drawing.Point(12, 31)
        Me.FIOText.Name = "FIOText"
        Me.FIOText.Size = New System.Drawing.Size(414, 20)
        Me.FIOText.TabIndex = 30
        '
        'Dialog2
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 315)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PostSelect)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DepartamentsSelect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BirthdayDate)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.LabelFIO)
        Me.Controls.Add(Me.FIOText)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dialog2"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PostSelect As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DepartamentsSelect As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BirthdayDate As DateTimePicker
    Friend WithEvents LabelDate As Label
    Friend WithEvents LabelFIO As Label
    Friend WithEvents FIOText As TextBox
End Class
