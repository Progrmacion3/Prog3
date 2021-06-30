<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAgregarParada.aspx.cs" MasterPageFile="~/Site.master" 
     Inherits="Ejemplo.Web.Forms.frmAgregarParada" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">w
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
       
        Administración de Paradas - Viajes
    </h2>
    <br />
    <center>
        <table>
            <tr>
                <td class="auto-style1">
                    <table>
                        <tr>
                            <td align="left">Viaje:
                            </td>
                            <td colspan="3" align="left">
                                <asp:Label ID="lblIdViaje" runat="server"></asp:Label>
                            </td>
                            
                        </tr>
                        <tr>
                            <td align="left" class="auto-style2">Tipo:
                            </td>
                            <td colspan="3" align="left" class="auto-style2">
                                <asp:DropDownList ID="ddlTipo" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddlTipo_SelectedIndexChanged" >
                                    <asp:ListItem>Descanso</asp:ListItem>
                                    <asp:ListItem>Rotura</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                <asp:Label ID="lblComentario" Text="Comentario:" runat="server" Visible="False"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtComentario" MaxLength="150" runat="server" Visible="False" ></asp:TextBox>
                            </td>
                            <td>
                                
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" align="left">
                                <asp:Label ID="lblResultado" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" align="left">
                                <asp:Label ID="lblResultado2" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" align="left">
                                <asp:Label ID="lblResultado3" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" align="left">
                                <asp:Button ID="btnAgregarParada" Text="Alta" runat="server" Visible="false" OnClick="btnAgregarParada_Click" />
                                <asp:Button ID="btnCancelar" Text="Cancelar" runat="server" OnClick="btnCancelar_Click" />
                                
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
                                    AutoGenerateSelectButton="True"
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
                                <asp:GridView ID="grdParadas" Width="100%" runat="server" AutoGenerateColumns="true"
                                    ViewStateMode="Enabled" CellPadding="4" ForeColor="#333333" GridLines="None"
                                    AutoGenerateDeleteButton="true" OnRowDeleting="grdParadas_RowDeleting1" AutoGenerateSelectButton="true"
                                    OnSelectedIndexChanging="grdParadas_SelectedIndexChanging" EmptyDataText="No hay datos ingresados"
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
