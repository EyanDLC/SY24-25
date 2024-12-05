Class MainWindow
    Private Sub Fill1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Fill1.MouseDown, Fill2.MouseDown, Fill2.MouseDown, Fill3.MouseDown, Fill4.MouseDown, fill5.MouseDown, fill6.MouseDown, fill7.MouseDown, fill8.MouseDown
        Brush_one.Fill = sender.fill
    End Sub
End Class
