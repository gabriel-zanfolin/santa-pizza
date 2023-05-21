<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro_pedido
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro_pedido))
        Me.tab_pedido = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_cardapio = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_qtde = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_borda = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_obs = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_item2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_id2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_item = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.btn_adicionar = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_pedido = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_entrega = New System.Windows.Forms.ComboBox()
        Me.btn_finalizar = New System.Windows.Forms.Button()
        Me.dgv_itens_pedido = New System.Windows.Forms.DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txt_nome3 = New System.Windows.Forms.TextBox()
        Me.txt_fone_fixo3 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_celular3 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cpf3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmb_pagamento = New System.Windows.Forms.ComboBox()
        Me.tab_pedido.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_itens_pedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab_pedido
        '
        Me.tab_pedido.Controls.Add(Me.TabPage1)
        Me.tab_pedido.Controls.Add(Me.TabPage2)
        Me.tab_pedido.Location = New System.Drawing.Point(12, 106)
        Me.tab_pedido.Name = "tab_pedido"
        Me.tab_pedido.SelectedIndex = 0
        Me.tab_pedido.Size = New System.Drawing.Size(743, 410)
        Me.tab_pedido.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Red
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.btn_cardapio)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.txt_qtde)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.cmb_borda)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txt_obs)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txt_item2)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txt_id2)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_item)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txt_id)
        Me.TabPage1.Controls.Add(Me.btn_adicionar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(735, 384)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "NOVO ITEM"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(503, 299)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 27)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(59, 296)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 27)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'btn_cardapio
        '
        Me.btn_cardapio.BackColor = System.Drawing.Color.Maroon
        Me.btn_cardapio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cardapio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cardapio.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_cardapio.Location = New System.Drawing.Point(486, 286)
        Me.btn_cardapio.Name = "btn_cardapio"
        Me.btn_cardapio.Size = New System.Drawing.Size(183, 48)
        Me.btn_cardapio.TabIndex = 17
        Me.btn_cardapio.Text = "   CARDÁPIO"
        Me.btn_cardapio.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(190, 91)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 16)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "QUANTIDADE"
        '
        'txt_qtde
        '
        Me.txt_qtde.Location = New System.Drawing.Point(193, 110)
        Me.txt_qtde.Name = "txt_qtde"
        Me.txt_qtde.Size = New System.Drawing.Size(92, 20)
        Me.txt_qtde.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(343, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "BORDA"
        '
        'cmb_borda
        '
        Me.cmb_borda.FormattingEnabled = True
        Me.cmb_borda.Location = New System.Drawing.Point(346, 217)
        Me.cmb_borda.Name = "cmb_borda"
        Me.cmb_borda.Size = New System.Drawing.Size(121, 21)
        Me.cmb_borda.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(44, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "OBSERVAÇÕES"
        '
        'txt_obs
        '
        Me.txt_obs.Location = New System.Drawing.Point(47, 218)
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(238, 20)
        Me.txt_obs.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(342, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "SABOR 2 - OPCIONAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(343, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "DESCRIÇÃO"
        '
        'txt_item2
        '
        Me.txt_item2.Location = New System.Drawing.Point(346, 162)
        Me.txt_item2.Name = "txt_item2"
        Me.txt_item2.Size = New System.Drawing.Size(238, 20)
        Me.txt_item2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(343, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CÓDIGO ITEM"
        '
        'txt_id2
        '
        Me.txt_id2.Location = New System.Drawing.Point(346, 110)
        Me.txt_id2.Name = "txt_id2"
        Me.txt_id2.Size = New System.Drawing.Size(92, 20)
        Me.txt_id2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "DESCRIÇÃO"
        '
        'txt_item
        '
        Me.txt_item.Location = New System.Drawing.Point(47, 162)
        Me.txt_item.Name = "txt_item"
        Me.txt_item.Size = New System.Drawing.Size(238, 20)
        Me.txt_item.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CÓDIGO ITEM"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(47, 110)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(92, 20)
        Me.txt_id.TabIndex = 2
        '
        'btn_adicionar
        '
        Me.btn_adicionar.BackColor = System.Drawing.Color.Maroon
        Me.btn_adicionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_adicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_adicionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_adicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_adicionar.Location = New System.Drawing.Point(47, 286)
        Me.btn_adicionar.Name = "btn_adicionar"
        Me.btn_adicionar.Size = New System.Drawing.Size(183, 48)
        Me.btn_adicionar.TabIndex = 0
        Me.btn_adicionar.Text = "   ADICIONAR"
        Me.btn_adicionar.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Red
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.lbl_total)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.cmb_entrega)
        Me.TabPage2.Controls.Add(Me.btn_finalizar)
        Me.TabPage2.Controls.Add(Me.dgv_itens_pedido)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(735, 384)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CARRINHO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(218, 345)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "R$"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Orange
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.lbl_pedido)
        Me.Panel1.Location = New System.Drawing.Point(17, 329)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(156, 39)
        Me.Panel1.TabIndex = 9
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(5, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 16)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "N° PEDIDO:"
        '
        'lbl_pedido
        '
        Me.lbl_pedido.AutoSize = True
        Me.lbl_pedido.BackColor = System.Drawing.Color.White
        Me.lbl_pedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pedido.Location = New System.Drawing.Point(90, 11)
        Me.lbl_pedido.Name = "lbl_pedido"
        Me.lbl_pedido.Size = New System.Drawing.Size(55, 16)
        Me.lbl_pedido.TabIndex = 8
        Me.lbl_pedido.Text = "100001"
        '
        'lbl_total
        '
        Me.lbl_total.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(217, 344)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(109, 21)
        Me.lbl_total.TabIndex = 6
        Me.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(214, 325)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 16)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "TOTAL:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(359, 325)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "ENTREGA"
        '
        'cmb_entrega
        '
        Me.cmb_entrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_entrega.FormattingEnabled = True
        Me.cmb_entrega.Location = New System.Drawing.Point(362, 344)
        Me.cmb_entrega.Name = "cmb_entrega"
        Me.cmb_entrega.Size = New System.Drawing.Size(137, 23)
        Me.cmb_entrega.TabIndex = 3
        '
        'btn_finalizar
        '
        Me.btn_finalizar.BackColor = System.Drawing.Color.Maroon
        Me.btn_finalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_finalizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_finalizar.Location = New System.Drawing.Point(523, 325)
        Me.btn_finalizar.Name = "btn_finalizar"
        Me.btn_finalizar.Size = New System.Drawing.Size(183, 43)
        Me.btn_finalizar.TabIndex = 2
        Me.btn_finalizar.Text = "FINALIZAR PEDIDO"
        Me.btn_finalizar.UseVisualStyleBackColor = False
        '
        'dgv_itens_pedido
        '
        Me.dgv_itens_pedido.AllowUserToAddRows = False
        Me.dgv_itens_pedido.AllowUserToDeleteRows = False
        Me.dgv_itens_pedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_itens_pedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_itens_pedido.BackgroundColor = System.Drawing.Color.Maroon
        Me.dgv_itens_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_itens_pedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column1, Me.Column2, Me.Column3, Me.Column8, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgv_itens_pedido.Location = New System.Drawing.Point(6, 6)
        Me.dgv_itens_pedido.Name = "dgv_itens_pedido"
        Me.dgv_itens_pedido.ReadOnly = True
        Me.dgv_itens_pedido.Size = New System.Drawing.Size(723, 302)
        Me.dgv_itens_pedido.TabIndex = 0
        '
        'Column9
        '
        Me.Column9.HeaderText = "N°"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 44
        '
        'Column1
        '
        Me.Column1.HeaderText = "DESCRIÇÃO"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 94
        '
        'Column2
        '
        Me.Column2.HeaderText = "SABOR 2"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 78
        '
        'Column3
        '
        Me.Column3.HeaderText = "BORDA"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 70
        '
        'Column8
        '
        Me.Column8.HeaderText = "QTDE"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 62
        '
        'Column4
        '
        Me.Column4.HeaderText = "OBS"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 54
        '
        'Column5
        '
        Me.Column5.HeaderText = "VALOR"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 68
        '
        'Column6
        '
        Me.Column6.HeaderText = "EDITAR"
        Me.Column6.Image = CType(resources.GetObject("Column6.Image"), System.Drawing.Image)
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 53
        '
        'Column7
        '
        Me.Column7.HeaderText = "EXCLUIR"
        Me.Column7.Image = CType(resources.GetObject("Column7.Image"), System.Drawing.Image)
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 59
        '
        'txt_nome3
        '
        Me.txt_nome3.Location = New System.Drawing.Point(110, 60)
        Me.txt_nome3.Name = "txt_nome3"
        Me.txt_nome3.Size = New System.Drawing.Size(307, 20)
        Me.txt_nome3.TabIndex = 25
        '
        'txt_fone_fixo3
        '
        Me.txt_fone_fixo3.Location = New System.Drawing.Point(423, 60)
        Me.txt_fone_fixo3.Mask = "(99)9999-9999"
        Me.txt_fone_fixo3.Name = "txt_fone_fixo3"
        Me.txt_fone_fixo3.Size = New System.Drawing.Size(82, 20)
        Me.txt_fone_fixo3.TabIndex = 24
        Me.txt_fone_fixo3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_celular3
        '
        Me.txt_celular3.Location = New System.Drawing.Point(511, 60)
        Me.txt_celular3.Mask = "(99)99999-9999"
        Me.txt_celular3.Name = "txt_celular3"
        Me.txt_celular3.Size = New System.Drawing.Size(87, 20)
        Me.txt_celular3.TabIndex = 23
        Me.txt_celular3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_cpf3
        '
        Me.txt_cpf3.Location = New System.Drawing.Point(17, 60)
        Me.txt_cpf3.Mask = "999,999,999-99"
        Me.txt_cpf3.Name = "txt_cpf3"
        Me.txt_cpf3.Size = New System.Drawing.Size(87, 20)
        Me.txt_cpf3.TabIndex = 22
        Me.txt_cpf3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(420, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "FONE FIXO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(508, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "CELULAR"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(107, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "NOME"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(14, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "CPF"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(19, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(170, 18)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "DADOS DO CLIENTE"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label17.Location = New System.Drawing.Point(601, 44)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 13)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "PAGAMENTO"
        '
        'cmb_pagamento
        '
        Me.cmb_pagamento.FormattingEnabled = True
        Me.cmb_pagamento.Location = New System.Drawing.Point(604, 59)
        Me.cmb_pagamento.Name = "cmb_pagamento"
        Me.cmb_pagamento.Size = New System.Drawing.Size(147, 21)
        Me.cmb_pagamento.TabIndex = 28
        '
        'frm_cadastro_pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(767, 528)
        Me.Controls.Add(Me.cmb_pagamento)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_nome3)
        Me.Controls.Add(Me.txt_fone_fixo3)
        Me.Controls.Add(Me.txt_celular3)
        Me.Controls.Add(Me.txt_cpf3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tab_pedido)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cadastro_pedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEDIDO"
        Me.tab_pedido.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_itens_pedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tab_pedido As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_borda As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_obs As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_item2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_id2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_item As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents btn_adicionar As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmb_entrega As System.Windows.Forms.ComboBox
    Friend WithEvents btn_finalizar As System.Windows.Forms.Button
    Friend WithEvents dgv_itens_pedido As System.Windows.Forms.DataGridView
    Friend WithEvents txt_nome3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_fone_fixo3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_celular3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_cpf3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_qtde As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmb_pagamento As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbl_pedido As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn_cardapio As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewImageColumn
End Class
