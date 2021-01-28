Imports System.IO
Imports System.Drawing.Imaging
Public Class FrmManagementStudent
    Dim stu As STUDENT
    Function codulieu() As Boolean
        If txtmahocsinh.Text <> "" AndAlso txttenhocsinh.Text <> "" AndAlso txtdiachi.Text <> "" AndAlso Panel1.Text <> "" Then
            Return True
        End If
        Return False
    End Function
    Sub hienthidanhsach()
        Dim context = New CSDLTRUONGHOCEntities()
        banghocsinh.DataSource = (From hs In context.HocSinhs Select hs.MaHocSinh, hs.TenHocSinh, hs.NgaySinh, hs.GioiTinh, hs.DiaChi, hs.LopHoc.TenLopHoc, hs.HinhAnh).ToList()
        banghocsinh.Columns(0).HeaderText = "Mã học sinh"
        banghocsinh.Columns(1).HeaderText = "Tên học sinh"
        banghocsinh.Columns(2).HeaderText = "Ngày sinh"
        banghocsinh.Columns(3).HeaderText = "Giới tính"
        banghocsinh.Columns(4).HeaderText = "Địa chỉ"
        banghocsinh.Columns(5).HeaderText = "Tên lớp"
        banghocsinh.Columns(6).HeaderText = "Hình ảnh"
        banghocsinh.Columns(5).Width = 130
    End Sub
    Sub xoadulieunhap()
        Dim stu = New STUDENT
        Dim danhsachmalop = stu.danhsachlop()
        txtdiachi.Clear()
        txtmahocsinh.Clear()
        txttenhocsinh.Clear()
        cbxmalop.Items.Clear()
        cbxmalop.Text = ""
        Panel1.Text = ""
        For Each item In danhsachmalop
            cbxmalop.Items.Add(item.TenLopHoc)
        Next
        PictureBox1.Image = Image.FromFile("C:\Users\nguye\Desktop\StudentInformation\StudentInformation\no-image.png")
    End Sub

    Private Sub FrmManagementStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = Image.FromFile("C:\Users\nguye\Desktop\StudentInformation\StudentInformation\no-image.png")
        stu = New STUDENT()
        For Each it In stu.danhsachlop()
            cbxmalop.Items.Add(it.TenLopHoc)
        Next
        hienthidanhsach()
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        xoadulieunhap()
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub

    Private Sub txtmahocsinh_TextChanged(sender As Object, e As EventArgs) Handles txtmahocsinh.TextChanged
        btnthemmoi.Enabled = True
    End Sub

    Private Sub btnthemmoi_Click(sender As Object, e As EventArgs) Handles btnthemmoi.Click
        If codulieu() Then
            Dim stu = New STUDENT()
            Dim stream = New MemoryStream()
            PictureBox1.Image.Save(stream, ImageFormat.Png)
            If stu.themmoihocsinh(txtmahocsinh.Text, txttenhocsinh.Text, Panel1.Text, dtpkngaysinh.Value, txtdiachi.Text, stream.ToArray(), stu.laymalop(cbxmalop.Text)) Then
                MsgBox("Đã thêm mới học sinh", vbOKOnly + vbInformation, "Thông báo")
                hienthidanhsach()
            Else
                MsgBox("Mã học sinh này đã được sử dụng", vbOKOnly + vbInformation, "Thông báo")
            End If
        Else
            MsgBox("Các trường dữ liệu không được để trống", vbOKOnly + vbInformation, "Thông báo")
        End If
    End Sub

    Private Sub radionam_CheckedChanged(sender As Object, e As EventArgs) Handles radionam.CheckedChanged
        Panel1.Text = "Nam"
    End Sub

    Private Sub radionu_CheckedChanged(sender As Object, e As EventArgs) Handles radionu.CheckedChanged
        Panel1.Text = "Nữ"
    End Sub

    Private Sub btnloadanh_Click(sender As Object, e As EventArgs) Handles btnloadanh.Click
        Dim opf = New OpenFileDialog()
        PictureBox1.Image = Image.FromFile("C:\Users\nguye\Desktop\StudentInformation\StudentInformation\no-image.png")
        opf.Filter = "Select image(*.png;*.jpg;*.gif)|*.png;*.jpg;*.gif"
        If opf.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        If MsgBox("Bạn muốn xóa học sinh này", vbYesNo + vbQuestion, "Canh bao") = vbYes Then
            Dim stu = New STUDENT()
            If stu.xoahocsinh(txtmahocsinh.Text) Then
                MsgBox("Đã xoa học sinh", vbOKOnly + vbInformation, "Thông báo")
            Else
                MsgBox("Đã co loi xay ra, thu lai sau", vbOKOnly + vbInformation, "Thông báo")
            End If
        End If
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        If codulieu() Then
            Dim stu = New STUDENT()
            Dim stream = New MemoryStream()
            PictureBox1.Image.Save(stream, ImageFormat.Png)
            If stu.suathongtinhs(txtmahocsinh.Text, txttenhocsinh.Text, Panel1.Text, dtpkngaysinh.Value, txtdiachi.Text, stream.ToArray()) Then
                MsgBox("Đã thay doi thong tin học sinh", vbOKOnly + vbInformation, "Thông báo")
                hienthidanhsach()
            Else
                MsgBox("dã co loi", vbOKOnly + vbInformation, "Thông báo")
            End If
        Else
            MsgBox("Các trường dữ liệu không được để trống", vbOKOnly + vbInformation, "Thông báo")
        End If
    End Sub
End Class