using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.WeatherConditions;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.Contact
{
    public sealed class ChangeWeatherConditionOnContactAbilityEffect : ContactAbilityEffect
    {
        public ChangeWeatherConditionOnContactAbilityEffect(
            WeatherConditionType newWeatherCondition,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            NewWeatherCondition = newWeatherCondition;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.ChangeWeatherConditionOnContact;

        public WeatherConditionType NewWeatherCondition { get; private set; }
    }
}