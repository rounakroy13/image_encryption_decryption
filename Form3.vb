Public Class Form3
    Dim n2 As Integer
    Dim n3 As Integer
    Dim nx As Integer
    Dim y As Integer
    Dim x As Integer
    ' Dim i1 As Bitmap = New Bitmap(PictureBox1.Image)
    ' Dim i2 As Bitmap = New Bitmap(PictureBox2.Image)
    'Dim i3 As Bitmap = New Bitmap(PictureBox3.Image)
    Dim store1(100000, 6) As Integer
    Dim store2(100000, 6) As Integer
    Dim store3(100000, 6) As Integer
    Dim temporarystorage(100000, 6) As Integer
    Dim encrypt(100000, 6) As Integer
    Dim encrypt1(100000, 6) As Integer
    Dim minh As Integer
    Dim minw As Integer
    ' Dim ColourCode1(100000, 10) As String
    'Dim ColourCode2(100000, 10) As String
    'Dim ColourCode3(100000, 10) As String
    'Dim arr(100000, 12) As Integer
    Dim c2 As Color
    Dim c3 As Color
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, PictureBox7.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.ImageLocation = OpenFileDialog1.FileName
            ' If Button1.Visible = True Then Button1.Visible = False
            'If Button4.Visible = False Then Button4.Visible = True
            '  If ListBox1.Visible = False Then ListBox1.Visible = True
            'If Label2.Visible = False Then Label2.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, PictureBox9.Click
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Pixel       R           G           B           Color")
        Try

            Dim img1 As Bitmap = New Bitmap(PictureBox1.Image)
            Dim n As Integer
            Dim c1 As Color
            'Dim ch As Char
            Dim c As Integer = 0
            If img1.Height >= img1.Width Then
                n = img1.Height
            ElseIf img1.Height < img1.Width Then
                n = img1.Width
            End If
            'n1 = n

            Dim i1 As Integer = 0
            'Dim Count1 As Integer = 0
            Do While (i1 < img1.Width)
                Dim j1 As Integer = 0
                Do While (j1 < img1.Height)
                    ' For c = i1 To j1
                    c1 = img1.GetPixel(i1, j1)
                    Dim r1 As Integer = Convert.ToInt16(c1.R)
                    Dim g1 As Integer = Convert.ToInt16(c1.G)
                    Dim b1 As Integer = Convert.ToInt16(c1.B)
                    ListBox1.Items.Add((i1.ToString + ("," + (j1.ToString + ("             " + (r1.ToString + ("      " + (g1.ToString + ("      " + (b1.ToString + ("         " + (c1.Name))))))))))))
                    '  arr(r1, 1) = arr(r1, 1) + 1
                    encrypt(c, 1) = i1
                    encrypt(c, 2) = j1
                    encrypt(c, 3) = r1
                    encrypt(c, 4) = g1
                    encrypt(c, 5) = b1
                    'temporarystorage(c, 1) = i1
                    'temporarystorage(c, 2) = j1
                    'temporarystorage(c, 3) = r1
                    'ch = c1.Name
                    'ListBox1.Items.Add(vbNewLine + (ch.ToString))
                    'For d = 0 To 8
                    ' ColourCode1(c, 1) = c1.Name
                    'ListBox1.Items.Add(vbNewLine + (ColourCode1(c, d).ToString))
                    'Next

                    c = (c + 1)
                    nx = c

                    ' Next
                    'ListBox1.Items.Add((store1(r1, 1).ToString + ("," + (store1(r1, 2).ToString))))
                    j1 = (j1 + 1)
                Loop
                i1 = (i1 + 1)
                y = j1
            Loop
            x = i1

            MessageBox.Show("SUCESSFULLY DONE")

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click, PictureBox5.Click
        Try
            Dim i As Integer
            Dim r As Integer
            Dim D As Integer
            Dim i1 As Bitmap = New Bitmap(PictureBox1.Image)
            Dim j As Integer = 0
            ListBox2.Items.Clear()
            ListBox2.Items.Add("Pixel       R           G           B           Color")
            For i = 0 To nx - 1
                If ((encrypt(i, 3) >= encrypt(i, 4)) And (encrypt(i, 3) >= encrypt(i, 5))) Then
                    encrypt1(i, 1) = encrypt(i, 1)
                    encrypt1(i, 2) = encrypt(i, 2)
                    encrypt1(i, 3) = encrypt(i, 3)
                    encrypt1(i, 4) = (encrypt(i, 3) - encrypt(i, 4))
                    encrypt1(i, 5) = (encrypt(i, 3) - encrypt(i, 5))
                ElseIf ((encrypt(i, 4) >= encrypt(i, 3)) And (encrypt(i, 4) >= encrypt(i, 5))) Then
                    encrypt1(i, 1) = encrypt(i, 1)
                    encrypt1(i, 2) = encrypt(i, 2)
                    encrypt1(i, 3) = (encrypt(i, 4) - encrypt(i, 3))
                    encrypt1(i, 4) = encrypt(i, 4)
                    encrypt1(i, 5) = (encrypt(i, 4) - encrypt(i, 5))
                ElseIf ((encrypt(i, 5) >= encrypt(i, 3)) And (encrypt(i, 5) >= encrypt(i, 4))) Then
                    encrypt1(i, 1) = encrypt(i, 1)
                    encrypt1(i, 2) = encrypt(i, 2)
                    encrypt1(i, 3) = (encrypt(i, 5) - encrypt(i, 3))
                    encrypt1(i, 4) = (encrypt(i, 5) - encrypt(i, 4))
                    encrypt1(i, 5) = encrypt(i, 5)
                End If
            Next
            For i = 0 To nx - 1
                'If (Not (encrypt(i, 1) = 0) And Not (encrypt(i, 2) = 0)) Then

                ListBox2.Items.Add((encrypt1(i, 1).ToString + ("," + (encrypt1(i, 2).ToString + ("             " + (encrypt1(i, 3).ToString + ("      " + (encrypt1(i, 4).ToString + ("      " + (encrypt1(i, 5).ToString))))))))))
                'i = (i + 1)

                'End If
            Next
            ListBox3.Items.Clear()
            ListBox3.Items.Add("Pixel       R           G           B           Color")
            For i = 0 To 100000
                temporarystorage(i, 1) = encrypt1(i, 1)
                temporarystorage(i, 2) = encrypt1(i, 2)
                ' i = (i + 1)
            Next
            For i = 0 To 100000
                D = 127
                For r = 0 To 63

                    If encrypt1(i, 3) = r Then

                        ' For j = 0 To 63
                        'If j = r Then
                        temporarystorage(i, 3) = D
                    End If
                    D = (D + 1)
                    'j = j + 1
                Next
                D = 127
                For r = 0 To 63
                    'D = 127
                    If encrypt1(i, 4) = r Then

                        ' For j = 0 To 63
                        'If j = r Then
                        temporarystorage(i, 4) = D
                    End If
                    D = (D + 1)
                    'j = j + 1
                Next
                D = 127
                For r = 0 To 63
                    'D = 127
                    If encrypt1(i, 5) = r Then

                        ' For j = 0 To 63
                        'If j = r Then
                        temporarystorage(i, 5) = D
                    End If
                    D = (D + 1)
                    'j = j + 1
                Next
            Next
            For i = 0 To 100000
                D = 192
                For r = 64 To 127

                    If encrypt1(i, 3) = r Then
                        ' D = 192
                        'For j = 64 To 127
                        'If j = r Then
                        temporarystorage(i, 3) = D
                    End If
                    D = (D + 1)
                Next
                D = 192
                For r = 64 To 127

                    If encrypt1(i, 4) = r Then
                        ' D = 192
                        'For j = 64 To 127
                        'If j = r Then
                        temporarystorage(i, 4) = D
                    End If
                    D = (D + 1)
                Next
                D = 192
                For r = 64 To 127

                    If encrypt1(i, 5) = r Then
                        ' D = 192
                        'For j = 64 To 127
                        'If j = r Then
                        temporarystorage(i, 5) = D
                    End If
                    D = (D + 1)
                Next
            Next
            For i = 0 To 100000
                D = 0
                For r = 128 To 191

                    If encrypt1(i, 3) = r Then
                        'D = 0
                        'For j = 127 To 190
                        ' If j = r Then
                        temporarystorage(i, 3) = D
                    End If
                    D = (D + 1)
                Next
                D = 0
                For r = 128 To 191

                    If encrypt1(i, 4) = r Then
                        'D = 0
                        'For j = 127 To 190
                        ' If j = r Then
                        temporarystorage(i, 4) = D
                    End If
                    D = (D + 1)
                Next
                D = 0
                For r = 128 To 191

                    If encrypt1(i, 5) = r Then
                        'D = 0
                        'For j = 127 To 190
                        ' If j = r Then
                        temporarystorage(i, 5) = D
                    End If
                    D = (D + 1)
                Next
            Next
            For i = 0 To 100000
                D = 64
                For r = 192 To 255

                    If encrypt1(i, 3) = r Then
                        ' D = 64
                        'For j = 192 To 255
                        ' If j = r Then
                        temporarystorage(i, 3) = D
                    End If
                    D = (D + 1)
                Next
                D = 64
                For r = 192 To 255

                    If encrypt1(i, 4) = r Then
                        ' D = 64
                        'For j = 192 To 255
                        ' If j = r Then
                        temporarystorage(i, 4) = D
                    End If
                    D = (D + 1)
                Next
                D = 64
                For r = 192 To 255

                    If encrypt1(i, 5) = r Then
                        ' D = 64
                        'For j = 192 To 255
                        ' If j = r Then
                        temporarystorage(i, 5) = D
                    End If
                    D = (D + 1)
                Next
                'D = (D + 1)
                ' ListBox4.Items.Add((encrypt(i, 1).ToString + ("," + (encrypt(i, 2).ToString + ("             " + (encrypt(i, 3).ToString))))))

            Next

            'ListBox4.Items.Add((encrypt(i, 1).ToString + ("," + (encrypt(i, 2).ToString + ("             " + (encrypt(i, 3).ToString + ("      " + (encrypt(i, 4).ToString + ("      " + (encrypt(i, 5).ToString))))))))))

            For i = 0 To nx - 1
                'If (Not (encrypt(i, 1) = 0) And Not (encrypt(i, 2) = 0)) Then

                ListBox3.Items.Add((temporarystorage(i, 1).ToString + ("," + (temporarystorage(i, 2).ToString + ("             " + (temporarystorage(i, 3).ToString + ("      " + (temporarystorage(i, 4).ToString + ("      " + (temporarystorage(i, 5).ToString))))))))))
                'i = (i + 1)
                'End If
            Next

            MessageBox.Show("SUCESSFULLY DONE")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click, PictureBox6.Click
        Dim img1 As Bitmap
        Dim img2 As Bitmap
        Dim img3 As Bitmap
        img1 = New Bitmap(x, y)
        img2 = New Bitmap(x, y)
        img3 = New Bitmap(x, y)
        'img.SetPixel(50, 50, Color.FromArgb(100, 255, 255, 200))
        'pb1.BackgroundImage = img

        For i = 0 To nx - 1
            img1.SetPixel(temporarystorage(i, 1), temporarystorage(i, 2), Color.FromArgb(255, temporarystorage(i, 3), temporarystorage(i, 3), temporarystorage(i, 3)))
        Next
        'PictureBox2.Image = img1
        For i = 0 To nx - 1
            img2.SetPixel(temporarystorage(i, 1), temporarystorage(i, 2), Color.FromArgb(255, temporarystorage(i, 4), temporarystorage(i, 4), temporarystorage(i, 4)))
        Next
        ' PictureBox3.Image = img2
        For i = 0 To nx - 1
            img3.SetPixel(temporarystorage(i, 1), temporarystorage(i, 2), Color.FromArgb(255, temporarystorage(i, 5), temporarystorage(i, 5), temporarystorage(i, 5)))
        Next
        ' PictureBox4.Image = img3
        Me.Visible = False
        Form5.Visible = True
        Form5.PictureBox5.Image = PictureBox1.Image
        Form5.PictureBox1.Image = img1
        Form5.PictureBox3.Image = img2
        Form5.PictureBox2.Image = img3
        PictureBox2.Image = img1
        PictureBox3.Image = img2
        PictureBox4.Image = img3


    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub


    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        MessageBox.Show("Save 1st Picture")
        SaveFileDialog1.ShowDialog()
        MessageBox.Show("Save 2nd Picture")
        SaveFileDialog2.ShowDialog()
        MessageBox.Show("Save 3rd Picture")
        SaveFileDialog3.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim FileToSaveAs As String = SaveFileDialog1.FileName
        PictureBox2.Image.Save(FileToSaveAs, System.Drawing.Imaging.ImageFormat.Bmp)
    End Sub

    Private Sub SaveFileDialog2_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog2.FileOk
        Dim FileToSaveAs As String = SaveFileDialog2.FileName
        PictureBox3.Image.Save(FileToSaveAs, System.Drawing.Imaging.ImageFormat.Bmp)
    End Sub

    Private Sub SaveFileDialog3_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog3.FileOk
        Dim FileToSaveAs As String = SaveFileDialog3.FileName
        PictureBox4.Image.Save(FileToSaveAs, System.Drawing.Imaging.ImageFormat.Bmp)
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class