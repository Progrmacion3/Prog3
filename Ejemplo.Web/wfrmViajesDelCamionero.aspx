<%@ Page Title="" Language="C#" MasterPageFile="~/Administradores.master" AutoEventWireup="true" CodeBehind="wfrmViajesDelCamionero.aspx.cs" Inherits="Ejemplo.Web.wfrmViajesDelCamionero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
  <style type="text/css">
    .titulo {
      font-family: Arial, Helvetica, sans-serif;
      font-size: large;
      font-weight: bold;
      color: #000066
    }
    .auto-style1 {
      width: 480px;
    }
  </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="MainContent">
  <table>
    <caption class="titulo">
      <br />
      VIAJES DEL CAMIONERO
      <br />
    </caption>
    <tr>
      <td class="auto-style1">
        <asp:Label ID="lblCamionero" runat="server" style="font-family: 'Arial Black'" Text="Lista de camioneros" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Filtrar por cédula:" />
        <asp:TextBox ID="txtCedula" runat="server" />
        <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" />
        <br />
        <asp:ListBox ID="lstCamioneros" runat="server" Width="440px" Height="300px" Font-Size="Small"
          OnSelectedIndexChanged="lstCamioneros_SelectedIndexChanged" AutoPostBack="True" />
      </td>
      <td>
        <asp:Label ID="lblViaje" runat="server" style="font-family: 'Arial Black'" Text="Lista de viajes" />
        <br />
        <asp:ListBox ID="lstViajes" runat="server" Width="440px" Height="315px" Font-Size="Smaller" />
      </td>
    </tr>
    <tr>
      <td class="auto-style1" colspan="2">
        <asp:Label ID="lblMensajes" style="font-family: 'Arial Black'"
          Width="514px" runat="server" ForeColor="#CC0000" />
      </td>
    </tr>
  </table>
</asp:Content>
