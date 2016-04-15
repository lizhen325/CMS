using Microsoft.Practices.Unity;
using Newtonsoft.Json.Serialization;
using System.Net.Http.Headers;
using System.Web.Http;
using CMS.Repository;
using Microsoft.Practices.Unity.WebApi;

namespace CMS
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();
            container.RegisterType<IBookingRepository, BookingRepository>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityDependencyResolver(container);

            config.MapHttpAttributeRoutes();

            // api controller return JSON
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            // Use camel case for JSON data.
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
