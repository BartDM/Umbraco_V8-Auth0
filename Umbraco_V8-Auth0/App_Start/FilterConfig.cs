using System.Web;
using System.Web.Mvc;

namespace Umnraco_V8_Auth0
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}