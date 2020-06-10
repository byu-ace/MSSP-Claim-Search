using System.Web;
using System.Web.Mvc;

namespace MSSP_Claim_Search
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
