using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace CameCaseSerialization
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // configure camel case serialization
            var json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new {id = RouteParameter.Optional});
        }
    }
}