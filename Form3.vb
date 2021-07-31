Public Class Form3
    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick
        If Panel4.Visible = True And Panel5.Visible = True Or Panel6.Visible = True Then
            Panel4.Visible = False
            Panel5.Visible = False
            Panel6.Visible = False
            Panel8.Visible = False
        Else
            Panel4.Visible = True
            Panel5.Visible = True
        End If
    End Sub

    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel2.MouseClick
        If Panel6.Visible = True Or Panel4.Visible = True And Panel5.Visible = True Then
            Panel4.Visible = False
            Panel5.Visible = False
            Panel6.Visible = False
            Panel8.Visible = False
            AxAcroPDF1.Visible = False

        Else
            Panel6.Visible = True
        End If
    End Sub

    Private Sub Panel3_MouseClick_1(sender As Object, e As MouseEventArgs) Handles Panel3.MouseClick
        If Panel8.Visible = True Or Panel4.Visible = True And Panel5.Visible = True Then
            Panel4.Visible = False
            Panel5.Visible = False
            Panel8.Visible = False
        Else
            Panel4.Visible = True
            Panel5.Visible = True
            Panel8.Visible = True
            Panel6.Visible = False
            AxAcroPDF1.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OpenFileDialog1.Filter = "PDF FILES | *.pdf"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            AxAcroPDF1.src = OpenFileDialog1.FileName
            AxAcroPDF1.Visible = True
        End If

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        PictureBox4.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Por el momento no hay más funciones.", MsgBoxStyle.Critical)
    End Sub
End Class