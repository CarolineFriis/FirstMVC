using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

//request på website
//Global.asax modtager request --> laver en routing --> finder rigtig controller
//Controller håndterer data ved brug af model --> vækker actions --> sender Model til view
// View render output til browser



//denne side ses som default handler
//default templates som vækkter static methods på 4 classes. 
namespace MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes); //Find denne under App_start
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
