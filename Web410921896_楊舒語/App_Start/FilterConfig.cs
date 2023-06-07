using System.Web;
using System.Web.Mvc;

namespace Web410921896_楊舒語
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
