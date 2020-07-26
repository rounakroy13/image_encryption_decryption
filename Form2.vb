Public Class Form2
    Dim n1 As Integer
    Dim n2 As Integer
    Dim n3 As Integer
    Dim nx As Integer
    Dim ny As Integer
    ' Dim i1 As Bitmap = New Bitmap(PictureBox1.Image)
    ' Dim i2 As Bitmap = New Bitmap(PictureBox2.Image)
    'Dim i3 As Bitmap = New Bitmap(PictureBox3.Image)
    Dim store1(100000, 6) As Integer
    Dim store2(100000, 6) As Integer
    Dim store3(100000, 6) As Integer
    Dim temporarystorage(100000, 6) As Integer
    Dim encrypt(100000, 6) As Integer
    Dim encrypt1(100000, 6) As Integer
    Dim minh As Integer = 150
    Dim minw As Integer = 220
    ' Dim ColourCode1(100000, 10) As String
    'Dim ColourCode2(100000, 10) As String
    'Dim ColourCode3(100000, 10) As String
    'Dim arr(100000, 12) As Integer
    Dim c2 As Color
    Dim c3 As Color
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, PictureBox6.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.ImageLocation = OpenFileDialog1.FileName
            ' If Button1.Visible = True Then Button1.Visible = False
            'If Button4.Visible = False Then Button4.Visible = True
            '  If ListBox1.Visible = False Then ListBox1.Visible = True
            'If Label2.Visible = False Then Label2.Visible = True
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, PictureBox7.Click
        If OpenFileDialog2.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox2.ImageLocation = OpenFileDialog2.FileName
            ' If Button2.Visible = True Then Button2.Visible = False
            'If Button5.Visible = False Then Button5.Visible = True
            ' If ListBox2.Visible = False Then ListBox2.Visible = True
            'If Label3.Visible = False Then Label3.Visible = True
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click, PictureBox8.Click
        If OpenFileDialog3.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox3.ImageLocation = OpenFileDialog3.FileName
            'If Button3.Visible = True Then Button3.Visible = False
            'If Button6.Visible = False Then Button6.Visible = True
            '   If ListBox3.Visible = False Then ListBox3.Visible = True
            '  If Button5.Visible = True Then Button5.Visible = False
            '    If Label4.Visible = False Then Label4.Visible = True
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim i1 As Bitmap = New Bitmap(PictureBox1.Image)
        Dim i2 As Bitmap = New Bitmap(PictureBox2.Image)
        Dim i3 As Bitmap = New Bitmap(PictureBox3.Image)
        'Dim img3 As Bitmap = DirectCast(PictureBox3.Image.Clone, Bitmap)
        ' Dim minh As Integer
        'Dim minw As Integer
        '        maxh = img1.Height
        '       maxw = img1.Width
        If i1.Height <= i2.Height Then
            minh = i1.Height
        ElseIf i1.Height > i2.Height Then
            minh = i2.Height
        End If
        If minh <= i3.Height Then
            minh = minh
        ElseIf minh > i3.Height Then
            minh = i3.Height
        End If
        If i1.Width <= i2.Width Then
            minw = i1.Width
        ElseIf i1.Width > i2.Width Then
            minw = i2.Width
        End If
        minh = minh
        minw = minw

        If minw <= i3.Width Then
            minw = minw
        ElseIf minw < i3.Width Then
            minw = i3.Width
        End If

        Dim img1 As Bitmap = DirectCast(PictureBox1.Image.Clone, Bitmap)
        Dim img11 As New Bitmap(minw, minh)
        Dim gr As Graphics = Graphics.FromImage(img11)
        gr.DrawImage(img1, New Rectangle(Point.Empty, img11.Size), New Rectangle(10, 10, minw, minh), GraphicsUnit.Pixel)
        PictureBox1.Image = img11
        Dim img As Bitmap = DirectCast(PictureBox2.Image.Clone, Bitmap)
        Dim img2 As New Bitmap(minw, minh)
        Dim gr1 As Graphics = Graphics.FromImage(img2)
        gr1.DrawImage(img, New Rectangle(Point.Empty, img2.Size), New Rectangle(10, 10, minw, minh), GraphicsUnit.Pixel)
        PictureBox2.Image = img2
        Dim img3 As Bitmap = DirectCast(PictureBox3.Image.Clone, Bitmap)
        Dim img33 As New Bitmap(minw, minh)
        Dim gr3 As Graphics = Graphics.FromImage(img33)
        gr3.DrawImage(img3, New Rectangle(Point.Empty, img33.Size), New Rectangle(10, 10, minw, minh), GraphicsUnit.Pixel)
        PictureBox3.Image = img33
        ' ImageLoc3 = PictureBox3.Image.ToString()
     
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click, Button5.Click
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
            n1 = n

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
                    store1(c, 1) = i1
                    store1(c, 2) = j1
                    store1(c, 3) = r1
                    store1(c, 4) = g1
                    store1(c, 5) = b1
                    temporarystorage(c, 1) = i1
                    temporarystorage(c, 2) = j1
                    temporarystorage(c, 3) = r1
                    'ch = c1.Name
                    'ListBox1.Items.Add(vbNewLine + (ch.ToString))
                    'For d = 0 To 8
                    ' ColourCode1(c, 1) = c1.Name
                    'ListBox1.Items.Add(vbNewLine + (ColourCode1(c, d).ToString))
                    'Next

                    c = (c + 1)
                    ' Next
                    'ListBox1.Items.Add((store1(r1, 1).ToString + ("," + (store1(r1, 2).ToString))))
                    j1 = (j1 + 1)
                Loop
                i1 = (i1 + 1)
            Loop

            ' MessageBox.Show("SUCESSFULLY DONE")
            '      Button6.PerformClick()
            Button6_Click(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            ListBox2.Items.Clear()
            ListBox2.Items.Add("Pixel       R     G      B      Color")

            Dim img2 As Bitmap = New Bitmap(PictureBox2.Image)

            Dim n As Integer
            Dim c As Integer = 0
            If img2.Height >= img2.Width Then
                n2 = img2.Height
            ElseIf img2.Height < img2.Width Then
                n2 = img2.Width
            End If
            n2 = n
            Dim i2 As Integer = 0
            Do While (i2 < img2.Width)
                Dim j2 As Integer = 0
                Do While (j2 < img2.Height)
                    c2 = img2.GetPixel(i2, j2)
                    Dim r2 As Integer = Convert.ToInt16(c2.R)
                    Dim g2 As Integer = Convert.ToInt16(c2.G)
                    Dim b2 As Integer = Convert.ToInt16(c2.B)
                    ListBox2.Items.Add((i2.ToString + ("," + (j2.ToString + ("             " + (r2.ToString + ("      " + (g2.ToString + ("      " + (b2.ToString + ("         " + (c2.Name))))))))))))

                    ' arr(r2, 2) = arr(r2, 2) + 1
                    store2(c, 1) = i2
                    store2(c, 2) = j2
                    store2(c, 3) = r2
                    store2(c, 4) = g2
                    store2(c, 5) = b2
                    temporarystorage(c, 4) = r2
                    c = (c + 1)
                    'ColourCode2(c, 1) = c2.Name
                    j2 = (j2 + 1)
                Loop
                i2 = (i2 + 1)
            Loop

            ' MessageBox.Show("SUCESSFULLY DONE")
            'Button7.PerformClick()
            Button7_Click(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ListBox3.Items.Clear()
        ListBox3.Items.Add("Pixel   R       G       B      color")
        Try
            Dim img3 As Bitmap = New Bitmap(PictureBox3.Image)

            Dim n As Integer
            Dim c As Integer = 0
            If img3.Height >= img3.Width Then
                n3 = img3.Height
            ElseIf img3.Height < img3.Width Then
                n3 = img3.Width
            End If
            n3 = n
            Dim i3 As Integer = 0
            Do While (i3 < img3.Width)
                Dim j3 As Integer = 0
                Do While (j3 < img3.Height)
                    c3 = img3.GetPixel(i3, j3)
                    Dim r3 As Integer = Convert.ToInt16(c3.R)
                    Dim g3 As Integer = Convert.ToInt16(c3.G)
                    Dim b3 As Integer = Convert.ToInt16(c3.B)
                    ListBox3.Items.Add((i3.ToString + ("," + (j3.ToString + ("      " + (r3.ToString + ("     " + (g3.ToString + ("     " + (b3.ToString + ("     " + (c3.Name))))))))))))
                    'arr(r3, 3) = arr(r3, 3) + 1
                    'arr(r3, 0) = i3
                    store3(c, 1) = i3
                    store3(c, 2) = j3
                    store3(c, 3) = r3
                    store3(c, 4) = g3
                    store3(c, 5) = b3
                    temporarystorage(c, 5) = r3
                    ' ColourCode3(c, 1) = c3.Name
                    c = (c + 1)
                    j3 = (j3 + 1)
                    nx = c
                Loop
                i3 = (i3 + 1)
            Loop
            MessageBox.Show("SUCESSFULLY DONE")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click, PictureBox10.Click
        Try
            Dim i As Integer = 0
            Dim r As Integer
            Dim D As Integer
            Dim i1 As Bitmap = New Bitmap(PictureBox1.Image)
            Dim j As Integer = 0
            ListBox5.Items.Clear()
            ListBox5.Items.Add("Pixel   R       G       B      ")
            '  For i = 0 To 100000
            'ListBox5.Items.Add((temporarystorage(i, 1).ToString + ("," + (temporarystorage(i, 2).ToString + ("             " + (temporarystorage(i, 3).ToString + ("      " + (temporarystorage(i, 4).ToString + ("      " + (temporarystorage(i, 5).ToString))))))))))
            ' Next
            For i = 0 To nx - 1
                'If (Not (temporarystorage(i, 1) = 0) And Not (temporarystorage(i, 2) = 0)) Then
                ListBox5.Items.Add((temporarystorage(i, 1).ToString + ("," + (temporarystorage(i, 2).ToString + ("             " + (temporarystorage(i, 3).ToString + ("      " + (temporarystorage(i, 4).ToString + ("      " + (temporarystorage(i, 5).ToString))))))))))
                'End If
            Next
            ListBox4.Items.Clear()
            ListBox4.Items.Add("Pixel   R       G       B      ")
            For i = 0 To 100000
                encrypt(i, 1) = temporarystorage(i, 1)
                encrypt(i, 2) = temporarystorage(i, 2)
                ' i = (i + 1)
            Next
            For i = 0 To 100000
                D = 128
                For r = 0 To 63

                    If temporarystorage(i, 3) = r Then

                        ' For j = 0 To 63
                        'If j = r Then
                        encrypt(i, 3) = D
                    End If
                    D = (D + 1)
                    'j = j + 1
                Next
                D = 128
                For r = 0 To 63
                    'D = 127
                    If temporarystorage(i, 4) = r Then

                        ' For j = 0 To 63
                        'If j = r Then
                        encrypt(i, 4) = D
                    End If
                    D = (D + 1)
                    'j = j + 1
                Next
                D = 128
                For r = 0 To 63
                    'D = 127
                    If temporarystorage(i, 5) = r Then

                        ' For j = 0 To 63
                        'If j = r Then
                        encrypt(i, 5) = D
                    End If
                    D = (D + 1)
                    'j = j + 1
                Next
            Next
            For i = 0 To 100000
                D = 192
                For r = 64 To 127

                    If temporarystorage(i, 3) = r Then
                        ' D = 192
                        'For j = 64 To 127
                        'If j = r Then
                        encrypt(i, 3) = D
                    End If
                    D = (D + 1)
                Next
                D = 192
                For r = 64 To 127

                    If temporarystorage(i, 4) = r Then
                        ' D = 192
                        'For j = 64 To 127
                        'If j = r Then
                        encrypt(i, 4) = D
                    End If
                    D = (D + 1)
                Next
                D = 192
                For r = 64 To 127

                    If temporarystorage(i, 5) = r Then
                        ' D = 192
                        'For j = 64 To 127
                        'If j = r Then
                        encrypt(i, 5) = D
                    End If
                    D = (D + 1)
                Next
            Next
            For i = 0 To 100000
                D = 0
                For r = 128 To 191

                    If temporarystorage(i, 3) = r Then
                        'D = 0
                        'For j = 127 To 190
                        ' If j = r Then
                        encrypt(i, 3) = D
                    End If
                    D = (D + 1)
                Next
                D = 0
                For r = 128 To 191

                    If temporarystorage(i, 4) = r Then
                        'D = 0
                        'For j = 127 To 190
                        ' If j = r Then
                        encrypt(i, 4) = D
                    End If
                    D = (D + 1)
                Next
                D = 0
                For r = 128 To 191

                    If temporarystorage(i, 5) = r Then
                        'D = 0
                        'For j = 127 To 190
                        ' If j = r Then
                        encrypt(i, 5) = D
                    End If
                    D = (D + 1)
                Next
            Next
            For i = 0 To 100000
                D = 64
                For r = 192 To 255

                    If temporarystorage(i, 3) = r Then
                        ' D = 64
                        'For j = 192 To 255
                        ' If j = r Then
                        encrypt(i, 3) = D
                    End If
                    D = (D + 1)
                Next
                D = 64
                For r = 192 To 255

                    If temporarystorage(i, 4) = r Then
                        ' D = 64
                        'For j = 192 To 255
                        ' If j = r Then
                        encrypt(i, 4) = D
                    End If
                    D = (D + 1)
                Next
                D = 64
                For r = 192 To 255

                    If temporarystorage(i, 5) = r Then
                        ' D = 64
                        'For j = 192 To 255
                        ' If j = r Then
                        encrypt(i, 5) = D
                    End If
                    D = (D + 1)
                Next
                'D = (D + 1)
                ' ListBox4.Items.Add((encrypt(i, 1).ToString + ("," + (encrypt(i, 2).ToString + ("             " + (encrypt(i, 3).ToString))))))

            Next

            'ListBox4.Items.Add((encrypt(i, 1).ToString + ("," + (encrypt(i, 2).ToString + ("             " + (encrypt(i, 3).ToString + ("      " + (encrypt(i, 4).ToString + ("      " + (encrypt(i, 5).ToString))))))))))

            For i = 0 To nx - 1
                'If (Not (encrypt(i, 1) = 0) And Not (encrypt(i, 2) = 0)) Then

                ListBox4.Items.Add((encrypt(i, 1).ToString + ("," + (encrypt(i, 2).ToString + ("             " + (encrypt(i, 3).ToString + ("      " + (encrypt(i, 4).ToString + ("      " + (encrypt(i, 5).ToString))))))))))
                'i = (i + 1)
                'End If
            Next
            ListBox6.Items.Clear()
            ListBox6.Items.Add("Pixel   R       G       B      ")
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

                ListBox6.Items.Add((encrypt1(i, 1).ToString + ("," + (encrypt1(i, 2).ToString + ("             " + (encrypt1(i, 3).ToString + ("      " + (encrypt1(i, 4).ToString + ("      " + (encrypt1(i, 5).ToString))))))))))
                'i = (i + 1)

                'End If
            Next
            Dim img As Bitmap
            img = New Bitmap(minw, minh)
            'img.SetPixel(50, 50, Color.FromArgb(100, 255, 255, 200))
            'pb1.BackgroundImage = img

            For i = 0 To nx - 1
                img.SetPixel(encrypt1(i, 1), encrypt1(i, 2), Color.FromArgb(255, encrypt1(i, 3), encrypt1(i, 4), encrypt1(i, 5)))
            Next

            Me.Visible = False
            Form4.Visible = True
            'MessageBox.Show("SUCESSFULLY DONE")
            Form4.PictureBox1.Image = PictureBox1.Image
            Form4.PictureBox2.Image = PictureBox2.Image
            Form4.PictureBox3.Image = PictureBox3.Image
            Form4.PictureBox5.Image = img

            PictureBox4.Image = img
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'MsgBox("A receipt will now be saved to your files")
        'MsgBox("Save encrypt_pic folder")
        MsgBox("save the file in your hard disk", vbOKOnly, "Thank you ")
        SaveFileDialog1.ShowDialog()
        MsgBox("Remember the name by which you save,for decryption purpose", vbOKOnly, "Thank you")

    End Sub
    'Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
    'Dim FileToSaveAs As String = System.IO.Path.Combine(My.Computer.FileSystem.c.Temp, SaveFileDialog1.FileName)
    '   PictureBox4.Image.Save(FileToSaveAs, System.Drawing.Imaging.ImageFormat.Jpeg)
    'End Sub
    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim FileToSaveAs As String = SaveFileDialog1.FileName
        PictureBox4.Image.Save(FileToSaveAs, System.Drawing.Imaging.ImageFormat.Bmp)
        'Dim objwriter As New System.IO.StreamWriter(FileToSaveAs)
        'objwriter.Write(PictureBox4)
        'objwriter.Close()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click, PictureBox5.Click
        Me.Visible = False
        Form1.Show()
        Form1.Visible = True
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click, PictureBox9.Click
        ListBox7.Items.Clear()
        ListBox7.Items.Add("Pixel       R           G           B           Color")
        Try

            Dim img1 As Bitmap = New Bitmap(PictureBox4.Image)
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
                    ListBox7.Items.Add((i1.ToString + ("," + (j1.ToString + ("             " + (r1.ToString + ("      " + (g1.ToString + ("      " + (b1.ToString + ("         " + (c1.Name))))))))))))
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
            Loop

            MessageBox.Show("SUCESSFULLY DONE")

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

  
    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = PictureBox1.BackgroundImage
        PictureBox2.Image = PictureBox2.BackgroundImage
        PictureBox3.Image = PictureBox3.BackgroundImage

    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        Dim img1 As Bitmap = New Bitmap(PictureBox1.Image)
        PictureBox1.Image = ResizeImage(PictureBox1.Image, 220, 150, Convert.ToInt32(img1.Width), Convert.ToInt32(img1.Height))
        Dim img2 As Bitmap = New Bitmap(PictureBox2.Image)
        PictureBox2.Image = ResizeImage(PictureBox2.Image, 220, 150, Convert.ToInt32(img2.Width), Convert.ToInt32(img2.Height))
        Dim img3 As Bitmap = New Bitmap(PictureBox3.Image)
        PictureBox3.Image = ResizeImage(PictureBox3.Image, 220, 150, Convert.ToInt32(img3.Width), Convert.ToInt32(img3.Height))
        ' Dim img As Bitmap = New Bitmap(PictureBox1.Image)
    End Sub
    Public Overloads Shared Function ResizeImage(ByVal SourceImage As Drawing.Image, ByVal TargetWidth As Int32, ByVal TargetHeight As Int32, ByVal sw As Integer, ByVal sh As Integer) As Drawing.Bitmap
        Dim bmSource = New Drawing.Bitmap(SourceImage)

        Return ResizeImage(bmSource, TargetWidth, TargetHeight, sw, sh)
    End Function

    Public Overloads Shared Function ResizeImage(ByVal bmSource As Drawing.Bitmap, ByVal TargetWidth As Int32, ByVal TargetHeight As Int32, ByVal sw As Integer, ByVal sh As Integer) As Drawing.Bitmap
        Dim bmDest As New Drawing.Bitmap(TargetWidth, TargetHeight, Drawing.Imaging.PixelFormat.Format32bppArgb)

        Dim nSourceAspectRatio = bmSource.Width / bmSource.Height
        'Dim nDestAspectRatio = bmDest.Width / bmDest.Height
        Dim nDestAspectRatio = sw / sh

        Dim NewX = 0
        Dim NewY = 0
        Dim NewWidth = 220
        Dim NewHeight = 150

        If nDestAspectRatio = nSourceAspectRatio Then
            'same ratio
        ElseIf nDestAspectRatio > nSourceAspectRatio Then
            'Source is taller
            NewWidth = Convert.ToInt32(Math.Floor(nSourceAspectRatio * NewHeight))
            NewX = Convert.ToInt32(Math.Floor((bmDest.Width - NewWidth) / 2))
        Else
            'Source is wider
            NewHeight = Convert.ToInt32(Math.Floor((1 / nSourceAspectRatio) * NewWidth))
            NewY = Convert.ToInt32(Math.Floor((bmDest.Height - NewHeight) / 2))
        End If

        Using grDest = Drawing.Graphics.FromImage(bmDest)
            With grDest
                .CompositingQuality = Drawing.Drawing2D.CompositingQuality.HighQuality
                .InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                .PixelOffsetMode = Drawing.Drawing2D.PixelOffsetMode.HighQuality
                .SmoothingMode = Drawing.Drawing2D.SmoothingMode.AntiAlias
                .CompositingMode = Drawing.Drawing2D.CompositingMode.SourceOver

                .DrawImage(bmSource, NewX, NewY, NewWidth, NewHeight)
            End With
        End Using

        Return bmDest
    End Function
End Class