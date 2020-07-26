Public Class Form5
    Dim a1 As Integer = 6
    Dim a2 As Integer = 393
    Dim a3 As Integer = 393
    Dim a4 As Integer = 170
    Dim count As Integer = 1

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click

    End Sub
    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub
    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click

    End Sub
    Private Sub Form5_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If (a1 < 171) Then
            PictureBox5.Location = New System.Drawing.Point(PictureBox5.Location.X, (PictureBox5.Location.Y + 1))
            a1 = PictureBox5.Location.Y + 1
        Else
            Timer1.Enabled = False
            PictureBox6.Visible = True
            Timer3.Enabled = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If (a2 > 48) Then
            PictureBox1.Location = New System.Drawing.Point((PictureBox1.Location.X - 1), PictureBox1.Location.Y)
            a2 = PictureBox1.Location.X - 1
        End If
        If (a3 < 745) Then
            PictureBox3.Location = New System.Drawing.Point((PictureBox3.Location.X + 1), PictureBox3.Location.Y)
            a3 = PictureBox3.Location.X + 1
        Else
            Me.Visible = False
            Form3.Visible = True
            Timer2.Enabled = False
        End If
        If (a4 < 347) Then
            PictureBox2.Location = New System.Drawing.Point(PictureBox2.Location.X, (PictureBox2.Location.Y + 1))
            a4 = PictureBox2.Location.Y + 1
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

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click

    End Sub
End Class