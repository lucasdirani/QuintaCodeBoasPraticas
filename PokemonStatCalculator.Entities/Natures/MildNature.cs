using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Natures
{
    internal sealed class MildNature : Nature
    {
        public override PokemonStat GetDecreasedStat()
        {
            return PokemonStat.Defense;
        }

        public override PokemonStat GetIncreasedStat()
        {
            return PokemonStat.SpecialAttack;
        }

        public override NatureType GetNatureType()
        {
            return NatureType.Mild;
        }
    }
}