Public Class MenuAwal

    Private Const CS_DROPSHADOW As Integer = 131072

    Protected Overrides ReadOnly Property CreateParams As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Dim terbuka As Boolean


    Private Sub BtnHariBiasa_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHariBiasa.Click
        Panel2.Height = BtnHariBiasa.Height
        Panel2.Top = BtnHariBiasa.Top
        BtnUjian.BackColor = Color.Turquoise
        btncarapemakaian.BackColor = Color.Turquoise
        BtnHariBiasa.BackColor = Color.Cyan
        HariBiasa.TopLevel = False
        Panel3.Controls.Add(HariBiasa)
        HariBiasa.Show()
        Ujian.Close()
        carapemakaian.Close()
        Label1.Text = "Bel Sapra2 - Hari Biasa"
        Me.Text = "Bel Sapra2 - Hari Biasa"
        Timer2.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUjian.Click
        Panel2.Height = BtnUjian.Height
        Panel2.Top = BtnUjian.Top
        BtnUjian.BackColor = Color.Cyan
        btncarapemakaian.BackColor = Color.Turquoise
        BtnHariBiasa.BackColor = Color.Turquoise
        Ujian.TopLevel = False
        Panel3.Controls.Add(Ujian)
        Ujian.Show()
        HariBiasa.Close()
        carapemakaian.Close()
        Label1.Text = "Bel Sapra2 - Ujian"
        Me.Text = "Bel Sapra2 - Ujian"
        Timer2.Enabled = True
    End Sub


    Dim Drag As Boolean
    Dim MouseX As Integer
    Dim MouseY As Integer
    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel5.MouseDown
        Drag = True
        MouseX = Windows.Forms.Cursor.Position.X - Me.Left
        MouseY = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel5.MouseMove
        If Drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - MouseX
            Me.Top = Windows.Forms.Cursor.Position.Y - MouseY
        End If
    End Sub

    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel5.MouseUp
        Drag = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncarapemakaian.Click
        carapemakaian.TopLevel = False
        Panel3.Controls.Add(carapemakaian)
        Ujian.Close()
        HariBiasa.Close()
        carapemakaian.Show()
        Panel2.Height = btncarapemakaian.Height
        Panel2.Top = btncarapemakaian.Top
        BtnUjian.BackColor = Color.Turquoise
        btncarapemakaian.BackColor = Color.Cyan
        BtnHariBiasa.BackColor = Color.Turquoise
        Label1.Text = "Bel Sapra2 - Cara Penggunaan"
        Me.Text = "Bel Sapra2 - Cara Penggunaan"
        Timer2.Enabled = True
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub MenuAwal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel2.Height = BtnHariBiasa.Height
        Panel2.Top = BtnHariBiasa.Top
        HariBiasa.TopLevel = False
        Panel3.Controls.Add(HariBiasa)
        HariBiasa.Show()
        Label1.Text = "Bel Sapra2 - Hari Biasa"
        Me.Text = "Bel Sapra2 - Hari Biasa"
        Panel1.Width = 52
        BtnUjian.BackColor = Color.Turquoise
        btncarapemakaian.BackColor = Color.Turquoise
        BtnHariBiasa.BackColor = Color.Cyan
        terbuka = False


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If terbuka Then
            Panel1.Width -= 10
            If Panel1.Width <= 52 Then
                Timer1.Enabled = False
                terbuka = False
            End If
        ElseIf Not terbuka Then
            Panel1.Width += 10
            If Panel1.Width >= 227 Then
                Timer1.Enabled = False
                terbuka = True
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If terbuka Then
            Panel1.Width -= 10
            If Panel1.Width <= 52 Then
                Timer2.Enabled = False
                terbuka = False
            End If
        ElseIf Not terbuka Then
            Timer2.Enabled = False
        End If
    End Sub
End Class