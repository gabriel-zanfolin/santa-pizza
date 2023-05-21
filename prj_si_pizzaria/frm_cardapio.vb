Public Class frm_cardapio

    Private Sub frm_cardapio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_tpbusca_cardapio()
        carregar_cardapio()
        'With dgv_cardapio
        'If status_cardapio = 1 Then
        '.Column4.Hide()
        '.Column5.Hide()
        'End If
        'End With
    End Sub

    Private Sub btn_cadastrar_item_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_item.Click
        Me.Hide()
        frm_cadastro_cardapio.Show()
    End Sub

    Private Sub txt_busca_cardapio_TextChanged(sender As Object, e As EventArgs) Handles txt_busca_cardapio.TextChanged
        'Try
        With dgv_cardapio
            If cmb_tipo_cardapio.Text = "DESCRIÇÃO" Then
                tp_busca = "descricao"
            Else
                tp_busca = "id_item"
            End If
            If op_cardapio = 2 Then
                tipo_item = "PIZZA SALGADA"
            ElseIf op_cardapio = 3 Then
                tipo_item = "PIZZA DOCE"
            ElseIf op_cardapio = 4 Then
                tipo_item = "BEBIDA"
            Else
                tipo_item = "GERAL"
            End If
            sql = "select * from tb_cardapio where " & tp_busca & " like '" & txt_busca_cardapio.Text & "%'"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                If rs.Fields(2).Value = tipo_item Or tipo_item = "GERAL" Then
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, (rs.Fields(3).Value / 100), Nothing, Nothing)
                End If
                rs.MoveNext()
            Loop
        End With
        'Catch ex As Exception
        'Exit Sub
        'End Try
    End Sub

    Private Sub dgv_cardapio_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cardapio.CellContentClick
        'Try
        aux_item = 0
        With dgv_cardapio
            id_item = .CurrentRow.Cells(0).Value
            If .CurrentRow.Cells(3).Selected = True Then
                id_item = .CurrentRow.Cells(0).Value
                sql = "select * from tb_cardapio where id_item='" & id_item & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    Me.Hide()
                    aux_item = 1
                    frm_cadastro_cardapio.Show()
                End If
            ElseIf .CurrentRow.Cells(4).Selected = True Then
                resp = MsgBox("Deseja realmente excluir o item '" & id_item & "'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete from tb_cardapio where id_item ='" & id_item & "'"
                    rs = db.Execute(sql)
                    carregar_cardapio()
                End If
            Else
                Exit Sub
            End If
        End With
        'Catch ex As Exception
        'MsgBox("Erro ao processar!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub
End Class