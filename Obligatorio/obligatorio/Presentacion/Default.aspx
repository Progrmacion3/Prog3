﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="obligatorio._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Camión Feroz</h1>
        <p class="lead"> Programita to piola para la camionera "Camión Feroz"</p>
    </div>

    <div class="loginContainer">
        <h2>Login</h2>
        <label for="InputUser">User</label>
        <label for="InputContra">Contraseña</label>
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
    </div>

    </asp:Content>