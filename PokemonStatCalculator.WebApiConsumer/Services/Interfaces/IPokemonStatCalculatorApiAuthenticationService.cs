using PokemonStatCalculator.WebApiConsumer.Models.Authentication;
using System.Threading.Tasks;

namespace PokemonStatCalculator.WebApiConsumer.Services.Interfaces
{
    public interface IPokemonStatCalculatorApiAuthenticationService
    {
        Task<UserAuthenticationResultViewModel> RegisterAsync(string requestBody);

        Task<UserAuthenticationResultViewModel> LoginAsync(string requestBody);

        string GetBearerToken();
    }
}