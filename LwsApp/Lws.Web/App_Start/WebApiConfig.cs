using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Lws.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.EnableCors();

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "LastValue",
                routeTemplate: "api/{controller}/{action}/{id}"
            );

            config.Routes.MapHttpRoute(
                name: "GetValues",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

        }
    }
}
