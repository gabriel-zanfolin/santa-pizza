Public Class frm_relat_card

    Private Sub frm_relat_card_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'prj_pizzariaDataSet.tb_cardapio' table. You can move, or remove it, as needed.
        Me.tb_cardapioTableAdapter.query_cardapio(Me.prj_pizzariaDataSet.tb_cardapio)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class