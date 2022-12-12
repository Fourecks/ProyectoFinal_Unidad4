Public Class AgregarUsuario
    Inherits System.Web.UI.Page

    Dim usuario As New Usuario

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub TxtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged


    End Sub



    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Response.Redirect("Usuario.aspx")

    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'variable para evaluar la respuesta del usuario
        Dim testmsg As Integer

        testmsg = MsgBox("Está seguro que desea guardar registro", 1, "Registro Usuario")
        If testmsg = 1 Then
            'Usuario.IdUsuario = TxtId.Text
            usuario.nomUsuario = txtNombre.Text
            usuario.clavUsuario = txtClave.Text
            usuario.nivUsuario = ListBox1.Text

            'llamada metodo guardar registro
            usuario.guardar()

            'Dejamos los campos vacíos para un nuevo ingreso de datos
            'Puede omitirse ya que el redireccionamiento es automático
            txtNombre.Text = ""
            txtClave.Text = ""
            ListBox1.Text = ""

            'Después de guardar volvemos a listado Usuarios
            'Redireccionamos de nuevo a la página listado Usuarios
            Response.Redirect("Usuario.aspx")
        Else
            'En el caso seleccione que no quiere agregar registro
            'Campos del Formulario quedan vacíos de nuevo
            txtNombre.Text = ""
            txtClave.Text = ""
            ListBox1.Text = ""
        End If

    End Sub


End Class