<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_relat_clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_relat_clientes))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.prj_pizzariaDataSet = New prj_si_pizzaria.prj_pizzariaDataSet()
        Me.tb_cadastroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tb_cadastroTableAdapter = New prj_si_pizzaria.prj_pizzariaDataSetTableAdapters.tb_cadastroTableAdapter()
        CType(Me.prj_pizzariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_cadastroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tb_cadastroBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "prj_si_pizzaria.list_cliente.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(775, 540)
        Me.ReportViewer1.TabIndex = 0
        '
        'prj_pizzariaDataSet
        '
        Me.prj_pizzariaDataSet.DataSetName = "prj_pizzariaDataSet"
        Me.prj_pizzariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_cadastroBindingSource
        '
        Me.tb_cadastroBindingSource.DataMember = "tb_cadastro"
        Me.tb_cadastroBindingSource.DataSource = Me.prj_pizzariaDataSet
        '
        'tb_cadastroTableAdapter
        '
        Me.tb_cadastroTableAdapter.ClearBeforeFill = True
        '
        'frm_relat_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 540)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_relat_clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.prj_pizzariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_cadastroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tb_cadastroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents prj_pizzariaDataSet As prj_si_pizzaria.prj_pizzariaDataSet
    Friend WithEvents tb_cadastroTableAdapter As prj_si_pizzaria.prj_pizzariaDataSetTableAdapters.tb_cadastroTableAdapter
End Class
