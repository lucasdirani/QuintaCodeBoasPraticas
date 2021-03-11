using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class QuietNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.Speed;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.SpecialAttack;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Quiet;
        }
    }
}