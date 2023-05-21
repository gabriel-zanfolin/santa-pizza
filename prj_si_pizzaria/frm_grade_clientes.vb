Public Class frm_grade_clientes

    Private Sub frm_grade_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_tipo_cliente()
        carregar_grade_clientes()
    End Sub

    Private Sub dgv_clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_clientes.CellContentClick
        'Try
        With dgv_clientes
            aux_cpf = .CurrentRow.Cells(0).Value
            If .CurrentRow.Cells(3).Selected = True Then
                sql = "select * from tb_cadastro where cpf='" & aux_cpf & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    btn_status = 1
                    Me.Close()
                    frm_cadastro_cliente.Show()
                    frm_cadastro_cliente.btn_voltar2.Show()
                    frm_cadastro_cliente.txt_cpf.Text = aux_cpf
                    frm_cadastro_cliente.txt_nome.Focus()
                End If
            ElseIf .CurrentRow.Cells(4).Selected = True Then
                Me.Close()
                frm_clientes.Show()
            ElseIf .CurrentRow.Cells(5).Selected = True Then
                resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                              "CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete from tb_cadastro where cpf ='" & aux_cpf & "'"
                    rs = db.Execute(sql)
                    carregar_grade_clientes()
                End If
            Else
                Exit Sub
            End If
        End With
        ' Catch ex As Exception
        'MsgBox("Erro ao processar!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub


    Private Sub txt_busca_cliente_TextChanged(sender As Object, e As EventArgs) Handles txt_busca_cliente.TextChanged
        'Try
        With dgv_clientes
            sql = "select * from tb_cadastro where " & cmb_tipo_cliente.Text & " like '" & txt_busca_cliente.Text & "%'"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(10).Value, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
        'Catch ex As Exception
        'Exit Sub
        'End Try
    End Sub
End Class