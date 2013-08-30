using System.Web;
using System.Web.Mvc;

namespace Zuehlke.Camp2013.NoSQL.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}