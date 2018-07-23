Public Class Form1
    Private Sub hsbRed_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbRed.Scroll
        lblRed.Text = hsbRed.Value
    End Sub
End Class
