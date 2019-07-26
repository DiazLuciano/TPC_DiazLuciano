<%@ Page Title="" Language="C#" MasterPageFile="Admin1.Master" AutoEventWireup="true" CodeBehind="frmVerCompras.aspx.cs" Inherits="WEB.frmVerCompras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section class ="content-header">
        <h1 style="text-align:center">COMPRAS</h1>
    </section>
    <section>
         <div class="input-group">
             <asp:TextBox ID="txtDNI" runat="server" text="" CssClass="form-control" Width="200px"></asp:TextBox>
             <asp:Button ID="btnBuscar" runat="server" CssClass="btn btn-primary" Width="100px" Text="BUSCAR" OnClick="btnBuscar_Click" /> 
         </div>
    </section>
   
    <asp:GridView ID="dgvCompras" runat="server" CssClass="table table-active " EmptyDataText="No Existen Registros"
        GridLines="Horizontal" AutoGenerateColumns ="false" >
        <HeaderStyle CssClass ="" Font-Size="12px" />
            <AlternatingRowStyle CssClass="" Font-Size="12px" />
            <RowStyle Font-size ="12px" />
        <Columns>
            <asp:TemplateField HeaderText="NUM FACTURA" HeaderStyle-width="30px">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lblfac" Text='<%# Eval("numfac")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="FECHA DE COMPRA" HeaderStyle-width="30px">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lblfecha" Text='<%# Eval("fecha_fac")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

             <asp:TemplateField HeaderText="DNI" HeaderStyle-width="30px">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lbldni" Text='<%# Eval("idcliente")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

             <asp:TemplateField HeaderText="PRECIO" HeaderStyle-width="30px">
                <ItemTemplate>
                    <asp:Label runat="server"  ID="lblprecio" Text='<%# Eval("precioV")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

             <asp:TemplateField HeaderText="CANTIDAD" HeaderStyle-width="30px">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lblcant" Text='<%# Eval("cantvend")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <%--<asp:TemplateField HeaderText="NOMBRE" HeaderStyle-width="30px">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lblnombre" Text='<%# Eval("nombre")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>--%>

           <%-- <asp:TemplateField HeaderText="DESCRIPCION" HeaderStyle-width="30px">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lbldesc" Text='<%# Eval("descripcion")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>--%>

            <%--<asp:TemplateField HeaderText="IMPORTE" HeaderStyle-width="30px">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lblimporte" Text='<%# Eval("importe")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>--%>
        </Columns>
    </asp:GridView>
</asp:Content>
