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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FileNameTB = New System.Windows.Forms.TextBox()
        Me.SetImageButton = New System.Windows.Forms.Button()
        Me.SelectImageButton = New System.Windows.Forms.Button()
        Me.PicBoxAOC = New System.Windows.Forms.PictureBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FilesListBox = New System.Windows.Forms.CheckedListBox()
        CType(Me.PicBoxAOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(316, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 58
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
        Me.FileNameTB.TabIndex = 57
        Me.FileNameTB.Tag = ""
        Me.FileNameTB.WordWrap = False
        '
        'SetImageButton
        '
        Me.SetImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetImageButton.Location = New System.Drawing.Point(370, 293)
        Me.SetImageButton.Name = "SetImageButton"
        Me.SetImageButton.Size = New System.Drawing.Size(135, 23)
        Me.SetImageButton.TabIndex = 54
        Me.SetImageButton.Text = "Установить"
        Me.SetImageButton.UseVisualStyleBackColor = True
        '
        'SelectImageButton
        '
        Me.SelectImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectImageButton.Location = New System.Drawing.Point(12, 293)
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
        Me.PicBoxAOC.Size = New System.Drawing.Size(186, 244)
        Me.PicBoxAOC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBoxAOC.TabIndex = 53
        Me.PicBoxAOC.TabStop = False
        '
        'FilesListBox
        '
        Me.FilesListBox.CheckOnClick = True
        Me.FilesListBox.FormattingEnabled = True
        Me.FilesListBox.Location = New System.Drawing.Point(12, 12)
        Me.FilesListBox.Name = "FilesListBox"
        Me.FilesListBox.Size = New System.Drawing.Size(301, 244)
        Me.FilesListBox.TabIndex = 59
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 329)
        Me.Controls.Add(Me.FilesListBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FileNameTB)
        Me.Controls.Add(Me.SetImageButton)
        Me.Controls.Add(Me.SelectImageButton)
        Me.Controls.Add(Me.PicBoxAOC)
        Me.Name = "Form10"
        Me.Text = "Form10"
        CType(Me.PicBoxAOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents FileNameTB As TextBox
    Friend WithEvents SetImageButton As Button
    Friend WithEvents SelectImageButton As Button
    Friend WithEvents PicBoxAOC As PictureBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents FilesListBox As CheckedListBox
End Class
