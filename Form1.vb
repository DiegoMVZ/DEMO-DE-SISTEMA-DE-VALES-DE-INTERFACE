Imports System.ComponentModel

Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 10
            Label2.Text = ProgressBar1.Value & " %"
        Else
            Timer1.Enabled = False
            Me.Hide()
            Form2.Show()

        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class
