<%@ Page Title="" Language="C#" MasterPageFile="~/Admin1.Master" AutoEventWireup="true" CodeBehind="frmCompras.aspx.cs" Inherits="WEB.frmCompras" ClientIDMode="Static" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <section class="content-header">
        <h1 align="left">VENTA</h1>
    </section>
    <section class="content">
        <div class ="row">
                <div class="col-md-6">
                    <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>LE ATIENDE</label>
                        </div>
                        <div class="input-group">
                            <asp:TextBox ID="txtLeAtiende" runat="server" text="" CssClass="form-control"></asp:TextBox>
                        </div>
                      
                        <div class="form-group">
                            <label>DOCUMENTO DE IDENTIDAD</label>
                        </div>
                        <div class="input-group">
                            <asp:TextBox ID="txtDNI" runat="server" text="" CssClass="form-control"></asp:TextBox>
                            <div class ="input-group-btn">
                                <asp:Button ID="btnBuscarDNI" runat="server" CssClass="btn btn-danger" Text="BUSCAR" OnClick="btnBuscarDNI_Click" />
                            </div>
                        <div class="form-group">
                            <label>NOMBRE</label>
                        </div>
                             <div class="form-group">
                            <asp:TextBox ID="txtNombre" runat="server" text="" CssClass="form-control" Enabled="False"></asp:TextBox>
                        </div>
                    </div>
                </div>
                </div>
                <div class="col-md-12">
                    <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>CODIGO PRODUCTO</label>
                        </div>
                        <div class="input-group">
                             <asp:TextBox ID="txtCodPro" runat="server" text="" CssClass="form-control"></asp:TextBox>
                            <div class ="input-group-btn">
                                <asp:Button ID="btnBuscarPro" runat="server" CssClass="btn btn-danger" Text="BUSCAR" OnClick="btnBuscarPro_Click" />
                            </div>
                        </div>
                         <div class="form-group">
                            <label>DESCRIPCION</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtDescripcion" runat="server" text="" CssClass="form-control" Enabled="False"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>PRECIO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtPrecio" runat="server" text="" CssClass="form-control" Enabled="False"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>CANTIDAD</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtCantidad" runat="server" text="" CssClass="form-control" OnTextChanged="txtCantidad_TextChanged" ToolTip="Aprete Enter para calcular Importe"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>TOTAL</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtTotal" runat="server" text="" CssClass="form-control" Enabled="False"></asp:TextBox>
                        </div>
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
                            <asp:Button ID="btnComprar" runat="server" CssClass="btn btn-primary" Width="200px" Text="COMPRAR" OnClick="btnComprar_Click" /> 
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

    



