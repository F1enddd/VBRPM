Public Class Form9
    Dim CheckedFontButton As String = "Times New Roman"
    Dim SelColor As Color = Color.Black
    Dim Font As New Font(CheckedFontButton, 14)
    Dim graph As Graphics = MyBase.CreateGraphics
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.AddRange(New Object() {"Окружность", "Отрезок", "Прямоугольник", "Сектор", "Текст", "Эллипс", "Закрашенный сектор"})
        ButtonBlack.BackColor = Color.Black
        ButtonGreen.BackColor = Color.Green
        ButtonYellow.BackColor = Color.Yellow
        ButtonRed.BackColor = Color.Red
        ButtonGreen.FlatAppearance.BorderColor = Color.Black
        ButtonRed.FlatAppearance.BorderColor = Color.Black
        ButtonYellow.FlatAppearance.BorderColor = Color.Black
        ButtonBlack.FlatAppearance.BorderColor = Color.Lime
        ButtonFont1.FlatAppearance.BorderColor = Color.Lime
        ButtonFont2.FlatAppearance.BorderColor = Color.Black
        ButtonFont3.FlatAppearance.BorderColor = Color.Black
        ButtonFont4.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub ListBox1_Click_1(sender As Object, e As EventArgs) Handles ListBox1.Click


        Dim pen1 As New Pen(SelColor)

        Dim brush1 As New SolidBrush(SelColor)

        Select Case ListBox1.SelectedIndex
            Case 0
                graph.DrawEllipse(pen1, 50, 50, 150, 150)
            Case 1
                graph.DrawLine(pen1, 50, 50, 200, 200)
            Case 2
                graph.DrawRectangle(pen1, 50, 30, 150, 180)
            Case 3
                graph.DrawPie(pen1, 40, 50, 200, 200, 180, 225)
            Case 4
                Dim s As String
                s = "Каждый во что-то верит, но" & vbCrLf & " жизнь преподносит сюрпризы."
                graph.DrawString(s, Font, brush1, 0, 100)
            Case 5
                graph.DrawEllipse(pen1, 30, 30, 150, 200)
            Case 6
                graph.FillPie(brush1, 20, 50, 150, 150, 0, 45)
        End Select
    End Sub

    Private Sub ButtonBlack_Click(sender As Object, e As EventArgs) Handles ButtonBlack.Click
        SelColor = Color.Black
        CheckedButtonCol(ButtonBlack)
    End Sub

    Private Sub ButtonRed_Click(sender As Object, e As EventArgs) Handles ButtonRed.Click
        SelColor = Color.Red
        CheckedButtonCol(ButtonRed)
    End Sub

    Private Sub ButtonYellow_Click(sender As Object, e As EventArgs) Handles ButtonYellow.Click
        SelColor = Color.Yellow
        CheckedButtonCol(ButtonYellow)
    End Sub

    Private Sub ButtonGreen_Click(sender As Object, e As EventArgs) Handles ButtonGreen.Click
        SelColor = Color.Green
        CheckedButtonCol(ButtonGreen)
    End Sub
    Private Sub ButtonFont1_Click(sender As Object, e As EventArgs) Handles ButtonFont1.Click
        CheckedButtonFont(ButtonFont1)
        CheckedFontButton = "Times New Roman"
        Font = New Font(CheckedFontButton, 12)
    End Sub

    Private Sub ButtonFont2_Click(sender As Object, e As EventArgs) Handles ButtonFont2.Click
        CheckedButtonFont(ButtonFont2)
        CheckedFontButton = "Mon Amour Two"
        Font = New Font(CheckedFontButton, 12)
    End Sub

    Private Sub ButtonFont3_Click(sender As Object, e As EventArgs) Handles ButtonFont3.Click
        CheckedButtonFont(ButtonFont3)
        CheckedFontButton = "Comic Sans MS"
        Font = New Font(CheckedFontButton, 12)
    End Sub

    Private Sub ButtonFont4_Click(sender As Object, e As EventArgs) Handles ButtonFont4.Click
        CheckedButtonFont(ButtonFont4)
        CheckedFontButton = "Beast Impacted"
        Font = New Font(CheckedFontButton, 12)
    End Sub


    Private Sub CheckedButtonCol(ByVal CheckedBtn As Button)
        ButtonGreen.FlatAppearance.BorderColor = Color.Black
        ButtonRed.FlatAppearance.BorderColor = Color.Black
        ButtonBlack.FlatAppearance.BorderColor = Color.Black
        ButtonYellow.FlatAppearance.BorderColor = Color.Black
        CheckedBtn.FlatAppearance.BorderColor = Color.Lime

    End Sub

    Private Sub CheckedButtonFont(ByVal CheckedBtn As Button)
        ButtonFont1.FlatAppearance.BorderColor = Color.Black
        ButtonFont2.FlatAppearance.BorderColor = Color.Black
        ButtonFont3.FlatAppearance.BorderColor = Color.Black
        ButtonFont4.FlatAppearance.BorderColor = Color.Black
        CheckedBtn.FlatAppearance.BorderColor = Color.Lime

    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        graph.clear(Color.FromName("Control"))
    End Sub
End Class