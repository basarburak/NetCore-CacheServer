using System;
using Microsoft.Extensions.Caching.Memory;

namespace NetCoreCacheServer.Core.CrossCuttingConcerns.Caching.MicrosoftCache
{
    public class MicrosoftCacheManager : ICacheManager
    {
        private IMemoryCache _cache;
        public MicrosoftCacheManager(IMemoryCache cache)
        {
            _cache = cache;
        }

        public void Add(string key, object data, int cacheTime)
        {
            var date = DateTimeOffset.Now + TimeSpan.FromDays(cacheTime);
            _cache.Set(key, data, date);
        }

        public object Add(string key, object data)
        {
            var date = DateTimeOffset.Now + TimeSpan.FromDays(60);
            _cache.Set(key, data, date);
            return data;
        }

        public object Get(string key)
        {
            return _cache.Get<object>(key);
        }

        public bool IsAdd(string key)
        {
            if (_cache.Get(key) != null)
            {
                return true;
            }
            return false;
        }

        public void Remove(string key)
        {
            _cache.Remove(key);
        }
    }
}