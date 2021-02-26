Public Class vmovimientos
    Dim idmov, idcaja As Integer
    Dim fechamov, horamov As Date
    Dim montomov As Double
    Dim tipomov, descmov As String
    Public Property gidmov
        Get
            Return idmov
        End Get
        Set(ByVal value)
            idmov = value
        End Set
    End Property

    Public Property gidcaja
        Get
            Return idcaja
        End Get
        Set(ByVal value)
            idcaja = value
        End Set
    End Property
    Public Property gfechamov
        Get
            Return fechamov
        End Get
        Set(ByVal value)
            fechamov = value
        End Set
    End Property
    Public Property ghoramov
        Get
            Return horamov
        End Get
        Set(ByVal value)
            horamov = value
        End Set
    End Property
    Public Property gmontomov
        Get
            Return montomov
        End Get
        Set(ByVal value)
            montomov = value
        End Set
    End Property
    Public Property gtipomov
        Get
            Return tipomov
        End Get
        Set(ByVal value)
            tipomov = value
        End Set
    End Property
    Public Property gdescmov
        Get
            Return descmov
        End Get
        Set(ByVal value)
            descmov = value
        End Set
    End Property

    'constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal idmov As Integer, ByVal idcaja As Integer, ByVal fechamov As Date, ByVal horamov As Date, ByVal montomov As Double, ByVal tipomov As String, ByVal descmov As String)
        gidmov = idmov
        gidcaja = idcaja
        gfechamov = fechamov
        ghoramov = horamov
        gmontomov = montomov
        gtipomov = tipomov
        gdescmov = descmov
    End Sub
End Class
