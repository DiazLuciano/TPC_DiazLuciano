<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaAdmin/Admin.Master" AutoEventWireup="true" CodeBehind="ModificarArticulo.aspx.cs" Inherits="WEB.PaginaAdmin.ModificarArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section class ="content-header">
        <h1 style="text-align:center">REGISTRO PRODUCTOS</h1>
    </section>
    <section class="content">
        <div class ="row">
                <div class="col-md-6">
                    <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>ID</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtID" runat="server" text="" CssClass="form-control" Enabled="False"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>DESCRIPCION</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtDescripcion" runat="server" text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>MARCA</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtMarca" runat="server" text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>PRECIO COMPRA</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtPrecioC" runat="server" text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>PRECIO VENTA</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtPrecioV" runat="server" text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>TIPO ARTICULO</label>
                        </div>
                        <div class="form-group">
                            <asp:DropDownList ID="ddlTipoArt" runat="server" CssClass="form-control">
                                <asp:ListItem>Inmuebles</asp:ListItem>
                                <asp:ListItem>Tecnologia</asp:ListItem>
                                 <asp:ListItem>Comida</asp:ListItem>
                                <asp:ListItem>Ropa y accesorios</asp:ListItem>
                                 <asp:ListItem>Electrodomesticos</asp:ListItem>
                                <asp:ListItem>Herramientas </asp:ListItem>
                                <asp:ListItem>Otro... </asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
              
                    </div>
                 </div>
             </div>
        <div class="row">
            <div align="center">
                <table>
                    <tr>
                        <td>
                            <asp:Button ID="btnRegistrar" runat="server" CssClass="btn btn-primary" Width="200px" Text="REGISTRAR" OnClick="btnRegistrar_Click"/>  
                        </td>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                        <td>
                            <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-danger" Width="200px" Text="CANCELAR" OnClick="btnCancelar_Click" />  
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </section>
</asp:Content>
