<%@ Page Title="" Language="C#" MasterPageFile="~/Administradores.master" AutoEventWireup="true" CodeBehind="wfrmParadasDelViaje.aspx.cs" Inherits="Ejemplo.Web.wfrmParadasDelViaje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

    <style type="text/css">
        .auto-style1 {
            width: 480px;
        }
        </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table class="auto-style10">
    <caption style="font-family: Arial, Helvetica, sans-serif; font-size: large; font-weight: bold; color: #000066">
      <br />
      PARADAS DEL VIAJE
      <br />
    </caption>
    <tr>
      <td class="auto-style1">
        <asp:Label ID="Label1" runat="server" style="font-family: 'Arial Black'" Text="Seleccione el viaje" />
        <br />
        <asp:ListBox ID="lstViajes" runat="server" Width="440px" Height="300px" 
          Font-Size="Smaller" OnSelectedIndexChanged="lstViajes_SelectedIndexChanged" AutoPostBack="True" />
      </td>
      <td class="auto-style1">
        <asp:Label ID="Label2" runat="server" style="font-family: 'Arial Black'" Text="Lista de paradas" />
        <br />
        <asp:ListBox ID="lstParadas" runat="server" Width="440px" Height="142px" 
          Font-Size="Smaller" AutoPostBack="True" OnSelectedIndexChanged="lstParadas_SelectedIndexChanged" />
        <br />
        <asp:Label ID="Label3" runat="server" style="font-family: 'Arial Black'" Text="Comentario" />
        <br />
        <asp:Button ID="btnComentar" runat="server" Text="Guardar Nuevo Comentario"  style="text-align: center" Width="208px" Height="33px" BackColor="#003366" 
                    BorderColor="#CCFFFF" Font-Bold="True" ForeColor="White"  OnClick="btnComentar_Click" />
        <asp:TextBox ID="txtComentario" runat="server" Height="56px" Width="426px" AutoPostBack="True" />
        <br />
      </td>
    </tr>
    <tr>
      <td class="auto-style1" colspan="2">
        <asp:Label ID="lblMensajes" style="font-family: 'Arial Black'"
          runat="server" Width="514px" ForeColor="#CC0000" />
      </td>
    </tr>
  </table>
</asp:Content>
