﻿
    <%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="obligatorio.Presentacion.Empleados" EnableEventValidation="false" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
          
  <h1>Gestión de Empleados</h1>
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
          <label for="InputTelefono">Teléfono</label>
          <asp:TextBox runat="server" CssClass="form-control" ID="InputTelefono"></asp:TextBox>
      </div>
      <div class="form-group">
        <label for="InputUser">Usuario</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="InputUser"></asp:TextBox>
      </div>
      <div class="form-group">
        <label for="InputPass">Contraseña</label>
        <asp:TextBox runat="server" type="password" CssClass="form-control" ID="InputPass"></asp:TextBox> 
      </div>
        <div class="form-group">
        <label for="InputPosition">Edad</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="InputEdad"></asp:TextBox>
              <asp:Label ID="lblEdadNotNumber" runat="server"></asp:Label>
      </div>
            <div class="form-group">
        <label for="InputPosition">Tipo de Libreta</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="InputTipoLibreta"></asp:TextBox>
      </div>
      <div class="form-group">
        <label for="InputPosition">Fecha de Vencimiento</label>
        <asp:Calendar runat="server" ID="InputFechaVencimiento"></asp:Calendar>
      </div>
      <div class="checkbox">
          <asp:RadioButton ID="rdbCamionero" runat="server" Text="Camionero" />
          <asp:RadioButton ID="rdbAdministrador" runat="server" Text="Administrador" />
          <br />
    &nbsp;<asp:Label ID="lblRadioBtn" runat="server"></asp:Label>
          <br />
          <br />
     </div>
    <div>
&nbsp;<asp:Button ID="btnAlta" runat="server" CssClass="btn-success" Text="Alta" OnClick="btnAlta_Click"/>
&nbsp;&nbsp;&nbsp;
      <asp:Button ID="btnBaja" runat="server" Text="Baja" OnClick="btnBaja_Click" />
&nbsp;&nbsp;&nbsp;
      <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
&nbsp;&nbsp;&nbsp;
      <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click" />
          <br />
          <br />
          <asp:Label ID="lblDataOutput" runat="server"></asp:Label>
     </div>    

     <div>
         <asp:GridView ID="grdEmpleados" Width="100%" runat="server"
                                    ViewStateMode="Enabled" CellPadding="4" ForeColor="#333333" GridLines="None"
                                    AutoGenerateDeleteButton="true" OnRowDeleting="grdEmpleados_RowDeleting" AutoGenerateSelectButton="true"
                                    OnSelectedIndexChanging="grdEmpleados_SelectedIndexChanging" EmptyDataText="No hay datos ingresados"
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
     </div>
    </form>
</asp:Content>

