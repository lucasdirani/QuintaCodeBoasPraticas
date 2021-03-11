using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.WeatherConditions;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.WeatherCondition
{
    public sealed class RecoverHPOnWeatherConditionAbilityEffect : WeatherConditionAbilityEffect
    {
        public RecoverHPOnWeatherConditionAbilityEffect(
            Percentage hpRecoverPercentage,
            WeatherConditionType recoverHPOn,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(recoverHPOn, affectedBattleParticipants)
        {
            HPRecoverPercentage = hpRecoverPercentage;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.RecoverHPOnWeatherCondition;

        public Percentage HPRecoverPercentage { get; private set; }
    }
}