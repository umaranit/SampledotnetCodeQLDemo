using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace SimpleFeedReader
{
    public class Program
    {
        // test comment
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
