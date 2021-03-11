using Microsoft.Extensions.Options;
using PokemonStatCalculator.WebApiConsumer.Configurations;
using PokemonStatCalculator.WebApiConsumer.Models.Authentication;
using PokemonStatCalculator.WebApiConsumer.Services.Interfaces;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PokemonStatCalculator.WebApiConsumer.Services
{
    public class PokemonStatCalculatorApiAuthenticationService : IPokemonStatCalculatorApiAuthenticationService
    {
        private readonly IHttpClientFactory httpClientFactory;

        private readonly ApiSettings apiSettings;

        private string bearerToken;

        public PokemonStatCalculatorApiAuthenticationService(
            IHttpClientFactory httpClientFactory,
            IOptions<ApiSettings> apiSettings)
        {
            this.httpClientFactory = httpClientFactory;
            this.apiSettings = apiSettings.Value;
        }

        public string GetBearerToken()
        {
            return bearerToken;
        }

        public async Task<UserAuthenticationResultViewModel> LoginAsync(string requestBody)
        {
            string endpointAddress = apiSettings.AuthLoginEndpoint;

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, endpointAddress)
            {
                Content = new StringContent(requestBody, Encoding.UTF8, "application/json")
            };

            HttpClient client = httpClientFactory.CreateClient();

            client.DefaultRequestHeaders.Add("Accept", "application/json");

            HttpResponseMessage responseMessage = await client.SendAsync(requestMessage);

            string responseContent = await responseMessage.Content.ReadAsStringAsync();

            HttpStatusCode responseStatusCode = responseMessage.StatusCode;

            if (!responseMessage.IsSuccessStatusCode)
            {
                return new UserAuthenticationResultViewModel(responseContent, authenticationIsSuccessful: false, responseStatusCode);
            }

            bearerToken = responseContent.Replace("\"", string.Empty);

            return new UserAuthenticationResultViewModel(bearerToken, authenticationIsSuccessful: true, responseStatusCode);
        }

        public async Task<UserAuthenticationResultViewModel> RegisterAsync(string requestBody)
        {
            string endpointAddress = apiSettings.AuthRegisterEndpoint;

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, endpointAddress)
            {
                Content = new StringContent(requestBody, Encoding.UTF8, "application/json")
            };

            HttpClient client = httpClientFactory.CreateClient();

            client.DefaultRequestHeaders.Add("Accept", "application/json");

            HttpResponseMessage responseMessage = await client.SendAsync(requestMessage);

            string responseContent = await responseMessage.Content.ReadAsStringAsync();

            HttpStatusCode responseStatusCode = responseMessage.StatusCode;

            if (!responseMessage.IsSuccessStatusCode)
            {
                return new UserAuthenticationResultViewModel(responseContent, authenticationIsSuccessful: false, responseStatusCode);
            }

            bearerToken = responseContent.Replace("\"", string.Empty);

            return new UserAuthenticationResultViewModel(bearerToken, authenticationIsSuccessful: true, responseStatusCode);
        }
    }
}