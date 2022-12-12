Public Class EditarDocente
    Inherits System.Web.UI.Page

    'llamamos la clase Docente, POO
    Dim docente As New Docente

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Comparamos el código pasado como parámetro
        docente.idDocente = Request.QueryString("Docente")

        If Not Me.IsPostBack Then
            'llenado de DataTable con los datos de docente
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


    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        'variable para evaluar la respuesta del usuario
        Dim testmsg As Integer

        testmsg = MsgBox("Está seguro que desea Actualizar registro", 1, "Actualizar Docente")
        If testmsg = 1 Then
            'docente.iddocente = TxtId.Text
            docente.nomDocente = txtNombre.Text
            docente.apeDocente = TxtApellido.Text
            docente.mailDocente = TxtCorreo.Text
            docente.telDocente = TxtTelefono.Text
            docente.codDocente = TxtCodigo.Text

            'llamada metodo guardar registro
            docente.editar()

            'Dejamos los campos vacíos para un nuevo ingreso de datos
            'Puede omitirse ya que el redireccionamiento es automático
            txtNombre.Text = ""
            TxtApellido.Text = ""
            TxtCorreo.Text = ""
            TxtTelefono.Text = ""
            TxtCodigo.Text = ""

            'Redireccionamos de nuevo a la página listado docentes
            Response.Redirect("Docente.aspx")
        Else
            'Dejamos los campos vacíos para un nuevo ingreso de datos
            'Puede omitirse ya que el redireccionamiento es automático
            txtNombre.Text = ""
            TxtApellido.Text = ""
            TxtCorreo.Text = ""
            TxtTelefono.Text = ""
            TxtCodigo.Text = ""
        End If

    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        'Si cancelamos, volvemos a la página listado Docentes
        Response.Redirect("Docente.aspx")

    End Sub

End Class
