<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="EditarUsuario.aspx.vb" Inherits="ProyectoFinal_Unidad4.EditarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <p class="text-center" style="font-size: large">
        <strong>EDITAR DATOS DE USUARIO</strong></p>
    <table align="center" style="width: 60%; border: 2px solid #0066FF; background-color: #99CCFF">
        <tr>
            <td style="width: 561px">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">Nombre</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">
                <asp:TextBox ID="txtNombre" runat="server" Width="258px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px; height: 20px;"></td>
            <td style="width: 33px; height: 20px;"></td>
            <td style="width: 561px; height: 20px;">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombre" ErrorMessage="Ingrese nombre de usuario"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">Clave</td>
            <td style="width: 33px; height: 20px;"></td>
            <td style="width: 561px; height: 20px;">
                <asp:TextBox ID="txtNombre0" runat="server" Width="258px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px; height: 20px;"></td>
            <td style="width: 33px; height: 20px;"></td>
            <td style="width: 561px; height: 20px;">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNombre" ErrorMessage="Ingrese la clave de usuario"></asp:RequiredFieldValidator>
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
                <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" />
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px; height: 20px;"></td>
            <td style="width: 33px; height: 20px;"></td>
            <td style="width: 561px; height: 20px;"></td>
        </tr>
    </table>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
