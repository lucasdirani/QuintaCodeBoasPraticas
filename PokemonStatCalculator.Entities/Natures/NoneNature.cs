using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class NoneNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.None;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.None;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.None;
        }
    }
}