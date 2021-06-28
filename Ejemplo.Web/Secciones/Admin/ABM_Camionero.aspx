<%@ Page Title="Gestión de Camioneros" Language="C#" AutoEventWireup="true" CodeBehind="ABM_Camionero.aspx.cs" Inherits="Ejemplo.Web.Secciones.Admin.ABM_Camionero" MasterPageFile="~/Site.master"%>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Camioneros</h2>
    <br />

    <table>
        <tr>
            <td align="left">Cedula:
            </td>
            <td>
                <asp:TextBox ID="txtCedula" MaxLength="8" onkeydown="return (!(event.keyCode>=65) && event.keyCode!=32);" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvCedula" runat="server" ErrorMessage="La cédula es obligatoria" ControlToValidate="txtCedula"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">Nombre:
            </td>
            <td>
                <asp:TextBox ID="txtNombre" MaxLength="30" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="El nombre es obligatorio" ControlToValidate="txtNombre"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">Apellido:
            </td>
            <td>
                <asp:TextBox ID="txtApellido" MaxLength="30" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ErrorMessage="El apellido es obligatorio" ControlToValidate="txtApellido"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">FechaNacimiento:
            </td>
            <td>
                <asp:TextBox ID="txtFechaNacimiento" MaxLength="10" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvFechaNacimiento" runat="server" ErrorMessage="La fecha de nacimiento es obligatoria" ControlToValidate="txtFechaNacimiento"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">Cargo:
            </td>
            <td>
                <asp:TextBox ID="txtCargo" MaxLength="30" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvCargo" runat="server" ErrorMessage="El cargo es obligatoria" ControlToValidate="txtCargo"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">Telefono:
            </td>
            <td>
                <asp:TextBox ID="txtTelefono" MaxLength="12" onkeydown="return (!(event.keyCode>=65) && event.keyCode!=32);" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ErrorMessage="El telefono es obligatorio" ControlToValidate="txtTelefono"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">Usuario:
            </td>
            <td>
                <asp:TextBox ID="txtUsuario" MaxLength="30" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" ErrorMessage="El usuario es obligatorio" ControlToValidate="txtUsuario"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">Contraseña:
            </td>
            <td>
                <asp:TextBox ID="txtContraseña" MaxLength="30" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvContraseña" runat="server" ErrorMessage="La contraseña es obligatoria" ControlToValidate="txtContraseña"></asp:RequiredFieldValidator>
            </td>
        </tr>
                <tr>
            <td align="left">Categoria de libreta:
            </td>
            <td>
                <asp:TextBox ID="txtCatLibreta" MaxLength="2" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvCatLibreta" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtCatLibreta"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">Fecha de vencimiento:
            </td>
            <td>
                <asp:TextBox ID="txtFechaVencimiento" MaxLength="10" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvFechaVencimiento" runat="server" ErrorMessage="La fecha es obligatoria" ControlToValidate="txtFechaVencimiento"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="3" align="left">
                <asp:Label ID="lblResultado" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3" align="left">
                <asp:Button ID="btnAgregar" Text="Agregar" runat="server" OnClick="btnAgregar_Click" />
                <asp:Button ID="btnEliminar" Text="Eliminar" runat="server" OnClick="btnEliminar_Click" />
                <asp:Button ID="btnModificar" Text="Modificar" runat="server" OnClick="btnModificar_Click" />
                <asp:Button ID="btnLimpiar" Text="Limpiar campos" runat="server" OnClick="btnLimpiar_Click" />
            </td>
        </tr>
    </table>
    <asp:GridView ID="grdCamioneros" Width="93%" runat="server" AutoGenerateColumns="true" ViewStateMode="Enabled" CellPadding="10" ForeColor="#333333"
        OnSelectedIndexChanging="grdCamioneros_SelectedIndexChanging" AutoGenerateSelectButton="true" OnRowCreated="grdCamioneros_RowCreated"
        EmptyDataText="No existen registros" ShowHeaderWhenEmpty="true" OnSelectedIndexChanged="grdCamioneros_SelectedIndexChanged">
        <EditRowStyle BackColor="#3399ff" />
        <FooterStyle BackColor="Black" Font-Bold="true" ForeColor="White" />
        <HeaderStyle BackColor="Black" Font-Bold="true" ForeColor="White" Font-Size="X-Small"/>
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="Black" HorizontalAlign="Center" Font-Size="X-Small"/>
        <SelectedRowStyle BackColor="#cccccc" ForeColor="Black" />
        <SortedAscendingCellStyle BackColor="#c0c0c0" />
        <SortedDescendingCellStyle BackColor="#c0c0c0" />
        <SortedDescendingHeaderStyle BackColor="White" />
    </asp:GridView>
</asp:Content>

