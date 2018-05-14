using System.Collections.Generic;
using System.Linq;

namespace WebApiProduct.Models.ProductRepo
{
    public class ProductRepository : IRepository
                                                       
    {
        
            ProductDbContext context = new ProductDbContext();
       // private List<Products> products = new List<Products>();

        public IEnumerable<Products> GetProducts()
        {
            return context.Set<Products>().ToList();
        }
       
        public void Save()
        {
            context.SaveChanges();
        }

    }
}