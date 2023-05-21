<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.painel_animado = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_porcent = New System.Windows.Forms.Label()
        Me.lbl_processamento = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.chk_visualizar1 = New System.Windows.Forms.CheckBox()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.txt_senha_login = New System.Windows.Forms.TextBox()
        Me.txt_usuario_login = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_tipo_conta = New System.Windows.Forms.ComboBox()
        Me.txt_rsenha = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chk_visualizar2 = New System.Windows.Forms.CheckBox()
        Me.btn_criar = New System.Windows.Forms.Button()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgv_contas = New System.Windows.Forms.DataGridView()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.lbl_adm = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.painel_animado.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgv_contas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(720, 415)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Red
        Me.TabPage1.Controls.Add(Me.painel_animado)
        Me.TabPage1.Controls.Add(Me.lbl_porcent)
        Me.TabPage1.Controls.Add(Me.lbl_processamento)
        Me.TabPage1.Controls.Add(Me.ProgressBar1)
        Me.TabPage1.Controls.Add(Me.chk_visualizar1)
        Me.TabPage1.Controls.Add(Me.btn_entrar)
        Me.TabPage1.Controls.Add(Me.txt_senha_login)
        Me.TabPage1.Controls.Add(Me.txt_usuario_login)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(712, 389)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "IDENTIFICAÇÃO CONTAS"
        '
        'painel_animado
        '
        Me.painel_animado.BackColor = System.Drawing.Color.Yellow
        Me.painel_animado.Controls.Add(Me.PictureBox1)
        Me.painel_animado.Location = New System.Drawing.Point(342, 62)
        Me.painel_animado.Name = "painel_animado"
        Me.painel_animado.Size = New System.Drawing.Size(302, 238)
        Me.painel_animado.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(270, 238)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'lbl_porcent
        '
        Me.lbl_porcent.AutoSize = True
        Me.lbl_porcent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_porcent.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_porcent.Location = New System.Drawing.Point(259, 284)
        Me.lbl_porcent.Name = "lbl_porcent"
        Me.lbl_porcent.Size = New System.Drawing.Size(16, 13)
        Me.lbl_porcent.TabIndex = 18
        Me.lbl_porcent.Text = "%"
        '
        'lbl_processamento
        '
        Me.lbl_processamento.AutoSize = True
        Me.lbl_processamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_processamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_processamento.Location = New System.Drawing.Point(240, 284)
        Me.lbl_processamento.Name = "lbl_processamento"
        Me.lbl_processamento.Size = New System.Drawing.Size(14, 13)
        Me.lbl_processamento.TabIndex = 17
        Me.lbl_processamento.Text = "0"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(81, 284)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(153, 16)
        Me.ProgressBar1.TabIndex = 16
        '
        'chk_visualizar1
        '
        Me.chk_visualizar1.AutoSize = True
        Me.chk_visualizar1.Location = New System.Drawing.Point(81, 183)
        Me.chk_visualizar1.Name = "chk_visualizar1"
        Me.chk_visualizar1.Size = New System.Drawing.Size(89, 17)
        Me.chk_visualizar1.TabIndex = 15
        Me.chk_visualizar1.Text = "VISUALIZAR"
        Me.chk_visualizar1.UseVisualStyleBackColor = True
        '
        'btn_entrar
        '
        Me.btn_entrar.BackColor = System.Drawing.Color.Maroon
        Me.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_entrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_entrar.Location = New System.Drawing.Point(81, 218)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(153, 45)
        Me.btn_entrar.TabIndex = 14
        Me.btn_entrar.Text = "ENTRAR"
        Me.btn_entrar.UseVisualStyleBackColor = False
        '
        'txt_senha_login
        '
        Me.txt_senha_login.Location = New System.Drawing.Point(81, 157)
        Me.txt_senha_login.Name = "txt_senha_login"
        Me.txt_senha_login.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_senha_login.Size = New System.Drawing.Size(153, 20)
        Me.txt_senha_login.TabIndex = 13
        '
        'txt_usuario_login
        '
        Me.txt_usuario_login.Location = New System.Drawing.Point(81, 105)
        Me.txt_usuario_login.Name = "txt_usuario_login"
        Me.txt_usuario_login.Size = New System.Drawing.Size(153, 20)
        Me.txt_usuario_login.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "SENHA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "USUÁRIO OU E-MAIL"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Red
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.cmb_tipo_conta)
        Me.TabPage2.Controls.Add(Me.txt_rsenha)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txt_email)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.chk_visualizar2)
        Me.TabPage2.Controls.Add(Me.btn_criar)
        Me.TabPage2.Controls.Add(Me.txt_senha)
        Me.TabPage2.Controls.Add(Me.txt_usuario)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(712, 389)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "NOVA CONTA"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(377, 48)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(272, 261)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 18)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "TIPO DE CONTA:"
        '
        'cmb_tipo_conta
        '
        Me.cmb_tipo_conta.FormattingEnabled = True
        Me.cmb_tipo_conta.Location = New System.Drawing.Point(26, 288)
        Me.cmb_tipo_conta.Name = "cmb_tipo_conta"
        Me.cmb_tipo_conta.Size = New System.Drawing.Size(153, 21)
        Me.cmb_tipo_conta.TabIndex = 26
        '
        'txt_rsenha
        '
        Me.txt_rsenha.Location = New System.Drawing.Point(195, 196)
        Me.txt_rsenha.Name = "txt_rsenha"
        Me.txt_rsenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_rsenha.Size = New System.Drawing.Size(153, 20)
        Me.txt_rsenha.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(192, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 18)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "REPETIR SENHA:"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(26, 128)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(322, 20)
        Me.txt_email.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 18)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "E-MAIL:"
        '
        'chk_visualizar2
        '
        Me.chk_visualizar2.AutoSize = True
        Me.chk_visualizar2.Location = New System.Drawing.Point(26, 222)
        Me.chk_visualizar2.Name = "chk_visualizar2"
        Me.chk_visualizar2.Size = New System.Drawing.Size(89, 17)
        Me.chk_visualizar2.TabIndex = 21
        Me.chk_visualizar2.Text = "VISUALIZAR"
        Me.chk_visualizar2.UseVisualStyleBackColor = True
        '
        'btn_criar
        '
        Me.btn_criar.BackColor = System.Drawing.Color.Maroon
        Me.btn_criar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_criar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_criar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_criar.Location = New System.Drawing.Point(195, 275)
        Me.btn_criar.Name = "btn_criar"
        Me.btn_criar.Size = New System.Drawing.Size(153, 34)
        Me.btn_criar.TabIndex = 20
        Me.btn_criar.Text = "CRIAR CONTA"
        Me.btn_criar.UseVisualStyleBackColor = False
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(26, 196)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_senha.Size = New System.Drawing.Size(153, 20)
        Me.txt_senha.TabIndex = 19
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(26, 64)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(322, 20)
        Me.txt_usuario.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 18)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "SENHA:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 18)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "NOME DE USUÁRIO:"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Maroon
        Me.TabPage3.Controls.Add(Me.dgv_contas)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(712, 389)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "MANUTENÇÃO CONTAS"
        '
        'dgv_contas
        '
        Me.dgv_contas.AllowUserToAddRows = False
        Me.dgv_contas.AllowUserToDeleteRows = False
        Me.dgv_contas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_contas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_contas.BackgroundColor = System.Drawing.Color.Red
        Me.dgv_contas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_contas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column8, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgv_contas.Location = New System.Drawing.Point(6, 6)
        Me.dgv_contas.Name = "dgv_contas"
        Me.dgv_contas.ReadOnly = True
        Me.dgv_contas.Size = New System.Drawing.Size(700, 377)
        Me.dgv_contas.TabIndex = 0
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(381, 18)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(347, 10)
        Me.ProgressBar2.TabIndex = 11
        '
        'lbl_adm
        '
        Me.lbl_adm.AutoSize = True
        Me.lbl_adm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_adm.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_adm.Location = New System.Drawing.Point(483, 0)
        Me.lbl_adm.Name = "lbl_adm"
        Me.lbl_adm.Size = New System.Drawing.Size(158, 15)
        Me.lbl_adm.TabIndex = 12
        Me.lbl_adm.Text = "ACESSO ADMINISTRADOR"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Timer2
        '
        '
        'Timer3
        '
        Me.Timer3.Interval = 250
        '
        'Column1
        '
        Me.Column1.HeaderText = "N° CONTA"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "USUARIO"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "EMAIL"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "TIPO"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "STATUS CONTA"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "BLOQUEAR"
        Me.Column5.Image = CType(resources.GetObject("Column5.Image"), System.Drawing.Image)
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column6
        '
        Me.Column6.HeaderText = "ATIVAR"
        Me.Column6.Image = CType(resources.GetObject("Column6.Image"), System.Drawing.Image)
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column7
        '
        Me.Column7.HeaderText = "EXCLUIR"
        Me.Column7.Image = CType(resources.GetObject("Column7.Image"), System.Drawing.Image)
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(744, 439)
        Me.Controls.Add(Me.lbl_adm)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TELA DE LOGIN"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.painel_animado.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgv_contas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_porcent As System.Windows.Forms.Label
    Friend WithEvents lbl_processamento As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents chk_visualizar1 As System.Windows.Forms.CheckBox
    Friend WithEvents btn_entrar As System.Windows.Forms.Button
    Friend WithEvents txt_senha_login As System.Windows.Forms.TextBox
    Friend WithEvents txt_usuario_login As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_conta As System.Windows.Forms.ComboBox
    Friend WithEvents txt_rsenha As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chk_visualizar2 As System.Windows.Forms.CheckBox
    Friend WithEvents btn_criar As System.Windows.Forms.Button
    Friend WithEvents txt_senha As System.Windows.Forms.TextBox
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_contas As System.Windows.Forms.DataGridView
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_adm As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents painel_animado As System.Windows.Forms.Panel
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewImageColumn
End Class
