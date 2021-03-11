using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class SassyNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.Speed;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.SpecialDefense;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Sassy;
        }
    }
}