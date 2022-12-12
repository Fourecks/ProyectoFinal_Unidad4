Public Class AgregarDocente
    Inherits System.Web.UI.Page

    'llamada de clase docente para usar sus métodos
    Dim docente As New Docente

    Protected Sub btnGenerarCodigo_Click(sender As Object, e As EventArgs) Handles btnGenerarCodigo.Click

        If txtNombre.Text = "" Then
            MsgBox("Debe agregar un nombre")

        Else
            TxtCodigo.Text = docente.generarCodigo(txtNombre.Text)
        End If

    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'variable para evaluar la respuesta del usuario
        Dim testmsg As Integer

        testmsg = MsgBox("Está seguro que desea guardar registro", 1, "Registro Docente")
        If testmsg = 1 Then
            'docente.iddocdente = TxtId.Text
            docente.nomDocente = txtNombre.Text
            docente.apeDocente = TxtApellido.Text
            docente.mailDocente = TxtCorreo.Text
            docente.telDocente = TxtTelefono.Text
            docente.codDocente = TxtCodigo.Text

            'llamada metodo guardar registro
            docente.guardar()

            'Dejamos los campos vacíos para un nuevo ingreso de datos
            'Puede omitirse ya que el redireccionamiento es automático
            txtNombre.Text = ""
            TxtApellido.Text = ""
            TxtCorreo.Text = ""
            TxtTelefono.Text = ""
            TxtCodigo.Text = ""

            'Después de guardar volvemos a listado Alumnos
            'Redireccionamos de nuevo a la página listado Alumnos
            Response.Redirect("docente.aspx")
        Else
            'En el caso seleccione que no quiere agregar registro
            'Campos del Formulario quedan vacíos de nuevo
            txtNombre.Text = ""
            TxtApellido.Text = ""
            TxtCorreo.Text = ""
            TxtTelefono.Text = ""
            TxtCodigo.Text = ""
        End If

    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        'Si damos clic en cancelar volvemos a listado docente
        Response.Redirect("Docente.aspx")

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class
