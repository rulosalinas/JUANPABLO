Public Class varanceles
    Dim idarancel, idcategoria As Integer
    Dim nombrearancel As String
    Dim precioarancel As Double


    Public Property gidarancel
        Get
            Return idarancel
        End Get
        Set(ByVal value)
            idarancel = value
        End Set
    End Property

    Public Property gidcategoria
        Get
            Return idcategoria
        End Get
        Set(ByVal value)
            idcategoria = value
        End Set
    End Property
    Public Property gnombrearancel
        Get
            Return nombrearancel
        End Get
        Set(ByVal value)
            nombrearancel = value
        End Set
    End Property

    Public Property gprecioarancel
        Get
            Return precioarancel
        End Get
        Set(ByVal value)
            precioarancel = value
        End Set
    End Property

    'constructores

    Public Sub New()

        End Sub

    Public Sub New(ByVal idarancel As Integer, ByVal idcategoria As Integer, ByVal nombrearancel As String, ByVal precioarancel As Double)
        gidarancel = idarancel
        gidcategoria = idcategoria
        gnombrearancel = nombrearancel
        gprecioarancel = precioarancel
    End Sub

End Class
