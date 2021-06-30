<%@ Page Title="Sección Paradas" Language="C#" AutoEventWireup="true" CodeBehind="Paradas.aspx.cs" Inherits="Ejemplo.Web.Secciones.Camionero.Paradas" MasterPageFile="~/Site.master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="MenuCamionero" runat="server" ContentPlaceHolderID="MainContent">
    <h2 style="margin-left: 40px"> Seccion de Paradas</h2>
    <p style="margin-left: 80px"><asp:Label ID="lblIdViaje" runat="server" Text="IdViaje"></asp:Label>
        <asp:TextBox ID="txtIdViaje" Enabled="false" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID="rfvIdViaje" ErrorMessage="El ID del viaje es obligatorio" ControlToValidate="txtIdViaje">
        </asp:RequiredFieldValidator>
    </p>
    <p style="margin-left: 80px">
        <asp:Label ID="lblParada" runat="server" Text="Tipo de parada"></asp:Label>
        <asp:DropDownList runat="server" ID="ddlTipoParada">
            <asp:ListItem Value="Descanso">Descanso</asp:ListItem>
            <asp:ListItem Value="Rotura">Rotura</asp:ListItem>
        </asp:DropDownList>
        
    </p>
    <p style="margin-left: 80px">
        <asp:Label ID="Label3" runat="server" Text="Comentario"></asp:Label>
    </p>
        <asp:TextBox style="margin-left: 80px" ID="txtComentario" TextMode="MultiLine" runat="server"></asp:TextBox>
    <p style="margin-left: 80px">
        <asp:Label ID="lblResultado" runat="server"></asp:Label>
    </p>
    <p style="margin-left: 80px">
        <asp:Button ID="btnAgregarParada" runat="server" Text="Agregar" Width="225px" OnClick="btnAgregarParada_Click" />
    </p>
    <p style="margin-left: 80px">
        <asp:GridView ID="grdViaje" runat="server" Width="93%" AutoGenerateColumns="true" ViewStateMode="Enabled" CellPadding="5" ForeColor="#333333"
        OnSelectedIndexChanging="grdParadas_SelectedIndexChanging" AutoGenerateSelectButton="true"
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