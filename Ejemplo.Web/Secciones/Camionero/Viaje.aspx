<%@ Page Title="Seccion viaje" Language="C#" AutoEventWireup="true" CodeBehind="Viaje.aspx.cs" Inherits="Ejemplo.Web.Secciones.Camionero.Viaje" MasterPageFile="~/Site.master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="MenuCamionero" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Seccion de Viaje</h2>
    <p>
        <asp:Label ID="Label1" runat="server" Text="IdViaje"></asp:Label>
        <asp:TextBox ID="txtIdViaje" runat="server" Width="272px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblKilaje" runat="server" Text="Kilaje"></asp:Label>
        <asp:TextBox ID="txtKilaje" runat="server" Width="273px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label>
        <asp:DropDownList runat="server" ID="ddlEstado" Height="16px" Width="286px">
            <asp:ListItem>Propuesto</asp:ListItem>
            <asp:ListItem>En curso</asp:ListItem>
            <asp:ListItem>Parado</asp:ListItem>
            <asp:ListItem>Finalizado</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        <asp:Label ID="lblResultado" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" Width="355px" />
    </p>
    <p>
        <asp:GridView ID="grdViajes" Width="93%" runat="server" AutoGenerateColumns="true" ViewStateMode="Enabled" CellPadding="10" ForeColor="#333333"
        OnSelectedIndexChanging="grdViajes_SelectedIndexChanging" AutoGenerateSelectButton="true"
        EmptyDataText="No existen registros" ShowHeaderWhenEmpty="true">
        <EditRowStyle BackColor="#3399ff" />
        <FooterStyle BackColor="Black" Font-Bold="true" ForeColor="White" />
        <HeaderStyle BackColor="Black" Font-Bold="true" ForeColor="White" Font-Size="X-Small"/>
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="Black" HorizontalAlign="Center" Font-Size="X-Small"/>
        <SelectedRowStyle BackColor="#cccccc" ForeColor="Black" />
        <SortedAscendingCellStyle BackColor="#c0c0c0" />
        <SortedDescendingCellStyle BackColor="#c0c0c0" />
        <SortedDescendingHeaderStyle BackColor="White" />
        </asp:GridView>
    </p>
</asp:Content>
