<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="AgregarUsuario.aspx.vb" Inherits="ProyectoFinal_Unidad4.AgregarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
    <p class="text-center" style="font-size: large">
        <strong>AGREGAR USUARIO</strong></p>
    <table align="center" style="width: 60%; border: 2px solid #0066FF; background-color: #99CCFF">
        <tr>
            <td class="text-right" style="width: 114px">&nbsp;</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-left" style="width: 114px">Nombre</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">
                <asp:TextBox ID="txtNombre" runat="server" Width="258px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">&nbsp;</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Ingrese nombre de usuario" ControlToValidate="txtNombre"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="text-left" style="width: 114px">Clave</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">
                <asp:TextBox ID="txtClave" runat="server" TextMode="Password" Width="258px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">&nbsp;</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Ingrese la clave de usuario" ControlToValidate="Txtclave"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="text-left" style="width: 114px">Nivel</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">
                <asp:ListBox ID="ListBox1" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                </asp:ListBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">&nbsp;</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Elija el nivel del usuario" ControlToValidate="ListBox1"></asp:RequiredFieldValidator>
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
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" />
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
</asp:Content>
