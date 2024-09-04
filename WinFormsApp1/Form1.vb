Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text

Public Class Form1
    Public dir_name As String = "C:\ordersummary\"
    Public dir_name2 As String = "C:\grandsummary\"
    Public customerName As String = ""
    'Defines text enter as customer name.
    Public customerAddress As String = ""
    ' Defines tect entered in adress box as customer adress.
    Public deliverycharge As Decimal = 3
    'Sets the delvery fee To three dollars.
    Public delivery As Decimal = 0
    ' Sets delivery to zero to have a separte system to pick up and delivery.
    Public phonenumber As String = ""
    ' Defines numbers entered in the phone box as text.

    Private Sub Btndelivery_Click(sender As Object, e As EventArgs) Handles Btndelivery.Click
        'shows adress box
        delivery = deliverycharge
        ' Sets the deivery to three dollars.
        Lbladress.Show()
        ' Shows the label for the adress.
        Txtaddress.Show()
        ' Shows the text box for the address.
    End Sub

    Private Sub Btnconfirm_Click(sender As Object, e As EventArgs) Handles Btnconfirm.Click
        customerName = Txtname.Text.Trim
        ' Sets the customers name to a trimmed text removng spaces.
        phonenumber = mtbphone.Text.Trim
        ' Removes leading spaces in the phone number.
        customerAddress = Txtaddress.Text.Trim
        ' Sets the customers adress as a trimed text removing spaces.
        phonenumber = phonenumber.Remove(0, 1)
        ' Removes first bracket from the masked text box.
        phonenumber = phonenumber.Remove(3, 1)
        ' Removes a bracket from the masked text box.
        phonenumber = phonenumber.Remove(3, 1)
        ' Removes one of the dsashes from the masked text box.
        phonenumber = phonenumber.Remove(6, 1)
        ' Removes the last of the dashes from the masked text box.
        phonenumber = Val(phonenumber)
        ' Sets the phone number from text to values/numbers.
        If Len(phonenumber) < 8 Then
            ' If thers been numbers enterd but under 8 it displays this.
            MessageBox.Show("please enter valid Phone number")
            ' Tells the person entering details that the phone numbere is not valid.
        Else
            If delivery > 0 Then fordelivery() Else forcollection()
            ' Other code is pulled up for each sub.
        End If

    End Sub


    Private Sub Btnno_Click(sender As Object, e As EventArgs) Handles Btnno.Click
        Lblyousure.Hide()
        ' If no was clicked it removes the lable asking if their sure.
        Btnyes.Hide()
        ' Hides the yes button from the form.
        Btnno.Hide()
        ' Hides the no button from the form
    End Sub

    Private Sub Btnpickup_Click(sender As Object, e As EventArgs) Handles Btnpickup.Click
        delivery = 0
        ' Sets the delivery to 0.
        Lbladress.Hide()
        ' Hides the aadress label from the form.
        Txtaddress.Hide()
        ' Hides the address text box from the form.
    End Sub

    Private Sub Btnyes_Click(sender As Object, e As EventArgs) Handles Btnyes.Click
        Form2.Show()
        ' Shows form two.
        Me.Hide()
        ' Hides this form.
    End Sub

    Public Sub fordelivery()
        ' If the delivery charge is more then zero codes is redericted to this sub.
        If customerName = "" Then
            MessageBox.Show("please enter name")
            ' If nothing is entered into the name text this will be displayed.
        ElseIf phonenumber = 0 Then
            MessageBox.Show("please enter valid phone number")
            ' If nothing is entered ibnto the phone number text box this will be displayed.

        ElseIf customerAddress = "" Then
            MessageBox.Show("please enter address")
            ' If nothing is entered into the address text boxt his is displayed.
        Else
            Lblyousure.Show()
            ' Shows label asking if customer is sure that their details are correct.
            Btnyes.Show()
            ' Shows button to move to the next form.
            Btnno.Show()
            ' Shows button to hide these last two.
        End If
    End Sub
    Public Sub forcollection() ' if delivery is sero than code is redirected to this sub
        If customerName = "" Then
            MessageBox.Show("please enter name") 'if nothing is entered into the customer name text box this is displayed
        ElseIf phonenumber = 0 Then
            MessageBox.Show("please enter valid phone number") ' if nothing is entered into the phone number text box than this is displayed
        Else
            Lblyousure.Show() 'shows label asking if the customer is sure that their details are correct
            Btnyes.Show() 'shows the button to move to the next form
            Btnno.Show() ' hshows the button that hides the other two
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnend.Click
        End ' if the X button is clicked than the application ends and has to be reopened
    End Sub

    Private Sub Btnrestart_Click(sender As Object, e As EventArgs) Handles Btnrestart.Click
        Application.Restart() ' if the restart bvutton is pressed it resets the application and removes everything entered 
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not System.IO.Directory.Exists(dir_name) Then
            System.IO.Directory.CreateDirectory(dir_name)
        End If
        If Not System.IO.Directory.Exists(dir_name2) Then
            System.IO.Directory.CreateDirectory(dir_name2)
        End If
        '"C:\grandsummary\"
        Dim path As String = "C:\ordersummary\orders.text"

        ' Create or overwrite the file. 
        Dim fs As FileStream = File.Create(path)

        ' Add text to the file. 
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(
                                   "")
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub


End Class
