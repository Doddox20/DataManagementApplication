Imports ModeleIAPM
Public Class FrmConsulterCommande

    Public Sub New(idcom As Integer, dates As Date)


        InitializeComponent()
        TxbNumCo.Text = idcom
        TxbDateCo.Text = dates

    End Sub
    Private Sub FrmConsulterCommande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmStart
        Me.Left = 0
        Me.Top = 0
        Dim idcom As Integer
        idcom = TxbNumCo.Text
        TxbHt.Text = GestionCommande.GetMontantHTByCommande(idcom)


        DgvProd.DataSource = GestionCommande.GetLesProduitsByCommande(TxbNumCo.Text)
        GestionInterface.AlimenterComboBox(CbCliCo, GestionClient.GetLesClientsByCom(TxbNumCo.Text), "Patronyme", "id_Utilisateur")
        GestionInterface.AlimenterComboBox(CbxCate, GestionCategories.GetLesCategorie(CbxCate), “libelle”, “IdCategorie”)
        GestionInterface.AlimenterComboBox(CbxProd, GestionProduit.GetLesProduits(), "libelleProduit", "IdProduit")
    End Sub

    Private Sub TxbNumCo_TextChanged(sender As Object, e As EventArgs) Handles TxbNumCo.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub CbxCate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxCate.SelectedIndexChanged
        Dim idcat As String
        idcat = CbxCate.SelectedValue.ToString
        Try
            GestionInterface.AlimenterComboBox(CbxProd, GestionProduit.GetLesProduitsByCAtegorie(idcat), "libelleProduit", "IdProduit")


        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub BtnAjtatCom_Click(sender As Object, e As EventArgs) Handles BtnAjtatCom.Click
        Try
            Dim idCo, idPro, Qu As String
            idCo = TxbNumCo.Text
            idPro = CbxProd.SelectedValue
            Qu = TxbQuant.Text
            GestionCommande.AjouterCommande(idCo, idPro, Qu)
            DgvProd.DataSource = GestionCommande.GetLesProduitsByCommande(TxbNumCo.Text)
        Catch
            MessageBox.Show("Voulez vous Remplacer la comma")
        End Try

    End Sub

    Private Sub BtnRetirCom_Click(sender As Object, e As EventArgs) Handles BtnRetirCom.Click
        Dim idCo, idPro As String
        idCo = TxbNumCo.Text
        idPro = DgvProd.CurrentRow.Cells(0).Value
        GestionCommande.SupprimerLigneComande(idCo, idPro)
        DgvProd.DataSource = GestionCommande.GetLesProduitsByCommande(TxbNumCo.Text)
    End Sub

    Private Sub BtnPdf_Click(sender As Object, e As EventArgs) Handles BtnPdf.Click
        Dim idcom As String
        idcom = TxbNumCo.Text
        Dim nameCli As String
        nameCli = CbCliCo.Text
        GestionPDF.genererpdfdepuisdatatableCo("La commande du client " & nameCli & " :", GestionCommande.GetLesProduitsByCommande(idcom))
    End Sub
End Class