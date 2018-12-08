Imports DTO.DTO.SachDTO


Namespace BUS
    Public Class SachBUS

        Public Function isValil_SoLuongTonNhap(sa As DTO.DTO.SachDTO, ts As DTO.DTO.ThamSoDTO) As Boolean
            If (sa.SoLuongTon <= ts.SoLuongTonMax) Then
                Return True
            End If
            Return False
        End Function

        Public Function isValil_SoLuongTonBan(sa As DTO.DTO.SachDTO, ts As DTO.DTO.ThamSoDTO) As Boolean
            If (sa.SoLuongTon >= ts.SoLuongTonMin) Then
                Return True
            End If
            Return False
        End Function

        Public Shared Sub insertSach(sa As DTO.DTO.SachDTO)
            DAL.DAL.SachDAL.insertSach(sa)
        End Sub
        Public Shared Sub updateSach(sa As DTO.DTO.SachDTO)
            DAL.DAL.SachDAL.updateSach(sa)
        End Sub


    End Class
End Namespace
