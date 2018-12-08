
Imports System
Imports DTO.DTO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Globalization

Namespace DAL
    Public Class HoaDonDAL



        Public Shared Function insertHoaDon(hd As DTO.DTO.PhieuHoaDon) As Integer
            Dim query As String = String.Empty
            query = String.Format("insert into hoadon (mahoadon,makhachhang,ngaylap) values('{0}','{1}',{2})", hd.MaHD, hd.MaKH, DateTime.ParseExact(hd.NgayLapHoaDon.ToShortDateString, "dd/MM/yyyy", New CultureInfo("")).ToShortDateString)
            functionDAL.CreateConnect()
            Return functionDAL.ExecuteQuery(query)
        End Function

        Public Shared Function deleteHoaDon(hd As DTO.DTO.PhieuHoaDon) As Integer
            Dim query As String = String.Empty
            query = String.Format("DELETE FROM hoadon WHERE mahoadon='{0}'", hd.MaHD)
            functionDAL.CreateConnect()
            Return functionDAL.ExecuteQuery(query)
        End Function

    End Class

End Namespace

