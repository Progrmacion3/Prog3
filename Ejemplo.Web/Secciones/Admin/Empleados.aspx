<%@ Page Title="Sección de empleados" Language="C#" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="Ejemplo.Web.Secciones.Admin.Empleados" MasterPageFile="~/Site.master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Empleados:</h2>
    <br />
    
    <asp:GridView ID="grdEmpleados" Width="93%" runat="server" AutoGenerateColumns="true" ViewStateMode="Enabled" CellPadding="10" ForeColor="#333333"
        EmptyDataText="No existen registros" ShowHeaderWhenEmpty="true">
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
    <br />
    <h2>Ex Empleados:</h2>
    <br />
    <asp:GridView ID="grdExEmpleados" Width="93%" runat="server" AutoGenerateColumns="true" ViewStateMode="Enabled" CellPadding="10" ForeColor="#333333"        
        EmptyDataText="No existen registros" ShowHeaderWhenEmpty="true">
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

