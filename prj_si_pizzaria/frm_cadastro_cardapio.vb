Public Class frm_cadastro_cardapio

    Private Sub frm_cadastro_cardapio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_tipo_cardapio()
        If aux_item = 1 Then
            sql = "select * from tb_cardapio where id_item='" & id_item & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_descricao.Text = rs.Fields(1).Value
                cmb_tipo_item.Text = rs.Fields(2).Value
                txt_preco.Text = rs.Fields(3).Value / 100
                txt_descricao.Focus()
            End If
        Else
            gerar_id_item()
        End If
        lbl_id.Text = id_item
    End Sub

    Private Sub btn_salvar3_Click(sender As Object, e As EventArgs) Handles btn_salvar3.Click
        'Try
        If txt_descricao.Text <> "" And txt_preco.Text <> "" Then
            sql = "select * from tb_cardapio where id_item='" & lbl_id.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update tb_cardapio set descricao='" & txt_descricao.Text & "', tipo='" & cmb_tipo_item.Text & "', " & _
                      "preco='" & txt_preco.Text * 100 & "' where id_item='" & lbl_id.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados atualizados com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                sql = "insert into tb_cardapio values ('" & lbl_id.Text & "', '" & txt_descricao.Text & "', " &
                                                      "'" & cmb_tipo_item.Text & "', '" & txt_preco.Text * 100 & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Item cadastrado com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
            limpar_cadastro_cardapio()
            lbl_id.Text = id_item
        Else
            MsgBox("Preencha todos os campos!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End If
        'Catch
        'MsgBox("Erro!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Private Sub btn_voltar3_Click(sender As Object, e As EventArgs) Handles btn_voltar3.Click
        Me.Close()
        frm_cardapio.Show()
        carregar_cardapio()
    End Sub
End Class