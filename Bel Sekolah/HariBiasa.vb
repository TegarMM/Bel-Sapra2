Imports System.Data.OleDb

Public Class HariBiasa

    Dim pathpulangcepat, pathceksound, PathJam1, PathJam2, PathJam3, PathJam4, PathJam5, PathJam6, PathJam7, PathJam8, PathJam9, PathJam10, pathjam11, pathpulang, PathIstirahat1, path5menitistirahat1, path5menitistirahat2, PathIstirahat2 As String

    Private Sub TimerTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTime.Tick
        LblTime.Text = TimeOfDay

    End Sub

    Public Function GetDatasenin(ByVal keterangan As String, ByVal cells As Integer)

        cmd = New OleDbCommand("Select * from Senin where keterangan='" & keterangan & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Return dr.Item(cells)
        Else
            Return 0
        End If

    End Function
    Private Function GetDataselasa(ByVal keterangan As String, ByVal cells As Integer)

        cmd = New OleDbCommand("Select * from Selasa where keterangan='" & keterangan & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Return dr.Item(cells)
        Else
            Return 0
        End If

    End Function
    Private Function GetDataRabu(ByVal keterangan As String, ByVal cells As Integer)

        cmd = New OleDbCommand("Select * from Rabu where keterangan='" & keterangan & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Return dr.Item(cells)
        Else
            Return 0
        End If

    End Function
    Private Function GetDataKamis(ByVal keterangan As String, ByVal cells As Integer)

        cmd = New OleDbCommand("Select * from Kamis where keterangan='" & keterangan & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Return dr.Item(cells)
        Else
            Return 0
        End If

    End Function
    Private Function GetDataJumat(ByVal keterangan As String, ByVal cells As Integer)

        cmd = New OleDbCommand("Select * from Jumat where keterangan='" & keterangan & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Return dr.Item(cells)
        Else
            Return 0
        End If


    End Function
    Private Function GetDataSabtu(ByVal Keterangan As String, ByVal cells As Integer)
        cmd = New OleDbCommand("Select * From Sabtu Where keterangan= '" & Keterangan & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Return dr.Item(cells)
        Else
            Return 0
        End If
    End Function

    'Mengambil Data Dari DataBase Ke DateTimePicker
    Private Sub DataToTimePickersenin()
        TimePicker1.Text = GetDatasenin("Jam Pertama", 0)
        TimePicker2.Text = GetDatasenin("Jam Kedua", 0)
        TimePicker3.Text = GetDatasenin("Jam Ketiga", 0)
        TimePicker4.Text = GetDatasenin("Jam Keempat", 0)
        TimePicker5.Text = GetDatasenin("Jam Kelima", 0)
        TimePicker6.Text = GetDatasenin("Jam Keenam", 0)
        TimePicker7.Text = GetDatasenin("Jam Ketujuh", 0)
        TimePicker8.Text = GetDatasenin("Jam Kedelapan", 0)
        TimePicker9.Text = GetDatasenin("Jam Kesembilan", 0)
        TimePicker10.Text = GetDatasenin("Jam Kesepuluh", 0)
        TimePickerIstirahat1.Text = GetDatasenin("Istirahat 1", 0)
        TimePickerKurang5Menit1.Text = GetDatasenin("Istirahat1 <5M", 0)
        TimePickerKurang5Menit2.Text = GetDatasenin("Istirahat2 <5M", 0)
        TimePickerIstirahat2.Text = GetDatasenin("Istirahat 2", 0)
        TimePickerPulang.Text = GetDatasenin("Jam Pulang", 0)
    End Sub
    Private Sub DataToTimePickerselasa()
        TimePicker1.Text = GetDataselasa("Jam Pertama", 0)
        TimePicker2.Text = GetDataselasa("Jam Kedua", 0)
        TimePicker3.Text = GetDataselasa("Jam Ketiga", 0)
        TimePicker4.Text = GetDataselasa("Jam Keempat", 0)
        TimePicker5.Text = GetDataselasa("Jam Kelima", 0)
        TimePicker6.Text = GetDataselasa("Jam Keenam", 0)
        TimePicker7.Text = GetDataselasa("Jam Ketujuh", 0)
        TimePicker8.Text = GetDataselasa("Jam Kedelapan", 0)
        TimePicker9.Text = GetDataselasa("Jam Kesembilan", 0)
        TimePicker10.Text = GetDataselasa("Jam Kesepuluh", 0)
        TimePickerIstirahat1.Text = GetDataselasa("Istirahat 1", 0)
        TimePickerKurang5Menit1.Text = GetDataselasa("Istirahat1 <5M", 0)
        TimePickerKurang5Menit2.Text = GetDataselasa("Istirahat2 <5M", 0)
        TimePickerIstirahat2.Text = GetDataselasa("Istirahat 2", 0)
        TimePickerPulang.Text = GetDataselasa("Jam Pulang", 0)
    End Sub
    Private Sub DataToTimePickerRabu()
        TimePicker1.Text = GetDataRabu("Jam Pertama", 0)
        TimePicker2.Text = GetDataRabu("Jam Kedua", 0)
        TimePicker3.Text = GetDataRabu("Jam Ketiga", 0)
        TimePicker4.Text = GetDataRabu("Jam Keempat", 0)
        TimePicker5.Text = GetDataRabu("Jam Kelima", 0)
        TimePicker6.Text = GetDataRabu("Jam Keenam", 0)
        TimePicker7.Text = GetDataRabu("Jam Ketujuh", 0)
        TimePicker8.Text = GetDataRabu("Jam Kedelapan", 0)
        TimePicker9.Text = GetDataRabu("Jam Kesembilan", 0)
        TimePicker10.Text = GetDataRabu("Jam Kesepuluh", 0)
        TimePickerIstirahat1.Text = GetDataRabu("Istirahat 1", 0)
        TimePickerKurang5Menit1.Text = GetDataRabu("Istirahat1 <5M", 0)
        TimePickerKurang5Menit2.Text = GetDataRabu("Istirahat2 <5M", 0)
        TimePickerIstirahat2.Text = GetDataRabu("Istirahat 2", 0)
        TimePickerPulang.Text = GetDataRabu("Jam Pulang", 0)
    End Sub
    Private Sub DataToTimePickerKamis()
        TimePicker1.Text = GetDataKamis("Jam Pertama", 0)
        TimePicker2.Text = GetDataKamis("Jam Kedua", 0)
        TimePicker3.Text = GetDataKamis("Jam Ketiga", 0)
        TimePicker4.Text = GetDataKamis("Jam Keempat", 0)
        TimePicker5.Text = GetDataKamis("Jam Kelima", 0)
        TimePicker6.Text = GetDataKamis("Jam Keenam", 0)
        TimePicker7.Text = GetDataKamis("Jam Ketujuh", 0)
        TimePicker8.Text = GetDataKamis("Jam Kedelapan", 0)
        TimePicker9.Text = GetDataKamis("Jam Kesembilan", 0)
        TimePicker10.Text = GetDataKamis("Jam Kesepuluh", 0)
        TimePickerIstirahat1.Text = GetDataKamis("Istirahat 1", 0)
        TimePickerKurang5Menit1.Text = GetDataKamis("Istirahat1 <5M", 0)
        TimePickerKurang5Menit2.Text = GetDataKamis("Istirahat2 <5M", 0)
        TimePickerIstirahat2.Text = GetDataKamis("Istirahat 2", 0)
        TimePickerPulang.Text = GetDataKamis("Jam Pulang", 0)
    End Sub
    Private Sub DataToTimePickerJumat()
        TimePicker1.Text = GetDataJumat("Jam Pertama", 0)
        TimePicker2.Text = GetDataJumat("Jam Kedua", 0)
        TimePicker3.Text = GetDataJumat("Jam Ketiga", 0)
        TimePicker4.Text = GetDataJumat("Jam Keempat", 0)
        TimePicker5.Text = GetDataJumat("Jam Kelima", 0)
        TimePicker6.Text = GetDataJumat("Jam Keenam", 0)
        TimePicker7.Text = GetDataJumat("Istirahat2 <5M", 0)
        TimePicker8.Text = GetDataJumat("Jam Kedelapan", 0)
        TimePicker9.Text = GetDataJumat("Jam Kesembilan", 0)
        TimePicker10.Text = GetDataJumat("Jam Kesepuluh", 0)
        TimePicker11.Text = GetDataJumat("Jam Kesebelas", 0)
        TimePickerIstirahat1.Text = GetDataJumat("Istirahat 1", 0)
        TimePickerKurang5Menit1.Text = GetDataJumat("Istirahat1 <5M", 0)
        TimePickerKurang5Menit2.Text = GetDataJumat("Istirahat 2", 0)
        TimePickerIstirahat2.Text = GetDataJumat("Jam Ketujuh", 0)
        TimePickerPulang.Text = GetDataJumat("Jam Pulang", 0)
    End Sub
    Private Sub DataToTimePickerSabtu()
        TimePicker1.Text = GetDataSabtu("Jam Pertama", 0)
        TimePicker2.Text = GetDataSabtu("Jam Kedua", 0)
        TimePicker3.Text = GetDataSabtu("Jam Ketiga", 0)
        TimePicker4.Text = GetDataSabtu("Jam Keempat", 0)
        TimePicker5.Text = GetDataSabtu("Jam Kelima", 0)
        TimePicker6.Text = GetDataSabtu("Jam Keenam", 0)
        TimePicker7.Text = GetDataSabtu("Jam Ketujuh", 0)
        TimePicker8.Text = GetDataSabtu("Jam Kedelapan", 0)
        TimePicker9.Text = GetDataSabtu("Jam Kesembilan", 0)
        TimePicker10.Text = GetDataSabtu("Jam Kesepuluh", 0)
        TimePickerIstirahat1.Text = GetDataSabtu("Istirahat 1", 0)
        TimePickerKurang5Menit1.Text = GetDataSabtu("Istirahat1 <5M", 0)
        TimePickerKurang5Menit2.Text = GetDataSabtu("Istirahat2 <5M", 0)
        TimePickerIstirahat2.Text = GetDataSabtu("Istirahat 2", 0)
        TimePickerPulang.Text = GetDataSabtu("Jam Pulang", 0)
    End Sub

    'validasi dengan Label1
    Private Sub TimerValidate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerValidate.Tick
        If Label1.Text = "Senin" Then
            senin()
        ElseIf Label1.Text = "Selasa" Then
            selasa()
        ElseIf Label1.Text = "Rabu" Then
            Rabu()
        ElseIf Label1.Text = "Kamis" Then
            Kamis()
        ElseIf Label1.Text = "Jumat" Then
            Jumat()
        ElseIf Label1.Text = "Sabtu" Then
            Sabtu()

        End If
    End Sub


    Sub senin()
        If TimePicker1.Text = TimeOfDay Then
            If Not PathJam1 = "" Then
                MenuAwal.WMP.URL = PathJam1
            Else
                MenuAwal.WMP.URL = GetDatasenin("Jam Pertama", 2)
            End If
        ElseIf TimePicker2.Text = TimeOfDay Then
            If Not PathJam2 = "" Then
                MenuAwal.WMP.URL = PathJam2
            Else
                MenuAwal.WMP.URL = GetDatasenin("Jam Kedua", 2)
            End If
        ElseIf TimePicker3.Text = TimeOfDay Then
            If Not PathJam3 = "" Then
                MenuAwal.WMP.URL = PathJam3
            Else
                MenuAwal.WMP.URL = GetDatasenin("Jam Ketiga", 2)
            End If
        ElseIf TimePicker4.Text = TimeOfDay Then
            If Not PathJam4 = "" Then
                MenuAwal.WMP.URL = PathJam4
            Else
                MenuAwal.WMP.URL = GetDatasenin("Jam Keempat", 2)
            End If
        ElseIf TimePicker5.Text = TimeOfDay Then
            If Not PathJam5 = "" Then
                MenuAwal.WMP.URL = PathJam5
            Else
                MenuAwal.WMP.URL = GetDatasenin("Jam Kelima", 2)
            End If
        ElseIf TimePicker6.Text = TimeOfDay Then
            If Not PathJam6 = "" Then
                MenuAwal.WMP.URL = PathJam6
            Else
                MenuAwal.WMP.URL = GetDatasenin("Jam Keenam", 2)
            End If
        ElseIf TimePicker7.Text = TimeOfDay Then
            If Not PathJam7 = "" Then
                MenuAwal.WMP.URL = PathJam7
            Else
                MenuAwal.WMP.URL = GetDatasenin("Jam Ketujuh", 2)
            End If
        ElseIf TimePicker8.Text = TimeOfDay Then
            If Not PathJam8 = "" Then
                MenuAwal.WMP.URL = PathJam8
            Else
                MenuAwal.WMP.URL = GetDatasenin("Jam Kedelapan", 2)
            End If
        ElseIf TimePicker9.Text = TimeOfDay Then
            If Not PathJam9 = "" Then
                MenuAwal.WMP.URL = PathJam9
            Else
                MenuAwal.WMP.URL = GetDatasenin("Jam Kesembilan", 2)
            End If
        ElseIf TimePicker10.Text = TimeOfDay Then
            If Not PathJam10 = "" Then
                MenuAwal.WMP.URL = PathJam10
            Else
                MenuAwal.WMP.URL = GetDatasenin("Jam Kesepuluh", 2)
            End If
        ElseIf TimePickerIstirahat1.Text = TimeOfDay Then
            If Not PathIstirahat1 = "" Then
                MenuAwal.WMP.URL = PathIstirahat1
            Else
                MenuAwal.WMP.URL = GetDatasenin("Istirahat 1", 2)
            End If
        ElseIf TimePickerKurang5Menit1.Text = TimeOfDay Then
            If Not path5menitistirahat1 = "" Then
                MenuAwal.WMP.URL = path5menitistirahat1
            Else
                MenuAwal.WMP.URL = GetDatasenin("Istirahat1 <5M", 2)
            End If
        ElseIf TimePickerKurang5Menit2.Text = TimeOfDay Then
            If Not path5menitistirahat2 = "" Then
                MenuAwal.WMP.URL = path5menitistirahat2
            Else
                MenuAwal.WMP.URL = GetDatasenin("Istirahat2 <5M", 2)
            End If
        ElseIf TimePickerIstirahat2.Text = TimeOfDay Then
            If Not PathIstirahat2 = "" Then
                MenuAwal.WMP.URL = PathIstirahat2
            Else
                MenuAwal.WMP.URL = GetDatasenin("Istirahat 2", 2)
            End If
        ElseIf TimePickerPulang.Text = TimeOfDay Then
            If Not pathpulang = "" Then
                MenuAwal.WMP.URL = pathpulang
            Else
                MenuAwal.WMP.URL = GetDatasenin("Jam Pulang", 2)
            End If
        End If
    End Sub
    Sub selasa()
        If TimePicker1.Text = TimeOfDay Then
            If Not PathJam1 = "" Then
                MenuAwal.WMP.URL = PathJam1
            Else
                MenuAwal.WMP.URL = GetDataselasa("Jam Pertama", 2)
            End If
        ElseIf TimePicker2.Text = TimeOfDay Then
            If Not PathJam2 = "" Then
                MenuAwal.WMP.URL = PathJam2
            Else
                MenuAwal.WMP.URL = GetDataselasa("Jam Kedua", 2)
            End If
        ElseIf TimePicker3.Text = TimeOfDay Then
            If Not PathJam3 = "" Then
                MenuAwal.WMP.URL = PathJam3
            Else
                MenuAwal.WMP.URL = GetDataselasa("Jam Ketiga", 2)
            End If
        ElseIf TimePicker4.Text = TimeOfDay Then
            If Not PathJam4 = "" Then
                MenuAwal.WMP.URL = PathJam4
            Else
                MenuAwal.WMP.URL = GetDataselasa("Jam Keempat", 2)
            End If
        ElseIf TimePicker5.Text = TimeOfDay Then
            If Not PathJam5 = "" Then
                MenuAwal.WMP.URL = PathJam5
            Else
                MenuAwal.WMP.URL = GetDataselasa("Jam Kelima", 2)
            End If
        ElseIf TimePicker6.Text = TimeOfDay Then
            If Not PathJam6 = "" Then
                MenuAwal.WMP.URL = PathJam6
            Else
                MenuAwal.WMP.URL = GetDataselasa("Jam Keenam", 2)
            End If
        ElseIf TimePicker7.Text = TimeOfDay Then
            If Not PathJam7 = "" Then
                MenuAwal.WMP.URL = PathJam7
            Else
                MenuAwal.WMP.URL = GetDataselasa("Jam Ketujuh", 2)
            End If
        ElseIf TimePicker8.Text = TimeOfDay Then
            If Not PathJam8 = "" Then
                MenuAwal.WMP.URL = PathJam8
            Else
                MenuAwal.WMP.URL = GetDataselasa("Jam Kedelapan", 2)
            End If
        ElseIf TimePicker9.Text = TimeOfDay Then
            If Not PathJam9 = "" Then
                MenuAwal.WMP.URL = PathJam9
            Else
                MenuAwal.WMP.URL = GetDataselasa("Jam Kesembilan", 2)
            End If
        ElseIf TimePicker10.Text = TimeOfDay Then
            If Not PathJam10 = "" Then
                MenuAwal.WMP.URL = PathJam10
            Else
                MenuAwal.WMP.URL = GetDataselasa("Jam Kesepuluh", 2)
            End If
        ElseIf TimePickerIstirahat1.Text = TimeOfDay Then
            If Not PathIstirahat1 = "" Then
                MenuAwal.WMP.URL = PathIstirahat1
            Else
                MenuAwal.WMP.URL = GetDataselasa("Istirahat 1", 2)
            End If
        ElseIf TimePickerKurang5Menit1.Text = TimeOfDay Then
            If Not path5menitistirahat1 = "" Then
                MenuAwal.WMP.URL = path5menitistirahat1
            Else
                MenuAwal.WMP.URL = GetDataselasa("Istirahat1 <5M", 2)
            End If
        ElseIf TimePickerKurang5Menit2.Text = TimeOfDay Then
            If Not path5menitistirahat2 = "" Then
                MenuAwal.WMP.URL = path5menitistirahat2
            Else
                MenuAwal.WMP.URL = GetDataselasa("Istirahat2 <5M", 2)
            End If

        ElseIf TimePickerIstirahat2.Text = TimeOfDay Then
            If Not PathIstirahat2 = "" Then
                MenuAwal.WMP.URL = PathIstirahat2
            Else
                MenuAwal.WMP.URL = GetDataselasa("Istirahat 2", 2)
            End If
        ElseIf TimePickerPulang.Text = TimeOfDay Then
            If Not pathpulang = "" Then
                MenuAwal.WMP.URL = pathpulang
            Else
                MenuAwal.WMP.URL = GetDataselasa("Jam Pulang", 2)
            End If
        End If
    End Sub
    Sub Rabu()
        If TimePicker1.Text = TimeOfDay Then
            If Not PathJam1 = "" Then
                MenuAwal.WMP.URL = PathJam1
            Else
                MenuAwal.WMP.URL = GetDataRabu("Jam Pertama", 2)
            End If
        ElseIf TimePicker2.Text = TimeOfDay Then
            If Not PathJam2 = "" Then
                MenuAwal.WMP.URL = PathJam2
            Else
                MenuAwal.WMP.URL = GetDataRabu("Jam Kedua", 2)
            End If
        ElseIf TimePicker3.Text = TimeOfDay Then
            If Not PathJam3 = "" Then
                MenuAwal.WMP.URL = PathJam3
            Else
                MenuAwal.WMP.URL = GetDataRabu("Jam Ketiga", 2)
            End If
        ElseIf TimePicker4.Text = TimeOfDay Then
            If Not PathJam4 = "" Then
                MenuAwal.WMP.URL = PathJam4
            Else
                MenuAwal.WMP.URL = GetDataRabu("Jam Keempat", 2)
            End If
        ElseIf TimePicker5.Text = TimeOfDay Then
            If Not PathJam5 = "" Then
                MenuAwal.WMP.URL = PathJam5
            Else
                MenuAwal.WMP.URL = GetDataRabu("Jam Kelima", 2)
            End If
        ElseIf TimePicker6.Text = TimeOfDay Then
            If Not PathJam6 = "" Then
                MenuAwal.WMP.URL = PathJam6
            Else
                MenuAwal.WMP.URL = GetDataRabu("Jam Keenam", 2)
            End If
        ElseIf TimePicker7.Text = TimeOfDay Then
            If Not PathJam7 = "" Then
                MenuAwal.WMP.URL = PathJam7
            Else
                MenuAwal.WMP.URL = GetDataRabu("Jam Ketujuh", 2)
            End If
        ElseIf TimePicker8.Text = TimeOfDay Then
            If Not PathJam8 = "" Then
                MenuAwal.WMP.URL = PathJam8
            Else
                MenuAwal.WMP.URL = GetDataRabu("Jam Kedelapan", 2)
            End If
        ElseIf TimePicker9.Text = TimeOfDay Then
            If Not PathJam9 = "" Then
                MenuAwal.WMP.URL = PathJam9
            Else
                MenuAwal.WMP.URL = GetDataRabu("Jam Kesembilan", 2)
            End If
        ElseIf TimePicker10.Text = TimeOfDay Then
            If Not PathJam10 = "" Then
                MenuAwal.WMP.URL = PathJam10
            Else
                MenuAwal.WMP.URL = GetDataRabu("Jam Kesepuluh", 2)
            End If
        ElseIf TimePickerIstirahat1.Text = TimeOfDay Then
            If Not PathIstirahat1 = "" Then
                MenuAwal.WMP.URL = PathIstirahat1
            Else
                MenuAwal.WMP.URL = GetDataRabu("Istirahat 1", 2)
            End If
        ElseIf TimePickerKurang5Menit1.Text = TimeOfDay Then
            If Not path5menitistirahat1 = "" Then
                MenuAwal.WMP.URL = path5menitistirahat1
            Else
                MenuAwal.WMP.URL = GetDataRabu("Istirahat1 <5M", 2)
            End If
        ElseIf TimePickerKurang5Menit2.Text = TimeOfDay Then
            If Not path5menitistirahat2 = "" Then
                MenuAwal.WMP.URL = path5menitistirahat2
            Else
                MenuAwal.WMP.URL = GetDataRabu("Istirahat2 <5M", 2)
            End If
        ElseIf TimePickerIstirahat2.Text = TimeOfDay Then
            If Not PathIstirahat2 = "" Then
                MenuAwal.WMP.URL = PathIstirahat2
            Else
                MenuAwal.WMP.URL = GetDataRabu("Istirahat 2", 2)
            End If
        ElseIf TimePickerPulang.Text = TimeOfDay Then
            If Not pathpulang = "" Then
                MenuAwal.WMP.URL = pathpulang
            Else
                MenuAwal.WMP.URL = GetDataRabu("Jam pulang", 2)
            End If
        End If
    End Sub
    Sub Kamis()
        If TimePicker1.Text = TimeOfDay Then
            If Not PathJam1 = "" Then
                MenuAwal.WMP.URL = PathJam1
            Else
                MenuAwal.WMP.URL = GetDataKamis("Jam Pertama", 2)
            End If
        ElseIf TimePicker2.Text = TimeOfDay Then
            If Not PathJam2 = "" Then
                MenuAwal.WMP.URL = PathJam2
            Else
                MenuAwal.WMP.URL = GetDataKamis("Jam Kedua", 2)
            End If
        ElseIf TimePicker3.Text = TimeOfDay Then
            If Not PathJam3 = "" Then
                MenuAwal.WMP.URL = PathJam3
            Else
                MenuAwal.WMP.URL = GetDataKamis("Jam Ketiga", 2)
            End If
        ElseIf TimePicker4.Text = TimeOfDay Then
            If Not PathJam4 = "" Then
                MenuAwal.WMP.URL = PathJam4
            Else
                MenuAwal.WMP.URL = GetDataKamis("Jam Keempat", 2)
            End If
        ElseIf TimePicker5.Text = TimeOfDay Then
            If Not PathJam5 = "" Then
                MenuAwal.WMP.URL = PathJam5
            Else
                MenuAwal.WMP.URL = GetDataKamis("Jam Kelima", 2)
            End If
        ElseIf TimePicker6.Text = TimeOfDay Then
            If Not PathJam6 = "" Then
                MenuAwal.WMP.URL = PathJam6
            Else
                MenuAwal.WMP.URL = GetDataKamis("Jam Keenam", 2)
            End If
        ElseIf TimePicker7.Text = TimeOfDay Then
            If Not PathJam7 = "" Then
                MenuAwal.WMP.URL = PathJam7
            Else
                MenuAwal.WMP.URL = GetDataKamis("Jam Ketujuh", 2)
            End If
        ElseIf TimePicker8.Text = TimeOfDay Then
            If Not PathJam8 = "" Then
                MenuAwal.WMP.URL = PathJam8
            Else
                MenuAwal.WMP.URL = GetDataKamis("Jam Kedelapan", 2)
            End If
        ElseIf TimePicker9.Text = TimeOfDay Then
            If Not PathJam9 = "" Then
                MenuAwal.WMP.URL = PathJam9
            Else
                MenuAwal.WMP.URL = GetDataKamis("Jam Kesembilan", 2)
            End If
        ElseIf TimePicker10.Text = TimeOfDay Then
            If Not PathJam10 = "" Then
                MenuAwal.WMP.URL = PathJam10
            Else
                MenuAwal.WMP.URL = GetDataKamis("Jam Kesepuluh", 2)
            End If
        ElseIf TimePickerIstirahat1.Text = TimeOfDay Then
            If Not PathIstirahat1 = "" Then
                MenuAwal.WMP.URL = PathIstirahat1
            Else
                MenuAwal.WMP.URL = GetDataKamis("Istirahat 1", 2)
            End If
        ElseIf TimePickerKurang5Menit1.Text = TimeOfDay Then
            If Not path5menitistirahat1 = "" Then
                MenuAwal.WMP.URL = path5menitistirahat1
            Else
                MenuAwal.WMP.URL = GetDataKamis("Istirahat1 <5M", 2)
            End If
        ElseIf TimePickerKurang5Menit2.Text = TimeOfDay Then
            If Not path5menitistirahat2 = "" Then
                MenuAwal.WMP.URL = path5menitistirahat2
            Else
                MenuAwal.WMP.URL = GetDataKamis("Istirahat2 <5M", 2)
            End If
        ElseIf TimePickerIstirahat2.Text = TimeOfDay Then
            If Not PathIstirahat2 = "" Then
                MenuAwal.WMP.URL = PathIstirahat2
            Else
                MenuAwal.WMP.URL = GetDataKamis("Istirahat 2", 2)
            End If
        ElseIf TimePickerPulang.Text = TimeOfDay Then
            If Not pathpulang = "" Then
                MenuAwal.WMP.URL = pathpulang
            Else
                MenuAwal.WMP.URL = GetDataKamis("Jam Pulang", 2)
            End If
        End If
    End Sub
    Sub Jumat()
        If TimePicker1.Text = TimeOfDay And TimePicker1.Checked = True Then
            If Not PathJam1 = "" Then
                MenuAwal.WMP.URL = PathJam1
            Else
                MenuAwal.WMP.URL = GetDataJumat("Jam Pertama", 2)
            End If
        ElseIf TimePicker2.Text = TimeOfDay Then
            If Not PathJam2 = "" Then
                MenuAwal.WMP.URL = PathJam2
            Else
                MenuAwal.WMP.URL = GetDataJumat("Jam Kedua", 2)
            End If
        ElseIf TimePicker3.Text = TimeOfDay Then
            If Not PathJam3 = "" Then
                MenuAwal.WMP.URL = PathJam3
            Else
                MenuAwal.WMP.URL = GetDataJumat("Jam Ketiga", 2)
            End If
        ElseIf TimePicker4.Text = TimeOfDay Then
            If Not PathJam4 = "" Then
                MenuAwal.WMP.URL = PathJam4
            Else
                MenuAwal.WMP.URL = GetDataJumat("Jam Keempat", 2)
            End If
        ElseIf TimePicker5.Text = TimeOfDay Then
            If Not PathJam5 = "" Then
                MenuAwal.WMP.URL = PathJam5
            Else
                MenuAwal.WMP.URL = GetDataJumat("Jam Kelima", 2)
            End If
        ElseIf TimePicker6.Text = TimeOfDay Then
            If Not PathJam6 = "" Then
                MenuAwal.WMP.URL = PathJam6
            Else
                MenuAwal.WMP.URL = GetDataJumat("Jam Keenam", 2)
            End If
        ElseIf TimePicker7.Text = TimeOfDay Then
            If Not PathJam7 = "" Then
                MenuAwal.WMP.URL = PathJam7
            Else
                MenuAwal.WMP.URL = GetDataJumat("Istirahat2 <5M", 2)
            End If
        ElseIf TimePicker8.Text = TimeOfDay Then
            If Not PathJam8 = "" Then
                MenuAwal.WMP.URL = PathJam8
            Else
                MenuAwal.WMP.URL = GetDataJumat("Jam Kedelapan", 2)
            End If
        ElseIf TimePicker9.Text = TimeOfDay Then
            If Not PathJam9 = "" Then
                MenuAwal.WMP.URL = PathJam9
            Else
                MenuAwal.WMP.URL = GetDataJumat("Jam Kesembilan", 2)
            End If
        ElseIf TimePicker10.Text = TimeOfDay Then
            If Not PathJam10 = "" Then
                MenuAwal.WMP.URL = PathJam10
            Else
                MenuAwal.WMP.URL = GetDataJumat("Jam Kesepuluh", 2)
            End If
        ElseIf TimePicker11.Text = TimeOfDay Then
            If Not pathjam11 = "" Then
                MenuAwal.WMP.URL = pathjam11
            Else
                MenuAwal.WMP.URL = GetDataJumat("Jam Kesebelas", 2)
            End If
        ElseIf TimePickerIstirahat1.Text = TimeOfDay Then
            If Not PathIstirahat1 = "" Then
                MenuAwal.WMP.URL = PathIstirahat1
            Else
                MenuAwal.WMP.URL = GetDataJumat("Istirahat 1", 2)
            End If
        ElseIf TimePickerKurang5Menit1.Text = TimeOfDay Then
            If Not path5menitistirahat1 = "" Then
                MenuAwal.WMP.URL = path5menitistirahat1
            Else
                MenuAwal.WMP.URL = GetDataJumat("Istirahat1 <5M", 2)
            End If
        ElseIf TimePickerKurang5Menit2.Text = TimeOfDay Then
            If Not path5menitistirahat2 = "" Then
                MenuAwal.WMP.URL = path5menitistirahat2
            Else
                MenuAwal.WMP.URL = GetDataJumat("Istirahat 2", 2)
            End If
        ElseIf TimePickerIstirahat2.Text = TimeOfDay Then
            If Not PathIstirahat2 = "" Then
                MenuAwal.WMP.URL = PathIstirahat2
            Else
                MenuAwal.WMP.URL = GetDataJumat("Jam Ketujuh", 2)
            End If
        ElseIf TimePickerPulang.Text = TimeOfDay Then
            If Not pathpulang = "" Then
                MenuAwal.WMP.URL = pathpulang
            Else
                MenuAwal.WMP.URL = GetDataJumat("Jam Pulang", 2)
            End If
        End If
    End Sub
    Sub Sabtu()
        If TimePicker1.Text = TimeOfDay Then
            If Not PathJam1 = "" Then
                MenuAwal.WMP.URL = PathJam1
            Else
                MenuAwal.WMP.URL = GetDataSabtu("Jam Pertama", 2)
            End If
        ElseIf TimePicker2.Text = TimeOfDay Then
            If Not PathJam2 = "" Then
                MenuAwal.WMP.URL = PathJam2
            Else
                MenuAwal.WMP.URL = GetDataSabtu("Jam Kedua", 2)
            End If
        ElseIf TimePicker3.Text = TimeOfDay Then
            If Not PathJam3 = "" Then
                MenuAwal.WMP.URL = PathJam3
            Else
                MenuAwal.WMP.URL = GetDataSabtu("Jam Ketiga", 2)
            End If
        ElseIf TimePicker4.Text = TimeOfDay Then
            If Not PathJam4 = "" Then
                MenuAwal.WMP.URL = PathJam4
            Else
                MenuAwal.WMP.URL = GetDataSabtu("Jam Keempat", 2)
            End If
        ElseIf TimePicker5.Text = TimeOfDay Then
            If Not PathJam5 = "" Then
                MenuAwal.WMP.URL = PathJam5
            Else
                MenuAwal.WMP.URL = GetDataSabtu("Jam Kelima", 2)
            End If
        ElseIf TimePicker6.Text = TimeOfDay Then
            If Not PathJam6 = "" Then
                MenuAwal.WMP.URL = PathJam6
            Else
                MenuAwal.WMP.URL = GetDataSabtu("Jam Keenam", 2)
            End If
        ElseIf TimePicker7.Text = TimeOfDay Then
            If Not PathJam7 = "" Then
                MenuAwal.WMP.URL = PathJam7
            Else
                MenuAwal.WMP.URL = GetDataSabtu("Jam Ketujuh", 2)
            End If
        ElseIf TimePicker8.Text = TimeOfDay Then
            If Not PathJam8 = "" Then
                MenuAwal.WMP.URL = PathJam8
            Else
                MenuAwal.WMP.URL = GetDataSabtu("Jam Kedelapan", 2)
            End If
        ElseIf TimePicker9.Text = TimeOfDay Then
            If Not PathJam9 = "" Then
                MenuAwal.WMP.URL = PathJam9
            Else
                MenuAwal.WMP.URL = GetDataSabtu("Jam Kesembilan", 2)
            End If
        ElseIf TimePicker10.Text = TimeOfDay Then
            If Not PathJam10 = "" Then
                MenuAwal.WMP.URL = PathJam10
            Else
                MenuAwal.WMP.URL = GetDataSabtu("Jam Kesepuluh", 2)
            End If
        ElseIf TimePickerIstirahat1.Text = TimeOfDay Then
            If Not PathIstirahat1 = "" Then
                MenuAwal.WMP.URL = PathIstirahat1
            Else
                MenuAwal.WMP.URL = GetDataSabtu("Istirahat 1", 2)
            End If
        ElseIf TimePickerKurang5Menit1.Text = TimeOfDay Then
            If Not path5menitistirahat1 = "" Then
                MenuAwal.WMP.URL = path5menitistirahat1
            Else
                MenuAwal.WMP.URL = GetDataSabtu("Istirahat1 <5M", 2)
            End If
        ElseIf TimePickerKurang5Menit2.Text = TimeOfDay Then
            If Not path5menitistirahat2 = "" Then
                MenuAwal.WMP.URL = path5menitistirahat2
            Else
                MenuAwal.WMP.URL = GetDataSabtu("Istirahat2 <5M", 2)
            End If
        ElseIf TimePickerIstirahat2.Text = TimeOfDay Then
            If Not PathIstirahat2 = "" Then
                MenuAwal.WMP.URL = PathIstirahat2
            Else
                MenuAwal.WMP.URL = GetDataSabtu("Istirahat 2", 2)
            End If
        ElseIf TimePickerPulang.Text = TimeOfDay Then
            If Not pathpulang = "" Then
                MenuAwal.WMP.URL = pathpulang
            Else
                MenuAwal.WMP.URL = GetDataSabtu("Jam Pulang", 2)
            End If
        End If

    End Sub


    Private Sub BtnSelectIstirahat1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectIstirahat1.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathIstirahat1 = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BtnSelectIstirahat2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectIstirahat2.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathIstirahat2 = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BtnSelect1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect1.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathJam1 = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BtnSelect2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSelect2.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathJam2 = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BtnSelect3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect3.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathJam3 = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BtnSelect4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect4.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathJam4 = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BtnSelect5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect5.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathJam5 = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BtnSelect6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect6.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathJam6 = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BtnSelect7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect7.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathJam7 = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BtnSelect8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect8.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathJam8 = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BtnSelect9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect9.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathJam9 = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BtnSelect10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect10.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathJam10 = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BtnSelect11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect11.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pathjam11 = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BntSelectPulang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BntSelectPulang.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pathpulang = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Btnkurang5menit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnkurang5menit1.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            path5menitistirahat1 = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BtnKurang5Menit2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKurang5Menit2.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            path5menitistirahat2 = OpenFileDialog1.FileName
        End If
    End Sub


    'Form Load
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConOpen()
        If DateTimePicker3.Value.DayOfWeek = 0 Then
            MsgBox("Hinggu")


        ElseIf DateTimePicker3.Value.DayOfWeek = 1 Then
            Lblistirahat2.Text = "Istirahat 2"
            LblJam7.Text = "Jam Ketujuh"
            LblKurang5menit2.Text = "Istirahat2 <5M"
            DataToTimePickersenin()
            Label1.Text = "Senin"
            PictureBox26.Visible = False
            PictureBox14.Visible = False
            seninstatus1()
            seninstatus2()
            seninstatus3()
            seninstatus4()
            seninstatus5()
            seninstatus6()
            seninstatus7()
            seninstatus8()
            seninstatus9()
            seninstatus10()
            seninstatusistirahat1()
            seninstatusistirahat2()
            seninstatuskurang5menit1()
            seninstatuskurang5menit2()
            seninstatuspulang()

            TimePickerPulang.Location = New Point(176, 70)
            LblPulang.Location = New Point(9, 75)
            BntSelectPulang.Location = New Point(267, 68)
            PictureBox25.Location = New Point(137, 68)
            PictureBox13.Location = New Point(137, 68)
        ElseIf DateTimePicker3.Value.DayOfWeek = 2 Then
            Lblistirahat2.Text = "Istirahat 2"
            LblJam7.Text = "Jam Ketujuh"
            LblKurang5menit2.Text = "Istirahat2 <5M"
            DataToTimePickerselasa()
            Label1.Text = "Selasa"
            PictureBox26.Visible = False
            PictureBox14.Visible = False

            selasastatus1()
            Selasastatus2()
            Selasastatus3()
            Selasastatus4()
            Selasastatus5()
            Selasastatus6()
            Selasastatus7()
            Selasastatus8()
            Selasastatus9()
            Selasastatus10()
            Selasastatusistirahat1()
            Selasastatusistirahat2()
            Selasastatuskurang5menit1()
            Selasastatuskurang5menit2()
            Selasastatuspulang()

            TimePickerPulang.Location = New Point(176, 70)
            LblPulang.Location = New Point(9, 75)
            BntSelectPulang.Location = New Point(267, 68)
            PictureBox25.Location = New Point(137, 68)
            PictureBox13.Location = New Point(137, 68)

        ElseIf DateTimePicker3.Value.DayOfWeek = 3 Then
            Lblistirahat2.Text = "Istirahat 2"
            LblJam7.Text = "Jam Ketujuh"
            LblKurang5menit2.Text = "Istirahat2 <5M"
            DataToTimePickerRabu()
            Label1.Text = "Rabu"
            PictureBox26.Visible = False
            PictureBox14.Visible = False

            Rabustatus1()
            Rabustatus2()
            Rabustatus3()
            Rabustatus4()
            Rabustatus5()
            Rabustatus6()
            Rabustatus7()
            Rabustatus8()
            Rabustatus9()
            Rabustatus10()
            Rabustatusistirahat1()
            Rabustatusistirahat2()
            Rabustatuskurang5menit1()
            Rabustatuskurang5menit2()
            Rabustatuspulang()

            TimePickerPulang.Location = New Point(176, 70)
            LblPulang.Location = New Point(9, 75)
            BntSelectPulang.Location = New Point(267, 68)
            PictureBox25.Location = New Point(137, 68)
            PictureBox13.Location = New Point(137, 68)

        ElseIf DateTimePicker3.Value.DayOfWeek = 4 Then
            Lblistirahat2.Text = "Istirahat 2"
            LblJam7.Text = "Jam Ketujuh"
            LblKurang5menit2.Text = "Istirahat2 <5M"

            DataToTimePickerKamis()
            Label1.Text = "Kamis"
            PictureBox26.Visible = False
            PictureBox14.Visible = False

            Kamisstatus1()
            Kamisstatus2()
            Kamisstatus3()
            Kamisstatus4()
            Kamisstatus5()
            Kamisstatus6()
            Kamisstatus7()
            Kamisstatus8()
            Kamisstatus9()
            Kamisstatus10()
            Kamisstatusistirahat1()
            Kamisstatusistirahat2()
            Kamisstatuskurang5menit1()
            Kamisstatuskurang5menit2()
            Kamisstatuspulang()

            TimePickerPulang.Location = New Point(176, 70)
            LblPulang.Location = New Point(9, 75)
            BntSelectPulang.Location = New Point(273, 68)
            PictureBox25.Location = New Point(137, 68)
            PictureBox13.Location = New Point(137, 68)

        ElseIf DateTimePicker3.Value.DayOfWeek = 5 Then
            Lblistirahat2.Text = "Jam Ketujuh"
            LblJam7.Text = "Istirahat2 <5M"
            LblKurang5menit2.Text = "Istirahat 2"

            DataToTimePickerJumat()
            Label1.Text = "Jumat"
            TimePicker11.Visible = True
            LblJam11.Visible = True
            BtnSelect11.Visible = True

            Jumatstatus1()
            Jumatstatus2()
            Jumatstatus3()
            Jumatstatus4()
            Jumatstatus5()
            Jumatstatus6()
            Jumatstatus7()
            Jumatstatus8()
            Jumatstatus9()
            Jumatstatus10()
            Jumatstatus11()
            Jumatstatusistirahat1()
            Jumatstatusistirahat2()
            Jumatstatuskurang5menit1()
            Jumatstatuskurang5menit2()
            Jumatstatuspulang()

            TimePickerPulang.Location = New Point(176, 99)
            LblPulang.Location = New Point(9, 105)
            BntSelectPulang.Location = New Point(267, 97)
            PictureBox25.Location = New Point(137, 96)
            PictureBox13.Location = New Point(137, 96)

        ElseIf DateTimePicker3.Value.DayOfWeek = 6 Then
            Lblistirahat2.Text = "Istirahat 2"
            LblJam7.Text = "Jam Ketujuh"
            LblKurang5menit2.Text = "Istirahat2 <5M"

            DataToTimePickerSabtu()
            Label1.Text = "Sabtu"
            PictureBox26.Visible = False
            PictureBox14.Visible = False

            Sabtustatus1()
            Sabtustatus2()
            Sabtustatus3()
            Sabtustatus4()
            Sabtustatus5()
            Sabtustatus6()
            Sabtustatus7()
            Sabtustatus8()
            Sabtustatus9()
            Sabtustatus10()
            Sabtustatusistirahat1()
            Sabtustatusistirahat2()
            Sabtustatuskurang5menit1()
            Sabtustatuskurang5menit2()
            Sabtustatuspulang()

             TimePickerPulang.Location = New Point(176, 70)
            LblPulang.Location = New Point(9, 75)
            BntSelectPulang.Location = New Point(267, 68)
            PictureBox25.Location = New Point(137, 68)
            PictureBox13.Location = New Point(137, 68)


        End If

    End Sub

    'Button Pilih Hari
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSenin.Click
        Lblistirahat2.Text = "Istirahat 2"
        LblJam7.Text = "Jam Ketujuh"
        LblKurang5menit2.Text = "Istirahat2 <5M"
        Label1.Text = "Senin"
        PathJam1 = ""
        PathJam2 = ""
        PathJam3 = ""
        PathJam4 = ""
        PathJam5 = ""
        PathJam6 = ""
        PathJam7 = ""
        PathJam8 = ""
        PathJam9 = ""
        PathJam10 = ""
        pathjam11 = ""
        PathIstirahat1 = ""
        PathIstirahat2 = ""
        pathpulang = ""
        path5menitistirahat1 = ""
        path5menitistirahat2 = ""
        DataToTimePickersenin()
        BtnRabu.BackColor = Color.MediumTurquoise
        BtnSenin.BackColor = Color.Red
        BtnSelasa.BackColor = Color.MediumTurquoise
        BtnKAmis.BackColor = Color.MediumTurquoise
        BtnSabtu.BackColor = Color.MediumTurquoise
        BtnJumat.BackColor = Color.MediumTurquoise
        BtnSenin.Enabled = False
        BtnJumat.Enabled = True
        BtnKAmis.Enabled = True
        BtnSelasa.Enabled = True
        BtnRabu.Enabled = True
        BtnSabtu.Enabled = True
        BtnSelect11.Visible = False
        LblJam11.Visible = False
        TimePicker11.Visible = False
        PictureBox26.Visible = False
        PictureBox14.Visible = False

        seninstatus1()
        seninstatus2()
        seninstatus3()
        seninstatus4()
        seninstatus5()
        seninstatus6()
        seninstatus7()
        seninstatus8()
        seninstatus9()
        seninstatus10()
        seninstatusistirahat1()
        seninstatusistirahat2()
        seninstatuskurang5menit1()
        seninstatuskurang5menit2()
        seninstatuspulang()

        TimePickerPulang.Location = New Point(176, 70)
        LblPulang.Location = New Point(9, 75)
        BntSelectPulang.Location = New Point(267, 68)
        PictureBox25.Location = New Point(137, 68)
        PictureBox13.Location = New Point(137, 68)
    End Sub

    Private Sub BtnSelasa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelasa.Click
        Label1.Text = "Selasa"
        Lblistirahat2.Text = "Istirahat 2"
        LblJam7.Text = "Jam Ketujuh"
        LblKurang5menit2.Text = "Istirahat2 <5M"
        PathJam1 = ""
        PathJam2 = ""
        PathJam3 = ""
        PathJam4 = ""
        PathJam5 = ""
        PathJam6 = ""
        PathJam7 = ""
        PathJam8 = ""
        PathJam9 = ""
        PathJam10 = ""
        pathjam11 = ""
        pathpulang = ""
        PathIstirahat1 = ""
        PathIstirahat2 = ""
        path5menitistirahat1 = ""
        path5menitistirahat2 = ""
        DataToTimePickerselasa()
        BtnRabu.BackColor = Color.MediumTurquoise
        BtnSenin.BackColor = Color.MediumTurquoise
        BtnSelasa.BackColor = Color.Red
        BtnKAmis.BackColor = Color.MediumTurquoise
        BtnSabtu.BackColor = Color.MediumTurquoise
        BtnJumat.BackColor = Color.MediumTurquoise
        BtnSenin.Enabled = True
        BtnSabtu.Enabled = True
        BtnJumat.Enabled = True
        BtnKAmis.Enabled = True
        BtnSelasa.Enabled = False
        BtnRabu.Enabled = True
        BtnSelect11.Visible = False
        LblJam11.Visible = False
        TimePicker11.Visible = False
        PictureBox26.Visible = False
        PictureBox14.Visible = False

        selasastatus1()
        Selasastatus2()
        Selasastatus3()
        Selasastatus4()
        Selasastatus5()
        Selasastatus6()
        Selasastatus7()
        Selasastatus8()
        Selasastatus9()
        Selasastatus10()
        Selasastatusistirahat1()
        Selasastatusistirahat2()
        Selasastatuskurang5menit1()
        Selasastatuskurang5menit2()
        Selasastatuspulang()

        TimePickerPulang.Location = New Point(176, 70)
        LblPulang.Location = New Point(9, 75)
        BntSelectPulang.Location = New Point(267, 68)
        PictureBox25.Location = New Point(137, 68)
        PictureBox13.Location = New Point(137, 68)
    End Sub

    Private Sub BtnRabu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRabu.Click
        Label1.Text = "Rabu"
        Lblistirahat2.Text = "Istirahat 2"
        LblJam7.Text = "Jam Ketujuh"
        LblKurang5menit2.Text = "Istirahat2 <5M"
        PathJam1 = ""
        PathJam2 = ""
        PathJam3 = ""
        PathJam4 = ""
        PathJam5 = ""
        PathJam6 = ""
        PathJam7 = ""
        PathJam8 = ""
        PathJam9 = ""
        PathJam10 = ""
        pathjam11 = ""
        PathIstirahat1 = ""
        PathIstirahat2 = ""
        pathpulang = ""
        path5menitistirahat1 = ""
        path5menitistirahat2 = ""
        DataToTimePickerRabu()

        BtnRabu.BackColor = Color.Red
        BtnSenin.BackColor = Color.MediumTurquoise
        BtnSelasa.BackColor = Color.MediumTurquoise
        BtnKAmis.BackColor = Color.MediumTurquoise
        BtnSabtu.BackColor = Color.MediumTurquoise
        BtnJumat.BackColor = Color.MediumTurquoise
      
        BtnSenin.Enabled = True
        BtnJumat.Enabled = True
        BtnSabtu.Enabled = True
        BtnKAmis.Enabled = True
        BtnSelasa.Enabled = True
        BtnRabu.Enabled = False
        BtnSelect11.Visible = False
        LblJam11.Visible = False
        TimePicker11.Visible = False
        PictureBox26.Visible = False
        PictureBox14.Visible = False

        Rabustatus1()
        Rabustatus2()
        Rabustatus3()
        Rabustatus4()
        Rabustatus5()
        Rabustatus6()
        Rabustatus7()
        Rabustatus8()
        Rabustatus9()
        Rabustatus10()
        Rabustatusistirahat1()
        Rabustatusistirahat2()
        Rabustatuspulang()
        Rabustatuskurang5menit1()
        Rabustatuskurang5menit2()

        TimePickerPulang.Location = New Point(176, 70)
        LblPulang.Location = New Point(9, 75)
        BntSelectPulang.Location = New Point(267, 68)
        PictureBox25.Location = New Point(137, 68)
        PictureBox13.Location = New Point(137, 68)
    End Sub

    Private Sub BtnKAmis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKAmis.Click
        Label1.Text = "Kamis"
        Lblistirahat2.Text = "Istirahat 2"
        LblJam7.Text = "Jam Ketujuh"
        LblKurang5menit2.Text = "Istirahat2 <5M"
        PathJam1 = ""
        PathJam2 = ""
        PathJam3 = ""
        PathJam4 = ""
        PathJam5 = ""
        PathJam6 = ""
        PathJam7 = ""
        PathJam8 = ""
        PathJam9 = ""
        PathJam10 = ""
        pathjam11 = ""
        pathpulang = ""
        PathIstirahat1 = ""
        PathIstirahat2 = ""
        path5menitistirahat1 = ""
        path5menitistirahat2 = ""
        DataToTimePickerKamis()
        BtnSenin.Enabled = True
        BtnRabu.BackColor = Color.MediumTurquoise
        BtnSenin.BackColor = Color.MediumTurquoise
        BtnSelasa.BackColor = Color.MediumTurquoise
        BtnKAmis.BackColor = Color.Red
        BtnSabtu.BackColor = Color.MediumTurquoise
        BtnJumat.BackColor = Color.MediumTurquoise
        BtnJumat.Enabled = True
        BtnKAmis.Enabled = False
        BtnSabtu.Enabled = True
        BtnSelasa.Enabled = True
        BtnRabu.Enabled = True
        BtnSelect11.Visible = False
        LblJam11.Visible = False
        TimePicker11.Visible = False
        PictureBox26.Visible = False
        PictureBox14.Visible = False

        Kamisstatus1()
        Kamisstatus2()
        Kamisstatus3()
        Kamisstatus4()
        Kamisstatus5()
        Kamisstatus6()
        Kamisstatus7()
        Kamisstatus8()
        Kamisstatus9()
        Kamisstatus10()
        Kamisstatusistirahat1()
        Kamisstatusistirahat2()
        Kamisstatuskurang5menit1()
        Kamisstatuskurang5menit2()
        Kamisstatuspulang()

        TimePickerPulang.Location = New Point(176, 70)
        LblPulang.Location = New Point(9, 75)
        BntSelectPulang.Location = New Point(267, 68)
        PictureBox25.Location = New Point(137, 68)
        PictureBox13.Location = New Point(137, 68)

    End Sub

    Private Sub BtnJumat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJumat.Click
        Label1.Text = "Jumat"
        Lblistirahat2.Text = "Jam Ketujuh"
        LblJam7.Text = "Istirahat2 <5M"
        LblKurang5menit2.Text = "Istirahat 2"
        PathJam1 = ""
        PathJam2 = ""
        PathJam3 = ""
        PathJam4 = ""
        PathJam5 = ""
        PathJam6 = ""
        PathJam7 = ""
        PathJam8 = ""
        PathJam9 = ""
        PathJam10 = ""
        pathjam11 = ""
        PathIstirahat1 = ""
        PathIstirahat2 = ""
        pathpulang = ""
        path5menitistirahat1 = ""
        path5menitistirahat2 = ""
        DataToTimePickerJumat()
        BtnRabu.BackColor = Color.MediumTurquoise
        BtnSenin.BackColor = Color.MediumTurquoise
        BtnSelasa.BackColor = Color.MediumTurquoise
        BtnKAmis.BackColor = Color.MediumTurquoise
        BtnSabtu.BackColor = Color.MediumTurquoise
        BtnJumat.BackColor = Color.Red


        BtnSenin.Enabled = True
        BtnJumat.Enabled = False
        BtnKAmis.Enabled = True
        BtnSabtu.Enabled = True
        BtnSelasa.Enabled = True
        BtnRabu.Enabled = True
        BtnSelect11.Visible = True
        LblJam11.Visible = True
        TimePicker11.Visible = True


        Jumatstatus1()
        Jumatstatus2()
        Jumatstatus3()
        Jumatstatus4()
        Jumatstatus5()
        Jumatstatus6()
        Jumatstatus7()
        Jumatstatus8()
        Jumatstatus9()
        Jumatstatus10()
        Jumatstatus11()
        Jumatstatusistirahat1()
        Jumatstatuskurang5menit1()
        Jumatstatuskurang5menit2()
        Jumatstatusistirahat2()
        Jumatstatuspulang()

        TimePickerPulang.Location = New Point(176, 99)
        LblPulang.Location = New Point(9, 105)
        BntSelectPulang.Location = New Point(267, 97)
        PictureBox25.Location = New Point(137, 96)
        PictureBox13.Location = New Point(137, 96)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSabtu.Click
        Label1.Text = "Sabtu"
        Lblistirahat2.Text = "Istirahat 2"
        LblJam7.Text = "Jam Ketujuh"
        LblKurang5menit2.Text = "Istirahat2 <5M"
        PathJam1 = ""
        PathJam2 = ""
        PathJam3 = ""
        PathJam4 = ""
        PathJam5 = ""
        PathJam6 = ""
        PathJam7 = ""
        PathJam8 = ""
        PathJam9 = ""
        PathJam10 = ""
        pathjam11 = ""
        PathIstirahat1 = ""
        pathpulang = ""
        PathIstirahat2 = ""
        path5menitistirahat1 = ""
        path5menitistirahat2 = ""
        DataToTimePickerSabtu()
        BtnRabu.BackColor = Color.MediumTurquoise
        BtnSenin.BackColor = Color.MediumTurquoise
        BtnSelasa.BackColor = Color.MediumTurquoise
        BtnKAmis.BackColor = Color.MediumTurquoise
        BtnSabtu.BackColor = Color.Red
        BtnJumat.BackColor = Color.MediumTurquoise
        BtnSenin.Enabled = True
        BtnJumat.Enabled = True
        BtnKAmis.Enabled = True
        BtnSelasa.Enabled = True
        BtnRabu.Enabled = True
        BtnSabtu.Enabled = False
        BtnSelect11.Visible = False
        LblJam11.Visible = False
        TimePicker11.Visible = False
        PictureBox14.Visible = False
        PictureBox26.Visible = False

        Sabtustatus1()
        Sabtustatus2()
        Sabtustatus3()
        Sabtustatus4()
        Sabtustatus5()
        Sabtustatus6()
        Sabtustatus7()
        Sabtustatus8()
        Sabtustatus9()
        Sabtustatus10()
        Sabtustatusistirahat1()
        Sabtustatusistirahat2()
        Sabtustatuskurang5menit1()
        Sabtustatuskurang5menit2()
        Sabtustatuspulang()

        TimePickerPulang.Location = New Point(176, 70)
        LblPulang.Location = New Point(9, 75)
        BntSelectPulang.Location = New Point(267, 68)
        PictureBox25.Location = New Point(137, 68)
        PictureBox13.Location = New Point(137, 68)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not pathceksound = "" Then
            cmd = New OleDbCommand("update Senin set song='" & pathceksound & "' where keterangan='" & Button3.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If Not pathpulangcepat = "" Then
            cmd = New OleDbCommand("update Senin set song='" & pathpulangcepat & "' where keterangan='" & Button2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If Label1.Text = "Senin" Then
            seninjam1()
            seninjam2()
            seninjam3()
            seninjam4()
            seninjam5()
            seninjam6()
            seninjam7()
            seninjam8()
            seninjam9()
            seninjam10()
            seninist1()
            seninist2()
            SeninPulang()
            seninist1kurang5()
            seninist2kurang5()

            seninstatus1()
        ElseIf Label1.Text = "Selasa" Then
            Selasajam1()
            Selasajam2()
            Selasajam3()
            Selasajam4()
            Selasajam5()
            Selasajam6()
            Selasajam7()
            Selasajam8()
            Selasajam9()
            Selasajam10()
            Selasaist1()
            Selasaist2()
            selasaist2kurang5()
            Selasaist1kurang5()
            SelasaPulang()
        ElseIf Label1.Text = "Rabu" Then
            Rabujam1()
            Rabujam2()
            Rabujam3()
            Rabujam4()
            Rabujam5()
            Rabujam6()
            Rabujam7()
            Rabujam8()
            Rabujam9()
            Rabujam10()
            Rabuist1()
            Rabuist2()
            Rabuist1kurang5()
            Rabuist2kurang5()
            RabuPulang()
        ElseIf Label1.Text = "Kamis" Then
            Kamisjam1()
            Kamisjam2()
            Kamisjam3()
            Kamisjam4()
            Kamisjam5()
            Kamisjam6()
            Kamisjam7()
            Kamisjam8()
            Kamisjam9()
            Kamisjam10()
            Kamisist1()
            Kamisist2()
            Kamisist1kurang5()
            Kamisist2kurang5()
            KamisPulang()
        ElseIf Label1.Text = "Jumat" Then
            Jumatjam1()
            Jumatjam2()
            Jumatjam3()
            Jumatjam4()
            Jumatjam5()
            Jumatjam6()
            Jumatjam7()
            Jumatjam8()
            Jumatjam9()
            Jumatjam10()
            Jumatjam11()
            Jumatist1()
            Jumatist2()
            Jumatist1kurang5()
            Jumatist2kurang5()
            JumatPulang()
        ElseIf Label1.Text = "Sabtu" Then
            Sabtujam1()
            Sabtujam2()
            Sabtujam3()
            Sabtujam4()
            Sabtujam5()
            Sabtujam6()
            Sabtujam7()
            Sabtujam8()
            Sabtujam9()
            Sabtujam10()
            Sabtuist1()
            Sabtuist2()
            Sabtuist1kurang5()
            Sabtuist2kurang5()
            SabtuPulang()

        End If
        MsgBox("Settingan Anda Berhasil Di Simpan", MsgBoxStyle.Information, "Suksess")
    End Sub


    Private Sub seninjam1()
        If TimePicker1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam1 = "" Then
            cmd = New OleDbCommand("update Senin set [time]='" & TimePicker1.Text & "' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set [time]='" & TimePicker1.Text & "', song='" & PathJam1 & "' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set status ='aktif' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub seninjam2()
        If TimePicker2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam2 = "" Then
            cmd = New OleDbCommand("update Senin set [time]='" & TimePicker2.Text & "' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set [time]='" & TimePicker2.Text & "', song='" & PathJam2 & "' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set status ='aktif' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub seninjam3()
        If TimePicker3.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam3 = "" Then
            cmd = New OleDbCommand("update Senin set [time]='" & TimePicker3.Text & "' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set [time]='" & TimePicker3.Text & "', song='" & PathJam3 & "' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker3.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set status ='aktif' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub seninjam4()
        If TimePicker4.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam4 = "" Then
            cmd = New OleDbCommand("update Senin set [time]='" & TimePicker4.Text & "' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set [time]='" & TimePicker4.Text & "', song='" & PathJam4 & "' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker4.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set status ='aktif' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub seninjam5()
        If TimePicker5.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam5 = "" Then
            cmd = New OleDbCommand("update Senin set [time]='" & TimePicker5.Text & "' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set [time]='" & TimePicker5.Text & "', song='" & PathJam5 & "' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()

        End If
        If TimePicker5.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set status ='aktif' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub seninjam6()
        If TimePicker6.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam6 = "" Then
            cmd = New OleDbCommand("update Senin set [time]='" & TimePicker6.Text & "' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set [time]='" & TimePicker6.Text & "', song='" & PathJam6 & "' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker6.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set status ='aktif' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub seninjam7()
        If TimePicker7.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam7 = "" Then
            cmd = New OleDbCommand("update Senin set [time]='" & TimePicker7.Text & "' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set [time]='" & TimePicker7.Text & "', song='" & PathJam7 & "' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker7.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set status ='aktif' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub seninjam8()
        If TimePicker8.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam8 = "" Then
            cmd = New OleDbCommand("update Senin set [time]='" & TimePicker8.Text & "' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set [time]='" & TimePicker8.Text & "', song='" & PathJam8 & "' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker8.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set status ='aktif' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub seninjam9()
        If TimePicker9.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam9 = "" Then
            cmd = New OleDbCommand("update Senin set [time]='" & TimePicker9.Text & "' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set [time]='" & TimePicker9.Text & "', song='" & PathJam9 & "' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker9.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set status ='aktif' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub seninjam10()
        If TimePicker10.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam10 = "" Then
            cmd = New OleDbCommand("update Senin set [time]='" & TimePicker10.Text & "' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set [time]='" & TimePicker10.Text & "', song='" & PathJam10 & "' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()

        End If
        If TimePicker10.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set status ='aktif' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub seninist1()
        If TimePickerIstirahat1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathIstirahat1 = "" Then
            cmd = New OleDbCommand("update Senin set [time]='" & TimePickerIstirahat1.Text & "' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set [time]='" & TimePickerIstirahat1.Text & "', song='" & PathIstirahat1 & "' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerIstirahat1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set status ='aktif' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub seninist1kurang5()
        If TimePickerKurang5Menit1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf path5menitistirahat1 = "" Then
            cmd = New OleDbCommand("update Senin set [time]='" & TimePickerKurang5Menit1.Text & "' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set [time]='" & TimePickerKurang5Menit1.Text & "', song='" & path5menitistirahat1 & "' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerKurang5Menit1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set status ='aktif' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub seninist2kurang5()
        If TimePickerKurang5Menit2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf path5menitistirahat2 = "" Then
            cmd = New OleDbCommand("update Senin set [time]='" & TimePickerKurang5Menit2.Text & "' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set [time]='" & TimePickerKurang5Menit2.Text & "',status = 'aktif', song='" & path5menitistirahat2 & "' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerKurang5Menit2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set status ='aktif' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub seninist2()
        If TimePickerIstirahat2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathIstirahat2 = "" Then
            cmd = New OleDbCommand("update Senin set [time]='" & TimePickerIstirahat2.Text & "' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set [time]='" & TimePickerIstirahat2.Text & "', song='" & PathIstirahat2 & "' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerIstirahat2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set status ='aktif' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub SeninPulang()
        If TimePickerPulang.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf pathpulang = "" Then
            cmd = New OleDbCommand("update Senin set [time]='" & TimePickerPulang.Text & "' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set [time]='" & TimePickerPulang.Text & "', song='" & pathpulang & "' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerPulang.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Senin set status ='nonaktif' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Senin set status ='aktif' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub

    Private Sub Selasajam1()
        If TimePicker1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam1 = "" Then
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePicker1.Text & "' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePicker1.Text & "', song='" & PathJam1 & "' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set status ='aktif' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Selasajam2()
        If TimePicker2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam2 = "" Then
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePicker2.Text & "' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePicker2.Text & "', song='" & PathJam2 & "' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set status ='aktif' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Selasajam3()
        If TimePicker3.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam3 = "" Then
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePicker3.Text & "' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePicker3.Text & "', song='" & PathJam3 & "' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker3.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set status ='aktif' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Selasajam4()
        If TimePicker4.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam4 = "" Then
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePicker4.Text & "' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePicker4.Text & "', song='" & PathJam4 & "' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker4.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set status ='aktif' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Selasajam5()
        If TimePicker5.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam5 = "" Then
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePicker5.Text & "' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePicker5.Text & "', song='" & PathJam5 & "' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker5.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set status ='aktif' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub Selasajam6()
        If TimePicker6.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam6 = "" Then
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePicker6.Text & "' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePicker6.Text & "', song='" & PathJam6 & "' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker6.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set status ='aktif' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub Selasajam7()
        If TimePicker7.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam7 = "" Then
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePicker7.Text & "' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePicker7.Text & "', song='" & PathJam7 & "' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker7.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set status ='aktif' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub Selasajam8()
        If TimePicker8.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam8 = "" Then
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePicker8.Text & "' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePicker8.Text & "', song='" & PathJam8 & "' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker8.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set status ='aktif' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Selasajam9()
        If TimePicker9.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam9 = "" Then
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePicker9.Text & "' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePicker9.Text & "', song='" & PathJam9 & "' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker9.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set status ='aktif' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub Selasajam10()
        If TimePicker10.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam10 = "" Then
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePicker10.Text & "' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePicker10.Text & "', song='" & PathJam10 & "' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

        If TimePicker10.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set status ='aktif' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub Selasaist1()
        If TimePickerIstirahat1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathIstirahat1 = "" Then
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePickerIstirahat1.Text & "' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePickerIstirahat1.Text & "', song='" & PathIstirahat1 & "' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerIstirahat1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set status ='aktif' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Selasaist2()
        If TimePickerIstirahat2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathIstirahat2 = "" Then
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePickerIstirahat2.Text & "' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePickerIstirahat2.Text & "', song='" & PathIstirahat2 & "' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerIstirahat2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set status ='aktif' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub Selasaist1kurang5()
        If TimePickerKurang5Menit1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf path5menitistirahat1 = "" Then
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePickerKurang5Menit1.Text & "' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePickerKurang5Menit1.Text & "', song='" & path5menitistirahat1 & "' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerKurang5Menit1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set status ='aktif' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub selasaist2kurang5()
        If TimePickerKurang5Menit2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf path5menitistirahat2 = "" Then
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePickerKurang5Menit2.Text & "' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePickerKurang5Menit2.Text & "', song='" & path5menitistirahat2 & "' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerKurang5Menit2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set status ='aktif' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub SelasaPulang()
        If TimePickerPulang.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf pathpulang = "" Then
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePickerPulang.Text & "' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set [time]='" & TimePickerPulang.Text & "', song='" & pathpulang & "' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerPulang.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Selasa set status ='nonaktif' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Selasa set status ='aktif' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub

    Private Sub Rabujam1()
        If TimePicker1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam1 = "" Then
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePicker1.Text & "' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePicker1.Text & "', song='" & PathJam1 & "' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set status ='aktif' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub Rabujam2()
        If TimePicker2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam2 = "" Then
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePicker2.Text & "' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePicker2.Text & "', song='" & PathJam2 & "' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set status ='aktif' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub Rabujam3()
        If TimePicker3.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam3 = "" Then
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePicker3.Text & "' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePicker3.Text & "', song='" & PathJam3 & "' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker3.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set status ='aktif' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub Rabujam4()
        If TimePicker4.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam4 = "" Then
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePicker4.Text & "' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePicker4.Text & "', song='" & PathJam4 & "' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker4.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set status ='aktif' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub Rabujam5()
        If TimePicker5.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam5 = "" Then
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePicker5.Text & "' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePicker5.Text & "', song='" & PathJam5 & "' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker5.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set status ='aktif' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub Rabujam6()
        If TimePicker6.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam6 = "" Then
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePicker6.Text & "' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePicker6.Text & "', song='" & PathJam6 & "' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker6.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set status ='aktif' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Rabujam7()
        If TimePicker7.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam7 = "" Then
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePicker7.Text & "' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePicker7.Text & "' , song='" & PathJam7 & "'where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker7.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set status ='aktif' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub Rabujam8()
        If TimePicker8.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam8 = "" Then
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePicker8.Text & "' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePicker8.Text & "', song='" & PathJam8 & "' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker8.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set status ='aktif' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Rabujam9()
        If TimePicker9.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam9 = "" Then
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePicker9.Text & "' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePicker9.Text & "', song='" & PathJam9 & "' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker9.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set status ='aktif' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Rabujam10()
        If TimePicker10.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam10 = "" Then
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePicker10.Text & "' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePicker10.Text & "', song='" & PathJam10 & "' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker10.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set status ='aktif' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Rabuist1()
        If TimePickerIstirahat1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathIstirahat1 = "" Then
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePickerIstirahat1.Text & "' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePickerIstirahat1.Text & "', song='" & PathIstirahat1 & "' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerIstirahat1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set status ='aktif' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Rabuist2()
        If TimePickerIstirahat2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathIstirahat2 = "" Then
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePickerIstirahat2.Text & "' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePickerIstirahat2.Text & "', song='" & PathIstirahat2 & "' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerIstirahat2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set status ='aktif' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Rabuist1kurang5()
        If TimePickerKurang5Menit1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf path5menitistirahat1 = "" Then
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePickerKurang5Menit1.Text & "' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePickerKurang5Menit1.Text & "', song='" & path5menitistirahat1 & "' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerKurang5Menit1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set status ='aktif' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Rabuist2kurang5()
        If TimePickerKurang5Menit2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf path5menitistirahat2 = "" Then
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePickerKurang5Menit2.Text & "' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePickerKurang5Menit2.Text & "', song='" & path5menitistirahat2 & "' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerKurang5Menit2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set status ='aktif' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub RabuPulang()
        If TimePickerPulang.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf pathpulang = "" Then
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePickerPulang.Text & "' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set [time]='" & TimePickerPulang.Text & "', song='" & pathpulang & "' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerPulang.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Rabu set status ='nonaktif' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Rabu set status ='aktif' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub

    Private Sub Kamisjam1()
        If TimePicker1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam1 = "" Then
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePicker1.Text & "' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePicker1.Text & "' , song='" & PathJam1 & "'where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()

        End If
        If TimePicker1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set status ='aktif' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Kamisjam2()
        If TimePicker2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam2 = "" Then
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePicker2.Text & "' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePicker2.Text & "' , song='" & PathJam2 & "'where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set status ='aktif' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Kamisjam3()
        If TimePicker3.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam3 = "" Then
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePicker3.Text & "' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePicker3.Text & "' , song='" & PathJam3 & "'where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker3.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set status ='aktif' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Kamisjam4()
        If TimePicker4.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam4 = "" Then
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePicker4.Text & "' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePicker4.Text & "', song='" & PathJam4 & "' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker4.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set status ='aktif' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Kamisjam5()
        If TimePicker5.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam5 = "" Then
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePicker5.Text & "' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePicker5.Text & "' , song='" & PathJam5 & "'where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker5.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set status ='aktif' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Kamisjam6()
        If TimePicker6.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam6 = "" Then
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePicker6.Text & "' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePicker6.Text & "' , song='" & PathJam6 & "'where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker6.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set status ='aktif' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Kamisjam7()
        If TimePicker7.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam7 = "" Then
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePicker7.Text & "' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePicker7.Text & "' , song='" & PathJam7 & "'where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker7.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set status ='aktif' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Kamisjam8()
        If TimePicker8.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam8 = "" Then
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePicker8.Text & "' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePicker8.Text & "', song='" & PathJam8 & "' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()

        End If
        If TimePicker8.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set status ='aktif' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Kamisjam9()
        If TimePicker9.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam9 = "" Then
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePicker9.Text & "' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePicker9.Text & "' , song='" & PathJam9 & "'where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker9.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set status ='aktif' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If


    End Sub
    Private Sub Kamisjam10()
        If TimePicker10.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam10 = "" Then
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePicker10.Text & "' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePicker10.Text & "', song='" & PathJam10 & "' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()

        End If
        If TimePicker10.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set status ='aktif' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub Kamisist1()
        If TimePickerIstirahat1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathIstirahat1 = "" Then
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePickerIstirahat1.Text & "' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePickerIstirahat1.Text & "', song='" & PathIstirahat1 & "' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerIstirahat1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set status ='aktif' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Kamisist2()
        If TimePickerIstirahat2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathIstirahat2 = "" Then
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePickerIstirahat2.Text & "' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePickerIstirahat2.Text & "', song='" & PathIstirahat2 & "' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

        If TimePickerIstirahat2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set status ='aktif' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub Kamisist1kurang5()
        If TimePickerKurang5Menit1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf path5menitistirahat1 = "" Then
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePickerKurang5Menit1.Text & "' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePickerKurang5Menit1.Text & "', song='" & path5menitistirahat1 & "' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerKurang5Menit1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set status ='aktif' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Kamisist2kurang5()
        If TimePickerKurang5Menit2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf path5menitistirahat2 = "" Then
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePickerKurang5Menit2.Text & "' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePickerKurang5Menit2.Text & "', song='" & path5menitistirahat2 & "' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerKurang5Menit2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set status ='aktif' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If


    End Sub
    Private Sub KamisPulang()
        If TimePickerPulang.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf pathpulang = "" Then
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePickerPulang.Text & "' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set [time]='" & TimePickerPulang.Text & "', song='" & pathpulang & "' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerPulang.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Kamis set status ='nonaktif' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Kamis set status ='aktif' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub

    Private Sub Jumatjam1()
        If TimePicker1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()


        ElseIf PathJam1 = "" Then
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePicker1.Text & "' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePicker1.Text & "', song='" & PathJam1 & "' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

        If TimePicker1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set status ='aktif' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub Jumatjam2()
        If TimePicker2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()

        ElseIf PathJam2 = "" Then
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePicker2.Text & "' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePicker2.Text & "'  , song='" & PathJam2 & "'where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

        If TimePicker2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set status ='aktif' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub Jumatjam3()
        If TimePicker3.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()

        ElseIf PathJam3 = "" Then
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePicker3.Text & "' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePicker3.Text & "', song='" & PathJam3 & "' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

        If TimePicker3.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set status ='aktif' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub Jumatjam4()
        If TimePicker4.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()

        ElseIf PathJam4 = "" Then
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePicker4.Text & "' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePicker4.Text & "', song='" & PathJam4 & "' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker4.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set status ='aktif' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Jumatjam5()
        If TimePicker5.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()

        ElseIf PathJam5 = "" Then
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePicker5.Text & "' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePicker5.Text & "' , song='" & PathJam5 & "'where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker5.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set status ='aktif' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Jumatjam6()
        If TimePicker6.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()

        ElseIf PathJam6 = "" Then
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePicker6.Text & "' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePicker6.Text & "' , song='" & PathJam6 & "'where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

        If TimePicker6.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set status ='aktif' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Jumatjam7()
        If TimePicker7.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()

        ElseIf PathJam7 = "" Then
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePicker7.Text & "' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePicker7.Text & "' , song='" & PathJam7 & "'where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker7.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set status ='aktif' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Jumatjam8()
        If TimePicker8.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()

        ElseIf PathJam8 = "" Then
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePicker8.Text & "' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePicker8.Text & "' , song='" & PathJam8 & "' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker8.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set status ='aktif' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Jumatjam9()
        If TimePicker9.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()

        ElseIf PathJam9 = "" Then
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePicker9.Text & "' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePicker9.Text & "' , song='" & PathJam9 & "' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker9.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set status ='aktif' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Jumatjam10()
        If TimePicker10.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()

        ElseIf PathJam10 = "" Then
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePicker10.Text & "' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePicker10.Text & "', song='" & PathJam10 & "' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker10.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set status ='aktif' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Jumatjam11()
        If TimePicker11.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblJam11.Text & "'", con)
            cmd.ExecuteNonQuery()

        ElseIf pathjam11 = "" Then
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePicker11.Text & "' where keterangan='" & LblJam11.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePicker11.Text & "', song='" & pathjam11 & "' where keterangan='" & LblJam11.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker11.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblJam11.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set status ='aktif' where keterangan='" & LblJam11.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Jumatist1()
        If TimePickerIstirahat1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()

        ElseIf PathIstirahat1 = "" Then
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePickerIstirahat1.Text & "' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePickerIstirahat1.Text & "', song='" & PathIstirahat1 & "' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerIstirahat1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set status ='aktif' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub Jumatist2()
        If TimePickerIstirahat2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()

        ElseIf PathIstirahat2 = "" Then
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePickerIstirahat2.Text & "' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePickerIstirahat2.Text & "', song='" & PathIstirahat2 & "' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerIstirahat2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set status ='aktif' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If


    End Sub
    Private Sub Jumatist1kurang5()
        If TimePickerKurang5Menit1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()

        ElseIf path5menitistirahat1 = "" Then
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePickerKurang5Menit1.Text & "' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePickerKurang5Menit1.Text & "', song='" & path5menitistirahat1 & "' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerKurang5Menit1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set status ='aktif' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Jumatist2kurang5()
        If TimePickerKurang5Menit2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()

        ElseIf path5menitistirahat2 = "" Then
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePickerKurang5Menit2.Text & "' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePickerKurang5Menit2.Text & "', song='" & path5menitistirahat2 & "' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerKurang5Menit2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set status ='aktif' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub JumatPulang()
        If TimePickerPulang.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()

        ElseIf pathpulang = "" Then
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePickerPulang.Text & "' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set [time]='" & TimePickerPulang.Text & "', song='" & pathpulang & "' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

        If TimePickerPulang.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Jumat set status ='nonaktif' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Jumat set status ='aktif' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub


    Private Sub Sabtujam1()
        If TimePicker1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam1 = "" Then
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePicker1.Text & "' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePicker1.Text & "', song='" & PathJam1 & "' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set status ='aktif' where keterangan='" & LblJam1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Sabtujam2()
        If TimePicker2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam2 = "" Then
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePicker2.Text & "' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePicker2.Text & "', song='" & PathJam2 & "' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set status ='aktif' where keterangan='" & LblJam2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub Sabtujam3()
        If TimePicker3.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam3 = "" Then
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePicker3.Text & "' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePicker3.Text & "', song='" & PathJam3 & "' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker3.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set status ='aktif' where keterangan='" & LblJam3.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub Sabtujam4()
        If TimePicker4.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam4 = "" Then
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePicker4.Text & "' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePicker4.Text & "', song='" & PathJam4 & "' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker4.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set status ='aktif' where keterangan='" & LblJam4.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Sabtujam5()
        If TimePicker5.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam5 = "" Then
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePicker5.Text & "' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePicker5.Text & "', song='" & PathJam5 & "' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()

        End If
        If TimePicker5.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set status ='aktif' where keterangan='" & LblJam5.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Sabtujam6()
        If TimePicker6.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam6 = "" Then
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePicker6.Text & "' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePicker6.Text & "', song='" & PathJam6 & "' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker6.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set status ='aktif' where keterangan='" & LblJam6.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Sabtujam7()
        If TimePicker7.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam7 = "" Then
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePicker7.Text & "' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePicker7.Text & "', song='" & PathJam7 & "' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker7.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set status ='aktif' where keterangan='" & LblJam7.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Sabtujam8()
        If TimePicker8.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam8 = "" Then
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePicker8.Text & "' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePicker8.Text & "', song='" & PathJam8 & "' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker8.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set status ='aktif' where keterangan='" & LblJam8.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Sabtujam9()
        If TimePicker9.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam9 = "" Then
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePicker9.Text & "' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePicker9.Text & "', song='" & PathJam9 & "' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePicker9.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set status ='aktif' where keterangan='" & LblJam9.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Sabtujam10()
        If TimePicker10.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathJam10 = "" Then
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePicker10.Text & "' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePicker10.Text & "', song='" & PathJam10 & "' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()

        End If
        If TimePicker10.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set status ='aktif' where keterangan='" & LblJam10.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Sabtuist1()
        If TimePickerIstirahat1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathIstirahat1 = "" Then
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePickerIstirahat1.Text & "' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePickerIstirahat1.Text & "', song='" & PathIstirahat1 & "' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerIstirahat1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set status ='aktif' where keterangan='" & Lblistirahat1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Sabtuist1kurang5()
        If TimePickerKurang5Menit1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf path5menitistirahat1 = "" Then
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePickerKurang5Menit1.Text & "' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePickerKurang5Menit1.Text & "', song='" & path5menitistirahat1 & "' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerKurang5Menit1.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set status ='aktif' where keterangan='" & LblKurang5Menit1.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Sabtuist2kurang5()
        If TimePickerKurang5Menit2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf path5menitistirahat2 = "" Then
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePickerKurang5Menit2.Text & "' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePickerKurang5Menit2.Text & "', song='" & path5menitistirahat2 & "' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerKurang5Menit2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set status ='aktif' where keterangan='" & LblKurang5menit2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub Sabtuist2()
        If TimePickerIstirahat2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf PathIstirahat2 = "" Then
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePickerIstirahat2.Text & "' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePickerIstirahat2.Text & "',song='" & PathIstirahat2 & "' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerIstirahat2.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set status ='aktif' where keterangan='" & Lblistirahat2.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Private Sub SabtuPulang()
        If TimePickerPulang.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf pathpulang = "" Then
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePickerPulang.Text & "' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set [time]='" & TimePickerPulang.Text & "', song='" & pathpulang & "' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
        If TimePickerPulang.Text = "00:00:00" Then
            cmd = New OleDbCommand("update Sabtu set status ='nonaktif' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            cmd = New OleDbCommand("update Sabtu set status ='aktif' where keterangan='" & LblPulang.Text & "'", con)
            cmd.ExecuteNonQuery()
        End If
    End Sub




    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        PictureBox1.Visible = False
        PictureBox20.Visible = True
        TimePicker1.Text = "00:00:00"
        BtnSelect1.Enabled = False
        TimePicker1.Enabled = False
    End Sub

    Private Sub PictureBox20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox20.Click
        If Label1.Text = "Senin" Then
            TimePicker1.Text = GetDatasenin("Jam Pertama", 0)
        ElseIf Label1.Text = "Selasa" Then
            TimePicker1.Text = GetDataselasa("Jam Pertama", 0)
        ElseIf Label1.Text = "Rabu" Then
            TimePicker1.Text = GetDataRabu("Jam Pertama", 0)
        ElseIf Label1.Text = "Kamis" Then
            TimePicker1.Text = GetDataKamis("Jam Pertama", 0)
        ElseIf Label1.Text = "Jumat" Then
            TimePicker1.Text = GetDataJumat("Jam Pertama", 0)
        ElseIf Label1.Text = "Sabtu" Then
            TimePicker1.Text = GetDataSabtu("Jam Pertama", 0)
        End If
        PictureBox1.Visible = True
        PictureBox20.Visible = False
        BtnSelect1.Enabled = True
        TimePicker1.Enabled = True
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        PictureBox2.Visible = False
        PictureBox19.Visible = True
        TimePicker2.Text = "00:00:00"
        BtnSelect2.Enabled = False
        TimePicker2.Enabled = False
    End Sub

    Private Sub PictureBox19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox19.Click
        If Label1.Text = "Senin" Then
            TimePicker2.Text = GetDatasenin("Jam Kedua", 0)
        ElseIf Label1.Text = "Selasa" Then
            TimePicker2.Text = GetDataselasa("Jam Kedua", 0)
        ElseIf Label1.Text = "Rabu" Then
            TimePicker2.Text = GetDataRabu("Jam Kedua", 0)
        ElseIf Label1.Text = "Kamis" Then
            TimePicker2.Text = GetDataKamis("Jam Kedua", 0)
        ElseIf Label1.Text = "Jumat" Then
            TimePicker2.Text = GetDataJumat("Jam Kedua", 0)
        ElseIf Label1.Text = "Sabtu" Then
            TimePicker2.Text = GetDataSabtu("Jam Kedua", 0)
        End If
        PictureBox2.Visible = True
        PictureBox19.Visible = False
        BtnSelect2.Enabled = True
        TimePicker2.Enabled = True
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        PictureBox3.Visible = False
        PictureBox18.Visible = True
        TimePicker3.Text = "00:00:00"
        BtnSelect3.Enabled = False
        TimePicker3.Enabled = False
    End Sub

    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        If Label1.Text = "Senin" Then
            TimePicker3.Text = GetDatasenin("Jam Ketiga", 0)
        ElseIf Label1.Text = "Selasa" Then
            TimePicker3.Text = GetDataselasa("Jam Ketiga", 0)
        ElseIf Label1.Text = "Rabu" Then
            TimePicker3.Text = GetDataRabu("Jam Ketiga", 0)
        ElseIf Label1.Text = "Kamis" Then
            TimePicker3.Text = GetDataKamis("Jam Ketiga", 0)
        ElseIf Label1.Text = "Jumat" Then
            TimePicker3.Text = GetDataJumat("Jam Ketiga", 0)
        ElseIf Label1.Text = "Sabtu" Then
            TimePicker3.Text = GetDataSabtu("Jam Ketiga", 0)
        End If
        PictureBox3.Visible = True
        PictureBox18.Visible = False
        BtnSelect3.Enabled = True
        TimePicker3.Enabled = True
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        PictureBox4.Visible = False
        PictureBox17.Visible = True
        TimePickerIstirahat1.Text = "00:00:00"
        BtnSelectIstirahat1.Enabled = False
        TimePickerIstirahat1.Enabled = False
    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.Click
        If Label1.Text = "Senin" Then
            TimePickerIstirahat1.Text = GetDatasenin("Istirahat 1", 0)
        ElseIf Label1.Text = "Selasa" Then
            TimePickerIstirahat1.Text = GetDataselasa("Istirahat 1", 0)
        ElseIf Label1.Text = "Rabu" Then
            TimePickerIstirahat1.Text = GetDataRabu("Istirahat 1", 0)
        ElseIf Label1.Text = "Kamis" Then
            TimePickerIstirahat1.Text = GetDataKamis("Istirahat 1", 0)
        ElseIf Label1.Text = "Jumat" Then
            TimePickerIstirahat1.Text = GetDataJumat("Istirahat 1", 0)
        ElseIf Label1.Text = "Sabtu" Then
            TimePickerIstirahat1.Text = GetDataSabtu("Istirahat 1", 0)
        End If
        PictureBox4.Visible = True
        PictureBox17.Visible = False
        BtnSelectIstirahat1.Enabled = True
        TimePickerIstirahat1.Enabled = True
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        PictureBox8.Visible = False
        PictureBox24.Visible = True
        TimePickerKurang5Menit1.Text = "00:00:00"
        Btnkurang5menit1.Enabled = False
        TimePickerKurang5Menit1.Enabled = False
    End Sub

    Private Sub PictureBox24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox24.Click
        If Label1.Text = "Senin" Then
            TimePickerKurang5Menit1.Text = GetDatasenin("Istirahat1 <5M", 0)
        ElseIf Label1.Text = "Selasa" Then
            TimePickerKurang5Menit1.Text = GetDataselasa("Istirahat1 <5M", 0)
        ElseIf Label1.Text = "Rabu" Then
            TimePickerKurang5Menit1.Text = GetDataRabu("Istirahat1 <5M", 0)
        ElseIf Label1.Text = "Kamis" Then
            TimePickerKurang5Menit1.Text = GetDataKamis("Istirahat1 <5M", 0)
        ElseIf Label1.Text = "Jumat" Then
            TimePickerKurang5Menit1.Text = GetDataJumat("Istirahat1 <5M", 0)
        ElseIf Label1.Text = "Sabtu" Then
            TimePickerKurang5Menit1.Text = GetDataSabtu("Istirahat1 <5M", 0)
        End If
        PictureBox8.Visible = True
        PictureBox24.Visible = False
        Btnkurang5menit1.Enabled = True
        TimePickerKurang5Menit1.Enabled = True
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        PictureBox7.Visible = False
        PictureBox23.Visible = True
        TimePicker4.Text = "00:00:00"
        BtnSelect4.Enabled = False
        TimePicker4.Enabled = False
    End Sub

    Private Sub PictureBox23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox23.Click
        If Label1.Text = "Senin" Then
            TimePicker4.Text = GetDatasenin("Jam Keempat", 0)
        ElseIf Label1.Text = "Selasa" Then
            TimePicker4.Text = GetDataselasa("Jam Keempat", 0)
        ElseIf Label1.Text = "Rabu" Then
            TimePicker4.Text = GetDataRabu("Jam Keempat", 0)
        ElseIf Label1.Text = "Kamis" Then
            TimePicker4.Text = GetDataKamis("Jam Keempat", 0)
        ElseIf Label1.Text = "Jumat" Then
            TimePicker4.Text = GetDataJumat("Jam Keempat", 0)
        ElseIf Label1.Text = "Sabtu" Then
            TimePicker4.Text = GetDataSabtu("Jam Keempat", 0)
        End If
        PictureBox7.Visible = True
        PictureBox23.Visible = False
        BtnSelect4.Enabled = True
        TimePicker4.Enabled = True
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        PictureBox6.Visible = False
        PictureBox22.Visible = True
        TimePicker5.Text = "00:00:00"
        BtnSelect5.Enabled = False
        TimePicker5.Enabled = False
    End Sub

    Private Sub PictureBox22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox22.Click
        If Label1.Text = "Senin" Then
            TimePicker5.Text = GetDatasenin("Jam Kelima", 0)
        ElseIf Label1.Text = "Selasa" Then
            TimePicker5.Text = GetDataselasa("Jam Kelima", 0)
        ElseIf Label1.Text = "Rabu" Then
            TimePicker5.Text = GetDataRabu("Jam Kelima", 0)
        ElseIf Label1.Text = "Kamis" Then
            TimePicker5.Text = GetDataKamis("Jam Kelima", 0)
        ElseIf Label1.Text = "Jumat" Then
            TimePicker5.Text = GetDataJumat("Jam Kelima", 0)
        ElseIf Label1.Text = "Sabtu" Then
            TimePicker5.Text = GetDataSabtu("Jam Kelima", 0)
        End If
        PictureBox6.Visible = True
        PictureBox22.Visible = False
        BtnSelect5.Enabled = True
        TimePicker5.Enabled = True
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        PictureBox5.Visible = False
        PictureBox21.Visible = True
        TimePicker6.Text = "00:00:00"
        BtnSelect6.Enabled = False
        TimePicker6.Enabled = False
    End Sub

    Private Sub PictureBox21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox21.Click
        If Label1.Text = "Senin" Then
            TimePicker6.Text = GetDatasenin("Jam Keenam", 0)
        ElseIf Label1.Text = "Selasa" Then
            TimePicker6.Text = GetDataselasa("Jam Keenam", 0)
        ElseIf Label1.Text = "Rabu" Then
            TimePicker6.Text = GetDataRabu("Jam Keenam", 0)
        ElseIf Label1.Text = "Kamis" Then
            TimePicker6.Text = GetDataKamis("Jam Keenam", 0)
        ElseIf Label1.Text = "Jumat" Then
            TimePicker6.Text = GetDataJumat("Jam Keenam", 0)
        ElseIf Label1.Text = "Sabtu" Then
            TimePicker6.Text = GetDataSabtu("Jam Keenam", 0)
        End If
        PictureBox5.Visible = True
        PictureBox21.Visible = False
        BtnSelect6.Enabled = True
        TimePicker6.Enabled = True
    End Sub

    Private Sub PictureBox32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox32.Click
        If Label1.Text = "Senin" Then
            TimePickerIstirahat2.Text = GetDatasenin("Istirahat 2", 0)
        ElseIf Label1.Text = "Selasa" Then
            TimePickerIstirahat2.Text = GetDataselasa("Istirahat 2", 0)
        ElseIf Label1.Text = "Rabu" Then
            TimePickerIstirahat2.Text = GetDataRabu("Istirahat 2", 0)
        ElseIf Label1.Text = "Kamis" Then
            TimePickerIstirahat2.Text = GetDataKamis("Istirahat 2", 0)
        ElseIf Label1.Text = "Jumat" Then
            TimePickerIstirahat2.Text = GetDataJumat("Jam Ketujuh", 0)
        ElseIf Label1.Text = "Sabtu" Then
            TimePickerIstirahat2.Text = GetDataSabtu("Istirahat 2", 0)
        End If
        PictureBox12.Visible = True
        PictureBox32.Visible = False
        BtnSelectIstirahat2.Enabled = True
        TimePickerIstirahat2.Enabled = True
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        PictureBox12.Visible = False
        PictureBox32.Visible = True
        TimePickerIstirahat2.Text = "00:00:00"
        BtnSelectIstirahat2.Enabled = False
        TimePickerIstirahat2.Enabled = False
    End Sub

    Private Sub PictureBox31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox31.Click
        If Label1.Text = "Senin" Then
            TimePickerKurang5Menit2.Text = GetDatasenin("Istirahat2 <5M", 0)
        ElseIf Label1.Text = "Selasa" Then
            TimePickerKurang5Menit2.Text = GetDataselasa("Istirahat2 <5M", 0)
        ElseIf Label1.Text = "Rabu" Then
            TimePickerKurang5Menit2.Text = GetDataRabu("Istirahat2 <5M", 0)
        ElseIf Label1.Text = "Kamis" Then
            TimePickerKurang5Menit2.Text = GetDataKamis("Istirahat2 <5M", 0)
        ElseIf Label1.Text = "Jumat" Then
            TimePickerKurang5Menit2.Text = GetDataJumat("Istirahat 2", 0)
        ElseIf Label1.Text = "Sabtu" Then
            TimePickerKurang5Menit2.Text = GetDataSabtu("Istirahat2 <5M", 0)
        End If
        PictureBox11.Visible = True
        PictureBox31.Visible = False
        BtnKurang5Menit2.Enabled = True
        TimePickerKurang5Menit2.Enabled = True
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        PictureBox11.Visible = False
        PictureBox31.Visible = True
        TimePickerKurang5Menit2.Text = "00:00:00"
        BtnKurang5Menit2.Enabled = False
        TimePickerKurang5Menit2.Enabled = False
    End Sub

    Private Sub PictureBox30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox30.Click
        If Label1.Text = "Senin" Then
            TimePicker7.Text = GetDatasenin("Jam Ketujuh", 0)
        ElseIf Label1.Text = "Selasa" Then
            TimePicker7.Text = GetDataselasa("Jam Ketujuh", 0)
        ElseIf Label1.Text = "Rabu" Then
            TimePicker7.Text = GetDataRabu("Jam Ketujuh", 0)
        ElseIf Label1.Text = "Kamis" Then
            TimePicker7.Text = GetDataKamis("Jam Ketujuh", 0)
        ElseIf Label1.Text = "Jumat" Then
            TimePicker7.Text = GetDataJumat("Istirahat2 <5M", 0)
        ElseIf Label1.Text = "Sabtu" Then
            TimePicker7.Text = GetDataSabtu("Jam Ketujuh", 0)
        End If
        PictureBox10.Visible = True
        PictureBox30.Visible = False
        BtnSelect7.Enabled = True
        TimePicker7.Enabled = True
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        PictureBox10.Visible = False
        PictureBox30.Visible = True
        TimePicker7.Text = "00:00:00"
        BtnSelect7.Enabled = False
        TimePicker7.Enabled = False
    End Sub

    Private Sub PictureBox29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox29.Click
        If Label1.Text = "Senin" Then
            TimePicker8.Text = GetDatasenin("Jam Kedelapan", 0)
        ElseIf Label1.Text = "Selasa" Then
            TimePicker8.Text = GetDataselasa("Jam Kedelapan", 0)
        ElseIf Label1.Text = "Rabu" Then
            TimePicker8.Text = GetDataRabu("Jam Kedelapan", 0)
        ElseIf Label1.Text = "Kamis" Then
            TimePicker8.Text = GetDataKamis("Jam Kedelapan", 0)
        ElseIf Label1.Text = "Jumat" Then
            TimePicker8.Text = GetDataJumat("Jam Kedelapan", 0)
        ElseIf Label1.Text = "Sabtu" Then
            TimePicker8.Text = GetDataSabtu("Jam Kedelapan", 0)
        End If
        PictureBox9.Visible = True
        PictureBox29.Visible = False
        BtnSelect8.Enabled = True
        TimePicker8.Enabled = True
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        PictureBox9.Visible = False
        PictureBox29.Visible = True
        TimePicker8.Text = "00:00:00"
        BtnSelect8.Enabled = False
        TimePicker8.Enabled = False
    End Sub

    Private Sub PictureBox28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox28.Click
        If Label1.Text = "Senin" Then
            TimePicker9.Text = GetDatasenin("Jam Kesembilan", 0)
        ElseIf Label1.Text = "Selasa" Then
            TimePicker9.Text = GetDataselasa("Jam Kesembilan", 0)
        ElseIf Label1.Text = "Rabu" Then
            TimePicker9.Text = GetDataRabu("Jam Kesembilan", 0)
        ElseIf Label1.Text = "Kamis" Then
            TimePicker9.Text = GetDataKamis("Jam Kesembilan", 0)
        ElseIf Label1.Text = "Jumat" Then
            TimePicker9.Text = GetDataJumat("Jam Kesembilan", 0)
        ElseIf Label1.Text = "Sabtu" Then
            TimePicker9.Text = GetDataSabtu("Jam Kesembilan", 0)
        End If
        PictureBox16.Visible = True
        PictureBox28.Visible = False
        BtnSelect9.Enabled = True
        TimePicker9.Enabled = True
    End Sub


    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        PictureBox16.Visible = False
        PictureBox28.Visible = True
        TimePicker9.Text = "00:00:00"
        BtnSelect9.Enabled = False
        TimePicker9.Enabled = False

    End Sub

    Private Sub PictureBox27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox27.Click
        If Label1.Text = "Senin" Then
            TimePicker10.Text = GetDatasenin("Jam Kesepuluh", 0)
        ElseIf Label1.Text = "Selasa" Then
            TimePicker10.Text = GetDataselasa("Jam Kesepuluh", 0)
        ElseIf Label1.Text = "Rabu" Then
            TimePicker10.Text = GetDataRabu("Jam Kesepuluh", 0)
        ElseIf Label1.Text = "Kamis" Then
            TimePicker10.Text = GetDataKamis("Jam Kesepuluh", 0)
        ElseIf Label1.Text = "Jumat" Then
            TimePicker10.Text = GetDataJumat("Jam Kesepuluh", 0)
        ElseIf Label1.Text = "Sabtu" Then
            TimePicker10.Text = GetDataSabtu("Jam Kesepuluh", 0)
        End If
        PictureBox15.Visible = True
        PictureBox27.Visible = False
        BtnSelect10.Enabled = True
        TimePicker10.Enabled = True
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        PictureBox15.Visible = False
        PictureBox27.Visible = True
        TimePicker10.Text = "00:00:00"
        BtnSelect10.Enabled = False
        TimePicker10.Enabled = False
    End Sub

    Private Sub PictureBox26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox26.Click

        TimePicker11.Text = GetDataJumat("Jam Kesebelas", 0)
        PictureBox14.Visible = True
        PictureBox26.Visible = False
        TimePicker11.Enabled = True
        BtnSelect11.Enabled = True
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        PictureBox14.Visible = False
        PictureBox26.Visible = True
        TimePicker11.Text = "00:00:00"
        TimePicker11.Enabled = False
        BtnSelect11.Enabled = False
    End Sub

    Private Sub PictureBox25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox25.Click
        If Label1.Text = "Senin" Then
            TimePickerPulang.Text = GetDatasenin("Jam Pulang", 0)
        ElseIf Label1.Text = "Selasa" Then
            TimePickerPulang.Text = GetDataselasa("Jam Pulang", 0)
        ElseIf Label1.Text = "Rabu" Then
            TimePickerPulang.Text = GetDataRabu("Jam Pulang", 0)
        ElseIf Label1.Text = "Kamis" Then
            TimePickerPulang.Text = GetDataKamis("Jam Pulang", 0)
        ElseIf Label1.Text = "Jumat" Then
            TimePickerPulang.Text = GetDataJumat("Jam Pulang", 0)
        ElseIf Label1.Text = "Sabtu" Then
            TimePickerPulang.Text = GetDataSabtu("Jam Pulang", 0)
        End If
        PictureBox13.Visible = True
        PictureBox25.Visible = False
        BntSelectPulang.Enabled = True
        TimePickerPulang.Enabled = True
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        PictureBox13.Visible = False
        PictureBox25.Visible = True
        TimePickerPulang.Text = "00:00:00"
        BntSelectPulang.Enabled = False
        TimePickerPulang.Enabled = False
    End Sub


    Private Sub DateTimePicker3_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker3.ValueChanged
        If DateTimePicker3.Value.DayOfWeek = 0 Then
            MsgBox("Hinggu")
        ElseIf DateTimePicker3.Value.DayOfWeek = 1 Then
            DataToTimePickersenin()
            Label1.Text = "Senin"
            BtnSelect11.Visible = False
            LblJam11.Visible = False
            TimePicker11.Visible = False
            PictureBox26.Visible = False
            PictureBox14.Visible = False
            seninstatus1()
            seninstatus2()
            seninstatus3()
            seninstatus4()
            seninstatus5()
            seninstatus6()
            seninstatus7()
            seninstatus8()
            seninstatus9()
            seninstatus10()
            seninstatusistirahat1()
            seninstatusistirahat2()
            seninstatuskurang5menit1()
            seninstatuskurang5menit2()
            seninstatuspulang()

            TimePickerPulang.Location = New Point(176, 70)
            LblPulang.Location = New Point(9, 75)
            BntSelectPulang.Location = New Point(267, 68)
            PictureBox25.Location = New Point(137, 68)
            PictureBox13.Location = New Point(137, 68)


        ElseIf DateTimePicker3.Value.DayOfWeek = 2 Then
            DataToTimePickerselasa()
            Label1.Text = "Selasa"
            BtnSelect11.Visible = False
            LblJam11.Visible = False
            TimePicker11.Visible = False
            PictureBox26.Visible = False
            PictureBox14.Visible = False
            selasastatus1()
            Selasastatus2()
            Selasastatus3()
            Selasastatus4()
            Selasastatus5()
            Selasastatus6()
            Selasastatus7()
            Selasastatus8()
            Selasastatus9()
            Selasastatus10()
            Selasastatusistirahat1()
            Selasastatusistirahat2()
            Selasastatuskurang5menit1()
            Selasastatuskurang5menit2()
            Selasastatuspulang()
            TimePickerPulang.Location = New Point(176, 70)
            LblPulang.Location = New Point(9, 75)
            BntSelectPulang.Location = New Point(267, 68)
            PictureBox25.Location = New Point(137, 68)
            PictureBox13.Location = New Point(137, 68)


        ElseIf DateTimePicker3.Value.DayOfWeek = 3 Then
            DataToTimePickerRabu()
            Label1.Text = "Rabu"
            BtnSelect11.Visible = False
            LblJam11.Visible = False
            TimePicker11.Visible = False
            PictureBox26.Visible = False
            PictureBox14.Visible = False
            Rabustatus1()
            Rabustatus2()
            Rabustatus3()
            Rabustatus4()
            Rabustatus5()
            Rabustatus6()
            Rabustatus7()
            Rabustatus8()
            Rabustatus9()
            Rabustatus10()
            Rabustatusistirahat1()
            Rabustatusistirahat2()
            Rabustatuskurang5menit1()
            Rabustatuskurang5menit2()
            Rabustatuspulang()

            TimePickerPulang.Location = New Point(176, 70)
            LblPulang.Location = New Point(9, 75)
            BntSelectPulang.Location = New Point(267, 68)
            PictureBox25.Location = New Point(137, 68)
            PictureBox13.Location = New Point(137, 68)

        ElseIf DateTimePicker3.Value.DayOfWeek = 4 Then
            DataToTimePickerKamis()
            Label1.Text = "Kamis"
            BtnSelect11.Visible = False
            LblJam11.Visible = False
            TimePicker11.Visible = False
            PictureBox26.Visible = False
            PictureBox14.Visible = False
            Kamisstatus1()
            Kamisstatus2()
            Kamisstatus3()
            Kamisstatus4()
            Kamisstatus5()
            Kamisstatus6()
            Kamisstatus7()
            Kamisstatus8()
            Kamisstatus9()
            Kamisstatus10()
            Kamisstatusistirahat1()
            Kamisstatusistirahat2()
            Kamisstatuskurang5menit1()
            Kamisstatuskurang5menit2()
            Kamisstatuspulang()

            TimePickerPulang.Location = New Point(164, 71)
            TimePickerPulang.Location = New Point(176, 70)
            LblPulang.Location = New Point(9, 75)
            BntSelectPulang.Location = New Point(267, 68)
            PictureBox25.Location = New Point(137, 68)
            PictureBox13.Location = New Point(137, 68)

        ElseIf DateTimePicker3.Value.DayOfWeek = 5 Then
            Lblistirahat2.Text = "Jam Ketujuh"
            LblJam7.Text = "Istirahat2 <5M"
            LblKurang5menit2.Text = "Istirahat 2"
            DataToTimePickerJumat()
            Label1.Text = "Jumat"
            TimePicker11.Visible = True
            LblJam11.Visible = True
            BtnSelect11.Visible = True
            PictureBox14.Visible = True
            Jumatstatus1()
            Jumatstatus2()
            Jumatstatus3()
            Jumatstatus4()
            Jumatstatus5()
            Jumatstatus6()
            Jumatstatus7()
            Jumatstatus8()
            Jumatstatus9()
            Jumatstatus10()
            Jumatstatus11()
            Jumatstatusistirahat1()
            Jumatstatusistirahat2()
            Jumatstatuskurang5menit2()
            Jumatstatuskurang5menit1()
            Jumatstatuspulang()
            TimePickerPulang.Location = New Point(176, 99)
            LblPulang.Location = New Point(9, 105)
            BntSelectPulang.Location = New Point(267, 97)
            PictureBox25.Location = New Point(137, 96)
            PictureBox13.Location = New Point(137, 96)



        ElseIf DateTimePicker3.Value.DayOfWeek = 6 Then
            DataToTimePickerSabtu()
            Label1.Text = "Sabtu"
            BtnSelect11.Visible = False
            LblJam11.Visible = False
            TimePicker11.Visible = False
            PictureBox26.Visible = False
            PictureBox14.Visible = False
            Sabtustatus1()
            Sabtustatus2()
            Sabtustatus3()
            Sabtustatus4()
            Sabtustatus5()
            Sabtustatus6()
            Sabtustatus7()
            Sabtustatus8()
            Sabtustatus9()
            Sabtustatus10()
            Sabtustatusistirahat1()
            Sabtustatusistirahat2()
            Sabtustatuskurang5menit1()
            Sabtustatuskurang5menit2()
            Sabtustatuspulang()


            TimePickerPulang.Location = New Point(176, 70)
            LblPulang.Location = New Point(9, 75)
            BntSelectPulang.Location = New Point(267, 68)
            PictureBox25.Location = New Point(137, 68)
            PictureBox13.Location = New Point(137, 68)

        End If
    End Sub
    Sub seninstatus1()
        cmd = New OleDbCommand("Select status From Senin Where keterangan = '" & LblJam1.Text & "'", con)
        dr = cmd.ExecuteReader()
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
    Sub seninstatus2()
        cmd = New OleDbCommand("Select status From Senin Where keterangan = '" & LblJam2.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox2.Visible = True
            PictureBox19.Visible = False
            TimePicker2.Enabled = True
            BtnSelect2.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox2.Visible = False
            PictureBox19.Visible = True
            TimePicker2.Enabled = False
            BtnSelect2.Enabled = False
            TimePicker2.Text = "00:00:00"
        End If
    End Sub
    Sub seninstatus3()
        cmd = New OleDbCommand("Select status From Senin Where keterangan = '" & LblJam3.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox3.Visible = True
            PictureBox18.Visible = False
            TimePicker3.Enabled = True
            BtnSelect3.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox3.Visible = False
            PictureBox18.Visible = True
            TimePicker3.Enabled = False
            BtnSelect3.Enabled = False
            TimePicker3.Text = "00:00:00"
        End If
    End Sub
    Sub seninstatusistirahat1()
        cmd = New OleDbCommand("Select status From Senin Where keterangan = '" & Lblistirahat1.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox4.Visible = True
            PictureBox17.Visible = False
            TimePickerIstirahat1.Enabled = True
            BtnSelectIstirahat1.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox4.Visible = False
            PictureBox17.Visible = True
            TimePickerIstirahat1.Enabled = False
            BtnSelectIstirahat1.Enabled = False
            TimePickerIstirahat1.Text = "00:00:00"
        End If
    End Sub
    Sub seninstatuskurang5menit1()
        cmd = New OleDbCommand("Select status From Senin Where keterangan = '" & LblKurang5Menit1.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox8.Visible = True
            PictureBox24.Visible = False
            TimePickerKurang5Menit1.Enabled = True
            Btnkurang5menit1.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox8.Visible = False
            PictureBox24.Visible = True
            TimePickerKurang5Menit1.Enabled = False
            Btnkurang5menit1.Enabled = False
            TimePickerKurang5Menit1.Text = "00:00:00"
        End If
    End Sub
    Sub seninstatus4()
        cmd = New OleDbCommand("Select status From Senin Where keterangan = '" & LblJam4.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox7.Visible = True
            PictureBox23.Visible = False
            TimePicker4.Enabled = True
            BtnSelect4.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox7.Visible = False
            PictureBox23.Visible = True
            TimePicker4.Enabled = False
            BtnSelect4.Enabled = False
            TimePicker4.Text = "00:00:00"
        End If
    End Sub
    Sub seninstatus5()
        cmd = New OleDbCommand("Select status From Senin Where keterangan = '" & LblJam5.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox6.Visible = True
            PictureBox22.Visible = False
            TimePicker5.Enabled = True
            BtnSelect5.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox6.Visible = False
            PictureBox22.Visible = True
            TimePicker5.Enabled = False
            BtnSelect5.Enabled = False
            TimePicker5.Text = "00:00:00"
        End If
    End Sub
    Sub seninstatus6()
        cmd = New OleDbCommand("Select status From Senin Where keterangan = '" & LblJam6.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox5.Visible = True
            PictureBox21.Visible = False
            TimePicker6.Enabled = True
            BtnSelect6.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox5.Visible = False
            PictureBox21.Visible = True
            TimePicker6.Enabled = False
            BtnSelect6.Enabled = False
            TimePicker6.Text = "00:00:00"
        End If
    End Sub
    Sub seninstatusistirahat2()
        cmd = New OleDbCommand("Select status From Senin Where keterangan = '" & Lblistirahat2.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox12.Visible = True
            PictureBox32.Visible = False
            TimePickerIstirahat2.Enabled = True
            BtnSelectIstirahat2.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox12.Visible = False
            PictureBox32.Visible = True
            TimePickerIstirahat2.Enabled = False
            BtnSelectIstirahat2.Enabled = False
            TimePickerIstirahat2.Text = "00:00:00"
        End If
    End Sub
    Sub seninstatuskurang5menit2()
        cmd = New OleDbCommand("Select status From Senin Where keterangan = '" & LblKurang5menit2.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox11.Visible = True
            PictureBox31.Visible = False
            TimePickerKurang5Menit2.Enabled = True
            BtnKurang5Menit2.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox11.Visible = False
            PictureBox31.Visible = True
            TimePickerKurang5Menit2.Enabled = False
            BtnKurang5Menit2.Enabled = False
            TimePickerKurang5Menit2.Text = "00:00:00"
        End If
    End Sub
    Sub seninstatus7()
        cmd = New OleDbCommand("Select status From Senin Where keterangan = '" & LblJam7.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox10.Visible = True
            PictureBox30.Visible = False
            TimePicker7.Enabled = True
            BtnSelect7.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox10.Visible = False
            PictureBox30.Visible = True
            TimePicker7.Enabled = False
            BtnSelect7.Enabled = False
            TimePicker7.Text = "00:00:00"
        End If
    End Sub
    Sub seninstatus8()
        cmd = New OleDbCommand("Select status From Senin Where keterangan = '" & LblJam8.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox9.Visible = True
            PictureBox29.Visible = False
            TimePicker8.Enabled = True
            BtnSelect8.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox9.Visible = False
            PictureBox29.Visible = True
            TimePicker8.Enabled = False
            BtnSelect8.Enabled = False
            TimePicker8.Text = "00:00:00"
        End If
    End Sub
    Sub seninstatus9()
        cmd = New OleDbCommand("Select status From Senin Where keterangan = '" & LblJam9.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox16.Visible = True
            PictureBox28.Visible = False
            TimePicker9.Enabled = True
            BtnSelect9.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox16.Visible = False
            PictureBox28.Visible = True
            TimePicker9.Enabled = False
            BtnSelect9.Enabled = False
            TimePicker9.Text = "00:00:00"
        End If
    End Sub
    Sub seninstatus10()
        cmd = New OleDbCommand("Select status From Senin Where keterangan = '" & LblJam10.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox15.Visible = True
            PictureBox27.Visible = False
            TimePicker10.Enabled = True
            BtnSelect10.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox15.Visible = False
            PictureBox27.Visible = True
            TimePicker10.Enabled = False
            BtnSelect10.Enabled = False
            TimePicker10.Text = "00:00:00"
        End If
    End Sub
    Sub seninstatuspulang()
        cmd = New OleDbCommand("Select status From Senin Where keterangan = '" & LblPulang.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox13.Visible = True
            PictureBox25.Visible = False
            TimePickerPulang.Enabled = True
            BntSelectPulang.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox13.Visible = False
            PictureBox25.Visible = True
            TimePickerPulang.Enabled = False
            BntSelectPulang.Enabled = False
            TimePickerPulang.Text = "00:00:00"
        End If
    End Sub
    Sub selasastatus1()
        cmd = New OleDbCommand("Select status From Selasa Where keterangan = '" & LblJam1.Text & "'", con)
        dr = cmd.ExecuteReader()
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
    Sub Selasastatus2()
        cmd = New OleDbCommand("Select status From Selasa Where keterangan = '" & LblJam2.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox2.Visible = True
            PictureBox19.Visible = False
            TimePicker2.Enabled = True
            BtnSelect2.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox2.Visible = False
            PictureBox19.Visible = True
            TimePicker2.Enabled = False
            BtnSelect2.Enabled = False
            TimePicker2.Text = "00:00:00"
        End If
    End Sub
    Sub Selasastatus3()
        cmd = New OleDbCommand("Select status From Selasa Where keterangan = '" & LblJam3.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox3.Visible = True
            PictureBox18.Visible = False
            TimePicker3.Enabled = True
            BtnSelect3.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox3.Visible = False
            PictureBox18.Visible = True
            TimePicker3.Enabled = False
            BtnSelect3.Enabled = False
            TimePicker3.Text = "00:00:00"
        End If
    End Sub
    Sub Selasastatusistirahat1()
        cmd = New OleDbCommand("Select status From Selasa Where keterangan = '" & Lblistirahat1.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox4.Visible = True
            PictureBox17.Visible = False
            TimePickerIstirahat1.Enabled = True
            BtnSelectIstirahat1.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox4.Visible = False
            PictureBox17.Visible = True
            TimePickerIstirahat1.Enabled = False
            BtnSelectIstirahat1.Enabled = False
            TimePickerIstirahat1.Text = "00:00:00"
        End If
    End Sub
    Sub Selasastatuskurang5menit1()
        cmd = New OleDbCommand("Select status From Selasa Where keterangan = '" & LblKurang5Menit1.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox8.Visible = True
            PictureBox24.Visible = False
            TimePickerKurang5Menit1.Enabled = True
            Btnkurang5menit1.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox8.Visible = False
            PictureBox24.Visible = True
            TimePickerKurang5Menit1.Enabled = False
            Btnkurang5menit1.Enabled = False
            TimePickerKurang5Menit1.Text = "00:00:00"
        End If
    End Sub
    Sub Selasastatus4()
        cmd = New OleDbCommand("Select status From Selasa Where keterangan = '" & LblJam4.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox7.Visible = True
            PictureBox23.Visible = False
            TimePicker4.Enabled = True
            BtnSelect4.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox7.Visible = False
            PictureBox23.Visible = True
            TimePicker4.Enabled = False
            BtnSelect4.Enabled = False
            TimePicker4.Text = "00:00:00"
        End If
    End Sub
    Sub Selasastatus5()
        cmd = New OleDbCommand("Select status From Selasa Where keterangan = '" & LblJam5.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox6.Visible = True
            PictureBox22.Visible = False
            TimePicker5.Enabled = True
            BtnSelect5.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox6.Visible = False
            PictureBox22.Visible = True
            TimePicker5.Enabled = False
            BtnSelect5.Enabled = False
            TimePicker5.Text = "00:00:00"
        End If
    End Sub
    Sub Selasastatus6()
        cmd = New OleDbCommand("Select status From Selasa Where keterangan = '" & LblJam6.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox5.Visible = True
            PictureBox21.Visible = False
            TimePicker6.Enabled = True
            BtnSelect6.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox5.Visible = False
            PictureBox21.Visible = True
            TimePicker6.Enabled = False
            BtnSelect6.Enabled = False
            TimePicker6.Text = "00:00:00"
        End If
    End Sub
    Sub Selasastatusistirahat2()
        cmd = New OleDbCommand("Select status From Selasa Where keterangan = '" & Lblistirahat2.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox12.Visible = True
            PictureBox32.Visible = False
            TimePickerIstirahat2.Enabled = True
            BtnSelectIstirahat2.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox12.Visible = False
            PictureBox32.Visible = True
            TimePickerIstirahat2.Enabled = False
            BtnSelectIstirahat2.Enabled = False
            TimePickerIstirahat2.Text = "00:00:00"
        End If
    End Sub
    Sub Selasastatuskurang5menit2()
        cmd = New OleDbCommand("Select status From Selasa Where keterangan = '" & LblKurang5menit2.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox11.Visible = True
            PictureBox31.Visible = False
            TimePickerKurang5Menit2.Enabled = True
            BtnKurang5Menit2.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox11.Visible = False
            PictureBox31.Visible = True
            TimePickerKurang5Menit2.Enabled = False
            BtnKurang5Menit2.Enabled = False
            TimePickerKurang5Menit2.Text = "00:00:00"
        End If
    End Sub
    Sub Selasastatus7()
        cmd = New OleDbCommand("Select status From Selasa Where keterangan = '" & LblJam7.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox10.Visible = True
            PictureBox30.Visible = False
            TimePicker7.Enabled = True
            BtnSelect7.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox10.Visible = False
            PictureBox30.Visible = True
            TimePicker7.Enabled = False
            BtnSelect7.Enabled = False
            TimePicker7.Text = "00:00:00"
        End If
    End Sub
    Sub Selasastatus8()
        cmd = New OleDbCommand("Select status From Selasa Where keterangan = '" & LblJam8.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox9.Visible = True
            PictureBox29.Visible = False
            TimePicker8.Enabled = True
            BtnSelect8.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox9.Visible = False
            PictureBox29.Visible = True
            TimePicker8.Enabled = False
            BtnSelect8.Enabled = False
            TimePicker8.Text = "00:00:00"
        End If
    End Sub
    Sub Selasastatus9()
        cmd = New OleDbCommand("Select status From Selasa Where keterangan = '" & LblJam9.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox16.Visible = True
            PictureBox28.Visible = False
            TimePicker9.Enabled = True
            BtnSelect9.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox16.Visible = False
            PictureBox28.Visible = True
            TimePicker9.Enabled = False
            BtnSelect9.Enabled = False
            TimePicker9.Text = "00:00:00"
        End If
    End Sub
    Sub Selasastatus10()
        cmd = New OleDbCommand("Select status From Selasa Where keterangan = '" & LblJam10.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox15.Visible = True
            PictureBox27.Visible = False
            TimePicker10.Enabled = True
            BtnSelect10.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox15.Visible = False
            PictureBox27.Visible = True
            TimePicker10.Enabled = False
            BtnSelect10.Enabled = False
            TimePicker10.Text = "00:00:00"
        End If
    End Sub
    Sub Selasastatuspulang()
        cmd = New OleDbCommand("Select status From Selasa Where keterangan = '" & LblPulang.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox13.Visible = True
            PictureBox25.Visible = False
            TimePickerPulang.Enabled = True
            BntSelectPulang.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox13.Visible = False
            PictureBox25.Visible = True
            TimePickerPulang.Enabled = False
            BntSelectPulang.Enabled = False
            TimePickerPulang.Text = "00:00:00"
        End If
    End Sub
    Sub Rabustatus1()
        cmd = New OleDbCommand("Select status From Rabu Where keterangan = '" & LblJam1.Text & "'", con)
        dr = cmd.ExecuteReader()
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
    Sub Rabustatus2()
        cmd = New OleDbCommand("Select status From Rabu Where keterangan = '" & LblJam2.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox2.Visible = True
            PictureBox19.Visible = False
            TimePicker2.Enabled = True
            BtnSelect2.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox2.Visible = False
            PictureBox19.Visible = True
            TimePicker2.Enabled = False
            BtnSelect2.Enabled = False
            TimePicker2.Text = "00:00:00"
        End If
    End Sub
    Sub Rabustatus3()
        cmd = New OleDbCommand("Select status From Rabu Where keterangan = '" & LblJam3.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox3.Visible = True
            PictureBox18.Visible = False
            TimePicker3.Enabled = True
            BtnSelect3.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox3.Visible = False
            PictureBox18.Visible = True
            TimePicker3.Enabled = False
            BtnSelect3.Enabled = False
            TimePicker3.Text = "00:00:00"
        End If
    End Sub
    Sub Rabustatusistirahat1()
        cmd = New OleDbCommand("Select status From Rabu Where keterangan = '" & Lblistirahat1.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox4.Visible = True
            PictureBox17.Visible = False
            TimePickerIstirahat1.Enabled = True
            BtnSelectIstirahat1.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox4.Visible = False
            PictureBox17.Visible = True
            TimePickerIstirahat1.Enabled = False
            BtnSelectIstirahat1.Enabled = False
            TimePickerIstirahat1.Text = "00:00:00"
        End If
    End Sub
    Sub Rabustatuskurang5menit1()
        cmd = New OleDbCommand("Select status From Rabu Where keterangan = '" & LblKurang5Menit1.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox8.Visible = True
            PictureBox24.Visible = False
            TimePickerKurang5Menit1.Enabled = True
            Btnkurang5menit1.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox8.Visible = False
            PictureBox24.Visible = True
            TimePickerKurang5Menit1.Enabled = False
            Btnkurang5menit1.Enabled = False
            TimePickerKurang5Menit1.Text = "00:00:00"
        End If
    End Sub
    Sub Rabustatus4()
        cmd = New OleDbCommand("Select status From Rabu Where keterangan = '" & LblJam4.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox7.Visible = True
            PictureBox23.Visible = False
            TimePicker4.Enabled = True
            BtnSelect4.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox7.Visible = False
            PictureBox23.Visible = True
            TimePicker4.Enabled = False
            BtnSelect4.Enabled = False
            TimePicker4.Text = "00:00:00"
        End If
    End Sub
    Sub Rabustatus5()
        cmd = New OleDbCommand("Select status From Rabu Where keterangan = '" & LblJam5.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox6.Visible = True
            PictureBox22.Visible = False
            TimePicker5.Enabled = True
            BtnSelect5.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox6.Visible = False
            PictureBox22.Visible = True
            TimePicker5.Enabled = False
            BtnSelect5.Enabled = False
            TimePicker5.Text = "00:00:00"
        End If
    End Sub
    Sub Rabustatus6()
        cmd = New OleDbCommand("Select status From Rabu Where keterangan = '" & LblJam6.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox5.Visible = True
            PictureBox21.Visible = False
            TimePicker6.Enabled = True
            BtnSelect6.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox5.Visible = False
            PictureBox21.Visible = True
            TimePicker6.Enabled = False
            BtnSelect6.Enabled = False
            TimePicker6.Text = "00:00:00"
        End If
    End Sub
    Sub Rabustatusistirahat2()
        cmd = New OleDbCommand("Select status From Rabu Where keterangan = '" & Lblistirahat2.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox12.Visible = True
            PictureBox32.Visible = False
            TimePickerIstirahat2.Enabled = True
            BtnSelectIstirahat2.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox12.Visible = False
            PictureBox32.Visible = True
            TimePickerIstirahat2.Enabled = False
            BtnSelectIstirahat2.Enabled = False
            TimePickerIstirahat2.Text = "00:00:00"
        End If
    End Sub
    Sub Rabustatuskurang5menit2()
        cmd = New OleDbCommand("Select status From Rabu Where keterangan = '" & LblKurang5menit2.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox11.Visible = True
            PictureBox31.Visible = False
            TimePickerKurang5Menit2.Enabled = True
            BtnKurang5Menit2.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox11.Visible = False
            PictureBox31.Visible = True
            TimePickerKurang5Menit2.Enabled = False
            BtnKurang5Menit2.Enabled = False
            TimePickerKurang5Menit2.Text = "00:00:00"
        End If
    End Sub
    Sub Rabustatus7()
        cmd = New OleDbCommand("Select status From Rabu Where keterangan = '" & LblJam7.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox10.Visible = True
            PictureBox30.Visible = False
            TimePicker7.Enabled = True
            BtnSelect7.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox10.Visible = False
            PictureBox30.Visible = True
            TimePicker7.Enabled = False
            BtnSelect7.Enabled = False
            TimePicker7.Text = "00:00:00"
        End If
    End Sub
    Sub Rabustatus8()
        cmd = New OleDbCommand("Select status From Rabu Where keterangan = '" & LblJam8.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox9.Visible = True
            PictureBox29.Visible = False
            TimePicker8.Enabled = True
            BtnSelect8.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox9.Visible = False
            PictureBox29.Visible = True
            TimePicker8.Enabled = False
            BtnSelect8.Enabled = False
            TimePicker8.Text = "00:00:00"
        End If
    End Sub
    Sub Rabustatus9()
        cmd = New OleDbCommand("Select status From Rabu Where keterangan = '" & LblJam9.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox16.Visible = True
            PictureBox28.Visible = False
            TimePicker9.Enabled = True
            BtnSelect9.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox16.Visible = False
            PictureBox28.Visible = True
            TimePicker9.Enabled = False
            BtnSelect9.Enabled = False
            TimePicker9.Text = "00:00:00"
        End If
    End Sub
    Sub Rabustatus10()
        cmd = New OleDbCommand("Select status From Rabu Where keterangan = '" & LblJam10.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox15.Visible = True
            PictureBox27.Visible = False
            TimePicker10.Enabled = True
            BtnSelect10.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox15.Visible = False
            PictureBox27.Visible = True
            TimePicker10.Enabled = False
            BtnSelect10.Enabled = False
            TimePicker10.Text = "00:00:00"
        End If
    End Sub
    Sub Rabustatuspulang()
        cmd = New OleDbCommand("Select status From Rabu Where keterangan = '" & LblPulang.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox13.Visible = True
            PictureBox25.Visible = False
            TimePickerPulang.Enabled = True
            BntSelectPulang.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox13.Visible = False
            PictureBox25.Visible = True
            TimePickerPulang.Enabled = False
            BntSelectPulang.Enabled = False
            TimePickerPulang.Text = "00:00:00"
        End If
    End Sub
    Sub Kamisstatus1()
        cmd = New OleDbCommand("Select status From Kamis Where keterangan = '" & LblJam1.Text & "'", con)
        dr = cmd.ExecuteReader()
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
    Sub Kamisstatus2()
        cmd = New OleDbCommand("Select status From Kamis Where keterangan = '" & LblJam2.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox2.Visible = True
            PictureBox19.Visible = False
            TimePicker2.Enabled = True
            BtnSelect2.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox2.Visible = False
            PictureBox19.Visible = True
            TimePicker2.Enabled = False
            BtnSelect2.Enabled = False
            TimePicker2.Text = "00:00:00"
        End If
    End Sub
    Sub Kamisstatus3()
        cmd = New OleDbCommand("Select status From Kamis Where keterangan = '" & LblJam3.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox3.Visible = True
            PictureBox18.Visible = False
            TimePicker3.Enabled = True
            BtnSelect3.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox3.Visible = False
            PictureBox18.Visible = True
            TimePicker3.Enabled = False
            BtnSelect3.Enabled = False
            TimePicker3.Text = "00:00:00"
        End If
    End Sub
    Sub Kamisstatusistirahat1()
        cmd = New OleDbCommand("Select status From Kamis Where keterangan = '" & Lblistirahat1.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox4.Visible = True
            PictureBox17.Visible = False
            TimePickerIstirahat1.Enabled = True
            BtnSelectIstirahat1.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox4.Visible = False
            PictureBox17.Visible = True
            TimePickerIstirahat1.Enabled = False
            BtnSelectIstirahat1.Enabled = False
            TimePickerIstirahat1.Text = "00:00:00"
        End If
    End Sub
    Sub Kamisstatuskurang5menit1()
        cmd = New OleDbCommand("Select status From Kamis Where keterangan = '" & LblKurang5Menit1.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox8.Visible = True
            PictureBox24.Visible = False
            TimePickerKurang5Menit1.Enabled = True
            Btnkurang5menit1.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox8.Visible = False
            PictureBox24.Visible = True
            TimePickerKurang5Menit1.Enabled = False
            Btnkurang5menit1.Enabled = False
            TimePickerKurang5Menit1.Text = "00:00:00"
        End If
    End Sub
    Sub Kamisstatus4()
        cmd = New OleDbCommand("Select status From Kamis Where keterangan = '" & LblJam4.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox7.Visible = True
            PictureBox23.Visible = False
            TimePicker4.Enabled = True
            BtnSelect4.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox7.Visible = False
            PictureBox23.Visible = True
            TimePicker4.Enabled = False
            BtnSelect4.Enabled = False
            TimePicker4.Text = "00:00:00"
        End If
    End Sub
    Sub Kamisstatus5()
        cmd = New OleDbCommand("Select status From Kamis Where keterangan = '" & LblJam5.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox6.Visible = True
            PictureBox22.Visible = False
            TimePicker5.Enabled = True
            BtnSelect5.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox6.Visible = False
            PictureBox22.Visible = True
            TimePicker5.Enabled = False
            BtnSelect5.Enabled = False
            TimePicker5.Text = "00:00:00"
        End If
    End Sub
    Sub Kamisstatus6()
        cmd = New OleDbCommand("Select status From Kamis Where keterangan = '" & LblJam6.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox5.Visible = True
            PictureBox21.Visible = False
            TimePicker6.Enabled = True
            BtnSelect6.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox5.Visible = False
            PictureBox21.Visible = True
            TimePicker6.Enabled = False
            BtnSelect6.Enabled = False
            TimePicker6.Text = "00:00:00"
        End If
    End Sub
    Sub Kamisstatusistirahat2()
        cmd = New OleDbCommand("Select status From Kamis Where keterangan = '" & Lblistirahat2.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox12.Visible = True
            PictureBox32.Visible = False
            TimePickerIstirahat2.Enabled = True
            BtnSelectIstirahat2.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox12.Visible = False
            PictureBox32.Visible = True
            TimePickerIstirahat2.Enabled = False
            BtnSelectIstirahat2.Enabled = False
            TimePickerIstirahat2.Text = "00:00:00"
        End If
    End Sub
    Sub Kamisstatuskurang5menit2()
        cmd = New OleDbCommand("Select status From Kamis Where keterangan = '" & LblKurang5menit2.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox11.Visible = True
            PictureBox31.Visible = False
            TimePickerKurang5Menit2.Enabled = True
            BtnKurang5Menit2.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox11.Visible = False
            PictureBox31.Visible = True
            TimePickerKurang5Menit2.Enabled = False
            BtnKurang5Menit2.Enabled = False
            TimePickerKurang5Menit2.Text = "00:00:00"
        End If
    End Sub
    Sub Kamisstatus7()
        cmd = New OleDbCommand("Select status From Kamis Where keterangan = '" & LblJam7.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox10.Visible = True
            PictureBox30.Visible = False
            TimePicker7.Enabled = True
            BtnSelect7.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox10.Visible = False
            PictureBox30.Visible = True
            TimePicker7.Enabled = False
            BtnSelect7.Enabled = False
            TimePicker7.Text = "00:00:00"
        End If
    End Sub
    Sub Kamisstatus8()
        cmd = New OleDbCommand("Select status From Kamis Where keterangan = '" & LblJam8.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox9.Visible = True
            PictureBox29.Visible = False
            TimePicker8.Enabled = True
            BtnSelect8.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox9.Visible = False
            PictureBox29.Visible = True
            TimePicker8.Enabled = False
            BtnSelect8.Enabled = False
            TimePicker8.Text = "00:00:00"
        End If
    End Sub
    Sub Kamisstatus9()
        cmd = New OleDbCommand("Select status From Kamis Where keterangan = '" & LblJam9.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox16.Visible = True
            PictureBox28.Visible = False
            TimePicker9.Enabled = True
            BtnSelect9.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox16.Visible = False
            PictureBox28.Visible = True
            TimePicker9.Enabled = False
            BtnSelect9.Enabled = False
            TimePicker9.Text = "00:00:00"
        End If
    End Sub
    Sub Kamisstatus10()
        cmd = New OleDbCommand("Select status From Kamis Where keterangan = '" & LblJam10.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox15.Visible = True
            PictureBox27.Visible = False
            TimePicker10.Enabled = True
            BtnSelect10.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox15.Visible = False
            PictureBox27.Visible = True
            TimePicker10.Enabled = False
            BtnSelect10.Enabled = False
            TimePicker10.Text = "00:00:00"
        End If
    End Sub
    Sub Kamisstatuspulang()
        cmd = New OleDbCommand("Select status From Kamis Where keterangan = '" & LblPulang.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox13.Visible = True
            PictureBox25.Visible = False
            TimePickerPulang.Enabled = True
            BntSelectPulang.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox13.Visible = False
            PictureBox25.Visible = True
            TimePickerPulang.Enabled = False
            BntSelectPulang.Enabled = False
            TimePickerPulang.Text = "00:00:00"
        End If
    End Sub


    Sub Jumatstatus1()
        cmd = New OleDbCommand("Select status From Jumat Where keterangan = '" & LblJam1.Text & "'", con)
        dr = cmd.ExecuteReader()
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
    Sub Jumatstatus2()
        cmd = New OleDbCommand("Select status From Jumat Where keterangan = '" & LblJam2.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox2.Visible = True
            PictureBox19.Visible = False
            TimePicker2.Enabled = True
            BtnSelect2.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox2.Visible = False
            PictureBox19.Visible = True
            TimePicker2.Enabled = False
            BtnSelect2.Enabled = False
            TimePicker2.Text = "00:00:00"
        End If
    End Sub
    Sub Jumatstatus3()
        cmd = New OleDbCommand("Select status From Jumat Where keterangan = '" & LblJam3.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox3.Visible = True
            PictureBox18.Visible = False
            TimePicker3.Enabled = True
            BtnSelect3.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox3.Visible = False
            PictureBox18.Visible = True
            TimePicker3.Enabled = False
            BtnSelect3.Enabled = False
            TimePicker3.Text = "00:00:00"
        End If
    End Sub
    Sub Jumatstatusistirahat1()
        cmd = New OleDbCommand("Select status From Jumat Where keterangan = '" & Lblistirahat1.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox4.Visible = True
            PictureBox17.Visible = False
            TimePickerIstirahat1.Enabled = True
            BtnSelectIstirahat1.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox4.Visible = False
            PictureBox17.Visible = True
            TimePickerIstirahat1.Enabled = False
            BtnSelectIstirahat1.Enabled = False
            TimePickerIstirahat1.Text = "00:00:00"
        End If
    End Sub
    Sub Jumatstatuskurang5menit1()
        cmd = New OleDbCommand("Select status From Jumat Where keterangan = '" & LblKurang5Menit1.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox8.Visible = True
            PictureBox24.Visible = False
            TimePickerKurang5Menit1.Enabled = True
            Btnkurang5menit1.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox8.Visible = False
            PictureBox24.Visible = True
            TimePickerKurang5Menit1.Enabled = False
            Btnkurang5menit1.Enabled = False
            TimePickerKurang5Menit1.Text = "00:00:00"
        End If
    End Sub
    Sub Jumatstatus4()
        cmd = New OleDbCommand("Select status From Jumat Where keterangan = '" & LblJam4.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox7.Visible = True
            PictureBox23.Visible = False
            TimePicker4.Enabled = True
            BtnSelect4.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox7.Visible = False
            PictureBox23.Visible = True
            TimePicker4.Enabled = False
            BtnSelect4.Enabled = False
            TimePicker4.Text = "00:00:00"
        End If
    End Sub
    Sub Jumatstatus5()
        cmd = New OleDbCommand("Select status From Jumat Where keterangan = '" & LblJam5.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox6.Visible = True
            PictureBox22.Visible = False
            TimePicker5.Enabled = True
            BtnSelect5.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox6.Visible = False
            PictureBox22.Visible = True
            TimePicker5.Enabled = False
            BtnSelect5.Enabled = False
            TimePicker5.Text = "00:00:00"
        End If
    End Sub
    Sub Jumatstatus6()
        cmd = New OleDbCommand("Select status From Jumat Where keterangan = '" & LblJam6.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox5.Visible = True
            PictureBox21.Visible = False
            TimePicker6.Enabled = True
            BtnSelect6.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox5.Visible = False
            PictureBox21.Visible = True
            TimePicker6.Enabled = False
            BtnSelect6.Enabled = False
            TimePicker6.Text = "00:00:00"
        End If
    End Sub
    Sub Jumatstatusistirahat2()
        cmd = New OleDbCommand("Select status From Jumat Where keterangan = '" & LblKurang5menit2.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox12.Visible = True
            PictureBox32.Visible = False
            TimePickerIstirahat2.Enabled = True
            BtnSelectIstirahat2.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox12.Visible = False
            PictureBox32.Visible = True
            TimePickerIstirahat2.Enabled = False
            BtnSelectIstirahat2.Enabled = False
            TimePickerIstirahat2.Text = "00:00:00"
        End If
    End Sub
    Sub Jumatstatuskurang5menit2()
        cmd = New OleDbCommand("Select status From Jumat Where keterangan = '" & LblJam7.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox11.Visible = True
            PictureBox31.Visible = False
            TimePickerKurang5Menit2.Enabled = True
            BtnKurang5Menit2.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox11.Visible = False
            PictureBox31.Visible = True
            TimePickerKurang5Menit2.Enabled = False
            BtnKurang5Menit2.Enabled = False
            TimePickerKurang5Menit2.Text = "00:00:00"
        End If
    End Sub
    Sub Jumatstatus7()
        cmd = New OleDbCommand("Select status From Jumat Where keterangan = '" & Lblistirahat2.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox10.Visible = True
            PictureBox30.Visible = False
            TimePicker7.Enabled = True
            BtnSelect7.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox10.Visible = False
            PictureBox30.Visible = True
            TimePicker7.Enabled = False
            BtnSelect7.Enabled = False
            TimePicker7.Text = "00:00:00"
        End If
    End Sub
    Sub Jumatstatus8()
        cmd = New OleDbCommand("Select status From Jumat Where keterangan = '" & LblJam8.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox9.Visible = True
            PictureBox29.Visible = False
            TimePicker8.Enabled = True
            BtnSelect8.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox9.Visible = False
            PictureBox29.Visible = True
            TimePicker8.Enabled = False
            BtnSelect8.Enabled = False
            TimePicker8.Text = "00:00:00"
        End If
    End Sub
    Sub Jumatstatus9()
        cmd = New OleDbCommand("Select status From Jumat Where keterangan = '" & LblJam9.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox16.Visible = True
            PictureBox28.Visible = False
            TimePicker9.Enabled = True
            BtnSelect9.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox16.Visible = False
            PictureBox28.Visible = True
            TimePicker9.Enabled = False
            BtnSelect9.Enabled = False
            TimePicker9.Text = "00:00:00"
        End If
    End Sub
    Sub Jumatstatus10()
        cmd = New OleDbCommand("Select status From Jumat Where keterangan = '" & LblJam10.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox15.Visible = True
            PictureBox27.Visible = False
            TimePicker10.Enabled = True
            BtnSelect10.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox15.Visible = False
            PictureBox27.Visible = True
            TimePicker10.Enabled = False
            BtnSelect10.Enabled = False
            TimePicker10.Text = "00:00:00"
        End If
    End Sub
    Sub Jumatstatus11()
        cmd = New OleDbCommand("Select status From Jumat Where keterangan = '" & LblJam11.text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")

        If status = "aktif" Then
            PictureBox14.Visible = True
            PictureBox26.Visible = False
            TimePicker11.Enabled = True
            BtnSelect11.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox14.Visible = False
            PictureBox26.Visible = True
            TimePicker11.Enabled = False
            BtnSelect11.Enabled = False
            TimePicker11.Text = "00:00:00"
        End If
    End Sub
    Sub Jumatstatuspulang()
        cmd = New OleDbCommand("Select status From Jumat Where keterangan = '" & LblPulang.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox13.Visible = True
            PictureBox25.Visible = False
            TimePickerPulang.Enabled = True
            BntSelectPulang.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox13.Visible = False
            PictureBox25.Visible = True
            TimePickerPulang.Enabled = False
            BntSelectPulang.Enabled = False
            TimePickerPulang.Text = "00:00:00"
        End If
    End Sub
    Sub Sabtustatus1()
        cmd = New OleDbCommand("Select status From Sabtu Where keterangan = '" & LblJam1.Text & "'", con)
        dr = cmd.ExecuteReader()
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
    Sub Sabtustatus2()
        cmd = New OleDbCommand("Select status From Sabtu Where keterangan = '" & LblJam2.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox2.Visible = True
            PictureBox19.Visible = False
            TimePicker2.Enabled = True
            BtnSelect2.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox2.Visible = False
            PictureBox19.Visible = True
            TimePicker2.Enabled = False
            BtnSelect2.Enabled = False
            TimePicker2.Text = "00:00:00"
        End If
    End Sub
    Sub Sabtustatus3()
        cmd = New OleDbCommand("Select status From Sabtu Where keterangan = '" & LblJam3.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox3.Visible = True
            PictureBox18.Visible = False
            TimePicker3.Enabled = True
            BtnSelect3.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox3.Visible = False
            PictureBox18.Visible = True
            TimePicker3.Enabled = False
            BtnSelect3.Enabled = False
            TimePicker3.Text = "00:00:00"
        End If
    End Sub
    Sub Sabtustatusistirahat1()
        cmd = New OleDbCommand("Select status From Sabtu Where keterangan = '" & Lblistirahat1.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox4.Visible = True
            PictureBox17.Visible = False
            TimePickerIstirahat1.Enabled = True
            BtnSelectIstirahat1.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox4.Visible = False
            PictureBox17.Visible = True
            TimePickerIstirahat1.Enabled = False
            BtnSelectIstirahat1.Enabled = False
            TimePickerIstirahat1.Text = "00:00:00"
        End If
    End Sub
    Sub Sabtustatuskurang5menit1()
        cmd = New OleDbCommand("Select status From Sabtu Where keterangan = '" & LblKurang5Menit1.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox8.Visible = True
            PictureBox24.Visible = False
            TimePickerKurang5Menit1.Enabled = True
            Btnkurang5menit1.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox8.Visible = False
            PictureBox24.Visible = True
            TimePickerKurang5Menit1.Enabled = False
            Btnkurang5menit1.Enabled = False
            TimePickerKurang5Menit1.Text = "00:00:00"
        End If
    End Sub
    Sub Sabtustatus4()
        cmd = New OleDbCommand("Select status From Sabtu Where keterangan = '" & LblJam4.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox7.Visible = True
            PictureBox23.Visible = False
            TimePicker4.Enabled = True
            BtnSelect4.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox7.Visible = False
            PictureBox23.Visible = True
            TimePicker4.Enabled = False
            BtnSelect4.Enabled = False
            TimePicker4.Text = "00:00:00"
        End If
    End Sub
    Sub Sabtustatus5()
        cmd = New OleDbCommand("Select status From Sabtu Where keterangan = '" & LblJam5.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox6.Visible = True
            PictureBox22.Visible = False
            TimePicker5.Enabled = True
            BtnSelect5.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox6.Visible = False
            PictureBox22.Visible = True
            TimePicker5.Enabled = False
            BtnSelect5.Enabled = False
            TimePicker5.Text = "00:00:00"
        End If
    End Sub
    Sub Sabtustatus6()
        cmd = New OleDbCommand("Select status From Sabtu Where keterangan = '" & LblJam6.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox5.Visible = True
            PictureBox21.Visible = False
            TimePicker6.Enabled = True
            BtnSelect6.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox5.Visible = False
            PictureBox21.Visible = True
            TimePicker6.Enabled = False
            BtnSelect6.Enabled = False
            TimePicker6.Text = "00:00:00"
        End If
    End Sub
    Sub Sabtustatusistirahat2()
        cmd = New OleDbCommand("Select status From Sabtu Where keterangan = '" & Lblistirahat2.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox12.Visible = True
            PictureBox32.Visible = False
            TimePickerIstirahat2.Enabled = True
            BtnSelectIstirahat2.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox12.Visible = False
            PictureBox32.Visible = True
            TimePickerIstirahat2.Enabled = False
            BtnSelectIstirahat2.Enabled = False
            TimePickerIstirahat2.Text = "00:00:00"
        End If
    End Sub
    Sub Sabtustatuskurang5menit2()
        cmd = New OleDbCommand("Select status From Sabtu Where keterangan = '" & LblKurang5menit2.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox11.Visible = True
            PictureBox31.Visible = False
            TimePickerKurang5Menit2.Enabled = True
            BtnKurang5Menit2.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox11.Visible = False
            PictureBox31.Visible = True
            TimePickerKurang5Menit2.Enabled = False
            BtnKurang5Menit2.Enabled = False
            TimePickerKurang5Menit2.Text = "00:00:00"
        End If
    End Sub
    Sub Sabtustatus7()
        cmd = New OleDbCommand("Select status From Sabtu Where keterangan = '" & LblJam7.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox10.Visible = True
            PictureBox30.Visible = False
            TimePicker7.Enabled = True
            BtnSelect7.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox10.Visible = False
            PictureBox30.Visible = True
            TimePicker7.Enabled = False
            BtnSelect7.Enabled = False
            TimePicker7.Text = "00:00:00"
        End If
    End Sub
    Sub Sabtustatus8()
        cmd = New OleDbCommand("Select status From Sabtu Where keterangan = '" & LblJam8.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox9.Visible = True
            PictureBox29.Visible = False
            TimePicker8.Enabled = True
            BtnSelect8.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox9.Visible = False
            PictureBox29.Visible = True
            TimePicker8.Enabled = False
            BtnSelect8.Enabled = False
            TimePicker8.Text = "00:00:00"
        End If
    End Sub
    Sub Sabtustatus9()
        cmd = New OleDbCommand("Select status From Sabtu Where keterangan = '" & LblJam9.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox16.Visible = True
            PictureBox28.Visible = False
            TimePicker9.Enabled = True
            BtnSelect9.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox16.Visible = False
            PictureBox28.Visible = True
            TimePicker9.Enabled = False
            BtnSelect9.Enabled = False
            TimePicker9.Text = "00:00:00"
        End If
    End Sub
    Sub Sabtustatus10()
        cmd = New OleDbCommand("Select status From Sabtu Where keterangan = '" & LblJam10.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox15.Visible = True
            PictureBox27.Visible = False
            TimePicker10.Enabled = True
            BtnSelect10.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox15.Visible = False
            PictureBox27.Visible = True
            TimePicker10.Enabled = False
            BtnSelect10.Enabled = False
            TimePicker10.Text = "00:00:00"
        End If
    End Sub

    Sub Sabtustatuspulang()
        cmd = New OleDbCommand("Select status From Sabtu Where keterangan = '" & LblPulang.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim status As String = dr.Item("status")
        If status = "aktif" Then
            PictureBox13.Visible = True
            PictureBox25.Visible = False
            TimePickerPulang.Enabled = True
            BntSelectPulang.Enabled = True

        ElseIf status = "nonaktif" Then
            PictureBox13.Visible = False
            PictureBox25.Visible = True
            TimePickerPulang.Enabled = False
            BntSelectPulang.Enabled = False
            TimePickerPulang.Text = "00:00:00"
        End If
    End Sub


    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pathpulangcepat = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pathceksound = OpenFileDialog1.FileName
        End If
    End Sub

   

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Not pathceksound = "" Then
            MenuAwal.WMP.URL = pathceksound
        Else
            MenuAwal.WMP.URL = GetDatasenin("CEK SOUND", 2)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Not pathpulang = "" Then
            MenuAwal.WMP.URL = pathpulang
        Else
            MenuAwal.WMP.URL = GetDatasenin("Pulang Cepat", 2)
        End If
    End Sub
End Class