<%@ Page Title="" Language="C#" MasterPageFile="~/Camioneros.master" AutoEventWireup="true" CodeBehind="wfrmModificacionesCamionero.aspx.cs" Inherits="Ejemplo.Web.wfrmModificacionesCamionero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
        }
        .auto-style2 {
            width: 273px;
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
        }
        </style>

</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="MainContent">
    <table class="auto-style10">
        <caption style="font-family: Arial, Helvetica, sans-serif; font-size: large; font-weight: bold; color: #000066">
            <br />
            GESTIÓN DE CAMIONEROS<br />
            <br />
        </caption>
        <tr>
            <td class="auto-style2">
  
              <asp:Label ID="lblCamioneroNombre" runat="server" style="font-family: 'Arial Black'" Text="Camionero"></asp:Label>

  
                </td>
            <td class="auto-style3">
  
                <asp:TextBox ID="txtCamionero" runat="server" Width="221px" Enabled="False" Height="26px" OnTextChanged="txtCamionero_TextChanged"></asp:TextBox>
            </td>
         </tr>
        <tr>
            <td class="auto-style1">
  
              <asp:Label ID="lblViajeID" runat="server" style="font-family: 'Arial Black'" Text="Viaje"></asp:Label>

  
                </td>
            <td>
  
                <asp:TextBox ID="txtViaje" runat="server" Width="220px" Enabled="False" Height="26px" OnTextChanged="txtKilaje_TextChanged"></asp:TextBox>
                <asp:Label ID="lblIdViaje" runat="server" Visible="false" />
            </td>
         </tr>
        <tr>
            <td class="auto-style1">
  
              <asp:Label ID="lblEstado" runat="server" style="font-family: 'Arial Black'" Text="Seleccione Estado"></asp:Label>

  
                <br />
  
  
                </td>
            <td>
  
                <asp:DropDownList ID="ddlEstado" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Height="28px" Width="228px">
                    <asp:ListItem>En curso</asp:ListItem>
                    <asp:ListItem>Parado</asp:ListItem>
                    <asp:ListItem>Finalizado</asp:ListItem>
                </asp:DropDownList>

  
                <br />
  
                </td>
         </tr>
        <tr>
            <td class="auto-style1">
  
              <asp:Label ID="lblKilaje" runat="server" style="font-family: 'Arial Black'" Text="Kilaje"></asp:Label>

  
                </td>
            <td>
  
                <asp:TextBox ID="txtKilaje" runat="server" Width="220px" Height="26px" OnTextChanged="txtCamionero1_TextChanged"></asp:TextBox>
            </td>
         </tr>
        <tr>
            <td class="auto-style1" colspan="2">
  
              <asp:Label ID="lblcomentario" runat="server" style="font-family: 'Arial Black'" Text="Comentario"></asp:Label>

  
                <br />
                <asp:TextBox ID="txtComentario" runat="server" Height="106px" TextMode="MultiLine" Width="496px"></asp:TextBox>
                <br />

  
                </td>
         </tr>
        </table>
    <table>
        <tr>
            <td>
   
                <asp:Button ID="btnModificarViaje" runat="server" Text="GUARDAR MODIFICACIONES" onclick="btnModificarViaje_Click" 
         style="text-align: center" Width="250px" Height="45px" BackColor="#003366" 
                    BorderColor="#CCFFFF" Font-Bold="True" ForeColor="White" 
        TabIndex="8" />




        </tr>
        </table>
    <br />
  

    &nbsp;

    &nbsp;&nbsp;
   
    &nbsp;
  
    <asp:Label ID="lblMensajes" style="font-family: 'Arial Black'" runat="server" 
        Width="514px" runat="server" ForeColor="#CC0000"></asp:Label>
    <br />
    
</asp:Content>
