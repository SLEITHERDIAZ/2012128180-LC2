using System.Web;
using System.Web.Mvc;

namespace LineasNuevas.Web.API
{
    public class FilterConfig
    {
        public static voId RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
