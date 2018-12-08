Namespace BUS
    Public Class BaoCaoCongNoBUS

        Public Shared Sub insertBaoCaoCongNo(bccn As DTO.DTO.BaoCaoCongNoDTO)
            DAL.DAL.BaoCaoCongNoDAL.insertBaoCaoCongNo(bccn)
        End Sub

        Public Shared Sub updateBaoCaoCongNo(bccn As DTO.DTO.BaoCaoCongNoDTO)
            DAL.DAL.BaoCaoCongNoDAL.updateCongNo(bccn)
        End Sub



    End Class
End Namespace
