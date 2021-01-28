<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdateDeleteStudent
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
        Me.btnloadanh = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtpkngaysinh = New System.Windows.Forms.DateTimePicker()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txttenhocsinh = New System.Windows.Forms.TextBox()
        Me.txtmahocsinh = New System.Windows.Forms.TextBox()
        Me.cbxmalop = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.btncapnhat = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.radionu = New System.Windows.Forms.RadioButton()
        Me.radionam = New System.Windows.Forms.RadioButton()
        Me.grpgioitinh = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpgioitinh.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnloadanh
        '
        Me.btnloadanh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnloadanh.Location = New System.Drawing.Point(322, 138)
        Me.btnloadanh.Name = "btnloadanh"
        Me.btnloadanh.Size = New System.Drawing.Size(79, 26)
        Me.btnloadanh.TabIndex = 49
        Me.btnloadanh.Text = "Chọn ảnh"
        Me.btnloadanh.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(407, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'dtpkngaysinh
        '
        Me.dtpkngaysinh.CustomFormat = "dd/MM/yyyy"
        Me.dtpkngaysinh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpkngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpkngaysinh.Location = New System.Drawing.Point(101, 90)
        Me.dtpkngaysinh.Name = "dtpkngaysinh"
        Me.dtpkngaysinh.Size = New System.Drawing.Size(198, 26)
        Me.dtpkngaysinh.TabIndex = 47
        Me.dtpkngaysinh.Value = New Date(2001, 7, 20, 0, 0, 0, 0)
        '
        'txtdiachi
        '
        Me.txtdiachi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiachi.Location = New System.Drawing.Point(407, 18)
        Me.txtdiachi.Multiline = True
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(198, 64)
        Me.txtdiachi.TabIndex = 44
        '
        'txttenhocsinh
        '
        Me.txttenhocsinh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenhocsinh.Location = New System.Drawing.Point(101, 54)
        Me.txttenhocsinh.Name = "txttenhocsinh"
        Me.txttenhocsinh.Size = New System.Drawing.Size(198, 26)
        Me.txttenhocsinh.TabIndex = 45
        '
        'txtmahocsinh
        '
        Me.txtmahocsinh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmahocsinh.Location = New System.Drawing.Point(101, 18)
        Me.txtmahocsinh.Name = "txtmahocsinh"
        Me.txtmahocsinh.Size = New System.Drawing.Size(198, 26)
        Me.txtmahocsinh.TabIndex = 46
        '
        'cbxmalop
        '
        Me.cbxmalop.Enabled = False
        Me.cbxmalop.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxmalop.FormattingEnabled = True
        Me.cbxmalop.Location = New System.Drawing.Point(101, 175)
        Me.cbxmalop.Name = "cbxmalop"
        Me.cbxmalop.Size = New System.Drawing.Size(198, 27)
        Me.cbxmalop.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 19)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Mã Lớp"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(342, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 19)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Địa chỉ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 19)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Giới tính"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 19)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Mã học sinh"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 19)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Tên học sinh"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 19)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Ngày sinh"
        '
        'btnthoat
        '
        Me.btnthoat.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnthoat.FlatAppearance.BorderSize = 2
        Me.btnthoat.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthoat.Location = New System.Drawing.Point(369, 248)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 33)
        Me.btnthoat.TabIndex = 51
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = False
        '
        'btncapnhat
        '
        Me.btncapnhat.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btncapnhat.FlatAppearance.BorderSize = 3
        Me.btncapnhat.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncapnhat.Location = New System.Drawing.Point(101, 248)
        Me.btncapnhat.Name = "btncapnhat"
        Me.btncapnhat.Size = New System.Drawing.Size(75, 33)
        Me.btncapnhat.TabIndex = 52
        Me.btncapnhat.Text = "Cập nhật"
        Me.btncapnhat.UseVisualStyleBackColor = False
        '
        'btnxoa
        '
        Me.btnxoa.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnxoa.FlatAppearance.BorderSize = 2
        Me.btnxoa.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxoa.Location = New System.Drawing.Point(241, 248)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 33)
        Me.btnxoa.TabIndex = 53
        Me.btnxoa.Text = "Xóa "
        Me.btnxoa.UseVisualStyleBackColor = False
        '
        'radionu
        '
        Me.radionu.AutoSize = True
        Me.radionu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radionu.Location = New System.Drawing.Point(87, -1)
        Me.radionu.Name = "radionu"
        Me.radionu.Size = New System.Drawing.Size(48, 23)
        Me.radionu.TabIndex = 0
        Me.radionu.TabStop = True
        Me.radionu.Text = "Nữ"
        Me.radionu.UseVisualStyleBackColor = True
        '
        'radionam
        '
        Me.radionam.AutoSize = True
        Me.radionam.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radionam.Location = New System.Drawing.Point(6, -1)
        Me.radionam.Name = "radionam"
        Me.radionam.Size = New System.Drawing.Size(57, 23)
        Me.radionam.TabIndex = 1
        Me.radionam.TabStop = True
        Me.radionam.Text = "Nam"
        Me.radionam.UseVisualStyleBackColor = True
        '
        'grpgioitinh
        '
        Me.grpgioitinh.Controls.Add(Me.radionam)
        Me.grpgioitinh.Controls.Add(Me.radionu)
        Me.grpgioitinh.Location = New System.Drawing.Point(99, 136)
        Me.grpgioitinh.Name = "grpgioitinh"
        Me.grpgioitinh.Size = New System.Drawing.Size(200, 25)
        Me.grpgioitinh.TabIndex = 54
        Me.grpgioitinh.TabStop = False
        '
        'FrmUpdateDeleteStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 304)
        Me.Controls.Add(Me.grpgioitinh)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btncapnhat)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btnloadanh)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dtpkngaysinh)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.txttenhocsinh)
        Me.Controls.Add(Me.txtmahocsinh)
        Me.Controls.Add(Me.cbxmalop)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Name = "FrmUpdateDeleteStudent"
        Me.Text = "FrmUpdateDeleteStudent"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpgioitinh.ResumeLayout(False)
        Me.grpgioitinh.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnloadanh As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dtpkngaysinh As DateTimePicker
    Friend WithEvents txtdiachi As TextBox
    Friend WithEvents txttenhocsinh As TextBox
    Friend WithEvents txtmahocsinh As TextBox
    Friend WithEvents cbxmalop As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnthoat As Button
    Friend WithEvents btncapnhat As Button
    Friend WithEvents btnxoa As Button
    Friend WithEvents radionu As RadioButton
    Friend WithEvents radionam As RadioButton
    Friend WithEvents grpgioitinh As GroupBox
End Class
