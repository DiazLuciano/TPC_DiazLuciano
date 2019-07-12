<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaAdmin/Admin.Master" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="WEB.PaginaAdmin.Pedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <table style="width:100%;">
        <tr>
            <td class="text-center" colspan="3" style="font-size: large"><strong>LISTADO DE PEDIDOS POR CLIENTE</strong></td>
        </tr>
        <tr>
            <td class="text-left" style="font-size: large; width: 92px">DNI:</td>
            <td class="text-left" style="font-size: large">
                <asp:TextBox ID="txtDNI" runat="server" style="margin-left: 0" TextMode="Number"></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
            </td>
            <td class="text-left" style="font-size: large">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnPageIndexChanging="GridView1_PageIndexChanging" Width="100%">
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td style="width: 92px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</div>
</asp:Content>
