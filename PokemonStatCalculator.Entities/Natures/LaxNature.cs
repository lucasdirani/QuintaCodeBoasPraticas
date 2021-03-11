using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class LaxNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.SpecialDefense;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.Defense;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Lax;
        }
    }
}