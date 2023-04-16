using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace API.Ocelot
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
                    webBuilder.ConfigureAppConfiguration((hostingContext, config) =>
                    {
                        config.AddJsonFile("ocelot.json"); // Add your Ocelot configuration file here
                    })
                    .ConfigureServices(services =>
                    {
                        services.AddControllers(); // Register controllers
                        services.AddOcelot(); // Add Ocelot services
                    })
                    .Configure(app =>
                    {
                        app.UseRouting();
                        app.UseEndpoints(endpoints =>
                        {
                            endpoints.MapControllers();
                            endpoints.MapGet("/", async context =>
                            {
                                await context.Response.WriteAsync("Welcome to the Fairy Packages Ocelot gateway!");
                            });
                        });

                        app.UseOcelot().Wait(); // Use Ocelot middleware
                    });
                });
    }
}
