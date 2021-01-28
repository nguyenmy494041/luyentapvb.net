<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmListStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.banghocsinh = New System.Windows.Forms.DataGridView()
        Me.btncapnhat = New System.Windows.Forms.Button()
        Me.grptimkiem = New System.Windows.Forms.GroupBox()
        Me.cbxtenlop = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttenhocsinh = New System.Windows.Forms.TextBox()
        CType(Me.banghocsinh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grptimkiem.SuspendLayout()
        Me.SuspendLayout()
        '
        'banghocsinh
        '
        Me.banghocsinh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.banghocsinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.banghocsinh.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.banghocsinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.banghocsinh.Location = New System.Drawing.Point(12, 49)
        Me.banghocsinh.Name = "banghocsinh"
        Me.banghocsinh.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.banghocsinh.RowTemplate.Height = 50
        Me.banghocsinh.Size = New System.Drawing.Size(825, 349)
        Me.banghocsinh.TabIndex = 0
        '
        'btncapnhat
        '
        Me.btncapnhat.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncapnhat.Location = New System.Drawing.Point(12, 405)
        Me.btncapnhat.Name = "btncapnhat"
        Me.btncapnhat.Size = New System.Drawing.Size(825, 33)
        Me.btncapnhat.TabIndex = 1
        Me.btncapnhat.Text = "Cập nhật"
        Me.btncapnhat.UseVisualStyleBackColor = True
        '
        'grptimkiem
        '
        Me.grptimkiem.Controls.Add(Me.cbxtenlop)
        Me.grptimkiem.Controls.Add(Me.Label2)
        Me.grptimkiem.Controls.Add(Me.Label1)
        Me.grptimkiem.Controls.Add(Me.txttenhocsinh)
        Me.grptimkiem.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grptimkiem.Location = New System.Drawing.Point(258, 13)
        Me.grptimkiem.Name = "grptimkiem"
        Me.grptimkiem.Size = New System.Drawing.Size(579, 30)
        Me.grptimkiem.TabIndex = 2
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(333, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Theo tên"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Theo lớp"
        '
        'txttenhocsinh
        '
        Me.txttenhocsinh.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenhocsinh.Location = New System.Drawing.Point(399, 5)
        Me.txttenhocsinh.Name = "txttenhocsinh"
        Me.txttenhocsinh.Size = New System.Drawing.Size(174, 23)
        Me.txttenhocsinh.TabIndex = 1
        '
        'FrmListStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 450)
        Me.Controls.Add(Me.grptimkiem)
        Me.Controls.Add(Me.btncapnhat)
        Me.Controls.Add(Me.banghocsinh)
        Me.Name = "FrmListStudent"
        Me.Text = "FrmListStudent"
        CType(Me.banghocsinh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grptimkiem.ResumeLayout(False)
        Me.grptimkiem.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents banghocsinh As DataGridView
    Friend WithEvents btncapnhat As Button
    Friend WithEvents grptimkiem As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txttenhocsinh As TextBox
    Friend WithEvents cbxtenlop As ComboBox
End Class
