namespace PokemonStatCalculator.WebApiConsumer.Models.PokemonTraining
{
    public class UserTrainingViewModel
    {
        public UserTrainingViewModel()
        {
        }

        public UserTrainingViewModel(string username, string userEmail)
        {
            Username = username;
            UserEmail = userEmail;
        }

        public string Username { get; set; }

        public string UserEmail { get; set; }
    }
}