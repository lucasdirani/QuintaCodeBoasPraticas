using System.ComponentModel;

namespace PokemonStatCalculator.Entities.Stats
{
    public enum PokemonStat
    {
        None,
        [Description("HP")]
        HP,
        [Description("Attack")]
        Attack,
        [Description("Defense")]
        Defense,
        [Description("Special Attack")]
        SpecialAttack,
        [Description("Special Defense")]
        SpecialDefense,
        [Description("Speed")]
        Speed,
        Accuracy,
        Evasion,
    }
}