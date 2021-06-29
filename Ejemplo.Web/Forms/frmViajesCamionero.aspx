<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmViajesCamionero.aspx.cs" MasterPageFile="~/Site.master" 
    Inherits="Ejemplo.Web.Forms.frmViajesCamionero" %>

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
       
        Viajes por Camionero
    </h2>
    <br />
    <center>
        <table>
            <tr>
                <td class="auto-style1">
                    <table>
                         
                        <tr>
                            <td align="left">
                                <asp:Label ID="lblCedula" Text="Cedula del Camionero:" runat="server" Visible="True"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtCedula" MaxLength="150" runat="server" Visible="True" ></asp:TextBox>
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
                                <asp:Button ID="btnListar" Text="Listar" runat="server" OnClick="btnListar_Click" />                                
                                
                            </td>
                        </tr>
                    </table>
                </td>
             </tr>
            <td class="auto-style1">
                  <table>
                        <tr>
                            <td>
                                <asp:GridView ID="grdViajesCamionero" Width="100%" runat="server" AutoGenerateColumns="true"
                                    ViewStateMode="Enabled" CellPadding="4" ForeColor="#333333" GridLines="None"
                                    EmptyDataText="No hay datos ingresados"
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

