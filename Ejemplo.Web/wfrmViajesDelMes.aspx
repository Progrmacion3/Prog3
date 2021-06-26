<%@ Page Title="" Language="C#" MasterPageFile="~/Administradores.master" AutoEventWireup="true" CodeBehind="wfrmViajesDelMes.aspx.cs" Inherits="Ejemplo.Web.wfrmViajesDelMes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
  <style type="text/css">
      .auto-style5 {
          width: 291px;
          height: 177px;
      }
      .auto-style6 {
          height: 39px;
      }
      .auto-style9 {
          width: 873px;
      }
      .auto-style10 {
          width: 290px;
          height: 177px;
      }
  </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <table class="auto-style9">
    <caption style="font-family: Arial, Helvetica, sans-serif; font-size: large; font-weight: bold; color: #000066">
      <br />
      VIAJES ORDENADOS DEL MES ACTUAL
      <br />
    </caption>
    <tr>
      <td colspan="3">
        <asp:ListBox ID="lstViajes" runat="server" Height="136px" Width="867px" OnSelectedIndexChanged="lstViajes_SelectedIndexChanged" AutoPostBack="True" ToolTip="Seleccione viaje a consultar" />
      </td>
    </tr>
    <tr>
      <td class="auto-style10" style="vertical-align: top; color: #800080; font-weight: bold; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; background-color: #FFFFFF;">
          &nbsp;</td>
      <td class="auto-style10" style="vertical-align: top; color: #800080; font-weight: bold; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; background-color: #D9ECFF;">
        <asp:Label ID="lblDetalle" runat="server" style="font-family: 'Arial Black'" />
      </td>
      <td class="auto-style5" style="vertical-align: top; color: #800080; font-weight: bold; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; background-color: #FFFFFF;">
          &nbsp;</td>
    </tr>
    <tr>
      <td class="auto-style6" colspan="3" style="vertical-align: top">
        <asp:Label ID="lblMensajes" style="font-family: 'Arial Black'" 
          Width="514px" ForeColor="#CC0000" runat="server" />
      </td>
    </tr>
  </table>
</asp:Content>
