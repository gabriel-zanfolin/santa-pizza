Public Class frm_menu

    Private Sub frm_menu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm_login.Show()
        limpar_login()
    End Sub

    Private Sub frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Renderer = New CustomRenderer()

        conecta_banco_sql_server()
        cont = 1
        frm_login.Hide()
        lbl_usuario.Text = UCase(aux_usuario)
        lbl_data.Text = Date.Today
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        carregar_voz()
        audio.speak("Bem vindo '" & aux_usuario & "'")
        op_pedidos = 1
    End Sub

    Private Class CustomRenderer
        Inherits ToolStripProfessionalRenderer

        Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
            If e.Item.Selected AndAlso e.Item.Enabled Then
                Dim customColor As Color = Color.Red ' Substitua pela cor desejada
                Using brush As New SolidBrush(customColor)
                    e.Graphics.FillRectangle(brush, e.Item.ContentRectangle)
                End Using
            Else
                MyBase.OnRenderMenuItemBackground(e)
            End If
        End Sub
    End Class

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = TimeOfDay
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        resp = MsgBox("Deseja realmente sair?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = MsgBoxResult.Yes Then
            Me.Close()
            frm_login.Show()
            limpar_login()
        End If
    End Sub

    Private Sub btn_edit_cardapio_Click(sender As Object, e As EventArgs) Handles btn_edit_cardapio.Click
        op_cardapio = 1
        frm_cardapio.Show()
        frm_cardapio.lbl_cardapio.Text = "CARDÁPIO GERAL"
        frm_cardapio.btn_cadastrar_item.Show()
        frm_cardapio.icone_mais.Show()
    End Sub

    Private Sub GeralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeralToolStripMenuItem.Click
        op_cardapio = 1
        frm_cardapio.Show()
        frm_cardapio.lbl_cardapio.Text = "CARDÁPIO GERAL"
        frm_cardapio.btn_cadastrar_item.Hide()
        frm_cardapio.icone_mais.Hide()
    End Sub

    Private Sub PizzasSalgadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PizzasSalgadasToolStripMenuItem.Click
        op_cardapio = 2
        frm_cardapio.Show()
        frm_cardapio.lbl_cardapio.Text = "CARDÁPIO PIZZAS SALGADAS"
        frm_cardapio.btn_cadastrar_item.Hide()
        frm_cardapio.icone_mais.Hide()
    End Sub

    Private Sub PizzasDocesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PizzasDocesToolStripMenuItem.Click
        op_cardapio = 3
        frm_cardapio.Show()
        frm_cardapio.lbl_cardapio.Text = "CARDÁPIO PIZZAS DOCES"
        frm_cardapio.btn_cadastrar_item.Hide()
        frm_cardapio.icone_mais.Hide()
    End Sub


    Private Sub BebidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BebidasToolStripMenuItem.Click
        op_cardapio = 4
        frm_cardapio.Show()
        frm_cardapio.lbl_cardapio.Text = "CARDÁPIO BEBIDAS"
        frm_cardapio.btn_cadastrar_item.Hide()
        frm_cardapio.icone_mais.Hide()

    End Sub

    Private Sub btn_cadast_pedido_Click(sender As Object, e As EventArgs) Handles btn_cadast_pedido.Click
        frm_cadastro_pedido.Show()
    End Sub

    Private Sub TodosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TodosToolStripMenuItem1.Click
        op_pedidos = 1
        frm_grade_pedidos.Show()
    End Sub

    Private Sub btn_cadast_client_Click(sender As Object, e As EventArgs) Handles btn_cadast_client.Click
        frm_cadastro_cliente.Show()
    End Sub

    Private Sub EmPreparaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmPreparaçãoToolStripMenuItem.Click
        op_pedidos = 2
        frm_grade_pedidos.Show()
    End Sub

    Private Sub AguardandoRetiradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AguardandoRetiradaToolStripMenuItem.Click
        op_pedidos = 3
        frm_grade_pedidos.Show()
    End Sub

    Private Sub EmEntregaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmEntregaToolStripMenuItem.Click
        op_pedidos = 4
        frm_grade_pedidos.Show()
    End Sub

    Private Sub FechadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FechadosToolStripMenuItem.Click
        op_pedidos = 5
        frm_grade_pedidos.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'Try
        'Timer2.Stop() '                                                                    ==> comentar
        If cont < 5 Then
            cont += 1
        Else
            cont = 1
        End If
        diretorio = Application.StartupPath & "\Imagens\" & cont & ".jpg"
        img_ilustr.Load(diretorio)
        'Catch
        'MsgBox("Erro ao carregar imagem ilustrativa!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        ' End Try
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        With painel_animado2
            If .BackColor = Color.Orange Then
                .BackColor = Color.Yellow
            Else
                .BackColor = Color.Orange
            End If
        End With
    End Sub

    Private Sub CLIENTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLIENTESToolStripMenuItem.Click
        frm_grade_clientes.Show()
    End Sub

    Private Sub PedidosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PedidosToolStripMenuItem1.Click
        frm_relat_pedidos.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        frm_relat_clientes.Show()
    End Sub

    Private Sub ClientesCidadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesCidadeToolStripMenuItem.Click
        frm_relat_clientes_cid.Show()
    End Sub

    Private Sub CardápioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CardápioToolStripMenuItem1.Click
        frm_relat_card.Show()
    End Sub

End Class