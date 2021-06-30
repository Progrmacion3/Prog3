<%@ Page Title="Sección roturas" Language="C#" AutoEventWireup="true" CodeBehind="Roturas.aspx.cs" Inherits="Ejemplo.Web.Secciones.Camionero.Roturas" MasterPageFile="~/Site.master"%>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="MenuCamionero" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Seccion de Roturas</h2>
    <p>
        <asp:Label ID="lblIdViaje" runat="server" Text="IdViaje"></asp:Label>

        <asp:TextBox ID="txtIdViaje" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" Width="199px" />
    </p>
    <asp:GridView ID="grdParadas" Width="93%" runat="server" AutoGenerateColumns="true" ViewStateMode="Enabled" CellPadding="5" ForeColor="#333333"
            EmptyDataText="No existen registros" ShowHeaderWhenEmpty="true" OnRowCreated="grdParadas_RowCreated">
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
