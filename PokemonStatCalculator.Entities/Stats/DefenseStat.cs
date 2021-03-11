namespace PokemonStatCalculator.Entities.Stats
{
    public sealed class DefenseStat : Stat
    {
        public DefenseStat(int value)
            : base(value)
        {
        }

        public override PokemonStat Classification { get; protected set; } = PokemonStat.Defense;
    }
}