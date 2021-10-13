Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim window As New WindowCuve()

        Dim result As Boolean? = window.ShowDialog()
        If result = True Then
            ' l'utilisateur a appuyé sur Ok
        End If
    End Sub
End Class
