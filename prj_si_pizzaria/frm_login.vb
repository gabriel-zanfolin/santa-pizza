Public Class frm_login

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_sql_server()
        carregar_tipo_conta()
        carregar_contas_login()
        lbl_processamento.Hide()
        lbl_porcent.Hide()
        ProgressBar1.Hide()
        ProgressBar2.Hide()
        lbl_adm.Hide()
        TabControl1.TabPages.Remove(TabPage3)
        Timer3.Start()
    End Sub
     Private Sub chk_visualizar1_Click(sender As Object, e As EventArgs) Handles chk_visualizar1.Click
        'Try
        If txt_senha_login.PasswordChar = "•" Then
            txt_senha_login.PasswordChar = ""
        Else
            txt_senha_login.PasswordChar = "•"
        End If
        'Catch ex As Exception
        'Exit Sub
        'End Try
    End Sub
    Private Sub chk_visualizar2_Click(sender As Object, e As EventArgs) Handles chk_visualizar2.Click
        ' Try
        If txt_senha.PasswordChar = "•" Or txt_rsenha.PasswordChar = "•" Then
            txt_senha.PasswordChar = ""
            txt_rsenha.PasswordChar = ""
        Else
            txt_senha.PasswordChar = "•"
            txt_rsenha.PasswordChar = "•"
        End If
        'Catch ex As Exception
        'Exit Sub
        ' End Try
    End Sub

    Private Sub txt_usuario_login_DoubleClick(sender As Object, e As EventArgs) Handles txt_usuario_login.DoubleClick
        limpar_login()
    End Sub

    Private Sub txt_usuario_DoubleClick(sender As Object, e As EventArgs) Handles txt_usuario.DoubleClick
        limpar_cadastro_conta()
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        ' Try
        lbl_processamento.Show()
        lbl_porcent.Show()
        Timer1.Start()
        ProgressBar1.Show()
        sql = "select * from tb_login where (usuario='" & txt_usuario_login.Text & "' or email='" & txt_usuario_login.Text & "') and senha='" & txt_senha_login.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            If rs.Fields(4).Value = "ATIVADA" Then
                status_login = 1
                conta = rs.Fields(5).Value
            Else
                status_login = 2
            End If
        Else
            status_login = 0
        End If
        'Catch ex As Exception
        'MsgBox("Erro ao Logar!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Try
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 1
            lbl_processamento.Text = lbl_processamento.Text + 1
        Else
            Timer1.Stop()
            lbl_processamento.Text = 0
            ProgressBar1.Value = 0
            If status_login = 1 Then
                MsgBox("Conta Logada com Sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                aux_usuario = txt_usuario_login.Text
                limpar_login()
                If conta = "OPERADOR" Then
                    frm_menu.ShowDialog()
                Else
                    TabControl1.TabPages.Add(TabPage3)
                    Timer2.Start()
                    lbl_adm.Show()
                    ProgressBar2.Show()
                End If
            ElseIf status_login = 2 Then
                MsgBox("      Conta Desativada!!!" + vbNewLine & _
                       "Contate um Login Administrador!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                limpar_login()
            Else
                MsgBox("Usuário ou Senha Inválidos!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                limpar_login()
            End If
            lbl_processamento.Hide()
            lbl_porcent.Hide()
            ProgressBar1.Hide()
        End If
        'Catch ex As Exception
        'MsgBox("Erro")
        ' End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' Try
        If ProgressBar2.Value < 100 Then
            ProgressBar2.Value = ProgressBar2.Value + 1
        Else
            Timer2.Stop()
            TabControl1.TabPages.Remove(TabPage3)
            ProgressBar2.Value = 0
            lbl_adm.Hide()
            ProgressBar2.Hide()
        End If
        'Catch ex As Exception
        'MsgBox("Erro")
        'End Try
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        With painel_animado
            If .BackColor = Color.Orange Then
                .BackColor = Color.Yellow
            Else
                .BackColor = Color.Orange
            End If
        End With
    End Sub

    Private Sub btn_criar_Click(sender As Object, e As EventArgs) Handles btn_criar.Click
        'Try
        sql = "select * from tb_login where usuario='" & txt_usuario.Text & "' or email='" & txt_email.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            MsgBox("Conta já cadastrada!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            If txt_senha.Text <> txt_rsenha.Text Then
                MsgBox("Senhas não conferem!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            ElseIf txt_usuario.Text = "" Or txt_email.Text = "" Then
                MsgBox("Preencha todos os campos!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If
            gerar_id_conta()
            sql = "insert into tb_login values (" & id_conta & ", " & _
                  "'" & txt_usuario.Text & "', '" & txt_email.Text & "', " & _
                  "'" & txt_senha.Text & "', 'ATIVADA', '" & cmb_tipo_conta.Text & "')"
            rs = db.Execute(sql)
            MsgBox("Conta criada com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            limpar_cadastro_conta()
            carregar_contas_login()
        End If
        'Catch ex As Exception
        'MsgBox("Erro ao gravar!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Private Sub dgv_contas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_contas.CellContentClick
        'Try
        With dgv_contas
            aux_conta = .CurrentRow.Cells(0).Value
            If .CurrentRow.Cells(5).Selected = True Then
                sql = "update tb_login set status_conta='DESATIVADA' where id_conta ='" & aux_conta & "'"
                rs = db.Execute(sql)
            ElseIf .CurrentRow.Cells(6).Selected = True Then
                sql = "update tb_login set status_conta='ATIVADA' where id_conta ='" & aux_conta & "'"
                rs = db.Execute(sql)
            ElseIf .CurrentRow.Cells(7).Selected = True Then
                resp = MsgBox("Deseja realmente excluir a conta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete from tb_login where id_conta ='" & aux_conta & "'"
                    rs = db.Execute(sql)
                End If
            Else
                Exit Sub
            End If
            carregar_contas_login()
        End With
        'Catch ex As Exception
        'MsgBox("Erro ao processar!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Private Sub txt_usuario_LostFocus(sender As Object, e As EventArgs) Handles txt_usuario.LostFocus
        'txt_email.Focus()
    End Sub

    Private Sub txt_email_LostFocus(sender As Object, e As EventArgs) Handles txt_email.LostFocus
        'txt_senha.Focus()
    End Sub

    Private Sub txt_senha_LostFocus(sender As Object, e As EventArgs) Handles txt_senha.LostFocus
        'txt_rsenha.Focus()
    End Sub
End Class