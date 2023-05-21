<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pedido_cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pedido_cliente))
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dgv_dados_pedido = New System.Windows.Forms.DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_pedido2 = New System.Windows.Forms.Label()
        Me.lbl_total2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_voltar3 = New System.Windows.Forms.Button()
        Me.lbl_pagamento = New System.Windows.Forms.Label()
        Me.lbl_entrega = New System.Windows.Forms.Label()
        CType(Me.dgv_dados_pedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label17.Location = New System.Drawing.Point(328, 272)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 15)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "PAGAMENTO"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(12, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(164, 18)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "DADOS DO PEDIDO"
        '
        'dgv_dados_pedido
        '
        Me.dgv_dados_pedido.AllowUserToAddRows = False
        Me.dgv_dados_pedido.AllowUserToDeleteRows = False
        Me.dgv_dados_pedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_dados_pedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_dados_pedido.BackgroundColor = System.Drawing.Color.Red
        Me.dgv_dados_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados_pedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column1, Me.Column2, Me.Column3, Me.Column8, Me.Column4, Me.Column5})
        Me.dgv_dados_pedido.Location = New System.Drawing.Point(15, 48)
        Me.dgv_dados_pedido.Name = "dgv_dados_pedido"
        Me.dgv_dados_pedido.ReadOnly = True
        Me.dgv_dados_pedido.Size = New System.Drawing.Size(672, 207)
        Me.dgv_dados_pedido.TabIndex = 40
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
        Me.Column4.HeaderText = "OBSERVAÇÕES"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 112
        '
        'Column5
        '
        Me.Column5.HeaderText = "VALOR"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 68
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(468, 292)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 15)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "R$"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Orange
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.lbl_pedido2)
        Me.Panel1.Location = New System.Drawing.Point(15, 272)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(156, 39)
        Me.Panel1.TabIndex = 46
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(5, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 16)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "N° PEDIDO:"
        '
        'lbl_pedido2
        '
        Me.lbl_pedido2.AutoSize = True
        Me.lbl_pedido2.BackColor = System.Drawing.Color.White
        Me.lbl_pedido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pedido2.Location = New System.Drawing.Point(90, 11)
        Me.lbl_pedido2.Name = "lbl_pedido2"
        Me.lbl_pedido2.Size = New System.Drawing.Size(56, 16)
        Me.lbl_pedido2.TabIndex = 8
        Me.lbl_pedido2.Text = "100001"
        '
        'lbl_total2
        '
        Me.lbl_total2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_total2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_total2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total2.Location = New System.Drawing.Point(467, 290)
        Me.lbl_total2.Name = "lbl_total2"
        Me.lbl_total2.Size = New System.Drawing.Size(109, 21)
        Me.lbl_total2.TabIndex = 45
        Me.lbl_total2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(464, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 15)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "TOTAL:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(192, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 15)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "ENTREGA"
        '
        'btn_voltar3
        '
        Me.btn_voltar3.BackColor = System.Drawing.Color.Red
        Me.btn_voltar3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_voltar3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_voltar3.Location = New System.Drawing.Point(592, 283)
        Me.btn_voltar3.Name = "btn_voltar3"
        Me.btn_voltar3.Size = New System.Drawing.Size(95, 31)
        Me.btn_voltar3.TabIndex = 41
        Me.btn_voltar3.Text = "VOLTAR"
        Me.btn_voltar3.UseVisualStyleBackColor = False
        '
        'lbl_pagamento
        '
        Me.lbl_pagamento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_pagamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_pagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pagamento.Location = New System.Drawing.Point(331, 290)
        Me.lbl_pagamento.Name = "lbl_pagamento"
        Me.lbl_pagamento.Size = New System.Drawing.Size(125, 21)
        Me.lbl_pagamento.TabIndex = 48
        Me.lbl_pagamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_entrega
        '
        Me.lbl_entrega.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_entrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_entrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_entrega.Location = New System.Drawing.Point(195, 290)
        Me.lbl_entrega.Name = "lbl_entrega"
        Me.lbl_entrega.Size = New System.Drawing.Size(125, 21)
        Me.lbl_entrega.TabIndex = 49
        Me.lbl_entrega.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frm_pedido_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(702, 331)
        Me.Controls.Add(Me.lbl_entrega)
        Me.Controls.Add(Me.lbl_pagamento)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_total2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_voltar3)
        Me.Controls.Add(Me.dgv_dados_pedido)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_pedido_cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEDIDO DO CLIENTE"
        CType(Me.dgv_dados_pedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dgv_dados_pedido As System.Windows.Forms.DataGridView
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbl_pedido2 As System.Windows.Forms.Label
    Friend WithEvents lbl_total2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_voltar3 As System.Windows.Forms.Button
    Friend WithEvents lbl_pagamento As System.Windows.Forms.Label
    Friend WithEvents lbl_entrega As System.Windows.Forms.Label
End Class
