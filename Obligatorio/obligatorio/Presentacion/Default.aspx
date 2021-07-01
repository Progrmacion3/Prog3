<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="obligatorio._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Camión Feroz</h1>
        <p class="lead"> admin admin para logearse como admin (se requiere la base de datos)</p>
    </div>

    <div class="loginContainer">
        <h2>Login</h2>
        <label for="InputUser">User</label>          <asp:TextBox runat="server" CssClass="form-control" ID="InputUser" placeholder="Ingresa su user"></asp:TextBox>
        <label for="InputContra">Contraseña</label>          <asp:TextBox TextMode="Password" runat="server" CssClass="form-control" ID="InputContra" placeholder="Ingresa su Contraseña"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /> <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
    </div>

    </asp:Content>
