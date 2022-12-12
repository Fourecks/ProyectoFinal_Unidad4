Imports Microsoft.VisualBasic
Imports System.Data
Public Class Usuario

    'Instancia de la conexion
    Dim c As New conexion

    Private Id As String
    Private nombreUsuario As String
    Private claveUsuario As String
    Private nivelUsuario As String
    Private pagina As Materia

    'Metodos de la propiedad
    Public Property idUsuario() As String
        Get
            Return Id

        End Get
        Set(value As String)
            Id = value
        End Set
    End Property
    Public Property nomUsuario() As String
        Get
            Return nombreUsuario

        End Get
        Set(value As String)
            nombreUsuario = value
        End Set
    End Property
    Public Property clavUsuario() As String
        Get
            Return claveUsuario

        End Get
        Set(value As String)
            claveUsuario = value
        End Set
    End Property
    Public Property nivUsuario() As String
        Get
            Return nivelUsuario

        End Get
        Set(value As String)
            nivelUsuario = value
        End Set
    End Property



    'Función para mostrar lista de usuarios
    Public Function listarRegistros() As DataTable
        'hace referencia a la instancia de la clase conexión
        c.strcon.Open()
        With c.cmd
            'cadena de conexión
            .Connection = c.strcon
            'consulta de la tabla usuarios
            .CommandText = "SELECT idusuario, nombre, clave FROM usuario"
        End With
        c.da.SelectCommand = c.cmd
        c.da.Fill(c.dt)
        Return c.dt
    End Function


    'Método para guardar
    Public Sub guardar()
        Try
            c.strcon.Open()
            With c.cmd
                .Connection = c.strcon
                .CommandText = "INSERT INTO usuario values ('""','" & idUsuario & "','" & nomUsuario & "','" & clavUsuario & "', '" & nivUsuario & "')"
                c.result = c.cmd.ExecuteNonQuery
            End With
            If c.result = 0 Then
                MsgBox("No se ha podido guardar", MsgBoxStyle.Critical)
            Else
                MsgBox("Registro guardado exitosamente", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
            MsgBox("NO se ha podido guardar el registro", MsgBoxStyle.Critical)
        End Try
        c.strcon.Close()
    End Sub



    'Método para editar, mostrar registro por Id
    'Si los campos son diferentes o mas se sustituyen y/o agrean
    Public Function mostrarRegistro() As DataTable
        c.strcon.Open()
        With c.cmd
            .Connection = c.strcon
            .CommandText = "SELECT idUsuario,nombre,clave,nivel FROM usuario where idusuario = '" & nomUsuario & "' "
            c.result = c.cmd.ExecuteNonQuery
        End With
        c.da.SelectCommand = c.cmd
        c.da.Fill(c.dt)
        Return c.dt

    End Function



    'Metodo para actualizr registros
    'Para utilizar con otra clase, cambie nombre de tabla y de los campos que se van actualizar
    Public Sub editar()
        Try
            c.strcon.Open()
            With c.cmd
                .Connection = c.strcon
                .CommandText = "UPDATE usuario SET 
                                nombre ='" & nomUsuario & "',
                                clave ='" & clavUsuario & "')"

                c.result = c.cmd.ExecuteNonQuery
            End With

            If c.result = 0 Then
                MsgBox("No se ha podido actualizar", MsgBoxStyle.Critical)
            Else
                MsgBox("Registro actualizado exitosamente", MsgBoxStyle.OkOnly)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        c.strcon.Close()
    End Sub

    'Función para eliminar Usuario seleccionada
    Public Sub eliminar()
        Try
            'hace referencia a la instancia de la clase conexión
            c.strcon.Open()
            With c.cmd
                'cadena de conexión
                .Connection = c.strcon
                'consulta de la tabla usuario
                .CommandText = "DELETE FROM usuario where idUsuario = '" & idUsuario & "' "
                c.result = c.cmd.ExecuteNonQuery
            End With

            If c.result = 0 Then
                MsgBox("No se ha podido eliminar", MsgBoxStyle.Critical)
            Else
                MsgBox("Registro eliminado exitosamente", MsgBoxStyle.OkOnly)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        c.strcon.Close()
    End Sub

End Class
