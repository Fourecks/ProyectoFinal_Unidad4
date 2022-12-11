Imports Microsoft.VisualBasic
Imports System.Data
Public Class Docente
    'Instancia de la conexion
    Dim c As New conexion

    Private Id As String
    Private codigoDocente As String
    Private nombreDocente As String
    Private apellidoDocente As String
    Private correoDocente As String
    Private telefonoDocente As String

    Private pagina As Page

    'Metodos de la propiedad
    Public Property idDocente() As String
        Get
            Return Id

        End Get
        Set(value As String)
            Id = value
        End Set
    End Property

    Public Property nomDocente() As String
        Get
            Return nombreDocente

        End Get
        Set(value As String)
            nombreDocente = value
        End Set
    End Property
    Public Property apeDocente() As String
        Get
            Return apellidoDocente

        End Get
        Set(value As String)
            apellidoDocente = value
        End Set
    End Property

    Public Property mailDocente() As String
        Get
            Return correoDocente

        End Get
        Set(value As String)
            correoDocente = value
        End Set
    End Property

    Public Property telDocente() As String
        Get
            Return telefonoDocente

        End Get
        Set(value As String)
            telefonoDocente = value
        End Set
    End Property

    Public Property codDocente() As String
        Get
            Return codigoDocente

        End Get
        Set(value As String)
            codigoDocente = value
        End Set
    End Property

    'Función para mostrar lista de docentes
    Public Function listarRegistros() As DataTable
        'hace referencia a la instancia de la clase conexión
        c.strcon.Open()
        With c.cmd
            'cadena de conexión
            .Connection = c.strcon
            'consulta de la tabla docente
            .CommandText = "SELECT iddocente, nombredocente, apellidodocente, correodocente, telefonodocente, codigodocente FROM docente"
        End With
        c.da.SelectCommand = c.cmd
        c.da.Fill(c.dt)
        Return c.dt
    End Function


    'Método para editar, mostrar registro por Id
    'Para utilizar con otra clase, cambie el nombre de la tabla
    'Cambie los nombres de los campos que quiere mostrar en el formulario
    Public Function mostrarRegistro() As DataTable
        c.strcon.Open()
        With c.cmd
            .Connection = c.strcon
            'Obtener los campos de la tabla si el identificador iddocente es igual a idDocente
            'Parámetro que se pasa al dar clic en Editar o Eliminar.
            .CommandText = "SELECT iddocente, nombredocente, apellidodocente, correodocente, telefonodocente, codigodocente FROM docente where iddocente = '" & idDocente & "' "
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
                .CommandText = "INSERT INTO docente values ('""','" & nomDocente & "','" & apeDocente & "','" & mailDocente & "','" & telDocente & "','" & codDocente & "')"
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
                .CommandText = "UPDATE docente SET nombre ='" & nomDocente & "', apellido = '" & apeDocente & "', correo = '" & mailDocente & "', telefono = '" & telDocente & "' WHERE idalumno = '" & idDocente & "' "

                'Estos dos campos no son editables, no es necesario actualizar
                'porque no pueden modificarse.
                'idestudiante ='" & idAlumno & "'
                'codigo = '" & codAlumno & "'


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

    'Función para eliminar docente seleccionado
    Public Sub eliminar()
        Try
            'hace referencia a la instancia de la clase conexión
            c.strcon.Open()
            With c.cmd
                'cadena de conexión
                .Connection = c.strcon
                'consulta de la tabla docente
                .CommandText = "DELETE FROM docentre where iddocente = '" & idDocente & "' "
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


    Public Function generarCodigo(ByVal nombre As String)

        Dim valor1 As String
        Dim valor2 As String
        Dim numero As Single

        valor1 = UCase(Left(nombre, 1))
        valor2 = Right(nombre, 2)
        numero = Int(Rnd() * 1000) + 65

        Return valor1 & numero & valor2

    End Function
End Class
