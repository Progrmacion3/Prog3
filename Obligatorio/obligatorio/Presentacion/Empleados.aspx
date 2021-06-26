
    <%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="obligatorio.Presentacion.Empleados" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
          
     <h1>Gestión de Empleados</h1>
  <form role="form">  <div class="form-group">    <label for="InputName">Nombre</label>    <asp:TextBox runat="server" CssClass="form-control" ID="InputName"></asp:TextBox>  </div>  <div class="form-group">    <label for="InputSecondName">Apellido</label>    <asp:TextBox runat="server" CssClass="form-control" ID="InputSecondName"></asp:TextBox>  </div>  <div class="form-group">    <label for="InputDocument">Cédula</label>    <asp:TextBox runat="server" CssClass="form-control" ID="InputDocument"></asp:TextBox>  </div>  <div class="form-group">    <label for="InputPosition">Cargo</label>    <asp:TextBox runat="server" CssClass="form-control" ID="InputPosition"></asp:TextBox>  </div>  <div class="form-control">
      <label for="InputTelefono">Teléfono</label>
      <asp:TextBox runat="server" CssClass="form-control" ID="InputTelefono"></asp:TextBox>
  </div>  <div class="form-group">    <label for="InputUser">Usuario</label>    <asp:TextBox runat="server" CssClass="form-control" ID="InputUser"></asp:TextBox>  </div>  <div class="form-group">    <label for="InputPass">Contraseña</label>    <asp:TextBox runat="server" type="password" CssClass="form-control" ID="InputPass"></asp:TextBox>   </div>  <div class="checkbox">         <div class="form-group">    <label for="InputPosition">Edad</label>    <asp:TextBox runat="server" CssClass="form-control" ID="InputEdad" Visible="False"></asp:TextBox>  </div>        <div class="form-group">    <label for="InputPosition">Tipo de Libreta</label>    <asp:TextBox runat="server" CssClass="form-control" ID="InputTipoLibreta" Visible="False"></asp:TextBox>  </div>        <div class="form-group">    <label for="InputPosition">Fecha de Vencimiento</label>    <asp:Calendar runat="server" ID="InputFechaVencimiento"></asp:Calendar>  </div>    <label>      <asp:RadioButton runat="server" ID="rdbCamionero" GroupName="checkbox" Text="Camionero" /> 
    <asp:RadioButton runat="server" ID="rdbAdministrador" GroupName="checkbox" Text="Administrador" /> <br />
&nbsp;<br />
      <br />
&nbsp;<asp:Button ID="btnAlta" runat="server" CssClass="btn-success" Text="Alta" />
&nbsp;&nbsp;&nbsp;
      <asp:Button ID="btnBaja" runat="server" Text="Baja" />
&nbsp;&nbsp;&nbsp;
      <asp:Button ID="btnModificar" runat="server" Text="Modificar" />
&nbsp;&nbsp;&nbsp;
      <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" />
      </label>  </div>    </form>

</asp:Content>

