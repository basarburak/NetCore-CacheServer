namespace NetCoreCacheServer.Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        object Get(string key);
        void Add(string key, object data, int cacheTime);
        object Add(string key, object data);
        bool IsAdd(string key);
        void Remove(string key);
    }
}