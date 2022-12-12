Public Class EliminarUsuario
    Inherits System.Web.UI.Page

    'llamada de clase Usuario para usar sus métodos
    Dim usuario As New Usuario

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Comparamos el código pasado como parámetro
        usuario.idUsuario = Request.QueryString("Usuario")

        If Not Me.IsPostBack Then
            'llenado de DataTable con los datos del Usuario
            Dim dt As DataTable = usuario.mostrarRegistro()

            'Mostrar los datos con ayuda de un ciclo for
            For i = 0 To dt.Rows.Count - 1
                txtNombre.Text = dt.Rows(i).Item("nombre")
            Next

        End If

    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        'variable para evaluar la respuesta del Usuario
        Dim testmsg As Integer

        testmsg = MsgBox("Está seguro que desea eliminar registro", 1, "Eliminar Usuario")
        If testmsg = 1 Then

            'llamada metodo eliminar registro
            usuario.eliminar()

            'Después de eliminar volvemos a listado Usuarios
            'Redireccionamos de nuevo a la página listado Usuarios
            Response.Redirect("Usuario.aspx")
        Else
            'Redireccionamos de nuevo a la página listado Usuarios
            'Sin llamar el metodo eliminar
            Response.Redirect("Usuario.aspx")
        End If

    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        'Si cancelamos volvemos a la página listado Usuarios
        Response.Redirect("Usuario.aspx")

    End Sub

End Class