Public Class EliminarDocente
    Inherits System.Web.UI.Page
    'llamada de clase Docente para usar sus métodos
    Dim docente As New Docente
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Comparamos el código pasado como parámetro
        docente.idDocente = Request.QueryString("Docente")

        If Not Me.IsPostBack Then
            'llenado de DataTable con los datos de Docente
            Dim dt As DataTable = docente.mostrarRegistro()

            'Mostrar los datos con ayuda de un ciclo for
            For i = 0 To dt.Rows.Count - 1
                TxtId.Text = dt.Rows(i).Item("iddocente")
                txtNombre.Text = dt.Rows(i).Item("nombredocente")
                TxtApellido.Text = dt.Rows(i).Item("apellidodocente")
                TxtCorreo.Text = dt.Rows(i).Item("correodocente")
                TxtTelefono.Text = dt.Rows(i).Item("telefonodocente")
                TxtCodigo.Text = dt.Rows(i).Item("codigodocente")
            Next

        End If
    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'variable para evaluar la respuesta del usuario
        Dim testmsg As Integer

        testmsg = MsgBox("Está seguro que desea eliminar registro", 1, "Eliminar Docente")
        If testmsg = 1 Then

            'llamada metodo eliminar registro
            docente.eliminar()

            'Después de eliminar volvemos a listado docente
            'Redireccionamos de nuevo a la página listado docente
            Response.Redirect("Docente.aspx")
        Else
            'Redireccionamos de nuevo a la página listado docente
            'Sin llamar el metodo eliminar
            Response.Redirect("Docente.aspx")
        End If
    End Sub
    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        'Si cancelamos volvemos a la página listado docente
        Response.Redirect("Docente.aspx")

    End Sub
End Class
