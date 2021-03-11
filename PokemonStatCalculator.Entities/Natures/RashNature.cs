using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class RashNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.SpecialDefense;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.SpecialAttack;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Rash;
        }
    }
}