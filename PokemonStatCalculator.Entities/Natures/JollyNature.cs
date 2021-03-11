using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class JollyNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.SpecialAttack;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.Speed;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Jolly;
        }
    }
}