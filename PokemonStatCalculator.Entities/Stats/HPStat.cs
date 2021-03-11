namespace PokemonStatCalculator.Entities.Stats
{
    public sealed class HPStat : Stat
    {
        public HPStat(int value)
            : base(value)
        {
        }

        public override PokemonStat Classification { get; protected set; } = PokemonStat.HP;
    }
}