<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Ejemplo.Web.Login" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            height: 372px;
        }
        .auto-style2 {
            margin-top: 128px;
        }
        .auto-style3 {
            margin-top: 88px;
        }
        .auto-style4 {
            margin-top: 67px;
        }
        .auto-style5 {
            margin-top: 46px;
        }
        .auto-style6 {
            margin-bottom: 0px;
        }
        .auto-style7 {
            margin-top: 14px;
        }
    </style>
</head>
<body style="height: 475px">
    <form runat="server">
     <div class="page">
 <div class="header">
            <div class="title">
                <h1>
                    Login
                </h1>
            </div>
    </div>
    <div class="auto-style1">
        <p>
            <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
            <asp:TextBox ID="txtUsuarioLogin" runat="server" style="margin-left: 12px" CssClass="auto-style5" Width="129px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="txtContraseñaLogin" runat="server" style="margin-left: 12px" CssClass="auto-style4" Width="129px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Tipo"></asp:Label>
            <asp:TextBox ID="txtTipoLogin" runat="server" style="margin-left: 12px" CssClass="auto-style3" Height="16px" Width="129px"></asp:TextBox>
        </p>
        <asp:Button ID="btnAceptarLogin" runat="server" style="margin-left: 63px; " Text="Aceptar" Width="69px" CssClass="auto-style2" />
        </div>
        </div>
        
    </form>
</body>
</html>

