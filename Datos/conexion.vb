﻿Imports System.Data.SqlClient
'clase conexion para conectarnos y deconectarnos de la base de datos
Public Class conexion
    Protected cnn As New SqlConnection
    Public id_usuario As Integer

    Protected Function conectado()
        Try
            cnn = New SqlConnection("data source = RULO; initial catalog=JUANPABLO; integrated security=true")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
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
