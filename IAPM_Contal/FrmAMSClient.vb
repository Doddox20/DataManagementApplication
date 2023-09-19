Imports ModeleIAPM
Public Class FrmAMSClient
    Dim position As Integer = 0
    Private Sub FrmAMSClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmStart
        DataGridClient.DataSource = GestionInterface.RemplaceSlashApostrophesDataTable(GestionClient.GetLesClients())
        Rafraichir()

    End Sub


    Public Sub Rafraichir()
        Dim MesClients As DataTable = GestionClient.GetLesClients()
        TextBoxNClient.Text = MesClients.Rows(position).Item(0)
        TextBoxNomClient.Text = MesClients.Rows(position).Item(1)
        TextBoxPrenomClient.Text = MesClients.Rows(position).Item(2)
        TextBoxCPClient.Text = MesClients.Rows(position).Item(7)
        TextBoxRueClient.Text = MesClients.Rows(position).Item(5)
        TextBoxVilleClient.Text = MesClients.Rows(position).Item(6)

        DataGridClient.ClearSelection()
        DataGridClient.Rows(position).Selected = True
    End Sub

    Private Sub Btnsuiv_Click(sender As Object, e As EventArgs) Handles Btnsuiv.Click
        If (position < GestionClient.GetNBClients() - 1) Then
            position = position + 1
        End If
        Rafraichir()
    End Sub

    Private Sub Btnpre_Click(sender As Object, e As EventArgs) Handles Btnpre.Click
        If position > 0 Then
            position = position - 1
        End If
        Rafraichir()
    End Sub

    Private Sub BtnDeb_Click(sender As Object, e As EventArgs) Handles BtnDeb.Click
        position = 0
        Rafraichir()
    End Sub

    Private Sub BtnFin_Click(sender As Object, e As EventArgs) Handles BtnFin.Click
        position = GestionClient.GetNBClients() - 1
        Rafraichir()
    End Sub

    Private Sub btnAjout_Click(sender As Object, e As EventArgs) Handles btnAjout.Click


        If btnAjout.Text = "+" Then
            btnAjout.Text = "Valider"
            TextBoxNClient.Text = GestionBDD.Generer_Cle_Primaire("id_Utilisateur", "Utilisateur")
            TextBoxNomClient.Text = ""
            TextBoxPrenomClient.Text = ""
            TextBoxRueClient.Text = ""
            TextBoxCPClient.Text = ""
            TextBoxVilleClient.Text = ""
        Else

            Dim c As Integer
            Dim n, p, r, cp, v As String
            c = GestionBDD.Generer_Cle_Primaire("id_Utilisateur", "Utilisateur")
            n = GestionInterface.RemplaceApostrophesSlash(TextBoxNomClient.Text)
            p = TextBoxPrenomClient.Text
            r = TextBoxRueClient.Text
            cp = TextBoxCPClient.Text
            v = TextBoxVilleClient.Text
            If Not GestionInterface.ValidNom(v) Or Not GestionInterface.ValidNom(p) Or Not GestionInterface.ValidNum(cp) Or Not GestionInterface.ValidNom(n) Then
                MsgBox("Insertion impossible, un des champs n'est pas correctement")
            Else
                GestionClient.AjouterClient(c, n, p, r, cp, v)

                MessageBox.Show("Client Ajouté...!", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                position = 0
                btnAjout.Text = "+"


                DataGridClient.DataSource = GestionInterface.RemplaceSlashApostrophesDataTable(GestionClient.GetLesClients())
                Rafraichir()
            End If
        End If
    End Sub

    Private Sub btnSupr_Click(sender As Object, e As EventArgs) Handles btnSupr.Click
        Dim answer As Integer
        answer = MsgBox("Voulez vous vraiment supprimer le Client N° " & TextBoxNClient.Text & " Suppression", MessageBoxButtons.YesNo)
        If answer = vbYes Then
            Dim id As Integer
            id = TextBoxNClient.Text
            GestionClient.SupprimerClient(id)
            MessageBox.Show("Client suprimé !", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            position = 0
            Rafraichir()
            answer = vbEmpty
            DataGridClient.DataSource = GestionInterface.RemplaceSlashApostrophesDataTable(GestionClient.GetLesClients())
        Else
            MessageBox.Show("Suppression annulé !", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        Dim answer As Integer
        answer = MsgBox("Voulez vous vraiment modifié le Client N° " & TextBoxNClient.Text & " ok", MessageBoxButtons.YesNo)
        If answer = vbYes Then
            Dim c As Integer
            Dim n, p, r, cp, v As String
            c = TextBoxNClient.Text
            n = GestionInterface.RemplaceApostrophesSlash(TextBoxNomClient.Text)
            p = TextBoxPrenomClient.Text
            r = TextBoxRueClient.Text
            cp = TextBoxCPClient.Text
            v = TextBoxVilleClient.Text
            GestionClient.ModifierClient(c, n, p, r, cp, v)
            MessageBox.Show("Client Modifié !", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            position = 0
            Rafraichir()
            DataGridClient.DataSource = GestionInterface.RemplaceSlashApostrophesDataTable(GestionClient.GetLesClients())
            answer = vbEmpty
        Else
            MessageBox.Show("Modification annulé !", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub TextBoxRecherche_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRecherche.TextChanged
        Dim R As String
        Try
            R = (TextBoxRecherche.Text)
        Catch ex As Exception
            Exit Sub
        End Try
        DataGridClient.DataSource = GestionInterface.RemplaceSlashApostrophesDataTable(GestionClient.RechercherClient(R))
        Rafraichir()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnPdf_Click(sender As Object, e As EventArgs) Handles BtnPdf.Click
        GestionPDF.genererpdfdepuisdatatable("Listes des Clients", GestionClient.GetLesClients(), GestionClient.GetNBClients)
    End Sub

    Private Sub TextBoxNomClient_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxNomClient.LostFocus
        If GestionInterface.ValidNom(TextBoxNomClient.Text) = False Then
            Me.ErrorProvider1.SetError(Me.TextBoxNomClient, "Le Nom est invalide, contient des nombres, ou absents !!!")
            ErrorProvider1.Tag = 1

        Else
            Me.ErrorProvider1.SetError(Me.TextBoxNomClient, "")
            ErrorProvider1.Tag = 0
        End If
    End Sub
    Private Sub TextBoxPrenom_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxPrenomClient.LostFocus
        If GestionInterface.ValidNom(TextBoxPrenomClient.Text) = False Then
            Me.ErrorProvider1.SetError(Me.TextBoxPrenomClient, "Le Nom est invalide, contient des nombres, ou absents !!!")
            ErrorProvider1.Tag = 1

        Else
            Me.ErrorProvider1.SetError(Me.TextBoxPrenomClient, "")
            ErrorProvider1.Tag = 0
        End If
    End Sub
    Private Sub TextBoxCPClient_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxCPClient.LostFocus
        If GestionInterface.ValidNum(TextBoxCPClient.Text) = False Then
            Me.ErrorProvider1.SetError(Me.TextBoxCPClient, "Le CP est invalide, contient des nombres, ou absents !!!")
            ErrorProvider1.Tag = 1

        Else
            Me.ErrorProvider1.SetError(Me.TextBoxCPClient, "")
            ErrorProvider1.Tag = 0

        End If
    End Sub
    Private Sub TextBoxVilleClient_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxVilleClient.LostFocus
        If GestionInterface.ValidNom(TextBoxVilleClient.Text) = False Then
            Me.ErrorProvider1.SetError(Me.TextBoxVilleClient, "Le Nom de la ville est invalide, contient des nombres, ou absents !!!")
            ErrorProvider1.Tag = 1

        Else
            Me.ErrorProvider1.SetError(Me.TextBoxVilleClient, "")
            ErrorProvider1.Tag = 0

        End If
    End Sub

End Class