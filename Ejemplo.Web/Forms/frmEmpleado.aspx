<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmEmpleado.aspx.cs" MasterPageFile="~/Site.master" 
Inherits="Ejemplo.Web.Forms.frmEmpleado" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .auto-style1 {
            height: 180px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Administración de Empleados
    </h2>
    <br />
    <center>
        <table>
            <tr>
                <td class="auto-style1">
                    <table>
                        <tr>
                            <td align="left">
                                Cedula:
                            </td>
                            <td>
                                <asp:TextBox ID="txtCedula" MaxLength="30" runat="server" ></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="frvCedula" runat="server" ErrorMessage="La Cedula es obligatoria"
                                    ControlToValidate="txtCedula"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                Nombre:
                            </td>
                            <td>
                                <asp:TextBox ID="txtNombre" MaxLength="30" runat="server" ></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="El Nombre es obligatorio"
                                    ControlToValidate="txtNombre"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                Apellido:
                            </td>
                            <td>
                                <asp:TextBox ID="txtApellido" MaxLength="30" runat="server" ></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ErrorMessage="El Apellido es obligatorio"
                                    ControlToValidate="txtApellido"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                               Telefono:
                            </td>
                            <td>
                                <asp:TextBox ID="txtTelefono" MaxLength="4" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ErrorMessage="El Telefono es obligatorio"
                                    ControlToValidate="txtTelefono"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                         <tr>
                            <td align="left">
                               Usuario:
                            </td>
                            <td>
                                <asp:TextBox ID="txtUsuario" MaxLength="4" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="rvfUsuario" runat="server" ErrorMessage="El Usuario es obligatorio"
                                    ControlToValidate="txtUsuario"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                         <tr>
                            <td align="left">
                               Password:
                            </td>
                            <td>
                                <asp:TextBox ID="txtPassword" MaxLength="4" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="rvfPassword" runat="server" ErrorMessage="La Password es obligatoria"
                                    ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                            </td>
                        </tr>

                        <tr>
                            <td colspan="3" align="left">
                                <asp:Label ID="lblResultado" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <%--<tr>
                            <td colspan="3" align="left">
                                <asp:Button ID="btnAgregar" Text="Agregar" runat="server" OnClick="btnAltaEmpleado" />
                                <asp:Button ID="btnActualizar" runat="server" Text="Modificar" Visible="false" OnClick="btnModificarCamion_Click" />
                                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Visible="false" OnClick="btnCancelar_Click" />
                            </td>
                        </tr>--%>
                    </table>
                </td>
                <td class="auto-style1">
                    <%--<table>
                        <tr>
                            <td>
                                <asp:GridView ID="grdAdministradores" Width="100%" runat="server" AutoGenerateColumns="true"
                                    ViewStateMode="Enabled" CellPadding="4" ForeColor="#333333" GridLines="None"
                                    AutoGenerateDeleteButton="true" OnRowDeleting="grdCamion_RowDeleting" AutoGenerateSelectButton="true"
                                    OnSelectedIndexChanging="grdCamion_SelectedIndexChanging" EmptyDataText="No hay datos ingresados"
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
                    </table>--%>
                </td>
            </tr>
        </table>
    </center>
</asp:Content>
