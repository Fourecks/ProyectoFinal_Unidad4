Imports Microsoft.VisualBasic
Imports System.Data
Public Class Materia


    'Instancia de la conexion
    Dim c As New conexion

    Private IdMater As String
    Private nombreMateria As String
    Private IdCarrera As String
    Private UV As String
    Private pagina As Materia

    'Metodos de la propiedad
    Public Property idMateria() As String
        Get
            Return IdMater

        End Get
        Set(value As String)
            IdMater = value
        End Set
    End Property
    Public Property nomMateria() As String
        Get
            Return nombreMateria

        End Get
        Set(value As String)
            nombreMateria = value
        End Set
    End Property
    Public Property idCarrer() As String
        Get
            Return IdCarrera

        End Get
        Set(value As String)
            IdCarrera = value
        End Set
    End Property
    Public Property uvCarrera() As String
        Get
            Return UV

        End Get
        Set(value As String)
            UV = value
        End Set
    End Property


    'Función para mostrar lista de estudiantes
    Public Function listarRegistros() As DataTable
        'hace referencia a la instancia de la clase conexión
        c.strcon.Open()
        With c.cmd
            'cadena de conexión
            .Connection = c.strcon
            'consulta de la tabla estudiante
            .CommandText = "SELECT idmateria,materia,idcarrera FROM materia"
        End With
        c.da.SelectCommand = c.cmd
        c.da.Fill(c.dt)
        Return c.dt
    End Function



    'Método para editar, mostrar registro por Id
    'Si los campos son diferentes o mas se sustituyen y/o agrean
    Public Function mostrarRegistro() As DataTable
        c.strcon.Open()
        With c.cmd
            .Connection = c.strcon
            .CommandText = "SELECT idmateria,materia,idcarrera,uv FROM materia where idmateria = '" & idMateria & "' "
            c.result = c.cmd.ExecuteNonQuery
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
                .CommandText = "INSERT INTO materia values ('""','" & nombreMateria & "')"
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



    'Metodo para actualizr registros
    'Para utilizar con otra clase, cambie nombre de tabla y de los campos que se van actualizar
    Public Sub editar()
        Try
            c.strcon.Open()
            With c.cmd
                .Connection = c.strcon
                .CommandText = "UPDATE materia SET 
                                materia ='" & nomMateria & "')"

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

    'Función para eliminar Materia seleccionada
    Public Sub eliminar()
        Try
            'hace referencia a la instancia de la clase conexión
            c.strcon.Open()
            With c.cmd
                'cadena de conexión
                .Connection = c.strcon
                'consulta de la tabla materia
                .CommandText = "DELETE FROM materia where idmateria = '" & idMateria & "' "
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
