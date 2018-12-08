
Imports System
Imports DTO.DTO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms



Namespace DAL
    Public Class ChiTietPhieuNhapDAL


        Public Shared Function insertChiTietPhieuNhapSach(ctpn As CTPhieuNhapDTO) As Integer
            Dim query As String = String.Empty
            query = String.Format("insert into chitietphieunhap(machitietphieunhap,maphieunhap,masach,soluongnhap) values('{0}','{1}','{2}',{3})", ctpn.MaCTPhieuNhap, ctpn.MaPhieuNhapSach, ctpn.MaSach, ctpn.SoLuongNhap)
            functionDAL.CreateConnect()
            Return functionDAL.ExecuteQuery(query)
        End Function

    End Class

End Namespace
