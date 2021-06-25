<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmInicioSesion.aspx.cs" MasterPageFile="~/Site.master"
    Inherits="Ejemplo.Web.Forms.frmInicioSesion" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .auto-style1 {
            width: 10px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        <center>Iniciar Sesión</center>
    </h2>
    <br />
    <center>
        <table>
            <tr>
                <td>
                    <table>
                        <tr>
                            <td align="left">
                                <asp:Label ID="lblUsuario" Text="Usuario:" runat="server"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                <asp:Label ID="lblContra" Text="Contraseña:" runat="server"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtPassword" MaxLength="50" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" align="left">
                                <asp:Label ID="lblResultado" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" align="left">
                                <center>
                                     <asp:Button ID="btnIniciarSesion" Text="Iniciar Sesion" runat="server" OnClick="btnIniciarSesion_Click"/>
                                     <asp:Button ID="btnCancelar" runat="server" Text="Cancelar"  OnClick="btnCancelar_Click"/>
                                </center>
                            </td>
                        </tr>
                        <tr>
                            <asp:RequiredFieldValidator ID="tfvUsuario" runat="server" ErrorMessage="El Usuario es obligatorio"
                                    ControlToValidate="txtUsuario"></asp:RequiredFieldValidator>
                        </tr>
                        <tr>
                            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="La contraseña es obligatoria"
                                    ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                        </tr>
                    </table>
                </td>
               
            </tr>
        </table>
    </center>
</asp:Content>


