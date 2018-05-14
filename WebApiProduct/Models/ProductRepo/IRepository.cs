using System.Collections.Generic;

namespace WebApiProduct.Models.ProductRepo
{
    public interface IRepository
    {
        IEnumerable<Products> GetProducts();
            
        
         
     
        void Save();
    }
}
