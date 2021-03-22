using Newtonsoft.Json;
using PokemonStatCalculator.Utils.Monads.Results;
using PokemonStatCalculator.WebApiConsumer.Models.Authentication;
using PokemonStatCalculator.WebApiConsumer.Models.PokemonTraining;
using PokemonStatCalculator.WebApiConsumer.Models.PokemonTraining.Result;
using PokemonStatCalculator.WebApiConsumer.Services.Interfaces;
using PokemonStatCalculator.WebApiConsumer.Services.Polly;
using System.Net.Http;
using System.Threading.Tasks;

namespace PokemonStatCalculator.WebApiConsumer.Services
{
    public class PokemonStatCalculatorService : IPokemonStatCalculatorService
    {
        private readonly IPokemonStatCalculatorApiAuthenticationService apiAuthenticationService;

        private readonly IPokemonStatCalculatorApiService apiService;

        private readonly IPokemonStatCalculatorPolicies apiPolicies;

        private UserAuthenticationResultViewModel authenticationResult;

        public PokemonStatCalculatorService(
            IPokemonStatCalculatorApiAuthenticationService apiAuthenticationService,
            IPokemonStatCalculatorApiService apiService,
            IPokemonStatCalculatorPolicies apiPolicies)
        {
            this.apiAuthenticationService = apiAuthenticationService;
            this.apiService = apiService;
            this.apiPolicies = apiPolicies;
        }

        public async Task<Result<UserTrainedPokemonViewModel>> SubmitPokemonTrainingAsync(
            TrainingViewModel pokemonTraining,
            LoginUserViewModel loginUser)
        {
            authenticationResult ??= await apiAuthenticationService.LoginAsync(JsonConvert.SerializeObject(loginUser));

            #if DEBUG
                authenticationResult = new UserAuthenticationResultViewModel(Properties.Resources.TokenExpirado);
            #endif

            var pokemonTrainingPolicy = apiPolicies.CreateRetryExecuteAsyncPolicyFor<HttpRequestException, Result<string>>(
                onRetryAsync: async() => authenticationResult = await apiAuthenticationService.LoginAsync(JsonConvert.SerializeObject(loginUser)),
                handler: unauthorizedEx => unauthorizedEx.Message.Contains("401 Unauthorized"),
                onExecuteAsync: async() => await apiService.ApplyPokemonTraining(JsonConvert.SerializeObject(pokemonTraining), authenticationResult.ResponseContent)
            );

            Result<string> applyPokemonTrainingResult = await pokemonTrainingPolicy;

            if (applyPokemonTrainingResult.Failure)
            {
                return Result.Fail<UserTrainedPokemonViewModel>(applyPokemonTrainingResult.Errors);
            }

            return Result.Success(JsonConvert.DeserializeObject<UserTrainedPokemonViewModel>(applyPokemonTrainingResult.Value));
        }
    }
}