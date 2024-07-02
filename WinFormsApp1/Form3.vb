Imports System.Net.Mail

Public Class Form3
    Dim orderedpizza As String = ""
    Dim qtyordered As String = ""
    Dim pizzaprice As String = ""
    Dim Gtotal As Decimal

    Public Sub calctotal()
        Gtotal = 0
        For x = 0 To 19
            Gtotal = Gtotal + Val(Form2.pizzaarray(x, 3))
        Next
        Gtotal += Form1.delivery
        lbltotal.Text = Gtotal.ToString("C")
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








        ' Lblpizza1.Text = Form2.pizzaarray(0, 0)
        ' lblpizza2.Text = Form2.pizzaarray(1, 0)
        ' lblpizza3.Text = Form2.pizzaarray(2, 0)
        'lblpizza4.Text = Form2.pizzaarray(3, 0)
        'Lblpizza5.Text = Form2.pizzaarray(4, 0)
        'Lblpizza6.Text = Form2.pizzaarray(5, 0)
        ' Lblpizza7.Text = Form2.pizzaarray(6, 0)
        'Lblpizza8.Text = Form2.pizzaarray(7, 0)
        ' Lblpizza9.Text = Form2.pizzaarray(8, 0)
        ' Lblpizza10.Text = Form2.pizzaarray(9, 0)
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

    Public Sub lbltotal_Click(sender As Object, e As EventArgs) Handles lbltotal.Click
        '   For x = 0 To 19
        '  Form2.pizzaarray(1, 3) = Val(Form2.pizzaarray(x, 1)).ToString("C") * Val(Form2.pizzaarray(x, 2)).ToString("C")
        '   Next
        '  lbltotal.Text = Val(Form2.pizzaarray(1, 3)).ToString("C")
    End Sub
End Class