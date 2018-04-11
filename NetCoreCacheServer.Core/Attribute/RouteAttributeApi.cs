using Microsoft.AspNetCore.Mvc;
using NetCoreCacheServer.Core.Configration;

namespace NetCoreCacheServer.Core.Attribute
{
    public class RouteAttributeApi : RouteAttribute
    {
        public RouteAttributeApi(string template = "") : base(template)
        {
            template = ApplicationVariables.ApiDefaultRote;
        }
    }
}