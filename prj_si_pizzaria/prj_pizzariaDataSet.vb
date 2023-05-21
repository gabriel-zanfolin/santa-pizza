Partial Class prj_pizzariaDataSet
    Partial Public Class tb_pedidosDataTable
        Private Sub tb_pedidosDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.totalColumn.ColumnName) Then
                'Adicionar o código do usuário aqui
            End If

        End Sub

    End Class
End Class