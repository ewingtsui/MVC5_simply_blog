using System.Web;
using System.Web.Mvc;

namespace MVC5簡易留言版
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
