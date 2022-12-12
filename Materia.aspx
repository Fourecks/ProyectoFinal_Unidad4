<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Materia.aspx.vb" Inherits="ProyectoFinal_Unidad4.Materia1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        <br />
    </p>
    <p class="text-center">
        <strong>Listado de Materias</strong></p>
    <p class="text-center">
        &nbsp;</p>
    <p class="text-left">
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" Width="123px" />
    </p>
    <p>

    <asp:placeholder id="materias" runat="server" />
    </p>
    </asp:Content>
