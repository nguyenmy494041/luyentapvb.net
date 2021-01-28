<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HọcSinhToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmMớiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhSáchHọcSinhToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HọcSinhToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HọcSinhToolStripMenuItem
        '
        Me.HọcSinhToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThêmMớiToolStripMenuItem, Me.DanhSáchHọcSinhToolStripMenuItem})
        Me.HọcSinhToolStripMenuItem.Name = "HọcSinhToolStripMenuItem"
        Me.HọcSinhToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.HọcSinhToolStripMenuItem.Text = "Học sinh"
        '
        'ThêmMớiToolStripMenuItem
        '
        Me.ThêmMớiToolStripMenuItem.Name = "ThêmMớiToolStripMenuItem"
        Me.ThêmMớiToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ThêmMớiToolStripMenuItem.Text = "Thêm mới"
        '
        'DanhSáchHọcSinhToolStripMenuItem
        '
        Me.DanhSáchHọcSinhToolStripMenuItem.Name = "DanhSáchHọcSinhToolStripMenuItem"
        Me.DanhSáchHọcSinhToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DanhSáchHọcSinhToolStripMenuItem.Text = "Danh sách học sinh"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HọcSinhToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThêmMớiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DanhSáchHọcSinhToolStripMenuItem As ToolStripMenuItem
End Class
