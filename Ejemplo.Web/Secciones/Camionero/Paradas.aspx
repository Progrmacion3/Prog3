<%@ Page Title="Sección Paradas" Language="C#" AutoEventWireup="true" CodeBehind="Paradas.aspx.cs" Inherits="Ejemplo.Web.Secciones.Camionero.Paradas" MasterPageFile="~/Site.master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="MenuCamionero" runat="server" ContentPlaceHolderID="MainContent">
    <h2 style="margin-left: 40px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Seccion de Paradas</h2>
    <p style="margin-left: 80px">&nbsp;<asp:Label ID="Label1" runat="server" Text="IdViaje"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtIdViaje" runat="server" Height="20px" style="margin-left: 47px" Width="225px"></asp:TextBox>
    </p>
    <p style="margin-left: 80px">
        <asp:Label ID="Label2" runat="server" Text="Tipo de parada"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList runat="server" ID="ddlTipoParada" Height="16px" Width="237px" OnSelectedIndexChanged="ddlEstado_SelectedIndexChanged">
            <asp:ListItem>Descanso</asp:ListItem>
            <asp:ListItem>Rotura</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p style="margin-left: 80px">
        <asp:Label ID="Label3" runat="server" Text="Comentario"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtComentario" runat="server" Height="20px" style="margin-left: 3px" Width="225px"></asp:TextBox>
    </p>
    <p style="margin-left: 80px">
        <asp:Button ID="btnAgregarParada" runat="server" Text="Agregar" Width="342px" OnClick="btnAgregarParada_Click" />
    </p>
    <p style="margin-left: 80px">
        <asp:GridView ID="GridView1" runat="server" Width="338px">
        </asp:GridView>
    </p>
    <p style="margin-left: 80px">
        <asp:Label ID="lblResultado" runat="server" Text="Label"></asp:Label>
    </p>
    <p style="margin-left: 80px">&nbsp;</p>
</asp:Content>