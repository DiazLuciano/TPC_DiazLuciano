<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUser/User.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="WEB.CarritoCompra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
	<div class="row">
        
		<div class="col-md-12">
			<div class="jumbotron"  style="background-color:white">
				<table class="table-responsive">
				<tbody>
                    <tr>
                         <td class="auto-style19">
                            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=PROBOOK\SQLEXPRESS;Initial Catalog=DIAZ_DB;Integrated Security=True" SelectCommand="SELECT [TipoArticulo] FROM [articulos]"></asp:SqlDataSource>
                        </td>
                </tr>
                    <tr>
                        <td class="auto-style16">
                            <h3>Marcas</h3>
                            <div style="height: 400px; width: 200px; overflow: Auto; background: #ede7e7">
                                <asp:DataList ID="DataList2" runat="server" DataSourceID="SqlDataSource2" style="text-align: left" Width="147px">
                                    <ItemTemplate>
                                        <br />
                                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "~/PaginaUser/Catalogo.aspx?marca=" + Eval("marca") %>' Text='<%# Eval("marca") %>'></asp:HyperLink>
                                        <br />
                                    </ItemTemplate>
                                </asp:DataList>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <h3>Lista de Productos</h3>                                                       
                            <asp:Label ID="codproductoLabel" runat="server" Text='<%# Eval("ID") %>' />
                        </td>
                        <td>
                            <asp:ImageButton ID="ImageButton1" width="120" height="120" runat="server" ImageUrl="~/Imagenes/Carro.png"  />
                        </td>
                    </tr>               
					<tr>
						<td>							

						    <asp:DataList ID="DataList1" runat="server" DataKeyField="id" DataSourceID="SqlDataSource1" RepeatColumns="3" GroupItemCount="3"  CssClass="table table-responsive">
                                
                                <ItemTemplate>
                                    <asp:Image ID="Image1" width="140" height="120" runat="server" ImageUrl='<%# "~/Imagenes/"+Eval("Imagen") %>' CssClass="img-fluid" />
                                    <br />
                                    <br />
                                    Código :
                                    <asp:Label ID="codproductoLabel" runat="server" Text='<%# Eval("ID") %>' />
                                    <br />
                                    Producto :
                                    <asp:Label ID="desproductoLabel" runat="server" Text='<%# Eval("descripcion") %>' />
                                    <br />
                                    Categoria :
                                    <asp:Label ID="codcategoriaLabel" runat="server" Text='<%# Eval("marca") %>' />
                                    <br />
                                    Precio :
                                    <asp:Label ID="preproductoLabel" runat="server" Text='<%# Eval("preciocompra") %>' />
                                    <br />
                                    Cantidad :
                                    <asp:Label ID="canproductoLabel" runat="server" Text='<%# Eval("tipoarticulo") %>' />
                                    <br />
                                    <asp:Button ID="Button1" runat="server" CommandName="Seleccionar"  Text="Agregar al Carrito" CssClass="btn btn-success" />
                                    <br />
                                </ItemTemplate>
                            </asp:DataList>

						    <asp:SqlDataSource ID="SqlDataSourceCategorias" runat="server" ConnectionString="Data Source=PROBOOK\SQLEXPRESS;Initial Catalog=DIAZ_DB;Integrated Security=True" SelectCommand="SELECT * FROM [Articulos]"></asp:SqlDataSource>

						</td>						
					</tr>
                    <tr>
                        <td class="auto-style19">
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=PROBOOK\SQLEXPRESS;Initial Catalog=DIAZ_DB;Integrated Security=True" SelectCommand="SELECT [tipoarticulo] FROM [articulos]"></asp:SqlDataSource>
                        </td>
            <td class="auto-style20">
                <div style="background-position: 0% 0%; border-radius: 4px; background-image: linear-gradient(to bottom, rgba(0, 0, 0, 0), rgba(0, 0, 0, 0.3)); -webkit-box-shadow: inset 0 0 0 1px rgba(0, 0, 0, 0.2), 0 0 6px rgba(0, 0, 0, 0.4); box-shadow: inset 0 0 0 1px rgba(0, 0, 0, 0.2), 0 0 6px rgba(0, 0, 0, 0.4); height: 30px; color: #FFFFFF; background-color: #383838; background-repeat: repeat; background-attachment: scroll;">
                    <asp:TextBox ID="TextBox2" runat="server" style="margin-top:4px;" Width="213px"></asp:TextBox>
                    <asp:Button ID="Button3" runat="server" BorderStyle="Solid" CssClass="botones" Text="Buscar" Width="87px" UseSubmitBehavior="False" />
                    <asp:Button ID="Button4" runat="server" BorderStyle="Solid" CssClass="botones" PostBackUrl="~/Catalogo.aspx" Text="Todos" Width="87px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;
                          <asp:DataPager ID="DataPager1" runat="server" PageSize="12" >
                                        <Fields>
                                            <asp:NumericPagerField />
                                        </Fields>
                                    </asp:DataPager>
                    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" Height="22px" Width="65px">
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                    </asp:DropDownList>
                </div>
                &nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 

            </td>
            <td class="auto-style21"></td>
        </tr>
				</tbody>
			</table>
			</div>
		</div>
	</div>
</div>
</asp:Content>
