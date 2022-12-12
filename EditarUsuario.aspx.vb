Public Class EditarUsuario
    Inherits System.Web.UI.Page

    'llamamos la clase Usuario, POO
    Dim usuario As New Usuario

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Comparamos el código pasado como parámetro
        usuario.idUsuario = Request.QueryString("Usuario")

        If Not Me.IsPostBack Then
            'llenado de DataTable con los datos de Usuario
            Dim dt As DataTable = usuario.mostrarRegistro()

            'Mostrar los datos con ayuda de un ciclo for
            For i = 0 To dt.Rows.Count - 1
                txtNombre.Text = dt.Rows(i).Item("nombre")
            Next
        End If

    End Sub

    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        'variable para evaluar la respuesta del usuario
        Dim testmsg As Integer

        testmsg = MsgBox("Está seguro que desea Actualizar registro", 1, "Actualizar Usuario")
        If testmsg = 1 Then
            'Usuario.IdeUsuario = TxtId.Text
            usuario.nomUsuario = txtNombre.Text
            usuario.clavUsuario = txtClave.Text

            'llamada metodo guardar registro
            usuario.editar()

            'Dejamos los campos vacíos para un nuevo ingreso de datos
            'Puede omitirse ya que el redireccionamiento es automático
            txtNombre.Text = ""
            txtClave.Text = ""

            'Redireccionamos de nuevo a la página listado Usuarios
            Response.Redirect("Usuario.aspx")
        Else
            'Dejamos los campos vacíos para un nuevo ingreso de datos
            'Puede omitirse ya que el redireccionamiento es automático
            txtNombre.Text = ""
            txtClave.Text = ""
        End If

    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        'Si cancelamos, volvemos a la página listado Usuarios
        Response.Redirect("Usuario.aspx")

    End Sub
End Class