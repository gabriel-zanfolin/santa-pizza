Module Module1
    Public diretorio, diretorio_foto As String
    Public db As New ADODB.Connection
    Public rs, rs2 As New ADODB.Recordset
    Public sql, sql2, aux_cpf, resp, conta, aux_usuario, status_pedido, item1, item2, borda, tp_busca, tipo_item, desc1, desc2 As String
    Public cont, id_conta, aux_conta, status_login, status_cardapio, btn_status, id_pedido, pedido_item, aux As Integer
    Public aux_pedido, op_pedidos, op_cardapio, id_item, aux_item, finalizar_pedido, n_item, aux_updt, aux_pedido_item As Integer
    Public tt_pedido, aux_preco, tt_item As Double
    Public audio As Object 'Objeto de voz

    Sub carregar_voz()
        audio = CreateObject("SAPI.SPVOICE")
        audio.volume = 100
        audio.rate = 2 'velocidade da fala
    End Sub

    Sub carregar_grade_clientes()
        'Try
        With frm_grade_clientes.dgv_clientes
            sql = "select * from tb_cadastro order by nome asc"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(10).Value, Nothing, Nothing, Nothing)
                cont = cont + 1
                rs.MoveNext()
            Loop
        End With
        'Catch ex As Exception
        '  MsgBox("Erro ao processar!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Sub carregar_grade_pedidos()
        'Try
        With frm_grade_pedidos.dgv_pedidos
            If op_pedidos = 1 Then
                sql = "select * from tb_pedidos order by pedido desc"
            ElseIf op_pedidos = 2 Then
                sql = "select * from tb_pedidos where status='EM PREPARAÇÃO' order by pedido desc"

            ElseIf op_pedidos = 3 Then
                sql = "select * from tb_pedidos where status='AGUARDANDO RETIRADA' order by pedido desc"
            ElseIf op_pedidos = 4 Then
                sql = "select * from tb_pedidos where status='EM ENTREGA' order by pedido desc"
            ElseIf op_pedidos = 5 Then
                sql = "select * from tb_pedidos where status='FINALIZADO' order by pedido desc"
            End If
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, (rs.Fields(3).Value / 100), rs.Fields(6).Value, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
        'Catch ex As Exception
        'MsgBox("Erro ao processar!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Sub carregar_cardapio()
        ' Try
        With frm_cardapio.dgv_cardapio
            If op_cardapio = 1 Then
                sql = "select * from tb_cardapio order by tipo desc"
            ElseIf op_cardapio = 2 Then
                sql = "select * from tb_cardapio where tipo='PIZZA SALGADA'  order by id_item asc"
            ElseIf op_cardapio = 3 Then
                sql = "select * from tb_cardapio where tipo='PIZZA DOCE' order by id_item asc"
            ElseIf op_cardapio = 4 Then
                sql = "select * from tb_cardapio where tipo='BEBIDA' order by id_item asc"
            End If
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, (rs.Fields(3).Value / 100.0), Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
        'Catch ex As Exception
        '    MsgBox("Erro ao processar!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Sub carregar_contas_login()
        'Try
        With frm_login.dgv_contas
            sql = "select * from tb_login order by id_conta asc"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(5).Value, rs.Fields(4).Value, Nothing, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
        'Catch ex As Exception
        '  MsgBox("Erro ao processar!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Sub carregar_itens_pedido_cliente()
        'Try
        With frm_pedido_cliente
            .dgv_dados_pedido.Rows.Clear()
            sql = "select * from tb_itens_pedido where pedido='" & id_pedido & "'"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                sql2 = "select * from tb_cardapio where id_item='" & rs.Fields(2).Value & "'"
                rs2 = db.Execute(sql2)
                If rs2.EOF = False Then
                    desc1 = rs2.Fields(1).Value
                    If rs2.Fields(2).Value = "PIZZA SALGADA" Or rs2.Fields(2).Value = "PIZZA DOCE" Then
                        borda = rs.Fields(5).Value
                    Else
                        borda = "N.A."
                    End If
                End If
                sql2 = "select * from tb_cardapio where id_item='" & rs.Fields(4).Value & "'"
                rs2 = db.Execute(sql2)
                If rs2.EOF = False Then
                    desc2 = rs2.Fields(1).Value
                Else
                    desc2 = "N.A."
                End If
                pedido_item = rs.Fields(0).Value
                n_item = -(id_pedido * 100 - pedido_item)
                .dgv_dados_pedido.Rows.Add(n_item, desc1, desc2, borda, rs.Fields(6).Value, rs.Fields(3).Value, (rs.Fields(7).Value / 100))
                rs.MoveNext()
            Loop
            calcula_total()
            .lbl_total2.Text = tt_pedido / 100
            sql = "select * from tb_pedidos where pedido='" & id_pedido & "'"
            rs = db.Execute(sql)
            .lbl_entrega.Text = rs.Fields(7).Value
            .lbl_pagamento.Text = rs.Fields(5).Value
        End With
        'Catch ex As Exception
        'MsgBox("Erro ao processar!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Sub carregar_itens_pedido()
        'Try
        With frm_cadastro_pedido
            .dgv_itens_pedido.Rows.Clear()
            sql = "select * from tb_itens_pedido where pedido='" & id_pedido & "'"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                sql2 = "select * from tb_cardapio where id_item='" & rs.Fields(2).Value & "'"
                rs2 = db.Execute(sql2)
                If rs2.EOF = False Then
                    desc1 = rs2.Fields(1).Value
                    If rs2.Fields(2).Value = "PIZZA SALGADA" Or rs2.Fields(2).Value = "PIZZA DOCE" Then
                        borda = rs.Fields(5).Value
                    Else
                        borda = "N.A."
                    End If
                End If
                sql2 = "select * from tb_cardapio where id_item='" & rs.Fields(4).Value & "'"
                rs2 = db.Execute(sql2)
                If rs2.EOF = False Then
                    desc2 = rs2.Fields(1).Value
                Else
                    desc2 = "N.A."
                End If
                pedido_item = rs.Fields(0).Value
                n_item = -(id_pedido * 100 - pedido_item)
                .dgv_itens_pedido.Rows.Add(n_item, desc1, desc2, borda, rs.Fields(6).Value, rs.Fields(3).Value, (rs.Fields(7).Value / 100), Nothing, Nothing)
                rs.MoveNext()
            Loop
            calcula_total()
            .lbl_total.Text = tt_pedido / 100
        End With
        'Catch ex As Exception
        'MsgBox("Erro ao processar!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Sub carregar_info_it_pedido()
        'Try
        With frm_cadastro_pedido
            sql = "select * from tb_itens_pedido where pedido_item='" & pedido_item & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                .tab_pedido.SelectTab(0)
                .txt_id.Text = rs.Fields(2).Value
                sql2 = "select * from tb_cardapio where id_item='" & .txt_id.Text & "'"
                rs2 = db.Execute(sql2)
                If rs2.EOF = False Then
                    .txt_item.Text = rs2.Fields(1).Value
                End If
                .txt_obs.Text = rs.Fields(3).Value
                If rs.Fields(4).Value <> 0 Then
                    .txt_id2.Text = rs.Fields(4).Value
                    sql2 = "select * from tb_cardapio where id_item='" & .txt_id2.Text & "'"
                    rs2 = db.Execute(sql2)
                    If rs2.EOF = False Then
                        .txt_item2.Text = rs2.Fields(1).Value
                    End If
                Else
                    .txt_id2.Text = ""
                    .txt_item2.Text = ""
                End If
                .cmb_borda.Text = rs.Fields(5).Value
                .txt_qtde.Text = rs.Fields(6).Value
            End If
            aux_updt = 1
        End With
        'Catch ex As Exception
        'MsgBox("Erro ao processar!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Sub carregar_pedidos_cliente()
        'Try
        With frm_clientes
            .dgv_pedidos_cliente.Rows.Clear()
            sql = "select * from tb_pedidos where cliente='" & .txt_cpf2.Text & "'"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                .dgv_pedidos_cliente.Rows.Add(rs.Fields(0).Value, rs.Fields(3).Value / 100, rs.Fields(6).Value, Nothing)
                rs.MoveNext()
            Loop
        End With
        'Catch ex As Exception
        '   MsgBox("Erro ao carregar pedidos!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Sub conecta_banco_sql_server()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=LAPTOP-IQ7JSTTD\SQLEXPRESS;Initial Catalog=prj_pizzaria;trusted_connection=yes;")
            'MsgBox("Conexão realizada com sucesso - SQLSERVER!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar - SQLSERVER!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub limpar_cadastro_cliente()
        With frm_cadastro_cliente
            .txt_cpf.Clear()
            .txt_nome.Clear()
            .txt_cep.Clear()
            .txt_endereco.Clear()
            .txt_bairro.Clear()
            .txt_cidade.Clear()
            .txt_uf.Clear()
            .txt_comp.Clear()
            .txt_fone_fixo.Clear()
            .txt_celular.Clear()
            .txt_email.Clear()
            diretorio_foto = Application.StartupPath & "\Fotos\foto_branco.png"
            .img_foto.Load(diretorio_foto)
            .txt_cpf.Focus()
        End With
    End Sub

    Sub carregar_tipo_conta()
        ' Try
        With frm_login.cmb_tipo_conta.Items
            .Add("ADMINISTRADOR")
            .Add("OPERADOR")
        End With
        frm_login.cmb_tipo_conta.SelectedIndex = 1
        'Catch ex As Exception
        'MsgBox("Erro ao carregar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        ' End Try
    End Sub

    Sub carregar_tipo_pagamento()
        ' Try
        With frm_cadastro_pedido.cmb_pagamento.Items
            .Add("DINHEIRO")
            .Add("CARTÃO DE DÉBITO")
            .Add("CARTÃO DE CRÉDITO")
        End With
        frm_cadastro_pedido.cmb_pagamento.SelectedIndex = 1
        'Catch ex As Exception
        'MsgBox("Erro ao carregar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        ' End Try
    End Sub

    Sub carregar_tipo_borda()
        ' Try
        With frm_cadastro_pedido.cmb_borda.Items
            .Add("TRADICIONAL")
            .Add("RECHEADA")
            .Add("N.A.")
        End With
        frm_cadastro_pedido.cmb_borda.SelectedIndex = 1
        '  Catch ex As Exception
        '    MsgBox("Erro ao carregar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        'End Try
    End Sub

    Sub carregar_tipo_entrega()
        ' Try
        With frm_cadastro_pedido.cmb_entrega.Items
            .Add("DELIVERY")
            .Add("RETIRA NO LOCAL")
        End With
        frm_cadastro_pedido.cmb_entrega.SelectedIndex = 1
        'Catch ex As Exception
        '  MsgBox("Erro ao carregar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        'End Try
    End Sub

    Sub carregar_tpbusca_cardapio()
        'Try
        With frm_cardapio.cmb_tipo_cardapio.Items
            .Add("CÓDIGO")
            .Add("DESCRIÇÃO")
        End With
        frm_cardapio.cmb_tipo_cardapio.SelectedIndex = 1
        ' Catch ex As Exception
        '  MsgBox("Erro ao carregar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        'End Try
    End Sub

    Sub carregar_tipo_cardapio()
        'Try
        With frm_cadastro_cardapio.cmb_tipo_item.Items
            .Add("PIZZA SALGADA")
            .Add("PIZZA DOCE")
            .Add("BEBIDA")
            .Add("OUTRO")
        End With
        frm_cardapio.cmb_tipo_cardapio.SelectedIndex = 1
        'Catch ex As Exception
        ' MsgBox("Erro ao carregar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        'End Try
    End Sub

    Sub carregar_tipo_cliente()
        Try
            With frm_grade_clientes.cmb_tipo_cliente.Items
                .Add("CPF")
                .Add("NOME")
            End With
            frm_grade_clientes.cmb_tipo_cliente.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("Erro ao carregar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_tipo_pedido()
        'Try
        With frm_grade_pedidos.cmb_tipo_pedido.Items
            .Add("PEDIDO")
            .Add("CLIENTE")
        End With
        frm_grade_pedidos.cmb_tipo_pedido.SelectedIndex = 1
        'Catch ex As Exception
        '   MsgBox("Erro ao carregar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        'End Try
    End Sub

    Sub gerar_id_conta()
        sql = "select * from tb_login order by id_conta desc"
        rs = db.Execute(sql)
        If rs.BOF = True Then
            id_conta = 1
        Else
            id_conta = rs.Fields(0).Value + 1
        End If
    End Sub

    Sub gerar_id_pedido()
        sql = "select * from tb_pedidos order by pedido desc"
        rs = db.Execute(sql)
        If rs.BOF = True Then
            id_pedido = 100001
        Else
            id_pedido = rs.Fields(0).Value + 1
        End If
    End Sub

    Sub gerar_id_item()
        sql = "select * from tb_cardapio order by id_item desc"
        rs = db.Execute(sql)
        If rs.BOF = True Then
            id_item = 1
        Else
            id_item = rs.Fields(0).Value + 1
        End If
    End Sub

    Sub limpar_login()
        With frm_login
            .txt_usuario_login.Clear()
            .txt_senha_login.Clear()
            .txt_usuario_login.Focus()
        End With
    End Sub

    Sub limpar_cadastro_conta()
        With frm_login
            .txt_usuario.Clear()
            .txt_email.Clear()
            .txt_senha.Clear()
            .txt_rsenha.Clear()
            .txt_usuario.Focus()
        End With
    End Sub

    Sub limpar_cadastro_pedido()
        With frm_cadastro_pedido
            aux_updt = 0
            .txt_id.Clear()
            .txt_qtde.Clear()
            .txt_item.Clear()
            .txt_obs.Clear()
            .txt_id2.Clear()
            .txt_item2.Clear()
            .txt_id.Focus()
        End With
    End Sub

    Sub limpar_dados_cliente()
        With frm_cadastro_pedido
            .txt_cpf3.Clear()
            .txt_nome3.Clear()
            .txt_fone_fixo3.Clear()
            .txt_celular3.Clear()
            .txt_cpf3.Focus()
        End With
    End Sub

    Sub calcula_total()
        'Try
        With frm_cadastro_pedido
            tt_pedido = 0
            sql = "select * from tb_itens_pedido where pedido='" & id_pedido & "'"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                tt_pedido += rs.Fields(7).Value
                rs.MoveNext()
            Loop
        End With
        'Catch ex As Exception
        'MsgBox("Erro ao processar!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Sub limpar_cadastro_cardapio()
        With frm_cadastro_cardapio
            .txt_descricao.Clear()
            .txt_preco.Clear()
            gerar_id_item()
        End With
    End Sub

    Sub atualiza_pedido()
        'Try
        With frm_grade_pedidos
            sql = "select * from tb_pedidos where pedido='" & aux_pedido & "'"
            rs = db.Execute(sql)
            If rs.Fields(6).Value = "EM PREPARAÇÃO" Then
                If rs.Fields(7).Value = "DELIVERY" Then
                    status_pedido = "EM ENTREGA"
                Else
                    status_pedido = "AGUARDANDO RETIRADA"
                End If
            ElseIf rs.Fields(6).Value = "FINALIZADO" Then
                MsgBox("O pedido '" & aux_pedido & "' já está finalizado!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            Else
                status_pedido = "FINALIZADO"
            End If
            resp = MsgBox("Deseja realmente atualizar o status do pedido '" & aux_pedido & "'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = MsgBoxResult.Yes Then
                sql = "update tb_pedidos set status='" & status_pedido & "' where pedido='" & aux_pedido & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Status atualizado com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                carregar_grade_pedidos()
            Else
                Exit Sub
            End If
        End With
        'Catch ex As Exception
        'MsgBox("Erro ao processar!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

End Module
