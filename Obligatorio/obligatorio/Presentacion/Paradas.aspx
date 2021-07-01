﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Paradas.aspx.cs" Inherits="obligatorio.Presentacion.Paradas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
   <b> <asp:Label ID="Label1" runat="server" Text="Gestión paradas" Font-Size="Larger"></asp:Label></b>
       
    <br />
    <div class="form-group">
        <label for="ddlViaje">Viaje:</label>
        <asp:DropDownList runat="server" CssClass="form-control" ID="ddlViaje" AutoPostBack="True" OnSelectedIndexChanged="ddlViaje_SelectedIndexChanged"></asp:DropDownList>
        <asp:Label ID="lblMissingTrip" runat="server" Text=""></asp:Label>
    </div>
    <div class="form-group">
        <label for="txtRazon">Razón:</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtRazon"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="txtComentario">Comentario (opcional):</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtComentario"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="txtEstado">Actualizar Estado (Solo Admins):</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtEstado"></asp:TextBox>
    </div>
    <asp:Button ID="btnAlta" runat="server" Text="Alta" OnClick="btnAlta_Click" />
    <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
    <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click" />
    <br />
    <br />
    <asp:Label ID="lblDataOutput" runat="server" Text=""></asp:Label>

    <asp:GridView ID="grdParadas" runat="server" 
                        AutoGenerateColumns="True" AutoGenerateDeleteButton="True" 
                        AutoGenerateSelectButton="True" CellPadding="4" EmptyDataText="No hay datos" GridLines="None" ShowHeaderWhenEmpty="True" 
                        ViewStateMode="Enabled" OnRowDeleting="grdParadas_RowDeleting" OnSelectedIndexChanging="grdParadas_SelectedIndexChanging">
        </asp:GridView>
</asp:Content>
