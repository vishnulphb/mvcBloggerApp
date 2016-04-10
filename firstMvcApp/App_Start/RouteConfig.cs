using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace firstMvcApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.MapRoute("Name, url, controller and action")
            routes.MapRoute("Login", "login", new { Controller="Auth", Action="Login" });
            routes.MapRoute("Home","", new {Controller="Posts", Action="Index" });


  

        }
    }
}
