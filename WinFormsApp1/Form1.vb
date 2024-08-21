Imports System.IO
Imports System.Text

Public Class Form1
    Public customername As String = "" 'dewfines text enter as customer name 
    Public customeradress As String = "" ' defines tect entered in adress box as customer adress
    Public deliverycharge As Decimal = 3 'sets the delvery fee to three dollars
    Public delivery As Decimal = 0 ' sets delivery to zero to have a separte system to pick up and delivery
    Public phonenumber As String = "" ' defines numbers entered in the phone box as text
    Private Sub Btndelivery_Click(sender As Object, e As EventArgs) Handles Btndelivery.Click
        'shows adress box
        delivery = deliverycharge 'sets the deivery to three dollars 
        Lbladress.Show() ' shows the label for the adress 
        Txtaddress.Show() ' shows the text box for the adress
    End Sub

    Private Sub Btnconfirm_Click(sender As Object, e As EventArgs) Handles Btnconfirm.Click
        customername = Txtname.Text.Trim ' sets the customers name to a trimmed text removng spaces
        phonenumber = mtbphone.Text.Trim 'removes leading spaces in the phone number
        customeradress = Txtaddress.Text.Trim 'sets the customers adress as a trimed text removing spaces
        phonenumber = phonenumber.Remove(0, 1) 'removes first bracket from the masked text box
        phonenumber = phonenumber.Remove(3, 1) 'remves a bracket from the masked text box
        phonenumber = phonenumber.Remove(3, 1) ' removes one of the dsashes from the masked text box
        phonenumber = phonenumber.Remove(6, 1) ' removes the last of the dashes from the masked text box
        phonenumber = Val(phonenumber) ' sets the phone number from text to values/numbers
        If Len(phonenumber) < 8 Then 'if thers benn numbers enterd but under 8 it displays this 
            MessageBox.Show("please enter valid Phone number") ' tells the person entering details that the phone numbere is not valid
        Else
            If delivery > 0 Then fordelivery() Else forcollection() 'other code is pulled up for each sub
        End If

    End Sub


    Private Sub Btnno_Click(sender As Object, e As EventArgs) Handles Btnno.Click
        Lblyousure.Hide() 'if no was clicked it removes the lable asking if their sure 
        Btnyes.Hide() ' hides the yes button from the form
        Btnno.Hide() ' hides the no button from the form
    End Sub

    Private Sub Btnpickup_Click(sender As Object, e As EventArgs) Handles Btnpickup.Click
        delivery = 0 'sets the delivery to 0
        Lbladress.Hide() ' hides the aadress label from the form
        Txtaddress.Hide() ' hides the address text box from the form
    End Sub

    Private Sub Btnyes_Click(sender As Object, e As EventArgs) Handles Btnyes.Click
        Form2.Show() 'shows form two
        Me.Hide() ' hides this form
    End Sub

    Public Sub fordelivery() ' if the delivery charge is more then zero codes is rederiv=cted to this sub
        If customername = "" Then
            MessageBox.Show("please enter name") 'if nothing is entered into the name text this will be displayed
        ElseIf phonenumber = 0 Then
            MessageBox.Show("please enter valid phone number") ' if nothing is entered ibnto the phone number text box this will be displayed

        ElseIf customeradress = "" Then
            MessageBox.Show("please enter address") ' if nothing is entered into the address text boxt his is displayed
        Else
            Lblyousure.Show() 'shows label asking if customer is sure that their details are correct
            Btnyes.Show() ' shows button to move to the next form
            Btnno.Show() ' shows button to hide these last two 
        End If
    End Sub
    Public Sub forcollection() ' if delivery is sero than code is redirected to this sub
        If customername = "" Then
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
