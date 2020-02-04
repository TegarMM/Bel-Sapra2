<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAwal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuAwal))
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btncarapemakaian = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.WMP = New AxWMPLib.AxWindowsMediaPlayer()
        Me.BtnUjian = New System.Windows.Forms.Button()
        Me.BtnHariBiasa = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WMP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.PictureBox2)
        Me.Panel5.Controls.Add(Me.Button4)
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(856, 42)
        Me.Panel5.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(44, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Bel Sapra2"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Bel_Sekolah.My.Resources.Resources.Bell_icon_icons_com_75182
        Me.PictureBox2.Location = New System.Drawing.Point(7, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = Global.Bel_Sekolah.My.Resources.Resources.minim
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button4.Location = New System.Drawing.Point(761, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(45, 40)
        Me.Button4.TabIndex = 1
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = Global.Bel_Sekolah.My.Resources.Resources.closewin
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button2.Location = New System.Drawing.Point(811, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 40)
        Me.Button2.TabIndex = 1
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Snow
        Me.Panel3.Location = New System.Drawing.Point(51, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 420)
        Me.Panel3.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Turquoise
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btncarapemakaian)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.WMP)
        Me.Panel1.Controls.Add(Me.BtnUjian)
        Me.Panel1.Controls.Add(Me.BtnHariBiasa)
        Me.Panel1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(4, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(227, 422)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel2.Location = New System.Drawing.Point(0, 238)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(8, 43)
        Me.Panel2.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.Bel_Sekolah.My.Resources.Resources.list_symbol_of_three_items_with_dots_icon_icons_com_72994
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(233, 40)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "    Menu"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button1, "Expand")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btncarapemakaian
        '
        Me.btncarapemakaian.FlatAppearance.BorderSize = 0
        Me.btncarapemakaian.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.btncarapemakaian.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.btncarapemakaian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncarapemakaian.ForeColor = System.Drawing.Color.Black
        Me.btncarapemakaian.Image = Global.Bel_Sekolah.My.Resources.Resources._20191009_103605
        Me.btncarapemakaian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncarapemakaian.Location = New System.Drawing.Point(8, 319)
        Me.btncarapemakaian.Name = "btncarapemakaian"
        Me.btncarapemakaian.Size = New System.Drawing.Size(226, 40)
        Me.btncarapemakaian.TabIndex = 4
        Me.btncarapemakaian.Text = "    Cara Penggunaan"
        Me.btncarapemakaian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btncarapemakaian, "Cara Penggunan")
        Me.btncarapemakaian.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Bel_Sekolah.My.Resources.Resources._1570283530276
        Me.PictureBox1.Location = New System.Drawing.Point(53, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'WMP
        '
        Me.WMP.Enabled = True
        Me.WMP.Location = New System.Drawing.Point(80, 74)
        Me.WMP.Name = "WMP"
        Me.WMP.OcxState = CType(resources.GetObject("WMP.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WMP.Size = New System.Drawing.Size(10, 10)
        Me.WMP.TabIndex = 1
        '
        'BtnUjian
        '
        Me.BtnUjian.FlatAppearance.BorderSize = 0
        Me.BtnUjian.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.BtnUjian.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.BtnUjian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUjian.ForeColor = System.Drawing.Color.Black
        Me.BtnUjian.Image = Global.Bel_Sekolah.My.Resources.Resources._20191009_103433
        Me.BtnUjian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUjian.Location = New System.Drawing.Point(8, 275)
        Me.BtnUjian.Name = "BtnUjian"
        Me.BtnUjian.Size = New System.Drawing.Size(226, 40)
        Me.BtnUjian.TabIndex = 0
        Me.BtnUjian.Text = "    Ujian"
        Me.BtnUjian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BtnUjian, "Ujian")
        Me.BtnUjian.UseVisualStyleBackColor = True
        '
        'BtnHariBiasa
        '
        Me.BtnHariBiasa.FlatAppearance.BorderSize = 0
        Me.BtnHariBiasa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.BtnHariBiasa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.BtnHariBiasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHariBiasa.ForeColor = System.Drawing.Color.Black
        Me.BtnHariBiasa.Image = Global.Bel_Sekolah.My.Resources.Resources._20191009_103344
        Me.BtnHariBiasa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHariBiasa.Location = New System.Drawing.Point(8, 229)
        Me.BtnHariBiasa.Name = "BtnHariBiasa"
        Me.BtnHariBiasa.Size = New System.Drawing.Size(226, 40)
        Me.BtnHariBiasa.TabIndex = 0
        Me.BtnHariBiasa.Text = "    Hari Biasa"
        Me.BtnHariBiasa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BtnHariBiasa, "Hari Biasa")
        Me.BtnHariBiasa.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'MenuAwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(856, 475)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuAwal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuAwal"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WMP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents WMP As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents BtnUjian As System.Windows.Forms.Button
    Friend WithEvents BtnHariBiasa As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btncarapemakaian As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
