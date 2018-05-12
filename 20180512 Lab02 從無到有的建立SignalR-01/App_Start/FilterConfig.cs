using System.Web;
using System.Web.Mvc;

namespace _20180512_Lab02_從無到有的建立SignalR_01
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
