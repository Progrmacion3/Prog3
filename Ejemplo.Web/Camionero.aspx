﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Camionero.aspx.cs" Inherits="Ejemplo.Web.Camionero" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            height: 25px;
        }
    </style>
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
            Administración de los camioneros
        </h2>
        <table>
             <tr>
            <td align="left"> 
            <asp:Label ID="lblIdentificadorCam" Text="identificadorCam:" runat="server" Visible="false"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtIdentificadorCam" MaxLength="50" runat="server" Visible="false"></asp:TextBox>
            </td>
        </tr>
             <tr>
            <td align="left"> Edad del camionero:
            </td>
            <td>
                <asp:TextBox ID="txtEdadCam" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvEdadCam" runat="server" ErrorMessage="La edad del camionero es obligatorio"
                    ControlToValidate="txtEdadCam"></asp:RequiredFieldValidator>
            </td>
        </tr>
             <tr>
            <td align="left"> Tipo de libreta:
            </td>
            <td>
                <asp:TextBox ID="txtTipoLibreta" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvTipoLibreta" runat="server" ErrorMessage="El tipo de libreta es obligatorio"
                    ControlToValidate="txtTipoLibreta"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td align="left"> Fecha de vencimiento de la libreta:
            </td>
            <td>
                <asp:TextBox ID="txtFechaVencimientoLibreta" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvFechaVencimientoLibreta" runat="server" ErrorMessage="La fecha de vencimiento de la libreta es obligatorio"
                    ControlToValidate="txtFechaVencimientoLibreta"></asp:RequiredFieldValidator>
            </td>
        </tr>
              <tr>
            <td colspan="3" align="left" class="auto-style1">
                <asp:Label ID="lblResultadoCamionero" Text="." runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
             <tr>
                  <td>
                         <asp:Button ID="btnAgregarCamionero" runat="server" Text="Agregar" OnClick="btnAgregarCamionero_Click" />
                         <asp:Button ID="btnModificarCamionero" runat="server" Text="Modificar" OnClick="btnModificarCamionero_Click" Visible="false"/>
                         <asp:GridView ID="grillaCamioneros" Width="100%" runat="server" AutoGenerateColumns="true"
                                    ViewStateMode="Enabled" CellPadding="4" ForeColor="#333333" GridLines="None"
                                    AutoGenerateDeleteButton="true" OnRowDeleting="grillaCamioneros_RowDeleting" AutoGenerateSelectButton="true" 
                                    OnSelectedIndexChanging="grillaCamioneros_SelectedIndexChanging"
                                    EmptyDataText="No hay datos ingresados"
                                    ShowHeaderWhenEmpty="True">
                                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                    <EditRowStyle BackColor="#999999" />
                                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                                </asp:GridView>
                      </td>
                </tr>
        </table>
    </div>
    </div>
    </form>
</body>
</html>
