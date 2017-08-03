Public Module MyModule
    Dim UserType As String
    Public Property Users() As String
        Get
            Return UserType
        End Get
        Set(ByVal value As String)
            UserType = value
        End Set
    End Property
End Module
