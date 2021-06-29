<%@ Page Title="Sección roturas" Language="C#" AutoEventWireup="true" CodeBehind="Roturas.aspx.cs" Inherits="Ejemplo.Web.Secciones.Camionero.Roturas" MasterPageFile="~/Site.master"%>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="MenuCamionero" runat="server" ContentPlaceHolderID="MainContent">
    <h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Seccion de Roturas</h2>
    <p>
        <asp:Label ID="Label1" runat="server" Text="IdViaje"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtIdViaje" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" Width="199px" />
    </p>
    <p>
        <asp:TextBox ID="txtResultado" runat="server" Height="156px" Rows="5" Width="191px"></asp:TextBox>
    </p>
    <p>&nbsp;</p>
</asp:Content>
