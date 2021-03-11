using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class HastyNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.Defense;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.Speed;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Hasty;
        }
    }
}