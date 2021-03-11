using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class NaughtyNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.SpecialDefense;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.Attack;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Naughty;
        }
    }
}