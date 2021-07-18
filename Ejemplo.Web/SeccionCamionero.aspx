<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeccionCamionero.aspx.cs" 
    Inherits="Ejemplo.Web.SeccionCamionero" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            margin-top: 26px;
        }
    </style>
</head>
<body>
    <form runat="server">
     <div class="page">
       <div class="header">
         <div class="title">
                 <h1>
                    Seccion Camionero
                 </h1>
        </div>
           
            <div class="clear hideSkiplink">
            <asp:Menu ID="NavigationCam" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
                <Items>

              <asp:MenuItem NavigateUrl="~/SeccionCamionero.aspx" Text="Pagina Principal"/>
              <asp:MenuItem NavigateUrl="~/ViajeC.aspx" Text="Viajes" />
              <asp:MenuItem NavigateUrl="~/ParadaC.aspx" Text="Camionero" />
                </Items>
            </asp:Menu>
            </div>
    </div>
      <div class="main">
          <h2>
              Bienvenido camionero
          </h2>
          <p>
           Esta es su sección donde podra modificar datos de sus respectivas paradas tanto como del kilaje y estado de su respectivo viaje tan solo tiene que seleccionar el viaje o parada que quiere actualizar/modificar y listo
          </p>
       <p>
           <asp:Button ID="btnVolverLoginC" runat="server" Text="Volver al Login" OnClick="btnVolverLoginC_Click" CssClass="auto-style1" />
       </p>
    </div>
    <div class="footer">
        
    </div>
    </div>
    </form>
</body>
</html>
