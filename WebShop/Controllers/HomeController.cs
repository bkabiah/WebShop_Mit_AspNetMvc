using System.Web.Mvc;
using WebApplication11.Filters;

namespace WebShop.Controllers
{
    [CrawlerFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}