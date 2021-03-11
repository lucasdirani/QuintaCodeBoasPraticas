using Microsoft.Extensions.Options;
using PokemonStatCalculator.Utils.Monads.Results;
using PokemonStatCalculator.WebApiConsumer.Configurations;
using PokemonStatCalculator.WebApiConsumer.Services.Interfaces;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PokemonStatCalculator.WebApiConsumer.Services
{
    public class PokemonStatCalculatorApiService : IPokemonStatCalculatorApiService
    {
        private readonly IHttpClientFactory httpClientFactory;

        private readonly ApiSettings apiSettings;

        public PokemonStatCalculatorApiService(IHttpClientFactory httpClientFactory, IOptions<ApiSettings> apiSettings)
        {
            this.httpClientFactory = httpClientFactory;
            this.apiSettings = apiSettings.Value;
        }

        public async Task<Result<string>> ApplyPokemonTraining(string requestBody, string requestToken)
        {
            string endpointAddress = apiSettings.PokemonTrainingEndpoint;

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, endpointAddress)
            {
                Content = new StringContent(requestBody, Encoding.UTF8, "application/json")
            };

            HttpClient client = httpClientFactory.CreateClient();

            client.DefaultRequestHeaders.Add("Accept", "application/json");

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", requestToken);

            HttpResponseMessage responseMessage = await client.SendAsync(requestMessage);

            string responseContent = await responseMessage.Content.ReadAsStringAsync();

            if (responseMessage.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new HttpRequestException(message: "401 Unauthorized");
            }

            if (responseMessage.StatusCode == HttpStatusCode.BadRequest)
            {
                return Result.Fail<string>(responseContent);
            }

            return Result.Success(responseContent);
        }
    }
}