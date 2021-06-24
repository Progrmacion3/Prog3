<%@ Page
  Title=""
  Language="C#"
  MasterPageFile="~/Administradores.master"
  AutoEventWireup="true"
  CodeBehind="wfrmIngresoUsuarios.aspx.cs"
  Inherits="Ejemplo.Web.FormularioIngresoUsuarios"
%>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
  <style type="text/css">
    .style1
    {
      width: 100%;
      height: 281px;
    }
    .style2
    {
      width: 201px;
    }
    .style4
    {
      width: 239px;
    }
    .style5
    {
      width: 262px;
      text-align: center;
    }
    .style6
    {
      width: 125px;
      height: 63px;
    }
    .style7
    {
      width: 265px;
      text-align: center;
    }
    .style8
    {
      text-align: center;
      height: 191px;
    }
    .style9
    {
      width: 125px;
      text-align: left;
      height: 63px;
    }
    .style10
    {
      width: 150px;
    }
    .style11
    {
      width: 231px;
    }
    .style13
    {
      width: 100%;
      height: 189px;
    }
    .style14
    {
      width: 262px;
      text-align: center;
      height: 63px;
    }
    .style15
    {
      width: 265px;
      text-align: center;
      height: 63px;
    }
    .style16
    {
      width: 150px;
      height: 29px;
    }
    .style17
    {
      width: 201px;
      height: 29px;
    }
    .style18
    {
      width: 231px;
      }
    .style19
    {
      width: 239px;
      height: 29px;
    }
  </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <table class="style1">
    <caption style="font-family: Arial, Helvetica, sans-serif; font-size: large; font-weight: bold; color: #000066">
      <br />
      INGRESO DE USUARIOS<br />
    </caption>
    <tr>
      <td class="style16">
        <asp:Label ID="lblTipo" runat="server" Text="Tipo" Style="font-family: 'Arial Black'"></asp:Label>
      </td>
      <td class="style17">
        <asp:RadioButton ID="rdbAdm" runat="server" Text="Administrador" Style="font-family: 'Arial Black'"
          OnCheckedChanged="rdbAdm_CheckedChanged" GroupName="TIPO" TabIndex="6" AutoPostBack="True" Checked="True" />
      </td>
      <td class="style18">
        <asp:RadioButton ID="rdbCamionero" runat="server" Text="Camionero" Style="font-family: 'Arial Black'"
          OnCheckedChanged="rdbAdm_CheckedChanged" GroupName="TIPO" TabIndex="7" AutoPostBack="True" />
      </td>
    </tr>
    <tr>
      <td class="style16">
        <asp:Label ID="lblId" runat="server" Text="Id" Style="font-family: 'Arial Black'"></asp:Label>
      </td>
      <td class="style17">
        <asp:TextBox ID="txtId" runat="server" Width="223px" TabIndex="1" AutoCompleteType="Disabled" Enabled="False"></asp:TextBox>
      </td>
      <td class="style18" rowspan="10">
          <asp:GridView ID="GridViewUsuarios" runat="server" AutoGenerateColumns="False" Width="433px" CellPadding="4" ForeColor="#333333" GridLines="None">
              <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
              <Columns>
                  <asp:BoundField DataField="id_usuario" HeaderText="ID"></asp:BoundField>
                  <asp:BoundField DataField="nombre" HeaderText="Nombre"></asp:BoundField>
                  <asp:BoundField DataField="apellido" HeaderText="Apellido"></asp:BoundField>
              </Columns>
              <EditRowStyle BackColor="#999999" />
              <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
              <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
              <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
              <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
              <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
              <sortedascendingcellstyle backcolor="#E9E7E2" />
              <sortedascendingheaderstyle backcolor="#506C8C" />
              <sorteddescendingcellstyle backcolor="#FFFDF8" />
              <sorteddescendingheaderstyle backcolor="#6F8DAE" />
          </asp:GridView>

        <asp:ListBox ID="lstUsuarios" runat="server"
          OnSelectedIndexChanged="lstUsuarios_SelectedIndexChanged"
          AutoPostBack="True" Height="101px" Width="332px" Font-Size="Small"></asp:ListBox>
          <br />
      </td>
    </tr>
    <tr>
      <td class="style10">
        <asp:Label ID="lblNombre" runat="server" Text="Nombre" Style="font-family: 'Arial Black'"></asp:Label>
      </td>
      <td class="style2">
        <asp:TextBox ID="txtNombre" runat="server" Width="223px" TabIndex="2"></asp:TextBox>
      </td>
    </tr>
    <tr>
      <td class="style10">
        <asp:Label ID="lblApellido" runat="server" Text="Apellido" Style="font-family: 'Arial Black'"></asp:Label>
      </td>
      <td class="style2">
        <asp:TextBox ID="txtApellido" runat="server" Width="223px" TabIndex="3"></asp:TextBox>
      </td>
    </tr>
    <tr>
      <td class="style10">
        <asp:Label ID="lblCedula" runat="server" Text="Cédula" Style="font-family: 'Arial Black'"></asp:Label>
      </td>
      <td class="style2">
        <asp:TextBox ID="txtCedula" runat="server" Width="223px" TabIndex="4"></asp:TextBox>
      </td>
    </tr>
    <tr>
      <td class="style10">
        <asp:Label ID="lblTelefono" runat="server" Text="Teléfono" Style="font-family: 'Arial Black'"></asp:Label>
      </td>
      <td class="style2">
        <asp:TextBox ID="txtTelefono" runat="server" Width="223px" TabIndex="5"></asp:TextBox>
      </td>
    </tr>

    <tr>
      <td class="style10">
        <asp:Label ID="lblUsuario" runat="server" Text="Usuario" Style="font-family: 'Arial Black'"></asp:Label>
      </td>
      <td class="style2">
        <asp:TextBox ID="txtUsuario" runat="server" Width="223px" TabIndex="5"></asp:TextBox>
      </td>
    </tr>
    <tr>
      <td class="style10">
        <asp:Label ID="lblContra" runat="server" Text="Contraseña" Style="font-family: 'Arial Black'"></asp:Label>
      </td>
      <td class="style2">
        <asp:TextBox ID="txtContra" runat="server" Width="223px" TabIndex="5"></asp:TextBox>
      </td>
    </tr>
    <tr>
      <td class="style10">
        <asp:Label ID="lblFecNac" runat="server" Text="Fecha Nacimiento" Style="font-family: 'Arial Black'" Visible="False"></asp:Label>
      </td>
      <td class="style2">
        <asp:TextBox ID="txtFecNac" runat="server" Width="223px" TabIndex="5" Visible="False"></asp:TextBox>
      </td>
    </tr>
    <tr>
      <td class="style10">
        <asp:Label ID="lblLibTipo" runat="server" Text="Tipo Libreta" Style="font-family: 'Arial Black'" Visible="False"></asp:Label>
      </td>
      <td class="style2">
        <asp:TextBox ID="txtLibTipo" runat="server" Width="223px" TabIndex="5" Visible="False"></asp:TextBox>
      </td>
    </tr>
    <tr>
      <td class="style10">
        <asp:Label ID="lblVencLib" runat="server" Text="Vencimiento Libreta" Style="font-family: 'Arial Black'" Visible="False"></asp:Label>
      </td>
      <td class="style2">
        <asp:TextBox ID="txtLibVenc" runat="server" Width="223px" TabIndex="5" Visible="False"></asp:TextBox>
      </td>
    </tr>
  </table>
  <br />
  <asp:Button ID="btnAlta" runat="server" Text="ALTA" OnClick="btnAlta_Click"
    Style="text-align: center" Width="115px" Height="45px" BackColor="#003366"
    BorderColor="#CCFFFF" Font-Bold="True" ForeColor="White"
    TabIndex="8" />
  &nbsp;
  <asp:Button ID="btnBaja" runat="server" Text="BAJA" OnClick="btnBaja_Click"
    Style="text-align: center" Width="115px" Height="45px" BackColor="#003366"
    BorderColor="#CCFFFF" Font-Bold="True" ForeColor="White"
    TabIndex="9" />
  &nbsp;
  <asp:Button ID="btnModificar" runat="server" Text="MODIFICAR"
    OnClick="btnModificar_Click" Style="text-align: center" Width="115px"
    Height="45px" BackColor="#003366"
    BorderColor="#CCFFFF" Font-Bold="True" ForeColor="White"
    TabIndex="10" />
  &nbsp;&nbsp;
  <asp:Button ID="btnLimpiar" runat="server" Text="LIMPIAR"
    OnClick="btnLimpiar_Click" Style="text-align: center" Width="115px"
    Height="45px" BackColor="#003366"
    BorderColor="#CCFFFF" Font-Bold="True" ForeColor="White"
    TabIndex="11" />
  &nbsp;&nbsp;
  <asp:Label ID="lblMensajes" runat="server" Style="font-family: 'Arial Black'"
    Text="." ForeColor="#CC0000"></asp:Label>
</asp:Content>


