<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManagementStudent
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
        Me.radionam = New System.Windows.Forms.RadioButton()
        Me.radionu = New System.Windows.Forms.RadioButton()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnthemmoi = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
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
        Me.btnsua = New System.Windows.Forms.Button()
        Me.banghocsinh = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grptimkiem = New System.Windows.Forms.GroupBox()
        Me.cbxtenlop = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnxoa = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banghocsinh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.grptimkiem.SuspendLayout()
        Me.SuspendLayout()
        '
        'radionam
        '
        Me.radionam.AutoSize = True
        Me.radionam.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radionam.Location = New System.Drawing.Point(3, 7)
        Me.radionam.Name = "radionam"
        Me.radionam.Size = New System.Drawing.Size(53, 20)
        Me.radionam.TabIndex = 1
        Me.radionam.TabStop = True
        Me.radionam.Text = "Nam"
        Me.radionam.UseVisualStyleBackColor = True
        '
        'radionu
        '
        Me.radionu.AutoSize = True
        Me.radionu.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radionu.Location = New System.Drawing.Point(97, 7)
        Me.radionu.Name = "radionu"
        Me.radionu.Size = New System.Drawing.Size(44, 20)
        Me.radionu.TabIndex = 0
        Me.radionu.TabStop = True
        Me.radionu.Text = "Nữ"
        Me.radionu.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Enabled = False
        Me.btnreset.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(470, 433)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(89, 40)
        Me.btnreset.TabIndex = 54
        Me.btnreset.Text = "Xóa dữ liêu nhập"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnthemmoi
        '
        Me.btnthemmoi.Enabled = False
        Me.btnthemmoi.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthemmoi.Location = New System.Drawing.Point(16, 433)
        Me.btnthemmoi.Name = "btnthemmoi"
        Me.btnthemmoi.Size = New System.Drawing.Size(89, 40)
        Me.btnthemmoi.TabIndex = 53
        Me.btnthemmoi.Text = "Thêm mới"
        Me.btnthemmoi.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthoat.Location = New System.Drawing.Point(350, 433)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(89, 40)
        Me.btnthoat.TabIndex = 52
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'btnloadanh
        '
        Me.btnloadanh.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnloadanh.Location = New System.Drawing.Point(16, 336)
        Me.btnloadanh.Name = "btnloadanh"
        Me.btnloadanh.Size = New System.Drawing.Size(79, 26)
        Me.btnloadanh.TabIndex = 51
        Me.btnloadanh.Text = "Chọn ảnh"
        Me.btnloadanh.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(101, 286)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'dtpkngaysinh
        '
        Me.dtpkngaysinh.CustomFormat = "dd/MM/yyyy"
        Me.dtpkngaysinh.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpkngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpkngaysinh.Location = New System.Drawing.Point(101, 89)
        Me.dtpkngaysinh.Name = "dtpkngaysinh"
        Me.dtpkngaysinh.Size = New System.Drawing.Size(198, 23)
        Me.dtpkngaysinh.TabIndex = 49
        Me.dtpkngaysinh.Value = New Date(2001, 7, 20, 0, 0, 0, 0)
        '
        'txtdiachi
        '
        Me.txtdiachi.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiachi.Location = New System.Drawing.Point(101, 216)
        Me.txtdiachi.Multiline = True
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(198, 64)
        Me.txtdiachi.TabIndex = 46
        '
        'txttenhocsinh
        '
        Me.txttenhocsinh.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenhocsinh.Location = New System.Drawing.Point(101, 53)
        Me.txttenhocsinh.Name = "txttenhocsinh"
        Me.txttenhocsinh.Size = New System.Drawing.Size(198, 23)
        Me.txttenhocsinh.TabIndex = 47
        '
        'txtmahocsinh
        '
        Me.txtmahocsinh.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmahocsinh.Location = New System.Drawing.Point(101, 17)
        Me.txtmahocsinh.Name = "txtmahocsinh"
        Me.txtmahocsinh.Size = New System.Drawing.Size(198, 23)
        Me.txtmahocsinh.TabIndex = 48
        '
        'cbxmalop
        '
        Me.cbxmalop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxmalop.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxmalop.FormattingEnabled = True
        Me.cbxmalop.Location = New System.Drawing.Point(101, 174)
        Me.cbxmalop.Name = "cbxmalop"
        Me.cbxmalop.Size = New System.Drawing.Size(198, 23)
        Me.cbxmalop.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Mã Lớp"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Địa chỉ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 16)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Giới tính"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Mã học sinh"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Tên học sinh"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Ngày sinh"
        '
        'btnsua
        '
        Me.btnsua.Enabled = False
        Me.btnsua.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsua.Location = New System.Drawing.Point(130, 433)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(89, 40)
        Me.btnsua.TabIndex = 58
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'banghocsinh
        '
        Me.banghocsinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.banghocsinh.Location = New System.Drawing.Point(305, 57)
        Me.banghocsinh.Name = "banghocsinh"
        Me.banghocsinh.RowTemplate.Height = 60
        Me.banghocsinh.Size = New System.Drawing.Size(609, 349)
        Me.banghocsinh.TabIndex = 59
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.radionam)
        Me.Panel1.Controls.Add(Me.radionu)
        Me.Panel1.Location = New System.Drawing.Point(101, 125)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(198, 32)
        Me.Panel1.TabIndex = 60
        '
        'grptimkiem
        '
        Me.grptimkiem.Controls.Add(Me.cbxtenlop)
        Me.grptimkiem.Controls.Add(Me.Label1)
        Me.grptimkiem.Controls.Add(Me.Label8)
        Me.grptimkiem.Controls.Add(Me.TextBox1)
        Me.grptimkiem.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grptimkiem.Location = New System.Drawing.Point(335, 17)
        Me.grptimkiem.Name = "grptimkiem"
        Me.grptimkiem.Size = New System.Drawing.Size(579, 30)
        Me.grptimkiem.TabIndex = 61
        Me.grptimkiem.TabStop = False
        Me.grptimkiem.Text = "Tìm kiếm"
        '
        'cbxtenlop
        '
        Me.cbxtenlop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxtenlop.FormattingEnabled = True
        Me.cbxtenlop.Location = New System.Drawing.Point(160, 6)
        Me.cbxtenlop.Name = "cbxtenlop"
        Me.cbxtenlop.Size = New System.Drawing.Size(167, 25)
        Me.cbxtenlop.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(333, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Theo tên"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(94, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Theo lớp"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(399, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(174, 23)
        Me.TextBox1.TabIndex = 1
        '
        'btnxoa
        '
        Me.btnxoa.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxoa.Location = New System.Drawing.Point(239, 433)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(89, 40)
        Me.btnxoa.TabIndex = 62
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'FrmManagementStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 508)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.grptimkiem)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.banghocsinh)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnthemmoi)
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
        Me.Name = "FrmManagementStudent"
        Me.Text = "FrmManagementStudent"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banghocsinh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grptimkiem.ResumeLayout(False)
        Me.grptimkiem.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radionam As RadioButton
    Friend WithEvents radionu As RadioButton
    Friend WithEvents btnreset As Button
    Friend WithEvents btnthemmoi As Button
    Friend WithEvents btnthoat As Button
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
    Friend WithEvents btnsua As Button
    Friend WithEvents banghocsinh As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents grptimkiem As GroupBox
    Friend WithEvents cbxtenlop As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnxoa As Button
End Class
