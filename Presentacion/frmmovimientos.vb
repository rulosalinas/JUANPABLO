Imports System.ComponentModel

Public Class frmmovimientos
    Dim dt As New DataTable
    Private Sub frmmovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        ocultar_columnas()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fmovimientos
            Dim dts As New vmovimientos

            dts.gidcaja = CInt(lblnumcaja.Text)

            dt = func.mostrar(dts)

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub limpiar()
        txtidmov.Text = ""
        txtmonto.Text = ""
        txtdescripcion.Text = ""
    End Sub
    Private Sub ocultar_columnas()
        datalistado.Columns(0).Visible = False
    End Sub


    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub txtmonto_Validating(sender As Object, e As CancelEventArgs) Handles txtmonto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Datos Obligatorios")
        End If
    End Sub
    Private Sub txtmonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmonto.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtdescripcion_Validating(sender As Object, e As CancelEventArgs) Handles txtdescripcion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Datos Obligatorios")
        End If
    End Sub

    Private Sub btnguardaralta_Click(sender As Object, e As EventArgs) Handles btnguardaralta.Click
        If Me.ValidateChildren = True And txtmonto.Text <> "" And txtdescripcion.Text <> "" Then
            Try
                Dim dts As New vmovimientos
                Dim func As New fmovimientos

                dts.gidcaja = CInt(lblnumcaja.Text)
                dts.gtipomov = UCase(cbxtipomov.Text)
                dts.gmontomov = UCase(txtmonto.Text)
                dts.gdescmov = UCase(txtdescripcion.Text)
                dts.gfechamov = Convert.ToDateTime(Date.Now)
                dts.ghoramov = Convert.ToDateTime(Date.Now)

                If func.insertar(dts) Then
                    MessageBox.Show("Movimiento Guardado Correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                    mostrar()
                Else
                    MessageBox.Show("Movimiento no Registrado", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox("Error Movimiento" + ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnbaja_Click(sender As Object, e As EventArgs) Handles btnbaja.Click
        Try
            Dim dts As New vmovimientos
            Dim func As New fmovimientos

            dts.gidmov = CInt(datalistado.SelectedCells.Item(0).Value)


            If func.eliminar(dts) Then
                MessageBox.Show("Moviminto Eliminado Correctamente", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar()
                limpiar()
            Else
                MessageBox.Show("Movimiento No Eliminado", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox("Error eliminar Movimiento" + ex.Message)
        End Try
    End Sub
End Class