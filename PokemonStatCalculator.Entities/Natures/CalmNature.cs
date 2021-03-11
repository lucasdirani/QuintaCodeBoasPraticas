using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class CalmNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.Attack;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.SpecialDefense;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Calm;
        }
    }
}