<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IniciarSesion.aspx.cs" Inherits="Ejemplo.Web.Secciones.Login.IniciarSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" />
    <!-- JavaScript Bundle with Popper -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <link href="../../Styles/Login.css" rel="stylesheet" />
    <title></title>
</head>
<body class="bg-light">
    <div class="viewContainer">
        <div class="wrapper">
            <div class="frmContainer">
                <form id="frmLogin" runat="server">
                    <div class="form-control">
                        <div class="card-title">
                            <asp:Label class="h1" runat="server" ID="lblBienvenida" Text="Iniciar sesión"></asp:Label>
                        </div>
                        <div>
                            <asp:Label ID="lblUsuario" runat="server" Text="Usuario:"></asp:Label>
                            <asp:TextBox ID="txtUsuario" CssClass="form-control" runat="server" placeholder="Ingrese usuario..."></asp:TextBox>
                        </div>
                        <div>
                            <asp:Label ID="lblContraseña" runat="server" Text="Contraseña:"></asp:Label>
                            <asp:TextBox ID="txtContraseña" CssClass="form-control" runat="server" placeholder="Ingrese contraseña..."></asp:TextBox>
                        </div>
                        <div id="cajaCheckBox">
                        <asp:CheckBox runat="server" ID="ckbAdmin" Text="Admin"/>
                        <asp:CheckBox runat="server" ID="ckbCamionero" Text="Camionero"/>
                        </div>
                        <hr />
                        <div class="row">
                            <asp:Label runat="server" ID="lblError" CssClass="alert-danger"></asp:Label>
                        </div>
                        <br />
                        <div class="row">
                            <asp:Button ID="btnIniciarSesion" CssClass="btn btn-primary btn-dark" runat="server" Text="Iniciar sesión" OnClick="btnIniciarSesion_Click" />
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>
</body>
</html>
