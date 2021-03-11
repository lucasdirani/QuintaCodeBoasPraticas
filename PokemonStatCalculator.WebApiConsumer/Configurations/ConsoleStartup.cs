using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PokemonStatCalculator.WebApiConsumer.Services;
using PokemonStatCalculator.WebApiConsumer.Services.Interfaces;
using PokemonStatCalculator.WebApiConsumer.Services.Polly;
using System;
using System.IO;

namespace PokemonStatCalculator.WebApiConsumer.Configurations
{
    public static class ConsoleStartup
    {
        public static IHost InitializeConfigurations()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName)
                .AddJsonFile("appsettings.json", optional: true)
                .Build();

            var builder = new HostBuilder()
               .ConfigureServices((hostContext, services) =>
               {
                   services.AddHttpClient();
                   services.Configure<ApiSettings>(config.GetSection("ApiSettings"));
                   services.AddTransient<IPokemonStatCalculatorApiAuthenticationService,PokemonStatCalculatorApiAuthenticationService>();
                   services.AddTransient<IPokemonStatCalculatorApiService, PokemonStatCalculatorApiService>();
                   services.AddTransient<IPokemonStatCalculatorPolicies, PokemonStatCalculatorPolicies>();
                   services.AddTransient<IPokemonStatCalculatorService, PokemonStatCalculatorService>();
               }).UseConsoleLifetime();

            return builder.Build();
        }
    }
}