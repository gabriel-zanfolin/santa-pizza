<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_relat_clientes_cid
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_relat_clientes_cid))
        Me.tb_cadastroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.prj_pizzariaDataSet = New prj_si_pizzaria.prj_pizzariaDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tb_cadastroTableAdapter = New prj_si_pizzaria.prj_pizzariaDataSetTableAdapters.tb_cadastroTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_busca_cidade = New System.Windows.Forms.TextBox()
        Me.btn_OK = New System.Windows.Forms.Button()
        CType(Me.tb_cadastroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prj_pizzariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_cadastroBindingSource
        '
        Me.tb_cadastroBindingSource.DataMember = "tb_cadastro"
        Me.tb_cadastroBindingSource.DataSource = Me.prj_pizzariaDataSet
        '
        'prj_pizzariaDataSet
        '
        Me.prj_pizzariaDataSet.DataSetName = "prj_pizzariaDataSet"
        Me.prj_pizzariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tb_cadastroBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "prj_si_pizzaria.list_cliente_cidade.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1019, 553)
        Me.ReportViewer1.TabIndex = 0
        '
        'tb_cadastroTableAdapter
        '
        Me.tb_cadastroTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(649, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DIGITE UMA CIDADE:"
        '
        'txt_busca_cidade
        '
        Me.txt_busca_cidade.Location = New System.Drawing.Point(784, 4)
        Me.txt_busca_cidade.Name = "txt_busca_cidade"
        Me.txt_busca_cidade.Size = New System.Drawing.Size(126, 20)
        Me.txt_busca_cidade.TabIndex = 2
        '
        'btn_OK
        '
        Me.btn_OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_OK.Location = New System.Drawing.Point(916, 4)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(48, 20)
        Me.btn_OK.TabIndex = 3
        Me.btn_OK.Text = "OK"
        Me.btn_OK.UseVisualStyleBackColor = True
        '
        'frm_relat_clientes_cid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 553)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.txt_busca_cidade)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_relat_clientes_cid"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.tb_cadastroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prj_pizzariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tb_cadastroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents prj_pizzariaDataSet As prj_si_pizzaria.prj_pizzariaDataSet
    Friend WithEvents tb_cadastroTableAdapter As prj_si_pizzaria.prj_pizzariaDataSetTableAdapters.tb_cadastroTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_busca_cidade As System.Windows.Forms.TextBox
    Friend WithEvents btn_OK As System.Windows.Forms.Button
End Class
