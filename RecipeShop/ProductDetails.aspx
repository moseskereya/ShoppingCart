<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="RecipeShop.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="productDetail" runat="server" ItemType="RecipeShop.Models.Product" SelectMethod ="GetProduct" RenderOuterTable="false">
           <ItemTemplate>
            <div>
                <h1><%#:Item.ProductName %></h1>
            </div>
            <br />
            <div class="row">
                <div class="col-sm-4">
                      <img src="<%#:Item.ImagePath %>" class="img-thumbnail" alt="<%#:Item.ProductName %>"/>
                </div>
                <div class="col-sm-4">
                        <b>Description:</b><br /><%#:Item.Description %>
                        <br />
                        <span><b>Price:</b>&nbsp;<%#: String.Format("{0:c}", Item.UnitPrice) %></span>
                        <br />
                        <span><b>Product Number:</b>&nbsp;<%#:Item.ProductID %></span>
                    <br />
                    <button>
                        <a href="ProductList.aspx">Back to products</a>
                    </button>
                        <a href="/AddToCart.aspx?productID=<%#:Item.ProductID %>">               
                        <span class="ProductListItem">
                            <b>Add To Cart<b>
                        </span>           
                    </a>
                </div>
            </div>

        </ItemTemplate>
    </asp:FormView>
</asp:Content>
