using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.Contact
{
    public sealed class DecreaseStatsOnContactAbilityEffect : ContactAbilityEffect
    {
        public DecreaseStatsOnContactAbilityEffect(
            Stage statsDecreaseStage,
            IEnumerable<PokemonStat> decreasedStats,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            StatsDecreaseStage = statsDecreaseStage;
            DecreasedStats = decreasedStats;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.DecreaseStatsOnContact;

        public Stage StatsDecreaseStage { get; private set; }

        public IEnumerable<PokemonStat> DecreasedStats { get; private set; }
    }
}