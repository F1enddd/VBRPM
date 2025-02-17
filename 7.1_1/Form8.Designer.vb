<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.PicBoxAOC = New System.Windows.Forms.PictureBox()
        Me.SelectImageButton = New System.Windows.Forms.Button()
        Me.SetImageButton = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FilesListBox = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FileNameTB = New System.Windows.Forms.TextBox()
        CType(Me.PicBoxAOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicBoxAOC
        '
        Me.PicBoxAOC.BackColor = System.Drawing.Color.White
        Me.PicBoxAOC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBoxAOC.Location = New System.Drawing.Point(319, 12)
        Me.PicBoxAOC.Name = "PicBoxAOC"
        Me.PicBoxAOC.Size = New System.Drawing.Size(186, 238)
        Me.PicBoxAOC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBoxAOC.TabIndex = 43
        Me.PicBoxAOC.TabStop = False
        '
        'SelectImageButton
        '
        Me.SelectImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectImageButton.Location = New System.Drawing.Point(12, 293)
        Me.SelectImageButton.Name = "SelectImageButton"
        Me.SelectImageButton.Size = New System.Drawing.Size(135, 23)
        Me.SelectImageButton.TabIndex = 49
        Me.SelectImageButton.Text = "Обзор"
        Me.SelectImageButton.UseVisualStyleBackColor = True
        '
        'SetImageButton
        '
        Me.SetImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetImageButton.Location = New System.Drawing.Point(370, 293)
        Me.SetImageButton.Name = "SetImageButton"
        Me.SetImageButton.Size = New System.Drawing.Size(135, 23)
        Me.SetImageButton.TabIndex = 49
        Me.SetImageButton.Text = "Установить"
        Me.SetImageButton.UseVisualStyleBackColor = True
        '
        'FilesListBox
        '
        Me.FilesListBox.FormattingEnabled = True
        Me.FilesListBox.HorizontalScrollbar = True
        Me.FilesListBox.Location = New System.Drawing.Point(12, 12)
        Me.FilesListBox.Name = "FilesListBox"
        Me.FilesListBox.Size = New System.Drawing.Size(301, 238)
        Me.FilesListBox.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(316, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Файл"
        '
        'FileNameTB
        '
        Me.FileNameTB.BackColor = System.Drawing.Color.White
        Me.FileNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FileNameTB.Location = New System.Drawing.Point(354, 262)
        Me.FileNameTB.Name = "FileNameTB"
        Me.FileNameTB.ReadOnly = True
        Me.FileNameTB.Size = New System.Drawing.Size(151, 20)
        Me.FileNameTB.TabIndex = 51
        Me.FileNameTB.Tag = ""
        Me.FileNameTB.WordWrap = False
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 331)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FileNameTB)
        Me.Controls.Add(Me.FilesListBox)
        Me.Controls.Add(Me.SetImageButton)
        Me.Controls.Add(Me.SelectImageButton)
        Me.Controls.Add(Me.PicBoxAOC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form8"
        Me.Text = "Выбор файла"
        CType(Me.PicBoxAOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicBoxAOC As PictureBox
    Friend WithEvents SelectImageButton As Button
    Friend WithEvents SetImageButton As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents FilesListBox As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FileNameTB As TextBox
End Class
