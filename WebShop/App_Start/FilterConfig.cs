

using WebShop.Filters;
using System.Web.Mvc;
using WebApplication11.Filters;

namespace WebShop
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CustomExceptionFilter());
            filters.Add(new LogRequestFilter());
        }
    }
}
