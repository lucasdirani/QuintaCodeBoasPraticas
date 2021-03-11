using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.Stats
{
    public sealed class LostHPStatIncreasingAbilityEffect : StatIncreasingAbilityEffect
    {
        public LostHPStatIncreasingAbilityEffect(
            Percentage lostUserHPPercentageToActivate,
            IEnumerable<PokemonStat> increasingStats,
            Stage increasingStatsStage,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(increasingStats, increasingStatsStage, affectedBattleParticipants)
        {
            LostUserHPPercentageToActivate = lostUserHPPercentageToActivate;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.LostHPStatIncreasing;

        public Percentage LostUserHPPercentageToActivate { get; private set; }
    }
}