<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUser/User.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="WEB.CarritoCompra" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ListarArticulos" TypeName="Negocio.ArticuloNegocio"></asp:ObjectDataSource>
    <asp:SqlDataSource ID="SqlDataSourceTodosProductos" runat="server" ConnectionString="<%$ ConnectionStrings:DIAZ_DBConnectionString %>" SelectCommand="SELECT [ID], [Descripcion], [Marca], [TipoArticulo], [PrecioVenta], [Imagen] FROM [Articulos]"></asp:SqlDataSource>
        <nav class="navbar navbar-dark bg-dark" style="background-color: #383838">
            <div class="form-inline my-2 my-lg-0" style="text-align:right;margin-top:5px">
            <asp:TextBox ID="txtBusqueda"  class="form-control mr-sm-2" type="search" placeholder="Search" aria-label="Search" runat="server" Width="250px" style="margin-right:10px" ></asp:TextBox>
            <asp:Button class="btn btn-outline-success my-2 my-sm-0" type="submit" ID="btnBuscar" runat="server" Text="Buscar"  OnClick="btnBuscar_Click" ForeColor="Black" style="margin-right:10px"/>
            <asp:Button class="btn btn-outline-success my-2 my-sm-0" type="submit" ID="btnTodos" runat="server" PostBackUrl="~/PaginaUser/Catalogo.aspx" Text="Todos" OnClick="btnTodos_Click" ForeColor="Black" style="margin-right:10px" />
            </div>
        </nav>
        <asp:SqlDataSource ID="SqlDataSourceCategorias" runat="server" ConnectionString="<%$ ConnectionStrings:DIAZ_DBConnectionString %>" SelectCommand="SELECT DISTINCT [TipoArticulo] FROM [Articulos]"></asp:SqlDataSource>
        <%--<div style="margin-right: 100px; background: #383838 url('linear-gradient(to%20bottom,%20rgba(0,%200,%200,%200),%20rgba(0,%200,%200,%200.3))'); width: 1400px; border-radius: 4px; -webkit-box-shadow: inset 0 0 0 1px rgba(0, 0, 0, 0.2), 0 0 6px rgba(0, 0, 0, 0.4); box-shadow: inset 0 0 0 1px rgba(0, 0, 0, 0.2), 0 0 6px rgba(0, 0, 0, 0.4); height: 39px; color: #FFFFFF; margin-left: 0px;" class="text-center">--%>
    
    <section class="content">
        <div class="row">
            <div class="col-sm-3" style="text-align: left">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Imagenes/CarroLogo.png" OnClick="ImageButton1_Click" ToolTip="Ver Carrito" Width="50%" ImageAlign="Middle" />
                <div class="card" style="border-style: outset; border-width: medium; border-color: #CCCCCC; width: 20rem; overflow: auto; background: #CCCCCC; left: 32px; top: 453px;" aria-hidden="False" aria-multiline="False">
                    <div class="card-body">
                        <h1 class="text-center">Categorías</h1>
                        <div class="text-center">
                            <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSourceCategorias" Style="font-size: medium; color: #000000;" Width="147px" HorizontalAlign="Center" ForeColor="Black">
                                <ItemTemplate>
                                    <br />
                                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "~/PaginaUser/Catalogo.aspx?TipoArticulo=" + Eval("TipoArticulo") %>' Text='<%# Eval("TipoArticulo") %>'></asp:HyperLink>
                                    <br />
                                </ItemTemplate>
                            </asp:DataList>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <table class="auto-style1" style="height: 420px">
                    <tr>
                        <td class="auto-style19" colspan="2"></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:ListView ID="ListView1" runat="server" DataSourceID="ObjectDataSource1" GroupItemCount="3" DataKeyNames="ID,Imagen,Marca,Descripcion,TipoArticulo,PrecioVenta" Style="margin-left: 0px; margin-right: 17px;" OnItemCommand="ListView1_ItemCommand">
                                <EmptyDataTemplate>
                                    <table runat="server" style="">
                                        <tr>
                                            <td style="color: #FFFFFF; width: 800px; font-size: 16px; background-color: #FF5050; font-weight: bold;">No se han encontrado Resultados, Intente Nuevamente.</td>
                                        </tr>
                                    </table>
                                </EmptyDataTemplate>
                                <EmptyItemTemplate>
                                    <td runat="server" />
                                </EmptyItemTemplate>
                                <GroupTemplate>
                                    <tr id="itemPlaceholderContainer" runat="server">
                                        <td id="itemPlaceholder" runat="server"></td>
                                    </tr>
                                </GroupTemplate>
                                <ItemTemplate>
                                    <td class="card card-block" style="width: 18rem;" runat="server">
                                        <table>
                                            <asp:Image ID="Image1" runat="server" class="card-img-top img-fluid" alt="" Height="120px" ImageUrl='<%# "~/Imagenes/"+Eval("Imagen") %>' Width="140px" />
                                            <caption>
                                                <tr>
                                                    <td class="card-body">ID:
                                <asp:Label ID="lblID" runat="server" Text='<%# Eval("ID") %>'></asp:Label>
                                                        <br />
                                                        Descripcion:
                                <asp:Label ID="lblDescripcion" runat="server" Text='<%# Eval("Descripcion") %>'></asp:Label>
                                                        <br />
                                                        Marca:
                                <asp:Label ID="MarcaLabel" runat="server" Text='<%# Eval("Marca") %>'></asp:Label>
                                                        <br />
                                                        Categoría:
                                <asp:Label ID="NombreLabel" runat="server" Text='<%# Eval("TipoArticulo") %>'></asp:Label>
                                                        <br />
                                                        Precio $:
                                <asp:Label ID="lblPrecioV" runat="server" Text='<%# Eval("PrecioVenta") %>'></asp:Label>
                                                        <br />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Button ID="btnAñadir" runat="server" CommandName="Seleccionar" class="btn btn-primary" Text="Añadir al carrito" />
                                                        <asp:Image ID="Image2" runat="server" ImageUrl="~/Imagenes/Carro.png" Width="40px" />
                                                        <br />
                                                        <br />
                                                        <br />
                                                    </td>
                                                </tr>
                                            </caption>
                                        </table>
                                    </td>
                                </ItemTemplate>
                                <LayoutTemplate>
                                    <table runat="server">
                                        <tr runat="server">
                                            <td runat="server">
                                                <table id="groupPlaceholderContainer" runat="server" border="0" style="">
                                                    <tr id="groupPlaceholder" runat="server">
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr runat="server">
                                            <td runat="server" style=""></td>
                                        </tr>
                                    </table>
                                </LayoutTemplate>
                            </asp:ListView>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </section>
    <section>
        <div class="auto-style10" style="text-align: center">
            <asp:DataPager class="pagination" ID="DataPager1" runat="server" PagedControlID="ListView1">
                <Fields>
                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                    <asp:NumericPagerField />
                    <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                </Fields>
            </asp:DataPager>
        </div>
    </section>
</asp:Content>
