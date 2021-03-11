using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class ModestNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.Attack;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.SpecialAttack;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Modest;
        }
    }
}