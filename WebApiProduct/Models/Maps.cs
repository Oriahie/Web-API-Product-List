using System.Data.Entity.ModelConfiguration;

namespace WebApiProduct.Models
{
    public class ProductMap : EntityTypeConfiguration<Products>
    {
        public ProductMap()
        {
            this.Property(c => c.Name).HasMaxLength(50);
            this.Property(c => c.Description).HasMaxLength(250);

        }

    }

    public class CategoriesMap : EntityTypeConfiguration<Categories>
    {
        public CategoriesMap()
        {
           

        }

    }

}