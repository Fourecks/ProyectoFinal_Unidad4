<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Usuario.aspx.vb" Inherits="ProyectoFinal_Unidad4.Usuario1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
</p>
<p class="text-center">
    <strong>Listado de Usuarios</strong></p>
<p class="text-center">
        &nbsp;</p>
<p class="text-left">
    <asp:Button ID="Button1" runat="server" Text="Agregar" Width="123px" />
</p>
<p>
    <asp:placeholder id="usuarios" runat="server" />
</p>
</asp:Content>
