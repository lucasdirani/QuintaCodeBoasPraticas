using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class SeriousNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.Speed;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.Speed;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Serious;
        }
    }
}