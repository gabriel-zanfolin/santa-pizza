<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cardapio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cardapio))
        Me.dgv_cardapio = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca_cardapio = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_tipo_cardapio = New System.Windows.Forms.ToolStripComboBox()
        Me.btn_cadastrar_item = New System.Windows.Forms.Button()
        Me.lbl_cardapio = New System.Windows.Forms.Label()
        Me.icone_mais = New System.Windows.Forms.PictureBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgv_cardapio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.icone_mais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_cardapio
        '
        Me.dgv_cardapio.AllowUserToAddRows = False
        Me.dgv_cardapio.AllowUserToDeleteRows = False
        Me.dgv_cardapio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_cardapio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_cardapio.BackgroundColor = System.Drawing.Color.Red
        Me.dgv_cardapio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cardapio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgv_cardapio.Location = New System.Drawing.Point(12, 28)
        Me.dgv_cardapio.Name = "dgv_cardapio"
        Me.dgv_cardapio.ReadOnly = True
        Me.dgv_cardapio.Size = New System.Drawing.Size(605, 355)
        Me.dgv_cardapio.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Maroon
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txt_busca_cardapio, Me.ToolStripLabel2, Me.cmb_tipo_cardapio})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(629, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripLabel1.Text = "DIGITE UM PARÂMETRO:"
        '
        'txt_busca_cardapio
        '
        Me.txt_busca_cardapio.Name = "txt_busca_cardapio"
        Me.txt_busca_cardapio.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripLabel2.Text = "SELECIONE:"
        '
        'cmb_tipo_cardapio
        '
        Me.cmb_tipo_cardapio.Name = "cmb_tipo_cardapio"
        Me.cmb_tipo_cardapio.Size = New System.Drawing.Size(121, 25)
        '
        'btn_cadastrar_item
        '
        Me.btn_cadastrar_item.BackColor = System.Drawing.Color.OrangeRed
        Me.btn_cadastrar_item.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cadastrar_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar_item.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_cadastrar_item.Location = New System.Drawing.Point(460, 389)
        Me.btn_cadastrar_item.Name = "btn_cadastrar_item"
        Me.btn_cadastrar_item.Size = New System.Drawing.Size(157, 38)
        Me.btn_cadastrar_item.TabIndex = 3
        Me.btn_cadastrar_item.Text = "      NOVO ITEM"
        Me.btn_cadastrar_item.UseVisualStyleBackColor = False
        '
        'lbl_cardapio
        '
        Me.lbl_cardapio.BackColor = System.Drawing.Color.Yellow
        Me.lbl_cardapio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_cardapio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cardapio.Location = New System.Drawing.Point(12, 402)
        Me.lbl_cardapio.Name = "lbl_cardapio"
        Me.lbl_cardapio.Size = New System.Drawing.Size(260, 25)
        Me.lbl_cardapio.TabIndex = 4
        Me.lbl_cardapio.Text = "CARDÁPIO PIZZAS SALGADAS"
        Me.lbl_cardapio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'icone_mais
        '
        Me.icone_mais.BackColor = System.Drawing.Color.OrangeRed
        Me.icone_mais.Image = CType(resources.GetObject("icone_mais.Image"), System.Drawing.Image)
        Me.icone_mais.Location = New System.Drawing.Point(472, 396)
        Me.icone_mais.Name = "icone_mais"
        Me.icone_mais.Size = New System.Drawing.Size(29, 27)
        Me.icone_mais.TabIndex = 19
        Me.icone_mais.TabStop = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 43
        '
        'Column2
        '
        Me.Column2.HeaderText = "DESCRIÇÃO"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 94
        '
        'Column3
        '
        Me.Column3.HeaderText = "PREÇO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 69
        '
        'Column4
        '
        Me.Column4.HeaderText = "EDITAR"
        Me.Column4.Image = CType(resources.GetObject("Column4.Image"), System.Drawing.Image)
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column4.Width = 72
        '
        'Column5
        '
        Me.Column5.HeaderText = "EXCLUIR"
        Me.Column5.Image = CType(resources.GetObject("Column5.Image"), System.Drawing.Image)
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column5.Width = 78
        '
        'frm_cardapio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(629, 439)
        Me.Controls.Add(Me.icone_mais)
        Me.Controls.Add(Me.lbl_cardapio)
        Me.Controls.Add(Me.btn_cadastrar_item)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgv_cardapio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cardapio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CARDÁPIO"
        CType(Me.dgv_cardapio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.icone_mais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_cardapio As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txt_busca_cardapio As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmb_tipo_cardapio As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents btn_cadastrar_item As System.Windows.Forms.Button
    Friend WithEvents lbl_cardapio As System.Windows.Forms.Label
    Friend WithEvents icone_mais As System.Windows.Forms.PictureBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewImageColumn
End Class
