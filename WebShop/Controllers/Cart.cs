using System.Web.Mvc;

namespace WebShop.Controllers
{
    public class CartController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
    }
}