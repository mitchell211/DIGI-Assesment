Imports System.IO
Imports System.Net.Mail
'Imports System.Net.Mime.MediaTypeNames
Imports System.Runtime.Intrinsics.X86
Imports System.Text
Imports System.Text.Json.Serialization
Imports System.Drawing.Printing
Public Class Form3
    Dim orderedpizza As String = "" 'sets the feild as empty string
    Dim qtyordered As String = "" ' sets the feild as empty string
    Dim pizzaprice As String = ""  ' sets the feild as empty string
    Dim Gtotal As Decimal ' sets the Gtotal as a decimal/value
    Dim all As String = ""
    Dim fileReader As String

    Public Sub calctotal()
        Gtotal = 0 'makes the total zero so the calculations are correct
        For x = 0 To 19
            Gtotal = Gtotal + Val(Form2.pizzaarray(x, 3)) 'takes the value of the calculated forms 
        Next
        Gtotal += Form1.delivery 'addes the delivery to the total
        lbltotal.Text = Gtotal.ToString("C") 'setsthe total text box to the value of the ototl

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        orderedpizza = "" 'resets the feild as empty string
        qtyordered = "" 'resets the feild as empty string
        pizzaprice = "" 'resets the feild as empty string 
        all = ""
        For x = 0 To 19
            Form2.pizzaarray(x, 3) = Val(Form2.pizzaarray(x, 1)) * Val(Form2.pizzaarray(x, 2))
            If Form2.pizzaarray(x, 2) > 0 Then
                orderedpizza = orderedpizza & Form2.pizzaarray(x, 0) & vbCrLf 'adds the names of the pizza into a text box that expands
                pizzaprice = pizzaprice & Val(Form2.pizzaarray(x, 3)).ToString("C") & vbCrLf 'adds the price of the pizza's into a text box that expands
                qtyordered = qtyordered & Form2.pizzaarray(x, 2) & vbCrLf 'adds the amount ordered into a text box that expands
            End If
        Next
        lblpizzas.Text = orderedpizza ' takes tthe above code and adds to text box
        lblprice.Text = pizzaprice 'takes the above code and adds to text box
        lblQty.Text = qtyordered ' takes above code and adds to text box

        For x = 0 To 19

            Form2.pizzaarray(x, 3) = Val(Form2.pizzaarray(x, 1)) * Val(Form2.pizzaarray(x, 2)) 'adds the prices of everyything together and calculates the total
            calctotal()

        Next
        all = "All listed below are in order

" + "Pizza
" & orderedpizza + "
" + "Pizza price
" + pizzaprice + "
" + "Amount Ordered
" + qtyordered + " 
" + "Delivery
" & Form1.delivery
        My.Computer.FileSystem.WriteAllText("c:\order summary\orders.text", all, True)
        fileReader = My.Computer.FileSystem.ReadAllText("c:\order summary\orders.text")
        MsgBox(fileReader)

    End Sub

    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        End ' when X button pressed then applacation ends and has to be reopened
    End Sub

    Private Sub Btnrestart_Click(sender As Object, e As EventArgs) Handles Btnrestart.Click
        Application.Restart() ' when restart button is clicked then it goes back to the first form and everything is reset


    End Sub

    Private Sub Btnback1_Click(sender As Object, e As EventArgs) Handles Btnback1.Click
        Form2.Show() 'when back is clicked it shows form two
        Me.Close() ' when back is clicked than this form closes
    End Sub

    Private Sub BtnContinue1_Click(sender As Object, e As EventArgs) Handles BtnContinue1.Click
        'This handles print preview and has the advantage of being able to  

        'print as well. However, it still needs the code above to generate the layout.  

        PrintPreviewDialog1.Document = PrintDocument1

        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocumentl_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'these lines are the important ones, they print the actual required info"
        Dim font1 As New Font("arial", 16, FontStyle.Regular) 'define the printing style  
        Dim font2 As New Font("times new roman", 18, FontStyle.Regular)


        If Form1.delivery > 0 Then
            e.Graphics.DrawString(Form1.Txtaddress.Text, font1, Brushes.Black, 100, 100)
        End If
        'across, down
        e.Graphics.DrawString(lblpizzas.Text, font1, Brushes.Black, 100, 175)
        e.Graphics.DrawString(Label1.Text, font2, Brushes.Cornsilk, 325, 25) 'should be fairly easy to work out the different parts,
        e.Graphics.DrawString(lblprice.Text, font1, Brushes.Black, 350, 175)
        e.Graphics.DrawString(lblQty.Text, font1, Brushes.Black, 450, 175)
        e.Graphics.DrawString(Form1.Txtname.Text, font1, Brushes.Black, 100, 60)
        e.Graphics.DrawString(Form1.mtbphone.Text, font1, Brushes.Black, 100, 80)
    End Sub


    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub
End Class