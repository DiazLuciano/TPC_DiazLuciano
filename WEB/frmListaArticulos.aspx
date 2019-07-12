<%@ Page Title="" Language="C#" MasterPageFile="~/Admin1.Master" AutoEventWireup="true" CodeBehind="frmListaArticulos.aspx.cs" Inherits="WEB.frmListaArticulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section class ="content-header">
        <h1 style="text-align:center">ARTICULOS</h1>
    </section>

    <asp:GridView ID="dgvArticulos" runat="server" CssClass="table table-active " EmptyDataText="No Existen Registros"
        GridLines="Horizontal" AutoGenerateColumns ="false" OnRowCommand="dgvArticulos_RowCommand">
        <HeaderStyle CssClass ="" Font-Size="12px" />
            <AlternatingRowStyle CssClass="" Font-Size="12px" />
            <RowStyle Font-size ="12px" />
        <Columns>
            <asp:TemplateField HeaderText="CÓDIGO" HeaderStyle-width="30px">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lblCodigo" Text='<%# Eval("id")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="DESCRIPCION" HeaderStyle-width="30px">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lblDes" Text='<%# Eval("descripcion")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

             <asp:TemplateField HeaderText="MARCA" HeaderStyle-width="30px">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lblMar" Text='<%# Eval("marca")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

             <asp:TemplateField HeaderText="Precio Compra" HeaderStyle-width="30px">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lblPreC" Text='<%# Eval("precioCompra")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Precio Venta" HeaderStyle-width="30px">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lblPreV" Text='<%# Eval("precioventa")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="TIPO" HeaderStyle-width="30px">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lbltipo" Text='<%# Eval("tipoarticulo")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="FECHA ALTA" HeaderStyle-width="30px">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lblFecha" Text='<%# Eval("Fecha_Alta")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="ESTADO" HeaderStyle-width="30px">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lblEstado" Text='<%# Eval("Estado")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="ACCIONES" HeaderStyle-width="30px">
                <ItemTemplate>
                    <table>
                        <tr>
                            <td>
                                <asp:button runat="server" ID="btnEditar" height="30px" Text="Editar" CssClass="btn btn-danger" CommandName="EditarProducto" CommandArgument='<%# Eval("id")%>' />
                            </td>
                            <td>
                                <asp:button runat="server" ID="btnEliminar" height="30px" Text="Eliminar" CssClass="btn btn-danger" CommandName="EliminarProducto" CommandArgument='<%# Eval("id")%>'/>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
    </asp:GridView>
</asp:Content>
