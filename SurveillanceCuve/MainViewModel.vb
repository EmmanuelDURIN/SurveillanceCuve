Imports System.Collections.ObjectModel

' Cette classe de View Model prépare et expose les données pour la MainWindow 
' à travers des propriétés - qui émettent des événements lorsqu'elles sont modifiées.
Public Class MainViewModel : Inherits BindableBase
    Private _cuveSélectionnée As Cuve
    Public Property CuveSélectionnée() As Cuve
        Get
            Return _cuveSélectionnée
        End Get
        Set(ByVal value As Cuve)
            _cuveSélectionnée = value
            OnPropertyChanged()
        End Set
    End Property

    Private _cuves As New ObservableCollection(Of Cuve)
    Public Property Cuves() As ObservableCollection(Of Cuve)
        Get
            Return _cuves
        End Get
        Set(ByVal value As ObservableCollection(Of Cuve))
            _cuves = value
            OnPropertyChanged()
        End Set
    End Property

    Sub New()
        Cuves.Add(New Cuve(2000) With {.Produit = "Huile", .Niveau = 1000, .DateRemplissage = DateTime.Now.AddDays(-2)})
        Cuves.Add(New Cuve(3000) With {.Produit = "BioDiesel", .Niveau = 3000, .DateRemplissage = DateTime.Now.AddDays(-4)})
        Cuves.Add(New Cuve(4000) With {.Produit = "Eau", .Niveau = 500, .DateRemplissage = DateTime.Now.AddDays(-6)})
    End Sub
End Class
