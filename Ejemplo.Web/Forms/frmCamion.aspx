﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCamion.aspx.cs" MasterPageFile="~/Site.master"
 Inherits="Ejemplo.Web.Forms.frmCamion" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .auto-style1 {
            height: 180px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Administración de Camiones
    </h2>
    <br />
    <center>
        <table>
            <tr>
                <td class="auto-style1">
                    <table>
                        <tr>
                            <td align="left">
                                Matricula:
                            </td>
                            <td>
                                <asp:TextBox ID="txtMatricula" MaxLength="30" runat="server" ></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="frvMatricula" runat="server" ErrorMessage="La Matricula es obligatoria"
                                    ControlToValidate="txtMatricula"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                Marca:
                            </td>
                            <td>
                                <asp:TextBox ID="txtMarca" MaxLength="30" runat="server" ></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="rfvMarca" runat="server" ErrorMessage="La Marca es obligatoria"
                                    ControlToValidate="txtMarca"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                Modelo:
                            </td>
                            <td>
                                <asp:TextBox ID="txtModelo" MaxLength="30" runat="server" ></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="rfvModelo" runat="server" ErrorMessage="El Modelo es obligatorio"
                                    ControlToValidate="txtModelo"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                               Año:
                            </td>
                            <td>
                                <asp:TextBox ID="txtYear" MaxLength="4" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="rfvYear" runat="server" ErrorMessage="El Año es obligatorio"
                                    ControlToValidate="txtYear"></asp:RequiredFieldValidator>
                            </td>
                        </tr>

                        <tr>
                            <td colspan="3" align="left">
                                <asp:Label ID="lblResultado" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" align="left">
                                <asp:Button ID="btnAgregar" Text="Agregar" runat="server" OnClick="btnAltaCamion" />
                                <asp:Button ID="btnActualizar" runat="server" Text="Modificar" Visible="false" OnClick="btnModificarCamion_Click" />
                                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Visible="false" OnClick="btnCancelar_Click" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="auto-style1">
                    <table>
                        <tr>
                            <td>
                                <asp:GridView ID="grdCamion" Width="100%" runat="server" AutoGenerateColumns="true"
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
                    </table>
                </td>
            </tr>
        </table>
    </center>
</asp:Content>

