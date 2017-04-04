Imports System.Windows.Forms

Public Class Record
    Public ChosenPlan As Integer
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If TrackBar1.Value = 0 Then
            If My.Settings.SkyCredits > 1 Then
                Cancel_Button.Enabled = False
                Button1.Enabled = True
                OK_Button.Enabled = False
                TrackBar1.Enabled = False
                ChosenPlan = 1
                Timer1.Interval = 60000 '60 seconds
                Timer1.Enabled = True
            Else
                MsgBox("You don't have enough SkyCredits !")
            End If
        ElseIf TrackBar1.Value = 1 Then
            If My.Settings.SkyCredits > 2 Then
                Cancel_Button.Enabled = False
                Button1.Enabled = True
                OK_Button.Enabled = False
                TrackBar1.Enabled = False
                ChosenPlan = 2
                Timer1.Interval = 60000 '60 seconds
                Timer1.Enabled = True
            Else
                MsgBox("You don't have enough SkyCredits !")
            End If
        ElseIf TrackBar1.Value = 2 Then
            If My.Settings.SkyCredits > 4 Then
                Cancel_Button.Enabled = False
                Button1.Enabled = True
                OK_Button.Enabled = False
                TrackBar1.Enabled = False
                ChosenPlan = 4
                Timer1.Interval = 60000 '60 seconds
                Timer1.Enabled = True
            Else
                MsgBox("You don't have enough SkyCredits !")
            End If
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Stop()
        TrackBar1.Enabled = True
        ChosenPlan = 0
        Cancel_Button.Enabled = True
        OK_Button.Enabled = True
        Button1.Enabled = False
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        If TrackBar1.Value = (0) Then
            Label7.Text = ("Gamer")
        ElseIf TrackBar1.Value = (1) Then
            Label7.Text = ("Pro")
        ElseIf TrackBar1.Value = (2) Then
            Label7.Text = ("Elite")
        End If
    End Sub

    Private Sub Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = My.Settings.SkyCredits
        TrackBar1.Value = My.Settings.FavouritePlan
        If TrackBar1.Value = (0) Then
            Label7.Text = ("Gamer")
        ElseIf TrackBar1.Value = (1) Then
            Label7.Text = ("Pro")
        ElseIf TrackBar1.Value = (2) Then
            Label7.Text = ("Elite")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Settings.SkyCredits > ChosenPlan Then
            My.Settings.SkyCredits -= ChosenPlan
            Label2.Text = My.Settings.SkyCredits
        Else
            MsgBox("You have used all your SkyCredits.")
            TrackBar1.Enabled = True
            ChosenPlan = 0
            Cancel_Button.Enabled = True
            OK_Button.Enabled = True
            Button1.Enabled = False
            Timer1.Stop()
        End If
    End Sub
End Class