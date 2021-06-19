<%@ Page Title="" Language="C#" MasterPageFile="~/Administradores.master" AutoEventWireup="true" CodeBehind="wfrmConsultas.aspx.cs" Inherits="Ejemplo.Web.wfrmConsultas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

    <style type="text/css">
        .auto-style1 {
            width: 273px;
        }
        </style>

</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="MainContent">
    <table class="auto-style10">
        <caption style="font-family: Arial, Helvetica, sans-serif; font-size: large; font-weight: bold; color: #000066">
            <br />
            CONSULTAS<br />
        </caption>
        <tr>
            <td class="auto-style1">
  
              <asp:Label ID="lblConsultas" runat="server" style="font-family: 'Arial Black'" Text="Seleccione Consulta"></asp:Label>

  
                </td>
            <td>
  
                <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                    <asp:ListItem>Paradas del Camionero</asp:ListItem>
                    <asp:ListItem>Paradas del Viaje</asp:ListItem>
                    <asp:ListItem>Viajes Ordenados por Fecha</asp:ListItem>
                </asp:DropDownList>

  
                </td>
         </tr>
        <tr>
            <td class="auto-style1">
  
                &nbsp;</td>
            <td>
  
                &nbsp;</td>
         </tr>
        <tr>
            <td class="auto-style1">
  
              <asp:Label ID="lblCamionero" runat="server" style="font-family: 'Arial Black'" Text="Seleccione Camionero" Visible="False"></asp:Label>

  
                <br />
  
            <asp:ListBox ID="lstCamioneros" runat="server" Width="255px" Height="117px" 
             Font-Size="Smaller" OnSelectedIndexChanged="lstCamioneros_SelectedIndexChanged" Visible="False"></asp:ListBox>
  
  
                </td>
            <td>
  
              <asp:Label ID="lblViaje" runat="server" style="font-family: 'Arial Black'" Text="Seleccione Viaje" Visible="False"></asp:Label>

  
                <br />
  
            <asp:ListBox ID="lstCamioneros0" runat="server" Width="255px" Height="117px" 
             Font-Size="Smaller" OnSelectedIndexChanged="lstViajes_SelectedIndexChanged" Visible="False"></asp:ListBox>
  
                </td>
         </tr>
        </table>
    <table>
        <tr>
            <td>
   
    <asp:ListBox ID="lstConsultas" runat="server" Width="530px" Height="224px" 
                    Font-Size="Smaller" OnSelectedIndexChanged="lstConsultas_SelectedIndexChanged" Visible="False" ></asp:ListBox>
                </td>
        </tr>
        </table>
    <br />
  

    &nbsp;

    &nbsp;&nbsp;
   
    &nbsp;
  
    <asp:Label ID="lblMensajes" style="font-family: 'Arial Black'" runat="server" 
        Width="514px" runat="server" Text="." ForeColor="#CC0000" Visible="False"></asp:Label>
    <br />
    
</asp:Content>
