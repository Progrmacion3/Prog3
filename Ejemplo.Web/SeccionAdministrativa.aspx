<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeccionAdministrativa.aspx.cs" Inherits="Ejemplo.Web.SeccionAdministrativa" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
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
        <h2>
            Bienvenido administrador
        </h2>
    <h3>
        En esta seccion usted esta habilitado para la gestion de viajes,empleados,camioneros,camiones y paradas.Usted tiene el control de todos los datos almacenados en el sistema 
    </h3>
   <h4>
       En la parte de abajo le daremos las instrucciones de como se realizan las gestiones de cada uno de los datos así que preste atención
   </h4>
    <p>
         Para agregar:ingrese los datos correspondientes 
    </p>
    <p>
        Para eliminar:ingrese el identificador de lo que desea eliminar(el primer dato a ingresar en la parte de arriba)
    </p>
    <p>
        Para modificar:ingrese el identificador de lo que desea modificar y despues ingrese en el resto de casillas los nuevos datos
    </p>
    </div>
    <div>
    <div class="footer">
    <h5>
        Ya teniendo todo lo basico puede empezar a cumplir su labor como administrador de la empresa, que tenga un buen día :)
    </h5>
    </div>
    </div>
    </form>
</body>
</html>

