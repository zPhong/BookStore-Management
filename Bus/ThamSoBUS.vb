Imports DTO.DTO.ThamSoDTO

Namespace BUS
    Public Class ThamSoBUS
        Public Shared Sub updateThamSo(ts As DTO.DTO.ThamSoDTO)
            DAL.DAL.ThamSoDAL.updateThamSo(ts)
        End Sub
    End Class
End Namespace
