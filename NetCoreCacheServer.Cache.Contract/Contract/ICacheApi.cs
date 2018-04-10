using NetCoreStack.Contracts;
using NetCoreCacheServer.Core;
using NetCoreCacheServer.Cache.Contract.Abstract;

namespace NetCoreCacheServer.Cache.Contract.Contract
{
    public interface ICacheApi : ICacheApiRoute
    {
        object Get(string key);
        object Set(string key, string value);
        object Remove(string key, string value);
    }
}