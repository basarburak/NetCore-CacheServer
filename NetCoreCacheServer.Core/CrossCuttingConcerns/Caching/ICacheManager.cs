namespace NetCoreCacheServer.Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);
        void Add(string key, object data, int cacheTime);
        void Add(string key, object data);
        bool IsAdd(string key);
        void Remove(string key);
    }
}