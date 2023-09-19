Namespace Global.ModeleIAPM


    Public Class GestionFournisseur
        Public Shared Function GetLesFournisseurs(ComboBoxFournisseur) As DataTable
            Return GestionBDD.Executer_Requete_Select(“Select * from Fournisseur”)
        End Function


        Public Shared Function GetNBFournisseur() As Integer
            Return GestionBDD.Executer_Requete_Scalaire("Select Count(*) From Fournisseur")
        End Function

        Public Shared Sub AjouterFournisseur(id As Integer, n As String, p As String, r As String, cp As String, v As String)
            GestionBDD.Executer_Requete_Action("Insert into forunisseur values (" & id & " ,'" & n & "','" & p & "','" & r & "','" & cp & "','" & v & "')")
        End Sub

        Public Shared Sub SupprimerProduit(id As Integer)
            GestionBDD.Executer_Requete_Action("delete from produit where idProduit = " & id)
        End Sub

        Public Shared Sub ModifierProduit(id As Integer, n As String, p As String, r As String, cp As String, v As String)
            GestionBDD.Executer_Requete_Action("update produit set LibelleProduit = '" & n & "',PrixHTProduit = '" & p & "',QteStockProduit = '" & r & "',idFourn = '" & cp & "',idCat = '" & v & "' Where idProduit = " & id & "")
        End Sub

        Public Shared Function RechercherProduit(re As String)
            Return GestionBDD.Executer_Requete_Select("Select * FROM Produit where ((LibelleProduit LIKE '%" & re & "%') or (PrixHTProduit like '%" & re & "%') or (QteStockProduit like '%" & re & "%') or (idFourn like '%" & re & "%') or  (idCat like '%" & re & "%'))")
        End Function
    End Class



End Namespace
