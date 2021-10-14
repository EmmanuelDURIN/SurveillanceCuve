Class MainWindow
    Private viewModel As New MainViewModel()

    Sub New()
        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        ' Le viewModel fournit les données du DataContext pour que le binding fonctionne
        DataContext = viewModel
    End Sub
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim window As New WindowCuve()

        Dim result As Boolean? = window.ShowDialog()
        If result = True Then
            ' l'utilisateur a appuyé sur Ok
            'window.Cuve
        End If
    End Sub
End Class
