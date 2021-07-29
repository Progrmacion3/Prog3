<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeccionLogin.aspx.cs" Inherits="Ejemplo.Web.SeccionLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div class="auto-style1">
            <div class="title">
                <h1>
                    Login
                </h1>
            </div>
    </div>
    <div>
      <h2>
          Bienvenido/a!!
      </h2>
        <h3>
            Para finalizar seleccione su sección correspondiente dandole click a uno de los dos botones.
            Recuerde que segun nuestras normas si ingresa a la sección que no le corresponde y la utiliza 
            sin previo aviso o charla con sus superiores
            se le penalizara por ello 
            y en el peor de los casos será despedido,
            usted ya ha sido advertido
        </h3>

        <asp:Button ID="btnSeccionAdmin" runat="server" Text="Sección Administrativa" OnClick="btnSeccionAdmin_Click" /> ---->Sección para los administradores
        <asp:Button ID="btnSeccionCam" runat="server" Text="Sección Camionero" OnClick="btnSeccionCam_Click" /> ----->Sección para los camioneros
    </div>
    </form>
</body>
</html>
