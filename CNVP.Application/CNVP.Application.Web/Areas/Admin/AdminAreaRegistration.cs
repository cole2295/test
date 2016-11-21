using System.Web.Mvc;

namespace CNVP.Application.Web.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                name: "Admin_default",
                url: "Admin/{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "AdminDefault", id = UrlParameter.Optional },
                namespaces: new[] { "CNVP.Application.Web.Areas.Admin.Controllers" }
            );
        }
    }
}
