Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Imports System.Text

Public Class Form2
    Public Const REGULARPRICE As Decimal = 8.5 ' sets the regular price to $8.5
    Public Const GOURMETPREMIUM As Decimal = 5 ' sets the gourmet premium to $5
    Public Const GOURMETPRICE As Decimal = REGULARPRICE + GOURMETPREMIUM ' sets the gourmet price to the regular plus the gourmet premuim
    Public pizzaarray(19, 3) As String ' creates an array for the name,price,the number of pizzas and totals 
    Public TotalPizza As Integer

    Private Sub Btnback1_Click(sender As Object, e As EventArgs) Handles Btnback1.Click
        Form1.Show() ' if the back button is clicked it brings up form one with all the details still entered
        Me.Hide() ' hides this form to show form one
    End Sub

    Private Sub Btnrestart_Click(sender As Object, e As EventArgs) Handles Btnrestart.Click
        Application.Restart() ' if the restart button is clicked it restarts the application to form one with nothing entered

    End Sub

    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        End ' if the X button is clicked than the application ends and has to be reopened
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'stores the name of the regular pizza's
        pizzaarray(0, 0) = "Cheese Pizza" ' sets the name of the first pizza to chesse pizza in the array
        pizzaarray(1, 0) = "hawaiian pizza" 'sets the name of the second pizza to hawaiian pizza in the array
        pizzaarray(2, 0) = "pepperoni pizza" 'sets the name fo the third pizza to pepperoni pizza in the array
        pizzaarray(3, 0) = "meat lovers pizza" ' sets the fourth pizza to meat lovers pizza in the array
        pizzaarray(4, 0) = "cheesy garlic pizza" ' sets the fifth pizza to chessy garlic pizza in the array 
        pizzaarray(5, 0) = "veggie pizza" ' sets the sixth pizza to veggie pizza in the array
        pizzaarray(6, 0) = "the Godfather" ' sets the seventh pizza to the godfahter in the array
        pizzaarray(7, 0) = "butter chicken" ' sets the eighth pizza to butter chicken in the array
        pizzaarray(8, 0) = "mr wedge" ' sets the ninth pizza to mr wedge in they array
        pizzaarray(9, 0) = "spicy pepper" 'sets the tenth pizza to spicy pepper in the array 

        Lblpizza1.Text = pizzaarray(0, 0) ' changes the name in the text box to the corresponding slot in the array
        lblpizza2.Text = pizzaarray(1, 0) ' changes the name in the text box to the corresponding slot in the array
        lblpizza3.Text = pizzaarray(2, 0) ' changes the name in the text box to the corresponding slot in the array
        lblpizza4.Text = pizzaarray(3, 0) ' changes the name in the text box to the corresponding slot in the array
        Lblpizza5.Text = pizzaarray(4, 0) ' changes the name in the text box to the corresponding slot in the array
        Lblpizza6.Text = pizzaarray(5, 0) ' changes the name in the text box to the corresponding slot in the array
        Lblpizza7.Text = pizzaarray(6, 0) ' changes the name in the text box to the corresponding slot in the array
        Lblpizza8.Text = pizzaarray(7, 0) ' changes the name in the text box to the corresponding slot in the array
        Lblpizza9.Text = pizzaarray(8, 0) ' changes the name in the text box to the corresponding slot in the array
        Lblpizza10.Text = pizzaarray(9, 0) ' changes the name in the text box to the corresponding slot in the array

        For x = 0 To 9
            pizzaarray(x, 1) = REGULARPRICE ' sets the price for regular pizzads in the correct slot in the array
        Next
        Lblprice.Text = Val(pizzaarray(0, 1)).ToString("C") 'sets the price label to the price in the corresponding slot in the array

        pizzaarray(10, 0) = "GREEK LAMB TZATZIKI" ' sets the eleventh pizza to greek lamb tzarziki in the array
        pizzaarray(11, 0) = "LAMB MEATLOVERS" ' sets the twelevth pizza to lamb meatlovers in the arrray
        pizzaarray(12, 0) = "CHICKEN DELUXE" ' sets the thirtenth pizza to chicken deluxe in the array 
        pizzaarray(13, 0) = "BBQ PORK BELLY" ' sets the fourtenth pizza to bbq pork belly 
        pizzaarray(14, 0) = "THE LOT" ' sets the fifthtenth pizza to the lot 
        pizzaarray(15, 0) = "BUFFALO CHICKEN" ' sets the sixthenth pizza to buffalo chicken
        pizzaarray(16, 0) = "PERI-PERI CHICKEN" ' sets the seventhenth pizza to peri peri chicken in the array
        pizzaarray(17, 0) = "GARLIC PRAWN" 'sets the eightenth pizza to garlic prawn in the array
        pizzaarray(18, 0) = "APRICOT CHICKEN" ' sets the ninetenth pizza to apricot chicken in the array
        pizzaarray(19, 0) = "MEGA MEATLOVERS" ' sets the twenteth pizza to mega meatlovers in to array

        Lblpizza11.Text = pizzaarray(10, 0) ' changes the name in the text box to the corresponding slot in the array
        Lblpizza12.Text = pizzaarray(11, 0) ' changes the name in the text box to the corresponding slot in the array
        Lblpizza13.Text = pizzaarray(12, 0) ' changes the name in the text box to the corresponding slot in the array
        Lblpizza14.Text = pizzaarray(13, 0) ' changes the name in the text box to the corresponding slot in the array
        Lblpizza15.Text = pizzaarray(14, 0) ' changes the name in the text box to the corresponding slot in the array
        lblpizza16.Text = pizzaarray(15, 0) ' changes the name in the text box to the corresponding slot in the array
        Lblpizza17.Text = pizzaarray(16, 0) ' changes the name in the text box to the corresponding slot in the array
        Lblpizza18.Text = pizzaarray(17, 0) ' changes the name in the text box to the corresponding slot in the array
        Lblpizza19.Text = pizzaarray(18, 0) ' changes the name in the text box to the corresponding slot in the array
        Lblpizza20.Text = pizzaarray(19, 0) ' changes the name in the text box to the corresponding slot in the array

        For x = 10 To 19
            pizzaarray(x, 1) = GOURMETPRICE ' sets the gourmet price to the corresponding spot in the array
        Next
        Lblgourmetprice.Text = Val(pizzaarray(10, 1)).ToString("C")

    End Sub

    ' Define a single event handler
    Private Sub PizzaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _
    Cbopizza0.SelectedIndexChanged, Cbopizza1.SelectedIndexChanged, Cbopizza2.SelectedIndexChanged,
    Cbopizza3.SelectedIndexChanged, Cbopizza4.SelectedIndexChanged, Cbopizza5.SelectedIndexChanged,
    Cbopizza6.SelectedIndexChanged, Cbopizza7.SelectedIndexChanged, Cbopizza8.SelectedIndexChanged,
    Cbopizza9.SelectedIndexChanged, Cbopizza11.SelectedIndexChanged, Cbopizza12.SelectedIndexChanged,
    Cbopizza13.SelectedIndexChanged, Cbopizza14.SelectedIndexChanged, Cbopizza15.SelectedIndexChanged,
    Cbopizza16.SelectedIndexChanged, Cbopizza17.SelectedIndexChanged, Cbopizza18.SelectedIndexChanged,
    Cbopizza19.SelectedIndexChanged, Cbopizza20.SelectedIndexChanged

        Dim cb As ComboBox = CType(sender, ComboBox)
        Dim index As Integer = Convert.ToInt32(cb.Name.Substring(8)) ' Extract index from ComboBox name

        If index < pizzaarray.GetLength(0) Then
            pizzaarray(index, 2) = cb.Text
        End If
    End Sub

    Private Sub BtnContinue1_Click(sender As Object, e As EventArgs) Handles BtnContinue1.Click
        For x = 0 To 19
            TotalPizza = TotalPizza + pizzaarray(x, 2)
        Next
        If TotalPizza < 1 Then
            MsgBox("Please select a pizza")
        Else
            Form3.Show()
            Me.Hide()
        End If
        Dim path As String = "c:\order summary\orders.text"

        ' Create or overwrite the file. 
        Dim fs As FileStream = File.Create(path)

        ' Add text to the file. 
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(
                                   "")
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub
End Class