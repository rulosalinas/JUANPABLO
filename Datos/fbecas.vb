Imports System.Data.SqlClient
Imports System.Data
Public Class fbecas
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_beca")
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

    Public Function insertar(ByVal dts As vbecas) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_beca")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idalu", dts.gidalumno)
            cmd.Parameters.AddWithValue("@iniciobeca", dts.giniciobeca)
            cmd.Parameters.AddWithValue("@resolucionbeca", dts.gresolucionbeca)
            cmd.Parameters.AddWithValue("@estadobeca", dts.gestadobeca)


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

    Public Function editar(ByVal dts As vbecas) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_beca")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("idbeca", dts.gidbeca)
            cmd.Parameters.AddWithValue("@idalu", dts.gidalumno)
            cmd.Parameters.AddWithValue("@iniciobeca", dts.giniciobeca)
            cmd.Parameters.AddWithValue("@resolucionbeca", dts.gresolucionbeca)
            cmd.Parameters.AddWithValue("@estadobeca", dts.gestadobeca)


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
    Public Function eliminar(dts As vbecas) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_beca")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("idbeca", dts.gidbeca)
            cmd.Parameters.AddWithValue("@finbeca", dts.gfinbeca)
            cmd.Parameters.AddWithValue("@estadobeca", dts.gestadobeca)

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
