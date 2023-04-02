using System.Web.Mvc;

namespace AspNetTest.Areas.MvcAdapter
{
    public class MvcAdapterAreaRegistration : AreaRegistration 
    {
        public override string AreaName => "MvcAdapter";

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "MvcAdapter_default",
                "MvcAdapter/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}