using PokemonStatCalculator.Entities.Natures;
using PokemonStatCalculator.Entities.Pokemons;
using PokemonStatCalculator.Entities.Stats.EffortValues;
using PokemonStatCalculator.Entities.Stats.IndividualValues;

namespace PokemonStatCalculator.Entities.Train
{
    public sealed class Training
    {
        public Training(EffortValue effortValues, IndividualValue individualValues, Nature nature, PokemonLevel level)
        {
            EffortValues = effortValues;
            IndividualValues = individualValues;
            Nature = nature;
            Level = level;
        }

        public EffortValue EffortValues { get; private set; }

        public IndividualValue IndividualValues { get; private set; }

        public Nature Nature { get; private set; }

        public PokemonLevel Level { get; private set; }
    }
}