<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAMSCommandes
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSuppr = New System.Windows.Forms.Button()
        Me.BtnConsulter = New System.Windows.Forms.Button()
        Me.TxbDate = New System.Windows.Forms.TextBox()
        Me.TxbNum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbClient = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnNouvelle = New System.Windows.Forms.Button()
        Me.BtnSuivSuiv = New System.Windows.Forms.Button()
        Me.BtnSuiv = New System.Windows.Forms.Button()
        Me.BtnPrec = New System.Windows.Forms.Button()
        Me.BtnPrecPrec = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DgvCommande = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvCommande, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSuppr)
        Me.GroupBox1.Controls.Add(Me.BtnConsulter)
        Me.GroupBox1.Controls.Add(Me.TxbDate)
        Me.GroupBox1.Controls.Add(Me.TxbNum)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CbClient)
        Me.GroupBox1.Location = New System.Drawing.Point(67, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(396, 138)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Commande Sélectionnée :"
        '
        'BtnSuppr
        '
        Me.BtnSuppr.Location = New System.Drawing.Point(238, 70)
        Me.BtnSuppr.Name = "BtnSuppr"
        Me.BtnSuppr.Size = New System.Drawing.Size(117, 38)
        Me.BtnSuppr.TabIndex = 8
        Me.BtnSuppr.Text = "Supprimer la Commande"
        Me.BtnSuppr.UseVisualStyleBackColor = True
        '
        'BtnConsulter
        '
        Me.BtnConsulter.Location = New System.Drawing.Point(238, 19)
        Me.BtnConsulter.Name = "BtnConsulter"
        Me.BtnConsulter.Size = New System.Drawing.Size(117, 38)
        Me.BtnConsulter.TabIndex = 7
        Me.BtnConsulter.Text = "Consulter la Commande"
        Me.BtnConsulter.UseVisualStyleBackColor = True
        '
        'TxbDate
        '
        Me.TxbDate.Enabled = False
        Me.TxbDate.Location = New System.Drawing.Point(82, 55)
        Me.TxbDate.Name = "TxbDate"
        Me.TxbDate.Size = New System.Drawing.Size(129, 20)
        Me.TxbDate.TabIndex = 6
        '
        'TxbNum
        '
        Me.TxbNum.Enabled = False
        Me.TxbNum.Location = New System.Drawing.Point(82, 24)
        Me.TxbNum.Name = "TxbNum"
        Me.TxbNum.Size = New System.Drawing.Size(129, 20)
        Me.TxbNum.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Numéro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Client :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'CbClient
        '
        Me.CbClient.Enabled = False
        Me.CbClient.FormattingEnabled = True
        Me.CbClient.Location = New System.Drawing.Point(82, 87)
        Me.CbClient.Name = "CbClient"
        Me.CbClient.Size = New System.Drawing.Size(129, 21)
        Me.CbClient.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnNouvelle)
        Me.GroupBox2.Controls.Add(Me.BtnSuivSuiv)
        Me.GroupBox2.Controls.Add(Me.BtnSuiv)
        Me.GroupBox2.Controls.Add(Me.BtnPrec)
        Me.GroupBox2.Controls.Add(Me.BtnPrecPrec)
        Me.GroupBox2.Location = New System.Drawing.Point(67, 188)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(396, 100)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rechercher une Commande :"
        '
        'BtnNouvelle
        '
        Me.BtnNouvelle.Location = New System.Drawing.Point(155, 36)
        Me.BtnNouvelle.Name = "BtnNouvelle"
        Me.BtnNouvelle.Size = New System.Drawing.Size(91, 36)
        Me.BtnNouvelle.TabIndex = 4
        Me.BtnNouvelle.Text = "Nouvelle Commande"
        Me.BtnNouvelle.UseVisualStyleBackColor = True
        '
        'BtnSuivSuiv
        '
        Me.BtnSuivSuiv.Location = New System.Drawing.Point(329, 34)
        Me.BtnSuivSuiv.Name = "BtnSuivSuiv"
        Me.BtnSuivSuiv.Size = New System.Drawing.Size(61, 36)
        Me.BtnSuivSuiv.TabIndex = 3
        Me.BtnSuivSuiv.Text = ">>"
        Me.BtnSuivSuiv.UseVisualStyleBackColor = True
        '
        'BtnSuiv
        '
        Me.BtnSuiv.Location = New System.Drawing.Point(262, 34)
        Me.BtnSuiv.Name = "BtnSuiv"
        Me.BtnSuiv.Size = New System.Drawing.Size(61, 36)
        Me.BtnSuiv.TabIndex = 2
        Me.BtnSuiv.Text = ">"
        Me.BtnSuiv.UseVisualStyleBackColor = True
        '
        'BtnPrec
        '
        Me.BtnPrec.Location = New System.Drawing.Point(73, 36)
        Me.BtnPrec.Name = "BtnPrec"
        Me.BtnPrec.Size = New System.Drawing.Size(61, 36)
        Me.BtnPrec.TabIndex = 1
        Me.BtnPrec.Text = "<"
        Me.BtnPrec.UseVisualStyleBackColor = True
        '
        'BtnPrecPrec
        '
        Me.BtnPrecPrec.Location = New System.Drawing.Point(6, 36)
        Me.BtnPrecPrec.Name = "BtnPrecPrec"
        Me.BtnPrecPrec.Size = New System.Drawing.Size(61, 36)
        Me.BtnPrecPrec.TabIndex = 0
        Me.BtnPrecPrec.Text = "<<"
        Me.BtnPrecPrec.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DgvCommande)
        Me.GroupBox3.Location = New System.Drawing.Point(67, 306)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(396, 180)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Toute les Commandes :"
        '
        'DgvCommande
        '
        Me.DgvCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCommande.Location = New System.Drawing.Point(6, 19)
        Me.DgvCommande.Name = "DgvCommande"
        Me.DgvCommande.Size = New System.Drawing.Size(384, 150)
        Me.DgvCommande.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(222, 511)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Fermer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(396, 492)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Actualiser"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmAMSCommandes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 546)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmAMSCommandes"
        Me.Text = "Liste des Commandes :"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvCommande, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DgvCommande As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CbClient As ComboBox
    Friend WithEvents TxbDate As TextBox
    Friend WithEvents TxbNum As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnSuppr As Button
    Friend WithEvents BtnConsulter As Button
    Friend WithEvents BtnNouvelle As Button
    Friend WithEvents BtnSuivSuiv As Button
    Friend WithEvents BtnSuiv As Button
    Friend WithEvents BtnPrec As Button
    Friend WithEvents BtnPrecPrec As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
