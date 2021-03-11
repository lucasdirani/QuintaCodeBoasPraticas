using PokemonStatCalculator.Utils.Monads.Results;
using System.Threading.Tasks;

namespace PokemonStatCalculator.WebApiConsumer.Services.Interfaces
{
    public interface IPokemonStatCalculatorApiService
    {
        Task<Result<string>> ApplyPokemonTraining(string requestBody, string requestToken);
    }
}