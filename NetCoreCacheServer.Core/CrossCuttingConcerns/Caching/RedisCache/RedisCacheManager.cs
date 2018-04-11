using System;
using System.Text;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace NetCoreCacheServer.Core.CrossCuttingConcerns.Caching.RedisCache
{
    public class RedisCacheManager : ICacheManager
    {
        private readonly IDistributedCache _distributedCache;
        public RedisCacheManager(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }
        public void Add(string key, object data, int cacheTime)
        {
            throw new NotImplementedException();
        }

        public object Add(string key, object data)
        {
            var _data = JsonConvert.SerializeObject(data);
            var _dataByte = Encoding.UTF8.GetBytes(_data);
            _distributedCache.Set(key.ToString(), _dataByte);
            return data;
        }

        public object Get(string key)
        {
            var data = _distributedCache.GetString(key.ToString());
            return JsonConvert.DeserializeObject<object>(data);
        }

        public bool IsAdd(string key)
        {
            if (_distributedCache.GetString(key.ToString()) == null)
            {
                return false;
            }
            return true;
        }

        public void Remove(string key)
        {
            _distributedCache.Remove(key.ToString());
        }
    }
}