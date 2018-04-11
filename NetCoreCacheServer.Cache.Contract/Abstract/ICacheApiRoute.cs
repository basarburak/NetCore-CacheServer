using NetCoreCacheServer.Core;
using NetCoreCacheServer.Core.Configration;
using NetCoreStack.Contracts;

namespace NetCoreCacheServer.Cache.Contract.Abstract
{
    [ApiRoute("api/[controller]", nameof(ApiRegionKey.CacheApi))]
    public interface ICacheApiRoute
    {
         
    }
}