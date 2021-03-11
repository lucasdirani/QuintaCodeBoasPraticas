using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class NaiveNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.SpecialDefense;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.Speed;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Naive;
        }
    }
}