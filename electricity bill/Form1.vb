Imports System.Linq.Expressions

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If (ComboBox1.SelectedItem = "DOMESTIC") Then

                Dim x As Integer
                Dim y As Integer
                Dim z As Integer
                Dim w As Integer


                TU.Text = TextBox2.Text - TextBox1.Text
                If TU.Text <= 100 Then
                    amt.Text = 0

                ElseIf TU.Text <= 200 Then
                    x = TU.Text - 100
                    amt.Text = (0 + x * 1.5)

                ElseIf TU.Text <= 500 Then
                    x = 100 * 1.5
                    y = 100 * 2
                    z = TU.Text - 200
                    amt.Text = ((x + y + z * 3) - x) + 30

                ElseIf TU.Text > 500 Then
                    x = 100 * 1.5
                    y = 100 * 3.5
                    z = 300 * 4.6
                    w = TU.Text - 500
                    amt.Text = ((x + y + z + w * 6.6) - x) + 50

                End If

            End If
            If ComboBox1.SelectedItem = "COMMERCIAL" Then
                Dim c As Integer
                TU.Text = TextBox2.Text - TextBox1.Text
                If TU.Text > 100 Then
                    c = TU.Text
                    amt.Text = c * 6.5
                End If

            End If
            If ComboBox1.SelectedItem = "INDUSTRIAL" Then
                Dim c As Integer
                TU.Text = TextBox2.Text - TextBox1.Text
                If TU.Text > 100 Then
                    c = TU.Text
                    amt.Text = c * 7.5
                End If
            End If
            MsgBox("TOTAL UNITS CONSUMED:" & TU.Text & vbCrLf & "TOTAL AMOUNT:" & amt.Text)

            TU.Clear()
                amt.Clear()

            Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try





    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
