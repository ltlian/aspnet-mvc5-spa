using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AspNetTest
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            if (Environment.GetEnvironmentVariable("DEV_ENVIRONMENT") == "1")
            {
                // Enable all CORS for dev mode to allow requests from app running on different port
                // https://learn.microsoft.com/en-us/aspnet/web-api/overview/security/enabling-cross-origin-requests-in-web-api
                var cors = new EnableCorsAttribute(origins: "*", headers: "*", methods: "*")
                {
                    SupportsCredentials = true
                };

                config.EnableCors(cors);
            }

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
