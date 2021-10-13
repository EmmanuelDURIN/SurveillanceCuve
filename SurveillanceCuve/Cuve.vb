Public Class Cuve

    Private _niveau As Double

    'Déclaration de propriété
    Public Property Niveau() As Double
        Get
            ' Récursion infinie
            'Return Niveau
            Return _niveau
        End Get
        Set(ByVal value As Double)
            If _niveau > _Volumemax Then
                _niveau = _Volumemax
            Else
                _niveau = value
            End If
        End Set
    End Property
    'Déclaration de propriete autoimplementée
    Public Property Produit As String
    Public Property Poids As Integer
    Public ReadOnly Property Volumemax As Integer
    Public Property DateRemplissage As DateTime

    'Creation d'un constructeur
    Sub New(volumemax As Double)
        Me.Volumemax = volumemax
    End Sub
End Class