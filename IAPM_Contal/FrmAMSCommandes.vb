Imports ModeleIAPM
Public Class FrmAMSCommandes
    Dim position
    Private Sub FrmAMSCommandes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmStart
        Me.Left = 0
        Me.Top = 0
        DgvCommande.DataSource = GestionCommande.GetLesCommandesDG()
        Rafraichir()
        GestionInterface.AlimenterComboBox(CbClient, GestionClient.GetLesClientsCB(), “Patronyme”, “id_Utilisateur”)

    End Sub
    Public Sub Rafraichir()
        Try
            Dim MesCommandes As DataTable = GestionCommande.GetLesCommandes()
            TxbNum.Text = MesCommandes.Rows(position).Item(0)
            TxbDate.Text = MesCommandes.Rows(position).Item(1)
            CbClient.SelectedValue = MesCommandes.Rows(position).Item(2)


            DgvCommande.ClearSelection()
            DgvCommande.Rows(position).Selected = True

        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnPrecPrec_Click(sender As Object, e As EventArgs) Handles BtnPrecPrec.Click
        position = 0
        Rafraichir()
    End Sub

    Private Sub BtnPrec_Click(sender As Object, e As EventArgs) Handles BtnPrec.Click
        If (position > 0) Then
            position = position - 1
        End If
        Rafraichir()
    End Sub

    Private Sub BtnSuiv_Click(sender As Object, e As EventArgs) Handles BtnSuiv.Click
        If (position < GestionCommande.GetNBCommandes() - 1) Then
            position = position + 1
        End If
        Rafraichir()
    End Sub

    Private Sub BtnSuivSuiv_Click(sender As Object, e As EventArgs) Handles BtnSuivSuiv.Click
        position = GestionCommande.GetNBCommandes() - 1
        Rafraichir()
    End Sub

    Private Sub BtnNouvelle_Click(sender As Object, e As EventArgs) Handles BtnNouvelle.Click
        Dim ajc As New FrmAjoutCommande
        ajc.Show()
    End Sub

    Private Sub BtnConsulter_Click(sender As Object, e As EventArgs) Handles BtnConsulter.Click
        Dim idcom As Integer
        Dim dates As Date
        idcom = TxbNum.Text
        dates = TxbDate.Text
        Dim CC As New FrmConsulterCommande(idcom, dates)
        CC.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BtnSuppr_Click(sender As Object, e As EventArgs) Handles BtnSuppr.Click
        Dim idcom As Integer
        idcom = TxbNum.Text
        GestionCommande.SupprimerCommande(idcom)
        DgvCommande.DataSource = GestionCommande.GetLesCommandesDG()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DgvCommande.DataSource = GestionCommande.GetLesCommandesDG()
    End Sub

    Private Sub DgvCommande_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCommande.CellContentClick

    End Sub
End Class