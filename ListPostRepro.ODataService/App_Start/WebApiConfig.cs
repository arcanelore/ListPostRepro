using ListPostRepro.ODataService.Models;
using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace ListPostRepro.ODataService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //Make Routes Case Insensitive
            config.EnableCaseInsensitive(true);
            config.EnableUnqualifiedNameCall(true);

            // Base V1 OData Route
            var odataRoute = config.MapODataServiceRoute(
                routeName: "ODataRouteV1",
                routePrefix: "odata/v1/",
                model: GetModel());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        private static IEdmModel GetModel()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();

            builder.EntitySet<CreateList>("CreateListIndex");
            builder.EntitySet<CreateListValue>("CreateListIndexValue");
            builder.EntitySet<ListValue>("ListValue");

            return builder.GetEdmModel();
        }
    }
}
