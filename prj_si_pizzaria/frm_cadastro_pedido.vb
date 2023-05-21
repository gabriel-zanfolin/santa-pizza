Public Class frm_cadastro_pedido

    Private Sub frm_cadastro_pedido_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If finalizar_pedido = 0 Then
            'resp = MsgBox("Tem certeza que deseja sair sem registrar o pedido???", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
            'If resp = MsgBoxResult.Yes Then
            sql = "delete from tb_pedidos where pedido ='" & lbl_pedido.Text & "'"
            rs = db.Execute(sql)
            sql = "delete from tb_itens_pedido where pedido ='" & lbl_pedido.Text & "'"
            rs = db.Execute(sql)
            'End If
        End If
    End Sub

    Private Sub frm_cadastro_pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_tipo_pagamento()
        carregar_tipo_entrega()
        carregar_tipo_borda()
        'dgv_itens_pedido.Rows.Clear()
        limpar_cadastro_pedido()
        carregar_itens_pedido()
        calcula_total()
        finalizar_pedido = 0
        gerar_id_pedido()
        lbl_pedido.Text = id_pedido
    End Sub

    Private Sub txt_cpf3_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf3.DoubleClick
        limpar_dados_cliente()
    End Sub

    Private Sub txt_cpf3_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf3.LostFocus
        'Try
        sql = "select * from tb_cadastro where cpf='" & txt_cpf3.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            txt_nome3.Text = rs.Fields(2).Value
            txt_fone_fixo3.Text = rs.Fields(9).Value
            txt_celular3.Text = rs.Fields(10).Value
        ElseIf txt_cpf3.Text <> "   .   .   -" Then
            resp = MsgBox("    Cliente não cadastrado!!!" + vbNewLine &
                          "Deseja cadastrar um novo cliente? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = MsgBoxResult.Yes Then
                btn_status = 2
                Me.Close()
                frm_cadastro_cliente.Show()
                frm_cadastro_cliente.btn_voltar2.Show()
            Else
                limpar_dados_cliente()
            End If
        End If
        'Catch ex As Exception
        'MsgBox("Erro ao processar a consulta!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Private Sub btn_finalizar_Click(sender As Object, e As EventArgs) Handles btn_finalizar.Click
        'Try
        If txt_cpf3.Text <> "   .   .   -" Then
            sql = "insert into tb_pedidos values ('" & id_pedido & "', '" & txt_cpf3.Text & "', " &
                                                      "'" & Date.Today & "', '" & tt_pedido & "', " &
                                                      "'" & aux_usuario & "', '" & cmb_pagamento.Text & "', " &
                                                      "'EM PREPARAÇÃO', '" & cmb_entrega.Text & "')"
            rs = db.Execute(UCase(sql))
            MsgBox("Pedido registrado com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            finalizar_pedido = 1
            limpar_cadastro_pedido()
            finalizar_pedido = 0
            gerar_id_pedido()
            lbl_pedido.Text = id_pedido
            carregar_itens_pedido()
            calcula_total()
            txt_cpf3.Clear() 'LIMPANDO DADOS DO CLIENTE
            txt_nome3.Clear() 'LIMPANDO DADOS DO CLIENTE
            txt_fone_fixo3.Clear() 'LIMPANDO DADOS DO CLIENTE
            txt_celular3.Clear() 'LIMPANDO DADOS DO CLIENTE
        Else
            MsgBox("Informe os dados do cliente!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End If
        'Catch ex As Exception
        'MsgBox("Erro ao finalizar pedido!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Private Sub btn_adicionar_Click(sender As Object, e As EventArgs) Handles btn_adicionar.Click
        'Try
        If txt_cpf3.Text <> "   .   .   -  " And txt_id.Text <> "" And txt_qtde.Text <> "" Then
            pedido_item = (id_pedido * 100) + 1
            sql = "select * from tb_itens_pedido where pedido_item='" & pedido_item & "'"
            rs = db.Execute(sql)
            While rs.EOF = False
                pedido_item += 1
                sql = "select * from tb_itens_pedido where pedido_item='" & pedido_item & "'"
                rs = db.Execute(sql)
                'rs.MoveNext()
            End While
            sql = "select * from tb_cardapio where id_item='" & txt_id.Text & "'"
            rs = db.Execute(sql)
            aux_preco = rs.Fields(3).Value
            If rs.Fields(2).Value = "PIZZA SALGADA" Or rs.Fields(2).Value = "PIZZA DOCE" Then
                If txt_id2.Text <> "" Then
                    sql = "select * from tb_cardapio where id_item='" & txt_id2.Text & "'"
                    rs = db.Execute(sql)
                    desc2 = rs.Fields(1).Value
                    If aux_preco < rs.Fields(3).Value Then
                        aux_preco = rs.Fields(3).Value
                    End If
                Else
                    desc2 = "N.A."
                End If
                borda = cmb_borda.Text
            Else
                borda = "N.A."
            End If
            tt_item = aux_preco * txt_qtde.Text
            If aux_updt = 0 Then
                sql = "insert into tb_itens_pedido values ('" & pedido_item & "', '" & id_pedido & "', " &
                                                  "'" & txt_id.Text & "', '" & txt_obs.Text & "', " &
                                                  "'" & txt_id2.Text & "', '" & borda & "', " &
                                                  "'" & txt_qtde.Text & "', '" & tt_item & "')"
                rs = db.Execute(UCase(sql))
                'rs = db.Execute(sql)
                MsgBox("Item adicionado ao pedido!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                sql = "update tb_itens_pedido set id_item='" & txt_id.Text & "', " &
                         "obs='" & txt_obs.Text & "', sabor2='" & txt_id2.Text & "', " &
                         "borda='" & borda & "', qtde='" & txt_qtde.Text & "', " &
                        "total_item='" & tt_item & "' where pedido_item='" & aux_pedido_item & "'"
                rs = db.Execute(UCase(sql))
                'rs = db.Execute(sql)
                MsgBox("Item alterado com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
            limpar_cadastro_pedido()
            carregar_itens_pedido()
        Else
            MsgBox("Preencha todos os campos!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End If
        'Catch ex As Exception
        'MsgBox("Erro ao adicionar item ao pedido!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Private Sub txt_id_LostFocus(sender As Object, e As EventArgs) Handles txt_id.LostFocus
        'Try
        sql = "select * from tb_cardapio where id_item='" & txt_id.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            txt_item.Text = rs.Fields(1).Value
        ElseIf txt_id.Text <> "" Then
            MsgBox("Item não cadastrado!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            limpar_cadastro_pedido()
        End If
        'Catch ex As Exception
        'MsgBox("Erro ao processar a consulta!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Private Sub txt_id2_LostFocus(sender As Object, e As EventArgs) Handles txt_id2.LostFocus
        'Try
        sql = "select * from tb_cardapio where id_item='" & txt_id2.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            txt_item2.Text = rs.Fields(1).Value
        ElseIf txt_id2.Text <> "   .   .   -" Then
            MsgBox("Item não cadastrado!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            txt_id2.Clear()
        End If
        ' Catch ex As Exception
        'MsgBox("Erro ao processar a consulta!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Private Sub dgv_itens_pedido_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_itens_pedido.CellContentClick
        'Try
        With dgv_itens_pedido
            pedido_item = .CurrentRow.Cells(0).Value + (id_pedido * 100) 'ESTAVA COMENTADO
            If .CurrentRow.Cells(7).Selected = True Then
                aux_pedido_item = pedido_item
                carregar_info_it_pedido()
            ElseIf .CurrentRow.Cells(8).Selected = True Then
                resp = MsgBox("Deseja realmente excluir o item do pedido?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    pedido_item = .CurrentRow.Cells(0).Value + (id_pedido * 100)
                    sql = "delete from tb_itens_pedido where pedido_item ='" & pedido_item & "'"
                    rs = db.Execute(sql)
                    .Rows.Clear()
                    carregar_itens_pedido()
                End If
            Else
                Exit Sub
            End If
        End With
        'Catch ex As Exception
        '   MsgBox("Erro ao processar!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Private Sub btn_cardapio_Click(sender As Object, e As EventArgs) Handles btn_cardapio.Click
        op_cardapio = 1
        frm_cardapio.Show()
        frm_cardapio.lbl_cardapio.Text = "CARDÁPIO GERAL"
        frm_cardapio.btn_cadastrar_item.Hide()
        frm_cardapio.icone_mais.Hide()
    End Sub

End Class