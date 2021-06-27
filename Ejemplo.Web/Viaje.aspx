<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Viaje.aspx.cs" Inherits="Ejemplo.Web.Viaje" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en">
<head runat="server">
    <title></title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form runat="server">
    <div class="page">
        <div class="header">
            <div class="title">
                <h1>
                    Seccion Administrativa
                </h1>
            </div>
           
            <div class="clear hideSkiplink">
            <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
                <Items>

              <asp:MenuItem NavigateUrl="~/SeccionAdministrativa.aspx" Text="Pagina Principal"/>
              <asp:MenuItem NavigateUrl="~/Camion.aspx" Text="Camion" />
              <asp:MenuItem NavigateUrl="~/Camionero.aspx" Text="Camionero" />
              <asp:MenuItem NavigateUrl="~/Empleado.aspx" Text="Empleado" />
              <asp:MenuItem NavigateUrl="~/Parada.aspx" Text="Parada" />
              <asp:MenuItem NavigateUrl="~/Viaje.aspx" Text="Viaje" />
                </Items>
            </asp:Menu>
            </div>
      </div>
    <div class="main">
    </div>
    <div class="footer">
        
    </div>
    </div>
    </form>
</body>
</html>
