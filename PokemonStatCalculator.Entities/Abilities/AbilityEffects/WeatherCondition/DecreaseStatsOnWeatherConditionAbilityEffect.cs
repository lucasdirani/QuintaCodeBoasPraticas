using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Entities.WeatherConditions;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.WeatherCondition
{
    public sealed class DecreaseStatsOnWeatherConditionAbilityEffect : WeatherConditionAbilityEffect
    {
        public DecreaseStatsOnWeatherConditionAbilityEffect(
            Stage statsDecreaseStage,
            IEnumerable<PokemonStat> decreasedStats,
            WeatherConditionType decreasedStatsOn,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(decreasedStatsOn, affectedBattleParticipants)
        {
            StatsDecreaseStage = statsDecreaseStage;
            DecreasedStats = decreasedStats;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.DecreaseStatsOnWeatherCondition;

        public Stage StatsDecreaseStage { get; private set; }

        public IEnumerable<PokemonStat> DecreasedStats { get; private set; }
    }
}