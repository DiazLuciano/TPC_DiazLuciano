<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaAdmin/Admin.Master" AutoEventWireup="true" CodeBehind="Facturacion.aspx.cs" Inherits="WEB.PaginaAdmin.Facturacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <table style="width:100%;">
        <tr>
            <td class="text-center" style="font-size: large; " colspan="3"><strong>VENTA</strong></td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 143px; border-style: solid; border-width: 2px; padding: 1px 4px">
                <p>
                    Vendedor:</p>
            </td>
            <td style="border-style: solid; border-width: 2px; padding: 1px 4px">
                <p>
                    <asp:Label ID="lblVendedor" runat="server"></asp:Label>
                </p>
            </td>
            <td style="width: 161px; border-left-style: solid; border-right-style: solid">&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 143px; border-style: solid; border-width: 2px; padding: 1px 4px">
                <p>
                    DNI:</p>
            </td>
            <td style="border-style: solid; border-width: 2px; padding: 1px 4px">
                <p>
                    <asp:TextBox ID="txtDNI" runat="server" TextMode="Number"></asp:TextBox>
                </p>
            </td>
            <td style="width: 161px; border-left-style: solid; border-right-style: solid">
                <asp:Button ID="btnBuscarC" runat="server" Text="Buscar" OnClick="btnBuscarC_Click" />
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 143px; border-style: solid; border-width: 2px; padding: 1px 4px">
                <p>
                    Cliente:</p>
            </td>
            <td style="border-style: solid; border-width: 2px; padding: 1px 4px">
                <p>
                    <asp:Label ID="lblCliente" runat="server"></asp:Label>
                </p>
            </td>
            <td style="width: 161px; border-left-style: solid; border-right-style: solid">&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 143px; border-style: solid; border-width: 2px; padding: 1px 4px">
                <p>
                    Código Producto:</p>
            </td>
            <td style="border-style: solid; border-width: 2px; padding: 1px 4px">
                <p>
                    <asp:TextBox ID="txtCodPro" runat="server" TextMode="Number"></asp:TextBox>
                </p>
            </td>
            <td style="width: 161px; border-left-style: solid; border-right-style: solid">
                <asp:Button ID="btnBuscarP" runat="server" OnClick="btnBuscarP_Click" Text="Buscar" />
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 143px; border-style: solid; border-width: 2px; padding: 1px 4px">
                <p>
                    Descripcion:</p>
            </td>
            <td style="border-style: solid; border-width: 2px; padding: 1px 4px">
                <p>
                    <asp:Label ID="lblDesc" runat="server"></asp:Label>
                </p>
            </td>
            <td style="width: 161px; border-left-style: solid; border-right-style: solid">&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 143px; border-style: solid; border-width: 2px; padding: 1px 4px">
                <p>
                    Precio Venta:</p>
            </td>
            <td style="border-style: solid; border-width: 2px; padding: 1px 4px">
                <p>
                    <asp:Label ID="lblPrecio" runat="server"></asp:Label>
                </p>
            </td>
            <td style="width: 161px; border-left-style: solid; border-right-style: solid">&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 143px; border-style: solid; border-width: 2px; padding: 1px 4px">
                <p>
                    Stock:</p>
            </td>
            <td style="border-style: solid; border-width: 2px; padding: 1px 4px">
                <p>
                    <asp:Label ID="lblStock" runat="server"></asp:Label>
                </p>
            </td>
            <td style="width: 161px; border-left-style: solid; border-right-style: solid">&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 143px; border-style: solid; border-width: 2px; padding: 1px 4px">
                <p>
                    Cantidad:</p>
            </td>
            <td style="border-style: solid; border-width: 2px; padding: 1px 4px">
                <p>
                    <asp:TextBox ID="txtCant" runat="server" MaxLength="3" TextMode="Number"></asp:TextBox>
                </p>
            </td>
            <td style="width: 161px; border-left-style: solid; border-right-style: solid">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Width="100%" OnRowDeleting="GridView1_RowDeleting" >
                    <Columns>
                        <asp:CommandField ButtonType="Button" HeaderText="Acciones" ShowDeleteButton="True" ShowHeader="True" />
                    </Columns>
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 143px">Total: </td>
            <td>
                <asp:Label ID="lblTotal" runat="server"></asp:Label>
            </td>
            <td style="width: 161px">&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 143px">
                <asp:Button ID="btnColocar" runat="server" Text="Colocar" CommandName="colocar" OnClick="btnColocar_Click" />
            </td>
            <td>
                <asp:Button ID="btnFacturar" runat="server" Text="Facturar" OnClick="btnFacturar_Click" />
            </td>
            <td style="width: 161px">
                <asp:Button ID="btnSalir" runat="server" OnClick="btnSalir_Click" Text="Salir" />
            </td>
        </tr>
    </table>
</div>
</asp:Content>
