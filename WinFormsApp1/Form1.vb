Public Class Form1
    Public customername As String = "" 'dewfines text enter as customer name 
    Public customeradress As String = "" ' defines tect entered in adress box as customer adress
    Public deliverycharge As Decimal = 3
    Public delivery As Decimal = 0
    Dim phonenumber As String = "" ' defines text entered in the phone box as hine bx
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Btndelivery_Click(sender As Object, e As EventArgs) Handles Btndelivery.Click
        'shows adress box
        delivery = deliverycharge
        Lbladress.Show()
        Txtaddress.Show()

    End Sub

    Private Sub Btnconfirm_Click(sender As Object, e As EventArgs) Handles Btnconfirm.Click
        customername = Txtname.Text.Trim
        phonenumber = mtbphone.Text.Trim 'removes leading spaces
        customeradress = Txtaddress.Text.Trim
        phonenumber = phonenumber.Remove(0, 1) 'removes brakets and dashes from phone number
        phonenumber = phonenumber.Remove(3, 1)
        phonenumber = phonenumber.Remove(3, 1)
        phonenumber = phonenumber.Remove(6, 1)
        phonenumber = Val(phonenumber)
        If Len(phonenumber) < 8 Then
            MessageBox.Show("please enter valid Phone number")
        Else
            If delivery > 0 Then fordelivery() Else forcollection()
        End If

    End Sub


    Private Sub Btnno_Click(sender As Object, e As EventArgs) Handles Btnno.Click
        Lblyousure.Hide()
        Btnyes.Hide()
        Btnno.Hide()
    End Sub

    Private Sub Btnpickup_Click(sender As Object, e As EventArgs) Handles Btnpickup.Click
        'adress hides
        delivery = 0
        Lbladress.Hide()
        Txtaddress.Hide()
    End Sub

    Private Sub Btnyes_Click(sender As Object, e As EventArgs) Handles Btnyes.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Txtname_TextChanged(sender As Object, e As EventArgs) Handles Txtname.TextChanged

    End Sub

    Private Sub Lblname_Click(sender As Object, e As EventArgs) Handles Lblname.Click

    End Sub

    Public Sub fordelivery()
        If customername = "" Then
            MessageBox.Show("please enter name")
        ElseIf phonenumber = 0 Then
            MessageBox.Show("please enter valid phone number")
        ElseIf customeradress = "" Then
            MessageBox.Show("please enter address")
            'nice
        Else
            Lblyousure.Show()
            Btnyes.Show()
            Btnno.Show()
        End If
    End Sub
    Public Sub forcollection()
        If customername = "" Then
            MessageBox.Show("please enter name")
        ElseIf phonenumber = 0 Then
            MessageBox.Show("please enter valid phone number")
        Else
            Lblyousure.Show()
            Btnyes.Show()
            Btnno.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnend.Click
        End
    End Sub

    Private Sub Btnrestart_Click(sender As Object, e As EventArgs) Handles Btnrestart.Click
        Application.Restart()
    End Sub
End Class
