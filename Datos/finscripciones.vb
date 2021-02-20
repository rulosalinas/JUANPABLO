Imports System.Data.SqlClient
Imports System.Data
Public Class finscripciones
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_inscripcion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function buscar(ByVal opcion As String, ByVal dato As String, ByVal dg As DataGridView) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscar_inscripcion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@opcion", opcion)
            cmd.Parameters.AddWithValue("@dato", dato)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function
    Public Function insertar(ByVal dts As vinscripciones) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_inscripcion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idalu", dts.gidalumno)
            cmd.Parameters.AddWithValue("@idnivel", dts.gidnivel)
            cmd.Parameters.AddWithValue("@idcurso", dts.gidcurso)
            cmd.Parameters.AddWithValue("@iddivision", dts.giddivision)
            cmd.Parameters.AddWithValue("@fechainscripcion", dts.gfinscripcion)
            cmd.Parameters.AddWithValue("@idaño", dts.ganio)
            cmd.Parameters.AddWithValue("@condicional", dts.gcondicional)
            cmd.Parameters.Add("@MENSAJE", SqlDbType.VarChar, 100).Direction = 2

            If cmd.ExecuteNonQuery Then
                Dim MENSAJE As String = cmd.Parameters("@MENSAJE").Value.ToString
                MessageBox.Show(MENSAJE, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("Error insertar inscripcion " + ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function editar(ByVal dts As vinscripciones) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_inscripcion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idalu", dts.gidalumno)
            cmd.Parameters.AddWithValue("@idnivel", dts.gidnivel)
            cmd.Parameters.AddWithValue("@idcurso", dts.gidcurso)
            cmd.Parameters.AddWithValue("@iddivision", dts.giddivision)
            cmd.Parameters.AddWithValue("@fechainscripcion", dts.gfinscripcion)
            cmd.Parameters.AddWithValue("@idaño", dts.ganio)
            cmd.Parameters.AddWithValue("@condicional", dts.gcondicional)
            cmd.Parameters.Add("@MENSAJE", SqlDbType.VarChar, 100).Direction = 2

            If cmd.ExecuteNonQuery Then
                Dim MENSAJE As String = cmd.Parameters("@MENSAJE").Value.ToString
                MessageBox.Show(MENSAJE, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function eliminar(dts As vinscripciones) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_inscripcion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idinscripcion", SqlDbType.NVarChar, 50).Value = dts.gidinscripcion
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try
    End Function
    'llenar los combos 
    Public Function llenarnivel() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("select_nivel")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
        End Try
    End Function
    Public Function llenarcurso(ByVal dts As vinscripciones) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("select_curso")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idnivel", SqlDbType.NVarChar, 50).Value = dts.gidnivel
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
        End Try
    End Function
    Public Function llenardivision(ByVal dts As vinscripciones) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("select_division")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idcurso", SqlDbType.NVarChar, 50).Value = dts.gidcurso
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
        End Try
    End Function
End Class
