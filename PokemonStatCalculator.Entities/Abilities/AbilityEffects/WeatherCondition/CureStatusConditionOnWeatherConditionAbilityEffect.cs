using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.StatusConditions;
using PokemonStatCalculator.Entities.WeatherConditions;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.WeatherCondition
{
    public sealed class CureStatusConditionOnWeatherConditionAbilityEffect : WeatherConditionAbilityEffect
    {
        public CureStatusConditionOnWeatherConditionAbilityEffect(
            IEnumerable<StatusConditionType> curedStatusConditions,
            Percentage cureStatusConditionsPercentage,
            WeatherConditionType curedStatusConditionOn,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(curedStatusConditionOn, affectedBattleParticipants)
        {
            CuredStatusConditions = curedStatusConditions;
            CureStatusConditionsPercentage = cureStatusConditionsPercentage;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.CureStatusConditionOnWeatherCondition;

        public IEnumerable<StatusConditionType> CuredStatusConditions { get; private set; }

        public Percentage CureStatusConditionsPercentage { get; private set; }
    }
}