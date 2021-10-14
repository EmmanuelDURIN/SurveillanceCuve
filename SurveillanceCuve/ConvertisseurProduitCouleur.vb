Imports System.Globalization

Public Class ConvertisseurProduitCouleur : Implements IValueConverter
    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
        Dim produit As String = CStr(value)
        Select Case produit
            Case "Huile"
                Return New SolidColorBrush(Color.FromRgb(255, 255, 0))
            Case "BioDiesel"
                Return New SolidColorBrush(Color.FromRgb(155, 155, 30))
            Case Else
                Return New SolidColorBrush(Color.FromRgb(0, 0, 255))
        End Select
    End Function
    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Return Nothing
    End Function
End Class


