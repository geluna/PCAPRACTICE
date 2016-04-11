
Interface IPerson


    'Public _ethnicity As String
    'Public _height As Double
    'Public _weight As Integer
    'Public _experience As Integer
    'Public _firstName As String
    'Public _lastName As String

    Property FirstName() As String
    Get
        FirstName = _firstName
    End Get
    Set(ByVal Value As String)
        _firstName = Value
    End Set
End Property

Public Overridable Property LastName() As String
    Get
        LastName = _lastName
    End Get
    Set(ByVal Value As String)
        _lastName = Value
    End Set
End Property

Public Overridable Property Ethnicity() As String
    Get
        Ethnicity = _ethnicity
    End Get
    Set(ByVal Value As String)
        _ethnicity = Value
    End Set
End Property

Public Overridable Property Height() As Double
    Get
        Height = _height
    End Get
    Set(ByVal Value As Double)
        _height = Value
    End Set
End Property

Public Overridable Property Weight() As Integer
    Get
        Weight = _weight
    End Get
    Set(ByVal Value As Integer)
        _weight = Value
    End Set
End Property

Public Overridable Property Experience() As Integer
    Get
        Experience = _experience
    End Get
    Set(ByVal Value As Integer)
        _experience = Value
    End Set
End Property

End Interface


