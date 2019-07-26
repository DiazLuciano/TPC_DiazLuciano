<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUser/User.Master" AutoEventWireup="true" CodeBehind="RegistroCompra.aspx.cs" Inherits="WEB.PaginaUser.RegistroCompra" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif; font-size: medium; color: #000000;">

        <table class="table" style="width: 100%;">
            <tr>
                <td colspan="3" aria-atomic="False" style="font-family: Arial; font-size: large; background-color: #3399FF;" class="text-center">REGISTRO DE PRODUCTO AL CARRITO</td>
            </tr>
            <tr>
                <td style="height: 20px; width: 208px;">Código:</td>
                <td style="height: 20px">
                    <asp:Label ID="lblIDPro" runat="server"></asp:Label>
                </td>
                <td style="height: 20px"></td>
            </tr>
            <tr>
                <td style="width: 208px">Descripción:</td>
                <td>
                    <asp:Label ID="lblDes" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="height: 20px; width: 208px;">Marca:</td>
                <td style="height: 20px">
                    <asp:Label ID="lblMarca" runat="server"></asp:Label>
                </td>
                <td style="height: 20px"></td>
            </tr>
            <tr>
                <td style="width: 208px">Categoría:</td>
                <td>
                    <asp:Label ID="lblCat" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 208px">Stock:</td>
                <td>
                    <asp:Label ID="lblStock" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 208px">Precio por Unidad:</td>
                <td aria-atomic="False">
                    <asp:Label ID="lblPrecio" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 208px">Cantidad:</td>
                <td>
                    <asp:TextBox ID="txtCantidad" runat="server" MaxLength="3" TextMode="Number"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 208px"></td>
                <td></td>
                <td></td>
            </tr>
        </table>
        <div>
            <table style="width: 100%; height: 40px;">
                <tr>
                    <td>
                        <asp:Button ID="btnAgregar" class="btn btn-primary" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnComprar" class="btn btn-success" runat="server" Text="Comprar" OnClick="btnComprar_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnRegresar" class="btn btn-danger" runat="server" Text="Regresar" OnClick="btnRegresar_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
