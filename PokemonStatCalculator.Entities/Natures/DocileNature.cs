using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class DocileNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.Defense;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.Defense;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Docile;
        }
    }
}