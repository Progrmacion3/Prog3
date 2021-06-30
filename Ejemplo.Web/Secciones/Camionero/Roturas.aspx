<%@ Page Title="Sección roturas" Language="C#" AutoEventWireup="true" CodeBehind="Roturas.aspx.cs" Inherits="Ejemplo.Web.Secciones.Camionero.Roturas" MasterPageFile="~/Site.master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="MenuCamionero" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Seccion de Roturas</h2>
    <br />
    <hr />
    <asp:GridView ID="grdParadas" Width="93%" runat="server" AutoGenerateColumns="true" ViewStateMode="Enabled" CellPadding="5" ForeColor="#333333"
        EmptyDataText="No existen registros" ShowHeaderWhenEmpty="true" OnUnload="grdParadas_Unload" OnRowCreated="grdParadas_RowCreated">
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
    <hr />
    <p>
        <asp:Label ID="lblIdViaje" runat="server" Text="IdViaje"></asp:Label>

        <asp:TextBox ID="txtIdViaje" runat="server" Enabled="false"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" Width="199px" />
    </p>
    <h3>Seleccione su viaje...</h3>

    <asp:GridView ID="grdViajes" Width="93%" runat="server" AutoGenerateColumns="true" ViewStateMode="Enabled" CellPadding="5" ForeColor="#333333"
        OnSelectedIndexChanging="grdViajes_SelectedIndexChanging" AutoGenerateSelectButton="true"
        EmptyDataText="No existen registros" ShowHeaderWhenEmpty="true">
        <EditRowStyle BackColor="#3399ff" />
        <FooterStyle BackColor="Black" Font-Bold="true" ForeColor="White" />
        <HeaderStyle BackColor="Black" Font-Bold="true" ForeColor="White" Font-Size="X-Small" />
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="Black" HorizontalAlign="Center" Font-Size="X-Small" />
        <SelectedRowStyle BackColor="#cccccc" ForeColor="Black" />
        <SortedAscendingCellStyle BackColor="#c0c0c0" />
        <SortedDescendingCellStyle BackColor="#c0c0c0" />
        <SortedDescendingHeaderStyle BackColor="White" />
    </asp:GridView>

</asp:Content>
