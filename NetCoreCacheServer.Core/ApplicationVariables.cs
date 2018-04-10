namespace NetCoreCacheServer.Core
{
    public static class ApplicationVariables
    {
        public static string ApiDefaultRote { get; } = "api/[controller]";
    }

    public enum ApiRegionKey
    {
        CacheApi = 1
    }
}