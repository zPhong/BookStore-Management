﻿Namespace DTO

    Public Class ThamSo

#Region "Declare"

        Private intSoLuongNhapMin As Integer
        Private intSoLuongTonMax As Integer ' ko nhap them dc neu vuot
        Private intSoLuongTonMin As Integer ' ban ra con it nhat
        Private intTienNoMax As Integer
        Property SoLuongNhapMin() As Integer
            Get
                Return intSoLuongNhapMin
            End Get
            Set(value As Integer)
                intSoLuongNhapMin = value
            End Set
        End Property

        Property SoLuongTonMax() As Integer
            Get
                Return intSoLuongTonMax
            End Get
            Set(value As Integer)
                intSoLuongTonMax = value
            End Set
        End Property

        Property SoLuongTonMin() As Integer
            Get
                Return intSoLuongTonMin
            End Get
            Set(value As Integer)
                intSoLuongTonMin = value
            End Set
        End Property

        Property TienNoMax() As Integer
            Get
                Return intTienNoMax
            End Get
            Set(value As Integer)
                intTienNoMax = value
            End Set
        End Property
#End Region


#Region "Function"
        Public Sub Create()
            intSoLuongNhapMin = 150
            intSoLuongTonMax = 300
            intSoLuongTonMin = 20
            intTienNoMax = 20000
        End Sub

        Public Sub Create(ByVal soluongnhapmax As Integer, ByVal soluongtonmax As Integer, ByVal soluongtonmin As Integer, ByVal tiennomax As Integer)
            intSoLuongNhapMin = soluongnhapmax
            intSoLuongTonMax = soluongtonmax
            intSoLuongTonMin = soluongtonmin
            intTienNoMax = tiennomax
        End Sub

#End Region

    End Class
End Namespace