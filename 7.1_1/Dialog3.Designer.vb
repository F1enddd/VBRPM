<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog3
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
        Me.AddPosts = New System.Windows.Forms.TextBox()
        Me.AddPostsButton = New System.Windows.Forms.Button()
        Me.PostsListView = New System.Windows.Forms.ListView()
        Me.PostsWorkers = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 243)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Отмена"
        '
        'AddPosts
        '
        Me.AddPosts.Location = New System.Drawing.Point(298, 180)
        Me.AddPosts.Name = "AddPosts"
        Me.AddPosts.Size = New System.Drawing.Size(122, 20)
        Me.AddPosts.TabIndex = 9
        '
        'AddPostsButton
        '
        Me.AddPostsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddPostsButton.Location = New System.Drawing.Point(298, 206)
        Me.AddPostsButton.Name = "AddPostsButton"
        Me.AddPostsButton.Size = New System.Drawing.Size(122, 23)
        Me.AddPostsButton.TabIndex = 8
        Me.AddPostsButton.Text = "Добавить"
        Me.AddPostsButton.UseVisualStyleBackColor = True
        '
        'PostsListView
        '
        Me.PostsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PostsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.PostsWorkers})
        Me.PostsListView.FullRowSelect = True
        Me.PostsListView.GridLines = True
        Me.PostsListView.HideSelection = False
        Me.PostsListView.Location = New System.Drawing.Point(12, 12)
        Me.PostsListView.MultiSelect = False
        Me.PostsListView.Name = "PostsListView"
        Me.PostsListView.Size = New System.Drawing.Size(280, 217)
        Me.PostsListView.TabIndex = 7
        Me.PostsListView.UseCompatibleStateImageBehavior = False
        Me.PostsListView.View = System.Windows.Forms.View.Details
        '
        'PostsWorkers
        '
        Me.PostsWorkers.Text = "Должность"
        Me.PostsWorkers.Width = 279
        '
        'Dialog3
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 284)
        Me.Controls.Add(Me.AddPosts)
        Me.Controls.Add(Me.AddPostsButton)
        Me.Controls.Add(Me.PostsListView)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog3"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dialog3"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents AddPosts As TextBox
    Friend WithEvents AddPostsButton As Button
    Friend WithEvents PostsListView As ListView
    Friend WithEvents PostsWorkers As ColumnHeader
End Class
