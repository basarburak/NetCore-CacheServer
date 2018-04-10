using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using NetCoreCacheServer.Core.CrossCuttingConcerns.Caching;
using NetCoreCacheServer.Core.CrossCuttingConcerns.Caching.MicrosoftCache;
using NetCoreCacheServer.Core.CrossCuttingConcerns.Caching.RedisCache;

namespace NetCoreCacheServer.Core.Extensions
{
    public static class CacheExtensions
    {
        public static void AddMicrosoftCache(this IServiceCollection services)
        {
            services.AddScoped<ICacheManager, MicrosoftCacheManager>();
        }

        public static void AddRedisCache(this IServiceCollection services)
        {
            services.AddScoped<ICacheManager, RedisCacheManager>();
        }
    }
}