Public Class frm_cadastro_cliente

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        ' Try
        With abrir_foto
            .Title = "SELECIONE UMA FOTO"
            .InitialDirectory = Application.StartupPath & "\Fotos"
            .ShowDialog()
            diretorio_foto = .FileName
            If diretorio_foto = "OpenFileDialog1" Then
                diretorio_foto = .InitialDirectory & "\foto_branco.png"
            End If
            img_foto.Load(diretorio_foto)
        End With
        ' Catch ex As Exception
        'Exit Sub
        'End Try
    End Sub

    Private Sub frm_cadastro_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpar_cadastro_cliente()
        btn_voltar2.Hide()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        'Try
        If txt_cpf.Text <> "   .   .   -  " And txt_nome.Text <> "" And txt_cep.Text <> "     -   " And txt_fone_fixo.Text <> "(  )    -    " And txt_celular.Text <> "(  )     -    " And txt_email.Text <> "" Then
            sql = "select * from tb_cadastro where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update tb_cadastro set data_nasc='" & cmb_data_nasc.Text & "', " &
                          "nome='" & txt_nome.Text & "', cep='" & txt_cep.Text & "', " &
                          "endereco='" & txt_endereco.Text & "', comp='" & txt_comp.Text & "', " &
                          "bairro='" & txt_bairro.Text & "', cidade='" & txt_cidade.Text & "', " &
                          "uf='" & txt_uf.Text & "', fone_fixo='" & txt_fone_fixo.Text & "', " &
                          "celular='" & txt_celular.Text & "', email='" & txt_email.Text & "', " &
                          "foto='" & diretorio_foto & "' where cpf='" & txt_cpf.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados atualizados com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                sql = "insert into tb_cadastro values ('" & txt_cpf.Text & "', '" & cmb_data_nasc.Text & "', " &
                                                      "'" & txt_nome.Text & "', '" & txt_cep.Text & "', " &
                                                      "'" & txt_endereco.Text & "', '" & txt_comp.Text & "', " &
                                                      "'" & txt_bairro.Text & "', '" & txt_cidade.Text & "', " &
                                                      "'" & txt_uf.Text & "', '" & txt_fone_fixo.Text & "', " &
                                                      "'" & txt_celular.Text & "', '" & txt_email.Text & "', " &
                                                      "'" & diretorio_foto & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Cliente cadastrado com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
            limpar_cadastro_cliente()
        Else
            MsgBox("Preencha todos os campos!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End If
        'Catch ex As Exception
        'MsgBox("Erro ao cadastrar cliente!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        ' End Try
    End Sub

    Private Sub txt_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf.DoubleClick
        limpar_cadastro_cliente()
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        ' Try
        sql = "select * from tb_cadastro where cpf='" & txt_cpf.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            cmb_data_nasc.Text = rs.Fields(1).Value
            txt_nome.Text = rs.Fields(2).Value
            txt_cep.Text = rs.Fields(3).Value
            txt_endereco.Text = rs.Fields(4).Value
            txt_comp.Text = rs.Fields(5).Value
            txt_bairro.Text = rs.Fields(6).Value
            txt_cidade.Text = rs.Fields(7).Value
            txt_uf.Text = rs.Fields(8).Value
            txt_fone_fixo.Text = rs.Fields(9).Value
            txt_celular.Text = rs.Fields(10).Value
            txt_email.Text = rs.Fields(11).Value
            diretorio_foto = rs.Fields(12).Value
            img_foto.Load(diretorio_foto)
            'Else
            'txt_nome.Focus()
        End If
        'Catch ex As Exception
        '   MsgBox("Erro ao processar a consulta!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Private Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus
        'Try
        If txt_cep.Text <> "     -" Then
            sql = "select * from tb_cep where cep='" & txt_cep.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_endereco.Text = rs.Fields(1).Value
                txt_cidade.Text = rs.Fields(2).Value
                txt_bairro.Text = rs.Fields(3).Value
                txt_uf.Text = rs.Fields(4).Value
                txt_comp.Focus()
            Else
                MsgBox("CEP não Localizado!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                txt_cep.Clear()
                txt_cep.Focus()
            End If
        End If
        'Catch ex As Exception
        'MsgBox("Erro ao processar a consulta!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        'End Try
    End Sub

    Private Sub txt_nome_LostFocus(sender As Object, e As EventArgs) Handles txt_nome.LostFocus
        'txt_cep.Focus()
    End Sub

    Private Sub txt_comp_LostFocus(sender As Object, e As EventArgs) Handles txt_comp.LostFocus
        'txt_fone_fixo.Focus()
    End Sub

    Private Sub txt_fone_fixo_LostFocus(sender As Object, e As EventArgs) Handles txt_fone_fixo.LostFocus
        'txt_celular.Focus()
    End Sub

    Private Sub txt_celular_LostFocus(sender As Object, e As EventArgs) Handles txt_celular.LostFocus
        'txt_email.Focus()
    End Sub

    Private Sub btn_voltar2_Click(sender As Object, e As EventArgs) Handles btn_voltar2.Click
        Me.Close()
        If btn_status = 1 Then
            frm_grade_clientes.Show()
        Else
            frm_cadastro_pedido.Show()
        End If
    End Sub
End Class