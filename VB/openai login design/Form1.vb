Public Class Form1
    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Guna2Panel1.Controls.Clear()
        Me.Guna2Panel1.Controls.Add(New UserControlLogin())
    End Sub
End Class
