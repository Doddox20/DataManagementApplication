Imports GestionIAPM
Namespace Global.ModeleIAPM


    Public Class GestionProduit
        Public Shared Function GetLesProduits() As DataTable
            Return GestionBDD.Executer_Requete_Select(“Select * from Produit”)
        End Function
        Public Shared Function GetLesProduitsDG() As DataTable
            Return GestionBDD.Executer_Requete_Select(“Select LibelleProduit,PrixHTProduit,QteStockProduit,NomFournisseur,Libelle from Produit,categorie,fournisseur WHERE (Fournisseur.idFournisseur = Produit.idFournisseur) and (Produit.idCategorie = Categorie.idCategorie) order by idProduit”)
        End Function
        Public Shared Function GetNBProduits() As Integer
            Return GestionBDD.Executer_Requete_Scalaire("Select Count(*) From Produit")
        End Function

        Public Shared Sub AjouterProduit(id As Integer, n As String, p As String, r As String, cp As String, v As String)
            Dim ph = "none"
            GestionBDD.Executer_Requete_Action("Insert into produit values (" & id & " ,'" & n & "','" & p & "','" & r & "','" & cp & "','" & v & "','" & ph & "')")
        End Sub

        Public Shared Sub SupprimerProduit(id As Integer)
            'GestionBDD.Executer_Requete_Action("delete from produit where idProduit = " & id)
            Dim MaRequete As String = "CALL _deleteProduitById (@id)"
            GestionBDD.MaCommande.CommandText = MaRequete
            GestionBDD.MaCommande.Parameters.Clear() ' Supprimer tous les paramètres existants
            GestionBDD.MaCommande.Parameters.AddWithValue("@id", id)

            GestionBDD.Executer_Requete_Action(MaRequete)

        End Sub

        Public Shared Sub ModifierProduit(id As Integer, n As String, p As String, r As String, cp As String, v As String)
            GestionBDD.Executer_Requete_Action("update produit set LibelleProduit = '" & n & "',PrixHTProduit = '" & p & "',QteStockProduit = '" & r & "',idFournisseur = '" & cp & "',idCategorie = '" & v & "' Where idProduit = " & id & "")
        End Sub

        'Public Shared Function RechercherProduit(re As String)
        '    Return GestionBDD.Executer_Requete_Select("Select * FROM Produit where ((LibelleProduit LIKE '%" & re & "%') or (PrixHTProduit like '%" & re & "%') or (QteStockProduit like '%" & re & "%') or (idFourn like '%" & re & "%') or  (idCat like '%" & re & "%'))")
        'End Function

        Public Shared Function RechercherProduit(re As String)
            Dim MaRequete As String = "CALL _RechercherProduit (@re)"
            GestionBDD.MaCommande.CommandText = MaRequete
            GestionBDD.MaCommande.Parameters.Clear() ' Supprimer tous les paramètres existants
            GestionBDD.MaCommande.Parameters.AddWithValue("@re", re)

            Return GestionBDD.Executer_Requete_Select(MaRequete)
        End Function

        Public Shared Function GetLesProduitsByCAtegorie(idcat As Integer) As DataTable
            Return GestionBDD.Executer_Requete_Select(“Select * from Produit where idCategorie like " & idcat & "”)
        End Function

    End Class
End Namespace