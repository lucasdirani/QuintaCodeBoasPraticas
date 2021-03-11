namespace PokemonStatCalculator.Entities.Stats
{
    public sealed class AttackStat : Stat
    {
        public AttackStat(int value)
            : base(value)
        {
        }

        public override PokemonStat Classification { get; protected set; } = PokemonStat.Attack;
    }
}