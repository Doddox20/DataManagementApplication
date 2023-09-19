<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsmProduit
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
        Me.ComboBoxCategorieProduit = New System.Windows.Forms.ComboBox()
        Me.ComboBoxFournisseur = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.Quitter = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.TextBoxRecherche = New System.Windows.Forms.TextBox()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.btnSupr = New System.Windows.Forms.Button()
        Me.btnAjout = New System.Windows.Forms.Button()
        Me.BtnFin = New System.Windows.Forms.Button()
        Me.Btnpre = New System.Windows.Forms.Button()
        Me.Btnsuiv = New System.Windows.Forms.Button()
        Me.BtnDeb = New System.Windows.Forms.Button()
        Me.TextBoxPrixProduit = New System.Windows.Forms.TextBox()
        Me.TextBoxQStockProduit = New System.Windows.Forms.TextBox()
        Me.TextBoxLibelleProduit = New System.Windows.Forms.TextBox()
        Me.TextBoxCodeProduit = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxCategorieProduit
        '
        Me.ComboBoxCategorieProduit.Enabled = False
        Me.ComboBoxCategorieProduit.FormattingEnabled = True
        Me.ComboBoxCategorieProduit.Location = New System.Drawing.Point(154, 241)
        Me.ComboBoxCategorieProduit.Name = "ComboBoxCategorieProduit"
        Me.ComboBoxCategorieProduit.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxCategorieProduit.TabIndex = 66
        '
        'ComboBoxFournisseur
        '
        Me.ComboBoxFournisseur.Enabled = False
        Me.ComboBoxFournisseur.FormattingEnabled = True
        Me.ComboBoxFournisseur.Location = New System.Drawing.Point(154, 204)
        Me.ComboBoxFournisseur.Name = "ComboBoxFournisseur"
        Me.ComboBoxFournisseur.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxFournisseur.TabIndex = 65
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Catégorie :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Fournisseur :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Quantité Stock :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Prix HT :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Libellé :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Code :"
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(387, 31)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(557, 262)
        Me.DataGridView.TabIndex = 58
        '
        'Quitter
        '
        Me.Quitter.Location = New System.Drawing.Point(414, 416)
        Me.Quitter.Name = "Quitter"
        Me.Quitter.Size = New System.Drawing.Size(104, 31)
        Me.Quitter.TabIndex = 56
        Me.Quitter.Text = "Fermer"
        Me.Quitter.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPDF)
        Me.GroupBox1.Controls.Add(Me.TextBoxRecherche)
        Me.GroupBox1.Controls.Add(Me.btnModif)
        Me.GroupBox1.Controls.Add(Me.btnSupr)
        Me.GroupBox1.Controls.Add(Me.btnAjout)
        Me.GroupBox1.Controls.Add(Me.BtnFin)
        Me.GroupBox1.Controls.Add(Me.Btnpre)
        Me.GroupBox1.Controls.Add(Me.Btnsuiv)
        Me.GroupBox1.Controls.Add(Me.BtnDeb)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 310)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(932, 100)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestion des Produits"
        '
        'btnPDF
        '
        Me.btnPDF.Location = New System.Drawing.Point(548, 65)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(87, 24)
        Me.btnPDF.TabIndex = 35
        Me.btnPDF.Text = "PDF"
        Me.btnPDF.UseVisualStyleBackColor = True
        '
        'TextBoxRecherche
        '
        Me.TextBoxRecherche.Location = New System.Drawing.Point(699, 41)
        Me.TextBoxRecherche.Name = "TextBoxRecherche"
        Me.TextBoxRecherche.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxRecherche.TabIndex = 7
        '
        'btnModif
        '
        Me.btnModif.Location = New System.Drawing.Point(455, 65)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(87, 24)
        Me.btnModif.TabIndex = 6
        Me.btnModif.Text = "Modifier"
        Me.btnModif.UseVisualStyleBackColor = True
        '
        'btnSupr
        '
        Me.btnSupr.Location = New System.Drawing.Point(512, 35)
        Me.btnSupr.Name = "btnSupr"
        Me.btnSupr.Size = New System.Drawing.Size(60, 24)
        Me.btnSupr.TabIndex = 5
        Me.btnSupr.Text = "-"
        Me.btnSupr.UseVisualStyleBackColor = True
        '
        'btnAjout
        '
        Me.btnAjout.Location = New System.Drawing.Point(437, 35)
        Me.btnAjout.Name = "btnAjout"
        Me.btnAjout.Size = New System.Drawing.Size(60, 24)
        Me.btnAjout.TabIndex = 4
        Me.btnAjout.Text = "+"
        Me.btnAjout.UseVisualStyleBackColor = True
        '
        'BtnFin
        '
        Me.BtnFin.Location = New System.Drawing.Point(306, 35)
        Me.BtnFin.Name = "BtnFin"
        Me.BtnFin.Size = New System.Drawing.Size(60, 24)
        Me.BtnFin.TabIndex = 3
        Me.BtnFin.Text = ">>"
        Me.BtnFin.UseVisualStyleBackColor = True
        '
        'Btnpre
        '
        Me.Btnpre.Location = New System.Drawing.Point(118, 35)
        Me.Btnpre.Name = "Btnpre"
        Me.Btnpre.Size = New System.Drawing.Size(60, 24)
        Me.Btnpre.TabIndex = 2
        Me.Btnpre.Text = "<"
        Me.Btnpre.UseVisualStyleBackColor = True
        '
        'Btnsuiv
        '
        Me.Btnsuiv.Location = New System.Drawing.Point(184, 35)
        Me.Btnsuiv.Name = "Btnsuiv"
        Me.Btnsuiv.Size = New System.Drawing.Size(60, 24)
        Me.Btnsuiv.TabIndex = 1
        Me.Btnsuiv.Text = ">"
        Me.Btnsuiv.UseVisualStyleBackColor = True
        '
        'BtnDeb
        '
        Me.BtnDeb.Location = New System.Drawing.Point(12, 35)
        Me.BtnDeb.Name = "BtnDeb"
        Me.BtnDeb.Size = New System.Drawing.Size(66, 24)
        Me.BtnDeb.TabIndex = 0
        Me.BtnDeb.Text = "<<"
        Me.BtnDeb.UseVisualStyleBackColor = True
        '
        'TextBoxPrixProduit
        '
        Me.TextBoxPrixProduit.Location = New System.Drawing.Point(154, 118)
        Me.TextBoxPrixProduit.Name = "TextBoxPrixProduit"
        Me.TextBoxPrixProduit.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPrixProduit.TabIndex = 55
        '
        'TextBoxQStockProduit
        '
        Me.TextBoxQStockProduit.Location = New System.Drawing.Point(154, 165)
        Me.TextBoxQStockProduit.Name = "TextBoxQStockProduit"
        Me.TextBoxQStockProduit.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxQStockProduit.TabIndex = 54
        '
        'TextBoxLibelleProduit
        '
        Me.TextBoxLibelleProduit.Location = New System.Drawing.Point(154, 69)
        Me.TextBoxLibelleProduit.Name = "TextBoxLibelleProduit"
        Me.TextBoxLibelleProduit.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxLibelleProduit.TabIndex = 53
        '
        'TextBoxCodeProduit
        '
        Me.TextBoxCodeProduit.Location = New System.Drawing.Point(154, 31)
        Me.TextBoxCodeProduit.Name = "TextBoxCodeProduit"
        Me.TextBoxCodeProduit.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCodeProduit.TabIndex = 52
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'AsmProduit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 460)
        Me.Controls.Add(Me.ComboBoxCategorieProduit)
        Me.Controls.Add(Me.ComboBoxFournisseur)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.Quitter)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxPrixProduit)
        Me.Controls.Add(Me.TextBoxQStockProduit)
        Me.Controls.Add(Me.TextBoxLibelleProduit)
        Me.Controls.Add(Me.TextBoxCodeProduit)
        Me.Name = "AsmProduit"
        Me.Text = "AsmProduit"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxCategorieProduit As ComboBox
    Friend WithEvents ComboBoxFournisseur As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents Quitter As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPDF As Button
    Friend WithEvents TextBoxRecherche As TextBox
    Friend WithEvents btnModif As Button
    Friend WithEvents btnSupr As Button
    Friend WithEvents btnAjout As Button
    Friend WithEvents BtnFin As Button
    Friend WithEvents Btnpre As Button
    Friend WithEvents Btnsuiv As Button
    Friend WithEvents BtnDeb As Button
    Friend WithEvents TextBoxPrixProduit As TextBox
    Friend WithEvents TextBoxQStockProduit As TextBox
    Friend WithEvents TextBoxLibelleProduit As TextBox
    Friend WithEvents TextBoxCodeProduit As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
