Imports ModeleIAPM
Public Class FrmAdminBDD
    Dim bdd = "Saisir ici votre BDD : ppe_marchand_contal"
    Dim Serv = "Saisir ici votre Serveur : localhost / SxxxPxx"
    Private Sub FrmAdminBDD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmStart
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextboxBdd.Text = bdd
        TextboxServ.Text = Serv
    End Sub
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        GestionBDD.Serveur = TextboxServ.Text
        GestionBDD.BDD = TextboxBdd.Text
        GestionBDD.Login = TextBoxLogin.Text
        GestionBDD.Mdp = TextBoxMdp.Text
        Try
            GestionBDD.SeConnecter()
            FrmStart.ClientToolStripMenuItem.Enabled = True
            FrmStart.ProduitsToolStripMenuItem.Enabled = True
            FrmStart.CommandesToolStripMenuItem.Enabled = True
            FrmStart.FournisseursToolStripMenuItem.Enabled = True
            FrmStart.CategoriesToolStripMenuItem.Enabled = True
            FrmStart.StatistiquesToolStripMenuItem.Enabled = True
            FrmStart.AProposToolStripMenuItem.Enabled = True

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Erreur dans les paramètres de connection : Serveur / BDD / Login / Mdp")
        End Try

    End Sub

End Class