using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreCacheServer.Cache.Contract.Contract;
using NetCoreCacheServer.Core.Controllers;
using NetCoreCacheServer.Core.CrossCuttingConcerns.Caching;

namespace NetCoreCacheServer.Cache.Hosting.Controllers
{
    [Route("api/[controller]")]
    public class CacheController : Controller, ICacheApi
    {
        private readonly ICacheManager _cacheManager;
        public CacheController(ICacheManager cacheManager)
        {
            _cacheManager = cacheManager;
        }

        [HttpGet(nameof(Get))]
        public object Get(string key)
        {
            return _cacheManager.Get(key);
        }

        [HttpDelete(nameof(Remove))]
        public void Remove(string key)
        {
            _cacheManager.Remove(key);
        }

        [HttpPost(nameof(Set))]
        public object Set(string key, string value)
        {
            return _cacheManager.Add(key, value);
        }
    }
}
