Imports FontAwesome
Public Class Main
    Dim password As String = "1010"
    Private currentChildForm As Form

    'function for openinig child form as mdi in panel'
    Private Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Panel2.Controls.Add(childForm)
        Panel2.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    Function Openclose(panelbutton As Button) As Integer
        IconButton6.Enabled = True
        IconButton1.Enabled = True
        IconButton2.Enabled = True
        IconButton3.Enabled = True
        panelbutton.Enabled = False


    End Function
    Function password_check() As Integer
        Dim passc As String
        passc = InputBox("enter the passwod")
        If passc = password Then
            Return 1
        Else
            Return 0
        End If
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenChildForm(Home)
        IconButton6.Enabled = False

    End Sub



    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        OpenChildForm(About)
        Openclose(IconButton2)
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        Dim a As Integer
        a = password_check()
        If a = 1 Then
            End
        ElseIf a = 0 Then
            MsgBox("password incorrect, try again later")
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        OpenChildForm(Vote)
        Openclose(IconButton1)


    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs)

        IconButton6.Enabled = True
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        IconButton6.Enabled = True
        Dim a As Integer
        a = password_check()
        If a = 1 Then
            OpenChildForm(Admin
                          )
        Else
            MsgBox("incorrect password, try again")
        End If
        Openclose(IconButton3)
    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        OpenChildForm(Home)
        Openclose(IconButton6)

    End Sub
End Class