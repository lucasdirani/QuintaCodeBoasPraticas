using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class BoldNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.Attack;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.Defense;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Bold;
        }
    }
}