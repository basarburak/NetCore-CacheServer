using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Extensions.DependencyInjection;
using NetCoreCacheServer.Core.Configration;
using static NetCoreCacheServer.Core.Configration.DevelopmentConfigration;

namespace NetCoreCacheServer.Core.Extensions
{
    public static class DevelopmentExtensions
    {
        private static Process process;
        private static string command = "start ";
        public static void StartBrowserSwaggerUI(this IServiceCollection services, string api, DevelopmentConfigration.Browser browser)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                command = command + nameof(browser);
                command = command + " " + api;
                command = command + " /swagger";

                process = new Process
                {
                    StartInfo = new ProcessStartInfo("cmd.exe", "/C " + command) { UseShellExecute = false }
                };

                process.Start();
            }
        }

        public static void StartBrowser(this IServiceCollection services, string api, DevelopmentConfigration.Browser browser)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                command = command + nameof(browser);
                command = command + " " + api;

                process = new Process
                {
                    StartInfo = new ProcessStartInfo("cmd.exe", "/C " + command) { UseShellExecute = false }
                };

                process.Start();
            }
        }
    }
}