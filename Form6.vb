Public Class Form6
    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel2.MouseClick
        If Panel4.Visible = True Then
            Panel4.Visible = False
        Else
            Panel4.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel5.Visible = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Se ha creado su vale con éxito.", MsgBoxStyle.Critical)
        Panel5.Visible = False
        Panel4.Visible = False

    End Sub

    Private Sub FlowLayoutPanel1_MouseClick(sender As Object, e As MouseEventArgs) Handles FlowLayoutPanel1.MouseClick
        If Panel6.Visible = True Then
            Panel6.Visible = False
        Else
            Panel6.Visible = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Por el momento no hay más funciones.", MsgBoxStyle.Critical)
    End Sub

    Private Sub Panel3_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel3.MouseClick
        If Panel7.Visible = True Then
            Panel7.Visible = False
        Else
            Panel7.Visible = True
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class