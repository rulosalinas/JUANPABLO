Imports System.Data
Imports System.Data.SqlClient
Public Class frminscripciones
    Private dt As New DataTable
    Private Sub fmrinscripciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        'ocultarcolumnas()
    End Sub
    
    Private Sub mostrar()
        Try
            Dim func As New finscripciones
            dt = func.mostrar

            If dt.Rows.Count <> 0 Then
                dginscripcion.DataSource = dt
                txtbuscar.Enabled = True               '--habilita opciones de busqueda despues de comprobar que en la base hay elemento
                dginscripcion.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                dginscripcion.DataSource = Nothing '-- sentencia para cuando no exixten datos en la base
                txtbuscar.Enabled = False
                dginscripcion.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox("Procedimiento Buscar " + ex.Message)
        End Try
        'buscar()
    End Sub
    Private Sub buscar()

        Try
            Dim func As New finscripciones
            dt = func.buscar(cbxbusqueda.Text, txtbuscar.Text, dginscripcion)

            If dt.Rows.Count <> 0 Then    '-- comprobar que los registros exixtan
                dginscripcion.DataSource = dt
                dginscripcion.ColumnHeadersVisible = True
                inexistente.Visible = False

            Else ' -- no se encuentran registros
                dginscripcion.DataSource = Nothing '-- sentencia para cuando no exixten datos en la base
                dginscripcion.ColumnHeadersVisible = False
                inexistente.Visible = True
                
            End If

        Catch ex As Exception
            MsgBox("Procedimiento Buscar " + ex.Message)
        End Try
    End Sub
    'Private Sub ocultarcolumnas()
    '    'dginscripcion.Columns(0).Visible = False '--oculta columna n°1 id
    '    dginscripcion.Columns(4).Visible = False
    '    dginscripcion.Columns(6).Visible = False
    '    dginscripcion.Columns(8).Visible = False

    'End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub
    'validacion de cajas de Texto
    Private Sub btnnuevo_Click_1(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Try
            Dim frm As New frmabminscripciones
            frm.txtidinscripcion.Text = ""
            frm.txtidalumno.Text = ""
            frm.txtdni.Text = ""
            frm.txtnombre.Text = ""
            'frm.cbxnivel.Text = ""
            'frm.cbxcurso.Text = ""
            'frm.cbxdivision.Text = ""
            frm.btnbuscaralumno.Visible = True
            frm.lblnuevo.Visible = True
            frm.btnguardaralta.Visible = True
            frm.llenarnivel()
            frm.ShowDialog()
            mostrar()
        Catch ex As Exception
            MsgBox("Nueva Inscripcion " + ex.Message)
        End Try
    End Sub


    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Try
            Dim result As DialogResult
            result = MessageBox.Show("Esta Seguro que Desea Editar los Datos?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then
                Dim frm As New frmabminscripciones
                frm.txtidinscripcion.Text = dginscripcion.SelectedCells.Item(0).Value
                frm.txtidalumno.Text = dginscripcion.SelectedCells.Item(1).Value
                frm.txtdni.Text = dginscripcion.SelectedCells.Item(2).Value
                frm.txtnombre.Text = dginscripcion.SelectedCells.Item(3).Value + ", " + dginscripcion.SelectedCells.Item(4).Value  'item 6 estado del alumno
                frm.cbxnivel.Text = dginscripcion.SelectedCells.Item(6).Value '9 id nivel
                frm.cbxcurso.Text = dginscripcion.SelectedCells.Item(8).Value '13 id curso
                frm.cbxdivision.Text = dginscripcion.SelectedCells.Item(10).Value '15 iddiviion
                frm.dtfinscripcion.Text = dginscripcion.SelectedCells.Item(12).Value

                frm.lblmodificar.Visible = True
                frm.btnguardaredicion.Visible = True
                frm.ShowDialog()
                mostrar()
            End If
        Catch ex As Exception
            MsgBox("error editar" + ex.Message)
        End Try

    End Sub


    Private Sub btnbaja_Click(sender As Object, e As EventArgs) Handles btnbaja.Click
        Try
            Dim result As DialogResult
            result = MessageBox.Show("Esta Seguro que Desea Eliminar la Inscripcion?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then
                Dim frm As New frmabminscripciones
                frm.txtidinscripcion.Text = dginscripcion.SelectedCells.Item(0).Value
                frm.txtidalumno.Text = dginscripcion.SelectedCells.Item(1).Value
                frm.txtdni.Text = dginscripcion.SelectedCells.Item(2).Value
                frm.txtnombre.Text = dginscripcion.SelectedCells.Item(3).Value + ", " + dginscripcion.SelectedCells.Item(4).Value  'item 6 estado del alumno
                frm.cbxnivel.Text = dginscripcion.SelectedCells.Item(6).Value '9 id nivel
                frm.cbxcurso.Text = dginscripcion.SelectedCells.Item(8).Value '13 id curso
                frm.cbxdivision.Text = dginscripcion.SelectedCells.Item(10).Value '15 iddiviion
                frm.dtfinscripcion.Text = dginscripcion.SelectedCells.Item(12).Value

                frm.lblbaja.Visible = True
                frm.btnguardarbaja.Visible = True
                frm.ShowDialog()
                mostrar()
            End If
        Catch ex As Exception
            MsgBox("error baja" + ex.Message)
        End Try


    End Sub


    Private Sub button29_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub dginscripcion_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dginscripcion.CellDoubleClick
        If txtflag.Text = "1" Then
            Dim frm As frmabmpagos = CType(Owner, frmabmpagos)

            frm.txtidalumno.Text = dginscripcion.SelectedCells.Item(1).Value.ToString
            frm.txtdni.Text = dginscripcion.SelectedCells.Item(2).Value.ToString
            frm.txtnombre.Text = dginscripcion.SelectedCells.Item(3).Value.ToString + ", " + dginscripcion.SelectedCells.Item(4).Value.ToString
            frm.txtnivel.Text = dginscripcion.SelectedCells.Item(7).Value.ToString
            frm.txtcurso.Text = dginscripcion.SelectedCells.Item(9).Value.ToString
            frm.txtdivision.Text = dginscripcion.SelectedCells.Item(11).Value.ToString
            Me.txtflag.Text = "0"
            Me.lblayuda.Visible = False
            Me.Close()

        End If
    End Sub
End Class