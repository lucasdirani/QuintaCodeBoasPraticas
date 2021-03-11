using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.Stats
{
    public sealed class DecreaseStatUserStatIncreasingAbilityEffect : StatIncreasingAbilityEffect
    {
        public DecreaseStatUserStatIncreasingAbilityEffect(
            IEnumerable<PokemonStat> decreasedStatsThatActivatesStatIncreasing,
            IEnumerable<PokemonStat> increasingStats,
            Stage increasingStatsStage,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(increasingStats, increasingStatsStage, affectedBattleParticipants)
        {
            DecreasedStatsThatActivatesStatIncreasing = decreasedStatsThatActivatesStatIncreasing;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.DecreaseStatUserStatIncreasing;

        public IEnumerable<PokemonStat> DecreasedStatsThatActivatesStatIncreasing { get; private set; }
    }
}