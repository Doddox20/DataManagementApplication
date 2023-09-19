<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAMSClient
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridClient = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxNClient = New System.Windows.Forms.TextBox()
        Me.TextBoxPrenomClient = New System.Windows.Forms.TextBox()
        Me.TextBoxVilleClient = New System.Windows.Forms.TextBox()
        Me.TextBoxCPClient = New System.Windows.Forms.TextBox()
        Me.TextBoxRueClient = New System.Windows.Forms.TextBox()
        Me.TextBoxNomClient = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.btnSupr = New System.Windows.Forms.Button()
        Me.btnAjout = New System.Windows.Forms.Button()
        Me.BtnFin = New System.Windows.Forms.Button()
        Me.Btnsuiv = New System.Windows.Forms.Button()
        Me.Btnpre = New System.Windows.Forms.Button()
        Me.BtnDeb = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxRecherche = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnPdf = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.DataGridClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridClient
        '
        Me.DataGridClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridClient.Location = New System.Drawing.Point(293, 12)
        Me.DataGridClient.Name = "DataGridClient"
        Me.DataGridClient.Size = New System.Drawing.Size(417, 276)
        Me.DataGridClient.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "N°Client :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Prenom :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nom :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Rue :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Code Postal :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Ville :"
        '
        'TextBoxNClient
        '
        Me.TextBoxNClient.Location = New System.Drawing.Point(102, 37)
        Me.TextBoxNClient.Name = "TextBoxNClient"
        Me.TextBoxNClient.Size = New System.Drawing.Size(168, 20)
        Me.TextBoxNClient.TabIndex = 7
        '
        'TextBoxPrenomClient
        '
        Me.TextBoxPrenomClient.Location = New System.Drawing.Point(102, 72)
        Me.TextBoxPrenomClient.Name = "TextBoxPrenomClient"
        Me.TextBoxPrenomClient.Size = New System.Drawing.Size(168, 20)
        Me.TextBoxPrenomClient.TabIndex = 8
        '
        'TextBoxVilleClient
        '
        Me.TextBoxVilleClient.Location = New System.Drawing.Point(102, 204)
        Me.TextBoxVilleClient.Name = "TextBoxVilleClient"
        Me.TextBoxVilleClient.Size = New System.Drawing.Size(168, 20)
        Me.TextBoxVilleClient.TabIndex = 9
        '
        'TextBoxCPClient
        '
        Me.TextBoxCPClient.Location = New System.Drawing.Point(102, 178)
        Me.TextBoxCPClient.Name = "TextBoxCPClient"
        Me.TextBoxCPClient.Size = New System.Drawing.Size(168, 20)
        Me.TextBoxCPClient.TabIndex = 10
        '
        'TextBoxRueClient
        '
        Me.TextBoxRueClient.Location = New System.Drawing.Point(102, 144)
        Me.TextBoxRueClient.Name = "TextBoxRueClient"
        Me.TextBoxRueClient.Size = New System.Drawing.Size(168, 20)
        Me.TextBoxRueClient.TabIndex = 11
        '
        'TextBoxNomClient
        '
        Me.TextBoxNomClient.Location = New System.Drawing.Point(102, 109)
        Me.TextBoxNomClient.Name = "TextBoxNomClient"
        Me.TextBoxNomClient.Size = New System.Drawing.Size(168, 20)
        Me.TextBoxNomClient.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnModif)
        Me.GroupBox1.Controls.Add(Me.btnSupr)
        Me.GroupBox1.Controls.Add(Me.btnAjout)
        Me.GroupBox1.Controls.Add(Me.BtnFin)
        Me.GroupBox1.Controls.Add(Me.Btnsuiv)
        Me.GroupBox1.Controls.Add(Me.Btnpre)
        Me.GroupBox1.Controls.Add(Me.BtnDeb)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 294)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(483, 81)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestion des Clients"
        '
        'btnModif
        '
        Me.btnModif.Location = New System.Drawing.Point(407, 36)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(63, 30)
        Me.btnModif.TabIndex = 8
        Me.btnModif.Text = "Modifier"
        Me.btnModif.UseVisualStyleBackColor = True
        '
        'btnSupr
        '
        Me.btnSupr.Location = New System.Drawing.Point(341, 36)
        Me.btnSupr.Name = "btnSupr"
        Me.btnSupr.Size = New System.Drawing.Size(60, 30)
        Me.btnSupr.TabIndex = 7
        Me.btnSupr.Text = "-"
        Me.btnSupr.UseVisualStyleBackColor = True
        '
        'btnAjout
        '
        Me.btnAjout.Location = New System.Drawing.Point(275, 36)
        Me.btnAjout.Name = "btnAjout"
        Me.btnAjout.Size = New System.Drawing.Size(60, 30)
        Me.btnAjout.TabIndex = 6
        Me.btnAjout.Text = "+"
        Me.btnAjout.UseVisualStyleBackColor = True
        '
        'BtnFin
        '
        Me.BtnFin.Location = New System.Drawing.Point(197, 36)
        Me.BtnFin.Name = "BtnFin"
        Me.BtnFin.Size = New System.Drawing.Size(61, 30)
        Me.BtnFin.TabIndex = 5
        Me.BtnFin.Text = ">>"
        Me.BtnFin.UseVisualStyleBackColor = True
        '
        'Btnsuiv
        '
        Me.Btnsuiv.Location = New System.Drawing.Point(135, 36)
        Me.Btnsuiv.Name = "Btnsuiv"
        Me.Btnsuiv.Size = New System.Drawing.Size(56, 30)
        Me.Btnsuiv.TabIndex = 4
        Me.Btnsuiv.Text = ">"
        Me.Btnsuiv.UseVisualStyleBackColor = True
        '
        'Btnpre
        '
        Me.Btnpre.Location = New System.Drawing.Point(73, 36)
        Me.Btnpre.Name = "Btnpre"
        Me.Btnpre.Size = New System.Drawing.Size(56, 30)
        Me.Btnpre.TabIndex = 3
        Me.Btnpre.Text = "<"
        Me.Btnpre.UseVisualStyleBackColor = True
        '
        'BtnDeb
        '
        Me.BtnDeb.Location = New System.Drawing.Point(6, 36)
        Me.BtnDeb.Name = "BtnDeb"
        Me.BtnDeb.Size = New System.Drawing.Size(61, 30)
        Me.BtnDeb.TabIndex = 1
        Me.BtnDeb.Text = "<<"
        Me.BtnDeb.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBoxRecherche)
        Me.GroupBox2.Location = New System.Drawing.Point(518, 294)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(269, 80)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recherche Clients"
        '
        'TextBoxRecherche
        '
        Me.TextBoxRecherche.Location = New System.Drawing.Point(86, 42)
        Me.TextBoxRecherche.Name = "TextBoxRecherche"
        Me.TextBoxRecherche.Size = New System.Drawing.Size(156, 20)
        Me.TextBoxRecherche.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Rechercher :"
        '
        'BtnPdf
        '
        Me.BtnPdf.Location = New System.Drawing.Point(319, 381)
        Me.BtnPdf.Name = "BtnPdf"
        Me.BtnPdf.Size = New System.Drawing.Size(193, 23)
        Me.BtnPdf.TabIndex = 15
        Me.BtnPdf.Text = "Générer la liste au format PDF"
        Me.BtnPdf.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(319, 410)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(193, 23)
        Me.BtnClose.TabIndex = 16
        Me.BtnClose.Text = "Fermer"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmAMSClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 440)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnPdf)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxNomClient)
        Me.Controls.Add(Me.TextBoxRueClient)
        Me.Controls.Add(Me.TextBoxCPClient)
        Me.Controls.Add(Me.TextBoxVilleClient)
        Me.Controls.Add(Me.TextBoxPrenomClient)
        Me.Controls.Add(Me.TextBoxNClient)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridClient)
        Me.Name = "FrmAMSClient"
        Me.Text = "FrmAMSClient"
        CType(Me.DataGridClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridClient As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxNClient As TextBox
    Friend WithEvents TextBoxPrenomClient As TextBox
    Friend WithEvents TextBoxVilleClient As TextBox
    Friend WithEvents TextBoxCPClient As TextBox
    Friend WithEvents TextBoxRueClient As TextBox
    Friend WithEvents TextBoxNomClient As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnModif As Button
    Friend WithEvents btnSupr As Button
    Friend WithEvents btnAjout As Button
    Friend WithEvents BtnFin As Button
    Friend WithEvents Btnsuiv As Button
    Friend WithEvents Btnpre As Button
    Friend WithEvents BtnDeb As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBoxRecherche As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnPdf As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
