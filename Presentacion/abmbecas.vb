Imports System.ComponentModel

Public Class abmbecas

    Private dt As New DataTable

    Private Sub abmbecas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub limpiar()
        txtidalumno.Text = ""
        txtnombre.Text = ""
        txtresolucion.Text = ""
    End Sub

    Private Sub txtnombe_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Datos Obligatorios")
        End If
    End Sub

    Private Sub txtresolucion_Validating(sender As Object, e As CancelEventArgs) Handles txtresolucion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Datos Obligatorios")
        End If
    End Sub

    Private Sub btnguardaralta_Click(sender As Object, e As EventArgs) Handles btnguardaralta.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" Then
            Try
                Dim dts As New vbecas
                Dim func As New fbecas

                dts.gidalumno = CInt(txtidalumno.Text)
                dts.giniciobeca = Convert.ToDateTime(dtfinicio.Value)
                dts.gestadobeca = txtestado.Text
                dts.gresolucionbeca = UCase(txtresolucion.Text)



                If func.insertar(dts) Then
                    MessageBox.Show("La Beca se Registro Correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                    btnguardaralta.Visible = False
                    lblnuevo.Visible = False
                    btnbuscaralu.Visible = False
                    Me.Close()

                Else
                    MessageBox.Show("La Beca no fue Registrado", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox("Error Nueva beca" + ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnguardaredicion_Click(sender As Object, e As EventArgs) Handles btnguardaredicion.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" Then
            Try
                Dim dts As New vbecas
                Dim func As New fbecas

                dts.gidbeca = CInt(txtidbeca.Text)
                dts.gidalumno = CInt(txtidalumno.Text)
                dts.giniciobeca = Convert.ToDateTime(dtfinicio.Value)
                dts.gestadobeca = txtestado.Text
                dts.gresolucionbeca = UCase(txtresolucion.Text)



                If func.editar(dts) Then
                    MessageBox.Show("La Beca se Modifico Correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                    btnguardaredicion.Visible = False
                    lblmodificar.Visible = False
                    btnbuscaralu.Visible = False
                    Me.Close()

                Else
                    MessageBox.Show("La Beca no fue Modificada", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox("Error modificar beca" + ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnguardarbaja_Click(sender As Object, e As EventArgs) Handles btnguardarbaja.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" Then
            Try
                Dim dts As New vbecas
                Dim func As New fbecas

                dts.gidbeca = CInt(txtidbeca.Text)
                dts.gfinbeca = Convert.ToDateTime(dtfinbeca.Value)
                dts.gestadobeca = txtestado.Text



                If func.eliminar(dts) Then
                    MessageBox.Show("La Beca se Elimino Correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                    btnguardarbaja.Visible = False
                    lblbaja.Visible = False
                    dtfinbeca.Enabled = False
                    Me.Close()

                Else
                    MessageBox.Show("La Beca no fue Modificada", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox("Error eliminar beca" + ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub btnbuscartutor_Click(sender As Object, e As EventArgs) Handles btnbuscaralu.Click
        Dim frm As New frmalumno
        frm.txtflag.Text = "2"
        frm.lblayuda.Visible = True
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub
End Class