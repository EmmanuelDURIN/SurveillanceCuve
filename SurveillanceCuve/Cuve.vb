Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class Cuve : Implements INotifyPropertyChanged

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Protected Sub OnPropertyChanged(<CallerMemberName> Optional propName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propName))
    End Sub

    Private _niveau As Double

    'Déclaration de propriété
    Public Property Niveau() As Double
        Get
            ' Récursion infinie
            'Return Niveau
            Return _niveau
        End Get
        Set(ByVal value As Double)
            If _niveau > _VolumeMax Then
                _niveau = _VolumeMax
            Else
                _niveau = value
            End If
            OnPropertyChanged()
        End Set
    End Property
    Private _produit As String
    Public Property Produit() As String
        Get
            Return _produit
        End Get
        Set(ByVal value As String)
            _produit = value
            OnPropertyChanged()
        End Set
    End Property
    Private _poids As Double
    Public Property Poids() As Double
        Get
            Return _poids
        End Get
        Set(ByVal value As Double)
            _poids = value
            OnPropertyChanged()
        End Set
    End Property
    Private _volumeMax As Double
    Public Property VolumeMax() As Double
        Get
            Return _volumeMax
        End Get
        Set(ByVal value As Double)
            _volumeMax = value
            OnPropertyChanged()
        End Set
    End Property
    Private _dateRemplissage As DateTime
    Public Property DateRemplissage() As DateTime
        Get
            Return _dateRemplissage
        End Get
        Set(ByVal value As DateTime)
            _dateRemplissage = value
            OnPropertyChanged()
        End Set
    End Property

    'Creation d'un constructeur
    Sub New(volumemax As Double)
        Me.VolumeMax = volumemax
    End Sub
End Class