﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="abmClientes.aspx.cs" MasterPageFile="~/Site.master"
    Inherits="Ejemplo.Web.Cliente.abmClientes" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Administración de clientes
    </h2>
    <table>
        <tr>
            <td align="left">Nombre:
            </td>
            <td>
                <asp:TextBox ID="txtNombre" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="El nombre es obligatorio"
                    ControlToValidate="txtNombre"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">Apellido:
            </td>
            <td>
                <asp:TextBox ID="txtApellido" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="El apellido es obligatorio"
                    ControlToValidate="txtApellido"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">Direccion:
            </td>
            <td>
                <asp:TextBox ID="txtDireccion" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="La direccion es obligatorio"
                    ControlToValidate="txtDireccion"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">Categoria:
            </td>
            <td colspan="3" align="left">
                <asp:Label ID="lblCategoria" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3" align="left">
                <asp:Label ID="lblResultado" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3" align="left">
                <asp:Button ID="btnAgregar" Text="Agregar" runat="server" OnClick="btnAgregar_Click" />
            </td>
        </tr>

        <tr>

            <td>
                <asp:GridView ID="grdCategorias" Width="100%" runat="server" AutoGenerateColumns="true"
                    ViewStateMode="Enabled" CellPadding="4" ForeColor="#333333" GridLines="None"
                    AutoGenerateSelectButton="true"
                    OnSelectedIndexChanging="grdCategorias_SelectedIndexChanging" EmptyDataText="No hay datos ingresados"
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
                <asp:GridView ID="grillaCliente" Width="100%" runat="server" AutoGenerateColumns="true"
                    ViewStateMode="Enabled" CellPadding="4" ForeColor="#333333" GridLines="None"
                    AutoGenerateSelectButton="true"
                    OnSelectedIndexChanging="grillaCliente_SelectedIndexChanging" EmptyDataText="No hay datos ingresados"
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
