Public Class frmabmbecas
    Private Sub frmabmbecas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private dt As New DataTable
    Public Sub limpiar()
        txtidalumno.Text = ""
        txtnombe.Text = ""
        txtmonto.Text = ""
        txtmonto.Text = ""
        txtresolucion.Text = ""
    End Sub


    Private Sub txtnombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtmonto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Datos Obligatorios")
        End If
    End Sub

    Private Sub txtmonto(sender As Object, e As KeyPressEventArgs) Handles txtdni.KeyPress

    End Sub

    Private Sub btnguardaralta_Click(sender As Object, e As EventArgs) Handles btnguardaralta.Click
        If Me.ValidateChildren = True And txtnombe.Text <> "" Then
            Try
                Dim dts As New vbecas
                Dim func As New fbecas

                dts.gidalumno = CInt(txtidalumno.Text)
                dts.giniciobeca = CDate(dtfinbeca.Value)
                dts.gestadobeca = "ACTIVO"
                dts.gresolucionbeca = UCase(txtresolucion.Text)
                dts.gporcentajebeca = CInt(txtmonto.Text)


                If func.insertar(dts) Then
                    MessageBox.Show("El Tutor se Registro Correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                    btnguardaralta.Visible = False
                    lblnuevo.Visible = False
                    Me.Close()

                Else
                    MessageBox.Show("El Tutor no fue Registrado", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox("Error Nuevp Tutor" + ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnguardaredicion_Click(sender As Object, e As EventArgs) Handles btnguardaredicion.Click
        If Me.ValidateChildren = True And txtidalumno.Text <> "" And txtmonto.Text <> "" And txtnombe.Text <> "" And txtresolucion.Text <> "" And txtdomicilio.Text <> "" And txtlocalidad.Text <> "" Then
            Try
                Dim dts As New vtutor
                Dim func As New ftutor

                dts.gdnitutor = CInt(txtidalumno.Text)
                dts.gapellidotutor = UCase(txtnombe.Text)
                dts.gnombretutor = UCase(txtmonto.Text)
                dts.gdomtutor = UCase(txtdomicilio.Text)
                dts.glocalidadtutor = UCase(txtlocalidad.Text)
                dts.gparentescotutor = cbxparentesco.Text
                dts.gteltutor = UCase(txtresolucion.Text)
                dts.gnomtutor2 = UCase(txtidbeca.Text)
                dts.gteltutor2 = UCase(txttelefono2.Text)
                dts.gnomtutor3 = UCase(txtnombre3.Text)
                dts.gteltutor3 = UCase(txttelefono3.Text)


                If func.editar(dts) Then
                    MessageBox.Show("El Tutor Fue Modificado Correctamente", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    limpiar()
                    btnguardaredicion.Visible = False
                    lblmodificar.Visible = False
                    Me.Close()
                Else
                    MessageBox.Show("El Tutor no fue Modificado", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox("Error Editar Tutor" + ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnguardarbaja_Click(sender As Object, e As EventArgs) Handles btnguardarbaja.Click

        Try
            Dim dts As New vtutor
            Dim func As New ftutor

            dts.gdnitutor = CInt(txtidalumno.Text)


            If func.eliminar(dts) Then
                MessageBox.Show("El Tutor Fue Eliminado Correctamente", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                limpiar()
                limpiar()
                lblbaja.Visible = False
                btnguardarbaja.Visible = False
                Me.Close()

            Else
                MessageBox.Show("El Tutor No fue Eliminado", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox("Error Editar Tutor" + ex.Message)
        End Try

    End Sub

    Private Sub button29_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub frmabmtutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub label4_Click(sender As Object, e As EventArgs) Handles label4.Click

    End Sub

    Private Sub frmabmbecas_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class