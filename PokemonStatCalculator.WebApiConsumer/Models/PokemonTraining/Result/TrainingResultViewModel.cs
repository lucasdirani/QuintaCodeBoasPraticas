namespace PokemonStatCalculator.WebApiConsumer.Models.PokemonTraining.Result
{
    public class TrainingResultViewModel
    {
        public int Level { get; set; }

        public string Nature { get; set; }

        public StatResultViewModel EffortValues { get; set; }

        public StatResultViewModel IndividualValues { get; set; }

        public StatResultViewModel ResultedStats { get; set; }
    }
}