using System;

namespace PokemonStatCalculator.DataAccess.DataModels.UserTrainedPokemonCollection
{
    public class UserTrainedPokemon
    {
        public UserTrainedPokemon()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public UserTrainer User { get; set; }

        public PokemonUserTrainedCollection Pokemon { get; set; }

        public TrainingUserTrainedCollection Training { get; set; }
    }
}