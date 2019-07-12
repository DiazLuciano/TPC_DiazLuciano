<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUser/User.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WEB.PaginaUser.Carrito1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>

        <table class="nav-justified">
            <tr>
                <td class="text-center" colspan="8" style="height: 20px; font-size: large"><strong>PRODUCTOS EN EL CARRITO</strong></td>
            </tr>
            <tr>
                <td colspan="8">
                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" OnRowDeleting="GridView1_RowDeleting" >
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Acciones" ShowHeader="True" Text="Eliminar" />
                        </Columns>
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
                </td>
            </tr>
            <tr>
                <td colspan="8">Importe Total:
                    <asp:Label ID="lblTotal" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="text-center" colspan="8" style="font-size: large"><strong>DATOS CLIENTE</strong></td>
            </tr>
            <tr>
                <td style="height: 22px; width: 105px" colspan="2">DNI Cliente: </td>
                <td colspan="4" style="height: 22px">
                    <asp:TextBox ID="txtDNI" runat="server" style="margin-left: 0" Width="281px" Enabled="False"></asp:TextBox>
                </td>
                <td style="height: 22px" colspan="2"></td>
            </tr>
            <tr>
                <td style="width: 98px">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Grabar" />
                </td>
                <td colspan="2" style="width: 98px">
                    &nbsp;</td>
                <td style="width: 98px">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Regresar" />
                </td>
                <td colspan="2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>

    </div>
</asp:Content>
