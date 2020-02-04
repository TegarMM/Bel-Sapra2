Imports System.Data.OleDb

Public Class Ujian


    Dim PathJam1, PathJam2, PathJam3, PathJam4, PathJam5, PathJam6, PathJam7, PathJam8, PathKurang1, PathKurang2, Pathkurang3, PathKurang4, PathKurang5, Pathkurang6, Pathkurang7, Pathkurang8, pathSelesai1, pathSelesai2, PathSelesai3, PathSelesai4, PathSelesai5, PathSelesai6, PathSelesai7, PathSelesai8 As String

    Private Sub TimerTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTime.Tick
        LblTime.Text = TimeOfDay
    End Sub

    Private Function GetData(ByVal keterangan As String, ByVal cells As Integer)

        cmd = New OleDbCommand("Select * from Ujian where keterangan='" & keterangan & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Return dr.Item(cells)
        Else
            Return 0
        End If

    End Function

    Private Sub DataToTimePicker()
        TimePicker1.Text = GetData("Jam Pertama", 0)
        TimePickerKurang1.Text = GetData("Kurang 5 Menit(1)", 0)
        TimePickerSelesai1.Text = GetData("Selesai Pertama", 0)
        TimePicker2.Text = GetData("Jam Kedua", 0)
        TimePickerKurang2.Text = GetData("Kurang 5 Menit(2)", 0)
        TimePickerSelesai2.Text = GetData("Selesai Kedua", 0)
        TimePicker3.Text = GetData("Jam Ketiga", 0)
        TimePickerKurang3.Text = GetData("Kurang 5 Menit(3)", 0)
        TimePickerSelesai3.Text = GetData("Selesai Ketiga", 0)
        TimePicker4.Text = GetData("Jam Keempat", 0)
        TimePickerKurang4.Text = GetData("Kurang 5 Menit(4)", 0)
        TimePickerSelesai4.Text = GetData("Selesai Keempat", 0)
        TimePicker5.Text = GetData("Jam Kelima", 0)
        TimePickerKurang5.Text = GetData("Kurang 5 Menit(5)", 0)
        TimePickerSelesai5.Text = GetData("Selesai Kelima", 0)
        TimePicker6.Text = GetData("Jam Keenam", 0)
        TimePickerKurang6.Text = GetData("Kurang 5 Menit(6)", 0)
        TimePickerSelesai6.Text = GetData("Selesai Keenam", 0)
        TimePicker7.Text = GetData("Jam Ketujuh", 0)
        TimePickerKurang7.Text = GetData("Kurang 5 Menit(7)", 0)
        TimePickerSelesai7.Text = GetData("Selesai Ketujuh", 0)
        TimePicker8.Text = GetData("Jam Kedelapan", 0)
        TimePickerKurang8.Text = GetData("Kurang 5 Menit(8)", 0)
        TimePickerSelesai8.Text = GetData("Selesai Kedelapan", 0)
    End Sub

    Private Sub TimerValidate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerValidate.Tick
        If TimePicker1.Text = TimeOfDay Then
            If Not PathJam1 = "" Then
                MenuAwal.WMP.URL = PathJam1
            Else
                MenuAwal.WMP.URL = GetData("Jam Pertama", 2)
            End If
        ElseIf TimePickerKurang1.Text = TimeOfDay Then
            If Not PathKurang1 = "" Then
                MenuAwal.WMP.URL = PathKurang1
            Else
                MenuAwal.WMP.URL = GetData("Kurang 5 Menit(1)", 2)
            End If
        ElseIf TimePickerSelesai1.Text = TimeOfDay Then
            If Not pathSelesai1 = "" Then
                MenuAwal.WMP.URL = pathSelesai1
            Else
                MenuAwal.WMP.URL = GetData("Selesai Pertama", 2)
            End If
        ElseIf TimePicker2.Text = TimeOfDay Then
            If Not PathJam2 = "" Then
                MenuAwal.WMP.URL = PathJam2
            Else
                MenuAwal.WMP.URL = GetData("Jam Kedua", 2)
            End If
        ElseIf TimePickerKurang2.Text = TimeOfDay Then
            If Not PathKurang2 = "" Then
                MenuAwal.WMP.URL = PathKurang2
            Else
                MenuAwal.WMP.URL = GetData("Kurang 5 Menit(2)", 2)
            End If
        ElseIf TimePickerSelesai2.Text = TimeOfDay Then
            If Not pathSelesai2 = "" Then
                MenuAwal.WMP.URL = pathSelesai2
            Else
                MenuAwal.WMP.URL = GetData("Selesai Kedua", 2)
            End If
        ElseIf TimePicker3.Text = TimeOfDay Then
            If Not PathJam3 = "" Then
                MenuAwal.WMP.URL = PathJam3
            Else
                MenuAwal.WMP.URL = GetData("Jam Ketiga", 2)
            End If
        ElseIf TimePickerKurang3.Text = TimeOfDay Then
            If Not Pathkurang3 = "" Then
                MenuAwal.WMP.URL = Pathkurang3
            Else
                MenuAwal.WMP.URL = GetData("Kurang 5 Menit(3)", 2)
            End If
        ElseIf TimePickerSelesai3.Text = TimeOfDay Then
            If Not pathSelesai1 = "" Then
                MenuAwal.WMP.URL = PathSelesai3
            Else
                MenuAwal.WMP.URL = GetData("Selesai Ketiga", 2)
            End If
        ElseIf TimePicker4.Text = TimeOfDay Then
            If Not PathJam4 = "" Then
                MenuAwal.WMP.URL = PathJam4
            Else
                MenuAwal.WMP.URL = GetData("Jam Keempat", 2)
            End If
        ElseIf TimePickerKurang4.Text = TimeOfDay Then
            If Not PathKurang4 = "" Then
                MenuAwal.WMP.URL = PathKurang4
            Else
                MenuAwal.WMP.URL = GetData("Kurang 5 Menit(4)", 2)
            End If
        ElseIf TimePickerSelesai4.Text = TimeOfDay Then
            If Not PathSelesai4 = "" Then
                MenuAwal.WMP.URL = PathSelesai4
            Else
                MenuAwal.WMP.URL = GetData("Selesai Keempat", 2)
            End If
        ElseIf TimePicker5.Text = TimeOfDay Then
            If Not PathJam5 = "" Then
                MenuAwal.WMP.URL = PathJam5
            Else
                MenuAwal.WMP.URL = GetData("Jam Kelima", 2)
            End If
        ElseIf TimePickerKurang5.Text = TimeOfDay Then
            If Not PathKurang5 = "" Then
                MenuAwal.WMP.URL = PathKurang5
            Else
                MenuAwal.WMP.URL = GetData("Kurang 5 Menit(5)", 2)
            End If
        ElseIf TimePickerSelesai5.Text = TimeOfDay Then
            If Not PathSelesai5 = "" Then
                MenuAwal.WMP.URL = PathSelesai5
            Else
                MenuAwal.WMP.URL = GetData("Selesai Kelima", 2)
            End If
        ElseIf TimePicker6.Text = TimeOfDay Then
            If Not PathJam6 = "" Then
                MenuAwal.WMP.URL = PathJam6
            Else
                MenuAwal.WMP.URL = GetData("Jam Keenam", 2)
            End If
        ElseIf TimePickerKurang6.Text = TimeOfDay Then
            If Not Pathkurang6 = "" Then
                MenuAwal.WMP.URL = Pathkurang6
            Else
                MenuAwal.WMP.URL = GetData("Kurang 5 Menit(6)", 2)
            End If
        ElseIf TimePickerSelesai6.Text = TimeOfDay Then
            If Not PathSelesai6 = "" Then
                MenuAwal.WMP.URL = PathSelesai6
            Else
                MenuAwal.WMP.URL = GetData("Selesai Keenam", 2)
            End If
        ElseIf TimePicker7.Text = TimeOfDay Then
            If Not PathJam7 = "" Then
                MenuAwal.WMP.URL = PathJam7
            Else
                MenuAwal.WMP.URL = GetData("Jam Ketujuh", 2)
            End If
        ElseIf TimePickerKurang7.Text = TimeOfDay Then
            If Not Pathkurang7 = "" Then
                MenuAwal.WMP.URL = Pathkurang7
            Else
                MenuAwal.WMP.URL = GetData("Kurang 5 Menit(7)", 2)
            End If
        ElseIf TimePickerSelesai7.Text = TimeOfDay Then
            If Not PathSelesai7 = "" Then
                MenuAwal.WMP.URL = PathSelesai7
            Else
                MenuAwal.WMP.URL = GetData("Selesai Ketujuh", 2)
            End If

        ElseIf TimePicker8.Text = TimeOfDay Then
            If Not PathJam8 = "" Then
                MenuAwal.WMP.URL = PathJam8
            Else
                MenuAwal.WMP.URL = GetData("Jam Kedelapan", 2)
            End If
        ElseIf TimePickerKurang8.Text = TimeOfDay Then
            If Not Pathkurang8 = "" Then
                MenuAwal.WMP.URL = Pathkurang8
            Else
                MenuAwal.WMP.URL = GetData("Kurang 5 Menit(8)", 2)
            End If
        ElseIf TimePickerSelesai8.Text = TimeOfDay Then
            If Not PathSelesai8 = "" Then
                MenuAwal.WMP.URL = PathSelesai8
            Else
                MenuAwal.WMP.URL = GetData("Selesai Kedelapan", 2)
            End If
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConOpen()
        DataToTimePicker()

        statusjam1()
        statusjam2()
        statusjam3()
        statusjam4()
        statusjam5()
        statusjam6()
        statusjam7()
        statusjam8()
        statuskurang5menit1()
        statuskurang5menit2()
        statuskurang5menit3()
        statuskurang5menit4()
        statuskurang5menit5()
        statuskurang5menit6()
        statuskurang5menit7()
        statuslurang5menit8()
        statusselesai1()
        statusselesai2()
        statusselesai3()
        statusselesai4()
        statusselesai5()
        statusselesai6()
        statusselesai7()
        statusselesai8()
        statusselesai1()
        statusselesai2()
        statusselesai3()
        statusselesai4()
        statusselesai5()
        statusselesai6()
        statusselesai7()
        statusselesai8()


    End Sub
    Private Sub BtnSelect1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect1.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathJam1 = OpenFileDialog1.FileName
        End If

    End Sub
    Private Sub BtnSelectKurang1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectKurang1.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathKurang1 = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub BtnSelectSelesai1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectSelesai1.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pathSelesai1 = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub BtnSelect2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect2.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathJam2 = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub BtnSelectKurang2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectKurang2.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathKurang2 = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub BtnSelectSelesai2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectSelesai2.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pathSelesai2 = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub BtnSelect3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect3.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathJam3 = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub BtnSelectKurang3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectKurang3.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Pathkurang3 = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub BtnSelectSelesai3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectSelesai3.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathSelesai3 = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub BtnSelect4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect4.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathJam4 = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub BtnSelectKurang4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectKurang4.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathKurang4 = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub BtnSelectSelesai4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectSelesai4.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathSelesai4 = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub BtnSelect5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect5.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathJam5 = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub BtnSelectKurang5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectKurang5.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathKurang5 = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub BtnSelectSelesai5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectSelesai5.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathSelesai5 = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub BtnSelect6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect6.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathJam6 = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub BtnSelectKurang6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectKurang6.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Pathkurang6 = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub BtnSelectSelesai6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectSelesai6.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathSelesai6 = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub BtnSelect7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect7.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathJam7 = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub BtnSelectKurang7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectKurang7.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Pathkurang7 = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub BtnSelectSelesai7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectSelesai7.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathSelesai7 = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub BtnSelect8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect8.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathJam8 = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub BtnSelectKurang8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectKurang8.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Pathkurang8 = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub BtnSelectSelesai8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectSelesai8.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathSelesai8 = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub JamPertama()
        If TimePicker1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam1 = "" Then
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePicker1.Text & "' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePicker1.Text & "', song='" & PathJam1 & "' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set status ='aktif' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If


    End Sub
    Private Sub JamKedua()
        If TimePicker2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam2 = "" Then
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePicker2.Text & "' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePicker2.Text & "', song='" & PathJam2 & "' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set status ='aktif' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub JamKetiga()
        If TimePicker3.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam3 = "" Then
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePicker3.Text & "' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePicker3.Text & "', song='" & PathJam3 & "' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker3.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set status ='aktif' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub JamKeempat()
        If TimePicker4.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam4 = "" Then
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePicker4.Text & "' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePicker4.Text & "', song='" & PathJam4 & "' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker4.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set status ='aktif' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If


    End Sub
    Private Sub JamKelima()
        If TimePicker5.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam5 = "" Then
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePicker5.Text & "' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePicker5.Text & "', song='" & PathJam5 & "' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker5.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set status ='aktif' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub JamKeenam()
        If TimePicker6.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam6 = "" Then
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePicker6.Text & "' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePicker6.Text & "', song='" & PathJam6 & "' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker6.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set status ='aktif' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If


    End Sub
    Private Sub JamKetujuh()
        If TimePicker7.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam7 = "" Then
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePicker7.Text & "' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePicker7.Text & "', song='" & PathJam7 & "' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker7.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set status ='aktif' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If


    End Sub
    Private Sub JamKedelapan()
        If TimePicker8.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam8 = "" Then
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePicker8.Text & "' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePicker8.Text & "', song='" & PathJam8 & "' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker8.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set status ='aktif' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub kurang5menit1()
        If TimePickerKurang1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & Lblkurang1.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathKurang1 = "" Then
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerKurang1.Text & "' where keterangan='" & Lblkurang1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerKurang1.Text & "', song='" & PathKurang1 & "' where keterangan='" & Lblkurang1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerKurang1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & Lblkurang1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set status ='aktif' where keterangan='" & Lblkurang1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub kurang5menit2()
        If TimePickerKurang2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & Lblkurang2.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathKurang2 = "" Then
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerKurang2.Text & "' where keterangan='" & Lblkurang2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerKurang2.Text & "', song='" & PathKurang2 & "' where keterangan='" & Lblkurang2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerKurang2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & Lblkurang2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set status ='aktif' where keterangan='" & Lblkurang2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub kurang5menit3()
        If TimePickerKurang3.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & Lblkurang3.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf Pathkurang3 = "" Then
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerKurang3.Text & "' where keterangan='" & Lblkurang3.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerKurang3.Text & "', song='" & Pathkurang3 & "' where keterangan='" & Lblkurang3.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerKurang3.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & Lblkurang3.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set status ='aktif' where keterangan='" & Lblkurang3.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub kurang5menit4()
        If TimePickerKurang4.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & Lblkurang4.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathKurang4 = "" Then
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerKurang4.Text & "' where keterangan='" & Lblkurang4.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerKurang4.Text & "', song='" & PathKurang4 & "' where keterangan='" & Lblkurang4.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerKurang4.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & Lblkurang4.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set status ='aktif' where keterangan='" & Lblkurang4.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub kurang5menit5()
        If TimePickerKurang5.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & Lblkurang5.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathKurang5 = "" Then
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerKurang5.Text & "' where keterangan='" & Lblkurang5.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerKurang5.Text & "', song='" & PathKurang5 & "' where keterangan='" & Lblkurang5.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerKurang5.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & Lblkurang5.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set status ='aktif' where keterangan='" & Lblkurang5.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub kurang5menit6()
        If TimePickerKurang6.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblKurang6.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf Pathkurang6 = "" Then
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerKurang6.Text & "' where keterangan='" & LblKurang6.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerKurang6.Text & "', song='" & Pathkurang6 & "' where keterangan='" & LblKurang6.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerKurang6.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblKurang6.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set status ='aktif' where keterangan='" & LblKurang6.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub kurang5menit7()
        If TimePickerKurang7.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & Lblkurang7.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf Pathkurang7 = "" Then
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerKurang7.Text & "' where keterangan='" & Lblkurang7.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerKurang7.Text & "', song='" & Pathkurang7 & "' where keterangan='" & Lblkurang7.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerKurang7.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & Lblkurang7.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set status ='aktif' where keterangan='" & Lblkurang7.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub kurang5menit8()
        If TimePickerKurang8.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblKurang8.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf Pathkurang8 = "" Then
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerKurang8.Text & "' where keterangan='" & LblKurang8.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerKurang8.Text & "', song='" & Pathkurang8 & "' where keterangan='" & LblKurang8.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerKurang8.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblKurang8.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set status ='aktif' where keterangan='" & LblKurang8.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub selesai1()
        If TimePickerSelesai1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & Lblselesai1.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf pathSelesai1 = "" Then
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerSelesai1.Text & "' where keterangan='" & Lblselesai1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerSelesai1.Text & "', song='" & pathSelesai1 & "' where keterangan='" & Lblselesai1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerSelesai1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & Lblselesai1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set status ='aktif' where keterangan='" & Lblselesai1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub selesai2()
        If TimePickerSelesai2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & Lblselesai2.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf pathSelesai2 = "" Then
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerSelesai2.Text & "' where keterangan='" & Lblselesai2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerSelesai2.Text & "', song='" & pathSelesai2 & "' where keterangan='" & Lblselesai2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerSelesai2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & Lblselesai2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set status ='aktif' where keterangan='" & Lblselesai2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub selesai3()
        If TimePickerSelesai3.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & Lblselesai3.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathSelesai3 = "" Then
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerSelesai3.Text & "' where keterangan='" & Lblselesai3.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerSelesai3.Text & "', song='" & PathSelesai3 & "' where keterangan='" & Lblselesai3.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerSelesai3.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & Lblselesai3.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set status ='aktif' where keterangan='" & Lblselesai3.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub selesai4()
        If TimePickerSelesai4.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & lblselesai4.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathSelesai4 = "" Then
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerSelesai4.Text & "' where keterangan='" & lblselesai4.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerSelesai4.Text & "', song='" & PathSelesai4 & "' where keterangan='" & lblselesai4.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerSelesai4.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & lblselesai4.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set status ='aktif' where keterangan='" & lblselesai4.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub selesai5()
        If TimePickerSelesai5.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & lblselesai5.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf pathSelesai2 = "" Then
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerSelesai5.Text & "' where keterangan='" & lblselesai5.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerSelesai5.Text & "', song='" & PathSelesai5 & "' where keterangan='" & lblselesai5.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerSelesai5.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & lblselesai5.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set status ='aktif' where keterangan='" & lblselesai5.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub selesai6()
        If TimePickerSelesai6.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblSelesai6.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathSelesai6 = "" Then
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerSelesai6.Text & "' where keterangan='" & LblSelesai6.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerSelesai6.Text & "', song='" & PathSelesai6 & "' where keterangan='" & LblSelesai6.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerSelesai6.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblSelesai6.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set status ='aktif' where keterangan='" & LblSelesai6.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub selesai7()
        If TimePickerSelesai7.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblSelesai7.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathSelesai7 = "" Then
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerSelesai7.Text & "' where keterangan='" & LblSelesai7.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerSelesai7.Text & "', song='" & PathSelesai7 & "' where keterangan='" & LblSelesai7.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerSelesai7.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblSelesai7.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set status ='aktif' where keterangan='" & LblSelesai7.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub selesai8()
        If TimePickerSelesai8.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblSelesai8.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathSelesai8 = "" Then
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerSelesai8.Text & "' where keterangan='" & LblSelesai8.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set [time]='" & TimePickerSelesai8.Text & "', song='" & PathSelesai8 & "' where keterangan='" & LblSelesai8.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerSelesai8.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Ujian set status ='nonaktif' where keterangan='" & LblSelesai8.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Ujian set status ='aktif' where keterangan='" & LblSelesai8.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        JamPertama()
        JamKedua()
        JamKetiga()
        JamKeempat()
        JamKeenam()
        JamKelima()
        JamKetujuh()
        JamKedelapan()
        kurang5menit1()
        kurang5menit2()
        kurang5menit3()
        kurang5menit4()
        kurang5menit5()
        kurang5menit6()
        kurang5menit7()
        kurang5menit8()
        selesai1()
        selesai2()
        selesai3()
        selesai4()
        selesai5()
        selesai6()
        selesai7()
        selesai8()

        MsgBox("Settingan Anda Berhasil Disimpan", MsgBoxStyle.Information, "Suksess")

    End Sub
    Public psbv As Integer = 0
    Private Sub VScrollBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles VScrollBar1.ValueChanged
        Dim increment As Integer
        If VScrollBar1.Value > psbv Then
            increment = VScrollBar1.Value - psbv
            psbv = VScrollBar1.Value
            Panel2.Location = New Point(Panel2.Location.X, Panel2.Location.Y - increment)
            Panel3.Location = New Point(Panel3.Location.X, Panel3.Location.Y - increment)
            Panel4.Location = New Point(Panel4.Location.X, Panel4.Location.Y - increment)
            Panel5.Location = New Point(Panel5.Location.X, Panel5.Location.Y - increment)
            Panel6.Location = New Point(Panel6.Location.X, Panel6.Location.Y - increment)
            Panel7.Location = New Point(Panel7.Location.X, Panel7.Location.Y - increment)
            Panel8.Location = New Point(Panel8.Location.X, Panel8.Location.Y - increment)
            Panel9.Location = New Point(Panel9.Location.X, Panel9.Location.Y - increment)

        ElseIf VScrollBar1.Value < psbv Then
            increment = psbv - VScrollBar1.Value
            psbv = VScrollBar1.Value
            Panel2.Location = New Point(Panel2.Location.X, Panel2.Location.Y + increment)
            Panel3.Location = New Point(Panel3.Location.X, Panel3.Location.Y + increment)
            Panel4.Location = New Point(Panel4.Location.X, Panel4.Location.Y + increment)
            Panel5.Location = New Point(Panel5.Location.X, Panel5.Location.Y + increment)
            Panel6.Location = New Point(Panel6.Location.X, Panel6.Location.Y + increment)
            Panel7.Location = New Point(Panel7.Location.X, Panel7.Location.Y + increment)
            Panel8.Location = New Point(Panel8.Location.X, Panel8.Location.Y + increment)
            Panel9.Location = New Point(Panel9.Location.X, Panel9.Location.Y + increment)
        End If
    End Sub



    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        TimePicker1.Text = "00:00:00"
        PictureBox1.Visible = False
        PictureBox20.Visible = True
        BtnSelect1.Enabled = False
        TimePicker1.Enabled = False
    End Sub

    Private Sub PictureBox20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox20.Click
        TimePicker1.Text = GetData("Jam Pertama", 0)
        PictureBox1.Visible = True
        PictureBox20.Visible = False
        BtnSelect1.Enabled = True
        TimePicker1.Enabled = True
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        TimePickerKurang1.Text = "00:00:00"
        PictureBox2.Visible = False
        PictureBox19.Visible = True
        BtnSelectKurang1.Enabled = False
        TimePickerKurang1.Enabled = False

    End Sub


    Private Sub PictureBox19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox19.Click
        TimePickerKurang1.Text = GetData("Kurang 5 Menit(1)", 0)
        PictureBox2.Visible = True
        PictureBox19.Visible = False
        BtnSelectKurang1.Enabled = True
        TimePickerKurang1.Enabled = True

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        TimePickerSelesai1.Text = "00:00:00"
        PictureBox3.Visible = False
        PictureBox18.Visible = True
        TimePickerSelesai1.Enabled = False
        BtnSelectSelesai1.Enabled = False
    End Sub

    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        TimePickerSelesai1.Text = GetData("Selesai Pertama", 0)
        PictureBox3.Visible = True
        PictureBox18.Visible = False
        TimePickerSelesai1.Enabled = True
        BtnSelectSelesai1.Enabled = True
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        TimePicker2.Text = "00:00:00"
        PictureBox9.Visible = False
        PictureBox8.Visible = True
        TimePicker2.Enabled = False
        BtnSelect2.Enabled = False
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        TimePicker2.Text = GetData("Jam Kedua", 0)
        PictureBox9.Visible = True
        PictureBox8.Visible = False
        TimePicker2.Enabled = True
        BtnSelect2.Enabled = True
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        TimePickerKurang2.Text = "00:00:00"
        PictureBox7.Visible = False
        PictureBox6.Visible = True
        TimePickerKurang2.Enabled = False
        BtnSelectKurang2.Enabled = False
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        TimePickerKurang2.Text = GetData("Kurang 5 Menit(2)", 0)
        PictureBox7.Visible = True
        PictureBox6.Visible = False
        TimePickerKurang2.Enabled = True
        BtnSelectKurang2.Enabled = True
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        TimePickerSelesai2.Text = "00:00:00"
        PictureBox5.Visible = False
        PictureBox4.Visible = True
        TimePickerSelesai2.Enabled = False
        BtnSelectSelesai2.Enabled = False
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        TimePickerSelesai2.Text = GetData("Selesai Kedua", 0)
        PictureBox5.Visible = True
        PictureBox4.Visible = False
        TimePickerSelesai2.Enabled = True
        BtnSelectSelesai2.Enabled = True
    End Sub



    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        TimePicker3.Text = "00:00:00"
        PictureBox15.Visible = False
        PictureBox14.Visible = True
        TimePicker3.Enabled = False
        BtnSelect3.Enabled = False
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click

        TimePicker3.Text = GetData("Jam Ketiga", 0)
        PictureBox15.Visible = True
        PictureBox14.Visible = False
        TimePicker3.Enabled = True
        BtnSelect3.Enabled = True
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click

        TimePickerKurang3.Text = "00:00:00"
        PictureBox13.Visible = False
        PictureBox12.Visible = True
        TimePickerKurang3.Enabled = False
        BtnSelectKurang3.Enabled = False
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click

        TimePickerKurang3.Text = GetData("Kurang 5 Menit(3)", 0)
        PictureBox13.Visible = True
        PictureBox12.Visible = False
        TimePickerKurang3.Enabled = True
        BtnSelectKurang3.Enabled = True
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        TimePickerSelesai3.Text = "00:00:00"
        PictureBox11.Visible = False
        PictureBox10.Visible = True
        TimePickerSelesai3.Enabled = False
        BtnSelectSelesai3.Enabled = False
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        TimePickerSelesai3.Text = GetData("Selesai Ketiga", 0)
        PictureBox11.Visible = True
        PictureBox10.Visible = False
        TimePickerSelesai3.Enabled = True
        BtnSelectSelesai3.Enabled = True
    End Sub



    Private Sub PictureBox24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox24.Click
        TimePicker4.Text = "00:00:00"
        PictureBox24.Visible = False
        PictureBox23.Visible = True
        TimePicker4.Enabled = False
        BtnSelect4.Enabled = False

    End Sub

    Private Sub PictureBox23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox23.Click
        TimePicker4.Text = GetData("Jam Keempat", 0)
        PictureBox24.Visible = True
        PictureBox23.Visible = False
        TimePicker4.Enabled = True
        BtnSelect4.Enabled = True

    End Sub

    Private Sub PictureBox22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox22.Click
        TimePickerKurang4.Text = "00:00:00"
        PictureBox22.Visible = False
        PictureBox21.Visible = True
        TimePickerKurang4.Enabled = False
        BtnSelectKurang4.Enabled = False

    End Sub

    Private Sub PictureBox21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox21.Click

        TimePickerKurang4.Text = GetData("Kurang 5 Menit(4)", 0)
        PictureBox22.Visible = True
        PictureBox21.Visible = False
        TimePickerKurang4.Enabled = True
        BtnSelectKurang4.Enabled = True
    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.Click
        TimePickerSelesai4.Text = "00:00:00"
        PictureBox17.Visible = False
        PictureBox16.Visible = True
        TimePickerSelesai4.Enabled = False
        BtnSelectSelesai4.Enabled = False
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click


        TimePickerSelesai4.Text = GetData("Selesai Keempat", 0)
        PictureBox17.Visible = True
        PictureBox16.Visible = False
        TimePickerSelesai4.Enabled = True
        BtnSelectSelesai4.Enabled = True
    End Sub

    Private Sub PictureBox30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox30.Click
        TimePicker5.Text = "00:00:00"
        PictureBox30.Visible = False
        PictureBox29.Visible = True
        TimePicker5.Enabled = False
        BtnSelect5.Enabled = False
    End Sub

    Private Sub PictureBox29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox29.Click
        TimePicker5.Text = GetData("Jam Kelima", 0)
        PictureBox30.Visible = True
        PictureBox29.Visible = False
        TimePicker5.Enabled = True
        BtnSelect5.Enabled = True
    End Sub


    Private Sub PictureBox28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox28.Click
        TimePickerKurang5.Text = "00:00:00"
        PictureBox28.Visible = False
        PictureBox27.Visible = True
        TimePickerKurang5.Enabled = False
        BtnSelectKurang5.Enabled = False
    End Sub

    Private Sub PictureBox27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox27.Click

        TimePickerKurang5.Text = GetData("Kurang 5 Menit(5)", 0)
        PictureBox28.Visible = True
        PictureBox27.Visible = False
        TimePickerKurang5.Enabled = True
        BtnSelectKurang5.Enabled = True
    End Sub


    Private Sub PictureBox26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox26.Click
        TimePickerSelesai5.Text = "00:00:00"
        PictureBox26.Visible = False
        PictureBox25.Visible = True
        TimePickerSelesai5.Enabled = False
        BtnSelectSelesai5.Enabled = False
    End Sub

    Private Sub PictureBox25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox25.Click
        TimePickerSelesai5.Text = GetData("Selesai Kelima", 0)
        PictureBox26.Visible = True
        PictureBox25.Visible = False
        TimePickerSelesai5.Enabled = True
        BtnSelectSelesai5.Enabled = True
    End Sub

    Private Sub PictureBox36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox36.Click
        TimePicker6.Text = "00:00:00"
        PictureBox36.Visible = False
        PictureBox35.Visible = True
        TimePicker6.Enabled = False
        BtnSelect6.Enabled = False

    End Sub

    Private Sub PictureBox35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox35.Click
        TimePicker6.Text = GetData("Jam Keenam", 0)
        PictureBox36.Visible = True
        PictureBox35.Visible = False
        TimePicker6.Enabled = True
        BtnSelect6.Enabled = True
    End Sub

    Private Sub PictureBox34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox34.Click

        TimePickerKurang6.Text = "00:00:00"
        PictureBox34.Visible = False
        PictureBox33.Visible = True
        TimePickerKurang6.Enabled = False
        BtnSelectKurang6.Enabled = False
    End Sub

    Private Sub PictureBox33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox33.Click


        TimePickerKurang6.Text = GetData("Kurang 5 Menit(6)", 0)
        PictureBox34.Visible = True
        PictureBox33.Visible = False
        TimePickerKurang6.Enabled = True
        BtnSelectKurang6.Enabled = True
    End Sub

    Private Sub PictureBox32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox32.Click

        TimePickerSelesai6.Text = "00:00:00"
        PictureBox32.Visible = False
        PictureBox31.Visible = True
        TimePickerSelesai6.Enabled = False
        BtnSelectSelesai6.Enabled = False
    End Sub

    Private Sub PictureBox31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox31.Click


        TimePickerSelesai6.Text = GetData("Selesai Keenam", 0)
        PictureBox32.Visible = True
        PictureBox31.Visible = False
        TimePickerSelesai6.Enabled = True
        BtnSelectSelesai6.Enabled = True

    End Sub

    Private Sub PictureBox42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox42.Click
        TimePicker7.Text = "00:00:00"
        PictureBox42.Visible = False
        PictureBox41.Visible = True
        TimePicker7.Enabled = False
        BtnSelect7.Enabled = False

    End Sub

    Private Sub PictureBox41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox41.Click

        TimePicker7.Text = GetData("Jam Ketujuh", 0)
        PictureBox42.Visible = True
        PictureBox41.Visible = False
        TimePicker7.Enabled = True
        BtnSelect7.Enabled = True
    End Sub

    Private Sub PictureBox40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox40.Click

        TimePickerKurang7.Text = "00:00:00"
        PictureBox40.Visible = False
        PictureBox39.Visible = True
        TimePickerKurang7.Enabled = False
        BtnSelectKurang7.Enabled = False
    End Sub

    Private Sub PictureBox39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox39.Click

        TimePickerKurang7.Text = GetData("Kurang 5 Menit(7)", 0)
        PictureBox40.Visible = True
        PictureBox39.Visible = False
        TimePickerKurang7.Enabled = True
        BtnSelectKurang7.Enabled = True
    End Sub

    Private Sub PictureBox38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox38.Click
        TimePickerSelesai7.Text = "00:00:00"
        PictureBox38.Visible = False
        PictureBox37.Visible = True
        BtnSelectSelesai7.Enabled = False
        TimePickerSelesai7.Enabled = False

    End Sub

    Private Sub PictureBox37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox37.Click

        TimePickerSelesai7.Text = GetData("Selesai Ketujuh", 0)
        PictureBox38.Visible = True
        PictureBox37.Visible = False
        TimePickerSelesai7.Enabled = True
        BtnSelectSelesai7.Enabled = True
    End Sub

    Private Sub PictureBox48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox48.Click
        TimePicker8.Text = "00:00:00"
        PictureBox48.Visible = False
        PictureBox47.Visible = True
        TimePicker8.Enabled = False
        BtnSelect8.Enabled = False
    End Sub

    Private Sub PictureBox47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox47.Click
        TimePicker8.Text = GetData("Jam Kedelapan", 0)
        PictureBox48.Visible = True
        PictureBox47.Visible = False
        BtnSelect8.Enabled = True
        TimePicker8.Enabled = True
    End Sub

    Private Sub PictureBox46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox46.Click
        TimePickerKurang8.Text = "00:00:00"
        PictureBox46.Visible = False
        PictureBox45.Visible = True
        BtnSelectKurang8.Enabled = False
        TimePickerKurang8.Enabled = False
    End Sub

    Private Sub PictureBox45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox45.Click
        TimePickerKurang8.Text = GetData("Kurang 5 Menit(8)", 0)
        PictureBox46.Visible = True
        PictureBox45.Visible = False
        BtnSelectKurang8.Enabled = True
        TimePickerKurang8.Enabled = True
    End Sub

    Private Sub PictureBox44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox44.Click
        TimePickerSelesai8.Text = "00:00:00"
        PictureBox44.Visible = False
        PictureBox43.Visible = True
        TimePickerSelesai8.Enabled = False
        BtnSelectSelesai8.Enabled = False

    End Sub

    Private Sub PictureBox43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox43.Click
        TimePickerSelesai8.Text = GetData("Selesai Kedelapan", 0)
        PictureBox44.Visible = True
        PictureBox43.Visible = False
        TimePickerSelesai8.Enabled = True
        BtnSelectSelesai8.Enabled = True
    End Sub


    Sub statusjam1()
        cmd = New OleDbCommand("Select status From Ujian Where keterangan = '" & LblJam1.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox1.Visible = True
            PictureBox20.Visible = False
            TimePicker1.Enabled = True
            BtnSelect1.Enabled = True
        ElseIf status = "nonaktif" Then
            PictureBox1.Visible = False
            PictureBox20.Visible = True
            TimePicker1.Enabled = False
            BtnSelect1.Enabled = False
            TimePicker1.Text = "00:00:00"
        End If

    End Sub
    Sub statuskurang5menit1()
        cmd = New OleDbCommand("Select status From Ujian Where keterangan = '" & Lblkurang1.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox2.Visible = True
            PictureBox19.Visible = False
            TimePickerKurang1.Enabled = True
            BtnSelectKurang1.Enabled = True
        ElseIf status = "nonaktif" Then
            PictureBox2.Visible = False
            PictureBox19.Visible = True
            TimePickerKurang1.Enabled = False
            BtnSelectKurang1.Enabled = False
            TimePickerKurang1.Text = "00:00:00"
        End If

    End Sub
    Sub statusselesai1()
        cmd = New OleDbCommand("Select status From Ujian Where keterangan = '" & Lblselesai1.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox3.Visible = True
            PictureBox18.Visible = False
            TimePickerSelesai1.Enabled = True
            BtnSelectSelesai1.Enabled = True
        ElseIf status = "nonaktif" Then
            PictureBox3.Visible = False
            PictureBox18.Visible = True
            TimePickerSelesai1.Enabled = False
            BtnSelectSelesai1.Enabled = False
            TimePickerSelesai1.Text = "00:00:00"
        End If

    End Sub
    Sub statusjam2()
        cmd = New OleDbCommand("Select status From Ujian Where keterangan = '" & LblJam2.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox9.Visible = True
            PictureBox8.Visible = False
            TimePicker2.Enabled = True
            BtnSelect2.Enabled = True
        ElseIf status = "nonaktif" Then
            PictureBox9.Visible = False
            PictureBox8.Visible = True
            TimePicker2.Enabled = False
            BtnSelect2.Enabled = False
            TimePicker2.Text = "00:00:00"
        End If

    End Sub
    Sub statuskurang5menit2()
        cmd = New OleDbCommand("Select status From Ujian Where keterangan = '" & Lblkurang2.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox7.Visible = True
            PictureBox6.Visible = False
            TimePicker2.Enabled = True
            BtnSelect2.Enabled = True
        ElseIf status = "nonaktif" Then
            PictureBox7.Visible = False
            PictureBox6.Visible = True
            TimePickerKurang2.Enabled = False
            BtnSelectKurang2.Enabled = False
            TimePickerKurang2.Text = "00:00:00"
        End If

    End Sub
    Sub statusselesai2()
        cmd = New OleDbCommand("Select status From Ujian Where keterangan = '" & Lblselesai2.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox5.Visible = True
            PictureBox4.Visible = False
            TimePickerSelesai2.Enabled = True
            BtnSelectSelesai2.Enabled = True
        ElseIf status = "nonaktif" Then
            PictureBox5.Visible = False
            PictureBox4.Visible = True
            TimePickerSelesai2.Enabled = False
            BtnSelectSelesai2.Enabled = False
            TimePickerSelesai2.Text = "00:00:00"
        End If

    End Sub
    Sub statusjam3()
        cmd = New OleDbCommand("Select status From Ujian Where keterangan = '" & LblJam3.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox15.Visible = True
            PictureBox14.Visible = False
            TimePicker3.Enabled = True
            BtnSelect3.Enabled = True
        ElseIf status = "nonaktif" Then
            PictureBox15.Visible = False
            PictureBox14.Visible = True
            TimePicker3.Enabled = False
            BtnSelect3.Enabled = False
            TimePicker3.Text = "00:00:00"
        End If

    End Sub
    Sub statuskurang5menit3()
        cmd = New OleDbCommand("Select status From Ujian Where keterangan = '" & Lblkurang3.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox13.Visible = True
            PictureBox12.Visible = False
            TimePickerKurang3.Enabled = True
            BtnSelectKurang3.Enabled = True
        ElseIf status = "nonaktif" Then
            PictureBox13.Visible = False
            PictureBox12.Visible = True
            TimePickerKurang3.Enabled = False
            BtnSelectKurang3.Enabled = False
            TimePickerKurang3.Text = "00:00:00"
        End If

    End Sub
    Sub statusselesai3()
        cmd = New OleDbCommand("Select status From Ujian Where keterangan = '" & Lblselesai3.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox11.Visible = True
            PictureBox10.Visible = False
            TimePickerSelesai3.Enabled = True
            BtnSelectSelesai3.Enabled = True
        ElseIf status = "nonaktif" Then
            PictureBox11.Visible = False
            PictureBox10.Visible = True
            TimePickerSelesai3.Enabled = False
            BtnSelectSelesai3.Enabled = False
            TimePickerSelesai3.Text = "00:00:00"
        End If

    End Sub
    Sub statusjam4()
        cmd = New OleDbCommand("Select status From Ujian Where keterangan = '" & LblJam4.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox24.Visible = True
            PictureBox23.Visible = False
            TimePicker4.Enabled = True
            BtnSelect4.Enabled = True
        ElseIf status = "nonaktif" Then
            PictureBox24.Visible = False
            PictureBox23.Visible = True
            TimePicker4.Enabled = False
            BtnSelect4.Enabled = False
            TimePicker4.Text = "00:00:00"
        End If

    End Sub
    Sub statuskurang5menit4()
        cmd = New OleDbCommand("Select status From Ujian Where keterangan = '" & Lblkurang4.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox22.Visible = True
            PictureBox21.Visible = False
            TimePickerKurang4.Enabled = True
            BtnSelectKurang4.Enabled = True
        ElseIf status = "nonaktif" Then
            PictureBox22.Visible = False
            PictureBox21.Visible = True
            TimePickerKurang4.Enabled = False
            BtnSelectKurang4.Enabled = False
            TimePickerKurang4.Text = "00:00:00"
        End If

    End Sub
    Sub statusselesai4()
        cmd = New OleDbCommand("Select status From Ujian Where keterangan = '" & lblselesai4.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox17.Visible = True
            PictureBox16.Visible = False
            TimePickerSelesai4.Enabled = True
            BtnSelectSelesai4.Enabled = True
        ElseIf status = "nonaktif" Then
            PictureBox17.Visible = False
            PictureBox16.Visible = True
            TimePickerSelesai4.Enabled = False
            BtnSelectSelesai4.Enabled = False
            TimePickerSelesai4.Text = "00:00:00"
        End If

    End Sub
    Sub statusjam5()
        cmd = New OleDbCommand("Select status From Ujian Where keterangan = '" & LblJam5.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox30.Visible = True
            PictureBox29.Visible = False
            TimePicker5.Enabled = True
            BtnSelect5.Enabled = True
        ElseIf status = "nonaktif" Then
            PictureBox30.Visible = False
            PictureBox29.Visible = True
            TimePicker5.Enabled = False
            BtnSelect5.Enabled = False
            TimePicker5.Text = "00:00:00"
        End If

    End Sub
    Sub statuskurang5menit5()
        cmd = New OleDbCommand("Select status From Ujian Where keterangan = '" & Lblkurang5.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox28.Visible = True
            PictureBox27.Visible = False
            TimePickerKurang5.Enabled = True
            BtnSelectKurang5.Enabled = True
        ElseIf status = "nonaktif" Then
            PictureBox28.Visible = False
            PictureBox27.Visible = True
            TimePickerKurang5.Enabled = False
            BtnSelectKurang5.Enabled = False
            TimePickerKurang5.Text = "00:00:00"
        End If

    End Sub
    Sub statusselesai5()
        cmd = New OleDbCommand("Select status From Ujian Where keterangan = '" & lblselesai5.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox26.Visible = True
            PictureBox25.Visible = False
            TimePickerSelesai5.Enabled = True
            BtnSelectSelesai5.Enabled = True
        ElseIf status = "nonaktif" Then
            PictureBox26.Visible = False
            PictureBox25.Visible = True
            TimePickerSelesai5.Enabled = False
            BtnSelectSelesai5.Enabled = False
            TimePickerSelesai5.Text = "00:00:00"
        End If

    End Sub
    Sub statusjam6()
        cmd = New OleDbCommand("Select status From Ujian Where keterangan = '" & LblJam6.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox36.Visible = True
            PictureBox35.Visible = False
            TimePicker6.Enabled = True
            BtnSelect6.Enabled = True
        ElseIf status = "nonaktif" Then
            PictureBox36.Visible = False
            PictureBox35.Visible = True
            TimePicker6.Enabled = False
            BtnSelect6.Enabled = False
            TimePicker6.Text = "00:00:00"
        End If

    End Sub
    Sub statuskurang5menit6()
        cmd = New OleDbCommand("Select status From Ujian Where keterangan = '" & LblKurang6.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox34.Visible = True
            PictureBox33.Visible = False
            TimePickerKurang6.Enabled = True
            BtnSelectKurang6.Enabled = True
        ElseIf status = "nonaktif" Then
            PictureBox34.Visible = False
            PictureBox33.Visible = True
            TimePickerKurang6.Enabled = False
            BtnSelectKurang6.Enabled = False
            TimePickerKurang6.Text = "00:00:00"
        End If

    End Sub
    Sub statusselesai6()
        cmd = New OleDbCommand("Select status From Ujian Where keterangan = '" & LblSelesai6.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox32.Visible = True
            PictureBox31.Visible = False
            TimePickerSelesai6.Enabled = True
            BtnSelectSelesai6.Enabled = True
        ElseIf status = "nonaktif" Then
            PictureBox32.Visible = False
            PictureBox31.Visible = True
            TimePickerSelesai6.Enabled = False
            BtnSelectSelesai6.Enabled = False
            TimePickerSelesai6.Text = "00:00:00"
        End If

    End Sub
    Sub statusjam7()
        cmd = New OleDbCommand("Select status From Ujian Where keterangan = '" & LblJam7.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox42.Visible = True
            PictureBox41.Visible = False
            TimePicker7.Enabled = True
            BtnSelect7.Enabled = True
        ElseIf status = "nonaktif" Then
            PictureBox42.Visible = False
            PictureBox41.Visible = True
            TimePicker7.Enabled = False
            BtnSelect7.Enabled = False
            TimePicker7.Text = "00:00:00"
        End If

    End Sub
    Sub statuskurang5menit7()
        cmd = New OleDbCommand("Select status From Ujian Where keterangan = '" & Lblkurang7.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox40.Visible = True
            PictureBox39.Visible = False
            TimePickerKurang7.Enabled = True
            BtnSelectKurang7.Enabled = True
        ElseIf status = "nonaktif" Then
            PictureBox40.Visible = False
            PictureBox39.Visible = True
            TimePickerKurang7.Enabled = False
            BtnSelectKurang7.Enabled = False
            TimePickerKurang7.Text = "00:00:00"
        End If

    End Sub
    Sub statusselesai7()
        cmd = New OleDbCommand("Select status From Ujian Where keterangan = '" & LblSelesai7.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox38.Visible = True
            PictureBox37.Visible = False
            TimePickerSelesai7.Enabled = True
            BtnSelectSelesai7.Enabled = True
        ElseIf status = "nonaktif" Then
            PictureBox38.Visible = False
            PictureBox37.Visible = True
            TimePickerSelesai7.Enabled = False
            BtnSelectSelesai7.Enabled = False
            TimePickerSelesai7.Text = "00:00:00"
        End If

    End Sub
    Sub statusjam8()
        cmd = New OleDbCommand("Select status From Ujian Where keterangan = '" & LblJam8.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox48.Visible = True
            PictureBox47.Visible = False
            TimePicker8.Enabled = True
            BtnSelect8.Enabled = True
        ElseIf status = "nonaktif" Then
            PictureBox48.Visible = False
            PictureBox47.Visible = True
            TimePicker8.Enabled = False
            BtnSelect8.Enabled = False
            TimePicker8.Text = "00:00:00"
        End If

    End Sub
    Sub statuslurang5menit8()
        cmd = New OleDbCommand("Select status From Ujian Where keterangan = '" & LblKurang8.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox46.Visible = True
            PictureBox45.Visible = False
            TimePickerKurang8.Enabled = True
            BtnSelectKurang8.Enabled = True
        ElseIf status = "nonaktif" Then
            PictureBox46.Visible = False
            PictureBox45.Visible = True
            TimePickerKurang8.Enabled = False
            BtnSelectKurang8.Enabled = False
            TimePickerKurang8.Text = "00:00:00"
        End If

    End Sub
    Sub statusselesai8()
        cmd = New OleDbCommand("Select status From Ujian Where keterangan = '" & LblSelesai8.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox44.Visible = True
            PictureBox43.Visible = False
            TimePickerSelesai8.Enabled = True
            BtnSelectSelesai8.Enabled = True
        ElseIf status = "nonaktif" Then
            PictureBox44.Visible = False
            PictureBox43.Visible = True
            TimePickerSelesai8.Enabled = False
            BtnSelectSelesai8.Enabled = False
            TimePickerSelesai8.Text = "00:00:00"
        End If

    End Sub
End Class