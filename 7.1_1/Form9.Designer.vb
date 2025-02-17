<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ButtonBlack = New System.Windows.Forms.Button()
        Me.ButtonRed = New System.Windows.Forms.Button()
        Me.ButtonYellow = New System.Windows.Forms.Button()
        Me.ButtonGreen = New System.Windows.Forms.Button()
        Me.ButtonFont1 = New System.Windows.Forms.Button()
        Me.ButtonFont3 = New System.Windows.Forms.Button()
        Me.ButtonFont4 = New System.Windows.Forms.Button()
        Me.ButtonFont2 = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(464, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(182, 95)
        Me.ListBox1.TabIndex = 0
        '
        'ButtonBlack
        '
        Me.ButtonBlack.BackColor = System.Drawing.Color.Black
        Me.ButtonBlack.FlatAppearance.BorderSize = 3
        Me.ButtonBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBlack.Location = New System.Drawing.Point(464, 114)
        Me.ButtonBlack.Name = "ButtonBlack"
        Me.ButtonBlack.Size = New System.Drawing.Size(41, 42)
        Me.ButtonBlack.TabIndex = 1
        Me.ButtonBlack.UseVisualStyleBackColor = False
        '
        'ButtonRed
        '
        Me.ButtonRed.BackColor = System.Drawing.Color.Red
        Me.ButtonRed.FlatAppearance.BorderSize = 3
        Me.ButtonRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRed.ForeColor = System.Drawing.Color.Black
        Me.ButtonRed.Location = New System.Drawing.Point(511, 114)
        Me.ButtonRed.Name = "ButtonRed"
        Me.ButtonRed.Size = New System.Drawing.Size(41, 42)
        Me.ButtonRed.TabIndex = 1
        Me.ButtonRed.UseVisualStyleBackColor = False
        '
        'ButtonYellow
        '
        Me.ButtonYellow.BackColor = System.Drawing.Color.Yellow
        Me.ButtonYellow.FlatAppearance.BorderSize = 3
        Me.ButtonYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonYellow.Location = New System.Drawing.Point(558, 114)
        Me.ButtonYellow.Name = "ButtonYellow"
        Me.ButtonYellow.Size = New System.Drawing.Size(41, 42)
        Me.ButtonYellow.TabIndex = 1
        Me.ButtonYellow.UseVisualStyleBackColor = False
        '
        'ButtonGreen
        '
        Me.ButtonGreen.BackColor = System.Drawing.Color.Lime
        Me.ButtonGreen.FlatAppearance.BorderSize = 3
        Me.ButtonGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGreen.Location = New System.Drawing.Point(605, 114)
        Me.ButtonGreen.Name = "ButtonGreen"
        Me.ButtonGreen.Size = New System.Drawing.Size(41, 42)
        Me.ButtonGreen.TabIndex = 1
        Me.ButtonGreen.UseVisualStyleBackColor = False
        '
        'ButtonFont1
        '
        Me.ButtonFont1.FlatAppearance.BorderSize = 3
        Me.ButtonFont1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFont1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonFont1.Location = New System.Drawing.Point(511, 162)
        Me.ButtonFont1.Name = "ButtonFont1"
        Me.ButtonFont1.Size = New System.Drawing.Size(135, 41)
        Me.ButtonFont1.TabIndex = 2
        Me.ButtonFont1.Text = "Шрифт1"
        Me.ButtonFont1.UseVisualStyleBackColor = True
        '
        'ButtonFont3
        '
        Me.ButtonFont3.FlatAppearance.BorderSize = 3
        Me.ButtonFont3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFont3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonFont3.Location = New System.Drawing.Point(511, 256)
        Me.ButtonFont3.Name = "ButtonFont3"
        Me.ButtonFont3.Size = New System.Drawing.Size(135, 41)
        Me.ButtonFont3.TabIndex = 2
        Me.ButtonFont3.Text = "Шрифт3"
        Me.ButtonFont3.UseVisualStyleBackColor = True
        '
        'ButtonFont4
        '
        Me.ButtonFont4.FlatAppearance.BorderSize = 3
        Me.ButtonFont4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFont4.Font = New System.Drawing.Font("Beast Impacted", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonFont4.Location = New System.Drawing.Point(511, 303)
        Me.ButtonFont4.Name = "ButtonFont4"
        Me.ButtonFont4.Size = New System.Drawing.Size(135, 41)
        Me.ButtonFont4.TabIndex = 2
        Me.ButtonFont4.Text = "Шрифт4"
        Me.ButtonFont4.UseVisualStyleBackColor = True
        '
        'ButtonFont2
        '
        Me.ButtonFont2.FlatAppearance.BorderSize = 3
        Me.ButtonFont2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFont2.Font = New System.Drawing.Font("Mon Amour Two", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonFont2.Location = New System.Drawing.Point(511, 209)
        Me.ButtonFont2.Name = "ButtonFont2"
        Me.ButtonFont2.Size = New System.Drawing.Size(135, 41)
        Me.ButtonFont2.TabIndex = 2
        Me.ButtonFont2.Text = "Шрифт2"
        Me.ButtonFont2.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClear.Location = New System.Drawing.Point(464, 360)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(182, 43)
        Me.ButtonClear.TabIndex = 3
        Me.ButtonClear.Text = "Отчистить"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 415)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonFont2)
        Me.Controls.Add(Me.ButtonFont4)
        Me.Controls.Add(Me.ButtonFont3)
        Me.Controls.Add(Me.ButtonFont1)
        Me.Controls.Add(Me.ButtonGreen)
        Me.Controls.Add(Me.ButtonYellow)
        Me.Controls.Add(Me.ButtonRed)
        Me.Controls.Add(Me.ButtonBlack)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form9"
        Me.Text = "Растровая графика"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ButtonBlack As Button
    Friend WithEvents ButtonRed As Button
    Friend WithEvents ButtonYellow As Button
    Friend WithEvents ButtonGreen As Button
    Friend WithEvents ButtonFont1 As Button
    Friend WithEvents ButtonFont3 As Button
    Friend WithEvents ButtonFont4 As Button
    Friend WithEvents ButtonFont2 As Button
    Friend WithEvents ButtonClear As Button
End Class
