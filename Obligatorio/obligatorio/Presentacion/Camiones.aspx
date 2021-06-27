<%@ Page enableEventValidation="false" Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Camiones.aspx.cs" Inherits="obligatorio.Presentacion.Camiones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Gestión de Camiones</h1>
    <form role="form">      <div class="form-group">          <br />        <label for="InputMarca">Marca</label>          <asp:TextBox runat="server" CssClass="form-control" ID="InputMarca" placeholder="Ingresa la marca"></asp:TextBox>      </div>      <div class="form-group">        <label for="InputModelo">Modelo</label>          <asp:TextBox runat="server" CssClass="form-control" ID="InputModelo" placeholder="Ingresa el modelo"></asp:TextBox>      </div>      <div class="form-group">        <label for="InputMatricula">Matrícula</label>          <asp:TextBox runat="server" CssClass="form-control" ID="InputMatricula" placeholder="Ingresa la matrícula"></asp:TextBox>      </div>      <div class="form-group">        <label for="InputAno">Año</label>          <asp:TextBox runat="server" CssClass="form-control" ID="InputAno" placeholder="Ingresa el año"></asp:TextBox>      </div>        <asp:Button ID="btnAlta" runat="server" OnClick="btnAlta_Click" Text="Alta" />
        <asp:Button ID="btnBaja" runat="server" Text="Baja" />
        <asp:Button ID="btnMod" runat="server" Text="Modificar" />
        <asp:Button ID="btnLimpiar" runat="server" OnClick="btnLimpiar_Click" Text="Limpiar" />
    </form>

</asp:Content>
