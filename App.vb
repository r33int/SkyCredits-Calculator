Public Class App
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.FavouritePlan = 0
        My.Settings.ResetDay = 0
        My.Settings.SkyCredits = 0
        My.Settings.IsSetup = False
        Setup.Show()
        Me.Close()
    End Sub

    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = My.Settings.SkyCredits
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dialog1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Record.Show()
    End Sub
End Class