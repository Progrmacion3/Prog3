<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViajeC.aspx.cs" Inherits="Ejemplo.Web.ViajeC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 328px;
        }
    </style>
</head>
<body>
    <form runat="server">
     <div class="page">
       <div class="header">
         <div class="title">
                 <h1>
                    Seccion Camionero
                 </h1>
        </div>
           
            <div class="clear hideSkiplink">
            <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
                <Items>

              <asp:MenuItem NavigateUrl="~/SeccionCamionero.aspx" Text="Pagina Principal"/>
              <asp:MenuItem NavigateUrl="~/ViajeC.aspx" Text="Viajes" />
              <asp:MenuItem NavigateUrl="~/ParadaC.aspx" Text="Camionero" />
                </Items>
            </asp:Menu>
            </div>
    </div>
      <div class="main">
          <h2>
        Actualización del kilaje y estado de su viaje
    </h2>
        <table>
       <tr>
           <td align="left" class="auto-style1"> Kilaje:
            </td>
            <td>
                <asp:TextBox ID="txtKilajeC" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvKilajeC" runat="server" ErrorMessage="El kilaje de la carga es obligatorio"
                    ControlToValidate="txtKilajeC"></asp:RequiredFieldValidator>
            </td>
       </tr>
            <tr>
            <td align="left" class="auto-style1"> Estado del viaje:
            </td>
            <td>
                <asp:TextBox ID="txtEstadoViajeC" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvEstadoViajeC" runat="server" ErrorMessage="El estado del viaje es obligatorio"
                    ControlToValidate="txtEstadoViajeC"></asp:RequiredFieldValidator>
            </td>
            </tr>
            <tr>
            <td align="left"> Tipo de carga:
            </td>
            <td>
                <asp:TextBox ID="txtTipoCargaC" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvTipoCargaC" runat="server" ErrorMessage="El tipo de carga del viaje es obligatorio"
                    ControlToValidate="txtTipoCargaC"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
           <td align="left"> Origen del viaje:
            </td>
            <td>
                <asp:TextBox ID="txtOrigenC" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvOrigenC" runat="server" ErrorMessage="El origen del viaje es obligatorio"
                    ControlToValidate="txtOrigenC"></asp:RequiredFieldValidator>
            </td>
       </tr>
       <tr>
           <td align="left"> Destino del viaje:
            </td>
            <td>
                <asp:TextBox ID="txtDestinoC" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvDestinoC" runat="server" ErrorMessage="El destino del viaje es obligatorio"
                    ControlToValidate="txtDestinoC"></asp:RequiredFieldValidator>
            </td>
       </tr>
            <tr>
                <td align="left"> Fecha de inicio del viaje:
            </td>
            <td>
                <asp:TextBox ID="txtFechaInicioC" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvFechaInicioC" runat="server" ErrorMessage="La fecha de inicio del viaje es obligatorio"
                    ControlToValidate="txtFechaInicioC"></asp:RequiredFieldValidator>
            </td>
            </tr>
            <tr>
                <td align="left"> Fecha de finalización del viaje:
            </td>
            <td>
                <asp:TextBox ID="txtFechaFinalizacionC" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvFechaFinalizacionC" runat="server" ErrorMessage="La fecha de finalización del viaje es obligatorio"
                    ControlToValidate="txtFechaFinalizacionC"></asp:RequiredFieldValidator>
            </td>
            </tr>
                <tr>
            <td colspan ="3" align="left">
                <asp:Label ID="lblIDcamioneroC" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
               <asp:Label ID="lblIDcamionC" runat="server"></asp:Label>
            </td>
        </tr>
               
            <tr>
            <td colspan="3" align="left">
                <asp:Label ID="lblResultadoViaC" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="lblIDviaje" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
             <tr>
                  <td class="auto-style1">
                         <asp:Button ID="btnActualizarViaje" runat="server" Text="Actualizar" OnClick="btnActualizarViaje_Click" Visible="false"/>
                         <asp:Button ID="btnCancelarViaje" runat="server" Text="Cancelar" OnClick="btnCancelarViaje_Click" Visible="false" />
                          <asp:GridView ID="grillaViajes" Width="100%" runat="server" AutoGenerateColumns="true"
                                    ViewStateMode="Enabled" CellPadding="4" ForeColor="#333333" GridLines="None"
                                    AutoGenerateSelectButton="true"
                                    OnSelectedIndexChanging="grillaViajes_SelectedIndexChanging"
                                    EmptyDataText="No hay datos ingresados"
                                    ShowHeaderWhenEmpty="true" Height="23px">
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
