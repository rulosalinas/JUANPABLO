Imports System.Data.SqlClient
Imports System.Data
Public Class fmovimientos
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function mostrar(dts As vmovimientos) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_movimiento")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idcaja", SqlDbType.NVarChar, 50).Value = dts.gidcaja

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

    Public Function insertar(ByVal dts As vmovimientos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_movimiento")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idcaja", dts.gidcaja)
            cmd.Parameters.AddWithValue("@montomov", dts.gmontomov)
            cmd.Parameters.AddWithValue("@tipomov", dts.gtipomov)
            cmd.Parameters.AddWithValue("@descmov", dts.gdescmov)
            cmd.Parameters.AddWithValue("@fechamov", dts.gfechamov)
            cmd.Parameters.AddWithValue("@horamov", dts.ghoramov)

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
    Public Function eliminar(dts As vmovimientos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_movimiento")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idmov", SqlDbType.NVarChar, 50).Value = dts.gidmov
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
End Class
