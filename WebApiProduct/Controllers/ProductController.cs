using System.Web.Mvc;

namespace WebApiProduct.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Retrieve()
        {
            return View();
        }
    }
}