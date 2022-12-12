Public Class EditarMateria
    Inherits System.Web.UI.Page

    'llamamos la clase Materia, POO
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



    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        'Si cancelamos, volvemos a la página listado Materias
        Response.Redirect("Materia.aspx")

    End Sub

    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        'variable para evaluar la respuesta del usuario
        Dim testmsg As Integer

        testmsg = MsgBox("Está seguro que desea Actualizar registro", 1, "Actualizar Materia")
        If testmsg = 1 Then
            'Materia.nomMateria = TxtId.Text
            materia.nomMateria = txtNombre.Text

            'llamada metodo guardar registro
            materia.editar()

            'Dejamos los campos vacíos para un nuevo ingreso de datos
            'Puede omitirse ya que el redireccionamiento es automático
            txtNombre.Text = ""

            'Redireccionamos de nuevo a la página listado Materias
            Response.Redirect("Materia.aspx")
        Else
            'Dejamos los campos vacíos para un nuevo ingreso de datos
            'Puede omitirse ya que el redireccionamiento es automático
            txtNombre.Text = ""
        End If
    End Sub
End Class