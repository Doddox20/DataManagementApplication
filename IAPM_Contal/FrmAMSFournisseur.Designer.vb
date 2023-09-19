<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAMSFournisseur
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
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnPdf = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxRecherche = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.btnSupr = New System.Windows.Forms.Button()
        Me.btnAjout = New System.Windows.Forms.Button()
        Me.BtnFin = New System.Windows.Forms.Button()
        Me.Btnsuiv = New System.Windows.Forms.Button()
        Me.Btnpre = New System.Windows.Forms.Button()
        Me.BtnDeb = New System.Windows.Forms.Button()
        Me.TextBoxNomFour = New System.Windows.Forms.TextBox()
        Me.TextBoxNFour = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridClient = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxVilleFour = New System.Windows.Forms.TextBox()
        Me.TextBoxCPFour = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(313, 377)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(193, 25)
        Me.BtnClose.TabIndex = 33
        Me.BtnClose.Text = "Fermer"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnPdf
        '
        Me.BtnPdf.Location = New System.Drawing.Point(313, 328)
        Me.BtnPdf.Name = "BtnPdf"
        Me.BtnPdf.Size = New System.Drawing.Size(193, 25)
        Me.BtnPdf.TabIndex = 32
        Me.BtnPdf.Text = "Générer la liste au format PDF"
        Me.BtnPdf.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBoxRecherche)
        Me.GroupBox2.Location = New System.Drawing.Point(512, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(269, 82)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recherche Fournisseurs"
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
        'TextBoxRecherche
        '
        Me.TextBoxRecherche.Location = New System.Drawing.Point(86, 42)
        Me.TextBoxRecherche.Name = "TextBoxRecherche"
        Me.TextBoxRecherche.Size = New System.Drawing.Size(156, 20)
        Me.TextBoxRecherche.TabIndex = 1
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
        Me.GroupBox1.Location = New System.Drawing.Point(23, 227)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(483, 83)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestion des Fournisseurs"
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
        'TextBoxNomFour
        '
        Me.TextBoxNomFour.Location = New System.Drawing.Point(96, 83)
        Me.TextBoxNomFour.Name = "TextBoxNomFour"
        Me.TextBoxNomFour.Size = New System.Drawing.Size(168, 20)
        Me.TextBoxNomFour.TabIndex = 25
        '
        'TextBoxNFour
        '
        Me.TextBoxNFour.Location = New System.Drawing.Point(96, 40)
        Me.TextBoxNFour.Name = "TextBoxNFour"
        Me.TextBoxNFour.Size = New System.Drawing.Size(168, 20)
        Me.TextBoxNFour.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nom :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "N°Fournisseur :"
        '
        'DataGridClient
        '
        Me.DataGridClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridClient.Location = New System.Drawing.Point(287, 15)
        Me.DataGridClient.Name = "DataGridClient"
        Me.DataGridClient.Size = New System.Drawing.Size(417, 187)
        Me.DataGridClient.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Ville :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Code Postal :"
        '
        'TextBoxVilleFour
        '
        Me.TextBoxVilleFour.Location = New System.Drawing.Point(96, 135)
        Me.TextBoxVilleFour.Name = "TextBoxVilleFour"
        Me.TextBoxVilleFour.Size = New System.Drawing.Size(168, 20)
        Me.TextBoxVilleFour.TabIndex = 36
        '
        'TextBoxCPFour
        '
        Me.TextBoxCPFour.Location = New System.Drawing.Point(96, 175)
        Me.TextBoxCPFour.Name = "TextBoxCPFour"
        Me.TextBoxCPFour.Size = New System.Drawing.Size(168, 20)
        Me.TextBoxCPFour.TabIndex = 37
        '
        'FrmAMSFournisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 414)
        Me.Controls.Add(Me.TextBoxCPFour)
        Me.Controls.Add(Me.TextBoxVilleFour)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnPdf)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxNomFour)
        Me.Controls.Add(Me.TextBoxNFour)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridClient)
        Me.Name = "FrmAMSFournisseur"
        Me.Text = "FrmAMSFournisseur"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnPdf As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxRecherche As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnModif As Button
    Friend WithEvents btnSupr As Button
    Friend WithEvents btnAjout As Button
    Friend WithEvents BtnFin As Button
    Friend WithEvents Btnsuiv As Button
    Friend WithEvents Btnpre As Button
    Friend WithEvents BtnDeb As Button
    Friend WithEvents TextBoxNomFour As TextBox
    Friend WithEvents TextBoxNFour As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridClient As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxVilleFour As TextBox
    Friend WithEvents TextBoxCPFour As TextBox
End Class
