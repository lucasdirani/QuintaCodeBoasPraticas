using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class CarefulNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.SpecialAttack;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.SpecialDefense;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Careful;
        }
    }
}