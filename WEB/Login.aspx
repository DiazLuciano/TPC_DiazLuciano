<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WEB.Login" %>

<!DOCTYPE html>

<html class="bg-black" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Acceso al Sistema</title>
   <%-- <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />
    <link href="css/AdminLTE.css" rel="stylesheet" type="text/css" />--%>
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
                    <div class="row">
                          <div class="center-block">
                                <asp:Label ID="lblMensaje" runat="server" Text="" />
                            </div>
                        <div class="col-xs-6">
                            <div class="form-group">
                                <label for="username" class="control-label">Usuario</label>
                                <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" placeholder="Ingrese Usuario"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="password" class="control-label">Contraeña</label>
                                <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password" CssClass="form-control" placeholder="Ingrese Contraseña"></asp:TextBox>
                                <br />
                                <asp:Button ID="btnIngresar" type="submit" runat="server" Text="Iniciar Sesión" class="btn btn-success btn-block" OnClick="btnIngresar_Click" />
                            </div>
                        </div>
                           <div class="col-xs-6">
                               <p class="lead">Registrate Ahora <span class="text-success">Gratis</span></p>
                               <ul class="list-unstyled">
                                   <li><span style="color:#FFFFFF;font-size:16px">Registrate si no tienes usuario</span></li>
                                   <li><span style="color:#FFFFFF;font-size:16px">Haz Click en el botón debajo</span></li>
                               </ul>
                                <p>
                                <a href="Registrarme.aspx" class="btn btn-info btn-block">Register for new user</a>
                                </p>
                            </div>
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
