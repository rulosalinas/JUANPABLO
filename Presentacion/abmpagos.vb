Public Class frmabmpagos
    Private dt As New DataTable
    Dim regventa As Integer = 0
    Dim resultado As MsgBoxResult

    Private Sub frmpagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dts As New vpagos
        Dim func As New fpago

        Lblcomprobante.Text = func.generarcodigo
        limpiar()

        Timer1.Interval = 1000
        Timer1.Start()
    End Sub
    Private Sub frmabmpagos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        resultado = CType(MessageBox.Show("Desea salir sin Guardar?, El pago se Cancelara", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
            e.Cancel = True
        Else
            Try
                If Trim(txtidpago.Text) = "0" Then
                    Me.Close()
                    Return
                End If
                Dim dts As New vdetalle
                Dim func As New fdetalles

                dts.gidpago = Convert.ToInt32(txtidpago.Text)


                If func.eliminar(dts) Then

                    For Each row As DataGridViewRow In datalistado.Rows
                        Dim iditem As Integer = Convert.ToInt32(row.Cells("iditem").Value)
                        Dim cantidad As Integer = Convert.ToInt32(row.Cells("cantidad").Value)

                        dts.gidarancel = iditem
                        dts.gcantidad = cantidad
                    Next

                    Me.Close()

                Else
                    MsgBox("Error al eliminar", MsgBoxStyle.Information, "Mensaje del Sistema")
                End If
            Catch ex As Exception

            End Try
            e.Cancel = False
        End If
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
        Dim frm As New frminscripciones
        frm.txtflag.Text = "1"
        frm.lblayuda.Visible = True
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub
    'cargar los aranceles a pagar al formulario
    Private Sub btnagregaritem_Click(sender As Object, e As EventArgs) Handles btnagregaritem.Click
        Dim frm As New Aranceles
        frm.txtflag.Text = "1"
        frm.lblayuda.Visible = True
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub
    'agrgar los los productos al detalle de venta
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnagregararancel.Click
        Try
            If regventa = 0 Then
                If agregarpago() Then
                    If agregardetalle() Then
                        regventa = 1
                        registropago()
                        limpiardetalle()
                    Else
                        MsgBox("Falta Ingresar Datos", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                    End If
                Else
                    MsgBox("Falta Ingresar los Datos del datos del alumno", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                End If

            Else
                If agregardetalle() Then
                    registropago()
                    limpiardetalle()
                Else
                    MsgBox("Falta Ingresar Datos para pagar", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                End If
            End If

        Catch ex As Exception
            MsgBox("Error Nuevo Arancel" + ex.Message)
        End Try
    End Sub
    Public Function agregarpago() As Boolean
        Try
            If txtidalumno.Text <> "" Then

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
            If txtidpago.Text <> "0" And txtidarancel.Text <> "0" Then

                'Dim dts As New vpagos
                ' Dim func As New fpago
                Dim dts As New vdetalle
                Dim func As New fdetalles

                dts.gidpago = CInt(txtidpago.Text)
                dts.gidarancel = CInt(txtidarancel.Text)
                dts.gcantidad = CInt(txtcantidad.Value)
                dts.gprecio = CDbl(txtprecioarancel.Text)
                dts.gdescuento = CDbl(txtdescuento.Text)


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
            txttotal.Text = "$./ " & FormatNumber(Sumar("precio_arancel", datalistado), 2).ToString

        Catch ex As Exception

        End Try

    End Sub
    Public Sub limpiardetalle()
        Try

            txtidarancel.Text = "0"
            txtnombrearancel.Text = ""
            txtprecioarancel.Text = "0"
            txtcantidad.Text = "1"
            txtrecargo.Text = "0"
            txtdescuento.Text = "0"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
                'dts.gidarancel = Me.datalistado.SelectedCells.Item(1).Value
                'dts.gcantidad = Me.datalistado.SelectedCells.Item(2).Value

                If func.eliminar(dts) Then

                    registropago()
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
                Return
            End If
            Dim dts As New vdetalle
            Dim func As New fdetalles

            dts.gidpago = Convert.ToInt32(txtidpago.Text)


            If func.eliminar(dts) Then

                For Each row As DataGridViewRow In datalistado.Rows
                    Dim iditem As Integer = Convert.ToInt32(row.Cells("iditem").Value)
                    Dim cantidad As Integer = Convert.ToInt32(row.Cells("cantidad").Value)

                    dts.gidarancel = iditem
                    dts.gcantidad = cantidad
                Next

                Me.Close()

            Else
                MsgBox("Error al eliminar", MsgBoxStyle.Information, "Mensaje del Sistema")
            End If
        Catch ex As Exception

        End Try

    End Sub

    'Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
    '    Try
    '        txtiddetalle.Text = datalistado.SelectedCells.Item(0).Value
    '        txtidarancel.Text = datalistado.SelectedCells.Item(2).Value
    '        txtnombrearancel.Text = datalistado.SelectedCells.Item(3).Value
    '        txtprecioarancel.Text = datalistado.SelectedCells.Item(5).Value
    '        txtdescuento.Text = datalistado.SelectedCells.Item(6).Value
    '        txtrecargo.Text = datalistado.SelectedCells.Item(7).Value

    '    Catch ex As Exception
    '        MsgBox("Error datalistado" + ex.Message)
    '    End Try

    'End Sub


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

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class