namespace PokemonStatCalculator.WebApi.Models.PokemonTraining
{
    public class TrainingViewModel
    {
        public PokemonViewModel PokemonToBeTrained { get; set; }

        public NatureViewModel Nature { get; set; }

        public LevelViewModel Level { get; set; }

        public EffortValueViewModel EffortValues { get; set; }

        public IndividualValueViewModel IndividualValues { get; set; }

        public UserTrainingViewModel UserTraining { get; set; }
    }
}