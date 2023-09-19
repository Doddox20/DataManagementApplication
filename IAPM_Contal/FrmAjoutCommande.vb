Imports ModeleIAPM
Public Class FrmAjoutCommande
    Private Sub FrmAjoutCommande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmStart
        Me.Left = 0
        Me.Top = 0

        Dim nb As Integer
        Dim id As Integer
        nb = GestionCommande.GetNBCommandes() + 1
        TxbNumCo.Text = nb
        id = TxbNumCo.Text


        Dim MyDate
        MyDate = DateTime.Now.ToString("dd/MM/yyyy")
        TxbDateCo.Text = MyDate
        GestionInterface.AlimenterComboBox(CbCliCo, GestionClient.GetLesClientsCB(), "Patronyme", "id_Utilisateur")
        GestionInterface.AlimenterComboBox(CbxCate, GestionCategories.GetLesCategorie(CbxCate), “libelle”, “IdCategorie”)
        GestionInterface.AlimenterComboBox(CbxProd, GestionProduit.GetLesProduits(), "libelleProduit", "IdProduit")
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

    Private Sub BtnVal_Click(sender As Object, e As EventArgs) Handles BtnVal.Click
        CbCliCo.Enabled = False
        TxbDateCo.Enabled = False
        TxbNumCo.Enabled = False
        BtnVal.Enabled = False
        CbxCate.Enabled = True
        CbxProd.Enabled = True
        TxbQuant.Enabled = True
        BtnAjtatCom.Enabled = True

        Dim idc As Integer
        Dim dat As Date
        Dim idcli As Integer
        idc = TxbNumCo.Text
        dat = TxbDateCo.Text
        idcli = CbCliCo.SelectedValue
        GestionCommande.AjouterCommandes(idc, dat, idcli)
        DgvProd.DataSource = GestionCommande.GetLesProduitsByCommande(TxbNumCo.Text)


    End Sub

    Private Sub BtnAjtatCom_Click(sender As Object, e As EventArgs) Handles BtnAjtatCom.Click

        Dim idCo, idPro, Qu As String
            idCo = TxbNumCo.Text
            idPro = CbxProd.SelectedValue
            Qu = TxbQuant.Text

        GestionCommande.AjouterCommande(idCo, idPro, Qu)
        DgvProd.DataSource = GestionCommande.GetLesProduitsByCommande(TxbNumCo.Text)
        TxbHt.Text = GestionCommande.GetMontantHTByCommande(idCo)


    End Sub

    Private Sub FrmAjoutCommande_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim idcom = Convert.ToInt32(TxbNumCo.Text)

        If CbCliCo.Enabled = False Then


            If GestionCommande.GetLesProduitsByCommande(idcom).Rows.Count = 0 Then

                GestionCommande.SupprimerCommande(idcom)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


End Class