﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Viaje.aspx.cs" Inherits="Ejemplo.Web.Viaje" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en">
<head runat="server">
    <title></title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form runat="server">
    <div class="page">
        <div class="header">
            <div class="title">
                <h1>
                    Seccion Administrativa
                </h1>
            </div>
           
            <div class="clear hideSkiplink">
            <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
                <Items>

              <asp:MenuItem NavigateUrl="~/SeccionAdministrativa.aspx" Text="Pagina Principal"/>
              <asp:MenuItem NavigateUrl="~/Camion.aspx" Text="Camion" />
              <asp:MenuItem NavigateUrl="~/Camionero.aspx" Text="Camionero" />
              <asp:MenuItem NavigateUrl="~/Empleado.aspx" Text="Empleado" />
              <asp:MenuItem NavigateUrl="~/Parada.aspx" Text="Parada" />
              <asp:MenuItem NavigateUrl="~/Viaje.aspx" Text="Viaje" />
                </Items>
            </asp:Menu>
            </div>
      </div>
    <div class="main">
    <h2>
        Administración de los Viajes
    </h2>
        <table>
        <tr>
            <td align="left"> identificador del viaje:
            </td>
            <td>
                <asp:TextBox ID="txtIdViaje" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvIdViaje" runat="server" ErrorMessage="El identificador del viaje es obligatorio"
                    ControlToValidate="txtIdViaje"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left"> identificador del camionero:
            </td>
            <td colspan ="3" align="left">
                <asp:Label ID="lblIDcamionero" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left"> identificador del camion:
            </td>
            <td>
               <asp:Label ID="lblMatricula" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left"> Tipo de carga:
            </td>
            <td>
                <asp:TextBox ID="txtTipoCarga" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvTipoCarga" runat="server" ErrorMessage="El tipo de carga del viaje es obligatorio"
                    ControlToValidate="txtTipoCarga"></asp:RequiredFieldValidator>
            </td>
        </tr>
       <tr>
           <td align="left"> Kilaje:
            </td>
            <td>
                <asp:TextBox ID="txtKilaje" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvKilaje" runat="server" ErrorMessage="El kilaje de la carga es obligatorio"
                    ControlToValidate="txtKilaje"></asp:RequiredFieldValidator>
            </td>
       </tr>
       <tr>
           <td align="left"> Origen del viaje:
            </td>
            <td>
                <asp:TextBox ID="txtOrigen" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvOrigen" runat="server" ErrorMessage="El origen del viaje es obligatorio"
                    ControlToValidate="txtOrigen"></asp:RequiredFieldValidator>
            </td>
       </tr>
       <tr>
           <td align="left"> Destino del viaje:
            </td>
            <td>
                <asp:TextBox ID="txtDestino" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvDestino" runat="server" ErrorMessage="El destino del viaje es obligatorio"
                    ControlToValidate="txtDestino"></asp:RequiredFieldValidator>
            </td>
       </tr>
            <tr>
                <td align="left"> Fecha de inicio del viaje:
            </td>
            <td>
                <asp:TextBox ID="txtFechaInicio" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvFechaInicio" runat="server" ErrorMessage="La fecha de inicio del viaje es obligatorio"
                    ControlToValidate="txtFechaInicio"></asp:RequiredFieldValidator>
            </td>
            </tr>
            <tr>
                <td align="left"> Fecha de finalización del viaje:
            </td>
            <td>
                <asp:TextBox ID="txtFechaFinalizacion" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvFechaFinalizacion" runat="server" ErrorMessage="La fecha de finalización del viaje es obligatorio"
                    ControlToValidate="txtFechaFinalizacion"></asp:RequiredFieldValidator>
            </td>
            </tr>
            <tr>
            <td align="left"> Estado del viaje:
            </td>
            <td>
                <asp:TextBox ID="txtEstadoViaje" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvEstadoViaje" runat="server" ErrorMessage="El estado del viaje es obligatorio"
                    ControlToValidate="txtEstadoViaje"></asp:RequiredFieldValidator>
            </td>
            </tr>
            <tr>
            <td colspan="3" align="left">
                <asp:Label ID="lblResultado" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        </table>
    </div>
    </div>
    </form>
</body>
</html>
