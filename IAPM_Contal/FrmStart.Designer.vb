<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStart
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrationBDDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommandesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificationToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FournisseursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificationToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificationToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatistiquesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.ClientToolStripMenuItem, Me.ProduitsToolStripMenuItem, Me.CommandesToolStripMenuItem, Me.FournisseursToolStripMenuItem, Me.CategoriesToolStripMenuItem, Me.StatistiquesToolStripMenuItem, Me.AProposToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(867, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitterToolStripMenuItem, Me.AdministrationBDDToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'AdministrationBDDToolStripMenuItem
        '
        Me.AdministrationBDDToolStripMenuItem.Name = "AdministrationBDDToolStripMenuItem"
        Me.AdministrationBDDToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.AdministrationBDDToolStripMenuItem.Text = "Administration BDD"
        '
        'ClientToolStripMenuItem
        '
        Me.ClientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListeToolStripMenuItem, Me.ModificationToolStripMenuItem})
        Me.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem"
        Me.ClientToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ClientToolStripMenuItem.Text = "Client"
        '
        'ListeToolStripMenuItem
        '
        Me.ListeToolStripMenuItem.Name = "ListeToolStripMenuItem"
        Me.ListeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ListeToolStripMenuItem.Text = "Liste"
        '
        'ModificationToolStripMenuItem
        '
        Me.ModificationToolStripMenuItem.Name = "ModificationToolStripMenuItem"
        Me.ModificationToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ModificationToolStripMenuItem.Text = "Ajout/Modif/Suppr"
        '
        'ProduitsToolStripMenuItem
        '
        Me.ProduitsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificationToolStripMenuItem1})
        Me.ProduitsToolStripMenuItem.Name = "ProduitsToolStripMenuItem"
        Me.ProduitsToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ProduitsToolStripMenuItem.Text = "Produit"
        '
        'ModificationToolStripMenuItem1
        '
        Me.ModificationToolStripMenuItem1.Name = "ModificationToolStripMenuItem1"
        Me.ModificationToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ModificationToolStripMenuItem1.Text = "Ajout/Modif/Suppr"
        '
        'CommandesToolStripMenuItem
        '
        Me.CommandesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificationToolStripMenuItem2})
        Me.CommandesToolStripMenuItem.Name = "CommandesToolStripMenuItem"
        Me.CommandesToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.CommandesToolStripMenuItem.Text = "Commande"
        '
        'ModificationToolStripMenuItem2
        '
        Me.ModificationToolStripMenuItem2.Name = "ModificationToolStripMenuItem2"
        Me.ModificationToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.ModificationToolStripMenuItem2.Text = "Ajout/Modif/Suppr"
        '
        'FournisseursToolStripMenuItem
        '
        Me.FournisseursToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificationToolStripMenuItem3})
        Me.FournisseursToolStripMenuItem.Name = "FournisseursToolStripMenuItem"
        Me.FournisseursToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.FournisseursToolStripMenuItem.Text = "Fournisseur"
        '
        'ModificationToolStripMenuItem3
        '
        Me.ModificationToolStripMenuItem3.Name = "ModificationToolStripMenuItem3"
        Me.ModificationToolStripMenuItem3.Size = New System.Drawing.Size(180, 22)
        Me.ModificationToolStripMenuItem3.Text = "Ajout/Modif/Suppr"
        '
        'CategoriesToolStripMenuItem
        '
        Me.CategoriesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificationToolStripMenuItem4})
        Me.CategoriesToolStripMenuItem.Name = "CategoriesToolStripMenuItem"
        Me.CategoriesToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.CategoriesToolStripMenuItem.Text = "Categorie"
        '
        'ModificationToolStripMenuItem4
        '
        Me.ModificationToolStripMenuItem4.Name = "ModificationToolStripMenuItem4"
        Me.ModificationToolStripMenuItem4.Size = New System.Drawing.Size(180, 22)
        Me.ModificationToolStripMenuItem4.Text = "Ajout/Modif/Suppr"
        '
        'StatistiquesToolStripMenuItem
        '
        Me.StatistiquesToolStripMenuItem.Name = "StatistiquesToolStripMenuItem"
        Me.StatistiquesToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.StatistiquesToolStripMenuItem.Text = "Statistiques"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.AProposToolStripMenuItem.Text = "A Propos"
        '
        'FrmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 661)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmStart"
        Me.Text = "IAPM"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProduitsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificationToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CommandesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificationToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents FournisseursToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificationToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents CategoriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificationToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents StatistiquesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrationBDDToolStripMenuItem As ToolStripMenuItem
End Class
