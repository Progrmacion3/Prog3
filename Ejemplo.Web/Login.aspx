<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Ejemplo.Web.Login" %>

<head runat="server">
    <title></title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <asp:ContentPlaceHolder ID="HeadContent" runat="server">
    </asp:ContentPlaceHolder>
</head>
<body>
    <form id="form1" runat="server">
 <div class="header">
            <div class="title">
                <h1>
                    Login
                </h1>
            </div>
    </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
            <asp:TextBox ID="txtUsuarioLogin" runat="server" style="margin-left: 8px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="txtContraseñaLogin" runat="server" style="margin-left: 7px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Tipo"></asp:Label>
            <asp:TextBox ID="txtTipoLogin" runat="server" style="margin-left: 12px"></asp:TextBox>
        </p>
        <asp:Button ID="btnAceptarLogin" runat="server" style="margin-left: 63px; margin-top: 22px" Text="Aceptar" Width="69px" />
    </form>
</body>

