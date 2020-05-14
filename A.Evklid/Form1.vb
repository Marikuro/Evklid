Public Class Form1
    Dim _a As Integer
    Dim _b As Integer
    Dim _c As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Try
                _a = Integer.Parse(TextBox1.Text)
            Catch ex As Exception
                MsgBox("Enter an integer")
                Throw ex
            End Try
            Try
                _b = Integer.Parse(TextBox2.Text)
            Catch ex As Exception
                MsgBox("Enter an integer")
                Throw ex
            End Try
        Catch ex As Exception
            Return
        End Try
        Evklid()
        TextBox3.Text = _c.ToString
    End Sub

    Private Sub Evklid()
        Do While _a <> 0 And _b <> 0
            If _a > _b Then
                _a = _a Mod _b
            Else
                _b = _b Mod _a
            End If
        Loop
        _c = _a + _b
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
End Class