using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class TimidNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.Attack;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.Speed;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Timid;
        }
    }
}