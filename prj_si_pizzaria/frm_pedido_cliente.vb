Public Class frm_pedido_cliente

    Private Sub frm_pedido_cliente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If aux = 0 Then
            frm_clientes.Show()
        Else
            frm_grade_pedidos.Show()
        End If
    End Sub

    Private Sub frm_pedido_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_itens_pedido_cliente()
        'calcula_total()
        lbl_pedido2.Text = id_pedido
    End Sub

    Private Sub btn_voltar3_Click(sender As Object, e As EventArgs) Handles btn_voltar3.Click
        Me.Close()
        If aux = 0 Then
            frm_clientes.Show()
        Else
            frm_grade_pedidos.Show()
        End If
    End Sub

    Private Sub dgv_dados_pedido_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados_pedido.CellContentClick

    End Sub
End Class