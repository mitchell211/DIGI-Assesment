Public Class Form2
    Public Const REGULARPRICE As Decimal = 8.5
    Public Const GOURMETPREMIUM As Decimal = 5
    Public Const GOURMETPRICE As Decimal = REGULARPRICE + GOURMETPREMIUM
    Public pizzaarray(19, 3) As String

    Private Sub Btnback1_Click(sender As Object, e As EventArgs) Handles Btnback1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Btnrestart_Click(sender As Object, e As EventArgs) Handles Btnrestart.Click
        Application.Restart()

    End Sub

    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        End
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'stores the name of the regular pizza's
        pizzaarray(0, 0) = "Cheese Pizza"
        pizzaarray(1, 0) = "hawaiian pizza"
        pizzaarray(2, 0) = "pepperoni pizza"
        pizzaarray(3, 0) = "meat lovers pizza"
        pizzaarray(4, 0) = "cheesy garlic pizza"
        pizzaarray(5, 0) = "veggie pizza"
        pizzaarray(6, 0) = "the Godfather"
        pizzaarray(7, 0) = "butter chicken"
        pizzaarray(8, 0) = "mr wedge"
        pizzaarray(9, 0) = "spicy pepper"

        'sets the labels as the names above
        Lblpizza1.Text = pizzaarray(0, 0)
        lblpizza2.Text = pizzaarray(1, 0)
        lblpizza3.Text = pizzaarray(2, 0)
        lblpizza4.Text = pizzaarray(3, 0)
        Lblpizza5.Text = pizzaarray(4, 0)
        Lblpizza6.Text = pizzaarray(5, 0)
        Lblpizza7.Text = pizzaarray(6, 0)
        Lblpizza8.Text = pizzaarray(7, 0)
        Lblpizza9.Text = pizzaarray(8, 0)
        Lblpizza10.Text = pizzaarray(9, 0)

        'stores the prices
        For x = 0 To 9
            pizzaarray(x, 1) = REGULARPRICE
        Next
        Lblprice.Text = Val(pizzaarray(0, 1)).ToString("C")

        pizzaarray(10, 0) = "GREEK LAMB TZATZIKI"
        pizzaarray(11, 0) = "LAMB MEATLOVERS"
        pizzaarray(12, 0) = "CHICKEN DELUXE"
        pizzaarray(13, 0) = "BBQ PORK BELLY"
        pizzaarray(14, 0) = "THE LOT"
        pizzaarray(15, 0) = "BUFFALO CHICKEN"
        pizzaarray(16, 0) = "PERI-PERI CHICKEN"
        pizzaarray(17, 0) = "GARLIC PRAWN"
        pizzaarray(18, 0) = "APRICOT CHICKEN"
        pizzaarray(19, 0) = "MEGA MEATLOVERS"

        Lblpizza11.Text = pizzaarray(10, 0)
        Lblpizza12.Text = pizzaarray(11, 0)
        Lblpizza13.Text = pizzaarray(12, 0)
        Lblpizza14.Text = pizzaarray(13, 0)
        Lblpizza15.Text = pizzaarray(14, 0)
        lblpizza16.Text = pizzaarray(15, 0)
        Lblpizza17.Text = pizzaarray(16, 0)
        Lblpizza18.Text = pizzaarray(17, 0)
        Lblpizza19.Text = pizzaarray(18, 0)
        Lblpizza20.Text = pizzaarray(19, 0)

        For x = 10 To 19
            pizzaarray(x, 1) = GOURMETPRICE
        Next
        Lblgourmetprice.Text = Val(pizzaarray(10, 1)).ToString("C")

    End Sub

    Private Sub Cbopizza0_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbopizza0.SelectedIndexChanged
        pizzaarray(0, 2) = Cbopizza0.Text
    End Sub

    Private Sub Cbopizza1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbopizza1.SelectedIndexChanged
        pizzaarray(1, 2) = Cbopizza1.Text
    End Sub

    Private Sub Cbopizza2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbopizza2.SelectedIndexChanged
        pizzaarray(2, 2) = Cbopizza2.Text
    End Sub

    Private Sub Cbopizza3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbopizza3.SelectedIndexChanged
        pizzaarray(3, 2) = Cbopizza3.Text
    End Sub

    Private Sub Cbopizza4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbopizza4.SelectedIndexChanged
        pizzaarray(4, 2) = Cbopizza4.Text
    End Sub

    Private Sub Cbopizza5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbopizza5.SelectedIndexChanged
        pizzaarray(5, 2) = Cbopizza5.Text
    End Sub

    Private Sub Cbopizza6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbopizza6.SelectedIndexChanged
        pizzaarray(6, 2) = Cbopizza6.Text
    End Sub

    Private Sub Cbopizza7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbopizza7.SelectedIndexChanged
        pizzaarray(7, 2) = Cbopizza7.Text
    End Sub

    Private Sub Cbopizza8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbopizza8.SelectedIndexChanged
        pizzaarray(8, 2) = Cbopizza8.Text
    End Sub

    Private Sub Cbopizza9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbopizza9.SelectedIndexChanged
        pizzaarray(9, 2) = Cbopizza9.Text
    End Sub

    Private Sub Cbopizza11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbopizza11.SelectedIndexChanged
        pizzaarray(10, 2) = Cbopizza11.Text
    End Sub

    Private Sub Cbopizza12_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbopizza12.SelectedIndexChanged
        pizzaarray(11, 2) = Cbopizza12.Text
    End Sub

    Private Sub Cbopizza13_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbopizza13.SelectedIndexChanged
        pizzaarray(12, 2) = Cbopizza13.Text
    End Sub

    Private Sub Cbopizza14_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbopizza14.SelectedIndexChanged
        pizzaarray(13, 2) = Cbopizza14.Text
    End Sub

    Private Sub Cbopizza15_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbopizza15.SelectedIndexChanged
        pizzaarray(14, 2) = Cbopizza15.Text
    End Sub

    Private Sub Cbopizza16_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbopizza16.SelectedIndexChanged
        pizzaarray(15, 2) = Cbopizza16.Text
    End Sub

    Private Sub Cbopizza17_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbopizza17.SelectedIndexChanged
        pizzaarray(16, 2) = Cbopizza17.Text
    End Sub

    Private Sub Cbopizza18_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbopizza18.SelectedIndexChanged
        pizzaarray(17, 2) = Cbopizza18.Text
    End Sub

    Private Sub Cbopizza19_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbopizza19.SelectedIndexChanged
        pizzaarray(18, 2) = Cbopizza19.Text
    End Sub

    Private Sub Cbopizza20_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbopizza20.SelectedIndexChanged
        pizzaarray(19, 2) = Cbopizza20.Text
    End Sub

    Private Sub BtnContinue1_Click(sender As Object, e As EventArgs) Handles BtnContinue1.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class