using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SuperSocketWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var appServer = new TestServer();
            if (!appServer.Setup(2012)) //Setup with listening port
            {
                return;
            }
            if (!appServer.Start())
            {
                return;
            }

            //while (true)
            //{
            //    continue;
            //}
            ////Stop the appServer
            //appServer.Stop();
        }
    }
}
