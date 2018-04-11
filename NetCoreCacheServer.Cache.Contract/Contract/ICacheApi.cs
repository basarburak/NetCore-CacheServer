using NetCoreStack.Contracts;
using NetCoreCacheServer.Core;
using NetCoreCacheServer.Cache.Contract.Abstract;
using NetCoreCacheServer.Core.Configration;

namespace NetCoreCacheServer.Cache.Contract.Contract
{
    [ApiRoute("api/[controller", regionKey: nameof(ApiRegionKey.CacheApi))]
    public interface ICacheApi : IApiContract
    {
        object Get(string key);
        object Set(string key, string value);
        void Remove(string key);
    }
}