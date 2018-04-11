using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreCacheServer.Cache.Contract.Contract;
using NetCoreCacheServer.Core.Controllers;

namespace NetCoreCacheServer.Hosting.Controllers
{
    [Route("api/[controller]")]
    public class CacheTestController : Controller
    {
        private readonly ICacheApi _cacheApi;
        public CacheTestController(ICacheApi cacheApi)
        {
            _cacheApi = cacheApi;
        }

        [HttpGet("{key}")]
        public object Get(string key)
        {
            return _cacheApi.Get(key);
        }

        [HttpDelete("key")]
        public void Delete(string key)
        {
            _cacheApi.Remove(key);
        }

        [HttpPost("{key}/{value}")]
        public object Post(string key, string value)
        {
            return _cacheApi.Set(key, value);
        }
    }
}
