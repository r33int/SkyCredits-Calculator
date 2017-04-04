Public Class Setup
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        If TrackBar1.Value = (0) Then
            Label7.Text = ("Gamer")
        ElseIf TrackBar1.Value = (1) Then
            Label7.Text = ("Pro")
        ElseIf TrackBar1.Value = (2) Then
            Label7.Text = ("Elite")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.FavouritePlan = TrackBar1.Value
        My.Settings.ResetDay = NumericUpDown1.Value
        My.Settings.SkyCredits = NumericUpDown2.Value
        My.Settings.IsSetup = True
        App.Show()
        Me.Close()
    End Sub

    Private Sub Setup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.IsSetup = True Then
            App.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class