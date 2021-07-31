Public Class Form2
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Administrador" And TextBox2.Text = "Administrador" Then
            Me.Hide()
            Form3.Show()
        Else
            If TextBox1.Text = "Almacenista" And TextBox2.Text = "Almacenista" Then
                Me.Hide()
                Form4.Show()
            Else
                If TextBox1.Text = "JefeUsuario" And TextBox2.Text = "JefeUsuario" Then
                    Me.Hide()
                    Form5.Show()
                Else
                    If TextBox1.Text = "Usuario" And TextBox2.Text = "Usuario" Then
                        Me.Hide()
                        Form6.Show()
                    Else
                        MsgBox("Datos ingresados incorrectos", MsgBoxStyle.Critical)
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            If CheckBox1.Checked = False Then
                TextBox2.UseSystemPasswordChar = True
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form7.Show()
    End Sub
End Class