<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.LblTime = New System.Windows.Forms.Label()
        Me.LblSetTime = New System.Windows.Forms.Label()
        Me.TimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LblSetSong = New System.Windows.Forms.Label()
        Me.BtnSelectSong = New System.Windows.Forms.Button()
        Me.WMP = New AxWMPLib.AxWindowsMediaPlayer()
        Me.TimerTime = New System.Windows.Forms.Timer(Me.components)
        Me.TimerValidate = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.WMP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTime
        '
        Me.LblTime.Font = New System.Drawing.Font("Bauhaus 93", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTime.ForeColor = System.Drawing.Color.Red
        Me.LblTime.Location = New System.Drawing.Point(-1, 29)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(745, 37)
        Me.LblTime.TabIndex = 0
        Me.LblTime.Text = "00:00:00"
        Me.LblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSetTime
        '
        Me.LblSetTime.AutoSize = True
        Me.LblSetTime.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSetTime.Location = New System.Drawing.Point(23, 111)
        Me.LblSetTime.Name = "LblSetTime"
        Me.LblSetTime.Size = New System.Drawing.Size(85, 18)
        Me.LblSetTime.TabIndex = 1
        Me.LblSetTime.Text = "Set Time"
        '
        'TimePicker
        '
        Me.TimePicker.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.TimePicker.Location = New System.Drawing.Point(124, 105)
        Me.TimePicker.Name = "TimePicker"
        Me.TimePicker.Size = New System.Drawing.Size(230, 27)
        Me.TimePicker.TabIndex = 2
        '
        'LblSetSong
        '
        Me.LblSetSong.AutoSize = True
        Me.LblSetSong.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSetSong.Location = New System.Drawing.Point(23, 156)
        Me.LblSetSong.Name = "LblSetSong"
        Me.LblSetSong.Size = New System.Drawing.Size(86, 18)
        Me.LblSetSong.TabIndex = 3
        Me.LblSetSong.Text = "Set Song"
        '
        'BtnSelectSong
        '
        Me.BtnSelectSong.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelectSong.Location = New System.Drawing.Point(124, 149)
        Me.BtnSelectSong.Name = "BtnSelectSong"
        Me.BtnSelectSong.Size = New System.Drawing.Size(230, 32)
        Me.BtnSelectSong.TabIndex = 4
        Me.BtnSelectSong.Text = "Select Song"
        Me.BtnSelectSong.UseVisualStyleBackColor = True
        '
        'WMP
        '
        Me.WMP.Enabled = True
        Me.WMP.Location = New System.Drawing.Point(26, 207)
        Me.WMP.Name = "WMP"
        Me.WMP.OcxState = CType(resources.GetObject("WMP.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WMP.Size = New System.Drawing.Size(328, 97)
        Me.WMP.TabIndex = 5
        '
        'TimerTime
        '
        '
        'TimerValidate
        '
        Me.TimerValidate.Interval = 1000
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(378, 105)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(342, 196)
        Me.DGV.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(441, 245)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 32)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Tampil Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(60, 72)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 15)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 332)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.WMP)
        Me.Controls.Add(Me.BtnSelectSong)
        Me.Controls.Add(Me.LblSetSong)
        Me.Controls.Add(Me.TimePicker)
        Me.Controls.Add(Me.LblSetTime)
        Me.Controls.Add(Me.LblTime)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        CType(Me.WMP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTime As System.Windows.Forms.Label
    Friend WithEvents LblSetTime As System.Windows.Forms.Label
    Friend WithEvents TimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblSetSong As System.Windows.Forms.Label
    Friend WithEvents BtnSelectSong As System.Windows.Forms.Button
    Friend WithEvents WMP As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents TimerTime As System.Windows.Forms.Timer
    Friend WithEvents TimerValidate As System.Windows.Forms.Timer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
