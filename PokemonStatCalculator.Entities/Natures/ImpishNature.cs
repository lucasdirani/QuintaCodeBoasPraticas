using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class ImpishNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.SpecialAttack;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.Defense;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Impish;
        }
    }
}