Imports System
Imports DTO.DTO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Namespace DAL
    Public Class KhachHangDAL


        Public Shared Function insertKhachHang(kh As KhachHangDTO) As Integer
            Dim query As String = String.Empty
            query = String.Format("insert into khachhang (makhachhang,hotenkhachhang,diachi,email,sodienthoai,tiennokhachhang) values('{0}','{1}','{2}','{3}','{4}',{5})", kh.MaKH, kh.HoTen, kh.DiaChi, kh.Email, kh.DienThoai, kh.SoTienNo)
            functionDAL.CreateConnect()
            Return functionDAL.ExecuteQuery(query)
        End Function

        Public Function deleteKhachHang(kh As KhachHangDTO) As Integer
            Dim query As String = String.Empty
            query &= "DELTE FROM sach WHERE makhachhang="
            query &= kh.MaKH
            functionDAL.CreateConnect()
            Return functionDAL.ExecuteQuery(query)
        End Function

        Public Shared Function updateKhachHang(kh As KhachHangDTO) As Integer
            Dim query As String = String.Empty
            query = String.Format("UPDATE khachhang SET hotenkhachhang='{0}',diachi='{1}', email='{2}', sodienthoai={3},tiennokhachhang = {4} WHERE makhachhang='{5}'", kh.HoTen, kh.DiaChi, kh.Email, kh.DienThoai, kh.SoTienNo, kh.MaKH)
            functionDAL.CreateConnect()
            Return functionDAL.ExecuteQuery(query)
        End Function

        Public Shared Function updateTienNoKhachHang(kh As KhachHangDTO) As Integer
            Dim query As String = String.Empty
            query = String.Format("UPDATE khachhang SET tiennokhachhang = {0} WHERE makhachhang='{1}'", kh.SoTienNo, kh.MaKH)
            functionDAL.CreateConnect()
            Return functionDAL.ExecuteQuery(query)
        End Function



    End Class

End Namespace


