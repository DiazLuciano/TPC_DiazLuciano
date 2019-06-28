<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frmClientes.aspx.cs" Inherits="WEB.frmClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class ="content-header">
        <h1 style="text-align:center">REGISTRO CLIENTES</h1>
    </section>
    <section class="content">
        <div class ="row">
                <div class="col-md-6">
                    <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>ID CLIENTE</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtID" runat="server" text="" CssClass="form-control" Enabled="False"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>DOCUMENTO DE IDENTIDAD</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtDNI" runat="server" text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>NOMBRES</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtNombre" runat="server" text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>APELLIDO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtApellido" runat="server" text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>DIRECCION</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtDireccion" runat="server" text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>LOCALIDAD</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtLocalidad" runat="server" text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>CÓDIGO POSTAL</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtCP" runat="server" text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>CIUDAD</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtCiudad" runat="server" text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>PROVINCIA</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtProvincia" runat="server" text="" CssClass="form-control"></asp:TextBox>
                        </div>
                         <div class="form-group">
                            <label>TIPO PERSONA</label>
                        </div>
                        <div class="form-group">
                            <asp:DropDownList ID="ddlTipoPersona" runat="server" CssClass="form-control">
                                <asp:ListItem>Físico</asp:ListItem>
                                <asp:ListItem>Jurídico</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>CUIL/CUIT</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtCUILCUIT" runat="server" text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        
                         <div class="form-group">
                            <label>FECHA</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtFecha" runat="server" text="" CssClass="form-control" TextMode="Date"></asp:TextBox>
                            <asp:Button ID="btnCalcularEdad" runat="server" CssClass="btn btn-secondary" Width="150px" Text="Calcular Edad" BackColor="#6666FF" OnClick="btnCalcularEdad_Click" /> 
                        </div>
                        <div class="form-group">
                            <label>EDAD</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtEdad" runat="server" text="" CssClass="form-control" BackColor="#CCCCCC" Enabled="False" TextMode="Number"></asp:TextBox>
                        </div>
                    </div>
                </div>
                </div>
                <div class="col-md-6">
                    <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>SEXO</label>
                        </div>
                        <div class="form-group">
                            <asp:DropDownList ID="ddlSexo" runat="server" CssClass="form-control">
                                <asp:ListItem>Masculino</asp:ListItem>
                                <asp:ListItem>Femenino</asp:ListItem>
                                <asp:ListItem>Otro</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                         <div class="form-group">
                            <label>EMAIL</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtEmail" runat="server" text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>RAZÓN SOCIAL</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtRazonS" runat="server" text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        
                        <div class="form-group">
                            <label>TIPO TELÉFONO</label>
                        </div>
                        <div class="form-group">
                            <asp:DropDownList ID="ddlTipoTel" runat="server" CssClass="form-control">
                                <asp:ListItem>Celular</asp:ListItem>
                                <asp:ListItem>Trabajo</asp:ListItem>
                                <asp:ListItem>Casa</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>TELÉFONO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtTelefono" runat="server" text="" CssClass="form-control"></asp:TextBox>
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
                            <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-danger" Width="200px" Text="CANCELAR" OnClick="btnCancelar_Click"/>  
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </section>
</asp:Content>
