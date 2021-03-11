namespace PokemonStatCalculator.Entities.Stats
{
    public sealed class SpeedStat : Stat
    {
        public SpeedStat(int value)
            : base(value)
        {
        }

        public override PokemonStat Classification { get; protected set; } = PokemonStat.Speed;
    }
}