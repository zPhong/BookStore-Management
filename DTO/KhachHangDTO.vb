
Namespace DTO

    Public Class KhachHangDTO
#Region "Declare"
        Private strMaKH As String
        Private strHoTen As String
        Private strDiaChi As String
        Private strDienThoai As String
        Private strEmail As String
        Private dobSoTienNo As String

        Property HoTen() As String
            Get
                Return strHoTen
            End Get
            Set(value As String)
                strHoTen = value
            End Set
        End Property




        Public Property MaKH() As String
            Get
                Return strMaKH
            End Get
            Set(value As String)
                strMaKH = value
            End Set
        End Property

        Public Property DiaChi() As String
            Get
                Return strDiaChi
            End Get
            Set(value As String)
                strDiaChi = value
            End Set
        End Property

        Public Property DienThoai() As String
            Get
                Return strDienThoai
            End Get
            Set(value As String)
                strDienThoai = value
            End Set
        End Property

        Public Property Email() As String
            Get
                Return strEmail
            End Get
            Set(value As String)
                strEmail = value
            End Set
        End Property

        Public Property SoTienNo() As String
            Get
                Return dobSoTienNo
            End Get
            Set(value As String)
                dobSoTienNo = value
            End Set
        End Property

#End Region

#Region "Function"
        Public Sub Create()
            strMaKH = ""
            strHoTen = ""
            strDiaChi = ""
            strDienThoai = ""
            strEmail = ""
            dobSoTienNo = 0
        End Sub

        Public Sub Create(ByVal makh As String, ByVal hoten As String, ByVal diachi As String, ByVal dienthoai As String, ByVal email As String, ByVal sotienno As Double)
            strMaKH = makh
            strHoTen = hoten
            strDiaChi = diachi
            strDienThoai = dienthoai
            strEmail = email
            dobSoTienNo = sotienno

        End Sub
#End Region
    End Class

End Namespace
