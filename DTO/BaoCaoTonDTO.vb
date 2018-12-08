Namespace DTO
    Public Class BaoCaoTonDTO
#Region "Declare"
        Private strMaTon As String
        Private strMaSach As String
        Private intThang As Integer
        Private intTonDau As Integer
        Private intTonCuoi As Integer
        Private intTonPhatSinh As Integer

        Property MaTon As String
            Get
                Return strMaTon
            End Get
            Set(value As String)
                strMaTon = value
            End Set
        End Property
        Property MaSach As String
            Get
                Return strMaSach
            End Get
            Set(value As String)
                strMaSach = value
            End Set
        End Property

        Property Thang As Integer
            Get
                Return intThang
            End Get
            Set(value As Integer)
                intThang = value
            End Set
        End Property

        Property TonDau As Integer
            Get
                Return intTonDau
            End Get
            Set(value As Integer)
                intTonDau = value
            End Set
        End Property
        Property TonCuoi As Integer
            Get
                Return intTonCuoi
            End Get
            Set(value As Integer)
                intTonCuoi = value
            End Set
        End Property

        Property TonPhatSinh As Integer
            Get
                Return intTonPhatSinh
            End Get
            Set(value As Integer)
                intTonPhatSinh = value
            End Set
        End Property
#End Region

#Region "Function"

        Public Sub Create()
            strMaTon = ""
            strMaSach = ""
            intTonDau = 0
            intTonCuoi = 0
            intThang = 1
            intTonPhatSinh = 0
        End Sub
        'Public Sub Create(ByVal masach As String, ByVal tensach As String, ByVal theloai As String, ByVal tacgia As String, ByVal soluongton As Integer, ByVal dongia As Double)

        Public Sub Create(ByVal maton As String, masach As String, ByVal thang As Integer, ByVal tondau As Integer, ByVal tonphatsinh As Integer, ByVal toncuoi As Integer)
            strMaSach = masach
            strMaTon = maton
            intThang = thang
            intTonCuoi = toncuoi
            intTonDau = tondau
            intTonPhatSinh = tonphatsinh
            'dobDonGia = dongia
        End Sub
#End Region

    End Class

End Namespace