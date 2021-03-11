using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Entities.StatusConditions;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.Stats
{
    public sealed class StatusConditionStatIncreasingAbilityEffect : StatIncreasingAbilityEffect
    {
        public StatusConditionStatIncreasingAbilityEffect(
            IEnumerable<StatusConditionType> increasingBasedOnStatusConditions,
            IEnumerable<PokemonStat> increasingStats,
            Stage increasingStatsStage,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(increasingStats, increasingStatsStage, affectedBattleParticipants)
        {
            IncreasingBasedOnStatusConditions = increasingBasedOnStatusConditions;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.StatusConditionStatIncreasing;

        public IEnumerable<StatusConditionType> IncreasingBasedOnStatusConditions { get; private set; }
    }
}