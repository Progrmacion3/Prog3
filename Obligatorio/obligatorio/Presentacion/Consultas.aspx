<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consultas.aspx.cs" Inherits="obligatorio.Presentacion.Consultas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <h1>Consultas</h1>

     <h3>Viajes y su información</h3>
    <asp:Button ID="btnC1" runat="server" Text="Ver" OnClick="btnC1_Click" />
    <h3>Viajes por camionero</h3>

    <form role="form">
      <div class="form-group">
          <br />
        <label for="InputCiCamionero">Introduzca la cédula del camionero</label>
          <asp:TextBox runat="server" CssClass="form-control" ID="InputCiCamionero" Height="36px" Width="224px"></asp:TextBox>
          <asp:Label ID="lblMissingMat" runat="server"></asp:Label>
      </div>
    </form>
       <asp:Button ID="btnC2" runat="server" Text="Ver" OnClick="btnC2_Click" />
   
       <asp:ListBox ID="lstViajesCamionero" runat="server" Height="122px" Width="280px" OnSelectedIndexChanged="lstViajesCamionero_SelectedIndexChanged"></asp:ListBox>

    <h3>Paradas</h3>
    <asp:TextBox runat="server" ID="txtParadaC3" Visible="false" Enabled="false"></asp:TextBox>
    <asp:Button ID="btnC3" runat="server" Text="Ver paradas" OnClick="btnC3_Click" />
    <br />
    <asp:Label runat="server" ID="lblMissingCamioneroC3" Text=""></asp:Label>
    <br />
    <label>Selecciona primero el viaje</label>
        <asp:GridView ID="grdViajeC3" runat="server" AutoGenerateColumns="true"
             AutoGenerateSelectButton="true" OnSelectedIndexChanging="grdViajeC3_SelectedIndexChanging" EmptyDataText="No hay viajes agregados." ></asp:GridView>
    <br />
    <label> Selecciona luego la parada</label>
           <asp:GridView ID="grdParadas" runat="server" AutoGenerateSelectButton="True"
            CellPadding="4" OnSelectedIndexChanging="grdParadas_SelectedIndexChanging"
            AutoGenerateColumns="true" EmptyDataText="No hay paradas para el viaje seleccionado.">
       </asp:GridView>
</asp:Content>
