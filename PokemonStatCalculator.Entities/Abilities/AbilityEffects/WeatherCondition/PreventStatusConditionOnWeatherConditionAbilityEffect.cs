using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.StatusConditions;
using PokemonStatCalculator.Entities.WeatherConditions;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.WeatherCondition
{
    public sealed class PreventStatusConditionOnWeatherConditionAbilityEffect : WeatherConditionAbilityEffect
    {
        public PreventStatusConditionOnWeatherConditionAbilityEffect(
            IEnumerable<StatusConditionType> preventedStatusConditions,
            WeatherConditionType preventedStatusConditionsOn,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(preventedStatusConditionsOn, affectedBattleParticipants)
        {
            PreventedStatusConditions = preventedStatusConditions;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.PreventStatusConditionOnWeatherCondition;

        public IEnumerable<StatusConditionType> PreventedStatusConditions { get; private set; }
    }
}