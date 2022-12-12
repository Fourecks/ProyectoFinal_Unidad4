Public Class Usuario1
    Inherits System.Web.UI.Page

    Dim usuario As New Usuario

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Me.IsPostBack Then

            ''llenado de DataTable para mostrar listado de Usuarios
            Dim dt As DataTable = usuario.listarRegistros()

            'Crear variable String para html
            Dim html As New StringBuilder()

            'Enlace para agregar nuevo Usuario

            '<a href = AgregarUsuario.aspx > Agregar</a>

            'Creando HTML para mostrar en forma tabla
            html.Append("<thead>")
            html.Append("<table class = 'table table-striped'>")

            'Encabezados de la tabla
            html.Append("<thead>")
            html.Append("<tr>")
            html.Append("<th>Usuario</th>")
            html.Append("<th>Clave</th>")
            html.Append("<th>Nivel</th>")
            html.Append("<th cols=3>Acciones</th>")
            html.Append("</tr>")
            html.Append("</thead>")

            html.Append("<tbody>")

            'Mostrar los datos en filas, segun cantidad de registros
            'en la tabla
            For i = 0 To dt.Rows.Count - 1

                Dim clave As Integer = dt.Rows(i).Item("idusuario")

                'Creamos una fila
                html.Append("<tr>")

                'Creamos las columnas y mostramos campos de tabla
                'Item recibe nombre de las columnas
                html.Append("<td>")
                html.Append(dt.Rows(i).Item("idusuario"))
                html.Append("</td>")
                html.Append("<td>")
                html.Append(dt.Rows(i).Item("nombre"))
                html.Append("</td>")

                'Columnas para Agregar, Editar,Eliminar
                html.Append("<td>")
                html.Append("<a href = 'EditarUsuario.aspx?Usuario=" & clave & "' dt.Rows(i).Item('clave') >Editar</a>")
                html.Append("</td>")
                html.Append("<td>")
                html.Append("<a href = 'EliminarUsuario.aspx?Usuario=" & clave & "' dt.Rows(i).Item('clave') >Eliminar</a>")
                html.Append("</td>")

                html.Append("</tr>")

            Next

            html.Append("<tbody>")

            'Finaliza la tabla
            html.Append("</table>")

            'Agregamos el código html en el contenedor placeholder
            usuarios.Controls.Add(New Literal() With {
                .Text = html.ToString()
            })


        End If

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Response.Redirect("AgregarUsuario.aspx")

    End Sub

End Class