Public Class frm_relat_clientes

    Private Sub frm_relat_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'prj_pizzariaDataSet.tb_cadastro' table. You can move, or remove it, as needed.
        Me.tb_cadastroTableAdapter.query_clientes(Me.prj_pizzariaDataSet.tb_cadastro)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class