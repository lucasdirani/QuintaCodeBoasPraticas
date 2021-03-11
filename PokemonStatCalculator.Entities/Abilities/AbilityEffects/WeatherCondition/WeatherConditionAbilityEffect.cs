using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.WeatherConditions;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.WeatherCondition
{
    public abstract class WeatherConditionAbilityEffect : AbilityEffect
    {
        protected WeatherConditionAbilityEffect(
            WeatherConditionType activatedWeatherCondition,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            ActivatedWeatherCondition = activatedWeatherCondition;
        }

        public WeatherConditionType ActivatedWeatherCondition { get; protected set; }
    }
}