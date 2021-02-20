Imports System.Data.SqlClient
Imports System.Data
Public Class faranceles
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_arancel")
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

    Public Function insertar(ByVal dts As varanceles) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_arancel")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idcategoria", dts.gidcategoria)
            cmd.Parameters.AddWithValue("@nombrearancel", dts.gnombrearancel)
            cmd.Parameters.AddWithValue("@precioarancel", dts.gprecioarancel)

            'cmd.Parameters.Add("@MENSAJE", SqlDbType.VarChar, 100).Direction = 2

            If cmd.ExecuteNonQuery Then
                'Dim MENSAJE As String = cmd.Parameters("@MENSAJE").Value.ToString
                'MessageBox.Show(MENSAJE, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
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

    Public Function editar(ByVal dts As varanceles) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("modificar_arancel")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idarancel", dts.gidarancel)
            cmd.Parameters.AddWithValue("@idcategoria", dts.gidcategoria)
            cmd.Parameters.AddWithValue("@nombrearancel", dts.gnombrearancel)
            cmd.Parameters.AddWithValue("@precioarancel", dts.gprecioarancel)

            'cmd.Parameters.Add("@MENSAJE", SqlDbType.VarChar, 100).Direction = 2

            If cmd.ExecuteNonQuery Then
                ' Dim MENSAJE As String = cmd.Parameters("@MENSAJE").Value.ToString
                'MessageBox.Show(MENSAJE, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
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
    Public Function eliminar(dts As varanceles) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_arancel")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idarancel", SqlDbType.NVarChar, 50).Value = dts.gidarancel
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
    Public Function llenacategoria() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_categoria")
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

End Class
