using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class HardyNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.Attack;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.Attack;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Hardy;
        }
    }
}