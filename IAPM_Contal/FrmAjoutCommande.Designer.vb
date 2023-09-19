<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAjoutCommande
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
        Me.TxbHt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dededed = New System.Windows.Forms.GroupBox()
        Me.BtnAjtatCom = New System.Windows.Forms.Button()
        Me.CbxCate = New System.Windows.Forms.ComboBox()
        Me.CbxProd = New System.Windows.Forms.ComboBox()
        Me.TxbQuant = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnVal = New System.Windows.Forms.Button()
        Me.TxbDateCo = New System.Windows.Forms.TextBox()
        Me.TxbNumCo = New System.Windows.Forms.TextBox()
        Me.CbCliCo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvProd = New System.Windows.Forms.DataGridView()
        Me.dededed.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxbHt
        '
        Me.TxbHt.Location = New System.Drawing.Point(306, 414)
        Me.TxbHt.Name = "TxbHt"
        Me.TxbHt.Size = New System.Drawing.Size(91, 20)
        Me.TxbHt.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(109, 417)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(191, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Montant Hors Taxes de la Commande :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(155, 450)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Fermer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dededed
        '
        Me.dededed.Controls.Add(Me.BtnAjtatCom)
        Me.dededed.Controls.Add(Me.CbxCate)
        Me.dededed.Controls.Add(Me.CbxProd)
        Me.dededed.Controls.Add(Me.TxbQuant)
        Me.dededed.Controls.Add(Me.Label6)
        Me.dededed.Controls.Add(Me.Label5)
        Me.dededed.Controls.Add(Me.Label4)
        Me.dededed.Location = New System.Drawing.Point(12, 104)
        Me.dededed.Name = "dededed"
        Me.dededed.Size = New System.Drawing.Size(451, 117)
        Me.dededed.TabIndex = 10
        Me.dededed.TabStop = False
        Me.dededed.Text = "Ajouter / Gérer des Produits :"
        '
        'BtnAjtatCom
        '
        Me.BtnAjtatCom.Enabled = False
        Me.BtnAjtatCom.Location = New System.Drawing.Point(269, 20)
        Me.BtnAjtatCom.Name = "BtnAjtatCom"
        Me.BtnAjtatCom.Size = New System.Drawing.Size(145, 23)
        Me.BtnAjtatCom.TabIndex = 6
        Me.BtnAjtatCom.Text = "Ajouter à la Commande"
        Me.BtnAjtatCom.UseVisualStyleBackColor = True
        '
        'CbxCate
        '
        Me.CbxCate.Enabled = False
        Me.CbxCate.FormattingEnabled = True
        Me.CbxCate.Location = New System.Drawing.Point(63, 20)
        Me.CbxCate.Name = "CbxCate"
        Me.CbxCate.Size = New System.Drawing.Size(171, 21)
        Me.CbxCate.TabIndex = 5
        '
        'CbxProd
        '
        Me.CbxProd.Enabled = False
        Me.CbxProd.FormattingEnabled = True
        Me.CbxProd.Location = New System.Drawing.Point(63, 51)
        Me.CbxProd.Name = "CbxProd"
        Me.CbxProd.Size = New System.Drawing.Size(171, 21)
        Me.CbxProd.TabIndex = 4
        '
        'TxbQuant
        '
        Me.TxbQuant.Enabled = False
        Me.TxbQuant.Location = New System.Drawing.Point(63, 81)
        Me.TxbQuant.Name = "TxbQuant"
        Me.TxbQuant.Size = New System.Drawing.Size(171, 20)
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnVal)
        Me.GroupBox2.Controls.Add(Me.TxbDateCo)
        Me.GroupBox2.Controls.Add(Me.TxbNumCo)
        Me.GroupBox2.Controls.Add(Me.CbCliCo)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(451, 65)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "La Commande :"
        '
        'BtnVal
        '
        Me.BtnVal.Location = New System.Drawing.Point(383, 28)
        Me.BtnVal.Name = "BtnVal"
        Me.BtnVal.Size = New System.Drawing.Size(62, 23)
        Me.BtnVal.TabIndex = 6
        Me.BtnVal.Text = "Valider"
        Me.BtnVal.UseVisualStyleBackColor = True
        '
        'TxbDateCo
        '
        Me.TxbDateCo.Location = New System.Drawing.Point(126, 29)
        Me.TxbDateCo.Name = "TxbDateCo"
        Me.TxbDateCo.Size = New System.Drawing.Size(79, 20)
        Me.TxbDateCo.TabIndex = 5
        '
        'TxbNumCo
        '
        Me.TxbNumCo.Location = New System.Drawing.Point(53, 30)
        Me.TxbNumCo.Name = "TxbNumCo"
        Me.TxbNumCo.Size = New System.Drawing.Size(38, 20)
        Me.TxbNumCo.TabIndex = 4
        '
        'CbCliCo
        '
        Me.CbCliCo.FormattingEnabled = True
        Me.CbCliCo.Location = New System.Drawing.Point(256, 29)
        Me.CbCliCo.Name = "CbCliCo"
        Me.CbCliCo.Size = New System.Drawing.Size(121, 21)
        Me.CbCliCo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(211, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Client :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numéro :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvProd)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 257)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 157)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Les Produits sélectionnés :"
        '
        'DgvProd
        '
        Me.DgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProd.Location = New System.Drawing.Point(6, 19)
        Me.DgvProd.Name = "DgvProd"
        Me.DgvProd.Size = New System.Drawing.Size(408, 132)
        Me.DgvProd.TabIndex = 0
        '
        'FrmAjoutCommande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 482)
        Me.Controls.Add(Me.TxbHt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dededed)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmAjoutCommande"
        Me.Text = "FrmAjoutCommande"
        Me.dededed.ResumeLayout(False)
        Me.dededed.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxbHt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents dededed As GroupBox
    Friend WithEvents BtnAjtatCom As Button
    Friend WithEvents CbxCate As ComboBox
    Friend WithEvents CbxProd As ComboBox
    Friend WithEvents TxbQuant As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxbDateCo As TextBox
    Friend WithEvents TxbNumCo As TextBox
    Friend WithEvents CbCliCo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgvProd As DataGridView
    Friend WithEvents BtnVal As Button
End Class
