Public Class frm_relat_clientes_cid

    Private Sub frm__relat_clientes_cid_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        'TODO: This line of code loads data into the 'prj_pizzariaDataSet.tb_cadastro' table. You can move, or remove it, as needed.
        Me.tb_cadastroTableAdapter.query_clientes_cidade(Me.prj_pizzariaDataSet.tb_cadastro, txt_busca_cidade.Text.ToString)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class