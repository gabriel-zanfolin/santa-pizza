Public Class frm_relat_pedidos

    Private Sub frm_relat_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'prj_pizzariaDataSet.tb_pedidos' table. You can move, or remove it, as needed.
        Me.tb_pedidosTableAdapter.query_pedidos(Me.prj_pizzariaDataSet.tb_pedidos)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class