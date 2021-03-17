Imports System.Data.SqlClient
Imports System.Data
Public Class fpago
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_pago")
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
            cmd = New SqlCommand("mostrar_pago")
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
    Public Function insertar(ByVal dts As vpagos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_pago")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idcaja", dts.gidcaja)
            cmd.Parameters.AddWithValue("@idalumno", dts.gidalumno)
            cmd.Parameters.AddWithValue("@tipocomprobante", dts.gtipocomprobante)
            cmd.Parameters.AddWithValue("@numcomprobante", dts.gnumcomprobante)
            cmd.Parameters.AddWithValue("@fechapago", dts.gfpago)
            cmd.Parameters.AddWithValue("@horapago", dts.ghorapago)
            cmd.Parameters.AddWithValue("@formapago", dts.gformapago)
            cmd.Parameters.AddWithValue("@total", dts.gtotalpago)


            If cmd.ExecuteNonQuery Then
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

    Public Function eliminar(dts As vpagos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_pago")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idpago", SqlDbType.NVarChar, 50).Value = dts.gidpago
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
    Public Function generarcodigo() As Integer
        Dim nrodocumento As String
        Try
            Dim numero As Integer
            conectado()
            Dim cmd As New SqlCommand("generar_nrocomprobante", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader

            If lector.HasRows Then
                lector.Read()

                numero = Convert.ToInt32(lector(0).ToString)
                numero += 1
                nrodocumento = Format(numero, "0000000")

                lector.Close()
                Return nrodocumento
            Else
                nrodocumento = "0000001"
                lector.Close()
                Return nrodocumento
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function
    Public Function obtenercuotaspagadas(ByVal idalu As Integer, ByVal nombrearancel As String) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("buscar_cuota")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idalu", idalu)
            cmd.Parameters.AddWithValue("@nombrearancel", nombrearancel)

            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader

            If lector.HasRows Then
                lector.Close()
                Return True
            Else
                lector.Close()
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function cuotasboton(ByVal idalu As Integer, ByVal nombrearancel As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscar_cuota")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idalu", idalu)
            cmd.Parameters.AddWithValue("@nombrearancel", nombrearancel)

            'Dim lector As SqlDataReader
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)

            If cmd.ExecuteNonQuery Then
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

End Class
