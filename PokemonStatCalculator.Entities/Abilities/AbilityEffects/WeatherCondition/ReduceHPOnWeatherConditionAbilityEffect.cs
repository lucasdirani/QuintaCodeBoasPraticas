using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.WeatherConditions;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.WeatherCondition
{
    public sealed class ReduceHPOnWeatherConditionAbilityEffect : WeatherConditionAbilityEffect
    {
        public ReduceHPOnWeatherConditionAbilityEffect(
            Percentage hpReducePercentage,
            WeatherConditionType reduceHPOn,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(reduceHPOn, affectedBattleParticipants)
        {
            HPReducePercentage = hpReducePercentage;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.ReduceHPOnWeatherCondition;

        public Percentage HPReducePercentage { get; private set; }
    }
}