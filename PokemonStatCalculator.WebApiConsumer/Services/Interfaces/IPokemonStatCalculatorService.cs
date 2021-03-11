using PokemonStatCalculator.Utils.Monads.Results;
using PokemonStatCalculator.WebApiConsumer.Models.Authentication;
using PokemonStatCalculator.WebApiConsumer.Models.PokemonTraining;
using PokemonStatCalculator.WebApiConsumer.Models.PokemonTraining.Result;
using System.Threading.Tasks;

namespace PokemonStatCalculator.WebApiConsumer.Services.Interfaces
{
    public interface IPokemonStatCalculatorService
    {
        Task<Result<UserTrainedPokemonViewModel>> SubmitPokemonTrainingAsync(TrainingViewModel pokemonTraining, LoginUserViewModel loginUser);
    }
}