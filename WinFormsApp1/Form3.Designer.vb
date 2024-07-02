<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.Location = New Point(154, 21)
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
        BtnContinue1.Text = "Continue"
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
        lblpizzas.Location = New Point(24, 58)
        lblpizzas.Name = "lblpizzas"
        lblpizzas.Size = New Size(136, 334)
        lblpizzas.TabIndex = 75
        lblpizzas.Text = "Label5"
        ' 
        ' lblQty
        ' 
        lblQty.Location = New Point(166, 58)
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
        lblprice.Location = New Point(342, 58)
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
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(49), CByte(199), CByte(242))
        ClientSize = New Size(490, 476)
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
End Class
