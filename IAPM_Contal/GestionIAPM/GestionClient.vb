
Namespace Global.ModeleIAPM

    Public Class GestionClient
        Public Shared Function GetLesClients() As DataTable
            Return GestionBDD.Executer_Requete_Select("Select * from Utilisateur")
        End Function
        Public Shared Function GetLesClientsCB() As DataTable
            Return GestionBDD.Executer_Requete_Select("Select id_Utilisateur,CONCAT(Nom_Utilisateur,' ',Prenom_Utilisateur) as Patronyme from Utilisateur")
        End Function
        Public Shared Function GetNBClients() As Integer
            Return GestionBDD.Executer_Requete_Scalaire("Select COUNT(id_Utilisateur) from Utilisateur")
        End Function

        Public Shared Sub AjouterClient(id As Integer, nom As String, prenom As String, rue As String, cp As Integer, ville As String)
            GestionBDD.Executer_Requete_Action("Insert into Utilisateur values (" & id & ", '" & nom & "','" & prenom & "','" & rue & "','" & cp & "','" & ville & "')")
        End Sub
        Public Shared Sub SupprimerClient(id As Integer)
            GestionBDD.Executer_Requete_Action("delete from Utilisateur where id_Utilisateur = " & id)
        End Sub
        Public Shared Sub ModifierClient(id As Integer, nom As String, prenom As String, rue As String, cp As Integer, ville As String)
            GestionBDD.Executer_Requete_Action("update Utilisateur set Nom_Utilisateur ='" & nom & "',Prenom_Utilisateur = '" & prenom & "' , AdRue_Utilisateur = '" & rue & "' ,AdCp_Utilisateur = '" & cp & "', AdVille_Utilisateur = '" & ville & "' where id_Utilisateur = '" & id & "'")
        End Sub
        Public Shared Function RechercherClient(id As String)
            Return GestionBDD.Executer_Requete_Select("SELECT Nom_Utilisateur, Prenom_Utilisateur, AdRue_Utilisateur, AdCp_Utilisateur, AdVille_Utilisateur FROM Utilisateur Where ((Nom_Utilisateur like '%" & id & "%') or (Prenom_Utilisateur like '%" & id & "%') or (AdRue_Utilisateur like '%" & id & "%') or (AdCp_Utilisateur like '%" & id & "%') or (AdVille_Utilisateur like '%" & id & "%'))")
        End Function


        Public Shared Function GetLesClientsByCom(idcom) As DataTable
            Return GestionBDD.Executer_Requete_Select("Select id_Utilisateur,CONCAT(Nom_Utilisateur,' ',Prenom_Utilisateur) as Patronyme from Utilisateur,Commande where (commande.idCli=Utilisateur.id_Utilisateur) and idCommande like '" & idcom & "'")
        End Function
    End Class
End Namespace
