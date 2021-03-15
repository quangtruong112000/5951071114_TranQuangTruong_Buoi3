using System.Web;
using System.Web.Mvc;

namespace TranQuangTruong_5951071114
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
