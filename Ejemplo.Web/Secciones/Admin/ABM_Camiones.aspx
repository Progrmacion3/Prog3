<%@ Page Title="Gestión camiones" Language="C#" AutoEventWireup="true" CodeBehind="ABM_Camiones.aspx.cs" Inherits="Ejemplo.Web.Secciones.Admin.ABM_Camiones" MasterPageFile="~/Site.master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
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
&nbsp;&nbsp;
                <asp:ListBox ID="ListBox1" runat="server" DataSourceID="SqlDataSource1" DataTextField="IdCamion" DataValueField="IdCamion" style="margin-top: 1px" Width="334px"></asp:ListBox>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WindowsAuth %>" SelectCommand="SELECT DISTINCT [IdCamion], [Matricula], [Marca], [Modelo], [Año] FROM [Camiones] ORDER BY [IdCamion]"></asp:SqlDataSource>
                <br />
                <br />
                <asp:Label ID="lblResultado" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3" align="left">
                <asp:Button ID="btnAgregar" Text="Agregar" runat="server" OnClick="btnAgregar_Click" />
                <%--                                <asp:Button ID="btnActualizar" Text="Modificar" runat="server" Visible="false" OnClick="btnActualizar_Click" />
                                <asp:Button ID="btnCancelar" Text="Cancelar" runat="server" Visible="false" OnClick="btnCancelar_Click" />--%>
                <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
                <asp:Button ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Modificar" />
            </td>
        </tr>
    </table>
</asp:Content>
