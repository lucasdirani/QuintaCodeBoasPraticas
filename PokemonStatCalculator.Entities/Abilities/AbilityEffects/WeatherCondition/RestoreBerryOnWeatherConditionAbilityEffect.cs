using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.WeatherConditions;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.WeatherCondition
{
    public sealed class RestoreBerryOnWeatherConditionAbilityEffect : WeatherConditionAbilityEffect
    {
        public RestoreBerryOnWeatherConditionAbilityEffect(
            Percentage restoreBerryPercentage,
            WeatherConditionType restoreBerryOn,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(restoreBerryOn, affectedBattleParticipants)
        {
            RestoreBerryPercentage = restoreBerryPercentage;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.RestoreBerryOnWeatherCondition;

        public Percentage RestoreBerryPercentage { get; private set; }
    }
}