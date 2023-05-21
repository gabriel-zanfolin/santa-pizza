<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro_cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro_cliente))
        Me.cmb_data_nasc = New System.Windows.Forms.DateTimePicker()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_uf = New System.Windows.Forms.TextBox()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.txt_comp = New System.Windows.Forms.TextBox()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fone_fixo = New System.Windows.Forms.MaskedTextBox()
        Me.txt_celular = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
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
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_salvar = New System.Windows.Forms.ToolStripButton()
        Me.abrir_foto = New System.Windows.Forms.OpenFileDialog()
        Me.btn_voltar2 = New System.Windows.Forms.Button()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmb_data_nasc
        '
        Me.cmb_data_nasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_data_nasc.Location = New System.Drawing.Point(200, 110)
        Me.cmb_data_nasc.Name = "cmb_data_nasc"
        Me.cmb_data_nasc.Size = New System.Drawing.Size(110, 20)
        Me.cmb_data_nasc.TabIndex = 49
        Me.cmb_data_nasc.Value = New Date(2020, 11, 24, 0, 0, 0, 0)
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(209, 303)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(226, 20)
        Me.txt_email.TabIndex = 48
        '
        'txt_uf
        '
        Me.txt_uf.Location = New System.Drawing.Point(403, 255)
        Me.txt_uf.Name = "txt_uf"
        Me.txt_uf.Size = New System.Drawing.Size(32, 20)
        Me.txt_uf.TabIndex = 47
        '
        'txt_cidade
        '
        Me.txt_cidade.Location = New System.Drawing.Point(169, 255)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(228, 20)
        Me.txt_cidade.TabIndex = 46
        '
        'txt_bairro
        '
        Me.txt_bairro.Location = New System.Drawing.Point(28, 255)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(135, 20)
        Me.txt_bairro.TabIndex = 45
        '
        'txt_comp
        '
        Me.txt_comp.Location = New System.Drawing.Point(337, 207)
        Me.txt_comp.Name = "txt_comp"
        Me.txt_comp.Size = New System.Drawing.Size(98, 20)
        Me.txt_comp.TabIndex = 44
        '
        'txt_endereco
        '
        Me.txt_endereco.Location = New System.Drawing.Point(99, 207)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(232, 20)
        Me.txt_endereco.TabIndex = 43
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(28, 159)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(282, 20)
        Me.txt_nome.TabIndex = 42
        '
        'txt_cep
        '
        Me.txt_cep.Location = New System.Drawing.Point(28, 207)
        Me.txt_cep.Mask = "99999-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(65, 20)
        Me.txt_cep.TabIndex = 41
        Me.txt_cep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_fone_fixo
        '
        Me.txt_fone_fixo.Location = New System.Drawing.Point(28, 303)
        Me.txt_fone_fixo.Mask = "(99)9999-9999"
        Me.txt_fone_fixo.Name = "txt_fone_fixo"
        Me.txt_fone_fixo.Size = New System.Drawing.Size(82, 20)
        Me.txt_fone_fixo.TabIndex = 40
        Me.txt_fone_fixo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_celular
        '
        Me.txt_celular.Location = New System.Drawing.Point(116, 303)
        Me.txt_celular.Mask = "(99)99999-9999"
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(87, 20)
        Me.txt_celular.TabIndex = 39
        Me.txt_celular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(28, 110)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(87, 20)
        Me.txt_cpf.TabIndex = 38
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(96, 191)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "ENDEREÇO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(334, 191)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "COMPLEMENTO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(25, 239)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "BAIRRO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(166, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "CIDADE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(400, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "UF"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(25, 287)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "FONE FIXO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(113, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "CELULAR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(206, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "E-MAIL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(25, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "CEP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(25, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "NOME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(197, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "DATA DE NASC."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(25, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "CPF"
        '
        'img_foto
        '
        Me.img_foto.BackColor = System.Drawing.Color.DarkGray
        Me.img_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_foto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(316, 47)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(119, 132)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 25
        Me.img_foto.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Maroon
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_salvar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(467, 25)
        Me.ToolStrip1.TabIndex = 50
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_salvar
        '
        Me.btn_salvar.BackColor = System.Drawing.Color.White
        Me.btn_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_salvar.Image = CType(resources.GetObject("btn_salvar.Image"), System.Drawing.Image)
        Me.btn_salvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(23, 22)
        Me.btn_salvar.Text = "SALVAR"
        '
        'abrir_foto
        '
        Me.abrir_foto.FileName = "OpenFileDialog1"
        '
        'btn_voltar2
        '
        Me.btn_voltar2.BackColor = System.Drawing.Color.Maroon
        Me.btn_voltar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_voltar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_voltar2.Location = New System.Drawing.Point(28, 47)
        Me.btn_voltar2.Name = "btn_voltar2"
        Me.btn_voltar2.Size = New System.Drawing.Size(87, 33)
        Me.btn_voltar2.TabIndex = 51
        Me.btn_voltar2.Text = "VOLTAR"
        Me.btn_voltar2.UseVisualStyleBackColor = False
        '
        'frm_cadastro_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(467, 355)
        Me.Controls.Add(Me.btn_voltar2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.cmb_data_nasc)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_uf)
        Me.Controls.Add(Me.txt_cidade)
        Me.Controls.Add(Me.txt_bairro)
        Me.Controls.Add(Me.txt_comp)
        Me.Controls.Add(Me.txt_endereco)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.txt_cep)
        Me.Controls.Add(Me.txt_fone_fixo)
        Me.Controls.Add(Me.txt_celular)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.img_foto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cadastro_cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO DE CLIENTES"
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_data_nasc As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_uf As System.Windows.Forms.TextBox
    Friend WithEvents txt_cidade As System.Windows.Forms.TextBox
    Friend WithEvents txt_bairro As System.Windows.Forms.TextBox
    Friend WithEvents txt_comp As System.Windows.Forms.TextBox
    Friend WithEvents txt_endereco As System.Windows.Forms.TextBox
    Friend WithEvents txt_nome As System.Windows.Forms.TextBox
    Friend WithEvents txt_cep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_fone_fixo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_celular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_cpf As System.Windows.Forms.MaskedTextBox
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
    Friend WithEvents img_foto As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_salvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents abrir_foto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_voltar2 As System.Windows.Forms.Button
End Class
