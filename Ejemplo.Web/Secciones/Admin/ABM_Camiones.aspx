<%@ Page Title="Gestión camiones" Language="C#" AutoEventWireup="true" CodeBehind="ABM_Camiones.aspx.cs" Inherits="Ejemplo.Web.Secciones.Admin.ABM_Camiones" MasterPageFile="~/Site.master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="MenuAdmin" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Camiones</h2>
    <br />

    <table>
        <tr>
            <td align="left">Matricula:
            </td>
            <td>
                <asp:TextBox ID="txtMatricula" MaxLength="7" runat="server" Width="275px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvMatricula" runat="server" ErrorMessage="La matricula es obligatoria" ControlToValidate="txtMatricula"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">Marca:
            </td>
            <td>
                <asp:TextBox ID="txtMarca" MaxLength="30" runat="server" Width="275px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvMarca" runat="server" ErrorMessage="La marca es obligatorio" ControlToValidate="txtMarca"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">Modelo:
            </td>
            <td>
                <asp:TextBox ID="txtModelo" MaxLength="30" runat="server" Width="275px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvModelo" runat="server" ErrorMessage="El modelo es obligatorio" ControlToValidate="txtModelo"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">Año:
            </td>
            <td>
                <asp:TextBox ID="txtAño" MaxLength="4" runat="server" onkeydown="return (!(event.keyCode>=65) && event.keyCode!=32);" Width="275px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvAño" runat="server" ErrorMessage="El año es obligatorio" ControlToValidate="txtAño"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="3" align="left">
                <br />
                <asp:Label ID="lblResultado" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3" align="left">
                <asp:Button ID="btnAgregar" Text="Agregar" runat="server" OnClick="btnAgregar_Click" />
                <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
                <asp:Button ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Modificar" />
                <asp:Button ID="btnLimpiar" runat="server" OnClick="btnLimpiar_Click" Text="Limpiar campos" />
            </td>
        </tr>
    </table>
     <asp:GridView ID="grdCamiones" Width="93%" runat="server" AutoGenerateColumns="true" ViewStateMode="Enabled" CellPadding="10" ForeColor="#333333"
        OnSelectedIndexChanging="grdCamiones_SelectedIndexChanging" AutoGenerateSelectButton="true"
        EmptyDataText="No existen registros" ShowHeaderWhenEmpty="true" OnSelectedIndexChanged="grdCamiones_SelectedIndexChanged">
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
