using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class BashfulNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.SpecialAttack;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.SpecialAttack;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Bashful;
        }
    }
}