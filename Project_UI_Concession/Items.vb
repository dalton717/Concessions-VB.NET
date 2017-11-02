Public Class Item


    Private sProduct As String
    Private iQuanity As Integer
    Private sDrinkProperty As String



    'Get Methods
    Public Function GET_Product()
        Return sProduct
    End Function
    Public Function GET_iQuanity()
        Return iQuanity
    End Function
    Public Function GET_sDrinkProperty()
        Return sDrinkProperty
    End Function

    'Set Methods
    Public Function SET_Product(value As String)
        sProduct = value
        Return sProduct
    End Function
    Public Function SET_iQuanity(value As Integer)
        iQuanity = value
        Return iQuanity
    End Function
    Public Function SET_sDrinkProperty(value As String)
        sDrinkProperty = value
        Return sDrinkProperty
    End Function



End Class
