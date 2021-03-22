using System;

namespace PokemonStatCalculator.WebApiConsumer.Models.PokemonTraining.Result
{
    public class UserTrainedPokemonViewModel
    {
        public Guid Id { get; set; }

        public UserTrainerResultViewModel User { get; set; }

        public PokemonResultViewModel Pokemon { get; set; }

        public TrainingResultViewModel Training { get; set; }
    }
}