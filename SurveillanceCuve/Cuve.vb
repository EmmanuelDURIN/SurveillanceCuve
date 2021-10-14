Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class Cuve : Inherits BindableBase
    Private _niveau As Double
    Private _produit As String
    Private _poids As Double
    Private _volumeMax As Double
    Private _dateRemplissage As Date

    Public ReadOnly Property NiveauRelatif() As Double
        Get
            Return _niveau / _volumeMax
        End Get
    End Property
    'Déclaration de propriété
    Public Property Niveau() As Double
        Get
            ' Récursion infinie
            'Return Niveau
            Return _niveau
        End Get
        Set(ByVal value As Double)
            If _niveau > _volumeMax Then
                _niveau = _volumeMax
            Else
                _niveau = value
            End If
            OnPropertyChanged()
            OnPropertyChanged(NameOf(NiveauRelatif))
        End Set
    End Property
    Public Property Produit() As String
        Get
            Return _produit
        End Get
        Set(ByVal value As String)
            _produit = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property Poids() As Double
        Get
            Return _poids
        End Get
        Set(ByVal value As Double)
            _poids = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property VolumeMax() As Double
        Get
            Return _volumeMax
        End Get
        Set(ByVal value As Double)
            _volumeMax = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property DateRemplissage() As Date
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
