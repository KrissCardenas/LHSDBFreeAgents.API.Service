using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace LHSDBFreeAgentsAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .ConfigureLogging(logging =>
                {
                    // add built-in providers manually, as needed 
                    logging.AddAWSProvider();
                    logging.SetMinimumLevel(LogLevel.Debug);
                    logging.AddDebug();    // Allowed to debug
                    logging.AddConsole();  // Allowed to logs on console
                });
    }
}
