
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="abmViaje.aspx.cs" MasterPageFile="~/Site.master"
    Inherits="Ejemplo.Web.Cliente.abmEmpleados" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Administración de Viaje
    </h2>
    <table>
        <tr>
            <td align="left">IdViaje:
            </td>
            <td>
                <asp:TextBox ID="txtIdViaje" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="El Id de viaje es obligatorio"
                    ControlToValidate="txtIdViaje"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">Cedula Camionero:
            </td>
            <td>
                <asp:TextBox ID="txtCedulaCam" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="La cedula de camionero es obligatoria"
                    ControlToValidate="txtCedulaCam"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">Matricula Camion:
            </td>
            <td>
                <asp:TextBox ID="txtMatriculaCam" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="La Matricula Camion obligatorio"
                    ControlToValidate="txtMatriculaCam"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">Kilos:
            </td>
            <td>
                <asp:TextBox ID="txtKilos" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="El kilaje es obligatorio"
                    ControlToValidate="txtKilos"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td align="left">Tipo De Carga:
            </td>
            <td>
                <asp:TextBox ID="txtTipoCarga" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="El Tipo de Carga es obligatorio"
                    ControlToValidate="txtTipoCarga"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td align="left">Origen:
            </td>
            <td>
                <asp:TextBox ID="txtOrigen" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="El Origen es obligatorio"
                    ControlToValidate="txtOrigen"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td align="left">Destino:
            </td>
            <td>
                <asp:TextBox ID="txtDestino" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="El Destino es obligatorio"
                    ControlToValidate="txtDestino"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td align="left">Fecha Inicio:
            </td>
            <td>
                <asp:TextBox ID="txtFechaIni" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="La fecha Inicio es obligatoria"
                    ControlToValidate="txtFechaIni"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td align="left">Fecha Fin:
            </td>
            <td>
                <asp:TextBox ID="txtFechaFin" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="La Fecha Fin es obligatoria"
                    ControlToValidate="txtFechaFin"></asp:RequiredFieldValidator>
            </td>
        </tr>
       
       
        
        <tr>
            <td colspan="3" align="left">
                <asp:Button ID="btnAgregar" Text="Agregar Viaje" runat="server" OnClick="btnAgregar_Click_Viaje" />
                <asp:Button ID="btnModificar" Text="Modificar Viaje" runat="server" Visible ="false" OnClick="btnModificar_Click_Viaje" />
                <asp:Button ID="btnEliminar" Text="Eliminar Viaje" runat="server" Visible ="false" OnClick="btnEliminar_Click_Viaje" />
                 <asp:Button ID="btnCancelar" Text="Cancelar" runat="server" Visible ="false" OnClick="btnCancelar_Click_Viaje" />
            </td>
        </tr>

        <tr>

            <td>
                <asp:GridView ID="grdViaje" Width="100%" runat="server" AutoGenerateColumns="true"
                    ViewStateMode="Enabled" CellPadding="4" ForeColor="#333333" GridLines="None"
                    AutoGenerateSelectButton="true"
                    OnSelectedIndexChanging="grdViaje_SelectedIndexChanging" EmptyDataText="No hay datos ingresados"
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



            <td>
                <asp:GridView ID="grillaViaje" Width="100%" runat="server" AutoGenerateColumns="true"
                    ViewStateMode="Enabled" CellPadding="4" ForeColor="#333333" GridLines="None"
                    AutoGenerateSelectButton="true"
                    OnSelectedIndexChanging="grillaViaje_SelectedIndexChanging" EmptyDataText="No hay datos ingresados"
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
    <br />
</asp:Content>
