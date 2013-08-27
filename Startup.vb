Public Class Startup

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Interval = Timer1.Interval + 100
        If Timer1.Interval = 1000 Then
            Me.Hide()
            DBTool.Show()

        End If
    End Sub

    Private Sub Starup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class