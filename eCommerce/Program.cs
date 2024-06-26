using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;
namespace eCommerce
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var app = CreateHostBuilder(args).Build();
            var task = app.RunAsync();
            await task;
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureKestrel(options => options.AddServerHeader = true);
                    webBuilder.UseStartup<Startup>();
                });
    }
}
