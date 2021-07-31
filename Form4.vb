Public Class Form4
    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel2.MouseClick
        If Panel5.Visible = True And Panel6.Visible = True Then
            Panel5.Visible = False
            Panel6.Visible = False
            Panel7.Visible = False
        Else
            Panel6.Visible = True
            Panel5.Visible = True
            Panel7.Visible = False
        End If
    End Sub

    Private Sub Panel3_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel3.MouseClick
        If Panel7.Visible = True Then
            Panel7.Visible = False
            Panel5.Visible = False
            Panel6.Visible = False
            Panel14.Visible = False
        Else
            Panel7.Visible = True
            Panel5.Visible = False
            Panel6.Visible = False
            Panel14.Visible = False
        End If
    End Sub

    Private Sub Panel8_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel8.MouseClick
        If Panel11.Visible = True Then
            Panel11.Visible = False
        Else
            Panel11.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Se ha añadido correctamente.", MsgBoxStyle.Critical)
        Panel11.Visible = False
        Panel12.Visible = True
        Panel13.Visible = True
    End Sub

    Private Sub Panel4_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel4.MouseClick
        If Panel14.Visible = True Then
            Panel14.Visible = False
            Panel5.Visible = False
            Panel6.Visible = False
            Panel7.Visible = False
        Else
            Panel14.Visible = True
            Panel6.Visible = True
            Panel5.Visible = True
            Panel7.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Por el momento no hay más funciones.", MsgBoxStyle.Critical)
    End Sub
End Class