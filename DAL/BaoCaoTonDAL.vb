Imports System
Imports DTO.DTO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Namespace DAL

    Public Class BaoCaoTonDAL

        Public Shared Function insertBaoCaoTon(bct As BaoCaoTonDTO) As Integer
            Dim query As String = String.Empty
            query = String.Format("insert into baocaoton(maton,masach,thang,tondau,tonphatsinh,toncuoi) values('{0}','{1}',{2},{3},{4},{5})", bct.MaTon, bct.MaSach, bct.Thang, bct.TonDau, bct.TonPhatSinh, bct.TonCuoi)
            functionDAL.CreateConnect()
            Return functionDAL.ExecuteQuery(query)
        End Function


        Public Function deleteBaoCaoTon(bct As BaoCaoTonDTO) As Integer
            Dim query As String = String.Empty
            query &= "DELTE FROM baocaoton WHERE maton="
            query &= bct.MaTon
            functionDAL.CreateConnect()
            Return functionDAL.ExecuteQuery(query)
        End Function

        Public Shared Function updateTon(bct As BaoCaoTonDTO) As Integer
            Dim query As String = String.Empty
            query = String.Format("UPDATE baocaoton SET tondau={0},tonphatsinh={1}, toncuoi={2} WHERE masach='{3}' AND thang={4}", bct.TonDau, bct.TonPhatSinh, bct.TonCuoi, bct.MaSach, bct.Thang)
            functionDAL.CreateConnect()
            Return functionDAL.ExecuteQuery(query)
        End Function

    End Class
End Namespace
