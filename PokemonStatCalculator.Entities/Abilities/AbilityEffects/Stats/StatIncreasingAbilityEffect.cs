using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.Stats
{
    public abstract class StatIncreasingAbilityEffect : AbilityEffect
    {
        protected StatIncreasingAbilityEffect(
            IEnumerable<PokemonStat> increasingStats,
            Stage increasingStatsStage,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            IncreasingStats = increasingStats;
            IncreasingStatsStage = increasingStatsStage;
        }

        public IEnumerable<PokemonStat> IncreasingStats { get; protected set; }

        public Stage IncreasingStatsStage { get; protected set; }
    }
}