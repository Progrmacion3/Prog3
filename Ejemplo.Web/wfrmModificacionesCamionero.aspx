<%@ Page Title="" Language="C#" MasterPageFile="~/Camioneros.master" AutoEventWireup="true" CodeBehind="wfrmModificacionesCamionero.aspx.cs" Inherits="Ejemplo.Web.wfrmModificacionesCamionero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {            height: 130px;
        }
        .auto-style2 {
            width: 273px;
            height: 38px;
        }
        .auto-style5 {
            height: 286px;
        }
        .auto-style7 {
            height: 38px;
        }
        .auto-style8 {
            width: 405px;
            height: 38px;
        }
        .auto-style9 {
            width: 405px;
            height: 106px;
        }
        </style>

</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="MainContent">
    <table class="auto-style5">
        <caption style="font-family: Arial, Helvetica, sans-serif; font-size: large; font-weight: bold; color: #000066">
            <br />
            GESTIÓN DE CAMIONEROS<br />
            <br />
        </caption>
        <tr>
            <td class="auto-style2">
  
              <asp:Label ID="lblCamioneroNombre" runat="server" style="font-family: 'Arial Black'" Text="Camionero"></asp:Label>

  
                </td>
            <td class="auto-style8">
  
                <asp:TextBox ID="txtCamionero" runat="server" Width="345px" Enabled="False" Height="26px" ></asp:TextBox>
            </td>
            <td class="auto-style8">
  
              <asp:Label ID="lblCParadas" runat="server" style="font-family: 'Arial Black'" Text="Estado actual"></asp:Label>

  
            </td>
         </tr>
        <tr>
            <td class="auto-style7">
  
              <asp:Label ID="lblViajeID" runat="server" style="font-family: 'Arial Black'" Text="Viaje"></asp:Label>

  
                </td>
            <td class="auto-style8">
  
                <asp:TextBox ID="txtViaje" runat="server" Width="343px" Enabled="False" Height="26px" ></asp:TextBox>
            </td>
            <td class="auto-style9" rowspan="3">
  
                <asp:TextBox ID="txtEstadoActual" runat="server" Height="106px" TextMode="MultiLine" Width="323px"></asp:TextBox>
            </td>
         </tr>
        <tr>
            <td class="auto-style7">
  
              <asp:Label ID="lblEstado" runat="server" style="font-family: 'Arial Black'" Text="Seleccione Estado"></asp:Label>

  
                <br />
  
  
                </td>
            <td class="auto-style8">
  
                <asp:DropDownList ID="ddlEstado" runat="server" Height="20px" Width="351px">
                    <asp:ListItem>En curso</asp:ListItem>
                    <asp:ListItem>Parada</asp:ListItem>
                    <asp:ListItem>Finalizado</asp:ListItem>
                </asp:DropDownList>

  
                <br />
  
                </td>
         </tr>
        <tr>
            <td class="auto-style7">
  
              <asp:Label ID="lblKilaje" runat="server" style="font-family: 'Arial Black'" Text="Kilaje"></asp:Label>

  
                </td>
            <td class="auto-style8">
  
                <asp:TextBox ID="txtKilaje" runat="server" Width="220px" Height="26px" ></asp:TextBox>
                <asp:Label ID="lblIdViaje" runat="server" Visible="false" />
            </td>
         </tr>
        <tr>
            <td class="auto-style1" colspan="3">
  
              <asp:Label ID="lblcomentario" runat="server" style="font-family: 'Arial Black'" Text="Comentario"></asp:Label>

  
                &nbsp;

  
                <br />
                <asp:TextBox ID="txtComentario" runat="server" Height="106px" TextMode="MultiLine" Width="865px"></asp:TextBox>
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
