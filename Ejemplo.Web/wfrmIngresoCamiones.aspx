<%@ Page Title="" Language="C#" MasterPageFile="~/Administradores.master" AutoEventWireup="true" CodeBehind="wfrmIngresoCamiones.aspx.cs" Inherits="Ejemplo.Web.FormularioIngresoCamiones" %>
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
            INGRESO DE  CAMIONES<br />
        </caption>
       
        <tr>
            <td class="style16">
                <asp:Label ID="lblId" runat="server" Text="Id" style="font-family: 'Arial Black'"></asp:Label>
            </td>
            <td class="style17">
                <asp:TextBox ID="txtId" runat="server" Width="223px" TabIndex="1" AutoCompleteType="Disabled" OnTextChanged="txtId_TextChanged" Enabled="False" Height="38px"></asp:TextBox>
            </td>
            <td class="style18" rowspan="10">
                <asp:ListBox ID="lstCamiones" runat="server" 
                onselectedindexchanged="lstCamiones_SelectedIndexChanged" 
                AutoPostBack="True" Height="246px" Width="332px" Font-Size="Small"></asp:ListBox>
            </td>
        </tr>
        <tr>
            <td class="style10">
                <asp:Label ID="lblMarca" runat="server" Text="Marca" style="font-family: 'Arial Black'"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="txtMarca" runat="server" Width="223px" TabIndex="2" OnTextChanged="txtMarca_TextChanged" Height="38px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10">
                <asp:Label ID="lblModelo" runat="server" Text="Modelo" style="font-family: 'Arial Black'"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="txtModelo" runat="server" Width="223px" TabIndex="3" OnTextChanged="txtModelo_TextChanged" Height="38px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10">
                <asp:Label ID="lblMatricula" runat="server" Text="Matrícula" style="font-family: 'Arial Black'"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="txtMatricula" runat="server" Width="223px" TabIndex="4" OnTextChanged="txtMatricula_TextChanged" Height="38px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10">
            <asp:Label ID="lblAnio" runat="server" Text="Año" style="font-family: 'Arial Black'"></asp:Label>
            </td>
            <td class="style2">
            <asp:TextBox ID="txtAnio" runat="server" Width="223px" TabIndex="5" OnTextChanged="txtAnio_TextChanged" Height="39px"></asp:TextBox>
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