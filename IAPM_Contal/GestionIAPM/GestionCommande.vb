Imports ModeleIAPM

Namespace Global.ModeleIAPM


    Public Class GestionCommande

        Public Shared Function GetLesCommandes() As DataTable
            Return GestionBDD.Executer_Requete_Select(“Select * from Commande”)
        End Function

        Public Shared Function GetLesCommandesDG() As DataTable
            Return GestionBDD.Executer_Requete_Select("Select commande.idCommande,DateCommande,concat(Nom_Utilisateur,' ',Prenom_Utilisateur) as Patronyme,SUM(QuantiteCom*PrixHTProduit) AS MontantHT from commande,client, ligne_de_commande,utilisateur, produit WHERE utilisateur.Id_Utilisateur=client.Id_Utilisateur and commande.idCli = client.Id_Client AND commande.idcommande = ligne_de_commande.idCommande AND ligne_de_commande.idProduit = produit.idProduit group by commande.idCommande ")

        End Function
        Public Shared Function GetNBCommandes() As Integer
            Return GestionBDD.Executer_Requete_Scalaire("Select Count(*) From Commande")
        End Function
        Public Shared Function GetLesProduitsCommande() As DataTable
            Return GestionBDD.Executer_Requete_Select("SELECT produit.idproduit, libelleproduit, prixhtproduit, quantitecom,(prixhtproduit * quantitecom) AS MontantLigneHT FROM produit, ligne_de_commande WHERE produit.idProduit = ligne_de_commande.idProduit AND idcommande = 1")
        End Function
        Public Shared Function GetLesProduitsByCommande(idcom As Integer) As DataTable
            Return GestionBDD.Executer_Requete_Select("SELECT produit.idproduit, libelleproduit, prixhtproduit, quantitecom,(prixhtproduit * quantitecom) AS MontantLigneHT FROM produit, ligne_de_commande WHERE produit.idProduit = ligne_de_commande.idProduit AND idcommande like '" & idcom & "'")
        End Function

        Public Shared Sub AjouterCommande(idCo As Integer, idPro As String, Qu As Integer)
            Dim code As Integer
            code = GestionBDD.Executer_Requete_Action("Insert into ligne_de_commande values (" & idCo & ", '" & idPro & "','" & Qu & "')")


        End Sub
        Public Shared Sub AjouterCommandes(idc As Integer, dat As Date, idcli As Integer)
            GestionBDD.Executer_Requete_Action("Insert into commande values (" & idc & ", '" & dat & "','" & idcli & "')")
        End Sub
        Public Shared Sub SupprimerLigneComande(idco As Integer, idPro As String)
            GestionBDD.Executer_Requete_Action("delete from ligne_de_commande where idcommande = '" & idco & "' and idProduit = '" & idPro & "'")
        End Sub
        Public Shared Function GetMontantHTByCommande(idcom As Integer) As Integer
            Return GestionBDD.Executer_Requete_Scalaire("Select Sum(prixhtproduit * quantitecom)  From produit, ligne_de_commande WHERE produit.idProduit = ligne_de_commande.idProduit and idcommande like '" & idcom & "'")
        End Function

        Public Shared Function GetMontantHTByNewCommande(id As Integer) As Integer
            Return GestionBDD.Executer_Requete_Scalaire("Select Sum(prixhtproduit * quantitecom)  From produit, ligne_de_commande WHERE produit.idProduit = ligne_de_commande.idProduit and idcommande like '" & id & "'")
        End Function
        Public Shared Sub SupprimerCommande(idcom As Integer)
            GestionBDD.Executer_Requete_Action("Delete From ligne_de_commande where (idCommande=" & idcom & ")")
            GestionBDD.Executer_Requete_Action("Delete From commande where (idCommande=" & idcom & ")")

        End Sub

    End Class

End Namespace
