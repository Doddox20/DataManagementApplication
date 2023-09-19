Imports System.Windows.Forms
Imports MySql.Data

Namespace Global.ModeleIAPM


    Public Class GestionBDD
        Public Shared MaConnexion As New MySqlClient.MySqlConnection
        Public Shared MaCommande As New MySqlClient.MySqlCommand
        'Public Shared MaCommandeSpecialRequete As New MySqlClient.MySqlCommand
        Public Shared MonAdapter As New MySqlClient.MySqlDataAdapter
        Public Shared MonJeuDeDonnees As New Data.DataSet
        Public Shared MaRequete As String
        Public Shared Serveur As String
        Public Shared BDD As String
        Public Shared Login As String
        Public Shared Mdp As String
        Public Shared machaine As String = "Data Source=" & Serveur & ";Initial Catalog=" & BDD & ";User ID=" & Login & ";Password=" & Mdp & ""
        Public Shared CptVue As Integer = 0
        Public Shared Sub SeConnecter()
            machaine = "Data Source=" & Serveur & ";Initial Catalog=" & BDD & ";User ID=" & Login & ";Password=" & Mdp & ""

            MaConnexion.ConnectionString = machaine
            MaConnexion.Open()
            MonJeuDeDonnees = New Data.DataSet("ppe_marchand_contall")
            MonJeuDeDonnees.Clear()
            MaCommande.CommandType = CommandType.Text
            MaCommande.Connection = MaConnexion
        End Sub
        Public Shared Function Executer_Requete_Select(ByVal marequeteselect As String) As Data.DataTable
            Dim result As New Data.DataTable

            Dim MaVue As String = "MaVue" & CptVue
            Try
                MaCommande.CommandText = marequeteselect
                MonAdapter.SelectCommand = MaCommande
                MonAdapter.Fill(MonJeuDeDonnees, MaVue)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            result = MonJeuDeDonnees.Tables(MaVue)
            CptVue = CptVue + 1
            Return result
        End Function

        Public Shared Function Generer_Cle_Primaire(ByVal nomcle As String, ByVal nomtable As String) As Integer
            MaCommande.CommandText = "SELECT Max(" & nomcle & ") FROM " & nomtable
            MonAdapter.SelectCommand = MaCommande
            Return CInt(MaCommande.ExecuteScalar + 1)
            'ExecuteScalar : Cas des requêtes renvoyant un résultat unique!
        End Function
        Public Shared Function Executer_Requete_Scalaire(ByVal marequetescalaire As String) As Integer
            MaCommande.CommandText = marequetescalaire
            Return CInt(MaCommande.ExecuteScalar)
            'ExecuteScalar : Cas des requêtes renvoyant un résultat unique: count/max/sum!
        End Function
        Public Shared Function Executer_Requete_Action(ByVal marequeteaction As String) As Integer
            Try
                MaCommande.CommandText = marequeteaction
                MaCommande.ExecuteNonQuery()
            Catch ex As Exception
                If TypeOf ex Is InvalidCastException Then
                    Return 0
                ElseIf TypeOf ex Is InvalidConstraintException Then
                    Return 1
                Else
                    Return 2
                End If


            End Try
        End Function
        Public Shared Sub ViderJeuDeDonnées()
            MonJeuDeDonnees.Clear()
        End Sub

    End Class

End Namespace