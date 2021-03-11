namespace PokemonStatCalculator.DataAccess.DataModels.UserTrainedPokemonCollection
{
    public class UserTrainer
    {
        public UserTrainer()
        {
        }

        public UserTrainer(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}