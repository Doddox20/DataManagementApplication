<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdminBDD
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBoxMdp = New System.Windows.Forms.TextBox()
        Me.TextBoxLogin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.TextboxBdd = New System.Windows.Forms.TextBox()
        Me.TextboxServ = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxMdp
        '
        Me.TextBoxMdp.Location = New System.Drawing.Point(107, 119)
        Me.TextBoxMdp.Name = "TextBoxMdp"
        Me.TextBoxMdp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxMdp.Size = New System.Drawing.Size(226, 20)
        Me.TextBoxMdp.TabIndex = 20
        '
        'TextBoxLogin
        '
        Me.TextBoxLogin.Location = New System.Drawing.Point(107, 89)
        Me.TextBoxLogin.Name = "TextBoxLogin"
        Me.TextBoxLogin.Size = New System.Drawing.Size(226, 20)
        Me.TextBoxLogin.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Mot de Passe :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Login :"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(204, 151)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(38, 151)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(91, 23)
        Me.BtnOk.TabIndex = 15
        Me.BtnOk.Text = "OK"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'TextboxBdd
        '
        Me.TextboxBdd.Location = New System.Drawing.Point(166, 61)
        Me.TextboxBdd.Name = "TextboxBdd"
        Me.TextboxBdd.Size = New System.Drawing.Size(167, 20)
        Me.TextboxBdd.TabIndex = 14
        Me.TextboxBdd.Text = "ppe_marchand_contall"
        '
        'TextboxServ
        '
        Me.TextboxServ.Location = New System.Drawing.Point(107, 21)
        Me.TextboxServ.Name = "TextboxServ"
        Me.TextboxServ.Size = New System.Drawing.Size(226, 20)
        Me.TextboxServ.TabIndex = 13
        Me.TextboxServ.Text = "localhost "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nom de la Base de Données :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nom du Serveur :"
        '
        'FrmAdminBDD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 194)
        Me.Controls.Add(Me.TextBoxMdp)
        Me.Controls.Add(Me.TextBoxLogin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.TextboxBdd)
        Me.Controls.Add(Me.TextboxServ)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmAdminBDD"
        Me.Text = "Paramètres de connexion :"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxMdp As TextBox
    Friend WithEvents TextBoxLogin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnOk As Button
    Friend WithEvents TextboxBdd As TextBox
    Friend WithEvents TextboxServ As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
