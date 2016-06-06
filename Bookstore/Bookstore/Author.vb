Public Structure Author
    Private _FName As String

    Private _LName As String

    Public Property FName As String
        Get
            Return _FName
        End Get
        Set(value As String)
            _FName = value
        End Set
    End Property

    Public Property LName As String
        Get
            Return _LName
        End Get
        Set(value As String)
            _LName = value
        End Set
    End Property


    Public ReadOnly Property Name As String
        Get
            Return FName & " " & LName
        End Get
    End Property

End Structure
