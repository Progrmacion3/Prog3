<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="obligatorio.Presentacion.Empleados"  EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <p> &nbsp; </p>

<form role="form">
  <div class="form-group">
    <label for="InputName">Nombre</label>
    <asp:TextBox runat="server" CssClass="form-control" ID="InputName"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="InputSecondName">Apellido</label>
    <asp:TextBox runat="server" CssClass="form-control" ID="InputSecondName"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="InputDocument">Cédula</label>
    <asp:TextBox runat="server" CssClass="form-control" ID="InputDocument"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="InputPosition">Cargo</label>
    <asp:TextBox runat="server" CssClass="form-control" ID="InputPosition"></asp:TextBox>
  </div>
  <div class="form-group">
      <label for="InputAge">Edad</label>
      <asp:TextBox runat="server" CssClass="form-control" ID="InputAge"></asp:TextBox>
  </div>
  <div class="form-group">
      <label for="InputPhone">Teléfono</label>
      <asp:TextBox runat="server" CssClass="form-control" ID="InputPhone"></asp:TextBox>
  </div>
  <div class="form-group">
      <label for="InputLicense">Tipo de libreta</label>
      <asp:TextBox runat="server" CssClass="form-control" ID="InputLicense"></asp:TextBox>
  </div>
  <div class="form-group">
      <label for="InputExpireDate">Fecha de vencimiento</label>
      <asp:Calendar ID="InputLicenseExpireDate" runat="server"></asp:Calendar>
      
  </div>
  <div class="form-group">
    <label for="InputUser">Usuario</label>
    <asp:TextBox runat="server" CssClass="form-control" ID="InputUser"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="InputPass">Contraseña</label>
    <asp:TextBox runat="server" type="password" CssClass="form-control" ID="InputPass"></asp:TextBox> 
  </div>
  <div class="checkbox">    
    <label>
      <asp:RadioButton runat="server" ID="rdoEmpleado" GroupName="checkbox" />Camionero<br />
    </label>
    <label>
    <asp:RadioButton runat="server" ID="rdoAdministrador" GroupName="checkbox" />Administrador<br />
      <br />
&nbsp;<asp:Button ID="btnAlta" runat="server" OnClick="btnAlta_Click" Text="Alta" />
&nbsp;&nbsp;&nbsp;
      <asp:Button ID="btnBaja" runat="server" OnClick="btnBaja_Click" Text="Baja" />
&nbsp;&nbsp;&nbsp;
      <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
&nbsp;&nbsp;&nbsp;
      <asp:Button ID="btnLimpiar" runat="server" OnClick="btnLimpiar_Click" Text="Limpiar" />
    </label>
  </div>
</form>

</asp:Content>
