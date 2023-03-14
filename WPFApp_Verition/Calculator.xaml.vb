Public Class Calculator
    Property Result As String
    Property FinalResult As Decimal = 0D
    Property OperatorND As String
    Private Sub btn_Click(sender As Object, e As RoutedEventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click,
                                                                          btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click,
                                                                          btneq.Click, btnp.Click, btnm.Click, btnx.Click, btnd.Click, btndt.Click

        ''Get the button value
        Result = DirectCast(sender, Button).Content

        ''If the value is of operator then do the below activities
        Select Case Result
            Case "="
                Select Case OperatorND
                    Case "+"
                        FinalResult = CInt(txtResult.Text) + FinalResult
                    Case "-"
                        FinalResult = FinalResult - CInt(txtResult.Text)
                    Case "/"
                        FinalResult = FinalResult / CInt(txtResult.Text)
                    Case "*"
                        FinalResult = CInt(txtResult.Text) * FinalResult
                End Select
                OperatorND = ""
                txtResult.Text = FinalResult
            Case "+"
                OperatorND = "+"
                FinalResult = txtResult.Text
                txtResult.Text = ""
            Case "-"
                OperatorND = "-"
                FinalResult = txtResult.Text
                txtResult.Text = ""
            Case "/"
                OperatorND = "/"
                FinalResult = txtResult.Text
                txtResult.Text = ""
            Case "x"
                OperatorND = "*"
                FinalResult = txtResult.Text
                txtResult.Text = ""
        End Select
        If IsNumeric(Result) Then txtResult.Text &= Result
    End Sub
End Class
