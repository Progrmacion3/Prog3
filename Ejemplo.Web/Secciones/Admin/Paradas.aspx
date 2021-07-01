<%@ Page Title="Sección de Paradas." Language="C#" AutoEventWireup="true" CodeBehind="Paradas.aspx.cs" Inherits="Ejemplo.Web.Secciones.Admin.Paradas" MasterPageFile="~/Site.Master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="MenuAdmin" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Paradas:</h2>
    <br />
    <table>
        <tr>
            <td>
                <h3>ID Viaje:
                <asp:TextBox runat="server" ID="txtIdViaje" Enabled="false"/>
                <asp:RequiredFieldValidator ID="rfvIdViaje" ErrorMessage="Debe seleccionar el id del viaje" SetFocusOnError="true" ControlToValidate="txtIdViaje" runat="server"/></h3>
                <h3>ID Parada:
                <asp:TextBox runat="server" ID="txtIdParada" Enabled="false"/>
                <asp:RequiredFieldValidator ID="rfvIdParada" ErrorMessage="Debe seleccionar el id de la parada" SetFocusOnError="true" ControlToValidate="txtIdParada" runat="server"/></h3>
                <h3>Estado:
                <asp:DropDownList runat="server" ID="ddlEstado">
                    <asp:ListItem>En curso</asp:ListItem>
                    <asp:ListItem>Finalizado</asp:ListItem>
                    <asp:ListItem>Parado</asp:ListItem>
                </asp:DropDownList></h3>
            </td>
        </tr>
        <tr>
            <td>
                <h3>Comentario:</h3>
                <asp:TextBox runat="server" ID="txtComentario" TextMode="MultiLine"></asp:TextBox>
                <asp:Button runat="server" ID="btnActualizar" Text="Actualizar" OnClick="btnActualizar_Click" />
                <asp:Label runat="server" ID="lblMensaje"></asp:Label>
            </td>
        </tr>
    </table>
    <hr />
    <br />
    <asp:GridView ID="grdParadas" Width="93%" runat="server" AutoGenerateColumns="true" ViewStateMode="Enabled" CellPadding="5" ForeColor="#333333"
        EmptyDataText="No existen registros" ShowHeaderWhenEmpty="true" AutoGenerateSelectButton="true" OnSelectedIndexChanging="grdParadas_SelectedIndexChanging">
        <EditRowStyle BackColor="#3399ff" />
        <FooterStyle BackColor="Black" Font-Bold="true" ForeColor="White" />
        <HeaderStyle BackColor="Black" Font-Bold="true" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="Black" />
        <SelectedRowStyle BackColor="#cccccc" ForeColor="Black" />
        <SortedAscendingCellStyle BackColor="#c0c0c0" />
        <SortedDescendingCellStyle BackColor="#c0c0c0" />
        <SortedDescendingHeaderStyle BackColor="White" />
    </asp:GridView>

</asp:Content>

