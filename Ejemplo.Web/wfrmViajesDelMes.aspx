<%@ Page Title="" Language="C#" MasterPageFile="~/Administradores.master" AutoEventWireup="true" CodeBehind="wfrmViajesDelMes.aspx.cs" Inherits="Ejemplo.Web.wfrmViajesDelMes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
  <style type="text/css">
    .auto-style1 {
      width: 273px;
    }
  </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <table class="auto-style10">
    <caption style="font-family: Arial, Helvetica, sans-serif; font-size: large; font-weight: bold; color: #000066">
      <br />
      VIAJES ORDENADOS DEL MES ACTUAL
      <br />
    </caption>
    <tr>
      <td class="auto-style1">
        <asp:ListBox ID="lstViajes" runat="server" Height="306px" Width="512px" OnSelectedIndexChanged="lstViajes_SelectedIndexChanged" />
      </td>
      <td class="auto-style1">
        <asp:Label ID="lblDetalle" runat="server" />
      </td>
    </tr>
    <tr>
      <td class="auto-style1" colspan="2">
        <asp:Label ID="lblMensajes" style="font-family: 'Arial Black'" 
          Width="514px" ForeColor="#CC0000" runat="server" />
      </td>
    </tr>
  </table>
</asp:Content>
