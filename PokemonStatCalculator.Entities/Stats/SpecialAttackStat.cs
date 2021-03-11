namespace PokemonStatCalculator.Entities.Stats
{
    public sealed class SpecialAttackStat : Stat
    {
        public SpecialAttackStat(int value)
            : base(value)
        {
        }

        public override PokemonStat Classification { get; protected set; } = PokemonStat.SpecialAttack;
    }
}