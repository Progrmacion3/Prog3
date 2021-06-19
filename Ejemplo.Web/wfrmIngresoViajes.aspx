<%@ Page Title="" Language="C#" MasterPageFile="~/Administradores.master" AutoEventWireup="true" CodeBehind="wfrmIngresoViajes.aspx.cs" Inherits="Ejemplo.Web.wfrmIngresoViajes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type ="text/css"> 
label
{display: 
 inline-block;
 width: 100px;
 }
  input[type: submit] 
 {
  padding: 10px;
 }
      
        .style1
        {
            height: 29px;
        width: 925px;
    }
      
    .auto-style3 {
        width: 330px;
    }
    .auto-style4 {
    }
    .auto-style6 {
        width: 165px;
    }
    .auto-style7 {
        width: 351px;
    }
      
    </style>
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="MainContent">
    <table class="style1">
        <caption style="font-family: Arial, Helvetica, sans-serif; font-size: large; font-weight: bold; color: #000066">
            <br />
            INGRESO DE VIAJES<br />
        </caption>
        <tr>
            <td class="auto-style6">
    <asp:Label ID="lblIdViaje" runat="server" style="font-family: 'Arial Black'" Text="Id Viaje"></asp:Label>
  
            </td>
            <td class="auto-style3">
    <asp:TextBox ID="txtIdViaje" runat="server" TabIndex="1" OnTextChanged="txtIdViaje_TextChanged" Enabled="False" Height="22px"></asp:TextBox>
            </td>
            <td class="auto-style7">
                &nbsp;</td>
         </tr>
        <tr>
            <td class="auto-style6">
    <asp:Label ID="lbCarga" runat="server" style="font-family: 'Arial Black'" Text="Tipo de Carga"></asp:Label>
  
            </td>
            <td class="auto-style3">
    <asp:TextBox ID="txtCarga" runat="server" TabIndex="1" OnTextChanged="txtCarga_TextChanged"></asp:TextBox>
            </td>
            <td class="auto-style7">
                &nbsp;</td>
         </tr>
        <tr>
            <td class="auto-style6">
    <asp:Label ID="lblFecIni" runat="server" style="font-family: 'Arial Black'" Text="Fecha Inicio"></asp:Label>
  
            </td>
            <td class="auto-style3">
    <asp:TextBox ID="txtFecIni" runat="server" TabIndex="1" OnTextChanged="txtFecIni_TextChanged"></asp:TextBox>
            </td>
            <td class="auto-style7">
                &nbsp;</td>
         </tr>
        <tr>
            <td class="auto-style6">
    <asp:Label ID="lblFecFinal" runat="server" style="font-family: 'Arial Black'" Text="Fecha Final"></asp:Label>
  
            </td>
            <td class="auto-style3">
    <asp:TextBox ID="txtFecFin" runat="server" TabIndex="1" OnTextChanged="txtFecFin_TextChanged"></asp:TextBox>
            </td>
            <td class="auto-style7">
                &nbsp;</td>
         </tr>
        <tr>
            <td class="auto-style6">
    <asp:Label ID="lblCamion" runat="server" style="font-family: 'Arial Black'" Text="Camión"></asp:Label>
  
            </td>
            <td class="auto-style3">
            <asp:ListBox ID="lstCamion" runat="server" Width="297px" Height="25px" 
             Font-Size="Smaller" OnSelectedIndexChanged="lstCamion_SelectedIndexChanged"></asp:ListBox>
            </td>
            <td class="auto-style7">
  
    <asp:Button ID="btnSeleccionarCamion" runat="server" style="text-align: center" 
                    Width="230px" Height="24px" BackColor="#003366" 
                    BorderColor="#CCFFFF" Font-Bold="True" ForeColor="White" Text="SELECCIONAR CAMIÓN" 
        onclick="btnSeleccionarCamion_Click" />
  
            </td>
         </tr>
        <tr>
            <td class="auto-style6">
    <asp:Label ID="lblCamionero" runat="server" style="font-family: 'Arial Black'" Text="Camionero"></asp:Label>
  
            </td>
            <td class="auto-style3">
            <asp:ListBox ID="lstCamioneros" runat="server" Width="297px" Height="25px" 
             Font-Size="Smaller" OnSelectedIndexChanged="lstCamioneros_SelectedIndexChanged"></asp:ListBox>
            </td>
            <td class="auto-style7">
  
    <asp:Button ID="btnSeleccionarCamionero" runat="server" style="text-align: center" 
                    Width="230px" Height="24px" BackColor="#003366" 
                    BorderColor="#CCFFFF" Font-Bold="True" ForeColor="White" Text="SELECCIONAR CAMIONERO" 
        onclick="btnSeleccionarCamionero_Click" />
  
            </td>
         </tr>
        <tr>
            <td class="auto-style6">
    <asp:Label ID="lblCiuIni" runat="server" style="font-family: 'Arial Black'" Text="Ciudad Inicio"></asp:Label>
                <br />
  
            </td>
            <td class="auto-style3">
            <asp:ListBox ID="lstCiudIni" runat="server" Width="297px" Height="25px" 
             Font-Size="Smaller" OnSelectedIndexChanged="lstCiudIni_SelectedIndexChanged"></asp:ListBox>
             <br />
            </td>
            <td class="auto-style7">
  
    <asp:Button ID="btnSeleccionarCiuIni" runat="server" style="text-align: center" 
                    Width="230px" Height="24px" BackColor="#003366" 
                    BorderColor="#CCFFFF" Font-Bold="True" ForeColor="White" Text="SELECCIONAR CIUDAD" 
        onclick="btnSeleccionarCiuIni_Click" />
  
            </td>
         </tr>
        <tr>
            <td class="auto-style6">
  
    <asp:Label ID="lblCiufin" runat="server" style="font-family: 'Arial Black'" Text="Ciudad Final"></asp:Label>
  
            </td>
            <td class="auto-style3">
            <asp:ListBox ID="lstCiudFin" runat="server" Width="297px" Height="25px" 
             Font-Size="Smaller" OnSelectedIndexChanged="lstCiudFin_SelectedIndexChanged"></asp:ListBox>
            </td>
            <td class="auto-style7">
    <asp:Button ID="btnSeleccionarCiudfin" runat="server" style="text-align: center; margin-top: 0px;" Width="230px" Height="26px" BackColor="#003366" 
                    BorderColor="#CCFFFF" Font-Bold="True" ForeColor="White"
         Text="SELECCIONAR CIUDAD" onclick="btnSeleccionarCiuFin_Click" />
            </td>
         </tr>
    </table>
    <table class="style13">
        <tr>
            <td class="auto-style4">
   
    <asp:ListBox ID="lstViajes" runat="server" Width="817px" Height="106px" 
                    Font-Size="Smaller" OnSelectedIndexChanged="lstViajes_SelectedIndexChanged" ></asp:ListBox>
                </td>
        </tr>
        </table>
    <br />
  

    <asp:Button ID="btnAlta" runat="server" style="text-align: center" 
        Width="115px" Height="45px" BackColor="#003366" 
                    BorderColor="#CCFFFF" Font-Bold="True" ForeColor="White" 
        Text="ALTA" onclick="btnAlta_Click" TabIndex="8" />

    &nbsp;

    <asp:Button ID="btnBaja" runat="server" style="text-align: center" 
        Width="115px" Height="45px" BackColor="#003366" 
                    BorderColor="#CCFFFF" Font-Bold="True" ForeColor="White" 
        Text="BAJA" onclick="btnBaja_Click" TabIndex="9" />
   
    &nbsp;&nbsp;
   
    <asp:Button ID="btnLimpiar" runat="server" style="text-align: center" Width="115px" Height="45px" BackColor="#003366" 
                    BorderColor="#CCFFFF" Font-Bold="True" ForeColor="White" Text="LIMPIAR" 
        onclick="btnLimpiar_Click" />

    &nbsp;&nbsp;&nbsp;
  
    <asp:Label ID="lblMensajes" style="font-family: 'Arial Black'" runat="server" 
        Width="514px" runat="server" Text="." ForeColor="#CC0000"></asp:Label>
    <br />
    
</asp:Content>
