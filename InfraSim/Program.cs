using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using InfraSim.Models.Capability;
using InfraSim.Models.Server;
using InfraSim.Models.Mediator;

namespace InfraSim
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
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<IServerCapability, ServerCapability>();
                    services.AddSingleton<ICapabilityFactory, ServerCapability>();
                    services.AddSingleton<IServerFactory, ServerFactory>();
                    services.AddSingleton<IInfrastructureMediator, InfrastructureMediator>();
                });
    }
}
