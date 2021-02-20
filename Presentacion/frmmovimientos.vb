Public Class frmmovimientos
    Private Sub frmmovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ----------------probando git-------
    End Sub
    'Private Sub frmmovimientos_Load(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub mostrar()
    '    Try
    '        Dim func As New faranceles

    '        dt = func.mostrar


    '        If dt.Rows.Count <> 0 Then
    '            datalistado.DataSource = dt
    '            txtbuscar.Enabled = True               '--habilita opciones de busqueda despues de comprobar que en la base hay elemento
    '            datalistado.ColumnHeadersVisible = True
    '            inexistente.Visible = False
    '        Else
    '            datalistado.DataSource = Nothing '-- sentencia para cuando no exixten datos en la base
    '            txtbuscar.Enabled = False
    '            datalistado.ColumnHeadersVisible = False
    '            inexistente.Visible = True
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    'End Sub
    'Private Sub ocultar_columnas()
    '    'datalistado.Columns(1).Visible = False '--oculta columna n°1 id
    'End Sub


    'Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
    '    Me.Close()
    'End Sub

End Class