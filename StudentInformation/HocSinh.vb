'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class HocSinh
    Public Property MaHocSinh As String
    Public Property TenHocSinh As String
    Public Property NgaySinh As Date
    Public Property GioiTinh As String
    Public Property DiaChi As String
    Public Property MaLopHoc As String
    Public Property HinhAnh As Byte()

    Public Overridable Property BangDiems As ICollection(Of BangDiem) = New HashSet(Of BangDiem)
    Public Overridable Property LopHoc As LopHoc

End Class
