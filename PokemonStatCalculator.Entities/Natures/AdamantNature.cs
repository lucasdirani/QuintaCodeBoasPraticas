using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class AdamantNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.SpecialAttack;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.Attack;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Adamant;
        }
    }
}