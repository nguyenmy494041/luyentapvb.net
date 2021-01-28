Imports System.IO
Public Class STUDENT
    Function laymalop(ByVal tenlop As String) As String
        Dim context = New CSDLTRUONGHOCEntities()
        Return context.LopHocs.Where(Function(x) x.TenLopHoc = tenlop).FirstOrDefault().MaLopHoc.ToString()
    End Function

    Function laymakhoi(ByVal tenkhoi As String) As String
        Dim context = New CSDLTRUONGHOCEntities()
        Return context.KhoiLops.Where(Function(x) x.TenKhoiLop = tenkhoi).FirstOrDefault().MaKhoiLop.ToString()
    End Function

    Function danhsachlop() As List(Of LopHoc)
        Dim context = New CSDLTRUONGHOCEntities()
        Return context.LopHocs.ToList()
    End Function

    Function danhsachkhoilop() As List(Of KhoiLop)
        Dim context = New CSDLTRUONGHOCEntities()
        Return context.KhoiLops.ToList()
    End Function
    Function danhsachhocsinh() As List(Of HocSinh)
        Dim context = New CSDLTRUONGHOCEntities()
        Return context.HocSinhs.ToList()
    End Function

    Function themmoihocsinh(ByVal mhs As String, ByVal ths As String, ByVal gt As String, ByVal ns As Date, ByVal dc As String, ByVal pic As Byte(), ByVal ml As String) As Boolean
        If mhs <> "" AndAlso ths <> "" AndAlso gt <> "" AndAlso dc <> "" AndAlso ml <> "" Then
            Dim context = New CSDLTRUONGHOCEntities()
            Dim mahocsinh = context.HocSinhs.Find(mhs)
            If mahocsinh Is Nothing Then
                Dim hs = New HocSinh()
                hs.MaHocSinh = mhs
                hs.TenHocSinh = ths
                hs.DiaChi = dc
                hs.GioiTinh = gt
                hs.MaLopHoc = ml
                hs.HinhAnh = pic
                hs.NgaySinh = ns
                context.HocSinhs.Add(hs)
                context.SaveChanges()
                Return True
            Else
                Return False
            End If
            Return False
        End If
        Return False
    End Function

    Function suathongtinhs(ByVal mhs As String, ByVal ths As String, ByVal gt As String, ByVal ns As Date, ByVal dc As String, ByVal pic As Byte()) As Boolean
        If mhs <> "" AndAlso ths <> "" AndAlso gt <> "" AndAlso dc <> "" Then
            Dim context = New CSDLTRUONGHOCEntities()
            Dim mahocsinh = context.HocSinhs.Find(mhs)
            If mahocsinh IsNot Nothing Then
                mahocsinh.TenHocSinh = ths
                mahocsinh.DiaChi = dc
                mahocsinh.NgaySinh = ns
                mahocsinh.GioiTinh = gt
                mahocsinh.HinhAnh = pic
                context.SaveChanges()
                Return True
            Else
                Return False
            End If
        End If
        Return False
    End Function

    Function xoahocsinh(ByVal mhs As String) As Boolean
        Dim context = New CSDLTRUONGHOCEntities()
        Dim hs = context.HocSinhs.Find(mhs)
        If hs IsNot Nothing Then
            context.HocSinhs.Remove(hs)
            context.SaveChanges()
            Return True
        End If
        Return False
    End Function
End Class
