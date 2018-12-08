Namespace BUS

    Public Class BaoCaoTonBUS
        Public Shared Sub insertBaoCaoTon(bct As DTO.DTO.BaoCaoTonDTO)
            DAL.DAL.BaoCaoTonDAL.insertBaoCaoTon(bct)
        End Sub

        Public Shared Sub updateBaoCaoTon(bct As DTO.DTO.BaoCaoTonDTO)
            DAL.DAL.BaoCaoTonDAL.updateTon(bct)
        End Sub

    End Class
End Namespace