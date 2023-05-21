<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_clientes))
        Me.tab_cliente = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_voltar1 = New System.Windows.Forms.Button()
        Me.cmb_data_nasc2 = New System.Windows.Forms.DateTimePicker()
        Me.txt_email2 = New System.Windows.Forms.TextBox()
        Me.txt_uf2 = New System.Windows.Forms.TextBox()
        Me.txt_cidade2 = New System.Windows.Forms.TextBox()
        Me.txt_bairro2 = New System.Windows.Forms.TextBox()
        Me.txt_comp2 = New System.Windows.Forms.TextBox()
        Me.txt_endereco2 = New System.Windows.Forms.TextBox()
        Me.txt_nome2 = New System.Windows.Forms.TextBox()
        Me.txt_cep2 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fone_fixo2 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_celular2 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cpf2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.img_foto2 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_pedidos_cliente = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tab_cliente.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.img_foto2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_pedidos_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab_cliente
        '
        Me.tab_cliente.Controls.Add(Me.TabPage1)
        Me.tab_cliente.Controls.Add(Me.TabPage2)
        Me.tab_cliente.Location = New System.Drawing.Point(12, 12)
        Me.tab_cliente.Name = "tab_cliente"
        Me.tab_cliente.SelectedIndex = 0
        Me.tab_cliente.Size = New System.Drawing.Size(469, 348)
        Me.tab_cliente.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Red
        Me.TabPage1.Controls.Add(Me.btn_voltar1)
        Me.TabPage1.Controls.Add(Me.cmb_data_nasc2)
        Me.TabPage1.Controls.Add(Me.txt_email2)
        Me.TabPage1.Controls.Add(Me.txt_uf2)
        Me.TabPage1.Controls.Add(Me.txt_cidade2)
        Me.TabPage1.Controls.Add(Me.txt_bairro2)
        Me.TabPage1.Controls.Add(Me.txt_comp2)
        Me.TabPage1.Controls.Add(Me.txt_endereco2)
        Me.TabPage1.Controls.Add(Me.txt_nome2)
        Me.TabPage1.Controls.Add(Me.txt_cep2)
        Me.TabPage1.Controls.Add(Me.txt_fone_fixo2)
        Me.TabPage1.Controls.Add(Me.txt_celular2)
        Me.TabPage1.Controls.Add(Me.txt_cpf2)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.img_foto2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(461, 322)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "DADOS PESSOAIS"
        '
        'btn_voltar1
        '
        Me.btn_voltar1.BackColor = System.Drawing.Color.Maroon
        Me.btn_voltar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_voltar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_voltar1.Location = New System.Drawing.Point(30, 20)
        Me.btn_voltar1.Name = "btn_voltar1"
        Me.btn_voltar1.Size = New System.Drawing.Size(87, 33)
        Me.btn_voltar1.TabIndex = 25
        Me.btn_voltar1.Text = "VOLTAR"
        Me.btn_voltar1.UseVisualStyleBackColor = False
        '
        'cmb_data_nasc2
        '
        Me.cmb_data_nasc2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_data_nasc2.Location = New System.Drawing.Point(202, 83)
        Me.cmb_data_nasc2.Name = "cmb_data_nasc2"
        Me.cmb_data_nasc2.Size = New System.Drawing.Size(110, 20)
        Me.cmb_data_nasc2.TabIndex = 24
        Me.cmb_data_nasc2.Value = New Date(2020, 11, 24, 0, 0, 0, 0)
        '
        'txt_email2
        '
        Me.txt_email2.Location = New System.Drawing.Point(211, 276)
        Me.txt_email2.Name = "txt_email2"
        Me.txt_email2.Size = New System.Drawing.Size(226, 20)
        Me.txt_email2.TabIndex = 23
        '
        'txt_uf2
        '
        Me.txt_uf2.Location = New System.Drawing.Point(405, 228)
        Me.txt_uf2.Name = "txt_uf2"
        Me.txt_uf2.Size = New System.Drawing.Size(32, 20)
        Me.txt_uf2.TabIndex = 22
        '
        'txt_cidade2
        '
        Me.txt_cidade2.Location = New System.Drawing.Point(171, 228)
        Me.txt_cidade2.Name = "txt_cidade2"
        Me.txt_cidade2.Size = New System.Drawing.Size(228, 20)
        Me.txt_cidade2.TabIndex = 21
        '
        'txt_bairro2
        '
        Me.txt_bairro2.Location = New System.Drawing.Point(30, 228)
        Me.txt_bairro2.Name = "txt_bairro2"
        Me.txt_bairro2.Size = New System.Drawing.Size(135, 20)
        Me.txt_bairro2.TabIndex = 20
        '
        'txt_comp2
        '
        Me.txt_comp2.Location = New System.Drawing.Point(339, 180)
        Me.txt_comp2.Name = "txt_comp2"
        Me.txt_comp2.Size = New System.Drawing.Size(98, 20)
        Me.txt_comp2.TabIndex = 19
        '
        'txt_endereco2
        '
        Me.txt_endereco2.Location = New System.Drawing.Point(101, 180)
        Me.txt_endereco2.Name = "txt_endereco2"
        Me.txt_endereco2.Size = New System.Drawing.Size(232, 20)
        Me.txt_endereco2.TabIndex = 18
        '
        'txt_nome2
        '
        Me.txt_nome2.Location = New System.Drawing.Point(30, 132)
        Me.txt_nome2.Name = "txt_nome2"
        Me.txt_nome2.Size = New System.Drawing.Size(282, 20)
        Me.txt_nome2.TabIndex = 17
        '
        'txt_cep2
        '
        Me.txt_cep2.Location = New System.Drawing.Point(30, 180)
        Me.txt_cep2.Mask = "99999-999"
        Me.txt_cep2.Name = "txt_cep2"
        Me.txt_cep2.Size = New System.Drawing.Size(65, 20)
        Me.txt_cep2.TabIndex = 16
        Me.txt_cep2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_fone_fixo2
        '
        Me.txt_fone_fixo2.Location = New System.Drawing.Point(30, 276)
        Me.txt_fone_fixo2.Mask = "(99)9999-9999"
        Me.txt_fone_fixo2.Name = "txt_fone_fixo2"
        Me.txt_fone_fixo2.Size = New System.Drawing.Size(82, 20)
        Me.txt_fone_fixo2.TabIndex = 15
        Me.txt_fone_fixo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_celular2
        '
        Me.txt_celular2.Location = New System.Drawing.Point(118, 276)
        Me.txt_celular2.Mask = "(99)99999-9999"
        Me.txt_celular2.Name = "txt_celular2"
        Me.txt_celular2.Size = New System.Drawing.Size(87, 20)
        Me.txt_celular2.TabIndex = 14
        Me.txt_celular2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_cpf2
        '
        Me.txt_cpf2.Location = New System.Drawing.Point(30, 83)
        Me.txt_cpf2.Mask = "999,999,999-99"
        Me.txt_cpf2.Name = "txt_cpf2"
        Me.txt_cpf2.Size = New System.Drawing.Size(87, 20)
        Me.txt_cpf2.TabIndex = 13
        Me.txt_cpf2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(98, 164)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "ENDEREÇO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(336, 164)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "COMPLEMENTO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(27, 212)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "BAIRRO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(168, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "CIDADE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(402, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "UF"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(27, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "FONE FIXO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(115, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "CELULAR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(208, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "E-MAIL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(27, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "CEP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(27, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "NOME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(199, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DATA DE NASC."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(27, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CPF"
        '
        'img_foto2
        '
        Me.img_foto2.BackColor = System.Drawing.Color.DarkGray
        Me.img_foto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_foto2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_foto2.Image = CType(resources.GetObject("img_foto2.Image"), System.Drawing.Image)
        Me.img_foto2.Location = New System.Drawing.Point(318, 20)
        Me.img_foto2.Name = "img_foto2"
        Me.img_foto2.Size = New System.Drawing.Size(119, 132)
        Me.img_foto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto2.TabIndex = 0
        Me.img_foto2.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Maroon
        Me.TabPage2.Controls.Add(Me.dgv_pedidos_cliente)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(461, 322)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PEDIDOS"
        '
        'dgv_pedidos_cliente
        '
        Me.dgv_pedidos_cliente.AllowUserToAddRows = False
        Me.dgv_pedidos_cliente.AllowUserToDeleteRows = False
        Me.dgv_pedidos_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_pedidos_cliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_pedidos_cliente.BackgroundColor = System.Drawing.Color.Red
        Me.dgv_pedidos_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pedidos_cliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgv_pedidos_cliente.Location = New System.Drawing.Point(6, 6)
        Me.dgv_pedidos_cliente.Name = "dgv_pedidos_cliente"
        Me.dgv_pedidos_cliente.ReadOnly = True
        Me.dgv_pedidos_cliente.Size = New System.Drawing.Size(449, 310)
        Me.dgv_pedidos_cliente.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "N° PEDIDO"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 88
        '
        'Column2
        '
        Me.Column2.HeaderText = "VALOR"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 68
        '
        'Column3
        '
        Me.Column3.HeaderText = "STATUS"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 75
        '
        'Column4
        '
        Me.Column4.HeaderText = "VISUALIZAR"
        Me.Column4.Image = CType(resources.GetObject("Column4.Image"), System.Drawing.Image)
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column4.Width = 95
        '
        'frm_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(493, 372)
        Me.Controls.Add(Me.tab_cliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INFORMAÇÕES DO CLIENTE"
        Me.tab_cliente.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.img_foto2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_pedidos_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab_cliente As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txt_cep2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_fone_fixo2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_celular2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_cpf2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents img_foto2 As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txt_nome2 As System.Windows.Forms.TextBox
    Friend WithEvents cmb_data_nasc2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_email2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_uf2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_cidade2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_bairro2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_comp2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_endereco2 As System.Windows.Forms.TextBox
    Friend WithEvents dgv_pedidos_cliente As System.Windows.Forms.DataGridView
    Friend WithEvents btn_voltar1 As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewImageColumn
End Class
