Imports ModeleIAPM

Public Class FrmStart
    Private Sub FrmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ClientToolStripMenuItem.Enabled = False
        ProduitsToolStripMenuItem.Enabled = False
        CommandesToolStripMenuItem.Enabled = False
        FournisseursToolStripMenuItem.Enabled = False
        CategoriesToolStripMenuItem.Enabled = False
        StatistiquesToolStripMenuItem.Enabled = False
        AProposToolStripMenuItem.Enabled = False
    End Sub

    Private Sub ListeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeToolStripMenuItem.Click
        Dim LC As New FrmListeClients2
        LC.Show()
    End Sub

    Private Sub ModificationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificationToolStripMenuItem.Click
        Dim AMSC As New FrmAMSClient
        AMSC.Show()
    End Sub

    Private Sub AdministrationBDDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrationBDDToolStripMenuItem.Click
        Dim Abdd As New FrmAdminBDD
        Abdd.Show()
    End Sub

    Private Sub ListeToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ModificationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ModificationToolStripMenuItem1.Click
        Dim Ap As New AsmProduit
        Ap.Show()
    End Sub

    Private Sub ModificationToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ModificationToolStripMenuItem2.Click
        Dim AC As New FrmAMSCommandes
        AC.Show()
    End Sub
End Class
