Public Class Vote

    Dim h1 As Image = Image.FromFile("C:\Users\visma\Pictures\siv main.png")
    Dim h2 As Image = Image.FromFile("C:\Users\visma\Pictures\siv main.png")
    Dim h3 As Image = Image.FromFile("C:\Users\visma\Pictures\siv main.png")
    Dim c1 As Image = Image.FromFile("C:\Users\visma\Pictures\siv main.png")
    Dim c2 As Image = Image.FromFile("C:\Users\visma\Pictures\siv main.png")
    Dim d1 As Image = Image.FromFile("C:\Users\visma\Pictures\siv main.png")
    Dim d2 As Image = Image.FromFile("C:\Users\visma\Pictures\siv main.png")
    Dim d3 As Image = Image.FromFile("C:\Users\visma\Pictures\siv main.png")
    Dim d4 As Image = Image.FromFile("C:\Users\visma\Pictures\siv main.png")
    Dim d5 As Image = Image.FromFile("C:\Users\visma\Pictures\siv main.png")
    Dim s1 As Image = Image.FromFile("C:\Users\visma\Pictures\siv main.png")

    Dim houselist As New List(Of Image)({h1, h2, h3})
    Dim cleanlist As New List(Of Image)({c1, c2})
    Dim disciplinelist As New List(Of Image)({d1, d2, d3, d4, d5})
    Dim sportslist As New List(Of Image)({s1})








    Function change_color(c As Color) As Integer
        Label2.ForeColor = c
        Panel1.BackColor = c
        Label1.BackColor = c
        CastVote.BackColor = c
        Label3.BackColor = c
        HouseCaptain.ForeColor = c
        Cleanliness.ForeColor = c
        Discipline.ForeColor = c
        Sports.ForeColor = c
        RadioButton1.BackColor = c
        RadioButton2.BackColor = c
        RadioButton3.BackColor = c
        RadioButton4.BackColor = c
        RadioButton5.BackColor = c



    End Function
    'disables image or picturebox'
    Function imageshutter(a As List(Of Image)) As Integer
        If a.Count = 1 Then
            PictureBox2.Visible = False
            RadioButton2.Visible = False

            PictureBox3.Visible = False
            RadioButton3.Visible = False

            PictureBox4.Visible = False
            RadioButton4.Visible = False

            PictureBox5.Visible = False
            RadioButton5.Visible = False
        ElseIf a.Count = 2 Then
            PictureBox3.Visible = False
            RadioButton3.Visible = False

            PictureBox4.Visible = False
            RadioButton4.Visible = False

            PictureBox5.Visible = False
            RadioButton5.Visible = False
        ElseIf a.Count = 3 Then
            PictureBox4.Visible = False
            RadioButton4.Visible = False

            PictureBox5.Visible = False
            RadioButton5.Visible = False
        ElseIf a.Count = 4 Then
            PictureBox5.Visible = False
            RadioButton5.Visible = False
        End If
    End Function



    Function reset() As Integer
        change_color(Color.Crimson)
        HouseCaptain.Enabled = False
        Discipline.Enabled = False
        Sports.Enabled = False
        Cleanliness.Enabled = False
        CastVote.Enabled = False
        PictureBox1.BackgroundImage = Nothing
        PictureBox2.BackgroundImage = Nothing
        PictureBox3.BackgroundImage = Nothing
        PictureBox4.BackgroundImage = Nothing
        PictureBox5.BackgroundImage = Nothing
        resimage()


    End Function
    Function resimage()
        PictureBox1.Visible = True
        RadioButton1.Visible = True
        PictureBox2.Visible = True
        RadioButton2.Visible = True
        PictureBox3.Visible = True
        RadioButton3.Visible = True
        PictureBox4.Visible = True
        RadioButton4.Visible = True
        PictureBox5.Visible = True
        RadioButton5.Visible = True

    End Function
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        change_color(Color.PaleTurquoise)
        HouseCaptain.Enabled = True
        Discipline.Enabled = True
        Sports.Enabled = True
        Cleanliness.Enabled = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        change_color(Color.Crimson)
        HouseCaptain.Enabled = True
        Discipline.Enabled = True
        Sports.Enabled = True
        Cleanliness.Enabled = True


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        change_color(Color.MediumSeaGreen)
        HouseCaptain.Enabled = True
        Discipline.Enabled = True
        Sports.Enabled = True
        Cleanliness.Enabled = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        change_color(Color.Khaki)
        HouseCaptain.Enabled = True
        Discipline.Enabled = True
        Sports.Enabled = True
        Cleanliness.Enabled = True

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub CastVote_Click(sender As Object, e As EventArgs) Handles CastVote.Click
        MsgBox("thank you for voting, your vote has been registered successfully")
        reset()

    End Sub

    Private Sub HouseCaptain_CheckedChanged(sender As Object, e As EventArgs) Handles HouseCaptain.CheckedChanged
        resimage()
        If HouseCaptain.Checked = True Then
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            RadioButton3.Enabled = True
            RadioButton4.Enabled = True
            RadioButton5.Enabled = True
            imageshutter(houselist)
        End If
    End Sub

    Private Sub Cleanliness_CheckedChanged(sender As Object, e As EventArgs) Handles Cleanliness.CheckedChanged
        resimage()
        If Cleanliness.Checked = True Then
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            RadioButton3.Enabled = True
            RadioButton4.Enabled = True
            RadioButton5.Enabled = True
            imageshutter(cleanlist)

        End If
    End Sub

    Private Sub Sports_CheckedChanged(sender As Object, e As EventArgs) Handles Sports.CheckedChanged
        resimage()
        If Sports.Checked = True Then
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            RadioButton3.Enabled = True
            RadioButton4.Enabled = True
            RadioButton5.Enabled = True
            imageshutter(sportslist)
        End If
    End Sub

    Private Sub Discipline_CheckedChanged(sender As Object, e As EventArgs) Handles Discipline.CheckedChanged
        resimage()
        If Discipline.Checked = True Then
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            RadioButton3.Enabled = True
            RadioButton4.Enabled = True
            RadioButton5.Enabled = True
            imageshutter(disciplinelist)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            CastVote.Enabled = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            CastVote.Enabled = True
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            CastVote.Enabled = True
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            CastVote.Enabled = True
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            CastVote.Enabled = True
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) 

    End Sub
End Class