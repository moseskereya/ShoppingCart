using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RecipeShop.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Pies"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Drinks"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Cakes"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Pizza"
                }
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Double-Crust Fruit Pie",
                    Description = "These are the pies you bake after going to the orchard in the summer or fall. Buttery, flaky top and bottom crusts encase mounds of perfectly stewed fruit in these quintessential American pies. Because the top crust shields the filling, the juicy fruit usually requires a thickening agent such as ground tapioca or cornstarch to keep it from being too soupy. The most traditional crusts feature sliced vents for moisture to escape, although some fruit fillings, such as cherry and peach, require more evaporation and often sport lattice-woven crusts. You can brush the top crust with an egg wash and, if desired, sprinkle it with sugar. Fruit pies take a full 4 hours to set up, so don’t slice them too soon. If you want a warm slice of pie with ice cream, you can always heat up individual slices. ",
                    ImagePath="https://res.cloudinary.com/hksqkdlah/image/upload/c_fill,f_auto,q_auto,w_300/v1/AKO%20Articles/Book%20Articles/Perfect%20Pie/SFS_Sour_Cherry_Hazelnut_Pie_239",
                    UnitPrice = 22.50,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Cream Pie",
                    Description = "Cream pies are filled with pastry cream—a cool, creamy, billowy custard that’s cooked completely on the stove and then spread into a fully baked pie crust before the whole thing goes in the refrigerator to chill. These diner-style pies are frequently topped with whipped cream. ",
                    ImagePath="https://res.cloudinary.com/hksqkdlah/image/upload/c_fill,f_auto,q_auto,w_300/v1/AKO%20Articles/Book%20Articles/Perfect%20Pie/SFS_chocolate_cream_pie_30",
                    UnitPrice = 15.95,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Custard Pie",
                    Description = "Custard pies feature an egg-thickened filling that’s a bit firmer than pastry cream. A mixture of eggs, dairy, and sugar bakes until set within a single crust. Once cooled, the custard is a creamy, lightly eggy filling that coheres with the crust. A custard pie is done when the center still wobbles gently (165 degrees is typically the sweet spot for doneness). Overcooked custard pies can have rubbery, grainy fillings. Sometimes we cook the custard in a saucepan before adding it to the pie to give it a head start; this ensures it bakes quickly so the edges of the custard don’t overcook before the center sets. The custard can be infused with just about any flavor you can dream up. ",
                    ImagePath="https://res.cloudinary.com/hksqkdlah/image/upload/c_fill,f_auto,q_auto,w_300/v1/AKO%20Articles/Book%20Articles/Perfect%20Pie/SFS_Lavender_Creme_Brulee_Pie_119",
                    UnitPrice = 32.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Meringue Pie",
                    Description = "These pies feature a lofty plume of whipped egg whites that adorns the filling like a fluffy, sweet cloud. The meringue, which we whip up in a stand mixer and then bake briefly on the pie to brown, usually tops a custard- or curd-filled pie (but we also whipped up elderflower-flavored meringue for a pie filled with Cape gooseberries in a recipe for The Perfect Pie). Whipping the meringue until it just reaches stiff peaks ensures it doesn’t weep, and anchoring the meringue to the edge of the crust keeps it from pulling away from the sides during broiling.",
                    ImagePath="https://res.cloudinary.com/hksqkdlah/image/upload/c_fill,f_auto,q_auto,w_300/v1/AKO%20Articles/Book%20Articles/Perfect%20Pie/SFS_ChocolateAngelPie-12",
                    UnitPrice = 8.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Tart",
                    Description = "Tarts are an elegant subcategory of pie. The pastry, which is typically baked in a short-sided fluted pan, isn’t flaky like a pie crust; instead it’s sweet and has a closed crumb, reminiscent of shortbread. The filling for tarts is often creamy and rich and can be baked with the tart shell, like in a Lemon Tart; added after, as with a Fresh Fruit Tart; and sometimes topped with fruit, like in French Apple Tart",
                    ImagePath="https://res.cloudinary.com/hksqkdlah/image/upload/c_fill,f_auto,q_auto,w_300/v1/AKO%20Articles/Book%20Articles/Perfect%20Pie/SFS_Plum_and_Raspberry_Fruit_Tart-17_1",
                    UnitPrice = 34.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Galette",
                    Description = "This pastry is a tart (it’s open-faced), but it’s also kind of like a pie in that it has a flaky crust and usually features a fruit filling that cooks during baking. It’s made free-form (which is why we use the names free-form tart and galette interchangeably) on a baking sheet, so it’s simple to pull together. Since the center is open, the fruit in these tarts essentially roasts, and their juices usually tighten up without the help of an additional thickener. ",
                    ImagePath="https://res.cloudinary.com/hksqkdlah/image/upload/c_fill,f_auto,q_auto,w_300/v1/AKO%20Articles/Book%20Articles/Perfect%20Pie/SFS_Strawberry-Tart-with-Balsamic-and-Basil-9",
                    UnitPrice = 95.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Chiffon Pie",
                    Description = "This pastry is a tart (it’s open-faced), but it’s also kind of like a pie in that it has a flaky crust and usually features a fruit filling that cooks during baking. It’s made free-form (which is why we use the names free-form tart and galette interchangeably) on a baking sheet, so it’s simple to pull together. Since the center is open, the fruit in these tarts essentially roasts, and their juices usually tighten up without the help of an additional thickener. ",
                    ImagePath="https://res.cloudinary.com/hksqkdlah/image/upload/c_fill,f_auto,q_auto,w_400/v1/AKO%20Articles/Book%20Articles/Perfect%20Pie/SFS_Rum_Pumpkin_Chiffon_Pie-26",
                    UnitPrice = 4.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Ice Cream Pie",
                    Description = "This one is pretty self-explanatory—and pretty delicious. Ice cream (or sorbet or gelato) is softened, maybe combined with mix-ins, and spread into a prebaked cookie crust for a sundae in sliceable form. ",
                    ImagePath="https://res.cloudinary.com/hksqkdlah/image/upload/c_fill,f_auto,q_auto,w_400/v1/AKO%20Articles/Book%20Articles/Perfect%20Pie/SFS_CookiesAndCreamIceCreamPie_67",
                    UnitPrice = 2.95,
                    CategoryID = 1
                },

                // moeses

                new Product
                {
                    ProductID = 9,
                    ProductName = "Moscow Mule",
                    Description = "Squeeze lime juice into a Moscow Mule mug, then drop in spent shell. Add 2-3 ice cubes and vodka, then fill with ginger beer.",
                    ImagePath="https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/10-moscow-1560986433.jpg?crop=1xw:1xh;center,top&resize=980:*",
                    UnitPrice = 32.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Aperol Spritz",
                    Description = "Fill a wine glass with ice. Add equal parts prosecco and Aperol, and a splash of club soda. Garnish with fresh orange slices.",
                    ImagePath="https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/9-aperol-1560986460.jpg?crop=1xw:1xh;center,top&resize=980:*",
                    UnitPrice = 15.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Margarita",
                    Description = "Rub the rim of a chilled cocktail glass with lime juice and dip in coarse salt. Shake tequila, Cointreau, lime juice, and ice in a mixing glass, then strain into the salted glass over ice.",
                    ImagePath="https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/8-marg-1560986473.jpg?crop=1xw:1xh;center,top&resize=980:*",
                    UnitPrice = 26.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Espresso Martini",
                    Description = "Shake ingredients with ice until chilled, then strain into a martini glass. Garnish with espresso beans.",
                    ImagePath="https://images.pexels.com/photos/3754296/pexels-photo-3754296.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    UnitPrice = 29.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Dry Martini",
                    Description = "Stir vermouth and gin with cracked ice, strain into a chilled cocktail glass, and garnish with an olive.",
                    ImagePath="https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/6-dry-1560987195.jpg?crop=1xw:1xh;center,top&resize=980",
                    UnitPrice = 95.00,
                    CategoryID = 2
                },

                // moses cakes

                new Product
                {
                    ProductID = 17,
                    ProductName = "Lady Baltimore Cake",
                    Description = "Fluffy white cake is layered with a fruit and nut filling and topped with a pillowy meringue type frosting. The origin of the cake is somewhat in dispute, but it’s believed to have been created in the southern part of the United States.",
                    ImagePath = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/lady-baltimire-cake-1577124740.jpg?crop=1.00xw:0.918xh;0,0&resize=768:*",
                    UnitPrice = 89.78,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 18,
                    ProductName = "Opera Cake",
                    Description = "The history of this type of cake is a bit muddled. One thing we do know, however, is that its thin layers of coffee-soaked almond cake are sandwiched between an espresso-flavored buttercream, a bittersweet chocolate ganache, and topped off with a second rich chocolate ganache. Light but rich, this pastry is a real showstopper.",
                    ImagePath = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/opera-cake-royalty-free-image-1578350233.jpg?crop=1xw:1xh;center,top&resize=768:*",
                    UnitPrice = 56.68,
                    CategoryID = 3,

                },
                new Product
                {
                    ProductID = 19,
                    ProductName = "Genoise Cake",
                    Description = "Genoise is what a sponge cake is called in Italy or France. In this cake, egg yolks, whites and sugar are beaten together until mousse-like. Next, flour, and either oil or butter, are folded in. This type of sponge cake is more moist and tender than its sponge cake cousin",
                    ImagePath = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/genoise-with-cream-berries-and-lemon-cream-royalty-free-image-1578348743.jpg?crop=1xw:1xh;center,top&resize=768:*",
                    UnitPrice = 67.29,
                    CategoryID = 3,

                },
                new Product
                {
                    ProductID = 20,
                    ProductName = "Flourless Cake",
                    Description = "This category includes both baked (think cheese cake or flourless chocolate) or unbaked (like mousse or unbaked cheesecakes) varieties. Typically very rich because of the high fat content, these cakes may or may not have a bottom crumb crust.",
                    ImagePath = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/cheese-cake-1577124381.jpg?crop=1.00xw:0.760xh;0,0.133xh&resize=768:*",
                    UnitPrice = 56.37,
                    CategoryID = 3,

                },
                new Product
                {
                    ProductID = 21,
                    ProductName = "Upside Down Cake",
                    Description = "The classic version of this butter style cake is traditionally made with pineapple, but can be made with many varieties of fruits, including plums, peaches, blueberries, or pears. The toppings are spread on the bottom of the pan, often with butter and sugar, and then topped with cake batter. After cooking, the cake is turned out so that the fruit is facing up.",
                    ImagePath = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/upside-down-cake-1577124438.jpg?crop=1.00xw:0.918xh;0,0.0357xh&resize=768:*",
                    UnitPrice = 52.18,
                    CategoryID = 3,

                },
                 new Product
                {
                    ProductID = 22,
                    ProductName = "Devil’s Food Cake",
                    Description = "This cake is made 'devilish' by the addition of chocolate in the form of cocoa powder. Extra baking soda causes the crumb to have more air bubbles, giving it a light and airy texture. This rich cake is frosted with either chocolate frosting or buttercream.",
                    ImagePath = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/devils-food-cake-1577124539.jpg?crop=1.00xw:0.911xh;0,0.0658xh&resize=768:*",
                    UnitPrice = 33.68,
                    CategoryID = 3,

                },
                new Product
                {
                    ProductID = 23,
                    ProductName = "Hummingbird Cake",
                    Description = "The classic southern oil cake is flavored with banana, pineapple, pecans, lots of warm spices, and topped with a tangy cream cheese frosting. Created in Jamaica and originally called 'Doctor Bird Cake,: this confection made its way Stateside sometime in the 1960s.",
                    ImagePath = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/hummingbird-cake-1577124607.jpg?crop=1.00xw:0.918xh;0,0.0536xh&resize=768:*",
                    UnitPrice = 21.68,
                    CategoryID = 3,

                },
                  new Product
                {
                    ProductID = 24,
                    ProductName = "The Original Neapolitan Pizza",
                    Description = "The Neapolitan pizza is the original pizza that left Italy and arrived with Italian immigrants in the United States. This is the pizza that launched American pizza fanaticism. In fact, Italy has sought UNESCO heritage protection for the",
                    ImagePath = "https://www.tripsavvy.com/thmb/bGq0C5ezMD4SPX--8ODRTGJBq90=/800x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/pizza-neapolitan-56a310505f9b58b7d0d0382c.jpg",
                    UnitPrice = 12.68,
                    CategoryID = 4,

                },

                  new Product
                  {
                      ProductID = 25,
                      ProductName = "California Style Pizza",
                      Description = "California style pizza uses a dough base similar to the Neapolitan or New York style pizza and jazzes up the base with unusual and uncommon ingredients. This style of pizza is generally credited to Chef Ed LaDou who developed a pizza with ricotta, red peppers, mustard, and pate, that Chef Wolfgang Puck tried and loved in the early 1980s. Chef Puck immediately hired Chef LaDou to work at the newly opened Spago in 1982 and Chef LaDou continued creating innovative pizzas, including varieties with duck sausage and smoked salmon.",
                      ImagePath = "https://www.tripsavvy.com/thmb/yHfpUyJpsrWJ2brKC4izn9l3yWQ=/800x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/154414313_HighRes-resize-56a30fc95f9b58b7d0d0377f.jpg",
                      CategoryID = 4
                  },
                  new Product
                  {
                      ProductID = 27,
                      ProductName = "Chicago Deep Dish Pizza",
                      Description = "In the 1940s, Pizzeria Uno in Chicago developed the deep-dish pizza, which has a deep crust that lines a deep dish, similar to a large metal cake or pie pan. Though the entire pizza is quite thick, the crust itself is only of thin to medium thickness, and the pizza has a very thick, large layer of toppings. Because the pizza is so thick, it requires a long baking time and a different assembly method, to avoid burning the cheese.",
                      ImagePath = "https://www.tripsavvy.com/thmb/nWgo7KWEVT-f936dhrvKIq8mW64=/800x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/stuffed-vegetarian-pizza-86288165-58e6db275f9b58ef7e21d4ca.jpg",
                      UnitPrice = 34.56 ,
                      CategoryID = 4
                  },
                      new Product
                  {
                      ProductID = 28,
                      ProductName = "Chicago Thin Crust Pizza",
                      Description = "The Chicago thin crust is crispier and crunchier than the New York style and normally cut into squares (or tavern cut) rather than diagonal slices. The Quad City area, a group of five cities between Iowa and Illinois, has developed a variation of the Chicago thin crust which uses a spicy sauce, large amounts of meat, and is cut into strips or squares.",
                      ImagePath = "https://www.tripsavvy.com/thmb/jexUFwkeRqqq-y6JHSRHEzpdizE=/800x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/ThinCrustSquarePizza-5c1f55a546e0fb00016478d6.jpg",
                      UnitPrice = 20.14,
                      CategoryID = 4
                  },
                       new Product
                  {
                      ProductID = 29,
                      ProductName = "Detroit Style Pizza",
                      Description = "The Detroit style pizza is a square pizza, similar to Sicilian-style pizza, with a deep-dish crust and marinara sauce sometimes served on top. The crust is usually baked in a well-oiled pan to develop caramelized crunchy edges. Detroit style pizza has developed a larger fan base as Detroit-based Little Caesars launched a Detroit-style deep dish pizza available at its nationwide chains.",
                      ImagePath = "https://www.tripsavvy.com/thmb/7gq0IwKXkpNSPTHGE0YsUzWHG-U=/800x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/GettyImages-1165394723-41135aff580a44f59d0881cd54f12463.jpg",
                      UnitPrice = 43.44,
                      CategoryID = 4
                  },
                  new Product
                  {
                      ProductID = 30,
                      ProductName = "New England Greek Style Pizza",
                      Description = "Greek-style pizza generally refers to the pizza served at Houses of Pizza, run by Greek immigrants in New England. The pizza crust lies in between the crunchy New York-style pizza and its thicker Sicilian cousin and it is baked in a heavily greased cake or cast iron pan, which results in a thick and golden crunchy crust. Many of these pizzas are topped with typical Greek ingredients, such as feta, artichokes, and kalamata olives, as well as an oregano-heavy tomato sauce. Though, a Greek pizza may also be simply topped with tomato sauce and mozzarella cheese.  ",
                      ImagePath = "https://www.tripsavvy.com/thmb/auY2hmSOtkrTpMhvQtn917Hz2mA=/800x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/Greek-style-pizza-greggman-56a30fc85f9b58b7d0d0377c.jpg",
                      UnitPrice = 26.56,
                      CategoryID = 4
                  },
            };

            return products;
        }

    }
}