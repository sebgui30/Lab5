<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassName = New System.Windows.Forms.TextBox()
        Me.grpSeats = New System.Windows.Forms.GroupBox()
        Me.rdo4B = New System.Windows.Forms.RadioButton()
        Me.rdo3B = New System.Windows.Forms.RadioButton()
        Me.rdo2B = New System.Windows.Forms.RadioButton()
        Me.rdo1B = New System.Windows.Forms.RadioButton()
        Me.rdo4A = New System.Windows.Forms.RadioButton()
        Me.rdo3A = New System.Windows.Forms.RadioButton()
        Me.rdo2A = New System.Windows.Forms.RadioButton()
        Me.rdo1A = New System.Windows.Forms.RadioButton()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnNextPass = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSeats.SuspendLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Happy Dolphins"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sea Planes"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SeatSelection.My.Resources.Resources.dolphin
        Me.PictureBox1.Location = New System.Drawing.Point(47, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Passenger Name:"
        '
        'txtPassName
        '
        Me.txtPassName.Location = New System.Drawing.Point(47, 169)
        Me.txtPassName.Name = "txtPassName"
        Me.txtPassName.Size = New System.Drawing.Size(160, 20)
        Me.txtPassName.TabIndex = 4
        '
        'grpSeats
        '
        Me.grpSeats.Controls.Add(Me.rdo4B)
        Me.grpSeats.Controls.Add(Me.rdo3B)
        Me.grpSeats.Controls.Add(Me.rdo2B)
        Me.grpSeats.Controls.Add(Me.rdo1B)
        Me.grpSeats.Controls.Add(Me.rdo4A)
        Me.grpSeats.Controls.Add(Me.rdo3A)
        Me.grpSeats.Controls.Add(Me.rdo2A)
        Me.grpSeats.Controls.Add(Me.rdo1A)
        Me.grpSeats.Location = New System.Drawing.Point(13, 199)
        Me.grpSeats.Name = "grpSeats"
        Me.grpSeats.Size = New System.Drawing.Size(229, 160)
        Me.grpSeats.TabIndex = 5
        Me.grpSeats.TabStop = False
        Me.grpSeats.Text = "Seat Selection"
        '
        'rdo4B
        '
        Me.rdo4B.AutoSize = True
        Me.rdo4B.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo4B.Location = New System.Drawing.Point(145, 109)
        Me.rdo4B.Name = "rdo4B"
        Me.rdo4B.Size = New System.Drawing.Size(49, 24)
        Me.rdo4B.TabIndex = 7
        Me.rdo4B.TabStop = True
        Me.rdo4B.Text = "4B"
        Me.rdo4B.UseVisualStyleBackColor = True
        '
        'rdo3B
        '
        Me.rdo3B.AutoSize = True
        Me.rdo3B.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo3B.Location = New System.Drawing.Point(145, 83)
        Me.rdo3B.Name = "rdo3B"
        Me.rdo3B.Size = New System.Drawing.Size(49, 24)
        Me.rdo3B.TabIndex = 6
        Me.rdo3B.TabStop = True
        Me.rdo3B.Text = "3B"
        Me.rdo3B.UseVisualStyleBackColor = True
        '
        'rdo2B
        '
        Me.rdo2B.AutoSize = True
        Me.rdo2B.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo2B.Location = New System.Drawing.Point(145, 57)
        Me.rdo2B.Name = "rdo2B"
        Me.rdo2B.Size = New System.Drawing.Size(49, 24)
        Me.rdo2B.TabIndex = 5
        Me.rdo2B.TabStop = True
        Me.rdo2B.Text = "2B"
        Me.rdo2B.UseVisualStyleBackColor = True
        '
        'rdo1B
        '
        Me.rdo1B.AutoSize = True
        Me.rdo1B.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo1B.Location = New System.Drawing.Point(145, 31)
        Me.rdo1B.Name = "rdo1B"
        Me.rdo1B.Size = New System.Drawing.Size(49, 24)
        Me.rdo1B.TabIndex = 4
        Me.rdo1B.TabStop = True
        Me.rdo1B.Text = "1B"
        Me.rdo1B.UseVisualStyleBackColor = True
        '
        'rdo4A
        '
        Me.rdo4A.AutoSize = True
        Me.rdo4A.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo4A.Location = New System.Drawing.Point(26, 109)
        Me.rdo4A.Name = "rdo4A"
        Me.rdo4A.Size = New System.Drawing.Size(49, 24)
        Me.rdo4A.TabIndex = 3
        Me.rdo4A.TabStop = True
        Me.rdo4A.Text = "4A"
        Me.rdo4A.UseVisualStyleBackColor = True
        '
        'rdo3A
        '
        Me.rdo3A.AutoSize = True
        Me.rdo3A.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo3A.Location = New System.Drawing.Point(26, 83)
        Me.rdo3A.Name = "rdo3A"
        Me.rdo3A.Size = New System.Drawing.Size(49, 24)
        Me.rdo3A.TabIndex = 2
        Me.rdo3A.TabStop = True
        Me.rdo3A.Text = "3A"
        Me.rdo3A.UseVisualStyleBackColor = True
        '
        'rdo2A
        '
        Me.rdo2A.AutoSize = True
        Me.rdo2A.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo2A.Location = New System.Drawing.Point(26, 57)
        Me.rdo2A.Name = "rdo2A"
        Me.rdo2A.Size = New System.Drawing.Size(49, 24)
        Me.rdo2A.TabIndex = 1
        Me.rdo2A.TabStop = True
        Me.rdo2A.Text = "2A"
        Me.rdo2A.UseVisualStyleBackColor = True
        '
        'rdo1A
        '
        Me.rdo1A.AutoSize = True
        Me.rdo1A.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo1A.Location = New System.Drawing.Point(26, 31)
        Me.rdo1A.Name = "rdo1A"
        Me.rdo1A.Size = New System.Drawing.Size(49, 24)
        Me.rdo1A.TabIndex = 0
        Me.rdo1A.TabStop = True
        Me.rdo1A.Text = "1A"
        Me.rdo1A.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(4, 365)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(76, 49)
        Me.btnConfirm.TabIndex = 6
        Me.btnConfirm.Text = "Confirm Seat"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnNextPass
        '
        Me.btnNextPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextPass.Location = New System.Drawing.Point(86, 365)
        Me.btnNextPass.Name = "btnNextPass"
        Me.btnNextPass.Size = New System.Drawing.Size(75, 49)
        Me.btnNextPass.TabIndex = 7
        Me.btnNextPass.Text = "Next Passenger"
        Me.btnNextPass.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(167, 365)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 49)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(254, 426)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNextPass)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.grpSeats)
        Me.Controls.Add(Me.txtPassName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seat Selection"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSeats.ResumeLayout(False)
        Me.grpSeats.PerformLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassName As TextBox
    Friend WithEvents grpSeats As GroupBox
    Friend WithEvents rdo1A As RadioButton
    Friend WithEvents rdo4B As RadioButton
    Friend WithEvents rdo3B As RadioButton
    Friend WithEvents rdo2B As RadioButton
    Friend WithEvents rdo1B As RadioButton
    Friend WithEvents rdo4A As RadioButton
    Friend WithEvents rdo3A As RadioButton
    Friend WithEvents rdo2A As RadioButton
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnNextPass As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents errP As ErrorProvider
End Class
