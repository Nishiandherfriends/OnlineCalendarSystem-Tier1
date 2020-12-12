

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using OnlineCalendarSystem_Tier1.Data;

namespace OnlineCalendarSystem_Tier1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ApiHelper.GetApiClient(); // This is important so the API works properly.
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
