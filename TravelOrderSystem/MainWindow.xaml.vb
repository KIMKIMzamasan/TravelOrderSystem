Class MainWindow

    Private Sub MainWindow_FormClosed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Current.Shutdown()

    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        ShowAdminWindow()
    End Sub

    Private Sub ShowAdminWindow()
        Dim adminWindow As New Admin()
        adminWindow.Show()

        Me.Hide()
    End Sub
End Class
