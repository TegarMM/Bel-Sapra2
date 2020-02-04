Public Class carapemakaian

    Private Sub carapemakaian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        pindah()


    End Sub
    Public psbv As Integer = 0

   

    Private Sub VScrollBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles VScrollBar1.ValueChanged
        Dim increment As Integer
        If VScrollBar1.Value > psbv Then
            increment = VScrollBar1.Value - psbv
            psbv = VScrollBar1.Value
            
            Panel2.Location = New Point(Panel2.Location.X, Panel2.Location.Y - increment)

        ElseIf VScrollBar1.Value < psbv Then
            increment = psbv - VScrollBar1.Value
            psbv = VScrollBar1.Value
            Panel2.Location = New Point(Panel2.Location.X, Panel2.Location.Y + increment)
           
        End If
    End Sub
    Sub pindah()
        Label4.Location = New Point(33, 1357)
        PictureBox4.Location = New Point(237, 1412)
        Label5.Location = New Point(33, 1880)

        Label9.Location = New Point(50, 1980)
        Label10.Location = New Point(33, 2050)
        Label11.Location = New Point(55, 2075)
        PictureBox6.Location = New Point(333, 2135)
        Label12.Location = New Point(55, 2200)
        PictureBox7.Location = New Point(333, 2252)
        Label13.Location = New Point(33, 2310)
        Label14.Location = New Point(33, 2545)
        Label15.Location = New Point(33, 2745)
        PictureBox8.Location = New Point(290, 2450)
        PictureBox9.Location = New Point(290, 2645)
        PictureBox10.Location = New Point(300, 2845)
        Label16.Location = New Point(33, 2935)
        Label17.Location = New Point(50, 3045)
        PictureBox11.Location = New Point(237, 3275)
        Label18.Location = New Point(55, 3135)
        Label19.Location = New Point(33, 3235)
        Label20.Location = New Point(33, 3500)
        PictureBox12.Location = New Point(237, 3550)
        Label21.Location = New Point(33, 4035)
        PictureBox13.Location = New Point(237, 4075)
        Label22.Location = New Point(33, 4535)
        PictureBox14.Location = New Point(237, 4710)
        Label23.Location = New Point(55, 4575)
        Label24.Location = New Point(33, 4650)
        Label25.Location = New Point(210, 5175)
        Label26.Location = New Point(222, 5250)
    End Sub

    

   

  
End Class