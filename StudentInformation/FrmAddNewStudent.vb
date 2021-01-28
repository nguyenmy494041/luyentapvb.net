Imports System.IO
Imports System.Drawing.Imaging

Public Class FrmAddNewStudent
    Dim stu As STUDENT
    Sub xoadulieunhap()
        Dim stu = New STUDENT
        Dim danhsachmalop = stu.danhsachlop()
        txtdiachi.Clear()
        txtmahocsinh.Clear()
        txttenhocsinh.Clear()
        cbxmalop.Items.Clear()
        grpgioitinh.Text = ""
        For Each item In danhsachmalop
            cbxmalop.Items.Add(item.TenLopHoc)
        Next
        PictureBox1.Image = Image.FromFile("C:\Users\nguye\Desktop\StudentInformation\StudentInformation\no-image.png")
    End Sub
    Private Function codulieu() As Boolean
        If txtdiachi.Text <> "" AndAlso txtmahocsinh.Text <> "" AndAlso txttenhocsinh.Text <> "" AndAlso cbxmalop.Text <> "" AndAlso grpgioitinh.Text <> "" Then
            Return True
        End If
        Return False
    End Function
    Private Sub FrmAddNewStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim stu = New STUDENT
        Dim danhsachmalop = stu.danhsachlop()
        For Each item In danhsachmalop
            cbxmalop.Items.Add(item.TenLopHoc)
        Next
        PictureBox1.Image = Image.FromFile("C:\Users\nguye\Desktop\StudentInformation\StudentInformation\no-image.png")
    End Sub

    Private Sub btnloadanh_Click(sender As Object, e As EventArgs) Handles btnloadanh.Click
        Dim opf = New OpenFileDialog()
        PictureBox1.Image = Image.FromFile("C:\Users\nguye\Desktop\StudentInformation\StudentInformation\no-image.png")
        opf.Filter = "Select image(*.png;*.jpg;*.gif)|*.png;*.jpg;*.gif"
        If opf.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub btnthemmoi_Click(sender As Object, e As EventArgs) Handles btnthemmoi.Click
        Dim stu = New STUDENT
        Dim context = New CSDLTRUONGHOCEntities()
        If codulieu() Then
            Dim stram = New MemoryStream()
            PictureBox1.Image.Save(stram, ImageFormat.Png)
            If stu.themmoihocsinh(txtmahocsinh.Text, txttenhocsinh.Text, grpgioitinh.Text, dtpkngaysinh.Value(), txtdiachi.Text, stram.ToArray(), stu.laymalop(cbxmalop.Text)) Then
                MsgBox("Đã thêm mới học sinh", vbOKOnly + vbInformation, "Thông báo")
            Else
                MsgBox("Mã học sinh này đã được sử dụng", vbOKOnly + vbInformation, "Thông báo")
            End If
        Else
            MsgBox("Thêm mới thất bại, các trường dữ liệu không được để trống", vbOKOnly, "thong bao")
        End If
    End Sub

    Private Sub radionam_CheckedChanged(sender As Object, e As EventArgs) Handles radionam.CheckedChanged
        grpgioitinh.Text = radionam.Text
    End Sub

    Private Sub radionu_CheckedChanged(sender As Object, e As EventArgs) Handles radionu.CheckedChanged
        grpgioitinh.Text = radionu.Text
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        xoadulieunhap()
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub


End Class