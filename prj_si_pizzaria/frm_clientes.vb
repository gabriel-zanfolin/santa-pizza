Public Class frm_clientes

    Private Sub frm_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        sql = "select * from tb_cadastro where cpf='" & aux_cpf & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            tab_cliente.SelectTab(0)
            txt_cpf2.Text = aux_cpf
            cmb_data_nasc2.Text = rs.Fields(1).Value
            txt_nome2.Text = rs.Fields(2).Value
            txt_cep2.Text = rs.Fields(3).Value
            txt_endereco2.Text = rs.Fields(4).Value
            txt_comp2.Text = rs.Fields(5).Value
            txt_bairro2.Text = rs.Fields(6).Value
            txt_cidade2.Text = rs.Fields(7).Value
            txt_uf2.Text = rs.Fields(8).Value
            txt_fone_fixo2.Text = rs.Fields(9).Value
            txt_celular2.Text = rs.Fields(10).Value
            txt_email2.Text = rs.Fields(11).Value
            diretorio_foto = rs.Fields(12).Value
            img_foto2.Load(diretorio_foto)
        End If
        carregar_pedidos_cliente()
        'Catch ex As Exception
        'MsgBox("Erro ao processar a consulta!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Private Sub btn_voltar1_Click(sender As Object, e As EventArgs) Handles btn_voltar1.Click
        Me.Close()
        frm_grade_clientes.Show()
    End Sub

    Private Sub dgv_pedidos_cliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pedidos_cliente.CellContentClick
        'Try
        With dgv_pedidos_cliente
            If .CurrentRow.Cells(3).Selected = True Then
                id_pedido = .CurrentRow.Cells(0).Value
                Me.Hide()
                aux = 0
                frm_pedido_cliente.Show()
            Else
                Exit Sub
            End If
        End With
        'Catch ex As Exception
        'MsgBox("Erro ao processar!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub
End Class