Namespace BUS

    Public Class HoaDonBUS

        Public Shared Sub insertHoaDon(hd As DTO.DTO.PhieuHoaDon)
            DAL.DAL.HoaDonDAL.insertHoaDon(hd)
        End Sub


        Public Sub deleteHoaDon(hd As DTO.DTO.PhieuHoaDon)
            DAL.DAL.HoaDonDAL.deleteHoaDon(hd)
        End Sub

    End Class

End Namespace

