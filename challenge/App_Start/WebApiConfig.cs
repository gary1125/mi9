using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web.Http;
using challenge.Exeption;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
//using System.Web.Http.Cors;

namespace challenge
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "",
                defaults: new { id = RouteParameter.Optional, controller = "Payload" }
            );
            //config.EnableCors();
            config.Filters.Add(new DefaultExceptionFilter());
        }
    }
}
