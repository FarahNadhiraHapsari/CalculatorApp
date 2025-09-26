Public Class Form1
    Dim firstNum As Double
    Dim secondNum As Double
    Dim operation As String

    Private Sub btnNumber_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click,
        btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        ' Ambil text dari tombol angka yang ditekan
        Dim btn As Button = CType(sender, Button)
        txtDisplay.Text &= btn.Text
    End Sub

    Private Sub btnOperator_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, btnSub.Click, btnMul.Click, btnDiv.Click
        Dim btn As Button = CType(sender, Button)
        firstNum = Val(txtDisplay.Text)
        operation = btn.Text
        txtDisplay.Clear()
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        secondNum = Val(txtDisplay.Text)
        Select Case operation
            Case "+"
                txtDisplay.Text = (firstNum + secondNum).ToString()
            Case "-"
                txtDisplay.Text = (firstNum - secondNum).ToString()
            Case "×"
                txtDisplay.Text = (firstNum * secondNum).ToString()
            Case "÷"
                If secondNum = 0 Then
                    txtDisplay.Text = "Error"
                Else
                    txtDisplay.Text = (firstNum / secondNum).ToString()
                End If
        End Select
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Clear()
        firstNum = 0
        secondNum = 0
        operation = ""
    End Sub
End Class
