using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class RelaxedNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.Speed;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.Defense;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Relaxed;
        }
    }
}