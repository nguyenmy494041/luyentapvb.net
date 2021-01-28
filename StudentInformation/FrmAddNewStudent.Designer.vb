<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddNewStudent
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnloadanh = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.btnthemmoi = New System.Windows.Forms.Button()
        Me.radionam = New System.Windows.Forms.RadioButton()
        Me.radionu = New System.Windows.Forms.RadioButton()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.grpgioitinh = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpgioitinh.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpkngaysinh
        '
        Me.dtpkngaysinh.CustomFormat = "dd/MM/yyyy"
        Me.dtpkngaysinh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpkngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpkngaysinh.Location = New System.Drawing.Point(110, 91)
        Me.dtpkngaysinh.Name = "dtpkngaysinh"
        Me.dtpkngaysinh.Size = New System.Drawing.Size(198, 26)
        Me.dtpkngaysinh.TabIndex = 30
        Me.dtpkngaysinh.Value = New Date(2001, 7, 20, 0, 0, 0, 0)
        '
        'txtdiachi
        '
        Me.txtdiachi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiachi.Location = New System.Drawing.Point(110, 218)
        Me.txtdiachi.Multiline = True
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(198, 64)
        Me.txtdiachi.TabIndex = 27
        '
        'txttenhocsinh
        '
        Me.txttenhocsinh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenhocsinh.Location = New System.Drawing.Point(110, 55)
        Me.txttenhocsinh.Name = "txttenhocsinh"
        Me.txttenhocsinh.Size = New System.Drawing.Size(198, 26)
        Me.txttenhocsinh.TabIndex = 28
        '
        'txtmahocsinh
        '
        Me.txtmahocsinh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmahocsinh.Location = New System.Drawing.Point(110, 19)
        Me.txtmahocsinh.Name = "txtmahocsinh"
        Me.txtmahocsinh.Size = New System.Drawing.Size(198, 26)
        Me.txtmahocsinh.TabIndex = 29
        '
        'cbxmalop
        '
        Me.cbxmalop.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxmalop.FormattingEnabled = True
        Me.cbxmalop.Location = New System.Drawing.Point(110, 176)
        Me.cbxmalop.Name = "cbxmalop"
        Me.cbxmalop.Size = New System.Drawing.Size(198, 27)
        Me.cbxmalop.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 19)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Mã Lớp"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 19)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Địa chỉ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 19)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Giới tính"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Mã học sinh"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 19)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Tên học sinh"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 19)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Ngày sinh"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(110, 288)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'btnloadanh
        '
        Me.btnloadanh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnloadanh.Location = New System.Drawing.Point(25, 338)
        Me.btnloadanh.Name = "btnloadanh"
        Me.btnloadanh.Size = New System.Drawing.Size(79, 26)
        Me.btnloadanh.TabIndex = 33
        Me.btnloadanh.Text = "Chọn ảnh"
        Me.btnloadanh.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthoat.Location = New System.Drawing.Point(219, 435)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(89, 40)
        Me.btnthoat.TabIndex = 34
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'btnthemmoi
        '
        Me.btnthemmoi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthemmoi.Location = New System.Drawing.Point(116, 435)
        Me.btnthemmoi.Name = "btnthemmoi"
        Me.btnthemmoi.Size = New System.Drawing.Size(89, 40)
        Me.btnthemmoi.TabIndex = 35
        Me.btnthemmoi.Text = "Thêm mới"
        Me.btnthemmoi.UseVisualStyleBackColor = True
        '
        'radionam
        '
        Me.radionam.AutoSize = True
        Me.radionam.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radionam.Location = New System.Drawing.Point(4, -1)
        Me.radionam.Name = "radionam"
        Me.radionam.Size = New System.Drawing.Size(57, 23)
        Me.radionam.TabIndex = 1
        Me.radionam.TabStop = True
        Me.radionam.Text = "Nam"
        Me.radionam.UseVisualStyleBackColor = True
        '
        'radionu
        '
        Me.radionu.AutoSize = True
        Me.radionu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radionu.Location = New System.Drawing.Point(85, -1)
        Me.radionu.Name = "radionu"
        Me.radionu.Size = New System.Drawing.Size(48, 23)
        Me.radionu.TabIndex = 0
        Me.radionu.TabStop = True
        Me.radionu.Text = "Nữ"
        Me.radionu.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxoa.Location = New System.Drawing.Point(12, 435)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(89, 40)
        Me.btnxoa.TabIndex = 37
        Me.btnxoa.Text = "Xóa dữ liệu"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'grpgioitinh
        '
        Me.grpgioitinh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpgioitinh.Controls.Add(Me.radionam)
        Me.grpgioitinh.Controls.Add(Me.radionu)
        Me.grpgioitinh.Location = New System.Drawing.Point(110, 138)
        Me.grpgioitinh.Name = "grpgioitinh"
        Me.grpgioitinh.Size = New System.Drawing.Size(200, 26)
        Me.grpgioitinh.TabIndex = 38
        Me.grpgioitinh.TabStop = False
        '
        'FrmAddNewStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 487)
        Me.Controls.Add(Me.grpgioitinh)
        Me.Controls.Add(Me.btnxoa)
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
        Me.Name = "FrmAddNewStudent"
        Me.Text = "FrmAddNewStudent"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpgioitinh.ResumeLayout(False)
        Me.grpgioitinh.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnloadanh As Button
    Friend WithEvents btnthoat As Button
    Friend WithEvents btnthemmoi As Button
    Friend WithEvents radionam As RadioButton
    Friend WithEvents radionu As RadioButton
    Friend WithEvents btnxoa As Button
    Friend WithEvents grpgioitinh As GroupBox
End Class
