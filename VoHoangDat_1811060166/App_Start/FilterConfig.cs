using System.Web;
using System.Web.Mvc;

namespace VoHoangDat_1811060166
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
