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
                                Cargo:
                            </td>
                            <td>
                                <asp:TextBox ID="txtCargo" MaxLength="30" runat="server" ></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="El Cargo es obligatorio"
                                    ControlToValidate="txtCargo"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                               Telefono:
                            </td>
                            <td>
                                <asp:TextBox ID="txtTelefono" MaxLength="12" runat="server"></asp:TextBox>
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
                                <asp:TextBox ID="txtUsuario" MaxLength="30" runat="server"></asp:TextBox>
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
                                <asp:TextBox ID="txtPassword" MaxLength="30" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="rvfPassword" runat="server" ErrorMessage="La Password es obligatoria"
                                    ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                          <td class="style16">
                            <asp:Label ID="lblTipo" runat="server" Text="Tipo" ></asp:Label>
                          </td>
                          <td class="style17">
                            <asp:RadioButton ID="rdbAdministrador" runat="server" Text="Administrador" 
                              OnCheckedChanged="rdbAdministrador_CheckedChanged" GroupName="TIPO" TabIndex="6" AutoPostBack="True" Checked="True" />
                          </td>
                          <td class="style18">
                            <asp:RadioButton ID="rdbCamionero" runat="server" Text="Camionero" 
                              OnCheckedChanged="rdbCamionero_CheckedChanged" GroupName="TIPO" TabIndex="7" AutoPostBack="True" />
                          </td>
                        </tr>
                        <tr>
                            <td  align="left">
                                <asp:Label ID="lblEdad" Text="Edad" runat="server" Visible="False"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtEdad" MaxLength="3" runat="server" Visible="False"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"  ErrorMessage="La Edad es obligatoria"
                                    ControlToValidate="txtEdad"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                             <td align="left">
                                <asp:Label ID="lblTipoLibreta" Text="Tipo Libreta" runat="server" Visible="False"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtTipoLibreta" MaxLength="30" runat="server" Visible="False"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"  ErrorMessage="El tipo de la Libreta es Oligatoria"
                                    ControlToValidate="txtTipoLibreta"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                             <td  align="left">
                                <asp:Label ID="lblVencimientoLibreta" Text="Vencimiento Libreta" runat="server" Visible="False"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtVencimientoLibreta" MaxLength="30" runat="server" Visible="False"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="El vencimiento de la Libreta es obligatoria"
                                    ControlToValidate="txtVencimientoLibreta"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" align="left">
                                <asp:Label ID="lblResultado" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" align="left">
                                <asp:Button ID="btnAltaEmpleado" Text="Alta" runat="server" OnClick="btnAltaEmpleado_Click" />
                                <asp:Button ID="btnActualizarEmpleado" runat="server" Text="Modificar" Visible="false" OnClick="btnActualizarEmpleado_Click" />
                                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Visible="false" OnClick="btnCancelar_Click" />
                            </td>
                        </tr>
                    </table>
                </td>
             </tr>
            <td class="auto-style1">
                    <table>
                        <tr>
                            <td>
                                <asp:GridView ID="grdAdministradores" Width="100%" runat="server" AutoGenerateColumns="true"
                                    ViewStateMode="Enabled" CellPadding="4" ForeColor="#333333" GridLines="None"
                                    AutoGenerateDeleteButton="true" OnRowDeleting="grdAdministradores_RowDeleting" AutoGenerateSelectButton="true"
                                    OnSelectedIndexChanging="grdAdministradores_SelectedIndexChanging" EmptyDataText="No hay datos ingresados"
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
                <table>
                        <tr>
                            <td>
                                <asp:GridView ID="grdCamioneros" Width="100%" runat="server"
                                    ViewStateMode="Enabled" CellPadding="4" ForeColor="#333333" GridLines="None"
                                    AutoGenerateDeleteButton="True" OnRowDeleting="grdCamioneros_RowDeleting" AutoGenerateSelectButton="True"
                                    OnSelectedIndexChanging="grdCamioneros_SelectedIndexChanging" EmptyDataText="No hay datos ingresados"
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
                </td>
        </table>
    </center>
</asp:Content>
