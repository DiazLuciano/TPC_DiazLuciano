<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exito.aspx.cs" Inherits="WEB.Exito" %>

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
            <div style="position:absolute; z-index:1;" id= "layer1">
                <div class="modal-body" style="margin: 30px 0px 0px 400px;">
                    <div class="row" style="margin-left:150px">
                          <div class="center-block">
                                <h1>Registro Exitoso</h1>
                            </div>
                        <div class="col-xs-6">
                            <div class="form-group">
                                <asp:Label ID="lblUser" runat="server" class="control-label"> Su nuevo Usuario es </asp:Label>
                                <asp:TextBox ID="txtUsuario" runat="server" Enabled="False" Width="180px"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="lblID" runat="server" class="control-label"> Su nuevo ID es </asp:Label>
                                <asp:TextBox ID="txtID" runat="server" Enabled="False" Width="180px"></asp:TextBox>
                            </div>
                            <div>
                                <asp:Button ID="btnRegresar"  runat="server" Text="Regresar" class="btn btn-danger form-control" OnClick="btnRegresar_Click"  />
                            </div>
                            </div>
                        </div>
                    </div>
                </div>
    </form>
</body>
</html>
