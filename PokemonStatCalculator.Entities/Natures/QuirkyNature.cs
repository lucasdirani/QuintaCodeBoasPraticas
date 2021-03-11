using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class QuirkyNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.SpecialDefense;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.SpecialDefense;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Quirky;
        }
    }
}