﻿
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class conexion

    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public result As String

    Public Function strconexion() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;database=academica;port=3306")
    End Function

    Public strcon As MySqlConnection = strconexion()

End Class
