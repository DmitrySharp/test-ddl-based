using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TestOrder
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "Start",
                url: "start",
                defaults: new { controller = "Orders", action = "Index" }
            );
            routes.MapRoute(
                name: "PrepareOrdersToShip",
                url: "prepareOrdersToShip",
                defaults: new { controller = "Orders", action = "PrepareShipments" }
            );

            routes.MapRoute(
                name: "Orders",
                url: "orders",
                defaults: new { controller = "Orders", action = "Orders"}
            );



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
