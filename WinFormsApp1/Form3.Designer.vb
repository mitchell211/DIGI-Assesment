﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Label1 = New Label()
        BtnContinue1 = New Button()
        Btnback1 = New Button()
        Btnrestart = New Button()
        Btnclose = New Button()
        lblpizzas = New Label()
        lblQty = New Label()
        Label5 = New Label()
        lblprice = New Label()
        lbltotal = New Label()
        PrintDialog1 = New PrintDialog()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Label2 = New Label()
        lblphone = New Label()
        lblname = New Label()
        Lbladdress = New Label()
        lblcusname = New Label()
        lblcusaddress = New Label()
        Lblcusphone = New Label()
        btngrandreset = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.Location = New Point(152, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(203, 37)
        Label1.TabIndex = 0
        Label1.Text = "Order Summary"
        ' 
        ' BtnContinue1
        ' 
        BtnContinue1.Location = New Point(55, 447)
        BtnContinue1.Name = "BtnContinue1"
        BtnContinue1.Size = New Size(177, 26)
        BtnContinue1.TabIndex = 58
        BtnContinue1.Text = "print"
        BtnContinue1.UseVisualStyleBackColor = True
        ' 
        ' Btnback1
        ' 
        Btnback1.Location = New Point(268, 447)
        Btnback1.Name = "Btnback1"
        Btnback1.Size = New Size(177, 26)
        Btnback1.TabIndex = 59
        Btnback1.Text = "Back"
        Btnback1.UseVisualStyleBackColor = True
        ' 
        ' Btnrestart
        ' 
        Btnrestart.Location = New Point(397, 3)
        Btnrestart.Name = "Btnrestart"
        Btnrestart.Size = New Size(58, 22)
        Btnrestart.TabIndex = 73
        Btnrestart.Text = "Restart"
        Btnrestart.UseVisualStyleBackColor = True
        ' 
        ' Btnclose
        ' 
        Btnclose.Location = New Point(461, 2)
        Btnclose.Name = "Btnclose"
        Btnclose.Size = New Size(26, 23)
        Btnclose.TabIndex = 74
        Btnclose.Text = "X"
        Btnclose.UseVisualStyleBackColor = True
        ' 
        ' lblpizzas
        ' 
        lblpizzas.Location = New Point(12, 89)
        lblpizzas.Name = "lblpizzas"
        lblpizzas.Size = New Size(136, 334)
        lblpizzas.TabIndex = 75
        lblpizzas.Text = "Label5"
        ' 
        ' lblQty
        ' 
        lblQty.Location = New Point(189, 89)
        lblQty.Name = "lblQty"
        lblQty.Size = New Size(136, 334)
        lblQty.TabIndex = 76
        lblQty.Text = "lblQTY"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(365, 69)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 15)
        Label5.TabIndex = 77
        ' 
        ' lblprice
        ' 
        lblprice.Location = New Point(331, 89)
        lblprice.Name = "lblprice"
        lblprice.Size = New Size(136, 334)
        lblprice.TabIndex = 78
        lblprice.Text = "lblQTY"
        ' 
        ' lbltotal
        ' 
        lbltotal.AutoSize = True
        lbltotal.Font = New Font("Segoe UI", 12F)
        lbltotal.Location = New Point(213, 423)
        lbltotal.Name = "lbltotal"
        lbltotal.Size = New Size(56, 21)
        lbltotal.TabIndex = 79
        lbltotal.Text = "Label2"
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 9F)
        Label2.Location = New Point(361, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 16)
        Label2.TabIndex = 80
        ' 
        ' lblphone
        ' 
        lblphone.AutoSize = True
        lblphone.Location = New Point(1, 45)
        lblphone.Name = "lblphone"
        lblphone.Size = New Size(91, 15)
        lblphone.TabIndex = 81
        lblphone.Text = "Phone Number:"
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.Location = New Point(1, 3)
        lblname.Name = "lblname"
        lblname.Size = New Size(42, 15)
        lblname.TabIndex = 82
        lblname.Text = "Name:"
        ' 
        ' Lbladdress
        ' 
        Lbladdress.AutoSize = True
        Lbladdress.Location = New Point(1, 24)
        Lbladdress.Name = "Lbladdress"
        Lbladdress.Size = New Size(52, 15)
        Lbladdress.TabIndex = 83
        Lbladdress.Text = "Address:"
        ' 
        ' lblcusname
        ' 
        lblcusname.AutoSize = True
        lblcusname.BackColor = Color.Transparent
        lblcusname.Font = New Font("Segoe UI", 7F)
        lblcusname.Location = New Point(43, 3)
        lblcusname.Name = "lblcusname"
        lblcusname.Size = New Size(33, 12)
        lblcusname.TabIndex = 84
        lblcusname.Text = "Label3"
        ' 
        ' lblcusaddress
        ' 
        lblcusaddress.AutoSize = True
        lblcusaddress.BackColor = Color.Transparent
        lblcusaddress.Font = New Font("Segoe UI", 7F)
        lblcusaddress.Location = New Point(59, 24)
        lblcusaddress.Name = "lblcusaddress"
        lblcusaddress.Size = New Size(33, 12)
        lblcusaddress.TabIndex = 85
        lblcusaddress.Text = "Label4"
        ' 
        ' Lblcusphone
        ' 
        Lblcusphone.AutoSize = True
        Lblcusphone.BackColor = Color.Transparent
        Lblcusphone.Font = New Font("Segoe UI", 7F)
        Lblcusphone.Location = New Point(98, 45)
        Lblcusphone.Name = "Lblcusphone"
        Lblcusphone.Size = New Size(33, 12)
        Lblcusphone.TabIndex = 86
        Lblcusphone.Text = "Label7"
        ' 
        ' btngrandreset
        ' 
        btngrandreset.Location = New Point(352, 28)
        btngrandreset.Name = "btngrandreset"
        btngrandreset.Size = New Size(135, 29)
        btngrandreset.TabIndex = 87
        btngrandreset.Text = "Reset grand summary"
        btngrandreset.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(49), CByte(199), CByte(242))
        ClientSize = New Size(490, 476)
        Controls.Add(btngrandreset)
        Controls.Add(Lblcusphone)
        Controls.Add(lblcusaddress)
        Controls.Add(lblcusname)
        Controls.Add(Lbladdress)
        Controls.Add(lblname)
        Controls.Add(lblphone)
        Controls.Add(Label2)
        Controls.Add(lbltotal)
        Controls.Add(lblprice)
        Controls.Add(Label5)
        Controls.Add(lblQty)
        Controls.Add(lblpizzas)
        Controls.Add(Btnclose)
        Controls.Add(Btnrestart)
        Controls.Add(Btnback1)
        Controls.Add(BtnContinue1)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnContinue1 As Button
    Friend WithEvents Btnback1 As Button
    Friend WithEvents Lblpizza10 As Label
    Friend WithEvents Lblpizza9 As Label
    Friend WithEvents lblpizza2 As Label
    Friend WithEvents lblpizza3 As Label
    Friend WithEvents lblpizza4 As Label
    Friend WithEvents Lblpizza5 As Label
    Friend WithEvents Lblpizza6 As Label
    Friend WithEvents Lblpizza7 As Label
    Friend WithEvents Lblpizza8 As Label
    Friend WithEvents Lblpizza1 As Label
    Friend WithEvents Btnrestart As Button
    Friend WithEvents Btnclose As Button
    Friend WithEvents lblpizzas As Label
    Friend WithEvents lblQty As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblprice As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents lblphone As Label
    Friend WithEvents lblname As Label
    Friend WithEvents Lbladdress As Label
    Friend WithEvents lblcusname As Label
    Friend WithEvents lblcusaddress As Label
    Friend WithEvents Lblcusphone As Label
    Friend WithEvents btngrandreset As Button
End Class
