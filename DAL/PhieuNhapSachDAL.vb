
Imports System
Imports DTO.DTO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Globalization



Namespace DAL
    Public Class PhieuNhapSachDAL


        Public Shared Function insertPhieuNhapSach(pn As PhieuNhapSachDTO) As Integer
            Dim query As String = String.Empty
            Dim provider As CultureInfo = CultureInfo.InvariantCulture

            query = String.Format("insert into phieunhapsach (maphieunhap,ngaynhap) values('{0}',{1})", pn.MaPhieuNhapSach, DateTime.ParseExact(pn.NgayNhap.ToShortDateString, "dd/MM/yyyy", provider).ToShortDateString)
            functionDAL.CreateConnect()
            Return functionDAL.ExecuteQuery(query)
        End Function

        Public Shared Function deletePhieuNhapSach(pn As PhieuNhapSachDTO) As Integer
            Dim query As String = String.Empty
            query = String.Format("DELETE FROM phieunhapsach WHERE maphieunhap='{0}'", pn.MaPhieuNhapSach)
            functionDAL.CreateConnect()
            Return functionDAL.ExecuteQuery(query)
        End Function


    End Class

End Namespace
