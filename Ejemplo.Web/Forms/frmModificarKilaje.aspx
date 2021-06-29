<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmModificarKilaje.aspx.cs" MasterPageFile="~/Site.master"
    Inherits="Ejemplo.Web.Forms.frmModificarKilaje" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Actualización de Kilaje 
    </h2>
    <br />
        <table>
            <tr>
                <td>
                    <table>
                        <tr>
                            <td align="left">Viaje:
                            </td>
                            <td colspan="3" align="left">
                                <asp:Label ID="lblIdViaje" runat="server"></asp:Label>
                            </td>
                            
                        </tr>
                        <tr>
                            <td align="left">
                                <asp:Label ID="lblKilaje" Text="Nueno Kilaje:" runat="server" ></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtKilaje" MaxLength="150" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label ID="lblKilajeViejo" Visible="false" runat="server"></asp:Label>
                                <asp:RequiredFieldValidator ID="rfvKilaje" runat="server" ErrorMessage="Ingrese el nuevo Kialje"
                                    ControlToValidate="txtKilaje"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="left">Estado:
                            </td>
                            <td colspan="3" align="left">
                                <asp:DropDownList ID="ddlEstado" AutoPostBack="true" runat="server">
                                    <asp:ListItem>Parado</asp:ListItem>
                                    <asp:ListItem>En curso</asp:ListItem>
                                </asp:DropDownList>
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
                                <asp:Button ID="btnModificarKilaje" Text="Modificar" runat="server" Visible="false" OnClick="btnModificarKilaje_Click" />
                                <asp:Button ID="btnCancelar" Text="Cancelar" runat="server" OnClick="btnCancelar_Click" />
                                
                            </td>
                        </tr>
                    </table>
                </td>
             </tr>
            <td>
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
                </td>
        </table>
</asp:Content>
