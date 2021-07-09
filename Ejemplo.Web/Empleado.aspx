<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empleado.aspx.cs" Inherits="Ejemplo.Web.Empleado" %>

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
            Administración de los empleados
        </h2>
        <table>
              <tr>
            <td align="left"> Cedula de identidad del empleado:
            </td>
            <td>
                <asp:TextBox ID="txtCI" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvCI" runat="server" ErrorMessage="La cedula de identidad del empleado es obligatorio"
                    ControlToValidate="txtCI"></asp:RequiredFieldValidator>
            </td>
        </tr>
          <tr>
            <td align="left"> Nombre del empleado:
            </td>
            <td>
                <asp:TextBox ID="txtNombreEmp" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvNombreEmp" runat="server" ErrorMessage="El nombre del empleado es obligatorio"
                    ControlToValidate="txtNombreEmp"></asp:RequiredFieldValidator>
            </td>
        </tr>
              <tr>
            <td align="left"> Apellido del empleado:
            </td>
            <td>
                <asp:TextBox ID="txtApellidoEmp" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvApellidoEmp" runat="server" ErrorMessage="El apellido del empleado es obligatorio"
                    ControlToValidate="txtApellidoEmp"></asp:RequiredFieldValidator>
            </td>
        </tr>
               <tr>
            <td align="left"> Cargo del empleado:
            </td>
            <td>
                <asp:TextBox ID="txtCargo" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvCargo" runat="server" ErrorMessage="El cargo del empleado es obligatorio"
                    ControlToValidate="txtCargo"></asp:RequiredFieldValidator>
            </td>
        </tr>
              <tr>
            <td align="left"> Tipo de empleado:
            </td>
            <td>
                <asp:TextBox ID="txtTipoEmp" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvTipoEmp" runat="server" ErrorMessage="El tipo del empleado es obligatorio"
                    ControlToValidate="txtTipoEmp"></asp:RequiredFieldValidator>
            </td>
        </tr>
              <tr>
            <td align="left"> Usuario del empleado:
            </td>
            <td>
                <asp:TextBox ID="txtUsuario" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" ErrorMessage="El usuario del empleado es obligatorio"
                    ControlToValidate="txtUsuario"></asp:RequiredFieldValidator>
            </td>
        </tr>
              <tr>
            <td align="left"> Contraseña del empleado:
            </td>
            <td>
                <asp:TextBox ID="txtContraseña" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvContraseña" runat="server" ErrorMessage="La contraseña del empleado es obligatorio"
                    ControlToValidate="txtContraseña"></asp:RequiredFieldValidator>
            </td>
        </tr>
              <tr>
            <td align="left"> Telefono del empleado:
            </td>
            <td>
                <asp:TextBox ID="txtTelefono" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ErrorMessage="El telefono del empleado es obligatorio"
                    ControlToValidate="txtTelefono"></asp:RequiredFieldValidator>
            </td>
        </tr>
             <tr>
            <td colspan="3" align="left" class="auto-style1">
              <asp:Label ID="lblResultadoEmpleado" runat="server" Text="." ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
           <td colspan="3" align="left" class="auto-style1">
            <asp:Label ID="lblIdEmpleado" runat="server" Text="." ForeColor="Red"></asp:Label>
          </td>
        </tr>
             <tr>
                  <td>
                         <asp:Button ID="btnAgregarEmpleado" runat="server" Text="Agregar" OnClick="btnAgregarEmpleado_Click" />
                         <asp:Button ID="btnEliminarEmpleado" runat="server" Text="Eliminar" OnClick="btnEliminarEmpleado_Click" Visible="false"/>
                         <asp:Button ID="btnModificarEmpleado" runat="server" Text="Modificar" OnClick="btnModificarEmpleado_Click" Visible="false"/>
                         <asp:GridView ID="grillaEmpleados" Width="100%" runat="server" AutoGenerateColumns="true"
                                    ViewStateMode="Enabled" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="true" 
                                    OnSelectedIndexChanging="grillaEmpleados_SelectedIndexChanging"
                                    EmptyDataText="No hay datos ingresados"
                                    ShowHeaderWhenEmpty="True">
                                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                    <EditRowStyle BackColor="#999999" />
                                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                                </asp:GridView>
                      </td>
                </tr>
        </table>
    </div>
    </div>
    </form>
</body>
</html>
