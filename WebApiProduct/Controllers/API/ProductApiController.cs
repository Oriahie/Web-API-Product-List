using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiProduct.Models.ProductRepo;

namespace WebApiProduct.Controllers.API
{
    [RoutePrefix("api/productapi")]
    public class ProductApiController : ApiController
    {

        // private ProductDbContext context = new ProductDbContext();

        ProductRepository repo; 

        public ProductApiController()
        {
           repo= new ProductRepository();
        }


        [Route("get_products")]
        public HttpResponseMessage GetProd()
        {

            try
            {
                var products = repo.GetProducts().ToList();
                return this.Request.CreateResponse(HttpStatusCode.OK, products);
            }
            catch (Exception ex)
            {
                return this.Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}