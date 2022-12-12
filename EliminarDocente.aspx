<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="EliminarDocente.aspx.vb" Inherits="ProyectoFinal_Unidad4.EliminarDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  
     <p>
        <br />
    </p>


    <p class="text-center" style="font-size: large">
        <strong>ELIMINAR DOCENTE </strong></p>

    <table align="center" style="width: 60%; border: 2px solid #0066FF; background-color: #99CCFF">
        <tr>
            <td class="text-right" style="width: 114px">&nbsp;</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">Id</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">
                <asp:TextBox ID="TxtId" runat="server" Width="122px" Enabled="False" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">&nbsp;</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">Nombre</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">
                <asp:TextBox ID="txtNombre" runat="server" Width="258px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">&nbsp;</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">Apellido</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">
                <asp:TextBox ID="TxtApellido" runat="server" Width="258px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">&nbsp;</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">Correo</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">
                <asp:TextBox ID="TxtCorreo" runat="server" Width="258px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">&nbsp;</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">Teléfono</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">
                <asp:TextBox ID="TxtTelefono" runat="server" Width="258px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">&nbsp;</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">Código</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">
                <asp:TextBox ID="TxtCodigo" runat="server" Width="122px" Enabled="False"></asp:TextBox>
&nbsp;
                </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">&nbsp;</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">&nbsp;</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">&nbsp;</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">
                &nbsp;</td>
        </tr>
    </table>
    <p>
    </p>
    <p>
    </p>


  
</asp:Content>
