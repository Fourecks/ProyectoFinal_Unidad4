Public Class EliminarAlumno
    Inherits System.Web.UI.Page
    'llamada de clase Alumno para usar sus métodos
    Dim alumno As New Alumno
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Comparamos el código pasado como parámetro
        alumno.idAlumno = Request.QueryString("Alumno")

        If Not Me.IsPostBack Then
            'llenado de DataTable con los datos de Alumno
            Dim dt As DataTable = alumno.mostrarRegistro()

            'Mostrar los datos con ayuda de un ciclo for
            For i = 0 To dt.Rows.Count - 1
                TxtId.Text = dt.Rows(i).Item("idalumno")
                txtNombre.Text = dt.Rows(i).Item("nombre")
                TxtApellido.Text = dt.Rows(i).Item("apellido")
                TxtCorreo.Text = dt.Rows(i).Item("correo")
                TxtTelefono.Text = dt.Rows(i).Item("telefono")
                TxtCodigo.Text = dt.Rows(i).Item("codigo")
            Next

        End If
    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        'variable para evaluar la respuesta del usuario
        Dim testmsg As Integer

        testmsg = MsgBox("Está seguro que desea eliminar registro", 1, "Eliminar Alumno")
        If testmsg = 1 Then

            'llamada metodo eliminar registro
            alumno.eliminar()

            'Después de eliminar volvemos a listado Alumnos
            'Redireccionamos de nuevo a la página listado Alumnos
            Response.Redirect("Alumno.aspx")
        Else
            'Redireccionamos de nuevo a la página listado Alumnos
            'Sin llamar el metodo eliminar
            Response.Redirect("Alumno.aspx")
        End If
    End Sub
    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        'Si cancelamos volvemos a la página listado Alumnos
        Response.Redirect("Alumno.aspx")

    End Sub
End Class
