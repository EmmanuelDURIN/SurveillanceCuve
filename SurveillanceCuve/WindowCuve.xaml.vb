Public Class WindowCuve
    Public Property Cuve() As Cuve = New Cuve(2000) With {.Niveau = 0, .Poids = 0, .Produit = "Huile Colza"}
    Sub New()
        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        ' La cuve est le contexte de données ambient
        Me.DataContext = Cuve
    End Sub
    Private Sub buttonOk_Click(sender As Object, e As RoutedEventArgs) Handles buttonOk.Click
        Me.DialogResult = True
    End Sub

    Private Sub buttonCancel_Click(sender As Object, e As RoutedEventArgs) Handles buttonCancel.Click
        Me.DialogResult = False
    End Sub
End Class
