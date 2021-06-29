<%@ Page Title="Sección de Administradores" Language="C#" AutoEventWireup="true" CodeBehind="formAdmin.aspx.cs" Inherits="Ejemplo.Web.Secciones.Admin.formAdmin" MasterPageFile="~/Site.master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="MenuAdmin" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Seccion de Administradores</h2>
    <hr />
    <div id="Salir" class="title">
        <h3>¿Seguro que desea salir?</h3>
        <asp:Button Text="Aceptar" runat="server" OnClick="btnSalir_Click" CssClass="salir"/>
    </div>
</asp:Content>