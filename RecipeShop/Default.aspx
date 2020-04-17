<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RecipeShop._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <div class="jumbotron">
        <h3 class="text-center">Recipe App</h3>
        <p>Recipe App is the web app built using asp.net webforms which shows the different types of recipes you need in her restaurant</p>
        <h4>This website has Shopping cart enabled so you can buy a product and make payments online</h4>
    </div>

    <div class="row">
          <div class="col-md-4">
    <div class="thumbnail">
      <a href="ProductList.aspx">
        <img src="https://www.bbcgoodfood.com/sites/default/files/styles/recipe/public/recipe_images/cocktail-truffle-selection.jpg?itok=dAf5U0zt" alt="Nature" style="width:100%">
        <div class="caption">
          <p>Cocktail truffle selection</p>
        </div>
      </a>
    </div>
  </div>
        <div class="col-md-4">
    <div class="thumbnail">
      <a href="ProductList.aspx">
        <img src="https://www.bbcgoodfood.com/sites/default/files/styles/recipe/public/recipe_images/recipe-image-legacy-id--561020_11.jpg?itok=R54zWpK1" alt="Nature" style="width:100%">
        <div class="caption">
          <p>Toffee apple cookies</p>
        </div>
      </a>
    </div>
  </div>
     <div class="col-md-4">
    <div class="thumbnail">
      <a href="ProductList.aspx">
        <img src="https://www.bbcgoodfood.com/sites/default/files/styles/recipe/public/recipe_images/recipe-image-legacy-id--363907_12.jpg?itok=0vIx3anC" alt="Nature" style="width:100%">
        <div class="caption">
          <p>Easy chocolate cupcakes</p>
        </div>
      </a>
    </div>
  </div>
    </div>
      <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
</asp:Content>
