<%@ Page Title="Seccion viaje" Language="C#" AutoEventWireup="true" CodeBehind="Viaje.aspx.cs" Inherits="Ejemplo.Web.Secciones.Camionero.Viaje" MasterPageFile="~/Site.master"%>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="MenuCamionero" runat="server" ContentPlaceHolderID="MainContent">
    <h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Seccion de Viaje</h2>
    <p>
        <asp:Label ID="Label1" runat="server" Text="IdViaje"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtIdViaje" runat="server" Width="272px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Kilaje"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtKilaje" runat="server" Width="273px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Estado"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList runat="server" ID="ddlEstado" Height="16px" Width="286px">
                    <asp:ListItem>Propuesto</asp:ListItem>
                    <asp:ListItem>En curso</asp:ListItem>
                    <asp:ListItem>Parado</asp:ListItem>
                    <asp:ListItem>Finalizado</asp:ListItem>
                </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="btnActualizar" runat="server" OnClick="Button1_Click" Text="Actualizar" Width="355px" />
    </p>
    <p>
        <asp:ListBox ID="ListBox1" runat="server" Width="359px"></asp:ListBox>
    </p>
    <p>
        <asp:Label ID="lblResultado" runat="server" Text="Label"></asp:Label>
    </p>
    <p>&nbsp;</p>
</asp:Content>
