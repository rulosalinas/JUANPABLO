Public Class vbecas
    Dim idbeca, idalu As Integer
    Dim iniciobeca, finbeca As Date
    Dim porcentajebeca As Double
    Dim resolucionbeca, estadobeca As String
    Public Property gidbeca
        Get
            Return idbeca
        End Get
        Set(ByVal value)
            idbeca = value
        End Set
    End Property

    Public Property gidalumno
        Get
            Return idalu
        End Get
        Set(ByVal value)
            idalu = value
        End Set
    End Property
    Public Property giniciobeca
        Get
            Return iniciobeca
        End Get
        Set(ByVal value)
            iniciobeca = value
        End Set
    End Property
    Public Property gfinbeca
        Get
            Return finbeca
        End Get
        Set(ByVal value)
            finbeca = value
        End Set
    End Property
    Public Property gporcentajebeca
        Get
            Return porcentajebeca
        End Get
        Set(ByVal value)
            porcentajebeca = value
        End Set
    End Property
    Public Property gresolucionbeca
        Get
            Return resolucionbeca
        End Get
        Set(ByVal value)
            resolucionbeca = value
        End Set
    End Property
    Public Property gestadobeca
        Get
            Return estadobeca
        End Get
        Set(ByVal value)
            estadobeca = value
        End Set
    End Property

    'constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal idbeca As Integer, ByVal idalu As Integer, ByVal iniciobeca As Date, ByVal finbeca As Date, ByVal porcentajebeca As Double, ByVal resolucionbeca As String, ByVal estadobeca As String)
        gidbeca = idbeca
        gidalumno = idalu
        giniciobeca = iniciobeca
        gfinbeca = finbeca
        gporcentajebeca = porcentajebeca
        gresolucionbeca = resolucionbeca
        gestadobeca = estadobeca
    End Sub

End Class
