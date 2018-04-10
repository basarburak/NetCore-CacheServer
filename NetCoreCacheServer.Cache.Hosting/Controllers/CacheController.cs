using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreCacheServer.Cache.Contract.Contract;

namespace NetCoreCacheServer.Cache.Hosting.Controllers
{
    public class CacheController : BaseController, ICacheApi
    {
        [HttpGet(nameof(Get))]
        public object Get(string key)
        {
            throw new NotImplementedException();
        }
        
        [HttpDelete(nameof(Remove))]
        public object Remove(string key, string value)
        {
            throw new NotImplementedException();
        }

        [HttpPost(nameof(Set))]
        public object Set(string key, string value)
        {
            throw new NotImplementedException();
        }
    }
}
