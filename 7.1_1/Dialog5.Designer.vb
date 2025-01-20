<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog5
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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.ListBoxInfo = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(356, 280)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "ОК"
        '
        'ListBoxInfo
        '
        Me.ListBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBoxInfo.FormattingEnabled = True
        Me.ListBoxInfo.Items.AddRange(New Object() {"Программа была создана Сусловым Д. С. в рамке пар РПМ", "Mail: Dsus26@mail.ru", "Phone: +79221004076", "в программе Visual Studio (WinForms) на базе языка Visual Basic ", "с подключением к SQL Server 2018"})
        Me.ListBoxInfo.Location = New System.Drawing.Point(12, 12)
        Me.ListBoxInfo.Name = "ListBoxInfo"
        Me.ListBoxInfo.Size = New System.Drawing.Size(393, 223)
        Me.ListBoxInfo.TabIndex = 1
        '
        'Dialog5
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 315)
        Me.Controls.Add(Me.ListBoxInfo)
        Me.Controls.Add(Me.OK_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog5"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Справка"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OK_Button As Button
    Friend WithEvents ListBoxInfo As ListBox
End Class
