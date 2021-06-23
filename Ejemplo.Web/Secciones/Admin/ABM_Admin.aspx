<%@ Page Title="Gestión de Admins" Language="C#" AutoEventWireup="true" CodeBehind="ABM_Admin.aspx.cs" Inherits="Ejemplo.Web.Secciones.Admin.ABM_Admin" MasterPageFile="~/Site.master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Administradores</h2>
    <br />

    <table>
        <tr>
            <td align="left">Cedula:
            </td>
            <td>
                <asp:TextBox ID="txtCedula" MaxLength="8" runat="server"></asp:TextBox>
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
                <asp:TextBox ID="txtTelefono" MaxLength="12" runat="server"></asp:TextBox>
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
            <td colspan="3" align="left">
                <asp:Label ID="lblResultado" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3" align="left">
                <asp:Button ID="btnAgregar" Text="Agregar" runat="server" OnClick="btnAgregar_Click" />
                <%--                                <asp:Button ID="btnActualizar" Text="Modificar" runat="server" Visible="false" OnClick="btnActualizar_Click" />
                                <asp:Button ID="btnCancelar" Text="Cancelar" runat="server" Visible="false" OnClick="btnCancelar_Click" />--%>
            </td>
        </tr>
    </table>
</asp:Content>
