<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Me.FilesListBox = New System.Windows.Forms.ListBox()
        Me.SetImageButton = New System.Windows.Forms.Button()
        Me.SelectImageButton = New System.Windows.Forms.Button()
        Me.PicBoxAOC = New System.Windows.Forms.PictureBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.PicBoxAOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilesListBox
        '
        Me.FilesListBox.FormattingEnabled = True
        Me.FilesListBox.HorizontalScrollbar = True
        Me.FilesListBox.Location = New System.Drawing.Point(12, 12)
        Me.FilesListBox.Name = "FilesListBox"
        Me.FilesListBox.Size = New System.Drawing.Size(301, 238)
        Me.FilesListBox.TabIndex = 56
        '
        'SetImageButton
        '
        Me.SetImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetImageButton.Location = New System.Drawing.Point(370, 256)
        Me.SetImageButton.Name = "SetImageButton"
        Me.SetImageButton.Size = New System.Drawing.Size(135, 23)
        Me.SetImageButton.TabIndex = 54
        Me.SetImageButton.Text = "Удалить"
        Me.SetImageButton.UseVisualStyleBackColor = True
        '
        'SelectImageButton
        '
        Me.SelectImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectImageButton.Location = New System.Drawing.Point(12, 256)
        Me.SelectImageButton.Name = "SelectImageButton"
        Me.SelectImageButton.Size = New System.Drawing.Size(135, 23)
        Me.SelectImageButton.TabIndex = 55
        Me.SelectImageButton.Text = "Обзор"
        Me.SelectImageButton.UseVisualStyleBackColor = True
        '
        'PicBoxAOC
        '
        Me.PicBoxAOC.BackColor = System.Drawing.Color.White
        Me.PicBoxAOC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBoxAOC.Location = New System.Drawing.Point(319, 12)
        Me.PicBoxAOC.Name = "PicBoxAOC"
        Me.PicBoxAOC.Size = New System.Drawing.Size(186, 238)
        Me.PicBoxAOC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBoxAOC.TabIndex = 53
        Me.PicBoxAOC.TabStop = False
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 290)
        Me.Controls.Add(Me.FilesListBox)
        Me.Controls.Add(Me.SetImageButton)
        Me.Controls.Add(Me.SelectImageButton)
        Me.Controls.Add(Me.PicBoxAOC)
        Me.Name = "Form10"
        Me.Text = "Form10"
        CType(Me.PicBoxAOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FilesListBox As ListBox
    Friend WithEvents SetImageButton As Button
    Friend WithEvents SelectImageButton As Button
    Friend WithEvents PicBoxAOC As PictureBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
