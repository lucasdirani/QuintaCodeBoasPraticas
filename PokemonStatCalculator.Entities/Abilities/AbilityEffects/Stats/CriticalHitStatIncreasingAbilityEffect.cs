using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.Stats
{
    public sealed class CriticalHitStatIncreasingAbilityEffect : StatIncreasingAbilityEffect
    {
        public CriticalHitStatIncreasingAbilityEffect(
            IEnumerable<PokemonStat> increasingStats,
            Stage increasingStatsStage,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(increasingStats, increasingStatsStage, affectedBattleParticipants)
        {
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.CriticalHitStatIncreasing;
    }
}