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
        Ptologo.Location = New Point(206, 20)
        Ptologo.Margin = New Padding(4, 5, 4, 5)
        Ptologo.Name = "Ptologo"
        Ptologo.Size = New Size(283, 153)
        Ptologo.TabIndex = 1
        Ptologo.TabStop = False
        ' 
        ' Lblpizzzaname
        ' 
        Lblpizzzaname.AutoSize = True
        Lblpizzzaname.ForeColor = Color.Maroon
        Lblpizzzaname.Location = New Point(24, 40)
        Lblpizzzaname.Margin = New Padding(4, 0, 4, 0)
        Lblpizzzaname.Name = "Lblpizzzaname"
        Lblpizzzaname.Size = New Size(185, 25)
        Lblpizzzaname.TabIndex = 2
        Lblpizzzaname.Text = "Southern dream pizza"
        ' 
        ' Lblwelcome
        ' 
        Lblwelcome.AutoSize = True
        Lblwelcome.Font = New Font("Segoe UI", 15F)
        Lblwelcome.ForeColor = Color.Maroon
        Lblwelcome.Location = New Point(24, 107)
        Lblwelcome.Margin = New Padding(4, 0, 4, 0)
        Lblwelcome.Name = "Lblwelcome"
        Lblwelcome.Size = New Size(142, 41)
        Lblwelcome.TabIndex = 3
        Lblwelcome.Text = "Welcome"
        ' 
        ' Lblname
        ' 
        Lblname.AutoSize = True
        Lblname.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Lblname.ForeColor = Color.Maroon
        Lblname.Location = New Point(309, 292)
        Lblname.Margin = New Padding(4, 0, 4, 0)
        Lblname.Name = "Lblname"
        Lblname.Size = New Size(62, 25)
        Lblname.TabIndex = 4
        Lblname.Text = "Name"
        ' 
        ' Lblophone
        ' 
        Lblophone.AutoSize = True
        Lblophone.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Lblophone.ForeColor = Color.Maroon
        Lblophone.Location = New Point(280, 365)
        Lblophone.Margin = New Padding(4, 0, 4, 0)
        Lblophone.Name = "Lblophone"
        Lblophone.Size = New Size(137, 25)
        Lblophone.TabIndex = 6
        Lblophone.Text = "phone number"
        ' 
        ' Btnpickup
        ' 
        Btnpickup.ForeColor = Color.Maroon
        Btnpickup.Location = New Point(66, 410)
        Btnpickup.Margin = New Padding(4, 5, 4, 5)
        Btnpickup.Name = "Btnpickup"
        Btnpickup.Size = New Size(107, 70)
        Btnpickup.TabIndex = 8
        Btnpickup.Text = "Pick-up"
        Btnpickup.UseVisualStyleBackColor = True
        ' 
        ' Btndelivery
        ' 
        Btndelivery.ForeColor = Color.Maroon
        Btndelivery.Location = New Point(460, 410)
        Btndelivery.Margin = New Padding(4, 5, 4, 5)
        Btndelivery.Name = "Btndelivery"
        Btndelivery.Size = New Size(107, 70)
        Btndelivery.TabIndex = 9
        Btndelivery.Text = "delivery +$3"
        Btndelivery.UseVisualStyleBackColor = True
        ' 
        ' Txtaddress
        ' 
        Txtaddress.Location = New Point(24, 520)
        Txtaddress.Margin = New Padding(4, 5, 4, 5)
        Txtaddress.Name = "Txtaddress"
        Txtaddress.Size = New Size(624, 31)
        Txtaddress.TabIndex = 10
        Txtaddress.Visible = False
        ' 
        ' Lbladress
        ' 
        Lbladress.AutoSize = True
        Lbladress.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Lbladress.ForeColor = Color.Maroon
        Lbladress.Location = New Point(309, 490)
        Lbladress.Margin = New Padding(4, 0, 4, 0)
        Lbladress.Name = "Lbladress"
        Lbladress.Size = New Size(80, 25)
        Lbladress.TabIndex = 12
        Lbladress.Text = "Address"
        Lbladress.Visible = False
        ' 
        ' Lblyousure
        ' 
        Lblyousure.AutoSize = True
        Lblyousure.Font = New Font("Segoe UI", 25F)
        Lblyousure.Location = New Point(170, 650)
        Lblyousure.Margin = New Padding(4, 0, 4, 0)
        Lblyousure.Name = "Lblyousure"
        Lblyousure.Size = New Size(327, 67)
        Lblyousure.TabIndex = 13
        Lblyousure.Text = "Are you sure?"
        Lblyousure.Visible = False
        ' 
        ' Btnyes
        ' 
        Btnyes.Location = New Point(170, 732)
        Btnyes.Margin = New Padding(4, 5, 4, 5)
        Btnyes.Name = "Btnyes"
        Btnyes.Size = New Size(107, 38)
        Btnyes.TabIndex = 14
        Btnyes.Text = "yes"
        Btnyes.UseVisualStyleBackColor = True
        Btnyes.Visible = False
        ' 
        ' Btnno
        ' 
        Btnno.Location = New Point(374, 732)
        Btnno.Margin = New Padding(4, 5, 4, 5)
        Btnno.Name = "Btnno"
        Btnno.Size = New Size(114, 43)
        Btnno.TabIndex = 15
        Btnno.Text = "No"
        Btnno.UseVisualStyleBackColor = True
        Btnno.Visible = False
        ' 
        ' Txtname
        ' 
        Txtname.Location = New Point(24, 322)
        Txtname.Margin = New Padding(4, 5, 4, 5)
        Txtname.Name = "Txtname"
        Txtname.Size = New Size(624, 31)
        Txtname.TabIndex = 5
        ' 
        ' mtbphone
        ' 
        mtbphone.Location = New Point(264, 410)
        mtbphone.Margin = New Padding(4, 5, 4, 5)
        mtbphone.Mask = "(999) 000-0000"
        mtbphone.Name = "mtbphone"
        mtbphone.Size = New Size(141, 31)
        mtbphone.TabIndex = 16
        ' 
        ' Btnconfirm
        ' 
        Btnconfirm.Font = New Font("Segoe UI", 25F)
        Btnconfirm.Location = New Point(206, 568)
        Btnconfirm.Margin = New Padding(4, 5, 4, 5)
        Btnconfirm.Name = "Btnconfirm"
        Btnconfirm.Size = New Size(236, 92)
        Btnconfirm.TabIndex = 17
        Btnconfirm.Text = "confirm"
        Btnconfirm.UseVisualStyleBackColor = True
        ' 
        ' Btnend
        ' 
        Btnend.Location = New Point(614, 20)
        Btnend.Margin = New Padding(4, 5, 4, 5)
        Btnend.Name = "Btnend"
        Btnend.Size = New Size(29, 40)
        Btnend.TabIndex = 18
        Btnend.Text = "X"
        Btnend.UseVisualStyleBackColor = True
        ' 
        ' Btnrestart
        ' 
        Btnrestart.Location = New Point(523, 20)
        Btnrestart.Margin = New Padding(4, 5, 4, 5)
        Btnrestart.Name = "Btnrestart"
        Btnrestart.Size = New Size(83, 40)
        Btnrestart.TabIndex = 19
        Btnrestart.Text = "Restart"
        Btnrestart.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(49), CByte(199), CByte(242))
        ClientSize = New Size(660, 790)
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
        Margin = New Padding(4, 5, 4, 5)
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