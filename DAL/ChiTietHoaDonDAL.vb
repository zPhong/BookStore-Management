Imports System
Imports DTO.DTO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Namespace DAL
    Public Class ChiTietHoaDonDAL

        Public Shared Function insertCTHoaDon(cthd As DTO.DTO.ChiTietPhieuHoaDon) As Integer
            Dim query As String = String.Empty
            query = String.Format("insert into chitiethoadon (machitiethoadon,mahoadon,masach,soluongban,dongiaban) values('{0}','{1}','{2}',{3},{4})", cthd.MaCTHD, cthd.MaHD, cthd.MaSach, cthd.SoLuongBan, cthd.DonGia)
            functionDAL.CreateConnect()
            Return functionDAL.ExecuteQuery(query)
        End Function



    End Class

End Namespace

