Public Class Form1
    Dim assign_input As Double = 0
    Dim operation As String
    Dim found_expression As Boolean = False
    Dim fristnm, secondnum, q As String

    Private Sub cmdClrCur_Click(sender As Object, e As EventArgs) Handles cmdClrCur.Click
        TxtAns.Text = "0"

    End Sub

    Private Sub cmdClr_Click(sender As Object, e As EventArgs) Handles cmdClr.Click
        TxtAns.Text = "0"
        lblEqu.Text = ""
        assign_input = "0"
        operation = ""

    End Sub

    Private Sub operation_Click(sender As Object, e As EventArgs) Handles cmdSub.Click, cmdMul.Click, cmdDiv.Click, cmdAdd.Click
        Dim b As Button = sender
        If (assign_input <> 0) Then
            cmdEqu.PerformClick()
            found_expression = True
            operation = b.Text
            lblEqu.Text = assign_input & "    " & operation
        Else
            operation = b.Text
            assign_input = Double.Parse(TxtAns.Text)
            found_expression = True
            lblEqu.Text = assign_input & "    " & operation
        End If
    End Sub

    Private Sub Numbers_Click(sender As Object, e As EventArgs) Handles cmd9.Click, cmd8.Click, cmd7.Click, cmd6.Click, cmd5.Click, cmd4.Click, cmd3.Click, cmd2.Click, cmd1.Click, cmd0.Click, cmdDot.Click
        Dim b As Button = sender
        If ((TxtAns.Text = "0") Or (found_expression)) Then
            TxtAns.Clear()
            TxtAns.Text = b.Text
            found_expression = False
        ElseIf (b.Text = ".") Then
            If (Not TxtAns.Text.Contains(".")) Then
                TxtAns.Text = TxtAns.Text + b.Text
            End If
        Else
            TxtAns.Text = TxtAns.Text + b.Text
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    
  
    
    Private Sub cmdEqu_Click(sender As Object, e As EventArgs) Handles cmdEqu.Click
        lblEqu.Text = ""
        Select Case operation
            Case "+"
                TxtAns.Text = (assign_input + Double.Parse(TxtAns.Text)).ToString()

            Case "-"
                TxtAns.Text = (assign_input - Double.Parse(TxtAns.Text)).ToString()

            Case "*"
                TxtAns.Text = (assign_input * Double.Parse(TxtAns.Text)).ToString()

            Case "/"
                TxtAns.Text = (assign_input / Double.Parse(TxtAns.Text)).ToString()

        End Select
        assign_input = Double.Parse(TxtAns.Text)
        operation = ""
    End Sub
End Class
