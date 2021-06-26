<%@ Page
  Title=""
  Language="C#"
  MasterPageFile="~/Administradores.master"
  AutoEventWireup="true"
  CodeBehind="wfrmIngresoViajes.aspx.cs"
  Inherits="Ejemplo.Web.wfrmIngresoViajes"
%>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    label {
      display: inline-block;
      width: 100px;
    }
    input[type: submit] {
      padding: 10px;
    }
    .style1 {
      height: 383px;
      width: 910px;
    }
    .etiqueta {
      font-family: 'Arial Black'
    }
        .auto-style17 {
            width: 227px;
        }
        .auto-style21 {
            width: 227px;
            height: 32px;
        }
        .auto-style23 {
            height: 26px;
            width: 227px;
        }
        .auto-style24 {
            width: 201px;
            height: 32px;
        }
        .auto-style25 {
            height: 26px;
            width: 201px;
        }
        .auto-style26 {
            width: 201px;
        }
        .auto-style27 {
            width: 148px;
            height: 32px;
        }
        .auto-style28 {
            height: 26px;
            width: 148px;
        }
        .auto-style29 {
            width: 148px;
        }
        .auto-style30 {
            width: 171px;
            height: 32px;
        }
        .auto-style31 {
            height: 26px;
            width: 171px;
        }
        .auto-style32 {
            width: 171px;
        }
  </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="MainContent">
    <table class="style1">
    <colgroup>
       <col>
       <col>
    </colgroup>
    <caption style="font-family: Arial, Helvetica, sans-serif; font-size: large; font-weight: bold; color: #000066">
      <br />
      INGRESO DE VIAJES<br />
    </caption>
    <tr>
      <td class="auto-style27">
        <asp:Label runat="server" CssClass="etiqueta" ID="lblIdViaje" Text="Id Viaje" />
      </td>
      <td class="auto-style24">
        <asp:TextBox ID="txtIdViaje" runat="server" TabIndex="1" Enabled="False" Height="22px" Width="203px"></asp:TextBox>
      </td>
      <td class="auto-style30">
        <asp:Label runat="server" CssClass="etiqueta" ID="lblFecIni" Text="Fecha Inicio" />
      </td>
      <td class="auto-style21">
        <asp:TextBox ID="txtFecIni" runat="server" Height="22px" Width="203px" TabIndex="1"></asp:TextBox>
      </td>
    </tr>
    <tr>
      <td class="auto-style28">
        <asp:Label runat="server" CssClass="etiqueta" ID="lblCarga" Text="Tipo de Carga" />
      </td>
      <td class="auto-style25">
        <asp:DropDownList ID="ddlCarga" runat="server" Height="22px" Width="210px">
          <asp:ListItem>Grano</asp:ListItem>
          <asp:ListItem>Contenedor</asp:ListItem>
          <asp:ListItem>Ganado</asp:ListItem>
        </asp:DropDownList>
      </td>
      <td class="auto-style31">
        <asp:Label runat="server" CssClass="etiqueta" ID="lblFecFinal" Text="Fecha Final" />
      </td>
      <td class="auto-style23">
        <asp:TextBox ID="txtFecFin" runat="server" Height="22px" Width="203px" TabIndex="1"></asp:TextBox>
      </td>
    </tr>
    <tr>
      <td class="auto-style28">
        <asp:Label runat="server" CssClass="etiqueta" ID="lblCamion" Text="Camión" />
      </td>
      <td class="auto-style25">
        <asp:DropDownList ID="lstCamion" runat="server" Height="22px" Width="210px" />
      </td>
      <td class="auto-style31">
        <asp:Label runat="server" CssClass="etiqueta" ID="lblCiuIni" Text="Ciudad Inicio" />
      </td>
      <td class="auto-style23">
        <asp:DropDownList ID="lstCiudIni" runat="server" Height="22px" Width="210px" />
      </td>
    </tr>
    <tr>
      <td class="auto-style29">
        <asp:Label runat="server" CssClass="etiqueta" ID="lblCamionero" Text="Camionero" />
      </td>
      <td class="auto-style26">
        <asp:DropDownList ID="lstCamionero" runat="server" Height="22px" Width="210px" />
      </td>
      <td class="auto-style32">
        <asp:Label runat="server" CssClass="etiqueta" ID="lblCiufin" Text="Ciudad Final" />
      </td>
      <td class="auto-style17">
        <asp:DropDownList ID="lstCiudFin" runat="server" Height="22px" Width="210px"/>
      </td>
    </tr>
    <tr>
      <td colspan="4">















        <asp:ListBox ID="lstViajes" runat="server" Height="202px"
          Font-Size="Small" Width="98%" AutoPostBack="True" OnSelectedIndexChanged="lstViajes_SelectedIndexChanged"></asp:ListBox>
      </td>
    </tr>
  </table>
  <br />


  <asp:Button ID="btnAlta" runat="server" Style="text-align: center"
    Width="115px" Height="45px" BackColor="#003366"
    BorderColor="#CCFFFF" Font-Bold="True" ForeColor="White"
    Text="ALTA" OnClick="btnAlta_Click" TabIndex="8" />

  &nbsp;

    <asp:Button ID="btnBaja" runat="server" Style="text-align: center"
      Width="115px" Height="45px" BackColor="#003366"
      BorderColor="#CCFFFF" Font-Bold="True" ForeColor="White"
      Text="BAJA" OnClick="btnBaja_Click" TabIndex="9" />

  &nbsp;&nbsp;
   
    <asp:Button ID="btnLimpiar" runat="server" Style="text-align: center" Width="115px" Height="45px" BackColor="#003366"
      BorderColor="#CCFFFF" Font-Bold="True" ForeColor="White" Text="LIMPIAR"
      OnClick="btnLimpiar_Click" />

  &nbsp;&nbsp;&nbsp;
  
    <asp:Label ID="lblMensajes" Style="font-family: 'Arial Black'" runat="server"
      Width="514px" ForeColor="#CC0000"></asp:Label>
  <br />

</asp:Content>
