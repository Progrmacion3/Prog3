<%@ Page Title="Sección de Camionero" Language="C#" AutoEventWireup="true" CodeBehind="formCamionero.aspx.cs" Inherits="Ejemplo.Web.Secciones.Camionero.formCamionero" MasterPageFile="~/Site.master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="MenuCamionero" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Seccion de Camionero</h2>
    <hr/>
    <div id="Salir" class="title">
        <h3>¿Seguro que desea salir?</h3>
        <asp:Button Text="Aceptar" runat="server" OnClick="btnSalir_Click" CssClass="salir"/>
    </div>
</asp:Content>