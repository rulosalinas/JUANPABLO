Public Class frmabmpagos
    Private dt As New DataTable
    Dim regventa As Integer = 0
    Dim resultado As MsgBoxResult

    Private Sub frmpagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dts As New vpagos
        Dim func As New fpago

        Lblcomprobante.Text = Format(func.generarcodigo, "000000")
        lblnumcaja.Text = Format(1, "000000")
        limpiar()

        Timer1.Interval = 1000
        Timer1.Start()
    End Sub
    Private Sub frmabmpagos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Try
            If Trim(txtidpago.Text) = "0" Then

                e.Cancel = False

            Else
                resultado = CType(MessageBox.Show("Desea salir sin Guardar?, El pago se Cancelara", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)

                If resultado = MsgBoxResult.No Then
                    e.Cancel = True
                Else

                    Dim dts As New vpagos
                    Dim func As New fpago

                    dts.gidpago = Convert.ToInt32(txtidpago.Text)


                    If func.eliminar(dts) Then
                        limpiarpago()
                        limpiardetalle()
                        resetearcolor()
                        e.Cancel = False
                    Else
                        MsgBox("Error al eliminar", MsgBoxStyle.Information, "Mensaje del Sistema")
                    End If
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub
    Public Sub limpiar()
        txtidpago.Text = ""
        txtidalumno.Text = ""
        txtdni.Text = ""
        txtnombre.Text = ""
        txtnivel.Text = ""
        txtcurso.Text = ""
        txtdivision.Text = ""
        txtiddetalle.Text = ""
    End Sub
    'cargar el alumno al formulario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnagregaralumno.Click
        resetearcolor()
        Dim frm As New frminscripciones
        frm.txtflag.Text = "1"
        frm.lblayuda.Visible = True
        AddOwnedForm(frm)
        frm.ShowDialog()
        obtenercuotas()
    End Sub
    'cargar los aranceles a pagar al formulario
    Private Sub btnagregaritem_Click(sender As Object, e As EventArgs) Handles btnagregaritem.Click

        If txtidalumno.Text <> "" Then
            Dim frm As New Aranceles
            frm.txtflag.Text = "1"
            frm.lblayuda.Visible = True
            AddOwnedForm(frm)
            frm.ShowDialog()
        Else
            MsgBox("Debe Ingresar los Datos del datos del alumno", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
        End If
    End Sub
    'agrgar los los productos al detalle de venta
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnagregararancel.Click
        Try
            If txtidalumno.Text <> "" Then
                If regventa = 0 Then
                    agregarpago()
                    If agregardetalle() Then
                        regventa = 1
                        registropago()
                        limpiardetalle()
                        resetearcolor()
                        obtenercuotas()
                    Else
                            MsgBox("Falta Ingresar Datos", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                        End If

                    Else
                    If agregardetalle() Then
                        registropago()
                        limpiardetalle()
                        resetearcolor()
                        obtenercuotas()
                    Else
                        MsgBox("Debe ingresar un Elemento a Pagar", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                    End If
                End If
            Else
                MsgBox("Debe Ingresar los Datos del datos del alumno", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            End If

        Catch ex As Exception
            MsgBox("Error Nuevo Arancel" + ex.Message)
        End Try
    End Sub
    Public Function agregarpago() As Boolean
        Try

            Dim dts As New vpagos
                Dim func As New fpago
                Dim dtsd As New vdetalle
                Dim funcd As New fdetalles

                dts.gidalumno = CInt(txtidalumno.Text)
                dts.gidcaja = CInt(lblnumcaja.Text)
                dts.gtipocomprobante = cbxtipocomprobante.Text
                dts.gformapago = cbxformapago.Text
                dts.gfpago = DateTime.Now
                dts.ghorapago = DateTime.Now
                dts.gtotalpago = txttotal.Text
                dts.gnumcomprobante = Lblcomprobante.Text

                If func.insertar(dts) Then
                    txtidpago.Text = (funcd.obteneridpago).ToString
                    Return True
                Else
                    Return False
                End If



        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function
    Public Function agregardetalle() As Boolean
        Try
            If txtidarancel.Text <> "0" Then


                Dim dts As New vdetalle
                Dim func As New fdetalles

                dts.gidpago = CInt(txtidpago.Text)
                dts.gidarancel = CInt(txtidarancel.Text)
                dts.gcantidad = CInt(txtcantidad.Value)
                dts.gprecio = CDbl(txtprecioarancel.Text)
                dts.gdescuento = CDbl(txtdescuento.Text)
                dts.gidalumno = CInt(txtidalumno.Text)
                dts.gaño = CInt(Now.Year)

                If func.insertar(dts) Then
                    Return True
                Else
                    Return False
                End If

            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Sub registropago()
        Try
            Dim dts As New vdetalle
            Dim func As New fdetalles

            dts.gidpago = Convert.ToInt32(txtidpago.Text)
            datalistado.DataSource = func.mostrar(dts)
            'datalistado.Columns(0).Visible = False
            'datalistado.Columns(1).Visible = False

            datalistado.ClearSelection()

            'ENVIAMOS LOS DATOS DE EL SUBTOTAL , IGV, TOTAL
            'txttotal.Text = "S./ " & FormatNumber((0.82 * Sumar("importe", listado)), 2)
            'txtigv.Text = "S./ " & FormatNumber((0.18 * Sumar("importe", listado)), 2)
            txttotal.Text = "$ " & FormatNumber(Sumar("Precio", datalistado), 2).ToString

        Catch ex As Exception

        End Try

    End Sub
    Public Sub limpiardetalle()
        txtidarancel.Text = "0"
        txtnombrearancel.Text = ""
        txtprecioarancel.Text = "0"
        txtcantidad.Text = "1"
        txtrecargo.Text = "0"
        txtdescuento.Text = "0"
    End Sub
    Public Sub limpiarpago()
        txtidpago.Text = "0"
        txtidalumno.Text = "0"
        txtdni.Text = "0"
        txtnombre.Text = ""
        txtnivel.Text = ""
        txtcurso.Text = ""
        txtdivision.Text = ""
    End Sub
    Private Function Sumar(ByVal nombre_Columna As String, ByVal dgv As DataGridView) As Double
        Dim Total As Double = 0
        ' suma los importes de cada items de la columna indicada en "nombre_Columna"  

        Try

            If dgv.RowCount > 0 Then
                For i As Integer = 0 To dgv.RowCount - 1
                    Total = Total + CDbl(dgv.Item(nombre_Columna.ToLower, i).Value)
                Next
                Return Total
            Else
                Return Nothing
            End If


        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return Nothing
        End Try

    End Function
    'quitar el arancel del detalle 
    Private Sub btnquitar_Click(sender As Object, e As EventArgs) Handles btnquitar.Click
        Try
            If datalistado.Rows.Count = 0 Then
                MsgBox("El pago no tiene elementos a Quitar", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                Return
            End If

            If datalistado.SelectedRows.Count > 0 Then
                Dim dts As New vdetalle
                Dim func As New fdetalles

                dts.giddetalle = Me.datalistado.SelectedCells.Item(0).Value

                If func.eliminar(dts) Then
                    registropago()
                    resetearcolor()
                    obtenercuotas()
                Else
                    MsgBox("No se Puede Eliminar el Registro")
                End If
            Else
                MsgBox("Seleccione un Registro porfavor", MsgBoxStyle.Information, "Mensaje del Sistema")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        'evaluamos si se quiere cancelar el pago para quitarlo de la base de datos (por cascada se quita el detalle asociado al pago) 
        Try
            If Trim(txtidpago.Text) = "0" Then
                Me.Close()
            Else
                resultado = CType(MessageBox.Show("Desea salir sin Guardar?, El pago se Cancelara", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)

                If resultado = MsgBoxResult.No Then
                    Return
                Else
                    Dim dts As New vpagos
                    Dim func As New fpago

                    dts.gidpago = Convert.ToInt32(txtidpago.Text)

                    If func.eliminar(dts) Then
                        limpiardetalle()
                        resetearcolor()
                        limpiarpago()

                        Me.Close()

                    Else
                        MsgBox("Error al eliminar", MsgBoxStyle.Information, "Mensaje del Sistema")
                    End If
                End If

            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblfecha.Text = DateTime.Now.ToShortDateString()
        Me.lblhora.Text = DateTime.Now.ToLongTimeString()
    End Sub

    Private Sub btnguardaralta_Click(sender As Object, e As EventArgs) Handles btnguardaralta.Click
        'solo se imprime ya que los datos ya fueron guardados
        Try
            If datalistado.Rows.Count = 0 Then
                MsgBox("El pago no tiene Elementos", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            End If
            '------se tendria que carar el formulario del comprobante
            'Dim ventana As New frmcomprobante
            'ventana.idventa = Convert.ToInt32(Me.txtidventa.Text)
            'ventana.ShowDialog()
            'Me.Close()
            limpiarpago()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New frmmovimientos
        frm.txtflag.Text = "1"
        frm.lblnumcaja.Text = lblnumcaja.Text
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub
    Public Sub obtenercuotas()
        Try
            Dim idalu As Integer
            Dim mescuota As String
            Dim func As New fpago

            idalu = Convert.ToInt32(txtidalumno.Text)

            If btnmarzo.BackColor = Color.LightGray Then
                mescuota = "CUOTA MARZO"
                If func.obtenercuotaspagadas(idalu, mescuota) Then
                    btnmarzo.BackColor = Color.LawnGreen
                    btnmarzo.Enabled = False
                Else
                    btnmarzo.BackColor = Color.Red
                End If
            End If

            If btnabril.BackColor = Color.LightGray Then
                mescuota = "CUOTA ABRIL"
                If func.obtenercuotaspagadas(idalu, mescuota) Then
                    btnabril.BackColor = Color.LawnGreen
                    btnabril.Enabled = False
                Else
                    btnabril.BackColor = Color.Red
                End If
            End If

            If btnmayo.BackColor = Color.LightGray Then
                mescuota = "CUOTA MAYO"
                If func.obtenercuotaspagadas(idalu, mescuota) Then
                    btnmayo.BackColor = Color.LawnGreen
                    btnmayo.Enabled = False
                Else
                    btnmayo.BackColor = Color.Red
                End If
            End If

            If btnjunio.BackColor = Color.LightGray Then
                mescuota = "CUOTA JUNIO"
                If func.obtenercuotaspagadas(idalu, mescuota) Then
                    btnjunio.BackColor = Color.LawnGreen
                    btnjunio.Enabled = False
                Else
                    btnjunio.BackColor = Color.Red
                End If
            End If

            If btnjulio.BackColor = Color.LightGray Then
                mescuota = "CUOTA JULIO"
                If func.obtenercuotaspagadas(idalu, mescuota) Then
                    btnjulio.BackColor = Color.LawnGreen
                    btnjulio.Enabled = False
                Else
                    btnjulio.BackColor = Color.Red
                End If
            End If

            If btnagosto.BackColor = Color.LightGray Then
                mescuota = "CUOTA AGOSTO"
                If func.obtenercuotaspagadas(idalu, mescuota) Then
                    btnagosto.BackColor = Color.LawnGreen
                    btnagosto.Enabled = False
                Else
                    btnagosto.BackColor = Color.Red
                End If
            End If

            If btnseptiembre.BackColor = Color.LightGray Then
                mescuota = "CUOTA SEPTIEMBRE"
                If func.obtenercuotaspagadas(idalu, mescuota) Then
                    btnseptiembre.BackColor = Color.LawnGreen
                    btnseptiembre.Enabled = False
                Else
                    btnseptiembre.BackColor = Color.Red
                End If
            End If

            If btnoctubre.BackColor = Color.LightGray Or btnoctubre.BackColor = Color.Red Then
                mescuota = "CUOTA OCTUBRE"
                If func.obtenercuotaspagadas(idalu, mescuota) Then
                    btnoctubre.BackColor = Color.LawnGreen
                    btnoctubre.Enabled = False
                Else
                    btnoctubre.BackColor = Color.Red
                End If
            End If

            If btnnoviembre.BackColor = Color.LightGray Or btnnoviembre.BackColor = Color.Red Then
                mescuota = "CUOTA NOVIEMBRE"
                If func.obtenercuotaspagadas(idalu, mescuota) Then
                    btnnoviembre.BackColor = Color.LawnGreen
                    btnnoviembre.Enabled = False
                Else
                    btnnoviembre.BackColor = Color.Red
                End If
            End If

            If btndiciembre.BackColor = Color.LightGray Or btndiciembre.BackColor = Color.Red Then
                mescuota = "CUOTA DICIEMBRE"
                If func.obtenercuotaspagadas(idalu, mescuota) Then
                    btndiciembre.BackColor = Color.LawnGreen
                    btndiciembre.Enabled = False
                Else
                    btndiciembre.BackColor = Color.Red
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub resetearcolor()
        btnmarzo.BackColor = Color.LightGray
        btnmarzo.Enabled = True
        btnabril.BackColor = Color.LightGray
        btnabril.Enabled = True
        btnmayo.BackColor = Color.LightGray
        btnmayo.Enabled = True
        btnjunio.BackColor = Color.LightGray
        btnjunio.Enabled = True
        btnjulio.BackColor = Color.LightGray
        btnjulio.Enabled = True
        btnagosto.BackColor = Color.LightGray
        btnagosto.Enabled = True
        btnseptiembre.BackColor = Color.LightGray
        btnseptiembre.Enabled = True
        btnoctubre.BackColor = Color.LightGray
        btnoctubre.Enabled = True
        btnnoviembre.BackColor = Color.LightGray
        btnnoviembre.Enabled = True
        btndiciembre.BackColor = Color.LightGray
        btndiciembre.Enabled = True
    End Sub

    Private Sub btnmarzo_Click(sender As Object, e As EventArgs) Handles btnmarzo.Click

        Dim idarancel As Integer
        idarancel = 1
        agregarcuotaboton(idarancel)

    End Sub
    Private Sub agregarcuotaboton(ByVal id As Integer)
        Dim func As New fdetalles

        dt = func.buscararancel(id)

        If dt.Rows.Count = 1 Then

            txtidarancel.Text = dt.Rows(0).Item(0).ToString
            txtnombrearancel.Text = dt.Rows(0).Item(1).ToString
            txtprecioarancel.Text = dt.Rows(0).Item(2).ToString

        End If
    End Sub

    Private Sub btnabril_Click(sender As Object, e As EventArgs) Handles btnabril.Click
        Dim idarancel As Integer
        idarancel = 2
        agregarcuotaboton(idarancel)
    End Sub

    Private Sub btnmayo_Click(sender As Object, e As EventArgs) Handles btnmayo.Click
        Dim idarancel As Integer
        idarancel = 3
        agregarcuotaboton(idarancel)
    End Sub

    Private Sub btnjunio_Click(sender As Object, e As EventArgs) Handles btnjunio.Click
        Dim idarancel As Integer
        idarancel = 4
        agregarcuotaboton(idarancel)
    End Sub

    Private Sub btnjulio_Click(sender As Object, e As EventArgs) Handles btnjulio.Click
        Dim idarancel As Integer
        idarancel = 5
        agregarcuotaboton(idarancel)
    End Sub

    Private Sub btnagosto_Click(sender As Object, e As EventArgs) Handles btnagosto.Click
        Dim idarancel As Integer
        idarancel = 6
        agregarcuotaboton(idarancel)
    End Sub

    Private Sub btnseptiembre_Click(sender As Object, e As EventArgs) Handles btnseptiembre.Click
        Dim idarancel As Integer
        idarancel = 8
        agregarcuotaboton(idarancel)
    End Sub

    Private Sub btnoctubre_Click(sender As Object, e As EventArgs) Handles btnoctubre.Click
        Dim idarancel As Integer
        idarancel = 9
        agregarcuotaboton(idarancel)
    End Sub

    Private Sub btnnoviembre_Click(sender As Object, e As EventArgs) Handles btnnoviembre.Click
        Dim idarancel As Integer
        idarancel = 10
        agregarcuotaboton(idarancel)
    End Sub

    Private Sub btndiciembre_Click(sender As Object, e As EventArgs) Handles btndiciembre.Click
        Dim idarancel As Integer
        idarancel = 11
        agregarcuotaboton(idarancel)
    End Sub
End Class