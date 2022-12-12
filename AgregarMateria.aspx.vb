Public Class AgregarMateria
    Inherits System.Web.UI.Page

    Dim materia As New Materia
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'variable para evaluar la respuesta del usuario
        Dim testmsg As Integer

        testmsg = MsgBox("Está seguro que desea guardar registro", 1, "Registro Alumno")
        If testmsg = 1 Then
            'alumno.ideAlumno = TxtId.Text
            materia.nomMateria = txtNombre.Text

            'llamada metodo guardar registro
            materia.guardar()

            'Dejamos los campos vacíos para un nuevo ingreso de datos
            'Puede omitirse ya que el redireccionamiento es automático
            txtNombre.Text = ""


            'Después de guardar volvemos a listado Alumnos
            'Redireccionamos de nuevo a la página listado Alumnos
            Response.Redirect("Materia.aspx")
        Else
            'En el caso seleccione que no quiere agregar registro
            'Campos del Formulario quedan vacíos de nuevo
            txtNombre.Text = ""
        End If

    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Response.Redirect("Materia.aspx")

    End Sub
End Class