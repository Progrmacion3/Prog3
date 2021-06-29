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
      .auto-style2 {
        }
        .auto-style3 {
        }
        .auto-style4 {
            width: 196px;
        }
  </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="MainContent">
    <table style="width: 920px">
    <caption class="titulo">
      <br />
      VIAJES DEL CAMIONERO
      <br />
    </caption>
    <tr>
      <td colspan="3">
        <asp:Label ID="lblCamionero" runat="server" style="font-family: 'Arial Black'" Text="Lista de camioneros" />
      </td>
    </tr>
    <tr>
      <td class="auto-style4" rowspan="3">
        <asp:ListBox ID="lstCamioneros" runat="server" Width="574px" Height="145px" Font-Size="Small"
          OnSelectedIndexChanged="lstCamioneros_SelectedIndexChanged" AutoPostBack="True" />
      </td>
      <td class="auto-style2" colspan="2">
        <asp:Label ID="Label1" runat="server" Text="Filtrar por cédula:       " />
      </td>
    </tr>
    <tr>
      <td class="auto-style2" colspan="2">
        <asp:TextBox ID="txtCedula" runat="server" Width="145px" Height="30px" />
      </td>
    </tr>
    <tr>
      <td class="auto-style2" colspan="2">
        <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" Style="text-align: center"
    Width="150px" Height="32px" BackColor="#003366"
    BorderColor="#CCFFFF" Font-Bold="True" ForeColor="White"  OnClick="btnFiltrar_Click" />
      </td>
    </tr>
    <tr>
      <td class="auto-style3" colspan="2">
        <asp:Label ID="lblViaje" runat="server" style="font-family: 'Arial Black'" Text="Lista de viajes" />
      </td>
      <td>
          &nbsp;</td>
    </tr>
    <tr>
      <td class="auto-style3" colspan="3">
        <asp:ListBox ID="lstViajes" runat="server" Width="893px" Height="190px" Font-Size="Small" Font-Overline="True" Font-Underline="False" style="margin-left: 0px" />
      </td>
    </tr>
    <tr>
      <td class="auto-style1" colspan="3">
        <asp:Label ID="lblMensajes" style="font-family: 'Arial Black'"
          Width="514px" runat="server" ForeColor="#CC0000" />
      </td>
    </tr>
  </table>
</asp:Content>
