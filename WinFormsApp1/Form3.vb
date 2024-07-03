Imports System.Net.Mail

Public Class Form3
    Dim orderedpizza As String = "" 'sets the feild as empty string
    Dim qtyordered As String = "" ' sets the feild as empty string
    Dim pizzaprice As String = "" ' sets the feild as empty string
    Dim Gtotal As Decimal ' sets the Gtotal as a decimal/value

    Public Sub calctotal()
        Gtotal = 0 'makes the total zero so the calculations are correct
        For x = 0 To 19
            Gtotal = Gtotal + Val(Form2.pizzaarray(x, 3)) 'takes the value of the calculated forms 
        Next
        Gtotal += Form1.delivery 'addes the delivery to the total
        lbltotal.Text = Gtotal.ToString("C") 'setsthe total text box to the value of the ototl
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        orderedpizza = ""
        qtyordered = ""
        pizzaprice = ""
        For x = 0 To 19
            If Form2.pizzaarray(x, 2) > 0 Then
                orderedpizza = orderedpizza & Form2.pizzaarray(x, 0) & vbCrLf
                pizzaprice = pizzaprice & Form2.pizzaarray(x, 1) & vbCrLf
                qtyordered = qtyordered & Form2.pizzaarray(x, 2) & vbCrLf
            End If
        Next

        lblpizzas.Text = orderedpizza
        lblprice.Text = pizzaprice
        lblQty.Text = qtyordered

        For x = 0 To 19
            Form2.pizzaarray(x, 3) = Val(Form2.pizzaarray(x, 1)) * Val(Form2.pizzaarray(x, 2))
            calctotal()
        Next

    End Sub

    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        End
    End Sub

    Private Sub Btnrestart_Click(sender As Object, e As EventArgs) Handles Btnrestart.Click
        Application.Restart()
    End Sub

    Private Sub Btnback1_Click(sender As Object, e As EventArgs) Handles Btnback1.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class