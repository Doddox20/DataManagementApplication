Imports ModeleIAPM
Public Class FrmListeClients2
    Private Sub FrmListeClients2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmStart
        DataGridClients.DataSource = GestionInterface.RemplaceSlashApostrophesDataTable(GestionClient.GetLesClients())

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub DataGridClients_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridClients.CellContentClick

    End Sub
End Class