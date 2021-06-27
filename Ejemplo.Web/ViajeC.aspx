<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViajeC.aspx.cs" Inherits="Ejemplo.Web.ViajeC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
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
                    Seccion Camionero
                 </h1>
        </div>
           
            <div class="clear hideSkiplink">
            <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
                <Items>

              <asp:MenuItem NavigateUrl="~/SeccionCamionero.aspx" Text="Pagina Principal"/>
              <asp:MenuItem NavigateUrl="~/ViajeC.aspx" Text="Viajes" />
              <asp:MenuItem NavigateUrl="~/ParadaC.aspx" Text="Camionero" />
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
