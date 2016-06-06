Public Class Book
    
    

    Private _Author As String
    Public Property Author As String
        Get
            Return _Author
        End Get
        Set(value As String)
            _Author = value
        End Set
    End Property

    Private _Title As String
    Public Property Title As String
        Get
            Return _Title
        End Get
        Set(value As String)
            _Title = value
        End Set
    End Property

    Private _Binding As binding
    Public Property Bound As binding
        Get
            Return _Binding
        End Get
        Set(value As binding)
            _Binding = value
        End Set
    End Property

    Private _Cover As String
    Public Property Cover As String
        Get
            Return _Cover
        End Get
        Set(value As String)
            _Cover = value
        End Set
    End Property


    Private _Price As Double
    Public Property Price As Double
        Get
            Return _Price
        End Get
        Set(value As Double)
            _Price = value
        End Set
    End Property
    Private _Qty As Integer
    Public Property Qty As Integer
        Get
            Return _Qty
        End Get
        Set(value As Integer)
            _Qty = value
        End Set
    End Property

    
    Public Overrides Function ToString() As String

        'Build Book String
        Return Author & " - " & Title & " - " & Cover & " - $" & Price & " - " & Qty & " copies in hand"
    End Function
End Class
