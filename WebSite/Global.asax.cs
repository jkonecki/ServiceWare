using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace ServiceWare.WebSite
{
	public class MvcApplication : System.Web.HttpApplication
	{
		public static readonly Version Version;

		static MvcApplication()
		{
			Version = typeof(MvcApplication).Assembly.GetName().Version;
		}

		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			WebApiConfig.Register(GlobalConfiguration.Configuration);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
		}
	}
}