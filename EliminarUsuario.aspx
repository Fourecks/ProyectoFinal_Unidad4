<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="EliminarUsuario.aspx.vb" Inherits="ProyectoFinal_Unidad4.EliminarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <p class="text-center" style="font-size: large">
        <strong>ELIMINAR USUARIO</strong></p>
    <table align="center" style="width: 60%; border: 2px solid #0066FF; background-color: #99CCFF">
        <tr>
            <td class="text-right" style="width: 114px">&nbsp;</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">Usuario</td>
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
            <td style="width: 561px">&nbsp;</td>
        </tr>
    </table>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
