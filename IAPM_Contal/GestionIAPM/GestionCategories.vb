Namespace Global.ModeleIAPM

    Public Class GestionCategories
        Public Shared Function GetLesCategorie(ComboBoxCategorie) As DataTable
            Return GestionBDD.Executer_Requete_Select(“Select * from Categorie”)
        End Function
    End Class

End Namespace

