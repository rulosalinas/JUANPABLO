﻿Imports System.Data.SqlClient
Imports System.Data
Public Class fdetalles
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function quitardetalle(ByVal dts As vdetalle) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("quitar_detalle")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idpago", dts)
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

    Public Function obteneridpago() As Integer
        Dim id As Integer
        Try
            conectado()
            cmd = New SqlCommand("obteneridpago")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader

            If lector.HasRows Then
                lector.Read()
                id = Convert.ToInt32(lector(0).ToString)
                lector.Close()
                Return id
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


    Public Function mostrar(ByVal dts As vdetalle) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_detalle")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idpago", dts.gidpago)
            'cmd.Parameters.Add("@idpago", SqlDbType.NVarChar, 50).Value = dts.gidpago

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

    'Public Function buscar(ByVal opcion As String, ByVal dato As String, ByVal dg As DataGridView) As DataTable
    '    Try
    '        conectado()
    '        cmd = New SqlCommand("buscar_detalle")
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Connection = cnn
    '        cmd.Parameters.AddWithValue("@opcion", opcion)
    '        cmd.Parameters.AddWithValue("@dato", dato)

    '        If cmd.ExecuteNonQuery Then
    '            Dim dt As New DataTable
    '            Dim da As New SqlDataAdapter(cmd)
    '            da.Fill(dt)
    '            Return dt
    '        Else
    '            Return Nothing
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return Nothing
    '    Finally
    '        desconectado()
    '    End Try
    'End Function
    Public Function insertar(ByVal dts As vdetalle) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_detalle")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idpago", dts.gidpago)
            cmd.Parameters.AddWithValue("@idarancel", dts.gidarancel)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@precio", dts.gprecio)
            cmd.Parameters.AddWithValue("@descuento", dts.gdescuento)

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

    Public Function eliminar(dts As vdetalle) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_detalle")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@iddetalle", SqlDbType.NVarChar, 50).Value = dts.giddetalle

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


End Class
