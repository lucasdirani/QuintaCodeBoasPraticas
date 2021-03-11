namespace PokemonStatCalculator.Entities.Stats
{
    public sealed class SpecialDefenseStat : Stat
    {
        public SpecialDefenseStat(int value)
            : base(value)
        {
        }

        public override PokemonStat Classification { get; protected set; } = PokemonStat.SpecialDefense;
    }
}