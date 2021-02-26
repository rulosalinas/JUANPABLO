Public Class frmbecas
    Private dt As New DataTable
    Private Sub frmbecas_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fbecas

            dt = func.mostrar


            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                txtbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            If cbxbusqueda.Text = "DNI" Then
                dv.RowFilter = "dni_alu" & " like '" & txtbuscar.Text & "%'"
            Else
                dv.RowFilter = "Nombre" & " like '" & txtbuscar.Text & "%'"
            End If

            If dv.Count <> 0 Then
                inexistente.Visible = False
                datalistado.DataSource = dv
                ocultar_columnas()

            Else
                inexistente.Visible = True
                datalistado.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ocultar_columnas()
        'datalistado.Columns(1).Visible = False '--oculta columna n°1 id
    End Sub


    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Dim frm As New abmbecas

        frm.txtidalumno.Text = ""
        frm.txtnombre.Text = ""
        frm.txtresolucion.Text = ""

        frm.btnbuscaralu.Visible = True
        frm.lblnuevo.Visible = True
        frm.btnguardaralta.Visible = True
        frm.ShowDialog()
        mostrar()
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim frm As New abmbecas

        frm.txtidbeca.Text = datalistado.SelectedCells.Item(0).Value
        frm.txtidalumno.Text = datalistado.SelectedCells.Item(1).Value
        frm.txtnombre.Text = datalistado.SelectedCells.Item(2).Value
        frm.dtfinicio.Value = datalistado.SelectedCells.Item(3).Value
        frm.txtresolucion.Text = datalistado.SelectedCells.Item(5).Value
        frm.txtestado.Text = datalistado.SelectedCells.Item(6).Value

        frm.lblmodificar.Visible = True
        frm.btnguardaredicion.Visible = True
        frm.btnbuscaralu.Visible = True
        frm.ShowDialog()
        mostrar()
    End Sub

    Private Sub btnbaja_Click(sender As Object, e As EventArgs) Handles btnbaja.Click
        Dim frm As New abmbecas

        frm.txtidbeca.Text = datalistado.SelectedCells.Item(0).Value
        frm.txtidalumno.Text = datalistado.SelectedCells.Item(1).Value
        frm.txtnombre.Text = datalistado.SelectedCells.Item(2).Value
        frm.dtfinicio.Value = datalistado.SelectedCells.Item(3).Value
        frm.txtresolucion.Text = datalistado.SelectedCells.Item(5).Value
        frm.txtestado.Text = "INACTIVO"

        frm.lblbaja.Visible = True
        frm.btnguardarbaja.Visible = True
        frm.dtfinbeca.Enabled = True
        frm.txtestado.BackColor = Color.Red
        frm.ShowDialog()
        mostrar()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

End Class