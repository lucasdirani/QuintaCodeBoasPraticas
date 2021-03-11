using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.Stats
{
    public sealed class DamageOfTypeStatIncreasingAbilityEffect : StatIncreasingAbilityEffect
    {
        public DamageOfTypeStatIncreasingAbilityEffect(
            IEnumerable<PokemonType> damageTypesThatActivesStatIncreasing,
            IEnumerable<PokemonStat> increasingStats,
            Stage increasingStatsStage,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(increasingStats, increasingStatsStage, affectedBattleParticipants)
        {
            DamageTypesThatActivesStatIncreasing = damageTypesThatActivesStatIncreasing;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.DamageOfTypeStatIncreasing;

        public IEnumerable<PokemonType> DamageTypesThatActivesStatIncreasing { get; private set; }
    }
}