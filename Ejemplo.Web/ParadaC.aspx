<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ParadaC.aspx.cs" Inherits="Ejemplo.Web.ParadaC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
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
            Administración de las paradas
        </h2>
        <table>
             <tr>
            <td align="left"> 
            <asp:Label ID="lblIdentificadorParC" Text="identificadorCam:" runat="server" Visible="false"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtIdentificadorParC" MaxLength="50" runat="server" Visible="false"></asp:TextBox>
            </td>
        </tr>
             <tr>
            <td align="left"> Estado de la parada:
            </td>
            <td>
                <asp:TextBox ID="txtEstadoParadaC" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvEstadoParadaC" runat="server" ErrorMessage="El estado de la parada es obligatorio"
                    ControlToValidate="txtEstadoParadaC"></asp:RequiredFieldValidator>
            </td>
        </tr>
             <tr>
            <td align="left"> Tipo de la parada:
            </td>
            <td>
                <asp:TextBox ID="txtTipoParadaC" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvTipoParadaC" runat="server" ErrorMessage="El tipo de parada es obligatorio"
                    ControlToValidate="txtTipoParadaC"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td align="left"> Comentario de la parada:
            </td>
            <td>
                <asp:TextBox ID="txtComentarioCam" MaxLength="50" runat="server" Height="83px" Width="184px"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvComentarioCam" runat="server" ErrorMessage="El comentario del administrador sobre la parada es obligatorio"
                    ControlToValidate="txtComentarioCam"></asp:RequiredFieldValidator>
            </td>
        </tr>
              <tr>
            <td colspan="3" align="left" class="auto-style1">
                <asp:Label ID="lblResultadoParadaC" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
             <tr>
                  <td>
                         <asp:Button ID="btnActualizarParada" runat="server" Text="Actualizar" OnClick="btnActualizarParada_Click" Visible="false"/>
                         <asp:GridView ID="grillaParadas" Width="100%" runat="server" AutoGenerateColumns="true"
                                    ViewStateMode="Enabled" CellPadding="4" ForeColor="#333333" GridLines="None"
                                    AutoGenerateSelectButton="true" OnSelectedIndexChanging="grillaParadas_SelectedIndexChanging"
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
