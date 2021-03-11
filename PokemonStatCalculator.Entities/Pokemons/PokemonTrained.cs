using PokemonStatCalculator.Entities.Stats.TrainedStats;
using PokemonStatCalculator.Entities.Train;

namespace PokemonStatCalculator.Entities.Pokemons
{
    public sealed class PokemonTrained
    {
        public PokemonTrained(Pokemon pokemon, TrainedStat trainedStats, Training appliedTraining)
        {
            Pokemon = pokemon;
            TrainedStats = trainedStats;
            AppliedTraining = appliedTraining;
        }

        public Pokemon Pokemon { get; private set; }

        public TrainedStat TrainedStats { get; private set; }

        public Training AppliedTraining { get; private set; }
    }
}