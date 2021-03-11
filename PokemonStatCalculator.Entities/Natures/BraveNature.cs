using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class BraveNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.Speed;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.Attack;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Brave;
        }
    }
}