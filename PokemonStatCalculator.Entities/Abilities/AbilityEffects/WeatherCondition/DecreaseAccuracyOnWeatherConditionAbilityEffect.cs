using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.WeatherConditions;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.WeatherCondition
{
    public sealed class DecreaseAccuracyOnWeatherConditionAbilityEffect : WeatherConditionAbilityEffect
    {
        public DecreaseAccuracyOnWeatherConditionAbilityEffect(
            Percentage decreaseAccuracyPercentage,
            WeatherConditionType decreaseAccuracyOn,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(decreaseAccuracyOn, affectedBattleParticipants)
        {
            DecreaseAccuracyPercentage = decreaseAccuracyPercentage;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.DecreaseAccuracyOnWeatherCondition;

        public Percentage DecreaseAccuracyPercentage { get; private set; }
    }
}