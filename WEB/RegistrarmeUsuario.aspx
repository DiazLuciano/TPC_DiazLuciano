<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarmeUsuario.aspx.cs" Inherits="WEB.RegistrarmeUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/Style.css" rel="stylesheet" />
    </head>
<body class="bg-black" style="background-image: url('Imagenes/TreeView.jpg')">
    <form id="form1" runat="server">

        <section class="content-header" style="text-align: center">
            <h1>Registro de Datos Personales</h1>
        </section>

        <section class="content">
            <div class="row">
                <div class="col-sm-4">
                    <div class="box box-primary" style="margin-left: 50px">
                        <div class="box-body">
                            <div class="form-group">
                                <label style="color: azure">ID CLIENTE</label>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtID" runat="server" Text="" BackColor="#CCCCCC" Width="100px" Enabled="False"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label style="color: azure">DOCUMENTO DE IDENTIDAD</label>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtDNI" runat="server" Text="" TextMode="Number"></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red" Font-Size="X-Large" Font-Bold="True" runat="server" ControlToValidate="txtDNI"
                                CssClass="field-validation-error" ErrorMessage="!" ValidationGroup="Registrar" />
                            </div>
                            <div class="form-group">
                                <label style="color: azure">NOMBRE</label>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtNombre" runat="server" Width="300px" Text=""></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red" Font-Size="X-Large" Font-Bold="True" runat="server" ControlToValidate="txtNombre"
                                CssClass="field-validation-error" ErrorMessage="!" ValidationGroup="Registrar" />
                            </div>
                            <div class="form-group">
                                <label style="color: azure">APELLIDO</label>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtApellido" runat="server" Width="300px" Text=""></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red" Font-Size="X-Large" Font-Bold="True" runat="server" ControlToValidate="txtApellido"
                                CssClass="field-validation-error" ErrorMessage="!" ValidationGroup="Registrar" />
                            </div>
                            <div class="form-group">
                                <label style="color: azure">DIRECCION</label>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtDireccion" runat="server" Width="300px" Text=""></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red" Font-Size="X-Large" Font-Bold="True" runat="server" ControlToValidate="txtDireccion"
                                CssClass="field-validation-error" ErrorMessage="!" ValidationGroup="Registrar" />
                            </div>
                            <div class="form-group">
                                <label style="color: azure">LOCALIDAD</label>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtLocalidad" runat="server" Width="300px" Text=""></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red" Font-Size="X-Large" Font-Bold="True" runat="server" ControlToValidate="txtLocalidad"
                                CssClass="field-validation-error" ErrorMessage="!" ValidationGroup="Registrar"/>
                            </div>
                            <div class="form-group">
                                <label style="color: azure">CÓDIGO POSTAL</label>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtCP" runat="server" Width="50px" Text="" TextMode="Number"></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red" Font-Size="X-Large" Font-Bold="True" runat="server" ControlToValidate="txtCP"
                                CssClass="field-validation-error" ErrorMessage="!" ValidationGroup="Registrar"/>
                            </div>
                            <div class="form-group">
                                <label style="color: azure">CIUDAD</label>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtCiudad" runat="server" Width="300px" Text=""></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red" Font-Size="X-Large" Font-Bold="True" runat="server" ControlToValidate="txtCiudad"
                                CssClass="field-validation-error" ErrorMessage="!" ValidationGroup="Registrar"/>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-sm-4">
                    <div class="box box-primary">
                        <div class="box-body">
                            <div class="form-group">
                                <label style="color: azure">PROVINCIA</label>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtProvincia" Width="300px" runat="server" Text=""></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red" Font-Size="X-Large" Font-Bold="True" runat="server" ControlToValidate="txtProvincia"
                                CssClass="field-validation-error" ErrorMessage="!" ValidationGroup="Registrar"/>
                            </div>
                            <div class="form-group">
                                <label style="color: azure">CUIL/CUIT</label>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtCUILCUIT" runat="server" Width="100px" Text=""></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red" Font-Size="X-Large" Font-Bold="True" runat="server" ControlToValidate="txtCUILCUIT"
                                CssClass="field-validation-error" ErrorMessage="!" ValidationGroup="Registrar"/>
                            </div>

                            <div class="form-group">
                                <label style="color: azure">FECHA</label>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtFecha" runat="server" Text="" Width="150px" TextMode="Date" ></asp:TextBox>
                                <asp:Button ID="btnCalcularEdad" runat="server" CssClass="btn btn-secondary" Width="150px" Text="Calcular Edad" BackColor="#6666FF" OnClick="btnCalcularEdad_Click" />
                            </div>
                            <div class="form-group">
                                <label style="color: azure">EDAD</label>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtEdad" runat="server" Text="" Width="50px" BackColor="#CCCCCC" Enabled="False" TextMode="Number"></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red" Font-Size="X-Large" Font-Bold="True" runat="server" ControlToValidate="txtEdad"
                                CssClass="field-validation-error" ErrorMessage="!" ValidationGroup="Registrar"/>
                            </div>
                            <div class="form-group">
                                <label style="color: azure">SEXO</label>
                            </div>
                            <div class="form-group">
                                <asp:DropDownList ID="ddlSexo" runat="server">
                                    <asp:ListItem>Masculino</asp:ListItem>
                                    <asp:ListItem>Femenino</asp:ListItem>
                                    <asp:ListItem>Otro</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <label style="color: azure">EMAIL</label>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtEmail" runat="server" Width="300px" Text=""></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red" Font-Size="X-Large" Font-Bold="True" runat="server" ControlToValidate="txtEmail"
                                CssClass="field-validation-error" ErrorMessage="!" ValidationGroup="Registrar"/>
                            </div>
                            <div class="form-group">
                                <label style="color: azure">TIPO TELÉFONO</label>
                            </div>
                            <div class="form-group">
                                <asp:DropDownList ID="ddlTipoTel" runat="server">
                                    <asp:ListItem>Celular</asp:ListItem>
                                    <asp:ListItem>Trabajo</asp:ListItem>
                                    <asp:ListItem>Casa</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <label style="color: azure">TELÉFONO</label>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtTelefono" runat="server" Width="100px" Text="" TextMode="Number"></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red" Font-Size="X-Large" Font-Bold="True" runat="server" ValidationGroup="Registrar" ControlToValidate="txtTelefono"
                                CssClass="field-validation-error" ErrorMessage="!" Display="Dynamic" />
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-sm-4">
                    <div class="box box-primary">
                        <div class="box-body">
                            <div style="margin-top:20px">
                                <asp:Button ID="btnRegistrar" ValidationGroup="Registrar" runat="server" class="btn btn-primary" style="font-size: large; width:200px" Text="Registrar" OnClick="btnRegistrar_Click" />
                                <br />
                                <br />
                                <br />
                                <asp:Button ID="btnRegresar" runat="server" class="btn btn-danger" style="font-size: large; width:200px" Text="Regresar" OnClick="btnRegresar_Click" OnClientClick="return confirm('¿Seguro desea salir el formulario?');" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </section>
        <section class="text-center">
           
        </section>
    </form>

    <%-- <form id="form1" runat="server">
        <h1 class="center"style="margin: 30px 0px 0px 400px;">Formulario de Registro</h1>
        <div class="modal-body" style="margin: 30px 0px 0px 400px;">
            <ul>
                <li>
                    <asp:TextBox runat="server" ID="Nombre" placeHolder="Dirección" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="Nombre"
                    CssClass="field-validation-error" ErrorMessage="El campo de Nombre es obligatorio." />
                    
                </li>
                <li>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="field-style field-split align-left" placeHolder="Dirección"></asp:TextBox>
                </li>
                <li>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="field-style field-split align-left" placeHolder="Dirección"></asp:TextBox>
                </li>
            </ul>
        </div>
        <%--<div class="panel-img">
            <img src="Imagenes/Panel.png" />
        </div>
        <div>
            <div style="position:absolute; z-index:1;" id= "layer1">
                <div class="modal-body" style="margin: 30px 0px 0px 400px;">
                    <div>
                         <fieldset>
                        <legend>Datos Personales</legend>
                        <ol>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="Nombre">Nombre</asp:Label>
                                <asp:TextBox runat="server" ID="Nombre" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="Nombre"
                                    CssClass="field-validation-error" ErrorMessage="El campo de nombre es obligatorio." />
                            </li>
                             <li>
                                <asp:Label runat="server" AssociatedControlID="Apellido">Apellido</asp:Label>
                                <asp:TextBox runat="server" ID="Apellido" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="Apellido"
                                    CssClass="field-validation-error" ErrorMessage="El campo de Apellido es obligatorio." />
                            </li>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="Email">Dirección de correo electrónico</asp:Label>
                                <asp:TextBox runat="server" ID="Email" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                                    CssClass="field-validation-error" ErrorMessage="El campo de dirección de correo es obligatorio." />
                            </li>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="Password">Contraseña</asp:Label>
                                <asp:TextBox runat="server" ID="Password" TextMode="Password" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                                    CssClass="field-validation-error" ErrorMessage="El campo de contraseña es obligatorio." />
                            </li>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="ConfirmPassword">Confirmar contraseña</asp:Label>
                                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                                     CssClass="field-validation-error" Display="Dynamic" ErrorMessage="El campo de confirmación de contraseña es obligatorio." />
                                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                                     CssClass="field-validation-error" Display="Dynamic" ErrorMessage="La contraseña y la contraseña de confirmación no coinciden." />
                            </li>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="Direccion">Dirección</asp:Label>
                                <asp:TextBox runat="server" ID="Direccion" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="Direccion"
                                    CssClass="field-validation-error" ErrorMessage="El campo de Direccion es obligatorio." />
                            </li>
                        </ol>
                        <asp:Button runat="server" CommandName="MoveNext" Text="Registrarse" />
                    </fieldset>
                            
                    </div>
                    </div>

                  
                </div>

            </div>--%>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>

</body>
</html>
