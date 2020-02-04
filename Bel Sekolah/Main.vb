Public Class Main

    Dim IsSetSong As Boolean
    Dim Path As String

    Private Sub SetDGV()
        DGV.DataSource = GetTable("normal")
        DGV.ReadOnly = True
        DGV.Columns(1).DefaultCellStyle.Format = "HH:mm:ss tt"
    End Sub

    Private Sub TimerTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTime.Tick
        LblTime.Text = TimeOfDay
    End Sub

    Private Sub TimerValidate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerValidate.Tick
        If IsSetSong Then
            If TimePicker.Text = TimeOfDay Then
                WMP.URL = path
            End If
        Else
            MsgBox("Alarm Muni")
        End If
    End Sub

    Private Sub TimePicker_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TimePicker.TextChanged
        TimerValidate.Enabled = True
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TimerTime.Enabled = True
    End Sub

    Private Sub BtnSelectSong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectSong.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            path = OpenFileDialog1.FileName
            IsSetSong = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SetDGV()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Ujian.Show()
    End Sub
End Class
