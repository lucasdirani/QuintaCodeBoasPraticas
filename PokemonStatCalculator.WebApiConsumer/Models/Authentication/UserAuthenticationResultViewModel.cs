using System.Net;

namespace PokemonStatCalculator.WebApiConsumer.Models.Authentication
{
    public class UserAuthenticationResultViewModel
    {
        public UserAuthenticationResultViewModel(
            string responseContent,
            bool authenticationIsSuccessful,
            HttpStatusCode statusCode)
        {
            ResponseContent = responseContent;
            AuthenticationIsSuccessful = authenticationIsSuccessful;
            StatusCode = statusCode;
        }

        public UserAuthenticationResultViewModel(string responseContent)
        {
            ResponseContent = responseContent;
            AuthenticationIsSuccessful = true;
            StatusCode = HttpStatusCode.OK;
        }

        public string ResponseContent { get; private set; }

        public bool AuthenticationIsSuccessful { get; private set; }

        public HttpStatusCode StatusCode { get; private set; }
    }
}