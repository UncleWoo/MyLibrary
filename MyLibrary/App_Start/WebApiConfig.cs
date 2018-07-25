using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MyLibrary
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "BooksApi",
                routeTemplate: "api/books",
                defaults: new { controller = "BookController", action = "GetAllBooks" }
                );

            config.Routes.MapHttpRoute(
                name: "BookIdApi",
                routeTemplate: "api/books/{id}",
                defaults: new { controller = "BookController", action = "GetBookById" },
                constraints: new { id = "[0-9]+" }
                );

            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
            config.Formatters.Remove(config.Formatters.XmlFormatter);



            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
