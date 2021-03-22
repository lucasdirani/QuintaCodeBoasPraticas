using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using PokemonStatCalculator.WebApiConsumer.Configurations;
using PokemonStatCalculator.WebApiConsumer.Models.Authentication;
using PokemonStatCalculator.WebApiConsumer.Models.PokemonTraining;
using PokemonStatCalculator.WebApiConsumer.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace PokemonStatCalculator.WebApiConsumer
{
    public class Program
    {
        public static async Task Main()
        {
            IHost applicationHost = ConsoleStartup.InitializeConfigurations();

            using IServiceScope serviceScope = applicationHost.Services.CreateScope();

            IServiceProvider serviceProvider = serviceScope.ServiceProvider;

            var apiConsumer = serviceProvider.GetRequiredService<IPokemonStatCalculatorService>();

            string loginJSON = Properties.Resources.LoginJSON;

            string pokemonTrainingJSON = Properties.Resources.PokemonTrainingJSON;

            var result = await apiConsumer.SubmitPokemonTrainingAsync(
                pokemonTraining: JsonConvert.DeserializeObject<TrainingViewModel>(pokemonTrainingJSON), 
                loginUser: JsonConvert.DeserializeObject<LoginUserViewModel>(loginJSON)
            );

            if (result.IsSuccess)
            {
                Console.WriteLine(JsonConvert.SerializeObject(result.Value));

                Console.ReadKey();
            }
        }
    }
}