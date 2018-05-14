using System.Data.Entity;

namespace WebApiProduct.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext() : base("ProductDbContext")
        {

        }


        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
    }
}