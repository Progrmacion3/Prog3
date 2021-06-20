<%@ Page Title="" Language="C#" MasterPageFile="~/Administradores.master" AutoEventWireup="true" CodeBehind="wfrmIngresoUsuarios.aspx.cs" Inherits="Ejemplo.Web.FormularioIngresoUsuarios" %>
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
                <asp:Label ID="lblTipo" runat="server" Text="Tipo" style="font-family: 'Arial Black'"></asp:Label>
            </td>
            <td class="style17">
                <asp:RadioButton ID="rdbAdm" runat="server" Text="Administrador" style="font-family: 'Arial Black'"
                oncheckedchanged="rdbAdm_CheckedChanged" GroupName="TIPO" TabIndex="6" AutoPostBack="True" Checked="True" />
            </td>
            <td class="style18">
                <asp:RadioButton ID="rdbCamionero" runat="server" Text="Camionero" style="font-family: 'Arial Black'"
                oncheckedchanged="rdbAdm_CheckedChanged" GroupName="TIPO" TabIndex="7" AutoPostBack="True" />
            </td>
        </tr>
        <tr>
            <td class="style16">
                <asp:Label ID="lblId" runat="server" Text="Id" style="font-family: 'Arial Black'"></asp:Label>
            </td>
            <td class="style17">
                <asp:TextBox ID="txtId" runat="server" Width="223px" TabIndex="1" AutoCompleteType="Disabled" OnTextChanged="txtId_TextChanged" Enabled="False"></asp:TextBox>
            </td>
            <td class="style18" rowspan="10">
                <asp:ListBox ID="lstUsuarios" runat="server" 
                onselectedindexchanged="lstUsuarios_SelectedIndexChanged" 
                AutoPostBack="True" Height="246px" Width="332px" Font-Size="Small"></asp:ListBox>
            </td>
        </tr>
        <tr>
            <td class="style10">
                <asp:Label ID="lblNombre" runat="server" Text="Nombre" style="font-family: 'Arial Black'"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="txtNombre" runat="server" Width="223px" TabIndex="2" OnTextChanged="txtNombre_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10">
                <asp:Label ID="lblApellido" runat="server" Text="Apellido" style="font-family: 'Arial Black'"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="txtApellido" runat="server" Width="223px" TabIndex="3" OnTextChanged="txtApellido_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10">
                <asp:Label ID="lblCedula" runat="server" Text="Cédula" style="font-family: 'Arial Black'"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="txtCedula" runat="server" Width="223px" TabIndex="4" OnTextChanged="txtCedula_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10">
            <asp:Label ID="lblTelefono" runat="server" Text="Teléfono" style="font-family: 'Arial Black'"></asp:Label>
            </td>
            <td class="style2">
            <asp:TextBox ID="txtTelefono" runat="server" Width="223px" TabIndex="5" OnTextChanged="txtTelefono_TextChanged"></asp:TextBox>
            </td>
        </tr>

        <tr>
           <td class="style10">
                <asp:Label ID="lblUsuario" runat="server" Text="Usuario" style="font-family: 'Arial Black'"></asp:Label>
                </td>
                <td class="style2">
                <asp:TextBox ID="txtUsuario" runat="server" Width="223px" TabIndex="5" OnTextChanged="txtUsuario_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10">
               <asp:Label ID="lblContra" runat="server" Text="Contraseña" style="font-family: 'Arial Black'"></asp:Label>
                </td>
                <td class="style2">
                <asp:TextBox ID="txtContra" runat="server" Width="223px" TabIndex="5" OnTextChanged="txtContra_TextChanged"></asp:TextBox>
                </td>

        </tr>
        <tr>
             <td class="style10">
               <asp:Label ID="lblFecNac" runat="server" Text="Fecha Nacimiento" style="font-family: 'Arial Black'" Visible="False"></asp:Label>
                </td>
                <td class="style2">
                <asp:TextBox ID="txtFecNac" runat="server" Width="223px" TabIndex="5" OnTextChanged="txtFecNac_TextChanged" Visible="False"></asp:TextBox>
                </td>
        </tr>
        <tr>
             <td class="style10">
               <asp:Label ID="lblLibTipo" runat="server" Text="Tipo Libreta" style="font-family: 'Arial Black'" Visible="False"></asp:Label>
                </td>
                <td class="style2">
                <asp:TextBox ID="txtLibTipo" runat="server" Width="223px" TabIndex="5" OnTextChanged="txtLibTipo_TextChanged" Visible="False"></asp:TextBox>
                </td>
        </tr>
        <tr>
             <td class="style10">
               <asp:Label ID="lblVencLib" runat="server" Text="Vencimiento Libreta" style="font-family: 'Arial Black'" Visible="False"></asp:Label>
                </td>
                <td class="style2">
                <asp:TextBox ID="txtLibVenc" runat="server" Width="223px" TabIndex="5" OnTextChanged="txtLibVenc_TextChanged" Visible="False"></asp:TextBox>
                </td>
        </tr>
    </table>
    <br />
<asp:Button ID="btnAlta" runat="server" Text="ALTA" onclick="btnAlta_Click" 
         style="text-align: center" Width="115px" Height="45px" BackColor="#003366" 
                    BorderColor="#CCFFFF" Font-Bold="True" ForeColor="White" 
        TabIndex="8" />
&nbsp;
<asp:Button ID="btnBaja" runat="server" Text="BAJA" onclick="btnBaja_Click"  
        style="text-align: center" Width="115px" Height="45px" BackColor="#003366" 
                    BorderColor="#CCFFFF" Font-Bold="True" ForeColor="White" 
        TabIndex="9" />
&nbsp;
<asp:Button ID="btnModificar" runat="server" Text="MODIFICAR" 
        onclick="btnModificar_Click"  style="text-align: center" Width="115px" 
        Height="45px" BackColor="#003366" 
                    BorderColor="#CCFFFF" Font-Bold="True" ForeColor="White" 
        TabIndex="10"/>
&nbsp;&nbsp;
<asp:Button ID="btnLimpiar" runat="server" Text="LIMPIAR" 
        onclick="btnLimpiar_Click"  style="text-align: center" Width="115px" 
        Height="45px" BackColor="#003366" 
                    BorderColor="#CCFFFF" Font-Bold="True" ForeColor="White" 
        TabIndex="11" />
&nbsp;&nbsp;
    <asp:Label ID="lblMensajes" runat="server" style="font-family: 'Arial Black'" 
        Text="." ForeColor="#CC0000"></asp:Label>





</asp:Content>
