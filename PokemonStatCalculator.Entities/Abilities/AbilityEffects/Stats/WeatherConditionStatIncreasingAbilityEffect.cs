using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Entities.WeatherConditions;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.Stats
{
    public sealed class WeatherConditionStatIncreasingAbilityEffect : StatIncreasingAbilityEffect
    {
        public WeatherConditionStatIncreasingAbilityEffect(
            WeatherConditionType increasingBasedOnWeatherCondition,
            IEnumerable<PokemonStat> increasingStats,
            Stage increasingStatsStage,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(increasingStats, increasingStatsStage, affectedBattleParticipants)
        {
            IncreasingBasedOnWeatherCondition = increasingBasedOnWeatherCondition;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.WeatherConditionStatIncreasing;

        public WeatherConditionType IncreasingBasedOnWeatherCondition { get; private set; }
    }
}