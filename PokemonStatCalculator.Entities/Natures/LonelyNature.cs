using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class LonelyNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.Defense;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.Attack;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Lonely;
        }
    }
}