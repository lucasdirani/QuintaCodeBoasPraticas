using System.Diagnostics.CodeAnalysis;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects
{
    public static class AbilityEffectParser
    {
        public static bool TryParse<T>([NotNull] AbilityEffect abilityEffect, [AllowNull] out T result)
            where T : AbilityEffect
        {
            result = abilityEffect is T ? abilityEffect as T : default;

            return result != default;
        }
    }
}