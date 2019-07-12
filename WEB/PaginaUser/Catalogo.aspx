<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUser/User.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="WEB.CarritoCompra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ListarArticulos" TypeName="Negocio.ArticuloNegocio"></asp:ObjectDataSource>
    <asp:SqlDataSource ID="SqlDataSourceTodosProductos" runat="server" ConnectionString="<%$ ConnectionStrings:DIAZ_DBConnectionString %>" SelectCommand="SELECT [ID], [Descripcion], [Marca], [TipoArticulo], [PrecioVenta], [Imagen] FROM [Articulos]"></asp:SqlDataSource>
    
    <table class="auto-style1" style="height: 420px">
        <tr>
            <td class="auto-style15" colspan="3">
                <%--<asp:Image ID="Image4" runat="server" Height="209px" ImageUrl="/Figuras/niños.jpg" Width="366px" />
                <asp:Image ID="Image5" runat="server" Height="209px" ImageUrl="~/Figuras/lo mas nuevo.jpg" style="margin-left: 0px" />
                <asp:Image ID="Image6" runat="server" Height="207px" ImageUrl="~/Figuras/rebajas.jpg" Width="378px" />
                <br />--%>
                <div style="width: 116%; margin-left:132px; background-position: 0% 0%; border-radius: 4px; background-image: linear-gradient(to bottom, rgba(0, 0, 0, 0), rgba(0, 0, 0, 0.3)); -webkit-box-shadow: inset 0 0 0 1px rgba(0, 0, 0, 0.2), 0 0 6px rgba(0, 0, 0, 0.4); box-shadow: inset 0 0 0 1px rgba(0, 0, 0, 0.2), 0 0 6px rgba(0, 0, 0, 0.4); height: 30px; color: #FFFFFF; background-color: #383838; background-repeat: repeat; background-attachment: scroll;">
                    &nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/PaginaUser/Carrito.aspx">Ver Carrito </asp:HyperLink>
                </div>
            </td>
        </tr>
        <tr>
            <td class="auto-style19" style="width: 397px">
                <asp:SqlDataSource ID="SqlDataSourceCategorias" runat="server" ConnectionString="<%$ ConnectionStrings:DIAZ_DBConnectionString %>" SelectCommand="SELECT DISTINCT [TipoArticulo] FROM [Articulos]"></asp:SqlDataSource>
            </td>
            <td class="auto-style20">
                <div style="background-position: 0% 0%; border-radius: 4px; background-image: linear-gradient(to bottom, rgba(0, 0, 0, 0), rgba(0, 0, 0, 0.3)); -webkit-box-shadow: inset 0 0 0 1px rgba(0, 0, 0, 0.2), 0 0 6px rgba(0, 0, 0, 0.4); box-shadow: inset 0 0 0 1px rgba(0, 0, 0, 0.2), 0 0 6px rgba(0, 0, 0, 0.4); height: 39px; color: #FFFFFF; background-color: #383838; background-repeat: repeat; background-attachment: scroll;">
                    &nbsp;&nbsp;<asp:TextBox ID="txtBusqueda" runat="server" style="margin-top:4px;" Width="224px" ForeColor="Black" Height="22px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;<asp:Button ID="btnBuscar" runat="server" BorderStyle="Solid" CssClass="botones" Text="Buscar" Width="87px" UseSubmitBehavior="False" foreColor="Black" OnClick="btnBuscar_Click"/>
                    &nbsp;&nbsp;&nbsp;<asp:Button ID="btnTodos" runat="server" BorderStyle="Solid" CssClass="botones" PostBackUrl="~/PaginaUser/Catalogo.aspx" Text="Todos" Width="87px" foreColor="Black" OnClick="btnTodos_Click"/>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;
                </div>
                &nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 

            </td>
            <td class="auto-style21"></td>
        </tr>
        <tr>
            <td class="auto-style16" style="width: 397px">
                <h3>Categorías</h3>
                <center>
                    <div style="border: medium double #0066FF; height: 400px; width: 200px; overflow: Auto; background: #C0C0C0; position: absolute;" aria-hidden="False" aria-multiline="False">
                        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSourceCategorias" style="text-align: left" Width="147px" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Both" HorizontalAlign="Center">
                            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                            <ItemStyle BackColor="White" ForeColor="#003399" />
                            <ItemTemplate>
                        <br />
                                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "~/PaginaUser/Catalogo.aspx?TipoArticulo=" + Eval("TipoArticulo") %>' Text='<%# Eval("TipoArticulo") %>'></asp:HyperLink>
                   
                        <br />

                            </ItemTemplate>
                            <SelectedItemStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        </asp:DataList>
                    </div>
                </center>
            </td>
            <td>
                <br />
    <asp:ListView ID="ListView1" runat="server" DataSourceID="ObjectDataSource1" GroupItemCount="3" DataKeyNames="ID,Imagen,Marca,Descripcion,TipoArticulo,PrecioVenta" style="margin-left: 0px; margin-right: 17px;" OnItemCommand="ListView1_ItemCommand"  >
     
      
        <EmptyDataTemplate>
            <table runat="server" style="">
                <tr>
                <td style="color: #FFFFFF;width:800px; font-size: 16px; background-color: #FF5050; font-weight: bold;">No se han encontrado Resultados, Intente Nuevamente.</td>
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
            <td runat="server" style="">
                <table class="">
                    <asp:Image ID="Image1" runat="server" CssClass="img-fluid" Height="120px" ImageUrl='<%# "~/Imagenes/"+Eval("Imagen") %>' Width="140px" />
                    <caption>
                        <br />
                        <tr>
                            <td>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>ID:
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
                                <asp:Button ID="btnAñadir" runat="server" CommandName="Seleccionar" style="height: 26px" Text="Añadir al carrito" />
                                
                            </td>
                        </tr>
                        <tr>
                            <td >
                                <asp:Image ID="Image2" runat="server" Height="35px" ImageAlign="Middle" ImageUrl="~/Imagenes/Carro.png" Width="49px" CssClass="active left"  />
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
    
                <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1">
                    <Fields>
                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                        <asp:NumericPagerField />
                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                    </Fields>
                </asp:DataPager>
    
                <br />
                <br />
                <br />

            </td>
            <td class="auto-style11"></td>
        </tr>
        <tr>
            <td class="auto-style18" style="width: 397px"></td>
            <td class="auto-style10">

              

            </td>
            <td class="auto-style9"></td>
        </tr>
</table>
    
</asp:Content>
