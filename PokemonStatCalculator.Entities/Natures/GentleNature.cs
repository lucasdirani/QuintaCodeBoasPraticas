using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class GentleNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.Defense;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.SpecialDefense;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Gentle;
        }
    }
}