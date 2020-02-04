Imports System.Data.OleDb
Public Class editdata
    Private Sub TimerTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTime.Tick
        LblTime.Text = TimeOfDay
    End Sub

    Private Sub SetDGV()
        DGV.DataSource = GetTableCustom("SELECT keterangan,time FROM Senin")
        DGV.ReadOnly = True
        DGV.Columns(1).DefaultCellStyle.Format = "HH:mm:ss tt"
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetDGV()
        BtnSelect1.Enabled = False
    End Sub

    Private Function GetData(ByVal keterangan As String, ByVal cells As Integer)
        ConOpen()
        cmd = New OleDbCommand("Select * from Senin where keterangan='" & keterangan & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Return dr.Item(cells)
        Else
            Return 0
        End If
        ConClose()
    End Function

    Private Sub save()
        ConOpen()
        cmd = New OleDbCommand("update Senin set [time]='" & TimePicker1.Text & "' where keterangan='" & LblKet.Text & "'", con)
        cmd.ExecuteNonQuery()
        ConClose()
    End Sub

    Private Sub DGV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.Click
        LblKet.Text = DGV.Rows(DGV.CurrentRow.Index).Cells(0).Value.ToString
        TimePicker1.Value = GetData(LblKet.Text, 0)
        BtnSelect1.Enabled = True
    End Sub

    Private Sub BtnSelect1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect1.Click
        save()
        SetDGV()
    End Sub
End Class