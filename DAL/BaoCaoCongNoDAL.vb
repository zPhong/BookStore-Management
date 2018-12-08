Imports System
Imports DTO.DTO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Namespace DAL

    Public Class BaoCaoCongNoDAL

        Public Shared Function insertBaoCaoCongNo(bccn As BaoCaoCongNoDTO) As Integer
            Dim query As String = String.Empty
            query = String.Format("insert into baocaocongno(macongno,makhachhang,thang,nodau,nophatsinh,nocuoi) values('{0}','{1}',{2},{3},{4},{5})", bccn.MaCongNo, bccn.MaKhachHang, bccn.Thang, bccn.NoDau, bccn.NoPhatSinh, bccn.NoCuoi)
            functionDAL.CreateConnect()
            Return functionDAL.ExecuteQuery(query)
        End Function


        Public Function deleteBaoCaoCongNo(bccn As BaoCaoCongNoDTO) As Integer
            Dim query As String = String.Empty
            query &= "DELTE FROM baocaocongno WHERE macongno="
            query &= bccn.MaCongNo
            functionDAL.CreateConnect()
            Return functionDAL.ExecuteQuery(query)
        End Function

        Public Shared Function updateCongNo(bccn As BaoCaoCongNoDTO) As Integer
            Dim query As String = String.Empty
            query = String.Format("UPDATE baocaocongno SET nodau={0},nophatsinh={1}, nocuoi={2} WHERE makhachhang='{3}' AND thang={4}", bccn.NoDau, bccn.NoPhatSinh, bccn.NoCuoi, bccn.MaKhachHang, bccn.Thang)
            functionDAL.CreateConnect()
            Return functionDAL.ExecuteQuery(query)
        End Function

    End Class

End Namespace
