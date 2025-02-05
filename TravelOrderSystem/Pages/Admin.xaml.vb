Public Class Admin

    Private Sub Mainform_FormClosed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Current.Shutdown()
    End Sub
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        ShowMainWindow()
    End Sub
    Private Sub ShowMainWindow()
        Dim mainWindow As New MainWindow()
        mainWindow.Show()

        Me.Hide()
    End Sub
End Class
