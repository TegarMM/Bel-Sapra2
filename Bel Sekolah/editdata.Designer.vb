<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editdata
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
        Me.BtnSelect1 = New System.Windows.Forms.Button()
        Me.LblSetSong = New System.Windows.Forms.Label()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.TimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LblKet = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.TimerTime = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSelect1
        '
        Me.BtnSelect1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSelect1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelect1.Location = New System.Drawing.Point(414, 313)
        Me.BtnSelect1.Name = "BtnSelect1"
        Me.BtnSelect1.Size = New System.Drawing.Size(101, 25)
        Me.BtnSelect1.TabIndex = 19
        Me.BtnSelect1.Text = "Save"
        Me.BtnSelect1.UseVisualStyleBackColor = True
        '
        'LblSetSong
        '
        Me.LblSetSong.AutoSize = True
        Me.LblSetSong.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSetSong.Location = New System.Drawing.Point(183, 318)
        Me.LblSetSong.Name = "LblSetSong"
        Me.LblSetSong.Size = New System.Drawing.Size(104, 16)
        Me.LblSetSong.TabIndex = 18
        Me.LblSetSong.Text = "Jam Pertama"
        '
        'LblTime
        '
        Me.LblTime.Font = New System.Drawing.Font("Bauhaus 93", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTime.ForeColor = System.Drawing.Color.Red
        Me.LblTime.Location = New System.Drawing.Point(81, 70)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(533, 37)
        Me.LblTime.TabIndex = 17
        Me.LblTime.Text = "00:00:00"
        Me.LblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimePicker1
        '
        Me.TimePicker1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.TimePicker1.Location = New System.Drawing.Point(303, 313)
        Me.TimePicker1.Name = "TimePicker1"
        Me.TimePicker1.ShowUpDown = True
        Me.TimePicker1.Size = New System.Drawing.Size(90, 23)
        Me.TimePicker1.TabIndex = 16
        '
        'LblKet
        '
        Me.LblKet.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKet.Location = New System.Drawing.Point(107, 275)
        Me.LblKet.Name = "LblKet"
        Me.LblKet.Size = New System.Drawing.Size(492, 35)
        Me.LblKet.TabIndex = 15
        Me.LblKet.Text = "Klik 2 Kali Pada Salah Satu Data Diatas"
        Me.LblKet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(107, 124)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(492, 148)
        Me.DGV.TabIndex = 14
        '
        'TimerTime
        '
        Me.TimerTime.Enabled = True
        '
        'editdata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 419)
        Me.Controls.Add(Me.BtnSelect1)
        Me.Controls.Add(Me.LblSetSong)
        Me.Controls.Add(Me.LblTime)
        Me.Controls.Add(Me.TimePicker1)
        Me.Controls.Add(Me.LblKet)
        Me.Controls.Add(Me.DGV)
        Me.Name = "editdata"
        Me.Text = "editdata"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSelect1 As System.Windows.Forms.Button
    Friend WithEvents LblSetSong As System.Windows.Forms.Label
    Friend WithEvents LblTime As System.Windows.Forms.Label
    Friend WithEvents TimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblKet As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents TimerTime As System.Windows.Forms.Timer
End Class
