Public Class Form4
    Dim a1 As Integer = 51
    Dim a2 As Integer = 4
    Dim a3 As Integer = 746
    Dim a4 As Integer = 167
    Dim Count As Integer = 1

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        If (a1 < 396) Then
            PictureBox1.Location = New System.Drawing.Point((PictureBox1.Location.X + 1), PictureBox1.Location.Y)
            a1 = PictureBox1.Location.X + 1
        End If
        If (a2 < 168) Then
            PictureBox2.Location = New System.Drawing.Point(PictureBox2.Location.X, (PictureBox2.Location.Y + 1))
            a2 = PictureBox2.Location.Y + 1
        End If
        If (a3 > 395) Then
            PictureBox3.Location = New System.Drawing.Point((PictureBox3.Location.X - 1), PictureBox3.Location.Y)
            a3 = PictureBox3.Location.X - 1
        Else
            PictureBox6.Visible = True
            Timer1.Enabled = False
            Timer3.Enabled = True

        End If
    End Sub

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Form2.picture1.picture = loadpicture("C:\picture.jpg")
        'Form2.picture1.picture = loadpicture("C:\picture.jpg")
        'Form2.PictureBox3.Image = loadpicture("C:\picture.jpg")
        Timer1.Enabled = True
    End Sub

    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If (a4 < 332) Then
            PictureBox5.Location = New System.Drawing.Point(PictureBox5.Location.X, (PictureBox5.Location.Y + 1))
            a4 = PictureBox5.Location.Y + 1
        Else
            Form2.Visible = True
            Me.Visible = False
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        If Count = 1 Then
            Label1.Visible = True
            Count = Count + 1
        ElseIf Count = 2 Then
            Label2.Visible = True
            Count = Count + 1
        ElseIf Count = 3 Then
            Label3.Visible = True
            Count = Count + 1
        Else
            Timer3.Enabled = False
            Timer2.Enabled = True

        End If
    End Sub
End Class