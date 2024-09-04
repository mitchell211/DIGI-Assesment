<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Ptologo = New PictureBox()
        Lblpizzzaname = New Label()
        Lblwelcome = New Label()
        Lblname = New Label()
        Lblophone = New Label()
        Btnpickup = New Button()
        Btndelivery = New Button()
        Txtaddress = New TextBox()
        Lbladress = New Label()
        Lblyousure = New Label()
        Btnyes = New Button()
        Btnno = New Button()
        Txtname = New TextBox()
        mtbphone = New MaskedTextBox()
        Btnconfirm = New Button()
        Btnend = New Button()
        Btnrestart = New Button()
        CType(Ptologo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Ptologo
        ' 
        Ptologo.Location = New Point(144, 12)
        Ptologo.Name = "Ptologo"
        Ptologo.Size = New Size(198, 92)
        Ptologo.TabIndex = 1
        Ptologo.TabStop = False
        ' 
        ' Lblpizzzaname
        ' 
        Lblpizzzaname.AutoSize = True
        Lblpizzzaname.ForeColor = Color.Maroon
        Lblpizzzaname.Location = New Point(17, 24)
        Lblpizzzaname.Name = "Lblpizzzaname"
        Lblpizzzaname.Size = New Size(121, 15)
        Lblpizzzaname.TabIndex = 2
        Lblpizzzaname.Text = "Southern dream pizza"
        ' 
        ' Lblwelcome
        ' 
        Lblwelcome.AutoSize = True
        Lblwelcome.Font = New Font("Segoe UI", 15F)
        Lblwelcome.ForeColor = Color.Maroon
        Lblwelcome.Location = New Point(28, 39)
        Lblwelcome.Name = "Lblwelcome"
        Lblwelcome.Size = New Size(93, 28)
        Lblwelcome.TabIndex = 3
        Lblwelcome.Text = "Welcome"
        ' 
        ' Lblname
        ' 
        Lblname.AutoSize = True
        Lblname.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Lblname.ForeColor = Color.Maroon
        Lblname.Location = New Point(216, 175)
        Lblname.Name = "Lblname"
        Lblname.Size = New Size(40, 15)
        Lblname.TabIndex = 4
        Lblname.Text = "Name"
        ' 
        ' Lblophone
        ' 
        Lblophone.AutoSize = True
        Lblophone.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Lblophone.ForeColor = Color.Maroon
        Lblophone.Location = New Point(196, 219)
        Lblophone.Name = "Lblophone"
        Lblophone.Size = New Size(89, 15)
        Lblophone.TabIndex = 6
        Lblophone.Text = "phone number"
        ' 
        ' Btnpickup
        ' 
        Btnpickup.ForeColor = Color.Maroon
        Btnpickup.Location = New Point(46, 246)
        Btnpickup.Name = "Btnpickup"
        Btnpickup.Size = New Size(75, 42)
        Btnpickup.TabIndex = 8
        Btnpickup.Text = "Pick-up"
        Btnpickup.UseVisualStyleBackColor = True
        ' 
        ' Btndelivery
        ' 
        Btndelivery.ForeColor = Color.Maroon
        Btndelivery.Location = New Point(322, 246)
        Btndelivery.Name = "Btndelivery"
        Btndelivery.Size = New Size(75, 42)
        Btndelivery.TabIndex = 9
        Btndelivery.Text = "delivery +$3"
        Btndelivery.UseVisualStyleBackColor = True
        ' 
        ' Txtaddress
        ' 
        Txtaddress.Location = New Point(17, 312)
        Txtaddress.Name = "Txtaddress"
        Txtaddress.Size = New Size(438, 23)
        Txtaddress.TabIndex = 10
        Txtaddress.Visible = False
        ' 
        ' Lbladress
        ' 
        Lbladress.AutoSize = True
        Lbladress.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Lbladress.ForeColor = Color.Maroon
        Lbladress.Location = New Point(216, 294)
        Lbladress.Name = "Lbladress"
        Lbladress.Size = New Size(51, 15)
        Lbladress.TabIndex = 12
        Lbladress.Text = "Address"
        Lbladress.Visible = False
        ' 
        ' Lblyousure
        ' 
        Lblyousure.AutoSize = True
        Lblyousure.Font = New Font("Segoe UI", 25F)
        Lblyousure.Location = New Point(119, 390)
        Lblyousure.Name = "Lblyousure"
        Lblyousure.Size = New Size(223, 46)
        Lblyousure.TabIndex = 13
        Lblyousure.Text = "Are you sure?"
        Lblyousure.Visible = False
        ' 
        ' Btnyes
        ' 
        Btnyes.Location = New Point(119, 439)
        Btnyes.Name = "Btnyes"
        Btnyes.Size = New Size(75, 23)
        Btnyes.TabIndex = 14
        Btnyes.Text = "yes"
        Btnyes.UseVisualStyleBackColor = True
        Btnyes.Visible = False
        ' 
        ' Btnno
        ' 
        Btnno.Location = New Point(262, 439)
        Btnno.Name = "Btnno"
        Btnno.Size = New Size(80, 26)
        Btnno.TabIndex = 15
        Btnno.Text = "No"
        Btnno.UseVisualStyleBackColor = True
        Btnno.Visible = False
        ' 
        ' Txtname
        ' 
        Txtname.Location = New Point(17, 193)
        Txtname.Name = "Txtname"
        Txtname.Size = New Size(438, 23)
        Txtname.TabIndex = 5
        ' 
        ' mtbphone
        ' 
        mtbphone.Location = New Point(185, 246)
        mtbphone.Mask = "(999) 000-0000"
        mtbphone.Name = "mtbphone"
        mtbphone.Size = New Size(100, 23)
        mtbphone.TabIndex = 16
        ' 
        ' Btnconfirm
        ' 
        Btnconfirm.Font = New Font("Segoe UI", 25F)
        Btnconfirm.Location = New Point(144, 341)
        Btnconfirm.Name = "Btnconfirm"
        Btnconfirm.Size = New Size(165, 55)
        Btnconfirm.TabIndex = 17
        Btnconfirm.Text = "confirm"
        Btnconfirm.UseVisualStyleBackColor = True
        ' 
        ' Btnend
        ' 
        Btnend.Location = New Point(430, 12)
        Btnend.Name = "Btnend"
        Btnend.Size = New Size(20, 24)
        Btnend.TabIndex = 18
        Btnend.Text = "X"
        Btnend.UseVisualStyleBackColor = True
        ' 
        ' Btnrestart
        ' 
        Btnrestart.Location = New Point(366, 12)
        Btnrestart.Name = "Btnrestart"
        Btnrestart.Size = New Size(58, 24)
        Btnrestart.TabIndex = 19
        Btnrestart.Text = "Restart"
        Btnrestart.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(49), CByte(199), CByte(242))
        ClientSize = New Size(462, 474)
        Controls.Add(Btnrestart)
        Controls.Add(Btnend)
        Controls.Add(Btnconfirm)
        Controls.Add(mtbphone)
        Controls.Add(Btnno)
        Controls.Add(Btnyes)
        Controls.Add(Lblyousure)
        Controls.Add(Lbladress)
        Controls.Add(Txtaddress)
        Controls.Add(Btndelivery)
        Controls.Add(Btnpickup)
        Controls.Add(Lblophone)
        Controls.Add(Txtname)
        Controls.Add(Lblname)
        Controls.Add(Lblwelcome)
        Controls.Add(Lblpizzzaname)
        Controls.Add(Ptologo)
        ForeColor = Color.Maroon
        Name = "Form1"
        Text = "Form1"
        CType(Ptologo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Ptologo As PictureBox
    Friend WithEvents Lblpizzzaname As Label
    Friend WithEvents Lblwelcome As Label
    Friend WithEvents Lblname As Label
    Friend WithEvents Lblophone As Label
    Friend WithEvents Btnpickup As Button
    Friend WithEvents Btndelivery As Button
    Friend WithEvents Txtaddress As TextBox
    Friend WithEvents Lbladress As Label
    Friend WithEvents Lblyousure As Label
    Friend WithEvents Btnyes As Button
    Friend WithEvents Btnno As Button

    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Txtname As TextBox
    Friend WithEvents mtbphone As MaskedTextBox
    Friend WithEvents Btnconfirm As Button
    Friend WithEvents Btnend As Button
    Friend WithEvents Btnrestart As Button

End Class