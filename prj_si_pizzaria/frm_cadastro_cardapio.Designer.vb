<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro_cardapio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro_cardapio))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_voltar3 = New System.Windows.Forms.ToolStripButton()
        Me.btn_salvar3 = New System.Windows.Forms.Button()
        Me.txt_descricao = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_tipo_item = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_preco = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Maroon
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_voltar3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(294, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_voltar3
        '
        Me.btn_voltar3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_voltar3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_voltar3.Image = CType(resources.GetObject("btn_voltar3.Image"), System.Drawing.Image)
        Me.btn_voltar3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_voltar3.Name = "btn_voltar3"
        Me.btn_voltar3.Size = New System.Drawing.Size(23, 22)
        Me.btn_voltar3.Text = "ToolStripButton1"
        Me.btn_voltar3.ToolTipText = "VOLTAR"
        '
        'btn_salvar3
        '
        Me.btn_salvar3.BackColor = System.Drawing.Color.Maroon
        Me.btn_salvar3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_salvar3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_salvar3.Location = New System.Drawing.Point(179, 39)
        Me.btn_salvar3.Name = "btn_salvar3"
        Me.btn_salvar3.Size = New System.Drawing.Size(87, 39)
        Me.btn_salvar3.TabIndex = 52
        Me.btn_salvar3.Text = "SALVAR"
        Me.btn_salvar3.UseVisualStyleBackColor = False
        '
        'txt_descricao
        '
        Me.txt_descricao.Location = New System.Drawing.Point(23, 114)
        Me.txt_descricao.Name = "txt_descricao"
        Me.txt_descricao.Size = New System.Drawing.Size(243, 20)
        Me.txt_descricao.TabIndex = 53
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Orange
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.lbl_id)
        Me.Panel1.Location = New System.Drawing.Point(23, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(137, 39)
        Me.Panel1.TabIndex = 55
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(5, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 16)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "ID ITEM:"
        '
        'lbl_id
        '
        Me.lbl_id.BackColor = System.Drawing.Color.White
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(70, 11)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(56, 16)
        Me.lbl_id.TabIndex = 8
        Me.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "DESCRIÇÃO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "TIPO"
        '
        'cmb_tipo_item
        '
        Me.cmb_tipo_item.FormattingEnabled = True
        Me.cmb_tipo_item.Location = New System.Drawing.Point(23, 172)
        Me.cmb_tipo_item.Name = "cmb_tipo_item"
        Me.cmb_tipo_item.Size = New System.Drawing.Size(152, 21)
        Me.cmb_tipo_item.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(178, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "PREÇO"
        '
        'txt_preco
        '
        Me.txt_preco.Location = New System.Drawing.Point(181, 173)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.Size = New System.Drawing.Size(85, 20)
        Me.txt_preco.TabIndex = 59
        '
        'frm_cadastro_cardapio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(294, 227)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_preco)
        Me.Controls.Add(Me.cmb_tipo_item)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_descricao)
        Me.Controls.Add(Me.btn_salvar3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cadastro_cardapio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO CARDÁPIO"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_voltar3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salvar3 As System.Windows.Forms.Button
    Friend WithEvents txt_descricao As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_item As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_preco As System.Windows.Forms.TextBox
End Class
