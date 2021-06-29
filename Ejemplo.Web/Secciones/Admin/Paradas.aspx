<%@ Page Title="Sección de Paradas." Language="C#" AutoEventWireup="true" CodeBehind="Paradas.aspx.cs" Inherits="Ejemplo.Web.Secciones.Admin.Paradas" MasterPageFile="~/Site.Master"%>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="MenuAdmin" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Paradas:</h2>
    <br />
    <asp:GridView ID="grdParadas" Width="93%" runat="server" AutoGenerateColumns="true" ViewStateMode="Enabled" CellPadding="5" ForeColor="#333333"
            EmptyDataText="No existen registros" ShowHeaderWhenEmpty="true" OnSelectedIndexChanged="grdParadas_SelectedIndexChanged">
        <EditRowStyle BackColor="#3399ff" />
        <FooterStyle BackColor="Black" Font-Bold="true" ForeColor="White" />
        <HeaderStyle BackColor="Black" Font-Bold="true" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="Black" />
        <SelectedRowStyle BackColor="#cccccc" ForeColor="Black" />
        <SortedAscendingCellStyle BackColor="#c0c0c0" />
        <SortedDescendingCellStyle BackColor="#c0c0c0" />
        <SortedDescendingHeaderStyle BackColor="White" />
    </asp:GridView>
    
</asp:Content>

