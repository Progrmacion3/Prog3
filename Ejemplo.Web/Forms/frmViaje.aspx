<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmViaje.aspx.cs" MasterPageFile="~/Site.master"
    Inherits="Ejemplo.Web.Forms.frmViaje" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .auto-style1 {
            height: 180px;
        }
        .auto-style2 {
            height: 21px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
       
        Administración de Viajes
    </h2>
    <br />
    <center>
        <table>
            <tr>
                <td class="auto-style1">
                    <table>
                        <tr>
                            <td align="left">
                                <asp:Label ID="lblIdViajeText" Text="Id Viaje" Visible="false" runat="server"></asp:Label>
                            </td>
                            <td colspan="3" align="left">
                                <asp:Label ID="lblIdViaje" runat="server"></asp:Label>
                            </td>
                        </tr>
                          <tr>
                            <td align="left">Camionero:
                            </td>
                            <td colspan="3" align="left">
                                <asp:Label ID="lblCamionero" runat="server"></asp:Label>
                                <asp:Label ID="lblCICamionero" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="left" class="auto-style2">Camion:
                            </td>
                            <td colspan="3" align="left" class="auto-style2">
                                <asp:Label ID="lblCamion" runat="server"></asp:Label>
                                <asp:Label ID="lblMatriculaCamion" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                Tipo de Carga:
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlTipoCarga" runat="server">
                                    <asp:ListItem>Grano</asp:ListItem>
                                    <asp:ListItem>Contenedor</asp:ListItem>
                                    <asp:ListItem>Ganado</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="frvTipoDeCarga" runat="server" ErrorMessage="El tipo de Carga es obligatoria"
                                    ControlToValidate="ddlTipoCarga"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                Kilaje:
                            </td>
                            <td>
                                <asp:TextBox ID="txtKilaje" MaxLength="30" runat="server" ></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="rfvKilaje" runat="server" ErrorMessage="El Kilaje es obligatorio"
                                    ControlToValidate="txtKilaje"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                Origen:
                            </td>
                            <td>
                                <asp:TextBox ID="txtOrigen" MaxLength="30" runat="server" ></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="rfvOrigen" runat="server" ErrorMessage="El Origen es obligatorio"
                                    ControlToValidate="txtOrigen"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                          <tr>
                            <td align="left">
                                Destino:
                            </td>
                            <td>
                                <asp:TextBox ID="txtDestino" MaxLength="30" runat="server" ></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="rfvDestino" runat="server" ErrorMessage="El Destino es obligatorio"
                                    ControlToValidate="txtDestino"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                               Fecha De Inicio:
                            </td>
                            <td>
                                <asp:TextBox ID="txtFechaInicio" MaxLength="12" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="rfvFechaInicio" runat="server" ErrorMessage="La Fecha de Inicio es obligatoria"
                                    ControlToValidate="txtFechaInicio"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                         <tr>
                            <td align="left">
                               Fecha de Finalización:
                            </td>
                            <td>
                                <asp:TextBox ID="txtFechaFinalización" MaxLength="30" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="rvfFechaFinalización" runat="server" ErrorMessage="La Fecha de Finalización es obligatoria"
                                    ControlToValidate="txtFechaFinalización"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                               Estado:
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlEstado" runat="server">
                                    <asp:ListItem>Propuesto</asp:ListItem>
                                    <asp:ListItem>En Curso</asp:ListItem>
                                    <asp:ListItem>Parado</asp:ListItem>
                                    <asp:ListItem>Finalizado</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="rfvEstado" runat="server" ErrorMessage="El Estado es obligatorio"
                                    ControlToValidate="ddlEstado"></asp:RequiredFieldValidator>
                            </td>
                        </tr>                                    
                         
                        <tr>
                            <td colspan="3" align="left">
                                <asp:Label ID="lblResultado" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" align="left">
                                <asp:Button ID="btnAltaViaje" Text="Alta" runat="server" OnClick="btnAltaViaje_Click" />
                                <asp:Button ID="btnModificarViaje" runat="server" Text="Modificar" OnClick="btnModificarViaje_Click" />
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
                                <asp:GridView ID="grdViajes" Width="100%" runat="server"
                                    ViewStateMode="Enabled" CellPadding="4" ForeColor="#333333" GridLines="None"
                                    AutoGenerateDeleteButton="True" OnRowDeleting="grdViajes_RowDeleting" AutoGenerateSelectButton="True"
                                    OnSelectedIndexChanging="grdViajes_SelectedIndexChanging" EmptyDataText="No hay datos ingresados"
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
                                <asp:GridView ID="grdCamioneros" Width="100%" runat="server" AutoGenerateColumns="true"
                                    ViewStateMode="Enabled" CellPadding="4" ForeColor="#333333" GridLines="None"
                                    AutoGenerateSelectButton="true"
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
                <table>
                        <tr>
                            <td>
                                <asp:GridView ID="grdCamiones" Width="100%" runat="server"
                                    ViewStateMode="Enabled" CellPadding="4" ForeColor="#333333" GridLines="None"
                                    AutoGenerateSelectButton="True"
                                    OnSelectedIndexChanging="grdCamiones_SelectedIndexChanging" EmptyDataText="No hay datos ingresados"
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