Imports System.IO
Imports System.Drawing.Imaging
Public Class FrmUpdateDeleteStudent
    Sub xoadulieunhap()
        Dim stu = New STUDENT
        Dim danhsachmalop = stu.danhsachlop()
        txtdiachi.Clear()
        txttenhocsinh.Clear()
        cbxmalop.Items.Clear()
        grpgioitinh.Text = ""
        For Each item In danhsachmalop
            cbxmalop.Items.Add(item.TenLopHoc)
        Next
        PictureBox1.Image = Image.FromFile("C:\Users\nguye\Desktop\StudentInformation\StudentInformation\no-image.png")
    End Sub
    Private Function codulieu() As Boolean
        If txtdiachi.Text <> "" AndAlso txtmahocsinh.Text <> "" AndAlso txttenhocsinh.Text <> "" AndAlso cbxmalop.Text <> "" Then
            Return True
        End If
        Return False
    End Function
    Private Sub btncapnhat_Click(sender As Object, e As EventArgs) Handles btncapnhat.Click
        If codulieu() Then
            Dim stram = New MemoryStream()
            Dim gt As String = ""
            Dim stu = New STUDENT()
            PictureBox1.Image.Save(stram, ImageFormat.Png)
            If radionam.Checked = True Then
                gt = radionam.Text
            End If
            If radionu.Checked = True Then
                gt = radionu.Text
            End If
            If stu.suathongtinhs(txtmahocsinh.Text, txttenhocsinh.Text, gt, dtpkngaysinh.Value(), txtdiachi.Text, stram.ToArray()) Then
                MsgBox("Cập nhật thành công", vbOKOnly + vbInformation, "Thông báo")
            Else
                MsgBox("Cập nhật không thành công", vbOKOnly + vbInformation, "Thông báo")
            End If


        Else
            MsgBox("Cập nhật thất bại, các trường phải có dữ liệu", vbOKOnly + vbInformation, "thông bấo")

        End If
    End Sub

    Private Sub btnloadanh_Click(sender As Object, e As EventArgs) Handles btnloadanh.Click
        Dim opf = New OpenFileDialog()
        'PictureBox1.Image = Image.FromFile("C:\Users\nguye\Desktop\StudentInformation\StudentInformation\no-image.png")
        opf.Filter = "Select image(*.png;*.jpg;*.gif)|*.png;*.jpg;*.gif"
        If opf.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim stu = New STUDENT()
        If MsgBox("Bạn muốn xóa học sinh này?", vbQuestion + vbYesNo, "Thông báo") = vbYes Then
            If stu.xoahocsinh(txtmahocsinh.Text) Then
                MsgBox("Bạn đã xóa thành công", vbOKOnly, "Thông báo")
                Me.Close()
            Else
                MsgBox("Xóa học sinh thất bại, vui lòng thử lại sau", vbOKOnly, "Thông báo")
            End If
        End If
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub
End Class