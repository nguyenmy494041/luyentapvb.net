Imports System.IO
Imports System.Drawing.Image

Public Class FrmListStudent
    Dim stu As STUDENT
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
    Private Sub FrmListStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hienthidanhsach()
        Dim stu = New STUDENT()
        For Each item In stu.danhsachlop
            cbxtenlop.Items.Add(item.TenLopHoc)
        Next
    End Sub

    Private Sub banghocsinh_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles banghocsinh.CellClick
        Dim inc As Integer = e.RowIndex()
        Dim student = New FrmUpdateDeleteStudent()

        student.txtmahocsinh.Text = banghocsinh.Rows(inc).Cells(0).Value.ToString()
        student.txttenhocsinh.Text = banghocsinh.Rows(inc).Cells(1).Value.ToString()
        student.txtdiachi.Text = banghocsinh.Rows(inc).Cells(4).Value.ToString()
        student.dtpkngaysinh.Value = banghocsinh.Rows(inc).Cells(2).Value
        If banghocsinh.Rows(inc).Cells(3).Value.ToString() = "Nam" Then
            student.radionam.Checked = True
        Else
            student.radionu.Checked = True
        End If
        student.cbxmalop.Text = banghocsinh.Rows(inc).Cells(5).Value.ToString()
        Dim pic As Byte()
        pic = banghocsinh.Rows(inc).Cells(6).Value
        If Not IsNothing(pic) Then
            Dim picture As New MemoryStream(pic)
            student.PictureBox1.Image = Image.FromStream(picture)
        Else
            student.PictureBox1.Image = Image.FromFile("C:\Users\nguye\Desktop\StudentInformation\StudentInformation\no-image.png")
        End If
        student.txtmahocsinh.Enabled = False
        Dim stu = New STUDENT()
        For Each item In stu.danhsachlop
            student.cbxmalop.Items.Add(item.TenLopHoc)
        Next
        student.Show()

    End Sub

    Private Sub btncapnhat_Click(sender As Object, e As EventArgs) Handles btncapnhat.Click
        hienthidanhsach()
    End Sub



    Private Sub cbxtenlop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxtenlop.SelectedIndexChanged
        If cbxtenlop.Text <> "" Then
            Dim context = New CSDLTRUONGHOCEntities()
            Dim stu = New STUDENT()
            Dim malop = stu.laymalop(cbxtenlop.Text)
            Dim danhsach = (From hs In context.HocSinhs.Where(Function(x) x.MaLopHoc = malop) Select hs.MaHocSinh, hs.TenHocSinh, hs.NgaySinh, hs.GioiTinh, hs.DiaChi, hs.LopHoc.TenLopHoc, hs.HinhAnh).ToList()
            If txttenhocsinh.Text <> "" Then
                danhsach = danhsach.Where(Function(x) x.TenHocSinh.Contains(txttenhocsinh.Text)).ToList()
            End If
            banghocsinh.ClearSelection()
            banghocsinh.DataSource = danhsach
        End If
    End Sub

    Private Sub txttenhocsinh_TextChanged(sender As Object, e As EventArgs) Handles txttenhocsinh.TextChanged
        Dim context = New CSDLTRUONGHOCEntities()
        Dim a = txttenhocsinh.Text
        Dim danhsach = (From hs In context.HocSinhs.Where(Function(x) x.TenHocSinh.Contains(a)) Select hs.MaHocSinh, hs.TenHocSinh, hs.NgaySinh, hs.GioiTinh, hs.DiaChi, hs.LopHoc.TenLopHoc, hs.HinhAnh).ToList()
        If cbxtenlop.Text <> "" Then
            danhsach = danhsach.Where(Function(x) x.TenLopHoc = cbxtenlop.Text).ToList()
        End If
        banghocsinh.ClearSelection()
        banghocsinh.DataSource = danhsach
    End Sub


End Class