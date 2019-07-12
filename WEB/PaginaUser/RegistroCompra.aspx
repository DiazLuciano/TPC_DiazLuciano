<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUser/User.Master" AutoEventWireup="true" CodeBehind="RegistroCompra.aspx.cs" Inherits="WEB.PaginaUser.RegistroCompra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>

        <table style="width:100%;">
            <tr>
                <td colspan="3">REGISTRO DE PRODUCTO AL CARRITO</td>
            </tr>
            <tr>
                <td style="height: 20px">Código:</td>
                <td style="height: 20px">
                    <asp:Label ID="lblIDPro" runat="server"></asp:Label>
                </td>
                <td style="height: 20px"></td>
            </tr>
            <tr>
                <td>Descripción:</td>
                <td>
                    <asp:Label ID="lblDes" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="height: 20px">Marca:</td>
                <td style="height: 20px">
                    <asp:Label ID="lblMarca" runat="server"></asp:Label>
                </td>
                <td style="height: 20px"></td>
            </tr>
            <tr>
                <td>Categoría:</td>
                <td>
                    <asp:Label ID="lblCat" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Stock:</td>
                <td>
                    <asp:Label ID="lblStock" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Precio por Unidad:</td>
                <td aria-atomic="False">
                    <asp:Label ID="lblPrecio" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Cantidad:</td>
                <td>
                    <asp:TextBox ID="txtCantidad" runat="server" MaxLength="3" TextMode="Number"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                </td>
                <td>
                    <asp:Button ID="btnComprar" runat="server" Text="Comprar" OnClick="btnComprar_Click" />
                </td>
                <td>
                    <asp:Button ID="btnRegresar" runat="server" Text="Regresar" OnClick="btnRegresar_Click" />
                </td>
            </tr>
        </table>

    </div>
</asp:Content>
