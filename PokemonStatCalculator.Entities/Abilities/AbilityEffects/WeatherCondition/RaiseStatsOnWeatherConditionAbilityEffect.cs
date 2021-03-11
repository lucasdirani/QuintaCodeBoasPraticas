using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Entities.WeatherConditions;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.WeatherCondition
{
    public sealed class RaiseStatsOnWeatherConditionAbilityEffect : WeatherConditionAbilityEffect
    {
        public RaiseStatsOnWeatherConditionAbilityEffect(
            Stage statsRaiseStage,
            IEnumerable<PokemonStat> raisedStats,
            WeatherConditionType raisedOn,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(raisedOn, affectedBattleParticipants)
        {
            StatsRaiseStage = statsRaiseStage;
            RaisedStats = raisedStats;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.RaiseStatsOnWeatherCondition;

        public Stage StatsRaiseStage { get; private set; }

        public IEnumerable<PokemonStat> RaisedStats { get; private set; }
    }
}