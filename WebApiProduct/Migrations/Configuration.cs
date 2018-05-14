namespace WebApiProduct.Migrations
{
    using System.Data.Entity.Migrations;
    using WebApiProduct.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProductDbContext context)
        {
            var product1 = new Products
            {
                Name = "Milo",
                Description = "Good for your body",
                Price = 450,
                Category = new Categories{ Name = "Beverages" }
            };

            var product2 = new Products
            {
                Name = "Samsung S6",
                Description = "Sleek and Expensive Mobile Phone",
                Price = 450000,
                Category = new Categories{ Name = "Electronics" }
            };

            var product3 = new Products
            {
                Name = "Dano Milk",
                Description = "Skimmed Milk, good for the family",
                Price = 950,
                Category = new Categories { Name = "Beverages" }
            };

            var product4 = new Products
            {
                Name = "Lenovo Touchpad",
                Description = "Sleek and Expensive Computer",
                Price = 500000,
                Category = new Categories{ Name = "Electronics" }
            };

           


            //context.Set<Products>().AddOrUpdate(c => c.Name, product1);
            //context.Set<Products>().AddOrUpdate(c => c.Name, product2);
            //context.Set<Products>().AddOrUpdate(c => c.Name, product3);
            //context.Set<Products>().AddOrUpdate(c => c.Name, product4);





            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
