Imports System.Data
Public Class Alumno1
    Inherits System.Web.UI.Page
    Dim alumno As New Alumno
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            'llenar datable con la base de datos.
            Dim dt As DataTable = alumno.listarRegistros()

            'construyendo HTML string.
            Dim html As New StringBuilder()

            'inicia creacion de tabla.
            html.Append("<table class='table table-striped'>")

            'Agregando encabezado a tabla
            html.Append("<thead>")
            html.Append("<tr>")
            html.Append("<th>Id</th>")
            html.Append("<th>Nombre</th>")
            html.Append("<th>Apellido</th>")
            html.Append("<th>Correo</th>")
            html.Append("<th>Telefono</th>")
            html.Append("<th>Código</th>")
            html.Append("<th cols=3>Acciones</th>")
            html.Append("</tr>")
            html.Append("</thead>")

            html.Append("<tbody>")


            'Mostrar datos en filas
            For i = 0 To dt.Rows.Count - 1
                Dim codigo As Integer = dt.Rows(i).Item("idalumno")
                html.Append("<tr>")
                html.Append("<td>")
                html.Append(dt.Rows(i).Item("idalumno"))
                html.Append("</td><td>")
                html.Append(dt.Rows(i).Item("nombre"))
                html.Append("</td><td>")
                html.Append(dt.Rows(i).Item("apellido"))
                html.Append("</td>")
                html.Append("<td>")
                html.Append(dt.Rows(i).Item("correo"))
                html.Append("</td>")
                html.Append("<td>")
                html.Append(dt.Rows(i).Item("telefono"))
                html.Append("</td>")
                html.Append("<td>")
                html.Append(dt.Rows(i).Item("codigo"))
                html.Append("</td>")

                'Columnas para Agregar, Editar,Eliminar
                html.Append("<td>")
                html.Append("<a href = 'EditarAlumno.aspx?Alumno=" & codigo & "' dt.Rows(i).Item('codigo') >Editar</a>")
                html.Append("</td>")
                html.Append("<td>")
                html.Append("<a href = 'EliminarAlumno.aspx?Alumno=" & codigo & "' dt.Rows(i).Item('codigo') >Eliminar</a>")
                html.Append("</td>")

                html.Append("</tr>")

            Next

            html.Append("</tbody>")
            'finaliza tabla
            html.Append("</table>")

            'agregar html placeholder1
            estudiante.Controls.Add(New Literal() With {.Text = html.ToString()})

        End If
    End Sub

End Class
