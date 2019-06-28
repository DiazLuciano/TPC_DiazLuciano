<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frmListaClientes.aspx.cs" Inherits="WEB.frmListaClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section class ="content-header">
        <h1 style="text-align:center">CLIENTES</h1>
    </section>
    
    <asp:GridView ID="dgvClientes" runat="server" CssClass="table table-active " EmptyDataText="No Existen Registros"
        GridLines="Horizontal" AutoGenerateColumns ="false" OnRowCommand="dgvClientes_RowCommand">
        <HeaderStyle CssClass ="" Font-Size="12px" />
            <AlternatingRowStyle CssClass="" Font-Size="12px" />
            <RowStyle Font-size ="12px" />
        <Columns>
            <asp:TemplateField HeaderText="ID" HeaderStyle-width="30px">
                <ItemTemplate>
                    <asp:Label runat="server"  Text='<%# Eval("ID")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="DNI" HeaderStyle-width="30px">
                <ItemTemplate>
                    <asp:Label runat="server"  Text='<%# Eval("DNI")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

             <asp:TemplateField HeaderText="NOMBRE" HeaderStyle-width="30px">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lblMar" Text='<%# Eval("NOMBRE")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

             <asp:TemplateField HeaderText="APELLIDO" HeaderStyle-width="30px">
                <ItemTemplate>
                    <asp:Label runat="server"  Text='<%# Eval("APELLIDO")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="GENERO" HeaderStyle-width="30px">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%# Eval("GENERO")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="FNAC" HeaderStyle-width="30px">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%# Eval("FNAC")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="EDAD" HeaderStyle-width="30px">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lblFecha" Text='<%# Eval("EDAD")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="EMAIL" HeaderStyle-width="30px">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lblEstado" Text='<%# Eval("EMAIL")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="ACCIONES" HeaderStyle-width="30px">
                <ItemTemplate>
                    <table>
                        <tr>
                            <td>
                                <asp:button runat="server" ID="btnEditar" height="30px" Text="Editar" CssClass="btn btn-danger" CommandName="EditarCliente" CommandArgument='<%# Eval("id")%>'  />
                            </td>
                            <td>
                                <asp:button runat="server" ID="btnEliminar" height="30px" Text="Eliminar" CssClass="btn btn-danger" CommandName="EliminarCliente" CommandArgument='<%# Eval("id")%>' />
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
