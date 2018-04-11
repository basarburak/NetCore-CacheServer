namespace NetCoreCacheServer.Core.Configration
{
    public static class ApplicationVariables
    {
        public static string ApiDefaultRote { get; } = "api/[controller]";
    }

    public enum ApiRegionKey
    {
        CacheApi = 1
    }
    public static class ApiConfigration
    {
        public static string CacheApiName { get; } = "Cache Api";
        public static string CacheApiVersion { get; } = "v1";
        public static string HostingApiName { get; } = "Hosting Api";
        public static string HostingApiVersion { get; } = "v1";
    }
    public static class RedisConfigration
    {
        public static string RedisServer { get; } = "127.0.0.1:6379";
        public static string InstanceName { get; } = "master";
    }

    public static class DevelopmentConfigration
    {
        public static string HostingApiUrl { get; } = "http://localhost:5051";
        public static string CacheApiUrl { get; } = "http://localhost:5050";
        public enum Browser
        {
            chrome = 1
        }
    }
}