Namespace DTO
    Public Class BaoCaoCongNoDTO
        Dim strMaCongNo As String
        Dim strMaKhachHang As String
        Dim intThang As Integer
        Dim intNoDau As Integer
        Dim intNoPhatSinh As Integer
        Dim intNoCuoi As Integer

        Public Property MaCongNo
            Get
                Return strMaCongNo
            End Get
            Set(value)
                strMaCongNo = value
            End Set
        End Property

        Public Property MaKhachHang
            Get
                Return strMaKhachHang
            End Get
            Set(value)
                strMaKhachHang = value
            End Set
        End Property

        Public Property NoDau
            Get
                Return intNoDau
            End Get
            Set(value)
                intNoDau = value
            End Set
        End Property

        Public Property NoPhatSinh
            Get
                Return intNoPhatSinh
            End Get
            Set(value)
                intNoPhatSinh = value
            End Set
        End Property

        Public Property NoCuoi
            Get
                Return intNoCuoi
            End Get
            Set(value)
                intNoCuoi = value
            End Set
        End Property

        Public Property Thang
            Get
                Return intThang
            End Get
            Set(value)
                intThang = value
            End Set
        End Property

        Public Sub Create()
            MaCongNo = ""
            MaKhachHang = ""
            Thang = Today.Month
            NoDau = 0
            NoPhatSinh = 0
            NoCuoi = 0
        End Sub

        Public Sub Create(ByVal macongno As String, ByVal makhachhang As String, ByVal thang As Integer, ByVal nodau As Integer, ByVal nophatsinh As Integer, ByVal nocuoi As Integer)
            strMaCongNo = macongno
            strMaKhachHang = makhachhang
            intThang = thang
            intNoDau = nodau
            intNoPhatSinh = nophatsinh
            intNoCuoi = nocuoi
        End Sub


    End Class
End Namespace
