Public Class EliminarMateria
    Inherits System.Web.UI.Page

    'llamada de clase Materia para usar sus métodos
    Dim materia As New Materia

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Comparamos el código pasado como parámetro
        materia.idMateria = Request.QueryString("Materia")

        If Not Me.IsPostBack Then
            'llenado de DataTable con los datos de Materia
            Dim dt As DataTable = materia.mostrarRegistro()

            'Mostrar los datos con ayuda de un ciclo for
            For i = 0 To dt.Rows.Count - 1
                txtNombre.Text = dt.Rows(i).Item("nombre")
            Next

        End If
    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        'variable para evaluar la respuesta del Usuario
        Dim testmsg As Integer

        testmsg = MsgBox("Está seguro que desea eliminar registro", 1, "Eliminar Materia")
        If testmsg = 1 Then

            'llamada metodo eliminar registro
            materia.eliminar()

            'Después de eliminar volvemos a listado Materias
            'Redireccionamos de nuevo a la página listado Materias
            Response.Redirect("Materia.aspx")
        Else
            'Redireccionamos de nuevo a la página listado Materias
            'Sin llamar el metodo eliminar
            Response.Redirect("Materia.aspx")
        End If
    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        'Si cancelamos volvemos a la página listado Materias
        Response.Redirect("Materia.aspx")

    End Sub
End Class