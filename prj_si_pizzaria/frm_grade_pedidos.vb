Public Class frm_grade_pedidos

    Private Sub frm_grade_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_tipo_pedido()
        carregar_grade_pedidos()
    End Sub

    Private Sub txt_busca_pedido_TextChanged(sender As Object, e As EventArgs) Handles txt_busca_pedido.TextChanged
        'Try
        With dgv_pedidos
            sql = "select * from tb_pedidos where " & cmb_tipo_pedido.Text & " like '" & txt_busca_pedido.Text & "%'"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(6).Value, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
        'Catch ex As Exception
        'Exit Sub
        ' End Try
    End Sub

    Private Sub dgv_pedidos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pedidos.CellContentClick
        'Try
        With dgv_pedidos
            If .CurrentRow.Cells(5).Selected = True Then
                aux_pedido = .CurrentRow.Cells(0).Value
                sql = "select * from tb_pedidos where pedido='" & aux_pedido & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    atualiza_pedido()
                End If
            ElseIf .CurrentRow.Cells(6).Selected = True Then
                id_pedido = .CurrentRow.Cells(0).Value
                Me.Hide()
                aux = 1
                frm_pedido_cliente.Show()
            ElseIf .CurrentRow.Cells(7).Selected = True Then
                aux_cpf = .CurrentRow.Cells(1).Value
                resp = MsgBox("Deseja realmente cancelar o pedido '" & aux_pedido & "'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete from tb_pedidos where pedido ='" & aux_pedido & "'"
                    rs = db.Execute(sql)
                    carregar_grade_pedidos()
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