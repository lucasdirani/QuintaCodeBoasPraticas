namespace PokemonStatCalculator.WebApi
{
    public class AppSettings
    {
        public string Secret { get; set; }

        public int ExpirationInMinutes { get; set; }

        public string Issuer { get; set; }

        public string ValidIn { get; set; }
    }
}