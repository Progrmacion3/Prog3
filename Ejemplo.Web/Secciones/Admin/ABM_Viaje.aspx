<%@ Page Title="Gestión de viajes" Language="C#" AutoEventWireup="true" CodeBehind="ABM_Viaje.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Ejemplo.Web.Secciones.Admin.ABM_Viaje" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="MenuAdmin" runat="server" ContentPlaceHolderID="MainContent">    
    <h2>Camioneros</h2>
    <br />

    <div id="Contenedor">
        <div id="ViewForm">
    <table>
        <tr>
            <td align="left">ID Viaje:
            </td>
            <td>
                <asp:TextBox ID="txtIdViaje" MaxLength="10" Enabled="false" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="left">ID Camionero:
            </td>
            <td>
                <asp:TextBox ID="txtIdCamionero" MaxLength="10" Enabled="false" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvIdCamionero" runat="server" ErrorMessage="El id del camionero es obligatorio" ControlToValidate="txtIdCamionero"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">ID Camion:
            </td>
            <td>
                <asp:TextBox ID="txtIdCamion" MaxLength="10" Enabled="false" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvIdCamion" runat="server" ErrorMessage="El id del camión es obligatorio" ControlToValidate="txtIdCamion"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">Tipo carga:
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlTipoCarga">
                    <asp:ListItem Value="Contenedor">Contenedor</asp:ListItem>
                    <asp:ListItem Value="Ganado">Ganado</asp:ListItem>
                    <asp:ListItem Value="Grano">Grano</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvTipoCarga" runat="server" ErrorMessage="El tipo de carga es obligatorio" ControlToValidate="ddlTipoCarga"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">Kilaje:
            </td>
            <td>
                <asp:TextBox ID="txtKilaje" onkeydown="return (!(event.keyCode>=65) && event.keyCode!=32);" MaxLength="10" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvKilaje" runat="server" ErrorMessage="El kilaje es obligatorio" ControlToValidate="txtKilaje"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">Origen:
            </td>
            <td>
                <asp:TextBox ID="txtOrigen" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvOrigen" runat="server" ErrorMessage="El origen es obligatorio" ControlToValidate="txtOrigen"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">Destino:
            </td>
            <td>
                <asp:TextBox ID="txtDestino" MaxLength="50" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvDestino" runat="server" ErrorMessage="El destino es obligatorio" ControlToValidate="txtDestino"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">Fecha de Inicio:
            </td>
            <td>
                <asp:TextBox ID="txtFechaInicio" MaxLength="10" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvFechaInicio" runat="server" ErrorMessage="La fecha es obligatoria" ControlToValidate="txtFechaInicio"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">Fecha de Finalizacion:
            </td>
            <td>
                <asp:TextBox ID="txtFechaFin" MaxLength="10" runat="server"></asp:TextBox>
            </td>
        </tr>
                <tr>
            <td align="left">Estado:
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlEstado">
                    <asp:ListItem>Propuesto</asp:ListItem>
                    <asp:ListItem>En curso</asp:ListItem>
                    <asp:ListItem>Parado</asp:ListItem>
                    <asp:ListItem>Finalizado</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvEstado" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="ddlEstado"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="3" align="left">
                <asp:Label ID="lblResultado" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3" align="left">
                <asp:Button ID="btnAgregar" Text="Agregar" runat="server" OnClick="btnAgregar_Click" />
                <asp:Button ID="btnEliminar" Text="Eliminar" runat="server" OnClick="btnEliminar_Click" />
                <asp:Button ID="btnModificar" Text="Modificar" runat="server" OnClick="btnModificar_Click" />
                <asp:Button ID="btnLimpiar" Text="Limpiar campos" runat="server" OnClick="btnLimpiar_Click" />
            </td>
        </tr>
    </table>
    </div>
        <div id="ViewListas">
            <h2 id="TituloCamiones">Camiones</h2>
            <br />
            <asp:GridView ID="grdCamiones" Width="93%" runat="server" AutoGenerateColumns="true" ViewStateMode="Enabled" CellPadding="5" ForeColor="#333333"
            OnSelectedIndexChanging="grdCamiones_SelectedIndexChanging" AutoGenerateSelectButton="true"
            EmptyDataText="No existen registros" ShowHeaderWhenEmpty="true">
                <EditRowStyle BackColor="#3399ff" />
                <FooterStyle BackColor="Black" Font-Bold="true" ForeColor="White" />
                <HeaderStyle BackColor="Black" Font-Bold="true" ForeColor="White" Font-Size="Medium" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="Black" HorizontalAlign="Center" Font-Size="Small" />
                <SelectedRowStyle BackColor="#cccccc" ForeColor="Black" />
                <SortedAscendingCellStyle BackColor="#c0c0c0" />
                <SortedDescendingCellStyle BackColor="#c0c0c0" />
                <SortedDescendingHeaderStyle BackColor="White" />
            </asp:GridView>
            <br />
            <h2>Camioneros:</h2>
            <br />
            <asp:GridView ID="grdCamioneros" Width="93%" runat="server" AutoGenerateColumns="true" ViewStateMode="Enabled" CellPadding="5" ForeColor="#333333"
                OnSelectedIndexChanging="grdCamioneros_SelectedIndexChanging" AutoGenerateSelectButton="true" OnRowCreated="grdCamioneros_RowCreated"
                EmptyDataText="No existen registros" ShowHeaderWhenEmpty="true">
                <EditRowStyle BackColor="#3399ff" />
                <FooterStyle BackColor="Black" Font-Bold="true" ForeColor="White" />
                <HeaderStyle BackColor="Black" Font-Bold="true" ForeColor="White" Font-Size="Medium" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="Black" HorizontalAlign="Center" Font-Size="Small" />
                <SelectedRowStyle BackColor="#cccccc" ForeColor="Black" />
                <SortedAscendingCellStyle BackColor="#c0c0c0" />
                <SortedDescendingCellStyle BackColor="#c0c0c0" />
                <SortedDescendingHeaderStyle BackColor="White" />
            </asp:GridView>
        </div>
    </div>
    <br />
    <h2>Viajes:</h2>
    <asp:GridView ID="grdViajes" Width="93%" runat="server" AutoGenerateColumns="true" ViewStateMode="Enabled" CellPadding="10" ForeColor="#333333"
        OnSelectedIndexChanging="grdViajes_SelectedIndexChanging" AutoGenerateSelectButton="true"
        EmptyDataText="No existen registros" ShowHeaderWhenEmpty="true">
        <EditRowStyle BackColor="#3399ff" />
        <FooterStyle BackColor="Black" Font-Bold="true" ForeColor="White" />
        <HeaderStyle BackColor="Black" Font-Bold="true" ForeColor="White" Font-Size="X-Small"/>
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="Black" HorizontalAlign="Center" Font-Size="X-Small"/>
        <SelectedRowStyle BackColor="#cccccc" ForeColor="Black" />
        <SortedAscendingCellStyle BackColor="#c0c0c0" />
        <SortedDescendingCellStyle BackColor="#c0c0c0" />
        <SortedDescendingHeaderStyle BackColor="White" />
    </asp:GridView>
</asp:Content>