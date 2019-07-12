<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrarme.aspx.cs" Inherits="WEB.Registrarme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registrarme</title>
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
                    <div style="margin-left:150px">
                        <h1>Registro de Usuario</h1>
                            <div class="form-group">
                                <label for="Usuario" class="control-label">Usuario</label>
                                <asp:TextBox ID="txtNombre1" runat="server" CssClass="form-control" placeholder="Ingrese Nombre Usuario"></asp:TextBox>
                                <span class="help-block"></span>
                            </div>
                            <div class="form-group">
                                <label for="password" class="control-label">Password</label>
                                <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password" CssClass="form-control" placeholder="Ingrese Contraseña"></asp:TextBox>
                                <span class="help-block"></span>
                            </div>
                            <div class="form-group">
                                <asp:Button ID="btnSiguiente" type="submit" runat="server" Text="Siguiente" class="btn btn-success btn-block" OnClick="btnSiguiente_Click" />
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
