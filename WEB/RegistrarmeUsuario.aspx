<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarmeUsuario.aspx.cs" Inherits="WEB.RegistrarmeUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
      <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/Style.css" rel="stylesheet" />
</head>
<body class="bg-black" style="background-image:url('Imagenes/TreeView.jpg')">
    <form id="form1" runat="server">
        <div class="panel-img">
            <img src="Imagenes/Panel.png" />
        </div>
        <div>
            <div style="position:absolute; z-index:1;" id= "layer1">
                <div class="modal-body" style="margin: 30px 0px 0px 400px;">
                    <div>
                         <fieldset>
                        <legend>Formulario de registro</legend>
                        <ol>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="UserName">Nombre de usuario</asp:Label>
                                <asp:TextBox runat="server" ID="UserName" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName"
                                    CssClass="field-validation-error" ErrorMessage="El campo de nombre de usuario es obligatorio." />
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
                        </ol>
                        <asp:Button runat="server" CommandName="MoveNext" Text="Registrarse" />
                    </fieldset>
                            
                    </div>
                    </div>

                  
                </div>

            </div>
        </form>
        <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>

</body>
</html>
