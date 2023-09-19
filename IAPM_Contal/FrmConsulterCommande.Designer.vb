<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsulterCommande
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvProd = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxbDateCo = New System.Windows.Forms.TextBox()
        Me.TxbNumCo = New System.Windows.Forms.TextBox()
        Me.CbCliCo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dededed = New System.Windows.Forms.GroupBox()
        Me.BtnRetirCom = New System.Windows.Forms.Button()
        Me.BtnAjtatCom = New System.Windows.Forms.Button()
        Me.CbxCate = New System.Windows.Forms.ComboBox()
        Me.CbxProd = New System.Windows.Forms.ComboBox()
        Me.TxbQuant = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxbHt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnPdf = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.dededed.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvProd)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 258)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 157)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tout les produits de la commande sélectionné :"
        '
        'DgvProd
        '
        Me.DgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProd.Location = New System.Drawing.Point(6, 19)
        Me.DgvProd.Name = "DgvProd"
        Me.DgvProd.Size = New System.Drawing.Size(379, 132)
        Me.DgvProd.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxbDateCo)
        Me.GroupBox2.Controls.Add(Me.TxbNumCo)
        Me.GroupBox2.Controls.Add(Me.CbCliCo)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(41, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(392, 65)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "La Commande :"
        '
        'TxbDateCo
        '
        Me.TxbDateCo.Location = New System.Drawing.Point(143, 29)
        Me.TxbDateCo.Name = "TxbDateCo"
        Me.TxbDateCo.Size = New System.Drawing.Size(79, 20)
        Me.TxbDateCo.TabIndex = 5
        '
        'TxbNumCo
        '
        Me.TxbNumCo.Location = New System.Drawing.Point(63, 29)
        Me.TxbNumCo.Name = "TxbNumCo"
        Me.TxbNumCo.Size = New System.Drawing.Size(38, 20)
        Me.TxbNumCo.TabIndex = 4
        '
        'CbCliCo
        '
        Me.CbCliCo.Enabled = False
        Me.CbCliCo.FormattingEnabled = True
        Me.CbCliCo.Location = New System.Drawing.Point(265, 29)
        Me.CbCliCo.Name = "CbCliCo"
        Me.CbCliCo.Size = New System.Drawing.Size(121, 21)
        Me.CbCliCo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(220, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Client :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numéro :"
        '
        'dededed
        '
        Me.dededed.Controls.Add(Me.BtnRetirCom)
        Me.dededed.Controls.Add(Me.BtnAjtatCom)
        Me.dededed.Controls.Add(Me.CbxCate)
        Me.dededed.Controls.Add(Me.CbxProd)
        Me.dededed.Controls.Add(Me.TxbQuant)
        Me.dededed.Controls.Add(Me.Label6)
        Me.dededed.Controls.Add(Me.Label5)
        Me.dededed.Controls.Add(Me.Label4)
        Me.dededed.Location = New System.Drawing.Point(41, 105)
        Me.dededed.Name = "dededed"
        Me.dededed.Size = New System.Drawing.Size(386, 117)
        Me.dededed.TabIndex = 2
        Me.dededed.TabStop = False
        Me.dededed.Text = "Ajouter / Gérer des Produits :"
        '
        'BtnRetirCom
        '
        Me.BtnRetirCom.Location = New System.Drawing.Point(223, 61)
        Me.BtnRetirCom.Name = "BtnRetirCom"
        Me.BtnRetirCom.Size = New System.Drawing.Size(145, 23)
        Me.BtnRetirCom.TabIndex = 7
        Me.BtnRetirCom.Text = "Retirer de la Commande"
        Me.BtnRetirCom.UseVisualStyleBackColor = True
        '
        'BtnAjtatCom
        '
        Me.BtnAjtatCom.Location = New System.Drawing.Point(223, 20)
        Me.BtnAjtatCom.Name = "BtnAjtatCom"
        Me.BtnAjtatCom.Size = New System.Drawing.Size(145, 23)
        Me.BtnAjtatCom.TabIndex = 6
        Me.BtnAjtatCom.Text = "Ajouter à la Commande"
        Me.BtnAjtatCom.UseVisualStyleBackColor = True
        '
        'CbxCate
        '
        Me.CbxCate.FormattingEnabled = True
        Me.CbxCate.Location = New System.Drawing.Point(63, 20)
        Me.CbxCate.Name = "CbxCate"
        Me.CbxCate.Size = New System.Drawing.Size(121, 21)
        Me.CbxCate.TabIndex = 5
        '
        'CbxProd
        '
        Me.CbxProd.FormattingEnabled = True
        Me.CbxProd.Location = New System.Drawing.Point(63, 51)
        Me.CbxProd.Name = "CbxProd"
        Me.CbxProd.Size = New System.Drawing.Size(121, 21)
        Me.CbxProd.TabIndex = 4
        '
        'TxbQuant
        '
        Me.TxbQuant.Location = New System.Drawing.Point(63, 81)
        Me.TxbQuant.Name = "TxbQuant"
        Me.TxbQuant.Size = New System.Drawing.Size(121, 20)
        Me.TxbQuant.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Quantité :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Produit :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Catégorie :"
        '
        'TxbHt
        '
        Me.TxbHt.Location = New System.Drawing.Point(335, 415)
        Me.TxbHt.Name = "TxbHt"
        Me.TxbHt.Size = New System.Drawing.Size(91, 20)
        Me.TxbHt.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(138, 418)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(191, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Montant Hors Taxes de la Commande :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(184, 451)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Fermer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnPdf
        '
        Me.BtnPdf.Location = New System.Drawing.Point(335, 451)
        Me.BtnPdf.Name = "BtnPdf"
        Me.BtnPdf.Size = New System.Drawing.Size(92, 23)
        Me.BtnPdf.TabIndex = 8
        Me.BtnPdf.Text = "Génerer PDF"
        Me.BtnPdf.UseVisualStyleBackColor = True
        '
        'FrmConsulterCommande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 486)
        Me.Controls.Add(Me.BtnPdf)
        Me.Controls.Add(Me.TxbHt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dededed)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmConsulterCommande"
        Me.Text = "FrmConsulterCommande"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.dededed.ResumeLayout(False)
        Me.dededed.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgvProd As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CbCliCo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dededed As GroupBox
    Friend WithEvents TxbDateCo As TextBox
    Friend WithEvents TxbNumCo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnRetirCom As Button
    Friend WithEvents BtnAjtatCom As Button
    Friend WithEvents CbxCate As ComboBox
    Friend WithEvents CbxProd As ComboBox
    Friend WithEvents TxbQuant As TextBox
    Friend WithEvents TxbHt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnPdf As Button
End Class
