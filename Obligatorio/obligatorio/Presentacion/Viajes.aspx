<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Viajes.aspx.cs" Inherits="obligatorio.Presentacion.Viajes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Gestión viajes" Font-Size="Larger"></asp:Label>
    <br /> <br />

    <asp:Label ID="Label2" runat="server" Text="Camionero:"></asp:Label>
    <asp:TextBox ID="txtCamionero" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Camión:"></asp:Label>
    <asp:TextBox ID="txtCamion" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Carga:"></asp:Label>
    <asp:TextBox ID="txtCarga" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Kilaje:"></asp:Label>
    <asp:TextBox ID="txtKilaje" runat="server"></asp:TextBox>
    <asp:Label ID="lblMissingKilaje" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Label ID="Label6" runat="server" Text="Origen:"></asp:Label>
    <asp:TextBox ID="txtOrigen" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label7" runat="server" Text="Destino:"></asp:Label>
    <asp:TextBox ID="txtDestino" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label8" runat="server" Text="Fecha de inicio:"></asp:Label>
    <asp:Calendar ID="dtpFechaInicio" runat="server"></asp:Calendar>
    <br />
    <asp:Label ID="Label9" runat="server" Text="Fecha de finalización"></asp:Label>
    <asp:Calendar ID="dtpFechaFin" runat="server"></asp:Calendar>

    <div>
        <br />
        <br />
        <asp:Button ID="btnAlta" Text="Alta" runat="server" OnClick="btnAlta_Click"/>
        <asp:Button ID="btnBaja" Text="Baja" runat="server" OnClick="btnBaja_Click"/>    
        <asp:Button ID="btnModificar" Text="Modificar" runat="server" OnClick="btnModificar_Click"/>
        <asp:Button ID="btnLimpiar" Text="Limpiar" runat="server" OnClick="btnLimpiar_Click"/>
        <br />
        <asp:Label ID="lblDataOutput" runat="server" Text="Label"></asp:Label>
    </div>

</asp:Content>
